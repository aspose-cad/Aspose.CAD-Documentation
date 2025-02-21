---
title: Як використовувати Aspose.CAD у JavaScript
type: docs
description: "використовуйте Aspose.CAD у JavaScript."
weight: 73
url: /uk/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Потреби
- Visual Code + Live Server
- Node.js

## Перетворення зображення dgn у png та відображення в браузері

У цьому прикладі ви створюєте просту програму для конвертації, яка конвертує малюнок та зберігає його як зображення.

## Створення JavaScript

1. Створіть package.json з залежностями aspose-cad
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
1. Створіть index.html
{{< highlight plain >}}
<!DOCTYPE html>
Відкрийте консоль (Ctrl+Shift+I), щоб побачити вивід.

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

1. Встановіть пакети за допомогою команди npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Запустіть додаток за допомогою [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) або yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Приклад виконання

1. Виберіть файл.<br>
![Choose file](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Якщо відповідь успішна, файл буде відображений на екрані і буде запропоновано завантажити його.<br>
![Convert image](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Дивіться також

- [Встановити Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Встановити Node.js](https://nodejs.org/en/)
