---
title: Exportování SHX písem
type: docs
weight: 40
url: /cs/java/export-shx-fonts/
---

## **Exportování SHX písem pro výkresy DXF/DWG**

Některé výkresy mohou obsahovat písma ve speciálním formátu SHX, který ukládá symboly písma ve formě tvarů. Tento formát vyžaduje další postup načítání pro každé použité písmo ve výkresu. Apose.CAD může exportovat výkresy s textem napsaným v SHX a má různé možnosti, jak toho dosáhnout. Nejjednodušší způsob, jak toho dosáhnout, je použití vlastnosti [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) objektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Každé SHX písmo má přiřazený odpovídající kódovou stránku. Tyto asociace jsou známy a částečně integrovány do Aspose.CAD pro známé SHX písma. V případě použití nějakého vlastního SHX písma je možné použít vlastnost **setShxCodePages** a nastavit cestu k souboru SHX a odpovídající kódovou stránku.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
