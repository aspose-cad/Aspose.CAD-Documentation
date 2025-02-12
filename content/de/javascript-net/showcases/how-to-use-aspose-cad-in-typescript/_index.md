---
title: Wie man Aspose.CAD in TypeScript verwendet
type: docs
description: "Verwenden Sie Aspose.CAD in TypeScript."
weight: 74
url: /de/javascript-net/how-to-use-aspose-cad-in-typescript
---


## Voraussetzungen
- Visual Studio Code + Live Server
- Node.js

## Konvertieren Sie eine DGN-Bilddatei in PNG und zeigen Sie sie im Browser an

In diesem Beispiel erstellen Sie ein einfaches Konvertierungsprogramm, das eine Zeichnung konvertiert und als Bild speichert.

## Erstellen des JavaScript-Codes

1. Erstellen Sie eine package.json-Datei im Projektordner
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
2. Ändern Sie die package.json-Datei und fügen Sie Abhängigkeiten von Aspose.CAD hinzu
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
3. Erstellen Sie die Datei index.ts
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
4. Verwenden Sie den npm-Befehl, um die Datei index.js zu erstellen
{{< highlight plain >}}
tsc
{{< /highlight >}}
5. Erstellen Sie die Datei index.html
{{< highlight plain >}}
<!DOCTYPE html>
Öffnen Sie die Konsole (Strg+Shift+I), um die Ausgabe zu sehen.

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

6. Installieren Sie die Pakete mithilfe des npm-Befehls
{{< highlight plain >}}
npm install
{{< /highlight >}}
7. Starten Sie die Anwendung mit [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) oder yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Ausführungsbeispiel

1. Wählen Sie eine Datei aus.<br>
![Datei auswählen](/_assets/javascript-net/typescript/choose-file.png)<br>
2. Wählen Sie eine DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-Datei aus.
3. Wenn die Aktion erfolgreich ist, wird die Datei auf dem Bildschirm angezeigt und es wird angeboten, sie herunterzuladen.<br>
![Bild konvertieren](/_assets/javascript-net/typescript/convert-image.png)<br>

## Siehe auch

- [Visual Studio Code installieren](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js installieren](https://nodejs.org/en/)
