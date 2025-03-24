---
title: Як використовувати Aspose.CAD у TypeScript
type: docs
description: "Використовуйте Aspose.CAD у TypeScript."
weight: 74
url: /uk/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## Попередні вимоги
- Visual Code + Live Server
- Node.js

## Перетворення зображення dgn у png та відображення в браузері

У цьому прикладі ви створите просту програму для перетворення, яка перетворює креслення та зберігає його у вигляді зображення.

## Створення JavaScript

1. Створіть package.json у папці проекту
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Змініть package.json, додайте залежності aspose-cad
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
1. Створіть index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //ОТРИМАННЯ_ФОРМАТУ_ФАЙЛУ
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // ЗАВАНТАЖЕННЯ
    var file = Image.load(array);
    console.log(file);
    
    // ЗБЕРЕЖЕННЯ
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Використайте команду npm для створення index.js
{{< highlight plain >}}
tsc
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
          
		  //ОТРИМАННЯ_ФОРМАТУ_ФАЙЛУ
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // ЗАВАНТАЖЕННЯ
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // ЗБЕРЕЖЕННЯ
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

1. Встановіть пакети, використовуючи команду npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Запустіть застосунок за допомогою [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) або yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Приклад виконання

1. Виберіть файл.<br>
![Виберіть файл](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Якщо відповідь успішна, файл буде відображений на екрані та буде запропоновано його завантажити.<br>
![Перетворити зображення](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## Дивіться також

- [Встановіть Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Встановіть Node.js](https://nodejs.org/en/)
