---
title: Demos Instellen
type: docs
weight: 40
url: /nl/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD voor Python bevat een aantal demo-projecten om je op weg te helpen.

De demo's die worden geleverd met Aspose.CAD voor Python zijn standaard Python-demo's die zijn aangepast om het gebruik van de nieuwe exporteurs te demonstreren.

{{% /alert %}}

Om de Aspose.CAD voor Python-demo's uit te voeren, volg je de volgende stappen:

1. Download Python (bijv. https://sourceforge.net/projects/python-net/files/archive/). Zorg ervoor dat je het volledige gecomprimeerde project met de broncode en demo's downloadt, niet alleen een enkele JAR.
2. Pak het gecomprimeerde project uit naar een locatie op je harde schijf, bijvoorbeeld C:\.
3. Kopieer alle demo-mappen van de \samples-map van **aspose-cad-xx.x.zip** naar **\InstallDir\demo\samples**, waar "\InstallDir" de locatie is waar je Python hebt uitgepakt. Deze stap is vereist omdat de demo-buildscripts afhankelijk zijn van de Python-mappenstructuur, anders moet je de buildscripts aanpassen.
4. Kopieer **aspose-cad-pythons-xx.x.jar** van de \lib-map van **aspose-cad-pythons-xx.x.zip** naar **\InstallDir\lib**.
5. Bereid de Ant Build Tool en Ivy Dependency Manager voor, zie **\InstallDir\readme.txt**.
6. Wijzig de **build.xml** in **\InstallDir\demo\samples**, voeg de aspose-cad-pythons-xx.x.jar toe aan de classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
7. Verander de huidige map naar **\InstallDir\demo\hsqldb** en voer de volgende opdrachtregel uit:
   **ant runServer**
8. Verander de huidige map naar een van de Aspose.CAD voor Python-demo's, bijvoorbeeld **\InstallDir\demo\samples\charts.ai** en voer de volgende opdrachten in de opdrachtregel uit:
   **ant test** - om rapportbestanden te genereren.
9. Open een van de resulterende documenten om te bekijken, bijvoorbeeld **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
