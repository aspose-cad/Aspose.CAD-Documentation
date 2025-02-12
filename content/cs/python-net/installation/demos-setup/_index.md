---
title: Nastavení ukázek
type: dokumentace
weight: 40
url: /cs/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD pro Python obsahuje řadu ukázkových projektů, které vám pomohou začít.

Ukázky poskytované s Aspose.CAD pro Python jsou standardní ukázky v jazyce Python upravené tak, aby demonstrovaly použití nových exportérů.

{{% /alert %}}

Pro spuštění ukázek Aspose.CAD pro Python proveďte následující kroky:

1. Stáhněte si Python (např. z https://sourceforge.net/projects/python-net/files/archive/). Ujistěte se, že stahujete celý archivovaný projekt se zdrojovým kódem a ukázkami, nikoli pouze jeden soubor JAR.
1. Rozbalte archivovaný projekt na libovolné místo na vašem pevném disku, například C:\.
1. Zkopírujte všechny složky s ukázkami ze složky \samples z archivu **aspose-cad-xx.x.zip** do složky **\InstallDir\demo\samples**, kde "\InstallDir" je umístění, kam jste rozbalili soubory Python. Tento krok je nezbytný, protože build skripty ukázek používají strukturu složek Pythonu, jinak byste museli upravit build skripty.
1. Zkopírujte soubor **aspose-cad-pythons-xx.x.jar** ze složky \lib z archivu **aspose-cad-pythons-xx.x.zip** do složky **\InstallDir\lib**.
1. Připravte nástroje pro sestavení Ant a správce závislostí Ivy, viz **\InstallDir\readme.txt**.
1. Upravte soubor **build.xml** v **\InstallDir\demo\samples**, přidejte aspose-cad-pythons-xx.x.jar do classpathu:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Změňte aktuální adresář na **\InstallDir\demo\hsqldb** a spusťte následující příkazový řádek:
   **ant runServer**
1. Změňte aktuální adresář na jednu z ukázek Aspose.CAD pro Python, například **\InstallDir\demo\samples\charts.ai** a spusťte následující příkazy v příkazovém řádku:
   **ant test** - ke generování souborů s reporty.
1. Otevřete jeden z výsledných dokumentů k prohlížení, například **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
