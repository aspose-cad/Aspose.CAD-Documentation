---
title: איך להריץ את דוקר אספוז.CAD בענן גוגל
type: docs
description: "הרץ את דוקר אספוז.CAD בענן גוגל."
weight: 75
url: /he/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## דרישות קדם

- יש להתקין את דוקר על המערכת שלך. למידע על איך להתקין דוקר על Windows או Mac, עיין בקישוריםใน סעיף "ראה גם".
- Visual Studio 2022.
- Google CLI.
- .NET Core 3.1 SDK בשימוש בדוגמה.
- Postman

## פונקציית Google Cloud Run

Cloud Run הוא סביבות חישוב מנוהלת לחלוטין לפריסת מיכלים HTTP ללא שרת ולתהליך גודלו מבלי לדאוג לפריסת מכונות, תצורת אשכולות, או גידול אוטומטי.

- אין נעילה לספק - מכיוון ש- Cloud Run לוקח מיכלים סטנדרטיים של OCI ויושם את ה- API הסטנדרטי של Knative Serving, תוכל בקלות להעביר את היישומים שלך לסביבת מחשוב מקומית או כל סביבה של ענן אחרת.
- גידול אוטומטי מהיר - מיקרו-שירותים המועלים ל- Cloud Run מתרחבים אוטומטית בהתבסס על מספר הבקשות המגיעות, מבלי שתצטרך לקבוע או לנהל אשכול קוברנטיס מלא. Cloud Run מתרחב לאפס - כלומר, לא עושה שימוש במשאבים - אם אין בקשות.
- חלוקת תנועה - Cloud Run מאפשר לך לחלק את התנועה בין מספר גרסאות, כך שתוכל לבצע פריסה הדרגתית כמו פריסות קנרית או פריסות כחול/ירוק.
- דומיינים מותאמים אישית - תוכל להגדיר מפה לדומיינים מותאמים אישית ב- Cloud Run והוא יספק תעודת TLS לדומיין שלך.
- גיבוי אוטומטי - Cloud Run מציע גיבוי אוטומטי כך שלא תצטרך לדאוג ליצירת מספר מופעים עבור זמינות גבוהה.

Cloud Run ופונקציות Cloud הן שירותים מנוהלים לחלוטין שפועלים על תשתית ללא שרת של Google Cloud, מגדרים אוטומטית ומטפלים בבקשות HTTP או באירועים. הם, עם זאת, יש להם כמה הבדלים חשובים:

- פונקציות Cloud מאפשרות לך לפרוס קטעי קוד (פונקציות) כתובים בהגדרת שפות תכנות מוגבלת, בעוד ש- Cloud Run מאפשרת לך לפרוס תמונות מיכל בהשתמש בשפת התכנות שבחרת.
- Cloud Run גם תומך בשימוש בכל כלי או ספריית מערכת מהיישום שלך; פונקציות Cloud לא מאפשרות לך להשתמש בביצועות מותאמות אישית.
- Cloud Run מציע משך זמן של הופעת בקשה ארוכה של עד 60 דקות, בעוד שבפונקציות Cloud הזמן המוגדר שמבוטל יכול להיות עד 9 דקות.
- פונקציות Cloud שולחות בקשה אחת בכל פעם לכל מופע פונקציה, בעוד ש- Cloud Run מוגדר מראש לשלוח מספר בקשות בו זמנית לכל מופע מיכל. זה מועיל לשיפור הלטנסי והפחתת העלויות אם אתה מצפה לנפחים גדולים.

## יצירת פרויקט פונקציית Google Cloud

{{% alert color="primary" %}} 
ודא שיש לך זכויות מספקות ליצור פונקציית Google Cloud Run ודימויים ברשות המוצר.
{{% /alert %}}

כדי ליצור את התוכנית של פונקציית Google Cloud, בצע את הצעדים הבאים:

1. התקן את .NET Core SDK 3.1.
1. התקן את חבילת התבנית:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. לאחר מכן, צור תיקיה עבור הפרויקט שלך, והשתמש ב-dotnet new כדי ליצור פונקציה HTTP חדשה:
{{< highlight plain >}}
mkdir AsposeFunctions // צור תיקיה
cd AsposeFunctions // עבור לתיקיית AsposeFunctions
dotnet new gcf-http // צור פרויקט פונקציית Google Cloud עם טריגר HTTP
{{< /highlight >}}
{{% alert color="primary" %}} 
זה יוצר AsposeFunctions.csproj ו- Function.cs בתיקיה הנוכחית. פתח את Function.cs כדי לעיין בקוד, וספק הודעה מותאמת אישית אם תרצה.
{{% /alert %}}
1. דוגמת קוד עבור קובץ csproj (AsposeFunctions.csproj).
{{< highlight plain >}}
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Aspose.CAD" Version="22.7.0" />
    <PackageReference Include="Google.Cloud.Functions.Hosting" Version="1.0.0" />
  </ItemGroup>
</Project>
{{< /highlight >}}
1. דוגמת קוד להמרת תמונת CAD לקובץ PNG (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// הלוגיקה עבור הפונקציה שלך נמצאת כאן.
        /// </summary>
        /// <param name="context">הקשר של HTTP, הכולל את הבקשה והתשובה.</param>
        /// <returns>משימה המייצגת את הפעולה האסינכרונית.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //קובץ טופס
                var file = context.Request.Body; //נתונים בינאריים
                
                var msFile = new MemoryStream();
                await file.CopyToAsync(msFile);
                msFile.Seek(0, SeekOrigin.Begin);
                
                using (var image = (CadImage)Image.Load(msFile))
                {
                    var ms = new MemoryStream();
                    image.Save(ms, new PngOptions());
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    context.Response.Headers.Add("Content-Type", "image/png");
                    context.Response.Headers.Add("Content-Disposition", "attachment;filename=result.png");

                    await context.Response.Body.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                }
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
{{< /highlight >}}
1. בנה את הפונקציה שלך באופן מקומי כדלקמן:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. לאחר שהשרת פועל, עבור אל http://localhost:8080 כדי להפעיל את הפונקציה. לחץ על Ctrl-C בקונסולה כדי להפסיק את השרת.

## פריסת דימוי דוקר על Google Cloud

1. התחבר ל-Google Cloud.
1. צור פרויקט אם הוא לא קיים.
1. עבור ל'רשות המוצר' וצור מאגר.<br>
![צור מאגר מוצר](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. בחר במאגר החדש ברשות המוצר.
![בחר במאגר מוצר](/cad/_assets/showcases/google/select-artifact.png)<br>
1. לחץ על 'הוראות התקנה' והעתק את פקודת 'הגדר דוקר'.<br>
![הוראות התקנה](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. הוסף רישום credHelper לדוקר לקובץ התצורה של דוקר, או צור את הקובץ אם הוא לא קיים.
{{< highlight plain >}}
// דוגמה
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. צור קובץ Dockerfile בתיקיית השורש של הפרויקט וערוך את DockerFile כפי שנמצא בסעיף <a href="#configuring-a-dockerfile">תצורת Dockerfile</a>.
1. הפעל את Docker Desktop.
1. בנה את דימוי הדוקר עם נתיב מאגר הענן.
{{< highlight plain >}}
// דוגמה
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. דחוף את הדימוי לרשות המוצר של Google Cloud
{{< highlight plain >}}
// דוגמה
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## צור שירות Google Cloud Run

1. עבור ל-Cloud Run.
1. צור שירות Cloud Run.<br>
![צור שירות Cloud Run](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. בשדה URL לתמונת המיכל, בחר את המיכל מתוך 'רשות מוצר'.<br>
![URL של תמונת מיכל](/cad/_assets/showcases/google/container-url.png)<br>
1. בדוק את שאר ההגדרות כפי שצוין למטה.<br>
![הגדרות שירות](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. המתן להשלמת הפריסה.
1. כתובת ה-URL של השירות לעבוד עם אפליקציית ההמרה.<br>
![ו URL של השירות](/cad/_assets/showcases/google/url-service.png)<br>

### תצורת Dockerfile

השלב הבא הוא לערוך את תצורת Dockerfile בפרויקט.

1. בקובץ Dockerfile, ציין:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

בעליון נמצא Dockerfile פשוט, האירועה contains فرمت העוקבות:

- תמונת ה-SDK שיש להשתמש בה. כאן מדובר בתמונת נט Core 3.1. דוקר יוריד אותה כאשר הפריסה מתבצעת. גרסה של ה-SDK מצוינת כתווית.
- לאחר מכן, ייתכן שתצטרך להתקין פונטים מכיוון שהתמונה של ה-SDK מכילה מאוד את הפונטים. בנוסף, תוכל להשתמש בפונטים מקומיים שהועתקו לדוקר תמונה.
- תיקיית העבודה, שצוין בשורה הבאה.
- הפקודה להעתיק הכל למיכל, לפרסם את היישום, ולציין את נקודת הכניסה.

## דוגמת ביצוע

1. הגדרות Postman.<br>
![תפריט סקירה כללית](/cad/_assets/showcases/google/postman-settings.png)<br>
1. בחר כל DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG קובץ.
1. לחץ על כפתור השליחה.

{{% alert color="primary" %}} 
אם התשובה מצליחה, לחץ על שמירה לקובץ ואתה תקבל את הקובץ שהומר לפורמט PNG
{{% /alert %}}

## דוגמאות נוספות

למעלה דוגמות של איך אתה יכול להשתמש באספוז.CAD בדוקר, עיין ב[דוגמאות](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## ראה גם.

- [התקן את Docker Desktop על Windows](https://docs.docker.com/docker-for-windows/install/)
- [התקן את Docker Desktop על Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [מעבר למיכלים של Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) אפשרות
- מידע נוסף על [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
