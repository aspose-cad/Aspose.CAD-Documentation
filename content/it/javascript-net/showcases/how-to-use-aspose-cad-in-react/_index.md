---
title: Come usare Aspose.CAD in React
type: docs
description: "Usa Aspose.CAD in React"
weight: 75
url: /it/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Requisiti
- Visual Code
- Node.js

## Converti un'immagine dgn in png e visualizzala nel browser

In questo esempio, crei un semplice programma di conversione che converte un disegno e lo salva come immagine.

## Creare il Progetto React

1. Assicurati di non essere già in una directory di lavoro React.
1. Inizia una nuova e poi il nome del programma o usa altri programmi per creare un progetto come Visual Code o WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Installa Aspose.CAD dal pacchetto npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Crea un input di tipo file e tag img per caricare e visualizzare il disegno
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="convertito" id="image" />
</span>
{{< /highlight >}}
1. In App.tsx, descriviamo il processo di avvio dei processi di supporto, elaborazione e salvataggio dell'immagine
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
          <img alt="convertito" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("caricamento WASM...");
  await boot();
  console.log("WASM caricato");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // CARICA
          var file = Image.load(array);

          // Salva
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
1. Avvia l'applicazione
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Esempio di esecuzione

1. Scegli file.<br>
![Scegli file](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se la risposta è positiva, il file verrà visualizzato sullo schermo e verrà offerta la possibilità di scaricarlo.<br>
![Converti immagine](/cad/_assets/javascript-net/react/convert-image.png)<br>

## Vedi Anche

- [Installa Visual Code](https://code.visualstudio.com/)
- [Installa Node.js](https://nodejs.org/en/)
