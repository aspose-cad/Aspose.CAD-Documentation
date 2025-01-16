---
title: Exportace písem SHX
type: docs
weight: 40
url: /cs/net/export-shx-fonts/
---

## **Exportování písem SHX pro výkresy DXF/DWG**

Některé výkresy mohou obsahovat písma ve speciálním formátu SHX, který uchovává symboly písma ve formě tvarů. Tento formát vyžaduje dodatečný proces načítání pro každé použité písmo ve výkresu. Aspose.CAD může exportovat výkresy s textem napsaným ve formátu SHX a má různé možnosti, jak toho dosáhnout. Nejjednodušší způsob, jak to udělat, je použít 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) vlastnost objektu 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


Je možné vyhnout se nastavování všech cest k různým písmům SHX s následujícím příkladem:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
Každé písmo SHX je doprovázeno příslušným kódováním, které je s ním spojené. Tyto asociace jsou známy a částečně vestavěny do Aspose.CAD pro známá písma SHX. V případě použití vlastního písma SHX je možné použít vlastnost ShxCodePages a nastavit cestu k souboru SHX a odpovídající kódovou stránku. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
