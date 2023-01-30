---
title: DXF Drawings
type: docs
weight: 60
url: /javascript/dxf-drawings/
---

## **Exporting DXF Format To PNG**

Aspose.CAD for Javascript in Angular allows developers to export an [DXF](https://docs.fileformat.com/cad/dxf/) file to [PNG](https://docs.fileformat.com/image/png/) format.
[DXF](https://docs.fileformat.com/cad/dxf/) to [PNG](https://docs.fileformat.com/image/png/) conversion approach works as follows:

1. Load [DXF](https://docs.fileformat.com/cad/dxf/) drawing file using the **Image.load** method.
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

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXF-to-PNG-Export.cs" >}}
