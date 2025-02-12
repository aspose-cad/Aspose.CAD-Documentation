---
title: Podpora souborů CTB
type: docs
weight: 40
url: /cs/net/support-ctb/
---

## **Podpora souborů CTB**

Někdy mohou být barvy, tloušťky linií a některé další možnosti pro kreslení použity nejen z výkresů samotných, ale také z vlastních stylů tisku v oddělených souborech CTB. 
Nejjednodušší způsob, jak využít tuto informaci, je umístit odpovídající soubory CTB vedle souboru s výkresem ve formátu DWG/DXF a informace z nich budou automaticky aplikovány během exportu.

Je také možné načíst všechny soubory CTB ve formě streamu pomocí 
[Vlastnosti **CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) objektu 
[Vlastnosti **CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).

Zde je příklad, jak na to:

{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
