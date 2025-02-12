---
title: Demos Einrichtung
type: docs
weight: 40
url: /de/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD für JasperReports enthält eine Reihe von Demoprojekten, um Ihnen den Einstieg zu erleichtern.

Die mit Aspose.CAD für JasperReports bereitgestellten Demos sind Standard-JasperReports-Demos, die modifiziert wurden, um die Verwendung der neuen Exporteure zu demonstrieren.

{{% /alert %}}

Um die Demos für Aspose.CAD für JasperReports auszuführen, führen Sie die folgenden Schritte aus:

1. Laden Sie JasperReports herunter (z.B. https://sourceforge.net/projects/jasperreports/files/archive/). Stellen Sie sicher, dass Sie das gesamte archivierte Projekt mit dem Quellcode und den Demos herunterladen, nicht nur ein einzelnes JAR.
1. Entpacken Sie das archivierte Projekt an einem beliebigen Ort auf Ihrer Festplatte, z.B. C:\.
1. Kopieren Sie alle Demomappen aus dem \samples-Ordner von **aspose-cad-xx.x.zip** nach **\InstallDir\demo\samples**, wobei "\InstallDir" der Ort ist, an dem Sie JasperReports entpackt haben. Dieser Schritt ist erforderlich, da die Demo-Bauskripte auf der Ordnerstruktur von JasperReports beruhen. Andernfalls müssen Sie die Bauskripte anpassen.
1. Kopieren Sie **aspose-cad-jasperreports-xx.x.jar** aus dem \lib-Ordner von **aspose-cad-jasperreports-xx.x.zip** nach **\InstallDir\lib**.
1. Bereiten Sie das Ant Build Tool und den Ivy Dependency Manager vor, siehe **\InstallDir\readme.txt**.
1. Ändern Sie die **build.xml** in **\InstallDir\demo\samples**, fügen Sie das aspose-cad-jasperreports-xx.x.jar dem Klassenpfad hinzu:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Wechseln Sie in das Verzeichnis **\InstallDir\demo\hsqldb** und geben Sie folgenden Befehl in der Befehlszeile ein:
   **Ant runServer**
1. Wechseln Sie in das Verzeichnis einer der Demos für Aspose.CAD für JasperReports, z.B. **\InstallDir\demo\samples\charts.ai** und führen Sie die folgenden Befehle in der Befehlszeile aus:
   **ant test** - um Berichtsdateien zu erstellen.
1. Öffnen Sie eines der resultierenden Dokumente zur Ansicht, z.B. **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
