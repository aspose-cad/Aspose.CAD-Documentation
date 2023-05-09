---
title: DXF Drawings
type: docs
weight: 60
url: /python-net/dxf-drawings/
---

## **Exporting DXF Drawings to PDF**

Aspose.CAD provides the feature to load AutoCAD DXF drawing entities and render them as an entire drawing to PDF format. DXF to PDF conversion approach works as follows:

1. Load DXF drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **page_height** & **page_width** properties.
1. Create an object of the **PdfOptions** class and set the **VectorRasterizationOptions** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

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

## **Export embedded DGN underlay for DXF format**

Aspose.CAD provides the feature to load AutoCAD DXF files and export embedded DGN underlay for DXF format.

The code sample below shows how to achieve specified requirements.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Support for Saving DXF Files**

Aspose.CAD provides the feature to load AutoCAD DXF files and make changes in it and save it again as a DXF file.

The code sample below shows how to achieve specified requirements.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Export DXF to WMF**

This approach works as follow:

1. Load DXF drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and load PDF files.
1. set the **page_height** & **Ppage_width** properties.
1. Call **Image.save** and save file.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}