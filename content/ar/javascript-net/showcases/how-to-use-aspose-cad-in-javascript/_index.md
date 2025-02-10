---
title: كيفية استخدام Aspose.CAD في JavaScript
type: docs
description: "استخدام Aspose.CAD في JavaScript."
weight: 73
url: /ar/javascript-net/how-to-run-aspose-cad-in-javascript
---

## المتطلبات الأساسية
- Visual Code + Live Server
- Node.js

## تحويل صورة dgn إلى png وعرضها في المتصفح

في هذا المثال، ستقوم بإنشاء برنامج تحويل بسيط يقوم بتحويل رسم وحفظه كصورة.

## إنشاء JavaScript

1. إنشاء package.json مع تبعيات aspose-cad
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
1. إنشاء index.html
{{< highlight plain >}}
<!DOCTYPE html>
افتح وحدة التحكم (Ctrl+Shift+I) لرؤية الناتج.

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
          
		  //احصل على تنسيق الملف
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
1. بدء التطبيق مع [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) أو yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## مثال على التنفيذ

1. اختر ملف.<br>
![اختر ملف](/_assets/choose-file.png)<br>
1. اختر أي ملف DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG.
1. إذا كانت الإجابة ناجحة، فسيتم عرض الملف على الشاشة وسيوفر تحميله.<br>
![تحويل الصورة](/_assets/convert-image.png)<br>
## انظر أيضًا

- [تثبيت Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [تثبيت Node.js](https://nodejs.org/en/)
