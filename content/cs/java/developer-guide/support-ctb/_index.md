---
title: Podpora souborů CTB
type: docs
weight: 40
url: /cs/java/developer-guide/support-ctb/
---

## **Podpora souborů CTB**

Někdy mohou být barvy, tloušťky linií a další možnosti pro výkresy použity nejen ze samotných výkresů, ale také ze stylů tisku v oddělených souborech CTB.
Nejjednodušší způsob, jak využít tuto informaci, je umístit příslušné soubory CTB vedle souboru s výkresem ve formátu DWG/DXF a informace z nich budou automaticky použity
během exportu.

Je také možné načíst všechny soubory CTB ve formě streamu pomocí vlastnosti 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) objektu 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

Zde je příklad, jak na to:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
