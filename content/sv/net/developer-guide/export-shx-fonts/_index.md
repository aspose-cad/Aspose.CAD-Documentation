---
title: Exportera SHX-teckensnitt
type: docs
weight: 40
url: /sv/net/developer-guide/export-shx-fonts/
---

## **Exportera SHX-teckensnitt för DXF/DWG-ritningar**

Vissa ritningar kan innehålla teckensnitt i det speciella SHX-formatet, som lagrar symboler för teckensnittet i form av former. Detta format kräver en extra
laddningsprocedur för varje teckensnitt som används i ritningen. Apose.CAD kan exportera ritningar med text skriven i SHX och har olika alternativ för att göra detta. Det enklaste sättet att göra det är att bara använda 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) egenskapen för 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objektet.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts exempel.cs">}}


Det är möjligt att undvika att ställa in alla sökvägar till flera SHX-teckensnitt med följande exempel:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts med mapp exempel.cs">}}
	
Varje SHX-teckensnitt kommer med den korrekta kodsidan kopplad till det. Dessa associationer är kända och delvis inbäddade i Aspose.CAD för kända SHX-teckensnitt.
I fallet där ett anpassat SHX-teckensnitt används är det möjligt att använda ShxCodePages-egenskapen och ställa in sökvägen till SHX-filen och motsvarande kodsida. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages exempel.cs">}}
