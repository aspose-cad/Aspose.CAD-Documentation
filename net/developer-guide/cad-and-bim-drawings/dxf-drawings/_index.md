---
title: DXF Drawings
type: docs
weight: 60
url: /net/dxf-drawings/
---

## **Exporting DXF Drawings to PDF**

Aspose.CAD provides the feature to load AutoCAD DXF drawing entities and render them as an entire drawing to PDF format. DXF to PDF conversion approach works as follows:

1. Load DXF drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set the [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

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

The property [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) of the [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) class can be used to control memory re-allocation. Re-allocation is most likely to occur for pre-allocated caches. It can happen when the system figures out that the allocated space will not be sufficient.

- If [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) is set to the default value, **False**, the space is re-allocated to the same medium.
- When set to **True**, re-allocation cannot exceed the maximum specified space. In this case the existing allocated in-memory cache (which requires re-allocation) is freed and extended space is allocated on disk.

## **Exporting Specific Layer of DXF Drawings to PDF**

This approach works as follows:

1. Open a DXF drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Create an instance of [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) and specify [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) properties.
1. Add layers to the object of [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Create an instance of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Call the [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method and pass the object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

The code sample below shows how to convert a specific layer of DXF to PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Render PDF files as a part of DXF drawings**

This approach works as follow:

1. Load DXF drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and load PDF files.
1. set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) and save the file.

The code sample below shows how to render PDF files as a part of DXF drawings.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Export embedded DGN underlay for DXF format**

Aspose.CAD provides the feature to load AutoCAD DXF files and export embedded DGN underlay for DXF format.

The code sample below shows how to achieve specified requirements.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Support for Saving DXF Files**

Aspose.CAD provides the feature to load AutoCAD DXF files and make changes in it and save it again as a DXF file.

The code sample below shows how to achieve specified requirements.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Export DXF to WMF**

This approach works as follow:

1. Load DXF drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and load PDF files.
1. set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) and save file.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exporting Specific DXF Layout to PDF**

This approach works as follow:

1. Open a DXF drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Create an instance of [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) and specify [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) properties.
1. Specify the desired layout name(s) using the [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) property.
1. Create an instance of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Export the drawing to PDF calling the [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method and passing the object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

The code sample below shows how to convert a specific layout of DXF to PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

The property [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) is of type string array so you may specify more than one layouts at a time for possible conversion to PDF format. While specifying multiple layouts for the [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) property, the resultant PDF would have multiple pages, where each page represents an individual AutoCAD layout.

{{% /alert %}}

## **Support of Block Clipping**

Aspose.CAD provides the feature of Block Clipping. Block Clipping approach works as follows:

1. Load DXF drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and load PDF files.
1. Set desired properties of [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as second parameter and save the file.

The code sample below shows how Block Clipping works.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Export Images to DXF**

Using Aspose.CAD, you can export images to DXF format. Using this approach, you can perform the following actions:

1. Set new font
1. Hide entities
1. Update text

The following code snippet shows you how to perform listed above actions.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Exporting Specific Layer of DXF Drawings to Image**

This approach works as follows:

1. Open a DXF drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) factory method.
1. Create an instance of [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) and specify [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) and [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) properties.
1. Add layers to the object of [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Create an instance of [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) and set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) property.
1. Export the drawing to PDF using the [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) method.

The code sample below shows how to convert a specific layer of DXF to Image.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
