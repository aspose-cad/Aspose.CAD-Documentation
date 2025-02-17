---
title: डेमो सेटअप
type: docs
weight: 40
url: /hi/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports में आपको शुरुआत करने में मदद करने के लिए कई डेमो प्रोजेक्ट शामिल हैं।

Aspose.CAD for JasperReports के साथ प्रदान किए गए डेमो मानक JasperReports डेमो हैं जिन्हें नए निर्यातकों के उपयोग का प्रदर्शन करने के लिए संशोधित किया गया है।

{{% /alert %}}

Aspose.CAD for JasperReports डेमो चलाने के लिए, निम्नलिखित कदम उठाएँ:

1. JasperReports डाउनलोड करें (जैसे https://sourceforge.net/projects/jasperreports/files/archive/)। सुनिश्चित करें कि आप स्रोत कोड और डेमो के साथ संपूर्ण संग्रहित प्रोजेक्ट डाउनलोड करते हैं, न कि सिर्फ एकल JAR।
1. संग्रहित प्रोजेक्ट को अपने हार्ड डिस्क पर किसी स्थान पर अनपैक करें, उदाहरण के लिए C:\।
1. **aspose-cad-xx.x.zip** के **\samples** फ़ोल्डर से सभी डेमो फ़ोल्डर को **\InstallDir\demo\samples** में कॉपी करें, जहां "\InstallDir" वह स्थान है जहाँ आपने JasperReports को अनपैक किया है। यह कदम आवश्यक है क्योंकि डेमो बिल्ड स्क्रिप्ट्स JasperReports के फ़ोल्डर संरचना पर निर्भर करती हैं, अन्यथा आपको बिल्ड स्क्रिप्ट्स में संशोधन करना पड़ेगा।
1. **aspose-cad-jasperreports-xx.x.jar** को **aspose-cad-jasperreports-xx.x.zip** के **\lib** फ़ोल्डर से **\InstallDir\lib** में कॉपी करें।
1. Ant Build Tool और Ivy Dependency Manager तैयार करें, देखें **\InstallDir\readme.txt**।
1. **\InstallDir\demo\samples** पर **build.xml** में संशोधन करें, classpath में aspose-cad-jasperreports-xx.x.jar जोड़ें:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. वर्तमान निर्देशिका को **\InstallDir\demo\hsqldb** पर बदलें और निम्नलिखित कमांड लाइन चलाएँ:
   **Ant runServer**
1. वर्तमान निर्देशिका को Aspose.CAD for JasperReports डेमो में से एक पर बदलें, उदाहरण के लिए **\InstallDir\demo\samples\charts.ai** और कमांड लाइन में निम्नलिखित कमांड चलाएँ:
   **ant test** - रिपोर्ट फ़ाइलें उत्पन्न करने के लिए।
1. प्राप्त दस्तावेज़ों में से एक को देखने के लिए खोलें, उदाहरण के लिए **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**।
