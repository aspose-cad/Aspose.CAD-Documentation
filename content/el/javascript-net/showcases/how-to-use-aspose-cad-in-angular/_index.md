---
title: Πώς να χρησιμοποιήσετε το Aspose.CAD στο Angular
type: docs
description: "Χρησιμοποιήστε το Aspose.CAD στο Angular."
weight: 71
url: /el/javascript-net/how-to-use-aspose-cad-in-angular
---

## Προαπαιτούμενα
- Angular CLI
- Visual Code
- Node.js

## Μετατροπή εικόνας dgn σε png και εμφάνιση στο πρόγραμμα περιήγησης

Σε αυτό το παράδειγμα, δημιουργείτε ένα απλό πρόγραμμα μετατροπής που μετατρέπει ένα σχέδιο και το αποθηκεύει ως εικόνα.

## Δημιουργία του έργου Angular

1. Βεβαιωθείτε ότι δεν βρίσκεστε ήδη σε έναν κατάλογο του Angular workspace.
1. Ξεκινήστε ένα νέο και έπειτα το όνομα του προγράμματος ή χρησιμοποιήστε άλλα προγράμματα για να δημιουργήσετε ένα έργο όπως το Visual Code ή το WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Εγκαταστήστε το Aspose.CAD από το npm package
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Ανοίξτε το αρχείο angular.json και προσθέστε μια καταχώρηση στο πεδίο script, αυτό το script ξεκινά τη φόρτωση με το έργο, είναι απαραίτητο για να ξεκινήσει η επεξεργασία των αρχείων
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. Στο app.component.html, δημιουργήστε ένα input τύπου αρχείου και ετικέτες img για να φορτώσετε και να εμφανίσετε το σχέδιο
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. Στο app.component.ts, περιγράφουμε τη διαδικασία εκκίνησης των βοηθητικών διεργασιών, επεξεργασίας και αποθήκευσης της εικόνας
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//πρέπει να ξεκινήσει η διαδικασία dotnet
declare let dotnet: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular-example';

  imageUrl: any;
  imgFile: Uint8Array | null | undefined;

  constructor(private sanitizer: DomSanitizer) {
  }

  // @ts-ignore
  async ngOnInit() {
    console.log("aspose-cad WASM φόρτωσης...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM έχει φορτωθεί");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Φόρτωση εικόνας
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //Αποθήκευση εικόνας ως png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //δημιουργία src για τη μετατραπείσα εικόνα
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //κατέβασμα εικόνας png
      let url = window.URL.createObjectURL(blob);
      let a = document.createElement('a');
      document.body.appendChild(a);
      a.setAttribute('style', 'display: none');
      a.href = url;
      a.download = "file.png";
      a.click();
      window.URL.revokeObjectURL(url);
      a.remove();

    });
  }
}
{{< /highlight >}}
1. Ξεκινήστε την εφαρμογή
{{< highlight plain >}}
npm start
//ή
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Η εντολή ng serve:

- Δημιουργεί την εφαρμογή
- Ξεκινά τον αναπτυξιακό διακομιστή
- Παρακολουθεί τα πηγαία αρχεία
- Ξαναχτίζει την εφαρμογή καθώς κάνετε αλλαγές

Η ένδειξη --open ανοίγει ένα πρόγραμμα περιήγησης στο http://localhost:4200.
{{% /alert %}}

## Παράδειγμα εκτέλεσης

1. Επιλέξτε αρχείο.<br>
![Επιλογή αρχείου](/_assets/javascript-net/angular/choose-file.png)<br>
1. Επιλέξτε οποιοδήποτε αρχείο DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Εάν η απάντηση είναι επιτυχής, το αρχείο θα εμφανιστεί στην οθόνη και θα προσφερθεί για κατέβασμα.<br>
![Μετατροπή εικόνας](/_assets/javascript-net/angular/convert-image.png)<br>

## Δείτε επίσης

- [Εγκατάσταση Angular CLI](https://angular.io/guide/setup-local/)
- [Εγκατάσταση Visual Code](https://code.visualstudio.com/)
- [Εγκατάσταση Node.js](https://nodejs.org/en/)
