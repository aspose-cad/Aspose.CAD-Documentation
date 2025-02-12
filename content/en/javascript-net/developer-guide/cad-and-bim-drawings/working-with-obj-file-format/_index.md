---
title: Working with OBJ File Format
type: docs
weight: 120
url: /javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD now supports the OBJ file format. The OBJ file format is a 3D geometry that contains texture maps, 3D coordinates, polygonal faces, and other object information.

{{% /alert %}}

## **Exporting OBJ Format To PNG**

Aspose.CAD for Javascript in Angular allows developers to export an [OBJ](https://docs.fileformat.com/3d/obj/) file to [PNG](https://docs.fileformat.com/image/png/) format.
[OBJ](https://docs.fileformat.com/3d/obj/) to [PNG](https://docs.fileformat.com/image/png/) conversion approach works as follows:

1. Load [OBJ](https://docs.fileformat.com/3d/obj/) drawing file using the **Image.load** method.
1. Call **Image.save** while passing an object of **PngOptions** as the second parameter.

## Sample Code

The code below shows how to achieve the same goal using Aspose.CAD for JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
