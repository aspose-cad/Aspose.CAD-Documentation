---
title: Як використовувати Aspose.CAD у React
type: docs
description: "Використовуйте Aspose.CAD у React"
weight: 75
url: /uk/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Передумови
- Visual Code
- Node.js

## Конвертація зображення dgn у png та відображення в браузері

У цьому прикладі ви створюєте просту програму для конвертації, яка перетворює малюнок і зберігає його як зображення.

## Створення проекту React

1. Переконайтеся, що ви не перебуваєте вже в каталозі робочого простору React.
1. Розпочніть новий та введіть назву програми або використовуйте інші програми для створення проекту, такі як Visual Code або WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Встановіть Aspose.CAD з пакета npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Створіть теги типу input для файлів і img для завантаження та відображення малюнка
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="перетворене" id="image" />
</span>
{{< /highlight >}}
1. У App.tsx ми описуємо процес запуску допоміжних процесів, обробки та збереження зображення
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
          <img alt="перетворене" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("завантаження WASM...");
  await boot();
  console.log("завантажено WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // ЗАВАНТАЖИТИ
          var file = Image.load(array);

          // ЗБЕРЕГТИ
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
1. Запустіть застосунок
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Приклад виконання

1. Виберіть файл.<br>
![Виберіть файл](/_assets/javascript-net/react/choose-file.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Якщо відповідь успішна, файл буде відображено на екрані та запропонує його завантажити.<br>
![Конвертація зображення](/_assets/javascript-net/react/convert-image.png)<br>

## Дивіться також

- [Встановіть Visual Code](https://code.visualstudio.com/)
- [Встановіть Node.js](https://nodejs.org/en/)
