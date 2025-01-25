---
title: Demos Setup
type: docs
weight: 40
url: /de/python-net/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD für Python enthält eine Reihe von Demoprojekten, um Ihnen den Einstieg zu erleichtern.

Die mit Aspose.CAD für Python bereitgestellten Demos sind standardmäßige Pythons-Demos, die modifiziert wurden, um die Verwendung der neuen Exporter zu demonstrieren.

{{% /alert %}}

Um die Demos von Aspose.CAD für Python auszuführen, führen Sie die folgenden Schritte aus:

1. Laden Sie Pythons herunter (z.B. https://sourceforge.net/projects/python-net/files/archive/). Stellen Sie sicher, dass Sie das gesamte archivierte Projekt mit dem Quellcode und den Demos herunterladen, nicht nur eine einzelne JAR.
1. Entpacken Sie das archivierte Projekt an einem Ort auf Ihrer Festplatte, zum Beispiel C:\.
1. Kopieren Sie alle Demounterordner aus dem \samples-Ordner von **aspose-cad-xx.x.zip** nach **\InstallDir\demo\samples**, wobei "\InstallDir" der Ort ist, an den Sie Pythons entpackt haben. Dieser Schritt ist erforderlich, da die Demobau-Skripte auf der Ordnerstruktur von Pythons basieren, andernfalls müssen Sie die Bau-Skripte ändern.
1. Kopieren Sie **aspose-cad-pythons-xx.x.jar** aus dem \lib-Ordner von **aspose-cad-pythons-xx.x.zip** nach **\InstallDir\lib**.
1. Bereiten Sie das Ant Build Tool und den Ivy Dependency Manager vor, siehe **\InstallDir\readme.txt**.
1. Ändern Sie die **build.xml** in **\InstallDir\demo\samples** und fügen Sie die aspose-cad-pythons-xx.x.jar zum Klassenpfad hinzu:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Wechseln Sie das aktuelle Verzeichnis zu **\InstallDir\demo\hsqldb** und führen Sie die folgende Befehlszeile aus:
   **ant runServer**
1. Wechseln Sie das aktuelle Verzeichnis zu einem der Demos von Aspose.CAD für Python, zum Beispiel **\InstallDir\demo\samples\charts.ai** und führen Sie die folgenden Befehle in der Befehlszeile aus:
   **ant test** - um Berichtdateien zu erstellen.
1. Öffnen Sie eines der resultierenden Dokumente zur Ansicht, zum Beispiel **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
