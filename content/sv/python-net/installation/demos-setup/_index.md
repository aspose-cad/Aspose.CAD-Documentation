---
title: Demos Inställning
type: docs
weight: 40
url: /sv/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD för Python inkluderar ett antal demoprojekt för att hjälpa dig komma igång.

Demonstrationerna som tillhandahålls med Aspose.CAD för Python är standard Pythons demonstrationer som har modifierats för att visa användningen av de nya exportörerna.

{{% /alert %}}

För att köra Aspose.CAD för Python-demonstrationer, utför följande steg:

1. Ladda ner Pythons (t.ex. https://sourceforge.net/projects/python-net/files/archive/). Se till att ladda ner hela det arkiverade projektet med källkoden och demonstrationerna, inte bara en enda JAR.
1. Packa upp det arkiverade projektet till en plats på din hårddisk, till exempel C:\.
1. Kopiera alla demomappar från \samples-mappen av **aspose-cad-xx.x.zip** till **\InstallDir\demo\samples**, där "\InstallDir" är den plats där du har packat upp Pythons. Detta steg är nödvändigt eftersom demobyggerna är beroende av Pythons mappstruktur, annars måste du modifiera byggskripten.
1. Kopiera **aspose-cad-pythons-xx.x.jar** från \lib-mappen av **aspose-cad-pythons-xx.x.zip** till **\InstallDir\lib**.
1. Förbered Ant Build Tool och Ivy Dependency Manager, se **\InstallDir\readme.txt**.
1. Modifiera **build.xml** vid **\InstallDir\demo\samples**, lägg till aspose-cad-pythons-xx.x.jar i klassvägen:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Byt den aktuella katalogen till **\InstallDir\demo\hsqldb** och kör följande kommandorad:
   **ant runServer**
1. Byt den aktuella katalogen till en av Aspose.CAD för Python-demonstrationerna, till exempel **\InstallDir\demo\samples\charts.ai** och kör följande kommandon i kommandoraden:
   **ant test** - för att producera rapportfiler.
1. Öppna ett av de resulterande dokumenten för att visa, till exempel **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
