---
title: Hur man använder Aspose.CAD i TypeScript
type: docs
description: "Använd Aspose.CAD i TypeScript."
weight: 74
url: /sv/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## Förutsättningar
- Visual Code + Live Server
- Node.js

## Konvertera dgn-bild till png och visa i webbläsaren

I det här exemplet skapar du ett enkelt konverteringsprogram som konverterar en ritning och sparar den som en bild.

## Skapa JavaScript

1. Skapa package.json i projektmappen
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Modifiera package.json, lägg till aspose-cad beroenden
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
1. Skapa index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //HÄMTA_FIL_FORMAT
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // LÄS IN
    var file = Image.load(array);
    console.log(file);
    
    // SPARA
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Använd npm-kommandot för att skapa index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Skapa index.html
{{< highlight plain >}}
<!DOCTYPE html>
Öppna konsolen (Ctrl+Shift+I) för att se utdata.

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
          
		  //HÄMTA_FIL_FORMAT
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // LÄS IN
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // SPARA
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

1. Installera paketen med npm-kommandot
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Starta applikationen med [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) eller yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Exempel på körning

1. Välj fil.<br>
![Välj fil](/_assets/javascript-net/typescript/choose-file.png)<br>
1. Välj valfri DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil.
1. Om svaret är framgångsrikt kommer filen att visas på skärmen och erbjuda att ladda ner den.<br>
![Konvertera bild](/_assets/javascript-net/typescript/convert-image.png)<br>
## Se Även

- [Installera Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Installera Node.js](https://nodejs.org/en/)
