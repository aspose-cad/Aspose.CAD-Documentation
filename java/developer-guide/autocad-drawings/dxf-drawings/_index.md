---
title: DXF Drawings
type: docs
weight: 60
url: /java/dxf-drawings/
---

## **Exporting DXF Drawings to PDF**

Aspose.CAD provides the feature to load AutoCAD DXF drawing entities and render them as an entire drawing to PDF format. DXF to PDF conversion approach works as follows:

1. Load DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set the [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) properties.
1. Create an object of the [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) class and set the [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) property.
1. Call Image.Save while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) as the second parameter.

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Supported Formats**

At the moment we fully support AutoCAD DXF 2010 file formats. The previous DXF versions are not guaranteed to be 100% valid. We are planning to include more formats and features in future Aspose.CAD versions.

### **Supported Entities**

At the moment we support all widespread 2D entities and their basic default parameters as follow:

1. Aligned Dimension
1. Angular Dimension
1. Arc
1. Attribute
1. Block Reference
1. Circle
1. Diameter Dimension
1. Ellipse
1. Hatch
1. Line
1. Multiline Text
1. Ordinate Dimension
1. Point
1. Polyline
1. Radial Dimension
1. Ray
1. Rotated Dimension
1. Table
1. Text
1. Xline

{{% alert color="primary" %}}

If during parsing we encounter some entity or property we do not support the entity or property will be silently ignored.

{{% /alert %}}

### **Memory Management**

The property [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) can be used to control memory re-allocation. Re-allocation is most likely to occur for pre-allocated caches. It can happen when the system figures out that the allocated space will not be sufficient.

- If [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) is set to the default value, **False**, the space is re-allocated to the same medium.
- When set to **True**, re-allocation cannot exceed the maximum specified space. In this case, the existing allocated in-memory cache (which requires re-allocation) is freed and extended space is allocated on disk.

## **Exporting Specific Layer of DXF Drawings to PDF**

This approach works as follows:

1. Open a DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an instance of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) and specify [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) properties.
1. Add layers to the object of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Create an instance of [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) property.
1. Export the drawing to PDF using the [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to convert a specific layer of DXF to PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exporting Specific Layer of DXF Drawings to Image**

This approach works as follows:

1. Open a DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an instance of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) and specify [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) properties.
1. Add layers to the object of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. Create an instance of [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) & set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) property.
1. Export the drawing to PDF using the [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to convert a specific layer of DXF to Image.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Render PDF files as a part of DXF drawings**

This approach works as follow:

1. Load DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and load PDF files.
1. set the [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) properties.
1. Call [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) and save the file.

The code sample below shows how to render PDF files as a part of DXF drawings.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Export DXF to WMF**

This approach works as follow:

1. Load DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and load PDF files.
1. set the [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) properties.
1. Call [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) and save the file.

The code sample below shows how to export DXF to WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Support for Saving DXF Files**

Aspose.CAD provides the feature to load AutoCAD DXF files and make changes in it and save it again as a DXF file. The code sample below shows how to achieve specified requirements

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Export embedded DGN underlay for DXF format**

Aspose.CAD provides the feature to load AutoCAD DXF files and export embedded DGN underlay for DXF format.

The code sample below shows how to achieve specified requirements.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Exporting Specific DXF Layout to PDF**

This approach works as follow:

1. Open a DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an instance of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) and specify [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) properties.
1. Specify the desired layout name(s) using the [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) property.
1. Create an instance of [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)property.
1. Export the drawing to PDF using the [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) method.

The code sample below shows how to convert a specific layout of DXF to PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

The property [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) is of type string array so you may specify more than one layouts at a time for possible conversion to PDF format. While specifying multiple layouts for the [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) property, the resultant PDF would have multiple pages, where each page represents an individual AutoCAD layout.

{{% /alert %}}

## **Access ATTRIB and MTEXT objects**

This approach works as follow:

1. Open a DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Access the entities inside CAD file.
1. Check for [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) and [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) entities.
1. Add to temporary list for further processing

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Decompose CAD Insert Objects**

This approach works as follow:

1. Open a **DXF** drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Access the entities inside CAD file.
1. Check for [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) entities.
1. check for [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) type list
1. Process the entities

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Support of Block Clipping**

Aspose.CAD provides the feature of Block Clipping. Block Clipping approach works as follows:

1. Load DXF drawing file using the [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class and load PDF files.
1. Set desired properties of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Call [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) as the second parameter and save the file.

The code sample below shows how Block Clipping works.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Export Images to DXF**

Using Aspose.CAD, you can export images to the DXF format. Using this approach, you can perform the following actions:

1. Set new font
1. Hide entities
1. Update text

The following code snippet shows you how to perform listed above actions.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
