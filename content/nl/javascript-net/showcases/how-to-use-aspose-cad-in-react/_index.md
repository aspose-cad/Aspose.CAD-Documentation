---
title: Hoe Aspose.CAD te gebruiken in React
type: docs
description: "Gebruik Aspose.CAD in React"
weight: 75
url: /nl/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Vereisten
- Visual Code
- Node.js

## Converteer dgn-afbeelding naar png en toon in browser

In dit voorbeeld maak je een eenvoudig conversieprogramma dat een tekening converteert en opslaat als een afbeelding.

## Het React-project aanmaken

1. Zorg ervoor dat je je niet al in een React-werkruimtedirectory bevindt.
1. Start een nieuwe en geef de naam van het programma op of gebruik andere programma's om een project te creëren, zoals Visual Code of WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Installeer Aspose.CAD vanuit het npm-pakket
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Maak een inputtypebestand en img-tags aan om de tekening te laden en weer te geven
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. In App.tsx beschrijven we het proces van het starten van de helperprocessen, het verwerken en opslaan van de afbeelding
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

          // LAAD
          var file = Image.load(array);

          // OPSLAAN
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
1. Start de applicatie
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Voorbeeld van uitvoering

1. Kies bestand.<br>
![Kies bestand](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. Selecteer een DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-bestand.
1. Als het antwoord succesvol is, wordt het bestand op het scherm weergegeven en wordt aangeboden om het te downloaden.<br>
![Converteer afbeelding](/cad/_assets/javascript-net/react/convert-image.png)<br>

## Zie ook

- [Installeer Visual Code](https://code.visualstudio.com/)
- [Installeer Node.js](https://nodejs.org/en/)
