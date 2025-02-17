---
title: רישוי
type: docs
weight: 40
url: /he/jasperreports/getting-started/licensing/
---
## **קריאה לשיטת setLicense**
כדי להחיל רישיון:

שמור את קובץ הרישיון בתיקיה בדיסק שלך. לדוגמה C:\Lic\Aspose.CAD.JasperReport.lic.
קרא לשיטת License.setLicense(filename) וקבע את שם הקובץ כארגומנט. כאשר תוזמן ההצהרה הזו, הרישיון יוגדר והודעת ההערכה לא תופיע יותר על גבי התמונות.
קטע הקוד הבא מגדיר את הרישיון ל-Aspose.CAD עבור JasperReports.

{{< highlight java >}}

// קביעת רישיון

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

עליך לקרוא לשיטת setLicense() רק פעם אחת לכל תהליך או יישום.

{{% /alert %}}

## **קביעת פרמטר רישוי המופק בקובץ applicationContext.xml**
{{% alert color="primary" %}}
שיטה זו רלוונטית לשימוש עם JasperServer.
{{% /alert %}}
1. הורד את הרישיון למחשב שלך והעבר אותו לתיקיית \apache-tomcat\webapps\jasperserver\WEB-INF, שבה נמצא תיקיית התקנת JasperServer.
2. אתר את הקובץ \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml והוסף את השורות הבאות:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
