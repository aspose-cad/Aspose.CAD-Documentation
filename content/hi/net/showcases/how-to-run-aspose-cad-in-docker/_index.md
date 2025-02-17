---
title: Aspose.CAD को डॉकर में कैसे चलाएं
type: docs
description: "Linux, Windows Server और किसी भी OS के लिए डॉकर कंटेनर में Aspose.CAD चलाएं।"
weight: 71
url: /hi/net/showcases/how-to-run-aspose-cad-in-docker/
---

## आवश्यकताएँ
- आपके सिस्टम पर डॉकर स्थापित होना चाहिए। Windows या Mac पर डॉकर कैसे स्थापित करें, इस बारे में जानकारी के लिए “देखें” अनुभाग में लिंक देखें।
- विज़ुअल स्टूडियो 2022।
- उदाहरण में .NET 6 SDK का उपयोग किया गया है।

## हेलो वर्ल्ड एप्लिकेशन

इस उदाहरण में, आप एक साधारण हेलो वर्ल्ड कंसोल एप्लिकेशन बनाते हैं जो एक अंडाकार बनाता है और उसे एक चित्र के रूप में सहेजता है। फिर एप्लिकेशन को डॉकर में बनाया और चलाया जा सकता है।

## कंसोल एप्लिकेशन बनाना

हेलो वर्ल्ड प्रोग्राम बनाने के लिए, नीचे दिए गए चरणों का पालन करें:
1. एक बार डॉकर स्थापित हो जाने के बाद, सुनिश्चित करें कि यह लिनक्स कंटेनरों का उपयोग करता है (डिफ़ॉल्ट)। यदि आवश्यक हो, तो डॉकर डेस्कटॉप मेनू से लिनक्स कंटेनरों में स्विच करने का विकल्प चुनें।
1. विज़ुअल स्टूडियो में, एक .NET 6 कंसोल एप्लिकेशन बनाएं।<br>
![एक .NET 6 कंसोल एप्लिकेशन प्रोजेक्ट संवाद](/_assets/showcases/docker/1.png)<br>
1. NuGet से नवीनतम Aspose.CAD संस्करण स्थापित करें।<br>
![NuGet पर Aspose.CAD](/_assets/showcases/docker/2.png)<br>
1. चूंकि एप्लिकेशन लिनक्स पर चलाया जाएगा, इसलिए आपको अतिरिक्त फ़ॉन्ट्स स्थापित करने की आवश्यकता हो सकती है। आप ttf-mscorefonts-installer को प्राथमिकता दे सकते हैं।
1. जब सभी आवश्यक निर्भरताएँ जोड़ दी जाएँ, तो एक साधारण प्रोग्राम लिखें जो एक अंडाकार बनाता है और उसे एक चित्र के रूप में सहेजता है:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

ध्यान दें कि "TestOut" फ़ोल्डर को आउटपुट दस्तावेज़ों को सहेजने के लिए आउटपुट फ़ोल्डर के रूप में निर्दिष्ट किया गया है। जब डॉकर में एप्लिकेशन चलाया जाता है, तो एक फ़ोल्डर होस्ट मशीन पर इस फ़ोल्डर में कंटेनर में माउंट किया जाएगा। इससे आपको डॉकर कंटेनर में Aspose.CAD द्वारा उत्पन्न आउटपुट को आसानी से देखने की सुविधा मिलेगी।

### डॉकरफाइल कॉन्फ़िगर करना

 अगला चरण डॉकरफाइल बनाना और कॉन्फ़िगर करना है।

1. डॉकरफाइल बनाएँ और इसे आपके एप्लिकेशन की समाधान फ़ाइल के बगल में रखें। इस फ़ाइल का नाम बिना एक्सटेंशन के (डिफ़ॉल्ट) रखें।
1. डॉकरफाइल में, निर्दिष्ट करें:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

उपरोक्त एक सरल डॉकरफाइल है, जिसमें निम्नलिखित निर्देश शामिल हैं:

- उपयोग करने के लिए SDK छवि। यहाँ यह Net 6 छवि है। डॉकर इसे बनावट चलने पर डाउनलोड करेगा। SDK का संस्करण एक टैग के रूप में निर्दिष्ट किया गया है।
- इसके बाद, आपको फ़ॉन्ट्स स्थापित करने की आवश्यकता हो सकती है क्योंकि SDK छवि में बहुत कम फ़ॉन्ट्स होते हैं। इसके अलावा, आप स्थानीय फ़ॉन्ट्स का उपयोग कर सकते हैं जो डॉकर छवि में कॉपी किए जाएँगे।
- कार्यशील निर्देशिका, जिसे अगले पंक्ति में निर्दिष्ट किया गया है।
- कंटेनर में सब कुछ कॉपी करने, एप्लिकेशन प्रकाशित करने, और प्रवेश स्थान spécifier करने का आदेश। 


## डॉकर में एप्लिकेशन बनाना और चलाना
 
अब एप्लिकेशन को डॉकर में बनाया और चलाया जा सकता है। अपनी पसंद के कमांड प्रॉम्प्ट को खोलें, एप्लिकेशन के फ़ोल्डर में निर्देशिका बदलें (जिस फ़ोल्डर में समाधान फ़ाइल और डॉकरफाइल रखी गई है) और निम्नलिखित आदेश चलाएँ:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

पहली बार इस आदेश को चलाने पर इसे अधिक समय लग सकता है, क्योंकि डॉकर को आवश्यक छवियों को डाउनलोड करने की आवश्यकता होती है। एक बार पिछले आदेश के पूरा होने पर, निम्नलिखित आदेश चलाएँ:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
माउंट तर्क पर ध्यान दें, क्योंकि, जैसा कि पहले उल्लेख किया गया है, होस्ट मशीन पर एक फ़ोल्डर कंटेनर के फ़ोल्डर में माउंट किया गया है, ताकि एप्लिकेशन निष्पादन के परिणामों को आसानी से देख सकें। लिनक्स में पथ केस संवेदनशील होते हैं।
{{% /alert %}}

## अधिक उदाहरण

डॉकर में Aspose.CAD का उपयोग करने के और अधिक उदाहरणों के लिए, [उदाहरण](https://github.com/aspose-cad/Aspose.CAD-Documentation) देखें।

## देखें 

- [Windows पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-windows/install/)
- [Mac पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-mac/install/)
- [विज़ुअल स्टूडियो 2022, .NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [लिनक्स कंटेनरों में स्विच करें](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) विकल्प
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) पर अतिरिक्त जानकारी
