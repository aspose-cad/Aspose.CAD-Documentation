---
title: Jak używać Aspose.CAD w JavaScript
type: docs
description: "użyj Aspose.CAD w JavaScript."
weight: 73
url: /pl/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Wymagania wstępne
- Visual Code + Live Server
- Node.js

## Konwersja obrazu dgn do png i wyświetlanie w przeglądarce

W tym przykładzie tworzysz prosty program konwertujący, który konwertuje rysunek i zapisuje go jako obraz.

## Tworzenie JavaScript

1. Utwórz plik package.json z zależnościami aspose-cad
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
1. Utwórz index.html
{{< highlight plain >}}
<!DOCTYPE html>
Otwórz konsolę (Ctrl+Shift+I), aby zobaczyć wynik.

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

1. Zainstaluj pakiety za pomocą polecenia npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Uruchom aplikację za pomocą [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) lub yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Przykład wykonania

1. Wybierz plik.<br>
![Wybierz plik](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Jeśli odpowiedź jest pomyślna, plik zostanie wyświetlony na ekranie i zostanie zaoferowane jego pobranie.<br>
![Konwertuj obraz](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Zobacz także

- [Zainstaluj Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Zainstaluj Node.js](https://nodejs.org/en/)
