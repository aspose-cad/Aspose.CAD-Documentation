---
title: DWG Drawings
type: docs
weight: 40
url: /javascript/dwg-drawings/
---

## **Exporting DWG Format To PNG**

Aspose.CAD for Javascript in Angular allows developers to export an [DWG](https://docs.fileformat.com/cad/dwg/) file to [PNG](https://docs.fileformat.com/image/png/) format.
[DWG](https://docs.fileformat.com/cad/dwg/) to [PNG](https://docs.fileformat.com/image/png/) conversion approach works as follows:

1. Load [DWG](https://docs.fileformat.com/cad/dwg/) drawing file using the **Image.load** method.
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

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DWG-to-PNG-Export.cs" >}}