---
title: Exportování formátu DGN AutoCAD
type: docs
weight: 50
url: /cs/python-net/developer-guide/exporting-dgn-autocad/
---

## **Exportování formátu DGN AutoCAD do PDF**

Aspose.CAD pro Python API představil funkčnost načtení souboru DGN AutoCAD a jeho konverzi do formátu PDF. Třída **CadImage** slouží k tomuto účelu.

Je třeba načíst existující soubor DGN jako **CadImage**. Vytvořte instanci třídy **CadRasterizationOptions** a nastavte různé vlastnosti. Vytvořte instanci třídy **PdfOptions** a předejte instanci **CadRasterizationOptions**. Nyní zavolejte metodu **save** instance třídy **CadImage**.

### Ukázkový kód

Následující ukazuje kód pro konverzi/export [DGN](https://docs.fileformat.com/cad/dgn/) do formátu [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Exportování formátu DGN AutoCAD do rastrového obrázkového formátu**

Aspose.CAD pro Python API představil funkčnost načtení souboru DGN AutoCAD a jeho konverzi do rastrového obrázku. Třída **CadImage** slouží k tomuto účelu.

Je třeba načíst existující soubor DGN jako **CadImage**. Vytvořte instanci třídy **CadRasterizationOptions** a nastavte různé vlastnosti. Vytvořte instanci třídy **JpegOptions** a předejte instanci **CadRasterizationOptions**. Nyní zavolejte metodu **save** instance třídy **CadImage**.

### Ukázkový kód

Následující ukazuje kód pro konverzi/export [DGN](https://docs.fileformat.com/cad/dgn/) do obrázkového formátu [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Podpora 3D entit pro DGN v7**

Aspose.CAD pro Python API představil funkčnost načtení [DGN](https://docs.fileformat.com/cad/dgn/) souboru AutoCAD a podporu 3D entit pro DGN v7. Třída **CadImage** slouží k tomuto účelu. Každý [DGN](https://docs.fileformat.com/cad/dgn/) obrázek podporuje 9 předdefinovaných pohledů. Jsou vyjmenovány od 1 do 9. Pokud není pohled definován při exportu, pro formáty s více stránkami (jako je PDF) budou všechny pohledy exportovány, každý na samostatnou stránku. 3D entity jsou podporovány ve formátu souboru DGN, stejně jako 2D. K tomu je použita třída **VectorRasterizationOptions**, TypeOfEntities již není pro formát DGN používáno (oba typy - 2D i 3D jsou podporovány současně).

### Ukázkový kód

Následující ukazuje ukázkový kód pro prohlížení podporovaných prvků DGN.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
