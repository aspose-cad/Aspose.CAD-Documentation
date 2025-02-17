---
title: लाइसेंसिंग
type: docs
weight: 40
url: /hi/python-net/getting-started/licensing/
---
## **Call setLicense**
एक लाइसेंस लागू करने के लिए:

लाइसेंस फ़ाइल को अपने डिस्क पर एक फ़ोल्डर में सहेजें। उदाहरण के लिए C:\Lic\Aspose.CAD.Python.lic।
License.set_license(filename) विधि को कॉल करें और फ़ाइल नाम को एक तर्क के रूप में पास करें। जब इस वाक्य को कॉल किया जाएगा, तो लाइसेंस सेट किया जाएगा और छवियों के शीर्ष पर मूल्यांकन संदेश फिर से नहीं दिखाई देगा।
निम्नलिखित कोड स्निपेट Aspose.CAD के लिए Python के लिए लाइसेंस सेट करता है।

{{< highlight java >}}

// लाइसेंस सेट करें

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

आपको प्रक्रिया या एप्लिकेशन प्रति केवल एक बार set_license() विधि को कॉल करने की आवश्यकता है।

{{% /alert %}}

## **Set the license Exporter Parameter in applicationContext.xm**
{{% alert color="primary" %}}
यह विधि JasperServer के साथ उपयोग के लिए लागू है।
{{% /alert %}}
1. लाइसेंस को अपने कंप्यूटर पर डाउनलोड करें और इसे \apache-tomcat\webapps\jasperserver\WEB-INF फ़ोल्डर में कॉपी करें, जहां JasperServer स्थापना निर्देशिका के लिए खड़ा है।
2. \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml फ़ाइल को ढूंढें और निम्नलिखित पंक्तियाँ जोड़ें:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
