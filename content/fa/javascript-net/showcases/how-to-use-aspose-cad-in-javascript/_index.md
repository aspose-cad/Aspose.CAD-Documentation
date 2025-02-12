---
title: نحوه استفاده از Aspose.CAD در جاوا اسکریپت
type: docs
description: "استفاده از Aspose.CAD در جاوا اسکریپت."
weight: 73
url: /fa/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## پیش نیازها
- Visual Code + Live Server
- Node.js

## تبدیل تصویر dgn به png و نمایش در مرورگر

در این مثال، شما یک برنامه تبدیل ساده ایجاد می‌کنید که یک نقاشی را تبدیل کرده و آن را به عنوان تصویر ذخیره می‌کند.

## ایجاد جاوا اسکریپت

1. ایجاد package.json با وابستگی‌های aspose-cad
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
1. ایجاد index.html
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

1. نصب بسته‌ها با استفاده از دستور npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. اجرای برنامه با [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) یا yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## مثال اجرایی

1. فایل را انتخاب کنید.<br>
![Choose file](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. اگر پاسخ موفقیت‌آمیز باشد، فایل روی صفحه نمایش داده می‌شود و به دانلود آن پیشنهاد می‌دهد.<br>
![Convert image](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## همچنین ببینید

- [نصب Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [نصب Node.js](https://nodejs.org/en/)
