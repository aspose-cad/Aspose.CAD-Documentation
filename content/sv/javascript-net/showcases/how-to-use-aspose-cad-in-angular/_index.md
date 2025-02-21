---
title: Hur man använder Aspose.CAD i Angular
type: docs
description: "Använd Aspose.CAD i Angular."
weight: 71
url: /sv/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Förutsättningar
- Angular CLI
- Visual Code
- Node.js

## Konvertera dgn-bild till png och visa i webbläsaren

I det här exemplet skapar du ett enkelt konverteringsprogram som konverterar en ritning och sparar den som en bild.

## Skapa Angular-projektet

1. Säkerställ att du inte redan är i en Angular-arbetsytans katalog.
1. Starta en ny och ange sedan namnet på programmet eller använd andra program för att skapa ett projekt som Visual Code eller WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Installera Aspose.CAD från npm-paketet
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Öppna filen angular.json och lägg till en post i skriptfältet, detta skript börjar laddas med projektet, det är nödvändigt för att börja bearbeta filerna
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. I app.component.html, skapa en input typ fil och img-taggar för att ladda och visa ritningen
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. I app.component.ts, beskriver vi processen för att starta hjälpprocesserna, bearbeta och spara bilden
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//måste starta dotnet-processen
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
    console.log("aspose-cad WASM laddas...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM har laddats");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Ladda bild
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //spara bild som png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //skapa src för konverterad bild
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //ladda ner png-bild
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
1. Starta applikationen
{{< highlight plain >}}
npm start
//eller
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Kommando ng serve:

- Bygger applikationen
- Startar utvecklingsservern
- Övervakar källfilerna
- Bygger om applikationen när du gör ändringar

Flaggan --open öppnar en webbläsare till http://localhost:4200.
{{% /alert %}}

## Exempel på körning

1. Välj fil.<br>
![Välj fil](/_assets/javascript-net/angular/choose-file.png)<br>
1. Välj valfri DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil.
1. Om svaret är framgångsrikt, kommer filen att visas på skärmen och erbjuda att ladda ner den.<br>
![Konvertera bild](/_assets/javascript-net/angular/convert-image.png)<br>

## Se Även

- [Installera Angular CLI](https://angular.io/guide/setup-local/)
- [Installera Visual Code](https://code.visualstudio.com/)
- [Installera Node.js](https://nodejs.org/en/)
