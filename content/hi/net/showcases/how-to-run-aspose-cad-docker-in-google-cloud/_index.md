---
title: कैसे Google Cloud में Aspose.CAD Docker छवि चलाएं
type: docs
description: "Google Cloud में Aspose.CAD Docker छवि चलाएं।"
weight: 75
url: /hi/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## पूर्वापेक्षाएँ

- आपके सिस्टम पर Docker स्थापित होना चाहिए। Windows या Mac पर Docker स्थापित करने के लिए जानकारी के लिए, "इसे भी देखें" सेक्शन में लिंक देखें।
- Visual Studio 2022।
- Google CLI।
- उदाहरण में .NET Core 3.1 SDK का उपयोग किया गया है।
- Postman

## Google Cloud रन फ़ंक्शन

Cloud Run एक पूरी तरह से प्रबंधित गणना वातावरण है जो बेपरवाह HTTP कंटेनरों को तैनात करने और स्केल करने के लिए है, मशीनों को प्रावधान करने, क्लस्टर कॉन्फ़िगर करने या ऑटोस्केलिंग के बारे में चिंता करने की आवश्यकता नहीं है।

- कोई विक्रेता लॉक-इन नहीं - क्योंकि Cloud Run मानक OCI कंटेनरों को लेता है और मानक Knative Serving API को लागू करता है, इसलिए आप आसानी से अपने अनुप्रयोगों को ऑन-प्रिमाइसेस या किसी और क्लाउड वातावरण में पोर्ट कर सकते हैं।
- तेज ऑटोस्केलिंग - Cloud Run में तैनात माइक्रोसर्विसेज स्वचालित रूप से आने वाले अनुरोधों की संख्या के आधार पर स्केल होती हैं, बिना आपको किसी पूर्ण-फledged Kubernetes क्लस्टर को कॉन्फ़िगर या प्रबंधित करने की आवश्यकता। अगर कोई अनुरोध नहीं हैं तो Cloud Run शून्य पर स्केल होता है - अर्थात, कोई संसाधन का उपयोग नहीं करता है।
- ट्रैफ़िक विभाजित करें - Cloud Run आपको कई संशोधनों के बीच ट्रैफ़िक को विभाजित करने की अनुमति देता है, ताकि आप कैनरी तैनाती या नीला/हरा तैनाती जैसी क्रमिक रोलआउट कर सकें।
- कस्टम डोमेन - आप Cloud Run में कस्टम डोमेन मैपिंग सेट कर सकते हैं और यह आपके डोमेन के लिए TLS प्रमाणपत्र प्रदान करेगा।
- स्वचालित कलंकता - Cloud Run स्वचालित कलंकता की पेशकश करता है ताकि आपको उच्च उपलब्धता के लिए कई उदाहरण बनाने की चिंता न हो।

Cloud Run और Cloud Functions दोनों पूरी तरह से प्रबंधित सेवाएँ हैं जो Google Cloud की सर्वरलेस इंफ्रास्ट्रक्चर पर चलती हैं, ऑटो-स्केल होती हैं, और HTTP अनुरोधों या घटनाओं को संभालती हैं। हालाँकि, उनके बीच कुछ महत्वपूर्ण अंतर हैं:

- Cloud Functions आपको सीमित सेट की प्रोग्रामिंग भाषाओं में लिखित कोड (फ़ंक्शन) के स्निपेट को तैनात करने की अनुमति देता है, जबकि Cloud Run आपको अपनी पसंद की प्रोग्रामिंग भाषा का उपयोग करके कंटेनर छवियाँ तैनात करने देता है।
- Cloud Run आपके अनुप्रयोग से किसी भी उपकरण या सिस्टम पुस्तकालय के उपयोग का समर्थन करता है; Cloud Functions आपको कस्टम निष्पादकों का उपयोग करने की अनुमति नहीं देती है।
- Cloud Run 60 मिनट तक के लिए लंबे अनुरोध समय-समापन की अवधि की पेशकश करता है, जबकि Cloud Functions के साथ अनुरोध समय-समापन को 9 मिनट तक सेट किया जा सकता है।
- Cloud Functions प्रत्येक फ़ंक्शन उदाहरण को एक समय में केवल एक अनुरोध भेजता है, जबकि डिफ़ॉल्ट रूप से Cloud Run प्रत्येक कंटेनर उदाहरण पर कई समवर्ती अनुरोध भेजने के लिए कॉन्फ़िगर किया गया है। यदि आप बड़े मात्रा की अपेक्षा कर रहे हैं तो यह विलंबता में सुधार करने और लागत को कम करने में सहायक है।

## Google Cloud Function प्रोजेक्ट बनाना

{{% alert color="primary" %}} 
सुनिश्चित करें कि आपके पास Google Cloud Run फ़ंक्शन और आर्टिफैक्ट रजिस्ट्री रिपॉजिटरी में छवियाँ बनाने के लिए पर्याप्त अधिकार हैं।
{{% /alert %}}

Google Cloud Function प्रोग्राम बनाने के लिए, नीचे दिए गए चरणों का पालन करें:

1. .NET Core SDK 3.1 स्थापित करें।
1. टेम्पलेट पैकेज स्थापित करें:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. अगले, अपने प्रोजेक्ट के लिए एक निर्देशिका बनाएं, और नए HTTP फ़ंक्शन बनाने के लिए dotnet new का उपयोग करें:
{{< highlight plain >}}
mkdir AsposeFunctions //फोल्डर बनाएं
cd AsposeFunctions //फोल्डर AsposeFunctions में जाएं
dotnet new gcf-http //HTTP ट्रिगर के साथ Google Cloud Function प्रोजेक्ट बनाएं
{{< /highlight >}}
{{% alert color="primary" %}} 
यह वर्तमान निर्देशिका में AsposeFunctions.csproj और Function.cs बनाता है। कोड की समीक्षा करने के लिए Function.cs खोलें, और यदि आप चाहें तो एक कस्टम संदेश प्रदान करें।
{{% /alert %}}
1. csproj फ़ाइल (AsposeFunctions.csproj) के लिए कोड उदाहरण।
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
1. png फ़ाइल में cad छवि को रूपांतरित करने के लिए कोड उदाहरण (Function.cs)।
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// आपकी फ़ंक्शन के लिए तर्क यहाँ जाता है।
        /// </summary>
        /// <param name="context">HTTP संदर्भ, जिसमें अनुरोध और प्रतिक्रिया शामिल है।</param>
        /// <returns>असिंक्रोनस ऑपरेशन का प्रतिनिधित्व करने वाला एक कार्य।</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //प्रारूप फ़ाइल
                var file = context.Request.Body; //बाइनरी डेटा
                
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
1. अपने फ़ंक्शन को लोकally इस प्रकार बनाएँ:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. एक बार जब सर्वर चल रहा हो, तो फ़ंक्शन को सक्रिय करने के लिए http://localhost:8080 पर जाएं। सर्वर को बंद करने के लिए कंसोल में Ctrl-C दबाएं।

## Google Cloud पर Docker छवि तैनात करें

1. Google Cloud में लॉगिन करें।
1. यदि यह मौजूद नहीं है तो एक प्रोजेक्ट बनाएं।
1. 'आर्टिफेक्ट रजिस्ट्री' पर जाएं और एक रिपॉजिटरी बनाएं।<br>
![Create Artifact Repository](/_assets/showcases/google/create-artifact-repository.png)<br>
1. आर्टिफेक्ट रजिस्ट्री में नए रिपॉजिटरी का चयन करें।
![Select artifact repository](/_assets/showcases/google/select-artifact.png)<br>
1. 'SETUP INSTRUCTION' पर क्लिक करें और 'Configure Docker' कमांड की कॉपी करें।<br>
![SETUP INSTRUCTION](/_assets/showcases/google/setup-instruction.png)<br>
1. Docker की कॉन्फ़िगरेशन फ़ाइल में एक Docker credHelper प्रविष्टि जोड़ें, या यदि यह मौजूद नहीं है तो फ़ाइल बनाएं।
{{< highlight plain >}}
//उदाहरण
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. प्रोजेक्ट की मूल निर्देशिका में एक Dockerfile बनाएं और DockerFile को <a href="#configuring-a-dockerfile">Dockerfile कॉन्फ़िगर करना</a> सेक्शन के रूप में संपादित करें।
1. Docker डेस्कटॉप प्रारंभ करें।
1. क्लाउड रिपॉजिटरी पथ के साथ Docker छवि बनाएं।
{{< highlight plain >}}
//उदाहरण
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Google Cloud आर्टिफेक्ट रजिस्ट्री में छवि धक्का दें।
{{< highlight plain >}}
//उदाहरण
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Google Cloud Run सेवा बनाएं 

1. Cloud Run पर जाएं।
1. Cloud Run सेवा बनाएं।<br>
![Create Cloud Run service](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. कंटेनर इमेज URL फ़ील्ड में, 'आर्टिफैक्ट रजिस्ट्री' से कंटेनर का चयन करें।<br>
![Container Image URL](/_assets/showcases/google/container-url.png)<br>
1. अन्य सेटिंग्स की जाँच करें जैसे नीचे।<br>
![Settings service](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. तैनाती समाप्त होने तक प्रतीक्षा करें।
1. रूपांतरण अनुप्रयोग के साथ काम करने के लिए सेवा URL।<br>
![Url service](/_assets/showcases/google/url-service.png)<br>

### Dockerfile को कॉन्फ़िगर करना

अगला कदम परियोजना में Dockerfile को संपादित करना है।

1. Dockerfile में, निर्दिष्ट करें:

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

उपर्युक्त एक सरल Dockerfile है, जिसमें निम्नलिखित निर्देश शामिल हैं:

- उपयोग के लिए SDK छवि। यहाँ यह Net Core 3.1 छवि है। Docker इसे तब डाउनलोड करेगा जब निर्माण चलाया जाएगा। SDK का संस्करण एक टैग के रूप में निर्दिष्ट किया गया है।
- इसके बाद, आपको फॉन्ट्स स्थापित करने की आवश्यकता हो सकती है क्योंकि SDK छवि में बहुत कम फॉन्ट होते हैं। इसके अलावा, आप स्थानीय फॉन्ट्स का उपयोग कर सकते हैं जिन्हें Docker छवि में कॉपी किया गया है।
- कार्यशील निर्देशिका, जिसे अगले पंक्ति में निर्दिष्ट किया गया है।
- कंटेनर में सबकुछ कॉपी करने, आवेदन प्रकाशित करने और एंट्री पॉइंट निर्दिष्ट करने का आदेश।

## कार्यान्वयन उदाहरण

1. Postman सेटिंग्स।<br>
![Overview menu](/_assets/showcases/google/postman-settings.png)<br>
1. किसी भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल का चयन करें।
1. भेजें बटन पर क्लिक करें।

{{% alert color="primary" %}} 
यदि उत्तर सफल है, तो फ़ाइल में सहेजें पर क्लिक करें और आपको png प्रारूप में परिवर्तित फ़ाइल प्राप्त होगी
{{% /alert %}}

## अधिक उदाहरण

Aspose.CAD को Docker में कैसे उपयोग किया जा सकता है, इसके और उदाहरणों के लिए, देखें [उदाहरण](https://github.com/aspose-cad/Aspose.CAD-Documentation)।

## इसे भी देखें।

- [Windows पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-windows/install/)
- [Mac पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Linux कंटेनरों पर स्विच करें](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) विकल्प
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) पर अतिरिक्त जानकारी
