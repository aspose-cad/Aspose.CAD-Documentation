---
title: Hoe Aspose.CAD in Angular te gebruiken
type: docs
description: "Gebruik Aspose.CAD in Angular."
weight: 71
url: /nl/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Vereisten
- Angular CLI
- Visual Code
- Node.js

## Converteer dgn-beeld naar png en toon in de browser

In dit voorbeeld maak je een eenvoudig conversieprogramma dat een tekening omzet en deze opslaat als een afbeelding.

## Het Angular-project aanmaken

1. Zorg ervoor dat je je nog niet in een Angular-werkruimte directory bevindt.
1. Start een nieuwe en geef dan de naam van het programma of gebruik andere programma's om een project te creëren, zoals Visual Code of WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Installeer Aspose.CAD vanuit het npm-pakket
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Open het angular.json bestand en voeg een invoer toe in het scriptveld, dit script begint met laden met het project en is vereist om de bestanden te verwerken
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. In app.component.html, maak een invoertype bestand en img-tags aan om de tekening te laden en weer te geven
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. In app.component.ts beschrijven we het proces van het starten van de hulpprocessen, het verwerken en opslaan van de afbeelding
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//moet het dotnet-proces opstarten
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
    console.log("aspose-cad WASM wordt geladen...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM is geladen");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Laad afbeelding
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //sla afbeelding op als png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //maak src voor geconverteerde afbeelding
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //download png afbeelding
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
1. Start applicatie
{{< highlight plain >}}
npm start
//of
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
De ng serve-opdracht:

- Bouwt de applicatie
- Start de ontwikkelingsserver
- Bekijkt de bronbestanden
- Herbalen de applicatie terwijl je wijzigingen aanbrengt

De --open vlag opent een browser naar http://localhost:4200.
{{% /alert %}}

## Voorbeeld van uitvoering

1. Kies bestand.<br>
![Kies bestand](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. Selecteer een DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-bestand.
1. Als het antwoord succesvol is, wordt het bestand op het scherm weergegeven en wordt aangeboden om het te downloaden.<br>
![Converteer afbeelding](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## Zie ook

- [Installeer Angular CLI](https://angular.io/guide/setup-local/)
- [Installeer Visual Code](https://code.visualstudio.com/)
- [Installeer Node.js](https://nodejs.org/en/)
