---
title: Exportera SHX-teckensnitt
type: docs
weight: 40
url: /sv/python-net/developer-guide/export-shx-fonts/
---

## **Exportera SHX-teckensnitt för DXF/DWG-ritningar**

Vissa ritningar kan innehålla teckensnitt i det speciella SHX-formatet, som lagrar symboler av teckensnittet i form av former. Detta format kräver en ytterligare
inläsningsprocedur för varje teckensnitt som används i ritningen. Apose.CAD kan exportera ritningar med text skriven i SHX och har olika alternativ för att göra detta. Det enklaste sättet att göra det är att bara använda 
**ShxFonts** egenskapen av 
**CadRasterizationOptions** objektet.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
