---
title: Hur man använder Aspose.CAD i React
type: docs
description: "Använd Aspose.CAD i React"
weight: 75
url: /sv/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Förutsättningar
- Visual Code
- Node.js

## Konvertera dgn-bild till png och visa i webbläsare

I detta exempel skapar du ett enkelt konverteringsprogram som konverterar en ritning och sparar den som en bild.

## Skapa React-projektet

1. Se till att du inte redan är i en React arbetskatalog.
1. Starta en ny och ange namnet på programmet eller använd andra program för att skapa ett projekt, såsom Visual Code eller WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Installera Aspose.CAD från npm-paketet
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Skapa en inputtyp för fil och img-taggar för att ladda och visa ritningen
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="konverterad" id="image" />
</span>
{{< /highlight >}}
1. I App.tsx beskriver vi processen för att starta hjälpprocesserna, bearbeta och spara bilden
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
          <img alt="konverterad" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("laddar WASM...");
  await boot();
  console.log("laddad WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // LÄS
          var file = Image.load(array);

          // SPARA
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
1. Starta applikationen
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Exempel på utförande

1. Välj fil.<br>
![Välj fil](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. Välj någon DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fil.
1. Om svaret är framgångsrikt kommer filen att visas på skärmen och erbjuda att ladda ner den.<br>
![Konvertera bild](/cad/_assets/javascript-net/react/convert-image.png)<br>

## Se även

- [Installera Visual Code](https://code.visualstudio.com/)
- [Installera Node.js](https://nodejs.org/en/)
