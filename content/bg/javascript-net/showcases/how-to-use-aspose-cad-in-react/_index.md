---
title: Как да използвате Aspose.CAD в React
type: docs
description: "Използвайте Aspose.CAD в React"
weight: 75
url: /bg/javascript-net/how-to-use-aspose-cad-in-react
---

## Предварителни условия
- Visual Code
- Node.js

## Конвертиране на dgn изображение в png и показване в браузъра

В този пример създавате проста програма за конвертиране, която конвертира чертеж и го запазва като изображение.

## Създаване на React проекта

1. Убедете се, че не се намирате в директория на работната среда на React.
1. Започнете нова и след това името на програмата или използвайте други програми за създаване на проект като Visual Code или WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Инсталирайте Aspose.CAD от npm пакета
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Създайте input тип файл и img тагове, за да заредите и покажете чертежа
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. В App.tsx описваме процеса на стартиране на помощните процеси, обработка и запазване на изображението
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
  console.log("зареждане на WASM...");
  await boot();
  console.log("зареден WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // ЗАРЕЖДАНЕ
          var file = Image.load(array);

          // ЗАПАЗВАНЕ
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
1. Стартирайте приложението
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Пример за изпълнение

1. Изберете файл.<br>
![Choose file](/_assets/javascript-net/react/choose-file.png)<br>
1. Изберете произволен файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Ако отговорът е успешен, файлът ще бъде показан на екрана и ще предложи да го изтеглите.<br>
![Convert image](/_assets/javascript-net/react/convert-image.png)<br>

## Вижте също

- [Инсталирайте Visual Code](https://code.visualstudio.com/)
- [Инсталирайте Node.js](https://nodejs.org/en/)
