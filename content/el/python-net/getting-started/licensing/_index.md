---
title: Άδειες
type: docs
weight: 40
url: /el/python-net/getting-started/licensing/
---
## **Καλέστε το setLicense**
Για να εφαρμόσετε μια άδεια:

Αποθηκεύστε το αρχείο άδειας σε έναν φάκελο στον δίσκο σας. Για παράδειγμα C:\Lic\Aspose.CAD.Python.lic.
Καλέστε τη μέθοδο License.set_license(filename) και περάστε το όνομα του αρχείου ως παράμετρο. Όταν καλεστεί αυτή η δήλωση, η άδεια ρυθμίζεται και το μήνυμα αξιολόγησης δεν θα εμφανίζεται πλέον στην κορυφή των εικόνων.
Το παρακάτω απόσπασμα κώδικα ρυθμίζει την άδεια για το Aspose.CAD για Python.

{{< highlight java >}}

// Ρυθμίστε την άδεια

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Πρέπει να καλέσετε τη μέθοδο set_license() μόνο μία φορά ανά διαδικασία ή εφαρμογή.

{{% /alert %}}

## **Ρυθμίστε την παράμετρο άδειας Exporter στο applicationContext.xml**
{{% alert color="primary" %}}
Αυτή η μέθοδος είναι εφαρμόσιμη για χρήση με το JasperServer.
{{% /alert %}}
1. Κατεβάστε την άδεια στον υπολογιστή σας και αντιγράψτε την στο φάκελο \apache-tomcat\webapps\jasperserver\WEB-INF, όπου αντιπροσωπεύει τον φάκελο εγκατάστασης του JasperServer.
2. Βρείτε το αρχείο \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml και προσθέστε τις παρακάτω γραμμές:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
