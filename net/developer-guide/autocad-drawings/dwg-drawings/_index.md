---
title: DWG Drawings
type: docs
weight: 40
url: /net/dwg-drawings/
---

## **Exporting DWG Drawings to PDF**

Aspose.CAD for .NET API can load AutoCAD drawings in [DWG](https://docs.fileformat.com/cad/dwg/) format, and convert it to [PDF](https://docs.fileformat.com/pdf/). This topic explains the usage of Aspose.CAD API to achieve the conversion of DWG to PDF format through simple steps as defined ahead.

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

1. Load the DWG file into an instance of [**Image**](https://apireference.aspose.com/cad/net/aspose.cad/image).
1. Create an object of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the [**PageHeight**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**PdfOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set the [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Call [**Image.Save**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save) while passing an object of [**PdfOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

The code sample below shows how to export DWG Drawings to PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Create Single PDF with Different Layout Sizes**

Aspose.CAD for .NET allows you to convert DWG file to a single PDF with different layout sizes. This approach works as follows:

1. Load a DWG file using the [**Aspose.CAD.Image.Load**](https://apireference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the resultant page height and width.
1. Add required [**LayoutPageSizes**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) for the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) object.
1. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set its [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Export the image to PDF using the [**Image.Save()**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to create a single [PDF](https://docs.fileformat.com/pdf/) with different layouts.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

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

1. Load a DWG file using the [**Aspose.CAD.Image.Load**](https://apireference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the resultant page height and width.
1. Set the [**Layouts**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) property for the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) object.
1. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set its [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Export the image to PDF using the [**Image.Save()**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a specific layout of DWG to PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Render DWG document by specifying coordinates**

Aspose.CAD for .NET API now provides a feature to render DWG documents by providing coordinates of the width and height of the document.

The code sample below shows how to render a DWG document.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Exporting DWG to Raster or PDF using Fixed Size**

Aspose.CAD for .NET API can load AutoCAD drawings in DWG format, and convert it to PDF or Raster using fixed size.

The code sample below shows how to implement this feature.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Exporting DWG to PDF/A and PDF/E**

This approach works as follows:

1. Load a DWG file using the [**Aspose.CAD.Image.Load**](https://apireference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class.
1. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set its [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Set PDF compliance property and save it.
1. Export the image to PDF using the [**Image.Save()**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a DWG file to PDF/A and PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Support for rounded hidden lines when exporting DWG/DXF to BMP and PDF**

This approach works as follows:

1. Load a DWG file using the [**Aspose.CAD.Image.Load**](https://apireference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the resultant page height and width.
1. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set its [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Export the image to PDF using the [**Image.Save()**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to implement this feature.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Support for setting print area for DWG image in exported PDF**

Aspose.CAD for .NET API can load AutoCAD drawings in DWG format, and convert it to PDF. This topic explains the usage of Aspose.CAD API to achieve the support for setting a print area for the DWG image in exported PDF.

The code sample below shows how to implement this feature.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Support for reading XREF metadata for DWG file**

1. Load a DWG file using the [**Aspose.CAD.Image.Load**](https://apireference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Traverse through every image entity.
1. If an entity is CadUnderlay than XREF entity with metadata.

The code sample below shows how to achieve this feature.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

The property [**CadRasterizationOptions.Layouts**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) is of type string array so you may specify more than one layouts at a time for possible conversion to PDF format. While specifying multiple layouts for the [**CadRasterizationOptions.Layouts**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) property, the resultant PDF would have multiple pages, where each page represents an individual AutoCAD layout.

### **List All Layouts**

You may list all the layouts present in an AutoCAD drawing using the following code snippet.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Accessing underlay Flags for DWG Format**

Aspose.CAD for .NET has implemented the underlay flags for DWG format and allows developers to access them. Following is the simple code demonstration.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Support for DWG Entities**

Aspose.CAD for .NET API can load AutoCAD drawings in DWG format and support different entities to work with.

### **Support for MLeader Entity**

A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes an example of working with MLeader entity inside the DWG file.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Support for Exporting DWG Entity to Image**

A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes an example of exporting a particular DWG entity to the image.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Support for Adding text in DWG**

Aspose.CAD for .NET API can load AutoCAD drawings in DWG format and support different entities to work with. A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes how can we add text inside the DWG file.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Support for Import Image to DWG File**

Aspose.CAD for .NET API can load AutoCAD drawings in DWG format and support different entities to work with. A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes how can we import images inside the DWG file.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Support for Mesh in DWG**

Aspose.CAD for .NET API can now access the entities supporting mesh which include [**CadPolyFaceMesh**](https://apireference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) and [**CadPolygonMesh**](https://apireference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) types. The following example describes how can we access the mesh types.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Convert DWG Drawings to DXF**

Aspose.CAD provides the feature to load AutoCAD DWG file and export it to DXF format. DWG to DXF conversion approach works as follows:

1. Load DWG drawing file using the [**Image.Load**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Export the DWG drawing to DXF using the [**Image.Save()**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a DWG file to a DXF format.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Convert DWG Drawings to SVG**

Aspose.CAD for .NET API can load AutoCAD drawings in DWG format, and convert it to SVG. This topic explains the usage of Aspose.CAD API to achieve the conversion of DWG to SVG format through simple steps as defined below.

1. Load the DWG file into an instance of [**Image**](https://apireference.aspose.com/cad/net/aspose.cad/image).
1. Create an object of the [**SvgOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) class and set the required properties.
1. Export the DWG drawing to SVG using the [**Image.Save()**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a DWG file to SVG format.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Load Large DWG File**

Aspose.CAD for .NET provides the facility to open very large DWG files using [**Image**](https://apireference.aspose.com/cad/net/aspose.cad/image) class. Now you can easily open large files with the help of the sample code given below.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
