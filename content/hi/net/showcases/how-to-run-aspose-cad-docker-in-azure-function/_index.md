---
title: Azure Function में Aspose.CAD Docker इमेज कैसे चलाएँ
type: docs
description: "Azure Function में Aspose.CAD Docker इमेज चलाएँ।"
weight: 73
url: /hi/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## पूर्वापेक्षाएँ
- आपके सिस्टम पर Docker स्थापित होना चाहिए। Windows या Mac पर Docker स्थापित करने के बारे में जानकारी के लिए "See Also" अनुभाग में संबंधित लिंक देखें।
- Visual Studio 2022।
- उदाहरण में .NET 6 SDK का उपयोग किया गया है।
- Postman

## Azure Function

इस उदाहरण में, आप एक सरल रूपांतरण फ़ंक्शन बनाते हैं जो एक CAD फ़ाइल को रूपांतरित करता है और उसे एक छवि के रूप में सहेजता है। फिर एप्लिकेशन को Docker में बनाया जा सकता है और Azure Function में चलाया जा सकता है।

## Azure Function बनाना

Azure Function प्रोग्राम बनाने के लिए, नीचे दिए गए चरणों का पालन करें:
1. एक बार Docker स्थापित हो जाने पर, सुनिश्चित करें कि यह Linux Containers (डिफ़ॉल्ट) का उपयोग कर रहा है। यदि आवश्यक हो, तो Docker डेस्कटॉप मेनू से Linux Containers पर स्विच करने का विकल्प चुनें।
1. Visual Studio में, .NET 6 Azure Function बनाएँ।<br>
![A NET 6 Azure Function project dialog](/cad/_assets/showcases/azure/Create-project.png)<br>
1. अतिरिक्त जानकारी।<br>
![A NET 6 Azure Function project dialog](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. NuGet से नवीनतम Aspose.CAD संस्करण स्थापित करें।<br>
![Aspose.CAD on NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. चूंकि एप्लिकेशन Linux पर चलाया जाएगा, आपको अतिरिक्त फ़ॉन्ट स्थापित करने की आवश्यकता हो सकती है। आप ttf-mscorefonts-installer का चयन कर सकते हैं।
1. जब सभी आवश्यक निर्भरताएँ जोड़ी जाएं, तो एक साधारण प्रोग्राम लिखें जो एक अंडाकार बनाता है और उसे एक छवि के रूप में सहेजता है:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");
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

### Dockerfile को कॉन्फ़िगर करना

अगला चरण Dockerfile बनाना और रूट प्रोजेक्ट फ़ोल्डर में कॉन्फ़िगर करना है।

1. Dockerfile बनाएं और इसे आपके एप्लिकेशन की समाधान फ़ाइल के बगल में रखें। इस फ़ाइल के नाम को बिना एक्सटेंशन (डिफ़ॉल्ट) के रखें।
![Root project folder](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Dockerfile में निर्दिष्ट करें:


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

उपर्युक्त एक साधारण Dockerfile है, जिसमें निम्नलिखित निर्देश शामिल हैं:

- उपयोग किया जाने वाला SDK इमेज। यहाँ यह .NET 6 इमेज है। Docker इसे तब डाउनलोड करेगा जब निर्माण चलाया जाएगा। SDK का संस्करण एक टैग के रूप में निर्दिष्ट किया गया है।
- इसके बाद, आपको फॉन्ट्स स्थापित करने की आवश्यकता हो सकती है क्योंकि SDK इमेज में बहुत कम फॉन्ट्स होते हैं। साथ ही, आप स्थानीय फॉन्ट्स का उपयोग कर सकते हैं जिन्हें Docker इमेज में कॉपी किया गया है।
- कार्यात्मक निर्देशिका, जो अगली पंक्ति में निर्दिष्ट होती है।
- कंटेनर में सब कुछ कॉपी करने का आदेश, एप्लिकेशन को प्रकाशित करें, और प्रवेश बिंदु निर्दिष्ट करें।

## Docker Hub
1. Docker Hub में लॉगिन करें
1. सार्वजनिक रिपॉजिटरी बनाएं

## Docker में एप्लिकेशन बनाना और चलाना
 
अब एप्लिकेशन को Docker में बनाया और चलाया जा सकता है। अपने पसंदीदा कमांड प्रॉम्प्ट को खोलें, उस फ़ोल्डर में निर्देशिका बदलें जहाँ एप्लिकेशन (जो समाधान फ़ाइल और Dockerfile स्थित है) है और निम्नलिखित आदेश चलाएँ:

{{< highlight plain >}}
//example
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
जब आप इस आदेश को पहली बार चलाते हैं, तो यह अधिक समय ले सकता है क्योंकि Docker को आवश्यक इमेज डाउनलोड करनी होती है। पिछला आदेश पूरा होने के बाद, Docker हब में इमेज को पुश करने के लिए निम्नलिखित आदेश चलाएँ:
 
{{< highlight plain >}}
//example
docker push <user name>/<repository name>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Azure में लॉगिन करें।
1. Azure सेवाओं का चयन करें।
1. Function App का चयन करें और एक फ़ंक्शन बनाएं।<br>
![Azure create function button](/cad/_assets/showcases/azure/create-function.png)<br>
1. नीचे दी गई छवि के अनुसार मूल सेटिंग्स को दोहराएँ।<br>
![Azure create function settings](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. 'Review + create' -> Create पर क्लिक करें।
1. वितरण खत्म होने की प्रतीक्षा करें।
1. 'Go to resource' बटन पर क्लिक करें।<br>
![Resource button](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. aspose-cad-docker-example फ़ंक्शन को रोकें।<br>
![Stop conteiner](/cad/_assets/showcases/azure/stop-container.png)<br>
1. वितरण केंद्र मेनू पर जाएं और उपयुक्त सेटिंग करें।<br>
![Deployment center](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. सेटिंग्स सहेजें।
1. वितरण केंद्र सेटिंग से Webhook URL कॉपी करें।<br>
![Webhook url](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Docker Hub पर जाएं, अपने रिपॉजिटरी का चयन करें और वेबहुक का चयन करें।
1. Azure से 'Webhook url' को Docker Hub वेबहुक url में चिपकाएँ और नाम सेट करें।<br>
![Webhook settings in docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Create बटन पर क्लिक करें।
1. अवलोकन Azure फ़ंक्शन पर लौटें और कंटेनर को चालू करें।<br>
![Overview menu](/cad/_assets/showcases/azure/overview.png)<br>

## कार्यान्वयन उदाहरण

1. Postman सेटिंग।<br>
![Overview menu](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. कोई भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल का चयन करें।
1. भेजें बटन पर क्लिक करें।

{{% alert color="primary" %}} 
यदि उत्तर सफल है, तो फ़ाइल को सहेजने पर क्लिक करें और आप png प्रारूप में परिवर्तित फ़ाइल प्राप्त करेंगे
{{% /alert %}}

## अधिक उदाहरण

Docker में Aspose.CAD का उपयोग करने के और अधिक नमूनों के लिए, [उदाहरण](https://github.com/aspose-cad/Aspose.CAD-Documentation) देखें।

## देखिए भी

- [Windows पर Docker डेस्कटॉप स्थापित करें](https://docs.docker.com/docker-for-windows/install/)
- [Mac पर Docker डेस्कटॉप स्थापित करें](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux कंटेनरों पर स्विच करें](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) विकल्प
- [.NET Core SDK पर अतिरिक्त जानकारी](https://hub.docker.com/_/microsoft-dotnet-sdk)
