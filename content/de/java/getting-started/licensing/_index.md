---
title: Lizenzierung
type: docs
weight: 50
url: /de/java/licensing/
---

{{% alert color="primary" %}}

Sie können eine Evaluierungsversion von **Aspose.CAD** für Java von [ihrer Download-Seite](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) herunterladen. Die Evaluierungsversion bietet genau die gleichen Funktionen wie die lizenzierte Version des Produkts. Darüber hinaus wird die Evaluierungsversion einfach lizenziert, wenn Sie eine Lizenz erwerben und ein paar Zeilen Code hinzufügen, um die Lizenz anzuwenden.

Sobald Sie mit Ihrer Evaluierung von **Aspose.CAD** zufrieden sind, können Sie eine [Lizenz erwerben](https://purchase.aspose.com/buy) auf der Aspose-Website. Machen Sie sich mit den verschiedenen angebotenen Abonnementtypen vertraut. Wenn Sie Fragen haben, zögern Sie nicht, das Aspose-Verkaufsteam zu kontaktieren.

Jede Aspose-Lizenz beinhaltet ein einjähriges Abonnement für kostenlose Upgrades auf alle neuen Versionen oder Fixes, die während dieser Zeit veröffentlicht werden. Der technische Support ist kostenlos und unbegrenzt und wird sowohl lizenzierten als auch Evaluierungsnutzern angeboten.

{{% /alert %}}

Wenn Sie **Aspose.CAD** ohne die Einschränkungen der Evaluierungsversion testen möchten, fordern Sie eine 30-tägige temporäre Lizenz an. Bitte beachten Sie [Wie man eine temporäre Lizenz erhält?](https://purchase.aspose.com/temporary-license) für weitere Informationen.

## **Lizenz festlegen**

Die Lizenz ist eine einfache XML-Datei, die Details wie den Produktnamen, die Anzahl der lizenzierten Entwickler, das Ablaufdatum des Abonnements usw. enthält. Die Datei ist digital signiert, daher sollten Sie die Datei nicht ändern; selbst das versehentliche Hinzufügen eines zusätzlichen Zeilenumbruchs in die Datei macht sie ungültig.

Sie müssen eine Lizenz festlegen, bevor Sie irgendwelche Operationen mit AutoCAD-Dateien durchführen. Es ist erforderlich, die Lizenz einmal pro Anwendung oder Prozess festzulegen.

Die Lizenz kann aus einem Stream oder einer Datei an den folgenden Positionen geladen werden:

1. Expliziter Pfad.
1. Der Ordner, der die Aspose.CAD.jar-Datei enthält.

Verwenden Sie die License.setLicense() Methode, um das Komponente zu lizenzieren. Oft ist es am einfachsten, die Lizenzdatei in denselben Ordner wie Aspose.CAD.jar zu legen und nur den Dateinamen ohne Pfad anzugeben, wie im folgenden Beispiel gezeigt:

### **Beispiel 1**

In diesem Beispiel wird **Aspose.CAD** versuchen, die Lizenzdatei im Ordner zu finden, der die JARs Ihrer Anwendung enthält.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Beispiel 2**

Initialisiert eine Lizenz aus einem Stream.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Lizenz validieren**

Es ist möglich zu überprüfen, ob die Lizenz ordnungsgemäß festgelegt wurde oder nicht. Die License-Klasse verfügt über das Feld isLicensed, das true zurückgibt, wenn die Lizenz ordnungsgemäß festgelegt wurde.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Lizenz wurde festgelegt!");

}

{{< /highlight >}}
