---
title: डेमो स्थापना
type: docs
weight: 40
url: /hi/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for Python में कई डेमो प्रोजेक्ट शामिल हैं जो आपको प्रारंभ करने में मदद करते हैं।

Aspose.CAD for Python के साथ प्रदान किए गए डेमो मानक पायथन डेमो हैं जिन्हें नए एक्सपोर्टर्स का उपयोग दिखाने के लिए संशोधित किया गया है।

{{% /alert %}}

Aspose.CAD for Python डेमो चलाने के लिए, निम्नलिखित चरणों का पालन करें:

1. पायथन डाउनलोड करें (जैसे https://sourceforge.net/projects/python-net/files/archive/)। सुनिश्चित करें कि आप स्रोत कोड और डेमो के साथ संपूर्ण संग्रहित प्रोजेक्ट डाउनलोड करें, केवल एकल JAR नहीं।
1. संग्रहित प्रोजेक्ट को अपने हार्ड डिस्क पर किसी स्थान पर अनपैक करें, उदाहरण के लिए C:\।
1. **aspose-cad-xx.x.zip** के \samples फ़ोल्डर से सभी डेमो फ़ोल्डर को **\InstallDir\demo\samples** में कॉपी करें, जहाँ "\InstallDir" वह स्थान है जहाँ आपने पायथन को अनपैक किया है। यह कदम आवश्यक है क्योंकि डेमो बिल्ड स्क्रिप्ट पायथन के फ़ोल्डर संरचना पर निर्भर करती हैं, अन्यथा आपको बिल्ड स्क्रिप्ट को संशोधित करना होगा।
1. **aspose-cad-pythons-xx.x.jar** को **aspose-cad-pythons-xx.x.zip** के \lib फ़ोल्डर से **\InstallDir\lib** में कॉपी करें।
1. एंट बिल्ड टूल और आइवी डिपेंडेंसी मैनेजर तैयार करें, देखें **\InstallDir\readme.txt**।
1. **\InstallDir\demo\samples** में **build.xml** को संशोधित करें, classpath में aspose-cad-pythons-xx.x.jar जोड़ें:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. वर्तमान निर्देशिका को **\InstallDir\demo\hsqldb** में बदलें और निम्नलिखित कमांड लाइन चलाएँ:
   **ant runServer**
1. वर्तमान निर्देशिका को Aspose.CAD for Python के डेमो में से एक में बदलें, उदाहरण के लिए **\InstallDir\demo\samples\charts.ai** और कमांड लाइन में निम्नलिखित कमांड चलाएँ:
   **ant test** - रिपोर्ट फ़ाइलें बनाने के लिए।
1. परिणामस्वरूप दस्तावेज़ों में से एक खोलें, उदाहरण के लिए **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**।
