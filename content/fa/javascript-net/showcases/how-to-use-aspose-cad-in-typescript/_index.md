---
title: چگونه از Aspose.CAD در TypeScript استفاده کنیم
type: docs
description: "استفاده از Aspose.CAD در TypeScript."
weight: 74
url: /fa/javascript-net/how-to-use-aspose-cad-in-typescript
---

## پیش‌نیازها
- Visual Code + Live Server
- Node.js

## تبدیل تصویر dgn به png و نمایش در مرورگر

در این مثال، شما یک برنامه تبدیل ساده ایجاد می‌کنید که یک نقاشی را تبدیل کرده و آن را به عنوان یک تصویر ذخیره می‌کند.

## ایجاد JavaScript

1. ایجاد package.json در پوشه پروژه
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
2. ویرایش package.json و اضافه کردن وابستگی‌های aspose-cad
{{< highlight plain >}}
"dependencies": {
    "aspose-cad": "^23.1.0"
  },
 "devDependencies": {
    "live-server": "^1.2.1",
    "typescript": "^3.3.3333",
    "yarn": "^1.22.19"
  }
{{< /highlight >}}
3. ایجاد index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //GET_FILE_FORMAT
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // LOAD
    var file = Image.load(array);
    console.log(file);
    
    // SAVE
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
4. استفاده از دستور npm برای ایجاد index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
5. ایجاد index.html
{{< highlight plain >}}
<!DOCTYPE html>
کنسول را باز کنید (Ctrl+Shift+I) تا خروجی را ببینید.

<script src="./node_modules/aspose-cad/dotnet.js"></script>
<script type="module" src="./node_modules/aspose-cad/es2015/index-js.js"></script>

<body>
	<input id="file" type="file">
	<img id="image" />
</body>

<script>
window.onload = async function () {
	document.querySelector('input').addEventListener('change', function() {
      var reader = new FileReader();
      reader.onload = function() {
      
          var arrayBuffer = this.result;
          var array = new Uint8Array(arrayBuffer);
          
		  //GET_FILE_FORMAT
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // LOAD
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // SAVE
		  exportedFilePromise = Aspose.CAD.Image.save(array, new Aspose.CAD.PngOptions());
		  exportedFilePromise.then(exportedFile => {
			console.log(exportedFile);
			
			var urlCreator = window.URL || window.webkitURL;
			var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            document.querySelector("#image").src = imageUrl;
		  });
      }
	  
      reader.readAsArrayBuffer(this.files[0]);
    }, 
	false);
};
</script>
{{< /highlight >}}

6. نصب بسته‌ها با استفاده از دستور npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
7. شروع برنامه با [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) یا yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## مثال اجرا

1. انتخاب فایل.<br>
![انتخاب فایل](/fa/_assets/choose-file.png)<br>
2. انتخاب هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG.
3. اگر پاسخ موفقیت‌آمیز باشد، فایل در صفحه نمایش داده خواهد شد و پیشنهاد دانلود آن داده می‌شود.<br>
![تبدیل تصویر](/fa/_assets/convert-image.png)<br>
## همچنین ببینید

- [نصب Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [نصب Node.js](https://nodejs.org/en/)
