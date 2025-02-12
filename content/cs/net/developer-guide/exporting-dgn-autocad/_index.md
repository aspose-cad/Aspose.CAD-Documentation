---
title: Exportování DGN AutoCADu
type: docs
weight: 50
url: /cs/net/exporting-dgn-autocad/
---

## **Export formátu DGN AutoCAD do PDF**

API Aspose.CAD pro .NET zavedlo funkcionalitu načtení souboru DGN AutoCAD a jeho převedení do formátu PDF. Třída [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) slouží k tomuto účelu.

Musíte načíst existující soubor DGN jako [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte různé vlastnosti. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a předejte instanci [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Nyní zavolejte metodu [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) třídy [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Ukázkový kód

Následující je demonstrace kódu pro převod/export [DGN](https://docs.fileformat.com/cad/dgn/) do formátu [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Export formátu DGN AutoCADu do rastru**

API Aspose.CAD pro .NET zavedlo funkcionalitu načtení souboru DGN AutoCAD a jeho převedení na rástrovaný obrázek. Třída [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) slouží k tomuto účelu.

Musíte načíst existující soubor DGN jako [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte různé vlastnosti. Vytvořte instanci třídy [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) a předejte instanci [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Nyní zavolejte metodu [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) třídy [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Ukázkový kód

Následující je demonstrace kódu pro převod/export [DGN](https://docs.fileformat.com/cad/dgn/) do obrázku [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Podpora 3D entit pro DGN v7**

API Aspose.CAD pro .NET zavedlo funkcionalitu načtení souboru [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD a podporu 3D entit pro DGN v7. Třída [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) slouží k tomuto účelu. Každý obrázek [DGN](https://docs.fileformat.com/cad/dgn/) podporuje 9 předdefinovaných pohledů. Jsou vyjmenovány od 1 do 9. Pokud není pohled definován při exportu, pro vícestránkové formáty výstupu (jako je PDF) budou všechny pohledy exportovány, každý na samostatné stránce. 3D entity jsou podporovány ve formátu souboru DGN stejně jako 2D. K tomu je použita třída [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), TypeOfEntities již není používán pro formát DGN (2D a 3D jsou podporovány současně).

### Ukázkový kód

Následující je ukázkový kód k prohlédnutí podporovaných prvků DGN.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
