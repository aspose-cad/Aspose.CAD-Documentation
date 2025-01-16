---
title: Jak používat Aspose.CAD v TypeScriptu
type: docs
description: "Použití Aspose.CAD v TypeScriptu."
weight: 74
url: /cs/javascript-net/jak-pouzivat-aspose-cad-v-typescriptu
---


## Předpoklady
- Visual Studio + Live Server
- Node.js

## Převod dgn obrázku na png a zobrazení v prohlížeči

V tomto příkladu vytvoříte jednoduchý konverzní program, který převede výkres a uloží ho jako obrázek.

## Vytvoření JavaScriptu

1. Vytvořte soubor package.json ve složce projektu
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Upravte package.json, přidejte závislosti aspose-cad
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
1. Vytvořte index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //GET_FILE_FORMAT
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // LOAD
    var file = Image.load(array);
    console.log(file);
    
    // SAVE
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Použijte npm příkaz k vytvoření index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Vytvořte index.html
{{< highlight plain >}}
<!DOCTYPE html>
Otevřete konzoli (Ctrl+Shift+I) pro zobrazení výstupu.

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

1. Nainstalujte balíčky pomocí npm příkazu
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Spusťte aplikaci s [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) nebo yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Příklad provedení

1. Vyberte soubor.<br>
![Vyberte soubor](choose-file.png)<br>
1. Vyberte libovolný soubor DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Pokud je odpověď úspěšná, soubor bude zobrazen na obrazovce a nabídne možnost jeho stažení.<br>
![Konvertovat obrázek](convert-image.png)<br>
## Viz také

- [Instalace Visual Studio](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Instalace Node.js](https://nodejs.org/en/)
