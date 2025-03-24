---
title: Как да използвате Aspose.CAD в TypeScript
type: docs
description: "Използвайте Aspose.CAD в TypeScript."
weight: 74
url: /bg/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## Предварителни условия
- Visual Code + Live Server
- Node.js

## Преобразуване на dgn изображение в png и показване в браузъра

В този пример ще създадете проста програма за преобразуване, която преобразува чертеж и го запазва като изображение.

## Създаване на JavaScript

1. Създайте package.json в папката на проекта
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Променете package.json, добавете зависимости на aspose-cad
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
1. Създайте index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //ВЗЕМИ_ФОРМАТ_НА_ФАЙЛА
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // ЗАРЕЖДАНЕ
    var file = Image.load(array);
    console.log(file);
    
    // ЗАПАЗВАНЕ
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Използвайте npm командата за създаване на index.js
{{< highlight plain >}}
tsc
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
          
		  //ВЗЕМИ_ФОРМАТ_НА_ФАЙЛА
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // ЗАРЕЖДАНЕ
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
![Изберете файл](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. Изберете всякакъв DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG файл.
1. Ако отговорът е успешен, файлът ще бъде показан на екрана и ще предложи да го изтеглите.<br>
![Преобразуване на изображение](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## Вижте също

- [Инсталирайте Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Инсталирайте Node.js](https://nodejs.org/en/)
