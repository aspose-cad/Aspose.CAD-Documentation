---
title: איך להריץ את דימוי ה-Docker של Aspose.CAD בפונקציית Azure
type: docs
description: "הרץ את דימוי ה-Docker של Aspose.CAD בפונקציית Azure."
weight: 73
url: /he/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## דרישות מוקדמות
- Docker חייב להיות מותקן במערכת שלך. למידע איך להתקין את Docker ב-Windows או Mac, עיין בקישורים בחלק "ראו גם".
- Visual Studio 2022.
- SDK של NET 6 משמש בדוגמה.
- Postman

## פונקציית Azure

בדוגמה זו, אתה יוצר פונקציה פשוטה להמרה שממירה קובץ CAD וש保存 אותו כדימוי. האפליקציה יכולה להיבנות אז ב-Docker ולהתבצע בפונקציית Azure.

## יצירת פונקציית Azure

כדי ליצור את תוכנית פונקציית Azure, בצע את השלבים הבאים:
1. לאחר ש-Docker מותקן, ודא שהוא משתמש במיכלים של Linux (ברירת מחדל). אם יש צורך, בחר באפשרות "החלף למיכלים של Linux" מתוך תפריט שולחן עבודה של Docker.
1. ב-Virtual Studio, צור פונקציית Azure NET 6.<br>
![דיאלוג פרויקט פונקציית Azure NET 6](/cad/_assets/showcases/azure/Create-project.png)<br>
1. מידע נוסף.<br>
![דיאלוג פרויקט פונקציית Azure NET 6](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. התקן את הגירסה האחרונה של Aspose.CAD מ-NuGet.<br>
![Aspose.CAD ב-NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. מכיוון שהאפליקציה תרוץ על Linux, ייתכן שיהיה צורך להתקין גופנים נוספים. תוכל להעדיף את ttf-mscorefonts-installer.
1. כאשר כל התלויות הנדרשות נוספו, כתוב תוכנית פשוטה שיוצרת אליפסה וש保存 אותה כדימוי:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("הפונקציה של.trigger ב-C# עיבדה בקשה.");
        try
        {
            using (var image = (CadImage)Image.Load(req.Body))
            {
                var ms = new MemoryStream();
                image.Save(ms, new PngOptions());

                ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);

                return new FileContentResult(ms.ToArray(), "application/octet-stream")
                {
                    FileDownloadName = "Export.png"
                };
            }
        }
        catch (Exception e)
        {
            return new OkObjectResult(e.Message);
        }
    }
}
{{< /highlight >}}

### הגדרת Dockerfile

השלב הבא הוא ליצור ולהגדיר את Dockerfile בתיקייה של פרויקט השורש.

1. צור את ה-Dockerfile והנח אותו ליד קובץ הפתרון של האפליקציה שלך. שמור על שם זה בלי סיומת (ברירת מחדל).
![תיקיית הפרויקט השורש](/cad/_assets/showcases/azure/root-folder.png)<br>
1. בקובץ Dockerfile, ציין:

{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
WORKDIR "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

הנ"ל הוא Dockerfile פשוט, המכיל את ההוראות הבאות:

- התמונה של ה-SDK שתשמש. כאן זו התמונה של Net 6. Docker יוריד אותה כאשר תתבצע הבנייה. הגירסה של ה-SDK מצוינת בתור תג.
- לאחר מכן, ייתכן שצריך להתקין גופנים כי התמונה של ה-SDK מכילה מאוד קומץ של גופנים. כמו כן, תוכל להשתמש בגופנים מקומיים מועתקים לתמונה של Docker.
- תיקיית העבודה, שהיא מצוינת בשורה הבאה.
- הפקודה להעתיק את כל מה שצריך לקונטיינר, לפרסם את האפליקציה ולציין את נקודת הכניסה.

## Docker Hub
1. התחבר ל-Docker Hub
1. צור מאגר ציבורי

## בניית והרצת האפליקציה ב-Docker

עכשיו האפליקציה יכולה להיבנות ולהתבצע ב-Docker. פתח את שורת הפקודה המועדפת עליך, החלף תיקיה לתיקייה שבה נמצאת האפליקציה (תיקיה שבה נמצא קובץ הפתרון וקובץ ה-Dockerfile) והרץ את הפקודה הבאה:

{{< highlight plain >}}
//דוגמה
docker build -t <שם משתמש>/<שם מאגר> .

docker build -t user/asposefunction .
{{< /highlight >}}

בפעם הראשונה שתהריץ את הפקודה הזו, זה עלול לקחת יותר זמן כי Docker יצטרך להוריד את התמונות הנדרשות. לאחר שהפקודה הקודמת מסתיימת, הרץ את הפקודה הבאה כדי לדחוף את התמונה ל-Docker Hub:

{{< highlight plain >}}
//דוגמה
docker push <שם משתמש>/<שם מאגר>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. התחבר ל-Azure.
1. בחר בשירותי Azure.
1. בחר באפליקציית פונקציה וצור פונקציה.<br>
![כפתור יצירת פונקציה ב-Azure](/cad/_assets/showcases/azure/create-function.png)<br>
1. שיחזר את ההגדרות הבסיסיות כפי שמוצג בתמונה למטה.<br>
![הגדרות יצירת פונקציה ב-Azure](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. לחץ על 'סקירה + צור' -> צור.
1. חכה לסיום הפריסה.
1. לחץ על כפתור 'עבור למשאב'.<br>
![כפתור משאב](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. עצור את פונקציית aspose-cad-docker-example.<br>
![עצור קונטיינר](/cad/_assets/showcases/azure/stop-container.png)<br>
1. עבור לתפריט מרכז הפריסה והגדר את ההגדרות המתאימות.<br>
![מרכז פריסה](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. שמור הגדרות
1. העתק את ה-URL של Webhook מהגדרות מרכז הפריסה.<br>
![Webhook url](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. עבור ל-Docker Hub, בחר את המאגר שלך ובחר ב-webhooks.
1. הדבק את ה-'Webhook url' מ-Azure בתיבת ה-webhook של Docker Hub והספק שם.<br>
![הגדרות Webhook ב-docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. לחץ על כפתור יצירה.
1. חזור לתצוגת הפונקציה Azure והפעל את הקונטיינר.<br>
![תפריט תצוגה](/cad/_assets/showcases/azure/overview.png)<br>

## דוגמת ביצוע

1. הגדרות Postman.<br>
![תפריט תצוגה](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. בחר כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. לחץ על כפתור שלח.

{{% alert color="primary" %}} 
אם התשובה מצליחה, לחץ על שמירה לקובץ ותשיג את הקובץ המומר בפורמט png
{{% /alert %}}

## דוגמאות נוספות

למידע נוסף על איך תוכל להשתמש ב-Aspose.CAD ב-Docker, ראה את [הדוגמאות](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## גם ראה

- [התקנת Docker Desktop על Windows](https://docs.docker.com/docker-for-windows/install/)
- [התקנת Docker Desktop על Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [החלף למיכלים של Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) אפשרות
- מידע נוסף על [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
