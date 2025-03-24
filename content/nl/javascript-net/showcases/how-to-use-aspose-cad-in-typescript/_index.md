---
title: Hoe Aspose.CAD te gebruiken in TypeScript
type: docs
description: "Gebruik Aspose.CAD in TypeScript."
weight: 74
url: /nl/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---

## Vereisten
- Visual Code + Live Server
- Node.js

## Converteer dgn afbeelding naar png en toon in de browser

In dit voorbeeld maak je een eenvoudig conversieprogramma dat een tekening converteert en opslaat als een afbeelding.

## Maak de JavaScript

1. Maak package.json aan in de projectmap
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Wijzig package.json, voeg aspose-cad afhankelijkheden toe
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
1. Maak index.ts aan
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //GET_FILE_FORMAT
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // LAAD
    var file = Image.load(array);
    console.log(file);
    
    // BEWAAR
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Gebruik de npm-opdracht om index.js aan te maken
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Maak index.html aan
{{< highlight plain >}}
<!DOCTYPE html>
Open console (Ctrl+Shift+I) om de output te zien.

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
		  
		  // LAAD
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // BEWAAR
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

1. Installeer de pakketten met de npm-opdracht
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Start de applicatie met [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) of yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Voorbeeld van uitvoering

1. Kies bestand.<br>
![Kies bestand](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. Selecteer een DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-bestand.
1. Als het antwoord succesvol is, wordt het bestand op het scherm weergegeven en wordt aangeboden om het te downloaden.<br>
![Converteren afbeelding](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## Zie ook

- [Installeer Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Installeer Node.js](https://nodejs.org/en/)
