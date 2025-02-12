---
title: Nastavení ukázek
type: docs
weight: 40
url: /cs/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD pro JasperReports zahrnuje řadu ukázkových projektů, které vám pomohou začít.

Ukázky poskytované s Aspose.CAD pro JasperReports jsou standardní ukázky JasperReports upravené k demonstrování použití nových exportérů.

{{% /alert %}}

Pro spuštění ukázek Aspose.CAD pro JasperReports postupujte podle těchto kroků:

1. Stáhněte si JasperReports (např. z https://sourceforge.net/projects/jasperreports/files/archive/). Ujistěte se, že stahujete celý archivovaný projekt se zdrojovým kódem a ukázkami, nejen jediný JAR soubor.
1. Rozbalte archivovaný projekt do libovolného umístění na vašem pevném disku, například do C:\.
1. Zkopírujte všechny složky s ukázkami z adresáře \samples z **aspose-cad-xx.x.zip** do **\InstallDir\demo\samples**, kde "\InstallDir" je umístění, kam jste rozbalili JasperReports. Tento krok je nutný, protože skripty pro sestavení ukázek spoléhají na složkovou strukturu JasperReports, jinak budete muset upravit skripty pro sestavení.
1. Zkopírujte **aspose-cad-jasperreports-xx.x.jar** z adresáře \lib z **aspose-cad-jasperreports-xx.x.zip** do **\InstallDir\lib**.
1. Připravte nástroj pro sestavení Ant a správce závislostí Ivy, viz **\InstallDir\readme.txt**.
1. Upravte soubor **build.xml** v **\InstallDir\demo\samples**, přidejte aspose-cad-jasperreports-xx.x.jar do classpathu:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Změňte aktuální adresář na **\InstallDir\demo\hsqldb** a spusťte následující příkazový řádek:
   **Ant runServer**
1. Změňte aktuální adresář na jednu z ukázek Aspose.CAD pro JasperReports, například na **\InstallDir\demo\samples\charts.ai** a spusťte následující příkazy v příkazovém řádku:
   **ant test** - pro vytvoření souborů s reporty.
1. Otevřete jeden z výsledných dokumentů k prohlédnutí, například **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
