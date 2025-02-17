---
title: लाइसेंसिंग
type: docs
weight: 40
url: /hi/jasperreports/getting-started/licensing/
---
## **Call setLicense**
लाइसेंस लागू करने के लिए:

लाइसेंस फ़ाइल को अपने डिस्क पर एक फ़ोल्डर में सहेजें। उदाहरण के लिए C:\Lic\Aspose.CAD.JasperReport.lic।
License.setLicense(filename) विधि को कॉल करें और फ़ाइल नाम को एक तर्क के रूप में पास करें। जब यह कथन कॉल किया जाता है, तो लाइसेंस सेट हो जाता है और मूल्यांकन संदेश चित्रों के शीर्ष पर अब नहीं दिखाई देगा।
निम्नलिखित कोड स्निपेट Aspose.CAD के लिए JasperReports के लिए लाइसेंस सेट करता है।

{{< highlight java >}}

// लाइसेंस सेट करें

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

आपको प्रक्रिया या आवेदन के लिए केवल एक बार setLicense() विधि को कॉल करने की आवश्यकता है।

{{% /alert %}}

## **Set the license Exporter Parameter in applicationContext.xml**
{{% alert color="primary" %}}
यह विधि JasperServer के साथ उपयोग के लिए लागू है।
{{% /alert %}}
1. लाइसेंस अपने कंप्यूटर पर डाउनलोड करें और इसे \apache-tomcat\webapps\jasperserver\WEB-INF फ़ोल्डर में कॉपी करें, जहाँ JasperServer इंस्टॉलेशन निर्देशिका का प्रतिनिधित्व करता है।
2. \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml फ़ाइल को खोजें और निम्नलिखित पंक्तियों को जोड़ें:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
