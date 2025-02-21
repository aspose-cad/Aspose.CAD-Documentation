---
title: Demos Instellen
type: docs
weight: 40
url: /nl/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD voor JasperReports bevat een aantal demo-projecten om u op weg te helpen.

De demo's die worden aangeboden met Aspose.CAD voor JasperReports zijn standaard JasperReports-demo's die zijn aangepast om het gebruik van de nieuwe exporteurs te demonstreren.

{{% /alert %}}

Volg de onderstaande stappen om de Aspose.CAD voor JasperReports-demo's uit te voeren:

1. Download JasperReports (bijv. https://sourceforge.net/projects/jasperreports/files/archive/). Zorg ervoor dat u het volledige archiefproject met de brontcode en demo's downloadt, niet alleen een enkele JAR.
1. Pak het gearchiveerde project uit naar een locatie op uw harde schijf, bijvoorbeeld C:\.
1. Kopieer alle demo-mappen uit de \samples map van **aspose-cad-xx.x.zip** naar **\InstallDir\demo\samples**, waar "\InstallDir" de locatie is waar u JasperReports heeft uitgepakt. Deze stap is vereist omdat de demo-buildscript afhankelijk zijn van de mappenstructuur van JasperReports, anders moet u de buildscripts aanpassen.
1. Kopieer **aspose-cad-jasperreports-xx.x.jar** uit de \lib map van **aspose-cad-jasperreports-xx.x.zip** naar **\InstallDir\lib**.
1. Bereid Ant Build Tool en Ivy Dependency Manager voor, zie **\InstallDir\readme.txt**.
1. Wijzig de **build.xml** in **\InstallDir\demo\samples**, voeg de aspose-cad-jasperreports-xx.x.jar toe aan het classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Wijzig de huidige directory naar **\InstallDir\demo\hsqldb** en voer de volgende opdrachtregel uit:
   **Ant runServer**
1. Wijzig de huidige directory naar een van de Aspose.CAD voor JasperReports-demo's, bijvoorbeeld **\InstallDir\demo\samples\charts.ai** en voer de volgende opdrachten uit in de opdrachtregel:
   **ant test** - om rapportbestanden te produceren.
1. Open een van de resulterende documenten om te bekijken, bijvoorbeeld **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
