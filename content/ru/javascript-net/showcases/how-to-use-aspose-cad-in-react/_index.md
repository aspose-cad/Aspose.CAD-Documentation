---
title: Как использовать Aspose.CAD в React
type: docs
description: "Используйте Aspose.CAD в React"
weight: 75
url: /ru/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Предварительные требования
- Visual Code
- Node.js

## Конвертировать изображение dgn в png и отобразить в браузере

В этом примере вы создаете простую программу для конвертации, которая конвертирует чертеж и сохраняет его в виде изображения.

## Создание проекта React

1. Убедитесь, что вы уже не находитесь в каталоге рабочего пространства React.
1. Начните новый и затем укажите имя программы или используйте другие программы для создания проекта, такие как Visual Code или WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Установите Aspose.CAD из npm-пакета
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Создайте элементы input типа файл и img, чтобы загрузить и отобразить чертеж
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. В App.tsx мы описываем процесс запуска вспомогательных процессов, обработки и сохранения изображения
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="converted" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("loading WASM...");
  await boot();
  console.log("loaded WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // ЗАГРУЗКА
          var file = Image.load(array);

          // СОХРАНЕНИЕ
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. Запустите приложение
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Пример выполнения

1. Выберите файл.<br>
![Выберите файл](/_assets/javascript-net/react/choose-file.png)<br>
1. Выберите любой файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Если ответ успешен, файл будет отображен на экране и предложит загрузить его.<br>
![Конвертировать изображение](/_assets/javascript-net/react/convert-image.png)<br>

## См. также

- [Установить Visual Code](https://code.visualstudio.com/)
- [Установить Node.js](https://nodejs.org/en/)
