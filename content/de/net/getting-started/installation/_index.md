---
title: Installation
type: docs
weight: 30
url: /de/net/installation/
---

## **Installation von Aspose.CAD für .NET über NuGet**

NuGet ist der einfachste Weg, um Aspose APIs für .NET herunterzuladen und zu installieren. Öffnen Sie Microsoft Visual Studio und den NuGet-Paket-Manager. Suchen Sie nach "aspose", um die gewünschte Aspose API zu finden. Klicken Sie auf "Installieren", die ausgewählte API wird heruntergeladen und in Ihrem Projekt referenziert.

![todo:image_alt_text](/_assets/installation_1.png)

## **Referenzierung von Aspose.CAD aus einem .NET Projekt**

Befolgen Sie diese Schritte (vorausgesetzt, Sie verwenden Microsoft Visual Studio):

1. Erweitern Sie im **Projektmappen-Explorer** den Projektknoten, zu dem Sie eine Referenz hinzufügen möchten.
1. Klicken Sie mit der rechten Maustaste auf den **Verweise**-Knoten für das Projekt und wählen Sie im Kontextmenü **Verweis hinzufügen**.
1. Im Dialogfeld **Verweis hinzufügen** durchsuchen Sie den Speicherort der DLL-Datei.
1. Wählen Sie die *Aspose.CAD* DLL-Datei aus und klicken Sie auf die Schaltfläche **OK**.
1. Die *Aspose.CAD* Referenz erscheint unter dem **Verweise**-Knoten Ihres Projekts.

![todo:image_alt_text](/_assets/installation_2.png)

### **Installieren oder Aktualisieren von Aspose.CAD über die Paket-Manager-Konsole**

Sie können die folgenden Schritte befolgen, um die [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) über die Paket-Manager-Konsole zu referenzieren:

1. Öffnen Sie Ihre Lösung/Ihr Projekt in Visual Studio.
1. Wählen Sie im Menü Werkzeuge -> Paket-Manager -> Paket-Manager-Konsole, um die Paket-Manager-Konsole zu öffnen.

![todo:image_alt_text](/_assets/installation_3.png)

Geben Sie den Befehl “**Install-Package Aspose.CAD**” ein und drücken Sie die Eingabetaste, um die neueste Vollversion in Ihre Anwendung zu installieren. Alternativ können Sie das "**-prerelease**" Suffix an den Befehl anhängen, um anzugeben, dass die neueste Version, einschließlich Hotfixes, ebenfalls installiert werden soll.

![todo:image_alt_text](/_assets/installation_4.png)

Sie werden sehen, dass der Hinweis "Aspose.CAD wird heruntergeladen..." unten links im Fenster erscheint, was darauf hinweist, dass der Download in Bearbeitung ist.

![todo:image_alt_text](/_assets/installation_5.png)

Sobald der Download abgeschlossen ist, sehen Sie die folgenden Bestätigungsnachrichten. Wenn Sie mit der [Aspose EULA](https://about.aspose.com/legal/eula) nicht vertraut sind, ist es eine gute Idee, die im URL referenzierte Lizenz zu lesen.

![todo:image_alt_text](/_assets/installation_6.png)

Sie sollten jetzt feststellen, dass Aspose.CAD erfolgreich in Ihrer Anwendung hinzugefügt und referenziert wurde.

![todo:image_alt_text](/_assets/installation_7.png)

In der Paket-Manager-Konsole können Sie auch den Befehl “**Update-Package Aspose.CAD**” verwenden und die Eingabetaste drücken, um nach Updates des Aspose.CAD-Pakets zu suchen und sie ggf. zu installieren. Sie können auch das Suffix "-prerelease" hinzufügen, um die neueste Version zu aktualisieren.

## **Überlegungen bei der Ausführung in einer gemeinsam genutzten Serverumgebung**

Alle Aspose .NET Komponenten wird empfohlen, mit dem Vollzugriffsberechtigungssatz ausgeführt zu werden. Dies liegt daran, dass Aspose .NET Komponenten manchmal auf Registrierungseinstellungen und Dateien zugreifen müssen, die sich an anderen Orten als dem virtuellen Verzeichnis befinden, z.B. um Schriftarten zu lesen usw. Darüber hinaus basieren Aspose.NET Komponenten auf den Kernklassen des .NET-Systems, von denen einige ebenfalls Vollzugriffsrechte benötigen, um in einigen Fällen ordnungsgemäß ausgeführt zu werden.

Internetdienstanbieter, die mehrere Anwendungen von verschiedenen Unternehmen hosten, erzwingen meistens das Sicherheitsniveau "Mittlerer Zugriff". Im Falle von .NET 2.0 kann ein solches Sicherheitsniveau die folgenden Einschränkungen festlegen, die die Fähigkeit von Aspose.CAD beeinträchtigen könnten, ordnungsgemäß zu funktionieren.

- **RegistryPermission** ist nicht verfügbar. Dies bedeutet, dass Sie nicht auf die Registrierung zugreifen können, was erforderlich ist, um installierte Schriftarten beim Rendern von Dokumenten aufzulisten.
- **FileIOPermission** ist eingeschränkt. Dies bedeutet, dass Sie nur auf Dateien in der Verzeichnisstruktur Ihrer Anwendung zugreifen können. Dies bedeutet möglicherweise, dass Schriftarten während des Exports nicht gelesen werden können.

Aus den oben genannten Gründen wird empfohlen, dass Aspose.CAD mit Vollzugriffsrechten ausgeführt wird. Möglicherweise stellen Sie fest, dass einige Funktionen der Bibliothek beim Ausführen unterschiedlicher Aufgaben mit mittlerem Zugriff funktionieren, während andere nicht funktionieren (z.B. Rendering), was aufgrund von Aufrufen zur GDI+-Bildverarbeitung der Fall sein kann.

## **Systemanforderungen**

### **Betriebssysteme**

Aspose.CAD für .NET unterstützt jedes 32-Bit- oder 64-Bit-Betriebssystem, auf dem das .NET- oder Mono-Framework installiert ist, einschließlich, aber nicht beschränkt auf:

- Microsoft Windows Desktop (XP, Vista, 7, 8, 10) und Serverbetriebssysteme (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS und andere)
- Mac OS X

### **Frameworks**

Aspose.CAD für .NET unterstützt:

- .NET Framework-Versionen von 2.0 bis 4.5 einschließlich Client-Profil-Versionen
- .NET Core
- Mono 2.6.7 oder höher

### **Entwicklungsumgebungen**

Sie können Aspose.CAD für .NET verwenden, um Anwendungen in jeder Entwicklungsumgebung zu entwickeln, die sich an die .NET-Plattform richtet, jedoch werden die folgenden Umgebungen ausdrücklich unterstützt:

- Microsoft Visual Studio 2010 oder höher
- MonoDevelop 2.4 und später
