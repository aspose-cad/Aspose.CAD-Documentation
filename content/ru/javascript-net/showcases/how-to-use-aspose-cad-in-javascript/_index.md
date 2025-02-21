---
title: Как использовать Aspose.CAD в JavaScript
type: docs
description: "используйте Aspose.CAD в JavaScript."
weight: 73
url: /ru/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Предварительные требования
- Visual Code + Live Server
- Node.js

## Конвертация изображения dgn в png и отображение в браузере

В этом примере вы создаете простую программу конвертации, которая преобразует чертеж и сохраняет его в качестве изображения.

## Создание JavaScript

1. Создайте package.json с зависимостями aspose-cad
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
1. Создайте index.html
{{< highlight plain >}}
<!DOCTYPE html>
Откройте консоль (Ctrl+Shift+I), чтобы увидеть вывод.

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

1. Установите пакеты с помощью команды npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Запустите приложение с помощью [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) или yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Пример выполнения

1. Выберите файл.<br>
![Выберите файл](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Выберите любой файл формата DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Если ответ успешен, файл будет отображен на экране и будет предложено его скачать.<br>
![Конвертировать изображение](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Также см. 

- [Установить Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Установить Node.js](https://nodejs.org/en/)
