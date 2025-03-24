---
title: Πώς να χρησιμοποιήσετε το Aspose.CAD στο JavaScript
type: docs
description: "χρησιμοποιήστε το Aspose.CAD στο JavaScript."
weight: 73
url: /el/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Προαπαιτούμενα
- Visual Code + Live Server
- Node.js

## Μετατροπή εικόνας dgn σε png και εμφάνιση στο πρόγραμμα περιήγησης

Σε αυτό το παράδειγμα, δημιουργείτε ένα απλό πρόγραμμα μετατροπής που μετατρέπει ένα σχέδιο και το αποθηκεύει ως εικόνα.

## Δημιουργία του JavaScript

1. Δημιουργήστε το package.json με τις εξαρτήσεις του aspose-cad
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
1. Δημιουργήστε το index.html
{{< highlight plain >}}
<!DOCTYPE html>
Ανοίξτε την κονσόλα (Ctrl+Shift+I) για να δείτε την έξοδο.

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

1. Εγκαταστήστε τα πακέτα χρησιμοποιώντας την εντολή npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Ξεκινήστε την εφαρμογή με [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) ή yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Παράδειγμα εκτέλεσης

1. Επιλέξτε αρχείο.<br>
![Επιλέξτε αρχείο](/cad/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Επιλέξτε οποιοδήποτε DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG αρχείο.
1. Εάν η απάντηση είναι επιτυχής, το αρχείο θα εμφανιστεί στην οθόνη και θα προσφέρει να το κατεβάσετε.<br>
![Μετατροπή εικόνας](/cad/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Δείτε επίσης

- [Εγκαταστήστε το Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Εγκαταστήστε το Node.js](https://nodejs.org/en/)
