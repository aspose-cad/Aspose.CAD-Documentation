---
title: Hogyan használjuk az Aspose.CAD-ot Angularban
type: docs
description: "Használja az Aspose.CAD-ot Angularban."
weight: 71
url: /hu/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Előfeltételek
- Angular CLI
- Visual Code
- Node.js

## DGN kép átkonvertálása PNG-re és megjelenítése a böngészőben

Ebben a példában egy egyszerű konvertáló programot készít, amely átkonvertál egy rajzot és elmenti azt képként.

## Az Angular Projekt Létrehozása

1. Győződjön meg arról, hogy nem egy Angular munkaterületi könyvtárban van.
1. Indítson egy új projektet a program nevével, vagy használjon más programokat, mint a Visual Code vagy WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Telepítse az Aspose.CAD-ot az npm csomagból
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Nyissa meg az angular.json fájlt és adjon hozzá egy bejegyzést a script mezőhöz, ez a script a projekttel együtt kezdődik, szükséges a fájlok feldolgozásának elindításához
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. Az app.component.html fájlban hozzon létre egy fájl típusú bemeneti mezőt és img tageket a rajz betöltéséhez és megjelenítéséhez
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. Az app.component.ts fájlban leírjuk a segédprogramok indításának, a feldolgozásnak és a kép mentésének folyamatát
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

// szükséges a dotnet folyamat elindítása
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
    console.log("aspose-cad WASM töltése...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM betöltődött");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); // Kép betöltése
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); // Kép mentése png-be

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      // forrás létrehozása a konvertált képhez
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      // png kép letöltése
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
1. Alkalmazás indítása
{{< highlight plain >}}
npm start
//vagy
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
A ng serve parancs:

- Létrehozza az alkalmazást
- Elindítja a fejlesztői szervert
- Figyeli a forrásfájlokat
- Újraépíti az alkalmazást a módosítások során

A --open kapcsoló megnyit egy böngészőt a http://localhost:4200 címen.
{{% /alert %}}

## Végrehajtási példa

1. Válassza ki a fájlt.<br>
![Fájl kiválasztása](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. Válasszon ki bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Ha a válasz sikeres, a fájl megjelenik a képernyőn és letöltési lehetőséget kínál.<br>
![Kép átkonvertálása](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## További információk

- [Angular CLI telepítése](https://angular.io/guide/setup-local/)
- [Visual Code telepítése](https://code.visualstudio.com/)
- [Node.js telepítése](https://nodejs.org/en/)
