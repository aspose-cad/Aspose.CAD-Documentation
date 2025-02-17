---
title: רישוי
type: docs
weight: 40
url: /he/python-net/getting-started/licensing/
---
## **קרא setLicense**
כדי להחיל רישוי:

שמור את קובץ הרישוי בתיקיה בכונן שלך. לדוגמה C:\Lic\Aspose.CAD.Python.lic.
קרא למתודת License.set_license(filename) ועבר את שם הקובץ כארגומנט. כאשר הצהרה זו נקראת, הרישוי מוצג וההודעת הערכה לא תופיע יותר בראש התמונות.
קטע הקוד הבא מגדיר את הרישוי עבור Aspose.CAD עבור Python.

{{< highlight java >}}

// הגדרת רישוי

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

עליך לקרוא למתודת set_license() רק פעם אחת לכל תהליך או יישום.

{{% /alert %}}

## **הגדרת פרמטר המייצא את הרישוי ב-applicationContext.xml**
{{% alert color="primary" %}}
שיטה זו מתאימה לשימוש עם JasperServer.
{{% /alert %}}
1. הורד את הרישוי למחשב שלך והעתק אותו לתיקיית \apache-tomcat\webapps\jasperserver\WEB-INF, שם עומד תור הרישוי להתקנת JasperServer.
2. מצא את הקובץ \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml והוסף את השורות הבאות:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
