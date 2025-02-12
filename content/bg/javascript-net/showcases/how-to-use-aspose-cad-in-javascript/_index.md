---
title: Как да използвате Aspose.CAD в JavaScript
type: docs
description: "използване на Aspose.CAD в JavaScript."
weight: 73
url: /bg/javascript-net/how-to-run-aspose-cad-in-javascript
---

## Предварителни условия
- Visual Code + Live Server
- Node.js

## Конвертиране на dgn изображение в png и показване в браузъра

В този пример ще създадете проста програма за конвертиране, която конвертира чертеж и го запазва като изображение.

## Създаване на JavaScript

1. Създайте package.json с зависимостите на aspose-cad
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
1. Създайте index.html
{{< highlight plain >}}
<!DOCTYPE html>
Отворете конзолата (Ctrl+Shift+I), за да видите изхода.

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
          
		  //ПОЛУЧАВАНЕ_ФОРМАТ_ФАЙЛ
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // ЗАЧИТАНЕ
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // ЗАПАЗВАНЕ
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

1. Инсталирайте пакетите, използвайки npm командата
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Стартирайте приложението с [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) или yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Пример за изпълнение

1. Изберете файл.<br>
![Изберете файл](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Изберете всеки DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG файл.
1. Ако отговорът е успешен, файлът ще бъде показан на екрана и ще предложи да го изтеглите.<br>
![Конвертиране на изображение](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Вижте също

- [Инсталирайте Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Инсталирайте Node.js](https://nodejs.org/en/)
