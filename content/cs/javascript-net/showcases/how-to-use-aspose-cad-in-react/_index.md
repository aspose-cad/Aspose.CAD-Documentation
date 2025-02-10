---
title: Jak používat Aspose.CAD v Reactu
type: docs
description: "Použití Aspose.CAD v Reactu"
weight: 75
url: /cs/javascript-net/jak-pouzivat-aspose-cad-v-reactu
---

## Předpoklady
- Visual Code
- Node.js

## Převod obrázku dgn na png a zobrazení v prohlížeči

V tomto příkladu vytvoříte jednoduchý program pro převod kresby a její uložení jako obrázku.

## Vytvoření React projektu

1. Ujistěte se, že již nejste ve složce pracovního prostoru React.
1. Vytvořte nový a poté zadejte název programu nebo použijte jiné programy k vytvoření projektu, například Visual Code nebo WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Nainstalujte Aspose.CAD z npm balíčku
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Vytvořte vstupní typ souboru a značky img pro načtení a zobrazení kresby
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. V souboru App.tsx popisujeme proces spouštění pomocných procesů, zpracování a uložení obrázku
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

          // LOAD
          var file = Image.load(array);

          // SAVE
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
1. Spusťte aplikaci
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Příklad provedení

1. Vyberte soubor.<br>
![Vybrat soubor](/_assets/choose-file.png)<br>
1. Vyberte libovolný DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG soubor.
1. Pokud odpověď bude úspěšná, soubor bude zobrazen na obrazovce a nabídne možnost jeho stažení.<br>
![Převést obrázek](/_assets/convert-image.png)<br>

## Viz také

- [Instalace Visual Code](https://code.visualstudio.com/)
- [Instalace Node.js](https://nodejs.org/cs/)
