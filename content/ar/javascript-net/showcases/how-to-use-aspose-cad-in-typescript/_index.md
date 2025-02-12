---
title: كيفية استخدام Aspose.CAD في TypeScript
type: docs
description: "استخدم Aspose.CAD في TypeScript."
weight: 74
url: /ar/javascript-net/how-to-use-aspose-cad-in-typescript
---

## المتطلبات الأساسية
- فيجوال كود + سيرفر مباشر
- Node.js

## تحويل صورة dgn إلى png وعرضها في المتصفح

في هذا المثال، تقوم بإنشاء برنامج تحويل بسيط يقوم بتحويل رسم وحفظه كصورة.

## إنشاء JavaScript

1. إنشاء package.json في مجلد المشروع
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. تعديل package.json، إضافة تبعيات aspose-cad
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
1. إنشاء index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    // الحصول على تنسيق الملف
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // تحميل
    var file = Image.load(array);
    console.log(file);
    
    // حفظ
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. استخدم الأمر npm لإنشاء index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. إنشاء index.html
{{< highlight plain >}}
<!DOCTYPE html>
افتح وحدة التحكم (Ctrl+Shift+I) لرؤية المخرجات.

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
          
		  // الحصول على تنسيق الملف
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // تحميل
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // حفظ
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

1. تثبيت الحزم باستخدام أمر npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. بدء التطبيق باستخدام [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) أو yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## مثال على التنفيذ

1. اختر ملف.<br>
![اختر ملف](/_assets/javascript-net/typescript/choose-file.png)<br>
1. اختر أي ملف DXF أو DWG أو DGN أو DWF أو DWFX أو IFC أو STL أو DWT أو IGES أو PLT أو CF2 أو OBJ أو HPGL أو IGS أو PCL أو FBX أو PDF أو SVG.
1. إذا كانت الاستجابة ناجحة، سيكون الملف معروضًا على الشاشة وسيوفر لك تنزيله.<br>
![تحويل الصورة](/_assets/javascript-net/typescript/convert-image.png)<br>
## انظر أيضًا

- [تثبيت فيجوال كود](https://code.visualstudio.com/)
- [سيرفر مباشر](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [تثبيت Node.js](https://nodejs.org/en/)
