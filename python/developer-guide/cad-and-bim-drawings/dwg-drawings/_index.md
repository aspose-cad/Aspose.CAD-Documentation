---
title: DWG Drawings
type: docs
weight: 40
url: /python/dwg-drawings/
---

## **Exporting DWG Drawings to PDF**

Aspose.CAD for Python API can load AutoCAD drawings in [DWG](https://docs.fileformat.com/cad/dwg/) format, and convert it to [PDF](https://docs.fileformat.com/pdf/). This topic explains the usage of Aspose.CAD API to achieve the conversion of DWG to PDF format through simple steps as defined ahead.

{{% alert color="primary" %}}

The API supports the following AutoCAD DWG revisions:

- DWG 2004  version 16.0 release 18
- DWG 2005 version  16.1
- DWG 2010 version 18.0
- DWG 2013 version 19.0

{{% /alert %}}

### **DWG File Format**

A [DWG](https://docs.fileformat.com/cad/dwg/) is a binary file that contains vector image data and metadata. The vector image data provides instructions to the CAD application about how to display the DWG; the metadata may contain a variety of information about the file including location-specific data and also client data. Open Specifications for DWG file format can be found [in this PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convert DWG Files to PDF**

The following simple steps are required to convert [DWG](https://docs.fileformat.com/cad/dwg/) to [PDF](https://docs.fileformat.com/pdf/).

1. Load the DWG file into an instance of [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set the [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

The code sample below shows how to export DWG Drawings to PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


### **Supported AutoCAD Primitives**

The following AutoCAD primitives are supported.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Exporting Specific DWG Layout to PDF**

This approach works as follows:

1. Load a DWG file using the [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the resultant page height and width.
1. Set the [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) property for the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) object.
1. Create an instance of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Export the image to PDF using the [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a specific layout of DWG to PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **Exporting DWG to PDF/A and PDF/E**

This approach works as follows:

1. Load a DWG file using the [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class.
1. Create an instance of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Set PDF compliance property and save it.
1. Export the image to PDF using the [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a DWG file to PDF/A and PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Convert DWG Drawings to DXF**

Aspose.CAD provides the feature to load AutoCAD DWG file and export it to DXF format. DWG to DXF conversion approach works as follows:

1. Load DWG drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Export the DWG drawing to DXF using the [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a DWG file to a DXF format.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Convert DWG Drawings to SVG**

Aspose.CAD for Python API can load AutoCAD drawings in DWG format, and convert it to SVG. This topic explains the usage of Aspose.CAD API to achieve the conversion of DWG to SVG format through simple steps as defined below.

1. Load the DWG file into an instance of [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Create an object of the [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) class and set the required properties.
1. Export the DWG drawing to SVG using the [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a DWG file to SVG format.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}