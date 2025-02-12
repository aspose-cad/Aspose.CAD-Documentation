---
title: Lizenzierung
type: docs
weight: 50
url: /de/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Sobald Sie mit Ihrer Bewertung von Aspose.CAD für .NET zufrieden sind, kaufen Sie eine Lizenz auf der Aspose-Website: [Kauf-Portal](https://purchase.aspose.com/buy). Machen Sie sich mit den verschiedenen verfügbaren Lizenztypen vertraut. Wenn Sie Fragen haben, [kontaktieren Sie das Aspose-Verkaufsteam](https://about.aspose.com/contact) und sie helfen Ihnen gerne weiter.

Jede Aspose-Lizenz beinhaltet ein einjähriges Abonnement für kostenlose Upgrades auf alle neuen Versionen oder Fehlerbehebungen, die in dieser Zeit veröffentlicht werden. Wir bieten sowohl lizenzierten als auch Evaluierungsbenutzern kostenlosen und unbegrenzten technischen Support.

Die Lizenz ist eine einfache Text-XML-Datei, die Details enthält, wie z.B. den Produktnamen, die Anzahl der lizenzierten Entwickler, das Ablaufdatum des Abonnements usw. Die Datei ist digital signiert, daher bearbeiten Sie die Datei nicht: Selbst das Hinzufügen eines zusätzlichen Zeilenumbruchs zur Datei macht sie ungültig.

{{% /alert %}}

## **Wann man eine Lizenz anwenden sollte**

Befolgen Sie diese einfachen Regeln:

- Die Lizenz muss nur einmal pro Anwendungsdomäne festgelegt werden.
- Sie müssen die Lizenz festlegen, bevor Sie andere Aspose.CAD-Klassen verwenden.
- Das mehrmalige Aufrufen von SetLicense ist nicht schädlich, verschwendet jedoch Prozessorzeit.
- Wenn Sie eine Windows Forms- oder Konsolenanwendung entwickeln, rufen Sie SetLicense im Startcode auf, bevor Sie Aspose.CAD-Klassen verwenden.
- Beim Entwickeln einer ASP.NET-Anwendung rufen Sie SetLicense aus der Global.asax.cs (Global.asax.vb)-Datei im geschützten Anwendungsstartmethoden auf. Es wird einmal aufgerufen, wenn die Anwendung startet.
- Rufen Sie SetLicense nicht innerhalb der Page_Load-Methoden auf, da dies bedeutet, dass die Lizenz jedes Mal geladen wird, wenn eine Webseite geladen wird.
- Wenn Sie eine Klassenbibliothek entwickeln, rufen Sie SetLicense aus einem statischen Konstruktor der Klasse auf, die Aspose.CAD verwendet. Der statische Konstruktor wird aufgerufen, bevor eine Instanz Ihrer Klasse erstellt wird, wodurch sichergestellt wird, dass die Aspose.CAD-Lizenz ordnungsgemäß festgelegt ist.

## **Lizenz anwenden mit einer Datei oder Stream-Objekt**

Verwenden Sie die **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)**-Methode, um die Komponente zu lizenzieren. Der einfachste Weg, eine Lizenz festzulegen, besteht darin, die Lizenzdatei im selben Ordner wie die Aspose.CAD.dll abzulegen und den Dateinamen ohne Pfad anzugeben, wie unten gezeigt.

### **Lizenz aus einer Datei laden**

Dieser Code-Schnipsel initialisiert eine Lizenz, die in einer Datei oder in einer eingebetteten Ressource gespeichert ist.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Lizenz aus einem Stream-Objekt laden**

Dieser Code-Schnipsel initialisiert die Lizenz aus einem Stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
