---
title: DWG Drawings
type: docs
weight: 40
url: /java/dwg-drawings/
---

## **Exporting DWG Drawings to PDF**
Aspose.CAD for Java API can load AutoCAD drawings in DWG format, and convert it to PDF. This topic explains the usage of Aspose.CAD API to achieve the conversion of DWG to PDF format through simple steps as defined ahead.

{{% alert color="primary" %}} 

The API supports the following AutoCAD DWG revisions:

- DWG 2004  version 16.0 release 18
- DWG 2005 version  16.1
- DWG 2010 version 18.0
- DWG 2013 version 19.0

{{% /alert %}} 
### **DWG File Format**
A DWG is a binary file that contains vector image data and metadata. The vector image data provides instructions to the CAD application about how to display the DWG; the metadata may contain a variety of information about the file including location-specific data and also client data. Open Specifications for DWG file format can be found [in this PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)
### **Convert DWG Files to PDF**
The following simple steps are required to convert DWG to PDF.

1. Load the DWG file into an instance of [**Image**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image).
1. Create an object of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set the [**PageHeight**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) properties.
1. Create an object of the [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) class and set the [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) property.
1. Call the [**Image.save**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method and pass the object of [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) as the second parameter.

The code sample below shows how to export DWG Drawings to PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}


### **Create Single PDF with Different Layout Sizes**
` `Aspose.CAD for Java allows you to convert the DWG file to a single PDF with different layout sizes. This approach works as follows:

1. Load a DWG file using the [**Aspose.CAD.Image.load**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set the resultant page height and width.
1. Add required [**LayoutPageSizes**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-)** **for the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object..
1. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) class and set its [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) property.
1. Export the image to PDF using the [**Image.save**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to create a single PDF with different layouts.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}
### **Exporting DWG to PDF/A and PDF/E**
The following simple steps are required to convert DWG to PDF.

1. Load the DWG file into an instance of [**Image**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image).
1. Create an object of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set the [**PageHeight**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) properties.
1. Create an object of the [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) class and set the [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)** **property.
1. Call the [**Image.save**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method and pass the object of [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) as the second parameter.

The code sample below shows how to export DWG Drawings to PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}
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

1. Load a DWG file using the [**Image.load**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set the resultant page height and width.
1. Set the [**Layouts**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) property for the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object.
1. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) class and set its [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)** **property.
1. Export the image to PDF using the [**Image.save()**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to convert a specific layout of DWG to PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}


## **Exporting DWG to Raster or PDF using Fixed Size**
Aspose.CAD for Java API can load AutoCAD drawings in DWG format, and convert it to PDF or Raster using fixed size.

The code sample below shows how to implement this feature.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}
## **Support for rounded hidden lines when exporting DWG/DXF to BMP and PDF**
This approach works as follows:

1. Load a DWG file using the [**Aspose.CAD.Image.load**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class.
1. Create an instance of the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set the resultant page height and width.
1. Create an instance of [**PdfOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) class and set its [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)** **property.
1. Export the image to PDF using the [**Image.save()**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to implement this feature.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}
## **Support for setting print area for DWG image in exported PDF**
Aspose.CAD for Java API can load AutoCAD drawings in DWG format, and convert it to PDF. This topic explains the usage of Aspose.CAD API to achieve the support for setting a print area for DWG image in exported PDF.

The code sample below shows how to implement this feature.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}
## **Support for reading XREF metadata for DWG file**
1. Load a DWG file using the [**Aspose.CAD.Image.load**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Traverse through every image entity.
1. If the entity is [**CadUnderlay**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) than XREF entity with metadata.

The code sample below shows how to achieve this feature.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}
## **DWG document by specifying coordinates**
Aspose.CAD for Java API now provides a feature to render DWG documents by providing coordinates of the width and height of the document.

The code sample below shows how to render a DWG document.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

The property [**CadRasterizationOptions.Layouts**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) is of type string array so you may specify more than one layouts at a time for possible conversion to PDF format. While specifying multiple layouts for the [**CadRasterizationOptions.Layouts**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) property, the resultant PDF would have multiple pages, where each page represents an individual AutoCAD layout.
### **List All Layouts**
You may list all the layouts present in an AutoCAD drawing using the following code snippet.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}


## **Get Block Attribute Value Of External Reference**
Aspose.CAD for Java API allows you to get an external reference of a block attribute. Aspose.CAD API exposes the [**getXRefPathName()**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) property to get the external reference of a block attribute in a [**CadBlockDictionary**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) collection.

The following code demonstrates how to get an external reference of a block attribute.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}


## **Search Text In DWG AutoCAD File**
Aspose.CAD for Java API allows you to search text in a DWG AutoCAD file. Aspose.CAD API exposes [**CadText**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) class that represents text entities in the DWG AutoCAD file. Class [**CadMText**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) is also included in the Aspose.CAD API because some other entities may also contain text.

The following code demonstrates how to search text in the DWG AutoCAD file.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}


### **Search For Text In Specific Layout**
{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}


### **Accessing underlay Flags for DWG Format**
Aspose.CAD for Java has implemented the underlay flags for DWG format and allows developers to access them. Following is the simple code demonstration.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}
## **Support for DWG Entities**
Aspose.CAD for Java API can load AutoCAD drawings in DWG format and support different entities to work with.
### **Support for MLeader Entity**
A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes an example of working with MLeader entity inside the DWG file.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}


### **Support for Exporting DWG Entity to Image**
A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes an example of exporting a particular DWG entity to the image.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}
## **Support for Import Image to DWG File**
Aspose.CAD for Java API can load AutoCAD drawings in DWG format and support different entities to work with. A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes how can we import images inside the DWG file.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}
## **Support for Adding text in DWG**
Aspose.CAD for Java API can load AutoCAD drawings in DWG format and support different entities to work with. A DWG is a binary file that contains vector image data and metadata. There are different entities in a DWG file. The following section describes how can we add text inside the DWG file.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}


## **Support for Mesh in DWG**
Aspose.CAD for Java API can now access the entities supporting mesh which include [**CadPolyFaceMesh**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) and [**CadPolygonMesh**](https://apireference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) types. The following example describes how can we access the mesh types.
## **Convert DWG Drawings to DXF**
Aspose.CAD provides the feature to load AutoCAD DWG file and export it to DXF format. DWG to DXF conversion approach works as follows:

1. Load DWG drawing file using the [**Image.load**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Export the DWG drawing to DXF using the [**Image.save()**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to convert a DWG file to a DXF format.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}
## **Convert DWG Drawings to SVG**
Aspose.CAD API can load AutoCAD drawings in DWG format, and convert it to SVG. This topic explains the usage of Aspose.CAD API to achieve the conversion of DWG to SVG format through simple steps as defined below.

1. Load the DWG file into an instance of [**Image**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image).
1. Create an object of the [**SvgOptions**](https://apireference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) class and set the required properties.
1. Export the DWG drawing to SVG using the [**Image.save()**](https://apireference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to convert a DWG file to SVG format.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
