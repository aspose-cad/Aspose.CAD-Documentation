---
title: Hogyan használjuk az Aspose.CAD-ot JavaScriptben
type: docs
description: "Aspose.CAD használata JavaScriptben."
weight: 73
url: /hu/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Előfeltételek
- Visual Code + Live Server
- Node.js

## DGN kép konvertálása PNG-re és megjelenítése a böngészőben

Ebben a példában egy egyszerű konverziós programot hozol létre, amely átkonvertál egy rajzot és képként menti el.

## JavaScript létrehozása

1. Hozd létre a package.json-t az aspose-cad függőségekkel
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
1. Hozd létre az index.html-t
{{< highlight plain >}}
<!DOCTYPE html>
Nyisd meg a konzolt (Ctrl+Shift+I) az eredmény megtekintéséhez.

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
          
		  //FÁJL FORMÁTUM MEGTSZÁMÍTÁSA
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // BETÖLTÉS
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // KIMENTÉS
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

1. Telepítsd a csomagokat az npm parancs használatával
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Indítsd el az alkalmazást a [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) vagy a yarn segítségével
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Példa végrehajtásra

1. Válaszd ki a fájlt.<br>
![Fájl kiválasztása](/cad/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Válassz ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Ha a válasz sikeres, a fájl megjelenik a képernyőn, és felajánlja a letöltést.<br>
![Kép konvertálása](/cad/_assets/javascript-net/javascript-net/convert-image.png)<br>
## További információk

- [Visual Code telepítése](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js telepítése](https://nodejs.org/en/)
