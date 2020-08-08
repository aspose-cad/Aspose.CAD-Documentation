---
title: DWF Drawings
type: docs
weight: 20
url: /net/dwf-drawings/
---

## **Exporting DWF Drawings to PDF**
Aspose.CAD provides the feature to load AutoCAD [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [**PDF**](https://wiki.fileformat.com/view/pdf/) format. [**DWF**](https://wiki.fileformat.com/cad/dwf/) to [**PDF**](https://wiki.fileformat.com/view/pdf/) conversion approach works as follows:

1. Load [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://apireference.aspose.com/net/cad/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/cadrasterizationoptions)class and set the [**PageHeight**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**PdfOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/pdfoptions)class and set the [**VectorRasterizationOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/vectorrasterizationoptions)property.
1. Call [**Image.Save**](https://apireference.aspose.com/net/cad/aspose.cad/image/methods/save/index) while passing an object of [**PdfOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/pdfoptions)as the second parameter.

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}


## **Extract Layers from DWF Drawing**
Aspose.CAD provides the feature to load AutoCAD [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [**JPEG** ](https://wiki.fileformat.com/image/jpeg/)format. 

1. Load [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://apireference.aspose.com/net/cad/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**JPEGOptions**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/jpegoptions) class.
1. Create an object of the [**CadRasterizationOptions**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/cadrasterizationoptions) class.
1. Extract layers name using the [**JPEG**](https://wiki.fileformat.com/image/jpeg/) object.
1. Call [**Image.Save**](https://apireference.aspose.com/net/cad/aspose.cad/image/methods/save/index) while passing an object of [**JPEGOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/jpegoptions)as the second parameter.

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}
## **Support of Layers in DWF**
Aspose.CAD provides the feature to load AutoCAD [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [**JPEG**](https://wiki.fileformat.com/image/jpeg/) format. 

1. Load [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://apireference.aspose.com/net/cad/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/cadrasterizationoptions) class.
1. Add desired layers.
1. Call [**Image.Save**](https://apireference.aspose.com/net/cad/aspose.cad/image/methods/save/index) while passing an object of [**JPEGOptions**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/jpegoptions) as the second parameter.

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}


## **Exporting DWF Drawings to BMP**
Aspose.CAD provides the feature to load AutoCAD [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [**BMP**](https://wiki.fileformat.com/image/bmp/) format. [**DWF**](https://wiki.fileformat.com/cad/dwf/) to [**BMP**](https://wiki.fileformat.com/image/bmp/) conversion approach works as follows:

1. Load [**DWF**](https://wiki.fileformat.com/cad/dwf/) drawing file using the [**Image.Load**](https://apireference.aspose.com/net/cad/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/cadrasterizationoptions)class and set the [**PageHeight**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**BmpOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/bmpoptions)class and set the [**VectorRasterizationOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/vectorrasterizationoptions)property.
1. Call [**Image.Save**](https://apireference.aspose.com/net/cad/aspose.cad/image/methods/save/index) while passing an object of [**BmpOptions** ](https://apireference.aspose.com/net/cad/aspose.cad.imageoptions/bmpoptions)as the second parameter.

The code sample below shows how to convert a [**DWF**](https://wiki.fileformat.com/cad/dwf/) file to [**BMP**](https://wiki.fileformat.com/image/bmp/) using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
