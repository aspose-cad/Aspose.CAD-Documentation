---
title: Working with Watermark
type: docs
weight: 60
url: /javascript/working-with-watermark/
---

## **Add Watermark in a DGN**

Sometimes you want to add some watermarks to drawings to indicate what purpose of the drawings or who created them. Aspose.CAD for Python allows you to add a watermark in a DGN file.

## Sample Code

The code below shows how to achieve the same goal using Aspose.CAD for JavaScript

async onFileSelected(event) {
 const file: File = event.target.files[0];
 file.arrayBuffer().then(async buff => {
  let x = new Uint8Array(buff);
  this.imgFile = await Image.load(x);
  let option = new PngOptions();
  option.userWatermarkColor = new Color();
  option.userWatermarkText = 'Aspose.CAD';
  var exportedFile = await Image.save(this.imgFile, option);
  var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
  });
}

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "AddWatermark.cs" >}}