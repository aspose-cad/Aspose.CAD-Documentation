---
title: Exporting DGN AutoCAD
type: docs
weight: 50
url: /net/exporting-dgn-autocad/
---

## **Exporting DGN AutoCAD Format To PDF**

Aspose.CAD for .NET API has introduced the functionality to load a DGN AutoCAD file and convert it to PDF format. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) class serves the purpose.

You need to load an existing DGN file as [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Create an instance of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set different properties. Create an instance of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and pass the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) instance. Now call the [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method of [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) class instance.

### Sample Code

Following is the code demonstration to convert/export [DGN](https://docs.fileformat.com/cad/dgn/) to [PDF](https://docs.fileformat.com/pdf/) format.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Exporting DGN AutoCAD Format To Raster Image Format**

Aspose.CAD for .NET API has introduced the functionality to load a DGN AutoCAD file and convert it to a raster image. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) class serves the purpose.

You need to load an existing DGN file as [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Create an instance of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set different properties. Create an instance of [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) class and pass the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) instance. Now call the [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method of [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) class instance.

### Sample Code

Following is the code demonstration to convert/export [DGN](https://docs.fileformat.com/cad/dgn/) to [JPEG](https://docs.fileformat.com/image/jpeg/) image.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **3D entities support for DGN v7**

Aspose.CAD for .NET API has introduced the functionality to load a [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD file and support 3D entities for DGN v7. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) class serves the purpose. Each [DGN](https://docs.fileformat.com/cad/dgn/) image supports 9 predefined views. It's enumerated from 1 to 9. If view not defined on export, for multi-paged output formats (like PDF) all views will be exported, each on a separate page. 3D entities supported on DGN file format, as well as 2D. For this, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) is used, TypeOfEntities is not used anymore for DGN format (both 2D and 3D supported simultaneously).

### Sample Code

The following is the sample code to look at supported DGN elements.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
