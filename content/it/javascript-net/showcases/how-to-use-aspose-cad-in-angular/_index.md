---
title: Come usare Aspose.CAD in Angular
type: docs
description: "Usa Aspose.CAD in Angular."
weight: 71
url: /it/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Prerequisiti
- Angular CLI
- Visual Code
- Node.js

## Convertire un'immagine dgn in png e visualizzarla nel browser

In questo esempio, crei un semplice programma di conversione che converte un disegno e lo salva come immagine.

## Creazione del Progetto Angular

1. Assicurati di non essere già nella directory di un workspace Angular.
1. Inizia un nuovo progetto e poi il nome del programma o usa altri programmi per creare un progetto come Visual Code o WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Installa Aspose.CAD dal pacchetto npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Apri il file angular.json e aggiungi una voce nel campo script, questo script inizia a caricarsi con il progetto, è necessario per iniziare a elaborare i file
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. In app.component.html, crea un tag input di tipo file e img per caricare e visualizzare il disegno
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. In app.component.ts, descriviamo il processo di avvio dei processi di supporto, elaborazione e salvataggio dell'immagine
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//necessario avviare il processo dotnet
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
    console.log("aspose-cad WASM caricamento...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM è stato caricato");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Carica immagine
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //salva immagine in png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //crea src per immagine convertita
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //scarica immagine png
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
1. Avvia l'applicazione
{{< highlight plain >}}
npm start
//oppure
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Il comando ng serve:

- Compila l'applicazione
- Avvia il server di sviluppo
- Monitora i file sorgente
- Ricompila l'applicazione mentre apporti modifiche

L'opzione --open apre un browser su http://localhost:4200.
{{% /alert %}}

## Esempio di esecuzione

1. Scegli un file.<br>
![Scegli file](/_assets/javascript-net/angular/choose-file.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se la risposta è positiva, il file verrà visualizzato sullo schermo e verrà offerto di scaricarlo.<br>
![Converti immagine](/_assets/javascript-net/angular/convert-image.png)<br>

## Vedi Anche

- [Installa Angular CLI](https://angular.io/guide/setup-local/)
- [Installa Visual Code](https://code.visualstudio.com/)
- [Installa Node.js](https://nodejs.org/en/)
