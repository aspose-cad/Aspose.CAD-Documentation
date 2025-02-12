---
title: Πώς να χρησιμοποιήσετε το Aspose.CAD σε React
type: docs
description: "Χρησιμοποιήστε το Aspose.CAD σε React"
weight: 75
url: /el/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Προαπαιτούμενα
- Visual Code
- Node.js

## Μετατροπή εικόνας dgn σε png και εμφάνιση στον browser

Σε αυτό το παράδειγμα, δημιουργείτε ένα απλό πρόγραμμα μετατροπής που μετατρέπει μια σχεδίαση και την αποθηκεύει ως εικόνα.

## Δημιουργία έργου React

1. Βεβαιωθείτε ότι δεν βρίσκεστε ήδη σε ένα κατάλογο εργασίας React.
1. Ξεκινήστε ένα νέο και στη συνέχεια το όνομα του προγράμματος ή χρησιμοποιήστε άλλα προγράμματα για να δημιουργήσετε ένα έργο όπως το Visual Code ή το WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Εγκαταστήστε το Aspose.CAD από το npm package
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Δημιουργήστε μια ετικέτα τύπου input file και img για να φορτώσετε και να εμφανίσετε τη σχεδίαση
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. Στο App.tsx, περιγράφουμε τη διαδικασία εκκίνησης των βοηθητικών διαδικασιών, επεξεργασίας και αποθήκευσης της εικόνας
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="converted" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("φορτώνοντας WASM...");
  await boot();
  console.log("φορτώθηκε WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // ΦΟΡΤΩΣΗ
          var file = Image.load(array);

          // ΑΠΟΘΗΚΕΥΣΗ
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. Ξεκινήστε την εφαρμογή
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Παράδειγμα εκτέλεσης

1. Επιλέξτε αρχείο.<br>
![Choose file](/_assets/javascript-net/react/choose-file.png)<br>
1. Επιλέξτε οποιοδήποτε αρχείο DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Αν η απάντηση είναι επιτυχής, το αρχείο θα εμφανιστεί στην οθόνη και θα προσφερθεί να το κατεβάσετε.<br>
![Convert image](/_assets/javascript-net/react/convert-image.png)<br>

## Δείτε επίσης

- [Εγκαταστήστε το Visual Code](https://code.visualstudio.com/)
- [Εγκαταστήστε το Node.js](https://nodejs.org/en/)
