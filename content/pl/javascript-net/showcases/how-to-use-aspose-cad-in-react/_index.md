---
title: Jak używać Aspose.CAD w React
type: docs
description: "Użyj Aspose.CAD w React"
weight: 75
url: /pl/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Wymagania wstępne
- Visual Code
- Node.js

## Konwertuj obraz dgn na png i wyświetl w przeglądarce

W tym przykładzie utworzysz prosty program konwertujący, który konwertuje rysunek i zapisuje go jako obraz.

## Tworzenie projektu React

1. Upewnij się, że nie jesteś już w katalogu roboczym React.
1. Rozpocznij nowy i podaj nazwę programu lub użyj innych programów do utworzenia projektu, takich jak Visual Code lub WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Zainstaluj Aspose.CAD z pakietu npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Utwórz znacznik typu pliku i img, aby załadować i wyświetlić rysunek
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. W App.tsx opisujemy proces uruchamiania procesów pomocniczych, przetwarzania i zapisywania obrazu
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
  console.log("ładowanie WASM...");
  await boot();
  console.log("załadowano WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // ŁADUJ
          var file = Image.load(array);

          // ZAPISZ
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
1. Uruchom aplikację
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Przykład wykonania

1. Wybierz plik.<br>
![Wybierz plik](/_assets/javascript-net/react/choose-file.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Jeśli odpowiedź będzie pomyślna, plik zostanie wyświetlony na ekranie i zostanie zaproponowane jego pobranie.<br>
![Konwertuj obraz](/_assets/javascript-net/react/convert-image.png)<br>

## Zobacz także

- [Zainstaluj Visual Code](https://code.visualstudio.com/)
- [Zainstaluj Node.js](https://nodejs.org/en/)
