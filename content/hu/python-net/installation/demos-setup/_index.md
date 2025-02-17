---
title: Demos beállítása
type: docs
weight: 40
url: /hu/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Az Aspose.CAD for Python számos bemutató projektet tartalmaz, hogy segítsen elindulni.

Az Aspose.CAD for Python által biztosított bemutatók szabványos Python bemutatók, amelyeket a new exporterek használatának bemutatására módosítottak.

{{% /alert %}}

Az Aspose.CAD for Python bemutatók futtatásához hajtsa végre az alábbi lépéseket:

1. Töltse le a Pythons-t (például: https://sourceforge.net/projects/python-net/files/archive/). Győződjön meg róla, hogy a teljes archivált projektet letölti a forráskóddal és a bemutatókkal, nem csak egyetlen JAR fájlt.
1. Csomagolja ki az archivált projektet a számítógépe egyik helyére, például: C:\.
1. Másolja az összes bemutató mappát az **\samples** mappából a **\InstallDir\demo\samples** mappába, ahol a "\InstallDir" az a hely, ahová a Pythons-t kicsomagolta. Ez a lépés kötelező, mert a bemutató építési skriptek a Pythons mappastruktúrájára támaszkodnak, különben módosítania kell az építési skripteket.
1. Másolja az **aspose-cad-pythons-xx.x.jar** fájlt az **aspose-cad-pythons-xx.x.zip** mappa **\lib** mappájából a **\InstallDir\lib** mappába.
1. Készítse elő az Ant Build Tool-t és az Ivy Dependency Manager-t, lásd: **\InstallDir\readme.txt**.
1. Módosítsa a **build.xml** fájlt a **\InstallDir\demo\samples** mappában, adja hozzá az aspose-cad-pythons-xx.x.jar fájlt a classpath-hez:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Változtassa meg a jelenlegi könyvtárat a **\InstallDir\demo\hsqldb** könyvtárra, és futtassa a következő parancssort:
   **ant runServer**
1. Változtassa meg a jelenlegi könyvtárat az Aspose.CAD for Python egyik bemutatójára, például a **\InstallDir\demo\samples\charts.ai** könyvtárra, és futtassa a következő parancsokat a parancssorban:
   **ant test** - a jelentésfájlok előállításához.
1. Nyisson meg egyet a létrejött dokumentumok közül, például a **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg** fájlt.
