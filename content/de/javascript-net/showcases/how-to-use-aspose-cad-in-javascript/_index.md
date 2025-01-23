---
title: Wie man Aspose.CAD in JavaScript verwendet
type: docs
description: "Aspose.CAD in JavaScript verwenden."
weight: 73
url: /de/javascript-net/wie-man-aspose-cad-in-javascript-ausfuhrt
---

## Voraussetzungen
- Visual Studio-Code + Live Server
- Node.js

## DGN-Bild in PNG konvertieren und im Browser anzeigen

In diesem Beispiel erstellen Sie ein einfaches Konvertierungsprogramm, das eine Zeichnung konvertiert und als Bild speichert.

## JavaScript erstellen

1. Erstellen Sie die package.json mit den aspose-cad-Abhängigkeiten
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
1. Index.html erstellen
{{< highlight plain >}}
<!DOCTYPE html>
Öffnen Sie die Konsole (Strg+Umschalt+I), um die Ausgabe zu sehen.

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

1. Installieren Sie die Pakete mit dem npm-Befehl
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Starten Sie die Anwendung mit [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) oder yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Ausführungsbeispiel

1. Datei auswählen.<br>
![Datei auswählen](choose-file.png)<br>
1. Wählen Sie eine beliebige DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-Datei aus.
1. Wenn die Antwort erfolgreich ist, wird die Datei auf dem Bildschirm angezeigt und es wird angeboten, sie herunterzuladen.<br>
![Bild konvertieren](convert-image.png)<br>

## Siehe auch

- [Visual Studio-Code installieren](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js installieren](https://nodejs.org/en/)
