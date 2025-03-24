---
title: Hur man använder Aspose.CAD i JavaScript
type: docs
description: "använd Aspose.CAD i JavaScript."
weight: 73
url: /sv/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Förutsättningar
- Visual Code + Live Server
- Node.js

## Konvertera dgn-bild till png och visa i webbläsare

I det här exemplet skapar du ett enkelt konverteringsprogram som konverterar en ritning och sparar den som en bild.

## Skapa JavaScript

1. Skapa package.json med aspose-cad beroenden
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
1. Skapa index.html
{{< highlight plain >}}
<!DOCTYPE html>
Öppna konsolen (Ctrl+Shift+I) för att se utskriften.

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
          
		  //HÄMTA_FILFORMAT
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // LADDNING
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
![Välj fil](/cad/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Välj valfri DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil.
1. Om svaret är framgångsrikt kommer filen att visas på skärmen och erbjuda att ladda ner den.<br>
![Konvertera bild](/cad/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Se Även

- [Installera Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Installera Node.js](https://nodejs.org/en/)
