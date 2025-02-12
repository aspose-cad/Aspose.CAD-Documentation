---
title: Άδειες
type: docs
weight: 40
url: /el/jasperreports/getting-started/licensing/
---
## **Κλήση setLicense**
Για να εφαρμόσετε μια άδεια:

Αποθηκεύστε το αρχείο άδειας σε έναν φάκελο στον δίσκο σας. Για παράδειγμα C:\Lic\Aspose.CAD.JasperReport.lic.
Καλέστε τη μέθοδο License.setLicense(filename) και περάστε το όνομα του αρχείου ως παράμετρο. Όταν καλεστεί αυτή η δήλωση, η άδεια ρυθμίζεται και το μήνυμα αξιολόγησης δεν θα εμφανίζεται πια πάνω από τις εικόνες.
Το παρακάτω απόσπασμα κώδικα ρυθμίζει την άδεια για το Aspose.CAD για JasperReports.

{{< highlight java >}}

// Ρύθμιση άδειας

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Πρέπει να καλέσετε τη μέθοδο setLicense() μόνο μία φορά ανά διαδικασία ή εφαρμογή.

{{% /alert %}}

## **Ρύθμιση της άδειας παραμέτρου εξαγωγής στο applicationContext.xml**
{{% alert color="primary" %}}
Αυτή η μέθοδος είναι εφαρμόσιμη για χρήση με το JasperServer.
{{% /alert %}}
1. Κατεβάστε την άδεια στον υπολογιστή σας και αντιγράψτε την στο φάκελο \apache-tomcat\webapps\jasperserver\WEB-INF, όπου αναφέρεται ο φάκελος εγκατάστασης του JasperServer.
2. Εντοπίστε το αρχείο \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml και προσθέστε τις παρακάτω γραμμές:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
