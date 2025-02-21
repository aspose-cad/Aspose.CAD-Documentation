---
title: Eksportowanie rysunków DWG/DXF i układów do określonego rozmiaru
type: docs
weight: 40
url: /pl/net/developer-guide/export-into-size/
---

## **Eksportuj model i wszystkie układy do rozmiaru PDF A4**

Aspose.CAD API pozwala na eksport wszystkich arkuszy pliku DWG/DXF do określonego fizycznego rozmiaru PDF.

Poniższy przykładowy kod ustawia rozmiar obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) w celu osiągnięcia pożądanego rozmiaru PDF.
Rozmiar arkusza papieru A4 to 210x297 milimetrów lub 8.27x11.69 cali, a te wartości są używane w kodzie.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Eksportuj układy CAD do PDF w różnych rozmiarach**

Czasami konieczne jest wyeksportowanie układu do jego fizycznego rozmiaru. Poniższy przykład demonstruje eksport rysunku do wielostronicowego PDF, w którym każda strona z zawartością układu
ma swój własny fizyczny rozmiar PDF. Ten przykład wykorzystuje właściwość [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
