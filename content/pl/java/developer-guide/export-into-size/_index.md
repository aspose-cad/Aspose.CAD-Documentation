---
title: Eksportowanie rysunków DWG/DXF i układów do określonego rozmiaru
type: docs
weight: 40
url: /pl/java/developer-guide/export-into-size/
---

## **Eksportowanie modelu i wszystkich układów do formatu PDF A4**

API Aspose.CAD pozwala na eksportowanie wszystkich arkuszy pliku DWG/DXF do określonego fizycznego rozmiaru PDF. 
Poniższy przykładowy kod ustawia rozmiar obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) w celu osiągnięcia żądanego rozmiaru PDF. 
Rozmiar arkusza papieru A4 wynosi 210x297 milimetrów lub 8.27x11.69 cali, a te wartości są używane w kodzie.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Eksportowanie układów CAD do PDF w różnych rozmiarach**

Czasami konieczne jest eksportowanie układu do jego fizycznego rozmiaru. Przykład poniżej demonstruje eksport rysunku do wielostronicowego PDF, gdzie każda strona z treścią układu 
ma swój własny fizyczny rozmiar PDF. Ten przykład używa właściwości [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
