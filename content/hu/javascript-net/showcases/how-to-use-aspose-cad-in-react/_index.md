---
title: Hogyan használjuk az Aspose.CAD-ot React-ben
type: docs
description: "Aspose.CAD használata React-ben"
weight: 75
url: /hu/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Előfeltételek
- Visual Code
- Node.js

## DGN kép átkonvertálása PNG-vé és megjelenítése a böngészőben

Ebben a példában létrehoz egy egyszerű átkonvertáló programot, amely egy rajzot konvertál és képként ment el.

## A React projekt létrehozása

1. Győződjön meg róla, hogy nem egy React munkaterületi könyvtárban van.
1. Indítson egy újat, majd a program nevét, vagy használjon más programokat egy projekt létrehozásához, mint például a Visual Code vagy a WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Telepítse az Aspose.CAD-ot az npm csomagból
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Hozzon létre egy bemeneti típusú fájlt és img tageket a rajz betöltésére és megjelenítésére
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="konvertálva" id="image" />
</span>
{{< /highlight >}}
1. Az App.tsx fájlban leírjuk a segédfolyamatok elindításának, a feldolgozásnak és a kép mentésének folyamatát
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
          <img alt="konvertálva" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("WASM betöltése...");
  await boot();
  console.log("WASM betöltve");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // BETÖLTÉS
          var file = Image.load(array);

          // MEGTARTÁS
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
1. Alkalmazás indítása
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Futtatási példa

1. Válassza ki a fájlt.<br>
![Fájl kiválasztása](/_assets/javascript-net/react/choose-file.png)<br>
1. Válasszon ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Ha a válasz sikeres, a fájl megjelenik a képernyőn és felajánlja a letöltését.<br>
![Kép konvertálása](/_assets/javascript-net/react/convert-image.png)<br>

## Lásd még

- [Visual Code telepítése](https://code.visualstudio.com/)
- [Node.js telepítése](https://nodejs.org/en/)
