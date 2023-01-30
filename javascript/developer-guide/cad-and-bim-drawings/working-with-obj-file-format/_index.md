---
title: Working with OBJ File Format
type: docs
weight: 120
url: /javascript/working-with-obj-file-format/
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

async onFileSelected(event) {
 const file: File = event.target.files[0];
 file.arrayBuffer().then(async buff => {
  let x = new Uint8Array(buff);
  this.imgFile = await Image.load(x);
  var exportedFile = await Image.save(this.imgFile, new PngOptions());
  var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
  });
}

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-OBJ-to-PNG-Export.cs" >}}
