---
title: Wie man Aspose.CAD in React verwendet
type: docs
description: "Verwenden Sie Aspose.CAD in React"
weight: 75
url: /de/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Voraussetzungen
- Visual Studio Code
- Node.js

## Konvertieren Sie eine DGN-Bilddatei in PNG und zeigen Sie sie im Browser an

In diesem Beispiel erstellen Sie ein einfaches Konvertierungsprogramm, das eine Zeichnung konvertiert und als Bild speichert.

## Erstellen des React-Projekts

1. Stellen Sie sicher, dass Sie sich nicht bereits in einem React-Arbeitsbereisverzeichnis befinden.
1. Starten Sie ein neues und geben Sie dann den Namen des Programms ein oder verwenden Sie andere Programme wie Visual Studio Code oder WebStorm, um ein Projekt zu erstellen:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Installieren Sie Aspose.CAD aus dem npm-Paket
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Erstellen Sie einen Eingabetyp-Datei und img-Tags, um die Zeichnung zu laden und anzuzeigen
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. In App.tsx beschreiben wir den Prozess des Startens der Hilfsprozesse, des Verarbeitens und Speicherns des Bildes
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
  console.log("Lade WASM...");
  await boot();
  console.log("WASM geladen");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {
          
          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // Laden
          var file = Image.load(array);

          // Speichern
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
1. Starten der Anwendung
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Ausführungsbeispiel

1. Datei auswählen.<br>
![Datei auswählen](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. Wählen Sie eine DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-Datei aus.
1. Wenn die Antwort erfolgreich ist, wird die Datei auf dem Bildschirm angezeigt und es wird angeboten, sie herunterzuladen.<br>
![Bild konvertieren](/cad/_assets/javascript-net/react/convert-image.png)<br>

## Siehe auch

- [Visual Studio Code installieren](https://code.visualstudio.com/)
- [Node.js installieren](https://nodejs.org/en/)
