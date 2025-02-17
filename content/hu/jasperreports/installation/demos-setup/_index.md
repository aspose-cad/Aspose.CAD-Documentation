---
title: Demók Beállítása
type: docs
weight: 40
url: /hu/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Az Aspose.CAD for JasperReports számos bemutatóprojektet tartalmaz, amelyek segítségével elkezdheti a munkát.

Az Aspose.CAD for JasperReports-hoz biztosított demók a standard JasperReports demók, amelyeket módosítottak az új exportálók használatának bemutatására.

{{% /alert %}}

Az Aspose.CAD for JasperReports demók futtatásához végezze el a következő lépéseket:

1. Töltse le a JasperReports-ot (például https://sourceforge.net/projects/jasperreports/files/archive/). Győződjön meg róla, hogy az egész archívált projektet letölti forráskód és demók mellett, ne csak egyetlen JAR-t.
1. Csomagolja ki az archívált projektet a merevlemeze egy tetszőleges helyére, például C:\.
1. Másolja az összes bemutató mappát a \samples mappából a **aspose-cad-xx.x.zip**-ből a **\InstallDir\demo\samples**-ba, ahol a "\InstallDir" az a hely, ahová a JasperReports-ot kicsomagolta. Ez a lépés szükséges, mert a demó építési szkriptek a JasperReports mappastruktúrájára támaszkodnak, különben módosítania kell az építési szkripteket.
1. Másolja a **aspose-cad-jasperreports-xx.x.jar** fájlt a **aspose-cad-jasperreports-xx.x.zip** \lib mappájából a **\InstallDir\lib**-ba.
1. Készítse elő az Ant Build Tool-t és az Ivy Dependency Manager-t, lásd **\InstallDir\readme.txt**.
1. Módosítsa a **build.xml**-t a **\InstallDir\demo\samples**-ban, adja hozzá az aspose-cad-jasperreports-xx.x.jar-t az osztályúton:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Változtassa meg a jelenlegi könyvtárat a **\InstallDir\demo\hsqldb**-ra, és futtassa az alábbi parancsot:
   **Ant runServer**
1. Változtassa meg a jelenlegi könyvtárat az Aspose.CAD for JasperReports demók egyikére, például a **\InstallDir\demo\samples\charts.ai**-ra, és futtassa az alábbi parancsokat a parancssorban:
   **ant test** - a jelentésfájlok előállításához.
1. Nyissa meg az egyik kapott dokumentumot megtekintésre, például **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
