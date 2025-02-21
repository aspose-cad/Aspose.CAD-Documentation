---
title: Exportera DGN AutoCAD
type: docs
weight: 50
url: /sv/net/developer-guide/exporting-dgn-autocad/
---

## **Exportera DGN AutoCAD-format till PDF**

Aspose.CAD för .NET API har introducerat funktionen att ladda en DGN AutoCAD-fil och konvertera den till PDF-format. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klassen tjänar syftet.

Du behöver ladda en befintlig DGN-fil som [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klassen och ställ in olika egenskaper. Skapa en instans av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klassen och skicka in [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) instansen. Anropa nu [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metoden hos [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klassinstansen.

### Exempel på kod

Följande är koddemonstrationen för att konvertera/exportera [DGN](https://docs.fileformat.com/cad/dgn/) till [PDF](https://docs.fileformat.com/pdf/) format.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Exportera DGN AutoCAD-format till rasterbildformat**

Aspose.CAD för .NET API har introducerat funktionen att ladda en DGN AutoCAD-fil och konvertera den till en rasterbild. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klassen tjänar syftet.

Du behöver ladda en befintlig DGN-fil som [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klassen och ställ in olika egenskaper. Skapa en instans av [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) klassen och skicka in [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) instansen. Anropa nu [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metoden hos [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klassinstansen.

### Exempel på kod

Följande är koddemonstrationen för att konvertera/exportera [DGN](https://docs.fileformat.com/cad/dgn/) till [JPEG](https://docs.fileformat.com/image/jpeg/) bild.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **3D-enhetsstöd för DGN v7**

Aspose.CAD för .NET API har introducerat funktionen att ladda en [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-fil och stödja 3D-enheter för DGN v7. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klassen tjänar syftet. Varje [DGN](https://docs.fileformat.com/cad/dgn/) bild stöder 9 fördefinierade vyer. Det numreras från 1 till 9. Om vy inte är definierad vid export kommer alla vyer att exporteras för fler-sidiga utdataformat (som PDF), varje på en separat sida. 3D-enheter stöds i DGN filformat, samt 2D. För detta används [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), TypeOfEntities används inte längre för DGN-format (både 2D och 3D stöds samtidigt).

### Exempel på kod

Följande är exempel på kod för att se stödja DGN-element. 

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
