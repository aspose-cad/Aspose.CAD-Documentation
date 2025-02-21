---
title: Come utilizzare Aspose.CAD in JavaScript
type: docs
description: "utilizzare Aspose.CAD in JavaScript."
weight: 73
url: /it/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Requisiti
- Visual Code + Live Server
- Node.js

## Converti l'immagine dgn in png e visualizzala nel browser

In questo esempio, crei un semplice programma di conversione che converte un disegno e lo salva come immagine.

## Creazione del JavaScript

1. Crea package.json con le dipendenze di aspose-cad
{{< highlight plain >}}
"dependencies": {
    "aspose-cad": "^23.1.0"
  },
 "devDependencies": {
    "live-server": "^1.2.1",
    "typescript": "^3.3.3333",
    "yarn": "^1.22.19"
  }
{{< /highlight >}}
1. Crea index.html
{{< highlight plain >}}
<!DOCTYPE html>
Apri la console (Ctrl+Shift+I) per vedere l'output.

<script src="./node_modules/aspose-cad/dotnet.js"></script>
<script type="module" src="./node_modules/aspose-cad/es2015/index-js.js"></script>

<body>
    <input id="file" type="file">
    <img id="image" />
</body>

<script>
window.onload = async function () {
    document.querySelector('input').addEventListener('change', function() {
      var reader = new FileReader();
      reader.onload = function() {
      
          var arrayBuffer = this.result;
          var array = new Uint8Array(arrayBuffer);
          
          //GET_FILE_FORMAT
          fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
          
          // LOAD
          file = Aspose.CAD.Image.load(array);
          console.log(file);
          
          // SAVE
          exportedFilePromise = Aspose.CAD.Image.save(array, new Aspose.CAD.PngOptions());
          exportedFilePromise.then(exportedFile => {
            console.log(exportedFile);
            
            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            document.querySelector("#image").src = imageUrl;
          });
      }
      
      reader.readAsArrayBuffer(this.files[0]);
    }, 
    false);
};
</script>
{{< /highlight >}}

1. Installa i pacchetti utilizzando il comando npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Avvia l'applicazione con [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) o yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Esempio di esecuzione

1. Scegli un file.<br>
![Scegli un file](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Seleziona un file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se la risposta ha successo, il file verrà visualizzato sullo schermo e verrà proposto di scaricarlo.<br>
![Converti immagine](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Vedi Anche

- [Installa Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Installa Node.js](https://nodejs.org/en/)
