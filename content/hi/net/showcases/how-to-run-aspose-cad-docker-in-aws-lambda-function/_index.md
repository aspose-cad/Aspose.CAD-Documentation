---
title: AWS Lambda फ़ंक्शन में Aspose.CAD Docker छवि को कैसे चलाएं
type: docs
description: "AWS Lambda फ़ंक्शन में Aspose.CAD Docker छवि को चलाएं।"
weight: 74
url: /hi/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## पूर्वापेक्षाएँ
- आपके सिस्टम पर Docker स्थापित होना चाहिए। Windows या Mac पर Docker स्थापित करने के तरीके के बारे में जानकारी के लिए “See Also” अनुभाग में लिंक देखें।
- Visual Studio 2022।
- AWS Toolkit for Visual Studio 2022।
- उदाहरण में .NET 6 SDK का उपयोग किया गया है।
- Postman

## AWS Lambda फ़ंक्शन

Lambda एक कंप्यूट सेवा है जो आपको सर्बर प्रावधिक या प्रबंधित किए बिना कोड चलाने देती है। Lambda आपके कोड को एक उच्च उपलब्धता वाले कंप्यूट अवसंरचना पर चलाती है और कंप्यूट संसाधनों के सभी प्रशासन करती है, जिसमें सर्वर और ऑपरेटिंग सिस्टम का रखरखाव, क्षमता प्रावधिक और स्वचालित स्केलिंग, और लॉगिंग शामिल है। Lambda के साथ, आप किसी भी प्रकार के एप्लिकेशन या बैकएंड सेवा के लिए कोड चला सकते हैं।

## AWS Lambda फ़ंक्शन बनाना

{{% alert color="primary" %}} 
सुनिश्चित करें कि आपके पास AWS Lambda कार्य और छवियाँ बनाने के लिए पर्याप्त अधिकार हैं Amazon Elastic Container Registry में।
{{% /alert %}}

AWS Lambda फ़ंक्शन प्रोग्राम बनाने के लिए, नीचे दिए गए चरणों का पालन करें:
1. AWS Lambda प्रोजेक्ट बनाएं।<br>
![Create AWS function button](/_assets/showcases/aws/create-project.png)<br>
1. .NET 6 (Container Image) का चयन करें और 'Finish' बटन पर क्लिक करें।<br>
![Create container function button](/_assets/showcases/aws/create-container.png)<br>
1. Visual Studio में AWS Explorer खोलें (View->AWS Explorer)।
1. AWS Explorer में AWS क्रेडेंशियल प्रोफ़ाइल जोड़ें।<br>
![Credential profile](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Access Key ID और Secret Access Key दर्ज करें, आप इन कीज़ को सुरक्षा क्रेडेंशियल में प्राप्त कर सकते हैं या प्रबंधक से संपर्क करके प्राधिकरण के लिए एक csv फ़ाइल प्राप्त कर सकते हैं।<br>
![Acount profile settings](/_assets/showcases/aws/account-profile.png)<br>
1. NuGet से नवीनतम पुस्तकालयों को स्थापित करें।<br>
![NuGet Manager](/_assets/showcases/aws/nuget-manager.png)<br>
1. CAD छवि को PDF फ़ाइल में परिवर्तित करने के लिए कोड उदाहरण।
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
1. DockerFile को <a href="#configuring-a-dockerfile">Configuring a Dockerfile</a> अनुभाग में जैसा संपादित करें।
1. Docker Desktop शुरू करें।
1. AWS Lambda पर प्रकाशित करें।<br>
![AWS lambda publish](/_assets/showcases/aws/publish-aws.png)<br>
1. अपलोड कॉन्फ़िगरेशन संपादित करें।<br>
![Upload aws lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. 'Upload' बटन पर क्लिक करें।<br>
![Upload aws lambda last](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. AWS पर जाएं और Lambda का चयन करें।<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. अपने नए फ़ंक्शन का चयन करें और URL फ़ंक्शन बनाएँ।<br>
![Configuration url function](/_assets/showcases/aws/create-function-url.png)<br>
1. प्रामाणिकता प्रकार चुनें
- AWS_IAM - केवल प्रमाणित IAM उपयोगकर्ता और भूमिकाएँ आपकी कार्य URL पर अनुरोध कर सकती हैं।
- NONE - Lambda आपकी कार्य URL पर अनुरोधों पर IAM प्रमाणीकरण नहीं करेगा। URL का एंडपॉइंट सार्वजनिक होगा जब तक कि आप अपने फ़ंक्शन में अपनी प्राधिकरण लॉजिक लागू न करें।

### Dockerfile को कॉन्फ़िगर करना

अगला कदम परियोजना में Dockerfile को संपादित करना है।

1. Dockerfile में, निर्दिष्ट करें:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

उपरोक्त एक साधारण Dockerfile है, जिसमें निम्नलिखित निर्देश शामिल हैं:

- जिसे SDK छवि का उपयोग किया जाना है। यहाँ यह Net 6 छवि है। Docker इसे तब डाउनलोड करेगा जब बिल्ड चलाया जाएगा। SDK का संस्करण एक टैग के रूप में निर्दिष्ट किया गया है।
- बाद में, आपको फ़ॉन्ट स्थापित करने की आवश्यकता हो सकती है क्योंकि SDK छवि में बहुत कम फ़ॉन्ट होते हैं। इसके अलावा, आप Docker छवि में कॉपी किए गए स्थानीय फ़ॉन्ट का उपयोग कर सकते हैं।
- कार्यशील निर्देशिका, जिसे अगले पंक्ति में निर्दिष्ट किया गया है।
- कंटेनर में सब कुछ कॉपी करने, एप्लिकेशन को प्रकाशित करने और एंट्री पॉइंट निर्दिष्ट करने के लिए आदेश।

## कार्य उदाहरण

1. Postman सेटिंग्स।<br>
![Overview menu](/_assets/showcases/aws/postman-settings.png)<br>
1. किसी भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल का चयन करें।
1. भेजें बटन पर क्लिक करें।

{{% alert color="primary" %}} 
यदि उत्तर सफल है, तो फ़ाइल में सहेजें पर क्लिक करें और आपको PDF प्रारूप में परिवर्तित फ़ाइल प्राप्त होगी
{{% /alert %}}

## अधिक उदाहरण

Docker में Aspose.CAD का उपयोग करने के अधिक नमूनों के लिए, [examples](https://github.com/aspose-cad/Aspose.CAD-Documentation) देखें।

## अन्य जानकारी।

- [Visual Studio 2022 के लिए AWS Toolkit स्थापित करें](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Windows पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-windows/install/)
- [Mac पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux कंटेनरों पर स्विच करें](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) विकल्प
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) पर अतिरिक्त जानकारी
