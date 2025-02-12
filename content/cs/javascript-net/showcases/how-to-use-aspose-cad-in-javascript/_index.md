---
title: Jak používat Aspose.CAD v JavaScriptu
type: docs
description: "použijte Aspose.CAD v JavaScriptu."
weight: 73
url: /cs/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Předpoklady
- Visual Code + Live Server
- Node.js

## Převod obrazu dgn na png a zobrazení v prohlížeči

V tomto příkladu vytvoříte jednoduchý konverzní program, který převede výkres a uloží ho jako obrázek.

## Vytváření JavaScriptu

1. Vytvořte package.json s aspose-cad závislostmi
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
1. Vytvořte index.html
{{< highlight plain >}}
<!DOCTYPE html>
Otevřete konzoli (Ctrl+Shift+I), abyste viděli výstup.

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

1. Nainstalujte balíčky pomocí příkazu npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Spusťte aplikaci s [Live Serverem](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) nebo yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Příklad provedení

1. Vyberte soubor.<br>
![Vyberte soubor](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Vyberte libovolný soubor DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Pokud je odpověď úspěšná, soubor bude zobrazen na obrazovce a nabídne možnost stáhnout ho.<br>
![Převod obrazu](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Viz také

- [Instalovat Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Instalovat Node.js](https://nodejs.org/en/)
