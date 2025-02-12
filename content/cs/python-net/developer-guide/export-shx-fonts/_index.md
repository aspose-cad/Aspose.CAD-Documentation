---
title: Exportování SHX písma
type: docs
weight: 40
url: /cs/python-net/developer-guide/export-shx-fonts/
---

## **Exportování SHX písma pro výkresy DXF/DWG**

Některé výkresy mohou obsahovat písma ve speciálním formátu SHX, který uchovává symboly písma ve formě tvarů. Tento formát vyžaduje dodatečný
postup načítání pro každé použité písmo ve výkresu. Apose.CAD může exportovat výkresy s textem napsaným v SHX a má různé možnosti, jak tohle provést. Nejjednodušší způsob, jak to udělat, je použít
vlastnost **ShxFonts** objektu
**CadRasterizationOptions**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
