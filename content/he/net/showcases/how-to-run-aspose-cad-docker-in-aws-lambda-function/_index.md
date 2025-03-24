---
title: איך להריץ את תמונת Docker של Aspose.CAD בפונקציית AWS Lambda
type: docs
description: "הרץ את תמונת Docker של Aspose.CAD בפונקציית AWS Lambda."
weight: 74
url: /he/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## דרישות מוקדמות
- עליך להתקין את Docker במערכת שלך. למידע על كيفية להתקין את Docker על Windows או Mac, עיין בקישורים במסך "ראו גם" (See Also).
- Visual Studio 2022.
- AWS Toolkit for Visual Studio 2022.
- NET 6 SDK משמש בדוגמה.
- Postman

## פונקציית AWS Lambda

Lambda היא שירות חישוב המאפשר לך להריץ קוד מבלי לנהל או להקצות שרתים. Lambda מריצה את הקוד שלך על תשתית חישוב בעלת זמינות גבוהה ומבצעת את כל הניהול של משאבי החישוב, כולל תחזוקת שרת ומערכת הפעלה, הקצאת קיבולת והספקה אוטומטית, ורישום. עם Lambda, תוכל להריץ קוד כמעט לכל סוג של יישום או שירות רדום.

## יצירת פונקציית AWS Lambda

{{% alert color="primary" %}} 
ודא שיש לך זכויות מספיקות כדי ליצור פונקציות ודימויים של AWS Lambda במאגר הקונטיינרים של Amazon Elastic.
{{% /alert %}}

כדי ליצור את תוכנית פונקציית AWS Lambda, פעל לפי השלבים הבאים:
1. צור פרויקט AWS Lambda.<br>
![Create AWS function button](/cad/_assets/showcases/aws/create-project.png)<br>
1. בחר .NET 6 (תמונת קונטיינר) ולחץ על כפתור 'סיים' (Finish).<br>
![Create container function button](/cad/_assets/showcases/aws/create-container.png)<br>
1. פתח את AWS Explorer ב- Visual Studio (View->AWS Explorer).
1. הוסף פרופיל אימות AWS ב-AWS Explorer.<br>
![Credential profile](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. הזן את Access Key ID ואת Secret Access Key, תוכל לקבל מפתחות אלו באימות אבטחה או לפנות למנהל ולקבל קובץ csv עבור האימות.<br>
![Acount profile settings](/cad/_assets/showcases/aws/account-profile.png)<br>
1. התקן את הספריות האחרונות מ-NuGet.<br>
![NuGet Manager](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. דוגמת קוד להמרת תמונת cad לקובץ pdf.
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. ערוך את DockerFile כפי שנמצא בסעיף <a href="#configuring-a-dockerfile">הגדרת Dockerfile</a>.
1. הפעל את Docker Desktop.
1. פרסם ל-AWS Lambda.<br>
![AWS lambda publish](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. ערוך את הגדרות ההעלאה.<br>
![Upload aws lambda](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. לחץ על כפתור 'העלה' (Upload).<br>
![Upload aws lambda last](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. עבור ל-AWS ובחר Lambda.<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. בחר את הפונקציה החדשה שלך וצור את קובץ ה-URL.<br>
![Configuration url function](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. בחר את סוג האימות
- AWS_IAM - רק משתמשים ותפקידי IAM מאומתים יכולים לבצע בקשות ל-URL הפונקציה שלך.
- NONE - Lambda לא תבצע אימות IAM על בקשות ל-URL הפונקציה שלך. נקודת הקצה של ה-URL תהיה ציבורית אלא אם תיישם את הלוגיקה של האימות שלך בפונקציה שלך.

### הגדרת Dockerfile

השלב הבא הוא לערוך את הגדרת ה-Dockerfile בפרויקט.

1. ב-Dockerfile, ציין:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

הדוגמה שלעיל היא Dockerfile פשוט, הכולל את ההוראות הבאות:

- תמונת ה-SDK שיש להשתמש בה. כאן זו תמונת Net 6. Docker יוריד אותה כאשר יתבצע הבניית.
- לאחר מכן, ייתכן שתצטרך להתקין גופנים כי לתמונת ה-SDK יש מעט מאוד גופנים. בנוסף, תוכל להשתמש בגופנים מקומיים שהועתקו לתמונת הדוקר.
- ספריית העבודה, שמצוינת בשורה הבאה.
- הפקודה להעתיק הכל לקונטיינר, לפרסם את היישום ולציין את הנקודת כניסה.

## דוגמת ביצוע

1. הגדרות Postman.<br>
![Overview menu](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. בחר כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. לחץ על כפתור השליחה.

{{% alert color="primary" %}} 
אם התגובה מצליחה, לחץ על שמור לקובץ (Save to file) ותשיג את הקובץ המומר בפורמט pdf
{{% /alert %}}

## דוגמאות נוספות

למגוון דוגמאות כיצד תוכל להשתמש ב-Aspose.CAD בדוקר, ראה את [דוגמאות](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## ראו גם.

- [התקנת AWS Toolkit for Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [התקנת Docker Desktop על Windows](https://docs.docker.com/docker-for-windows/install/)
- [התקנת Docker Desktop על Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [מעבר לקונטיינרים של לינוקס](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) אפשרות
- מידע נוסף על [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
