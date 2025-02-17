---
title: איך להריץ את התמונה Docker של Aspose.CAD בפונקציה של Azure
type: docs
description: "הרץ את התמונה Docker של Aspose.CAD בפונקציה של Azure."
weight: 71
url: /he/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## דרישות מקדמיות
- יש להתקין את Docker במערכת שלך. למידע על איך להתקין את Docker על Windows או Mac, עיין בקישורים שבראשית פרק “ראה גם”.
- IntelliJ IDEA.
- Azure Toolkit for IntelliJ.
- Postman.

## פונקציה של Azure

בדוגמה זו, אתה יוצר פונקציה פשוטה שתמיר קובץ CAD ותשמור אותו כתמונה. לאחר מכן ניתן לבנות את היישום ב-Docker ולהריץ אותו בפונקציה של Azure.

## יצירת הפונקציה של Azure

כדי ליצור את תוכנית הפונקציה של Azure, בצע את הצעדים הבאים:
1. לאחר שה-Docker מותקן, ודא שהוא משתמש בקונטיינרים של Linux (ברירת מחדל). אם יש צורך, בחר באפשרות לעבור לקונטיינרים של Linux מתפריט Desktop של Docker.
1. צור פרויקט פונקציה של Azure ב-IntelliJ IDEA.<br>
![צור פרויקט פונקציה של Azure](/_assets/java/java-azure/create-function-ide-1.png)<br>
![צור פרויקט פונקציה של Azure-סופי](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->Sing In ובחר באימות OAuth 2.0.<br>
![כניסה ל-Azure](/_assets/java/java-azure/sign-in-azure.png)<br>
1. התחבר בדפדפן.
1. בחר בשם המנוי.
1. הוסף תמיכה ב-Docker.<br>
![הוסף תמיכה ב-Docker](/_assets/java/java-azure/add-docker-support.png)<br>
1. ערוך את ה-DockerFile כפי שמופיע בפרק <a href="#configuring-a-dockerfile">הגדרת Dockerfile</a>.
1. הכנס בלוקים למאגר aspose.cad ב-pom.xml.
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. כאשר כל התלויות הנדרשות נוספות, כתוב תוכנית פשוטה שמייצרת אליפסה ושומרת אותה כתמונה:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * פונקציה זו מקשיבה בנקודת הקצה "/api/HttpExample". שתי דרכים לזמן אותה באמצעות פקודת "curl" ב-bash:
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP trigger processed a request.");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### הגדרת Dockerfile

 הצעד הבא הוא ליצור ולהגדיר את ה-Dockerfile בתיקיית השורש של הפרויקט.

1. ב-Dockerfile, ציין:
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

 ה-Dockerfile הנ"ל הוא פשוט, והוא מכיל את ההוראות הבאות:

- התמונה של ה-SDK שתשמש. Docker יספק אותה כאשר הבנייה תורץ. גרסת SDK מצוינת כתווית.
- תיקיית העבודה, אותה מציינים בשורה הבאה.
- הפקודה להעתיק את הכל לקונטיינר, לפרסם את היישום, ולקבוע את נקודת הכניסה.

## Docker Hub
1. התחבר ל-Docker Hub
1. צור מאגר ציבורי

## בניית והרצת היישום ב-Docker
 
 כעת ניתן לבנות ולהריץ את היישום ב-Docker. פתח את שורת הפקודה המועדפת עליך, שינויים בתיקיה עם היישום (התיקיה שבה קובץ הפתרון וה-Dockerfile נמצאים) והרץ את הפקודה הבאה:


1. פקודת הבנייה של Dockerfile בקונסולה
{{< highlight plain >}}
//דוגמה
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. בפעם הראשונה שתפעיל פקודה זו, זה יכול לקחת יותר זמן כי Docker זקוק להוריד את התמונות הנדרשות. לאחר שהפקודה הקודמת תושלם, הרץ את הפקודה הבאה כדי לדחוף את התמונה ל-Docker Hub.
{{< highlight plain >}}
//דוגמה
docker push <user name>/<repository name>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. הרץ את ה-Dockerfile ב-IDE ולאחר מכן דחוף ל-Docker Hub.<br>
![הרץ את Docker ב-IDE](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. הכנס את שם התמונה, כפי שהוא במאגר ה-Docker Hub.<br>
![הרץ את Docker ב-IDE- הבא](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. המתן לסיום.

## Azure

1. התחבר ל-Azure.
1. בחר שירותי Azure.
1. בחר באפליקציית פונקציה וצור פונקציה.<br>
![כפתור צור פונקציה של Azure](/_assets/java/java-azure/create-function-azure.png)<br>
1. חזור על ההגדרות הבסיסיות כפי שמופיע בתמונה למטה.<br>
![הגדרות פונקציה של Azure](/_assets/java/java-azure/create-function-settings.png)<br>
1. לחץ על 'סקור + צור' -> צור.
1. המתן לסיום ההתקנה.
1. לחץ על כפתור 'עבור למשאב'.<br>
![כפתור משאב](/_assets/java/java-azure/go-to-resource.png)<br>
1. עצור את הפונקציה aspose-cad-docker-example.<br>
![עצור קונטיינר](/_assets/java/java-azure/stop-container.png)<br>
1. עבור לתפריט מרכז ההתקנות והגדר את ההגדרות המתאימות.<br>
![מרכז התקנה](/_assets/java/java-azure/deployment-center.png)<br>
1. שמור הגדרות
1. העתק את כתובת ה-WebHook ממסך ההגדרות של מרכז ההתקנה.<br>
![כתובת WebHook](/_assets/java/java-azure/webhook-url.png)<br>
1. עבור ל-Docker Hub, בחר את המאגר שלך ובחר Webhooks.
1. הדבק את 'כתובת ה-WebHook' מ-Azure לתוך כתובת ה-WebHook של Docker Hub וקבע שם.<br>
![הגדרות WebHook ב-Docker](/_assets/java/java-azure/webhook.png)<br>
1. לחץ על כפתור צור.
1. חזור לפונקציה של Azure ותתחיל את הקונטיינר.<br>
![תפריט תצוגה כללית](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
זה עלול לקחת כמה דקות להתחלת הפונקציה.
{{% /alert %}}

## דוגמת ביצוע

1. הגדרות Postman.<br>
![תפריט תצוגה כללית](/_assets/java/java-azure/postman-settings.png)<br>
1. בחר כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. לחץ על כפתור השליחה.
1. שמור את התוצאה
![שמור את התגובה](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
אם התשובה הצליחה, לחץ שמור לקובץ ותשמור את הקובץ המומר בפורמט PNG
{{% /alert %}}

## דוגמאות נוספות

לנוסף לדוגמאות כיצד להשתמש ב-Aspose.CAD ב-Docker, ראה את [דוגמאות](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## ראה גם

- [התקן Docker Desktop על Windows](https://docs.docker.com/docker-for-windows/install/)
- [התקן Docker Desktop על Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [מעבר לקונטיינרים של Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) option
