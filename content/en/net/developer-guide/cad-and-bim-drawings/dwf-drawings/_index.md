---
title: DWF Drawings
type: docs
weight: 20
url: /net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exporting DWF Drawings to PDF**

Aspose.CAD provides the feature to load AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [PDF](https://docs.fileformat.com/pdf/) format. [DWF](https://docs.fileformat.com/cad/dwf/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [DWF](https://docs.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set the [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) property.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

### Sample Code

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Extract Layers from DWF Drawing**

Aspose.CAD provides the feature to load AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [JPEG](https://docs.fileformat.com/image/jpeg/) format.

1. Load [DWF](https://docs.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) class.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class.
1. Extract layers name using the [JPEG](https://docs.fileformat.com/image/jpeg/) object.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) as the second parameter.

### Sample Code

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Support of Layers in DWF**

Aspose.CAD provides the feature to load AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [JPEG](https://docs.fileformat.com/image/jpeg/) format.

1. Load [DWF](https://docs.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class.
1. Add desired layers.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) as the second parameter.

### Sample Code

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Exporting DWF Drawings to BMP**

Aspose.CAD provides the feature to load AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [BMP](https://docs.fileformat.com/image/bmp/) format. [DWF](https://docs.fileformat.com/cad/dwf/) to [BMP](https://docs.fileformat.com/image/bmp/) conversion approach works as follows:

1. Load [DWF](https://docs.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) class and set the [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) property.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) as the second parameter.

### Sample Code

The code sample below shows how to convert a [DWF](https://docs.fileformat.com/cad/dwf/) file to [BMP](https://docs.fileformat.com/image/bmp/) using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
