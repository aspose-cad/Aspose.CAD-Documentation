---
title: Hogyan használjuk az Aspose.CAD-ot TypeScript-ben
type: docs
description: "Aspose.CAD használata TypeScript-ben."
weight: 74
url: /hu/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---

## Előfeltételek
- Visual Code + Live Server
- Node.js

## DGN kép konvertálása PNG-re és megjelenítése a böngészőben

Ebben a példában egy egyszerű konverziós programot készít, amely egy rajzot konvertál és képként menti el.

## JavaScript létrehozása

1. Hozzon létre package.json fájlt a projekt mappában
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Módosítsa a package.json-t, adja hozzá az aspose-cad függőségeket
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
1. Hozzon létre index.ts fájlt
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //FÁJL_FORMÁTUM_LEKÉRDEZÉS
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // BETÖLTÉS
    var file = Image.load(array);
    console.log(file);
    
    // MEGTARTÁS
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Használja az npm parancsot index.js létrehozásához
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Hozzon létre index.html fájlt
{{< highlight plain >}}
<!DOCTYPE html>
Nyissa meg a konzolt (Ctrl+Shift+I), hogy megtekintse a kimenetet.

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
          
		  //FÁJL_FORMÁTUM_LEKÉRDEZÉS
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // BETÖLTÉS
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // MEGTARTÁS
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

1. Telepítse a csomagokat az npm parancs használatával
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Indítsa el az alkalmazást [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) vagy yarn segítségével
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Példa végrehajtásra

1. Válassza ki a fájlt.<br>
![Fájl kiválasztása](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. Válasszon ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Ha a válasz sikeres, a fájl megjelenik a képernyőn, és felajánlja a letöltését.<br>
![Kép konvertálása](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## További információk

- [Visual Code telepítése](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js telepítése](https://nodejs.org/en/)
