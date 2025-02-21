---
title: Come usare Aspose.CAD in TypeScript
type: docs
description: "Usa Aspose.CAD in TypeScript."
weight: 74
url: /it/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---

## Requisiti
- Visual Code + Live Server
- Node.js

## Converti immagine dgn in png e visualizzala nel browser

In questo esempio, crei un semplice programma di conversione che converte un disegno e lo salva come immagine.

## Creare il JavaScript

1. Crea package.json nella cartella del progetto
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Modifica package.json, aggiungi le dipendenze di aspose-cad
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
1. Crea index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //OTTENERE_IL_FORMATO_DEI_FILE
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // CARICAMENTO
    var file = Image.load(array);
    console.log(file);
    
    // SALVA
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Usa il comando npm per creare index.js
{{< highlight plain >}}
tsc
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
          
		  //OTTENERE_IL_FORMATO_DEI_FILE
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // CARICAMENTO
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // SALVA
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

1. Scegli file.<br>
![Scegli file](/_assets/javascript-net/typescript/choose-file.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se la risposta è positiva, il file verrà visualizzato sullo schermo e offrirà di scaricarlo.<br>
![Converti immagine](/_assets/javascript-net/typescript/convert-image.png)<br>
## Vedi anche

- [Installa Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Installa Node.js](https://nodejs.org/en/)
