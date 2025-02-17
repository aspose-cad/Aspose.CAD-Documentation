---
title: Azure Function में Aspose.CAD Docker इमेज कैसे चलाएं
type: docs
description: "Azure Function में Aspose.CAD Docker इमेज चलाएं।"
weight: 71
url: /hi/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## आवश्यकताएँ
- आपके सिस्टम पर Docker स्थापित होना चाहिए। Windows या Mac पर Docker स्थापित करने की जानकारी के लिए, "संबंधित लिंक" अनुभाग में देखें।
- IntelliJ IDEA.
- IntelliJ के लिए Azure Toolkit.
- Postman.

## Azure Function

इस उदाहरण में, आप एक साधारण रूपांतरण फ़ंक्शन बनाते हैं जो एक CAD फ़ाइल को परिवर्तित करता है और उसे एक इमेज के रूप में सहेजता है। फिर एप्लिकेशन को Docker में बनाया जा सकता है और Azure Function में चलाया जा सकता है।

## Azure Function बनाना

Azure Function प्रोग्राम बनाने के लिए, नीचे दिए गए चरणों का पालन करें:
1. एक बार जब Docker स्थापित हो जाए, तो सुनिश्चित करें कि यह Linux Containers (डिफ़ॉल्ट) का उपयोग कर रहा है। यदि आवश्यक हो, तो Docker डेस्कटॉप मेनू से Linux Containers में स्विच करने का विकल्प चुनें।
1. IntelliJ IDEA में Azure Function प्रोजेक्ट बनाएँ।<br>
![Create azure function project](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Create azure function project-final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->साइन इन करें और OAuth 2.0 प्रमाणन चुनें।<br>
![Azure sign In](/_assets/java/java-azure/sign-in-azure.png)<br>
1. ब्राउज़र में लॉग इन करें।
1. सदस्यता नाम चुनें।
1. Docker सहायता जोड़ें।<br>
![Azure sign In](/_assets/java/java-azure/add-docker-support.png)<br>
1. DockerFile को <a href="#configuring-a-dockerfile">Dockerfile को कॉन्फ़िगर करना</a> अनुभाग में जैसा किया गया है, संपादित करें।
1. pom.xml में aspose.cad के लिए रिपॉजिटरी के लिए ब्लॉक्स जोड़ें।
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

1. जब सभी आवश्यक निर्भरताएँ जोड़ दी जाएं, तो एक सरल प्रोग्राम लिखें जो एक अंडाकार बनाता है और इसे एक इमेज के रूप में सहेजता है:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * यह फ़ंक्शन एंडपॉइंट "/api/HttpExample" पर सुनता है। इसे "curl" कमांड का उपयोग करके दो तरीकों से सक्रिय किया जा सकता है:
     * 1. curl -d "HTTP Body" {आपका होस्ट}/api/HttpExample
     * 2. curl "{आपका होस्ट}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP ट्रिगर ने एक अनुरोध को संसाधित किया।");

        try {
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

### Dockerfile को कॉन्फ़िगर करना

 अगला कदम रूट प्रोजेक्ट फ़ोल्डर में Dockerfile को बनाना और कॉन्फ़िगर करना है।

1. Dockerfile में, निर्दिष्ट करें:
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

 उपरोक्त एक सरल Dockerfile है, जिसमें निम्नलिखित निर्देश शामिल हैं:

- उपयोग की जाने वाली SDK इमेज। Docker इसे निर्माण के दौरान डाउनलोड करेगा। SDK का संस्करण टैग के रूप में निर्दिष्ट किया गया है।
- कार्यशील निर्देशिका, जिसे अगले पंक्ति में निर्दिष्ट किया गया है।
- सभी चीज़ों को कंटेनर में कॉपी करने, एप्लिकेशन को प्रकाशित करने और प्रवेश बिंदु निर्दिष्ट करने के लिए आदेश।

## Docker Hub
1. Docker Hub में लॉगिन करें
1. सार्वजनिक रिपॉजिटरी बनाएं

## Docker में एप्लिकेशन का निर्माण और चलाना
 
 अब एप्लिकेशन को Docker में बनाया और चलाया जा सकता है। अपनी पसंद के कमांड प्रांप्ट को खोलें, एप्लिकेशन के फ़ोल्डर (फ़ोल्डर जहां समाधान फ़ाइल और Dockerfile स्थित है) में डायरेक्टरी बदलें और निम्नलिखित आदेश चलाएं:


1. कंसोल में dockerfile निर्माण आदेश
{{< highlight plain >}}
//उदाहरण
docker build -t <उपयोगकर्ता नाम>/<रिपॉजिटरी नाम> .

docker build -t उपयोगकर्ता/asposefunction .
{{< /highlight >}}
 
1. जब आप इस आदेश को पहली बार चलाते हैं, तो यह अधिक समय ले सकता है क्योंकि Docker को आवश्यक इमेज़ डाउनलोड करने की आवश्यकता होती है। पिछले आदेश को पूरा करने के बाद, निम्नलिखित आदेश चलाएं ताकि इमेज़ को docker hub पर धक्का (push) दिया जा सके।
{{< highlight plain >}}
//उदाहरण
docker push <उपयोगकर्ता नाम>/<रिपॉजिटरी नाम>:tagname

docker push उपयोगकर्ता/aspose-cad-java:latest
{{< /highlight >}}

1. IDE में dockerfile चलाएं और उसके बाद docker hub पर धक्का (push) दें।<br>
![Run docker in ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. इमेज का नाम दर्ज करें, जैसा कि Docker Hub रिपॉजिटरी में है।<br>
![Run docker in ide-next](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. समाप्त होने की प्रतीक्षा करें।

## Azure

1. Azure में लॉग इन करें।
1. Azure सेवाएँ चुनें।
1. फ़ंक्शन ऐप चुनें और एक फ़ंक्शन बनाएं।<br>
![Azure create function button](/_assets/java/java-azure/create-function-azure.png)<br>
1. नीचे दी गई छवि के रूप में मौलिक सेटिंग्स को दोहराएँ।<br>
![Azure create function settings](/_assets/java/java-azure/create-function-settings.png)<br>
1. 'Review + create' पर क्लिक करें -> बनाएं।
1. वितरण समाप्त होने की प्रतीक्षा करें।
1. 'स्रोत पर जाएं' बटन पर क्लिक करें।<br>
![Resource button](/_assets/java/java-azure/go-to-resource.png)<br>
1. aspose-cad-docker-example फ़ंक्शन रोकें।<br>
![Stop conteiner](/_assets/java/java-azure/stop-container.png)<br>
1. वितरण केंद्र मेनू पर जाएँ और उपयुक्त सेटिंग्स बनाएं।<br>
![Deployment center](/_assets/java/java-azure/deployment-center.png)<br>
1. सेटिंग्स सहेजें
1. वितरण केंद्र सेटिंग्स से वेबहुक यूआरएल कॉपी करें।<br>
![Webhook url](/_assets/java/java-azure/webhook-url.png)<br>
1. Docker Hub पर जाएँ, अपने रिपॉजिटरी का चयन करें और वेबहुक्स चुनें।
1. Azure से 'Webhook url' को Docker Hub के वेबहुक URL में पेस्ट करें और नाम सेट करें।<br>
![Webhook settings in docker](/_assets/java/java-azure/webhook.png)<br>
1. बनाएँ बटन पर क्लिक करें।
1. azure function की समग्रता पर लौटें और कंटेनर शुरू करें।<br>
![Overview menu](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
फ़ंक्शन प्रारंभ होने में कुछ मिनट लग सकते हैं।
{{% /alert %}}

## निष्पादन उदाहरण

1. Postman सेटिंग।<br>
![Overview menu](/_assets/java/java-azure/postman-settings.png)<br>
1. किसी भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल का चयन करें।
1. भेजें बटन पर क्लिक करें।
1. परिणाम सहेजें
![Save responce](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
यदि उत्तर सफल होता है, तो फ़ाइल को सहेजें पर क्लिक करें और आप png प्रारूप में परिवर्तित फ़ाइल प्राप्त करेंगे
{{% /alert %}}

## अधिक उदाहरण

Docker में Aspose.CAD का उपयोग करने के अधिक नमूनों के लिए, [उदाहरण](https://github.com/aspose-cad/Aspose.CAD-Documentation) देखें।


## संबंधित लिंक

- [Windows पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-windows/install/)
- [Mac पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Linux कंटेनरों में स्विच करें](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) विकल्प
