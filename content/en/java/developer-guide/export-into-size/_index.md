---
title: Exporting DWG/DXF drawing and layouts into specified size
type: docs
weight: 40
url: /java/developer-guide/export-into-size/
---

## **Export Model and all layouts into A4 PDF size**

Aspose.CAD API allows you to export all sheets of the DWG/DXF file into specified physical PDF size.
The following sample code sets up the size of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) object to achieve desired PDF size.
The size of A4 paper sheet is 210x297 millimeters or 8.27x11.69 inches and these values are used in the code.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Export CAD Layouts to PDF in different size**

Sometimes it is required to export layout into its physical size. The example below demonstrates the export of the drawing into multipage PDF where each page with layout content
has its own physical PDF size. This example uses [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) property.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}