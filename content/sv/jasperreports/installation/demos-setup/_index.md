---
title: Demosinstallation
type: docs
weight: 40
url: /sv/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD för JasperReports inkluderar ett antal demoprojekt för att hjälpa dig att komma igång.

Demos som tillhandahålls med Aspose.CAD för JasperReports är standarddemos för JasperReports som har modifierats för att demonstrera användningen av de nya exportörerna.

{{% /alert %}}

För att köra Aspose.CAD för JasperReports-demos, utför följande steg:

1. Ladda ner JasperReports (t.ex. https://sourceforge.net/projects/jasperreports/files/archive/). Se till att ladda ner hela det arkiverade projektet med källkoden och demona, inte bara en enda JAR.
1. Packa upp det arkiverade projektet till en plats på din hårddisk, till exempel C:\.
1. Kopiera alla demokataloger från \samples-mappen i **aspose-cad-xx.x.zip** till **\InstallDir\demo\samples**, där "\InstallDir" är platsen där du har packat upp JasperReports. Det här steget är nödvändigt eftersom demobyggda skript beror på JasperReports' mappstruktur, annars måste du modifiera byggskripten.
1. Kopiera **aspose-cad-jasperreports-xx.x.jar** från \lib-mappen i **aspose-cad-jasperreports-xx.x.zip** till **\InstallDir\lib**.
1. Förbered Ant Build Tool och Ivy Dependency Manager, se **\InstallDir\readme.txt**.
1. Modifiera **build.xml** i **\InstallDir\demo\samples**, lägg till aspose-cad-jasperreports-xx.x.jar i klassvägen:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Byt den aktuella katalogen till **\InstallDir\demo\hsqldb** och kör följande kommandorad:
   **Ant runServer**
1. Byt den aktuella katalogen till en av Aspose.CAD för JasperReports-demos, till exempel **\InstallDir\demo\samples\charts.ai** och kör följande kommandon i kommandoraden:
   **ant test** - för att producera rapportfiler.
1. Öppna ett av de resulterande dokumenten för att visa, till exempel **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
