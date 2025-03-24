---
title: Как использовать Aspose.CAD в TypeScript
type: docs
description: "Использование Aspose.CAD в TypeScript."
weight: 74
url: /ru/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## Предварительные условия
- Visual Code + Live Server
- Node.js

## Преобразование изображения dgn в png и отображение в браузере

В этом примере вы создаете простую программу для преобразования, которая преобразует рисунок и сохраняет его в виде изображения.

## Создание JavaScript

1. Создайте package.json в папке проекта
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Измените package.json, добавьте зависимости aspose-cad
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
1. Создайте index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //ПОЛУЧИТЬ_ФОРМАТ_ФАЙЛА
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // ЗАГРУЗИТЬ
    var file = Image.load(array);
    console.log(file);
    
    // СОХРАНИТЬ
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Используйте команду npm, чтобы создать index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Создайте index.html
{{< highlight plain >}}
<!DOCTYPE html>
Откройте консоль (Ctrl+Shift+I), чтобы увидеть результат.

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
          
		  //ПОЛУЧИТЬ_ФОРМАТ_ФАЙЛА
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // ЗАГРУЗИТЬ
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // СОХРАНИТЬ
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

1. Установите пакеты, используя команду npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Запустите приложение с помощью [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) или yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Пример выполнения

1. Выберите файл.<br>
![Выберите файл](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. Выберите любой файл формата DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Если ответ успешен, файл будет отображаться на экране и предложит его скачать.<br>
![Преобразовать изображение](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## Также смотрите

- [Установить Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Установить Node.js](https://nodejs.org/en/)
