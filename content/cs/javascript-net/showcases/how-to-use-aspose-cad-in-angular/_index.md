---
title: Jak používat Aspose.CAD v Angularu
type: docs
description: "Použití Aspose.CAD v Angularu."
weight: 71
url: /cs/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Prerekvizity
- Angular CLI
- Visual Code
- Node.js

## Převod obrázku dgn na png a zobrazení v prohlížeči

V tomto příkladu vytvoříte jednoduchý program pro konverzi kresby a uložení jejího zobrazení.

## Vytvoření Angular projektu

1. Ujistěte se, že nejste již v adresáři Angular workspace.
1. Vytvořte nový a poté zadejte název programu nebo použijte jiné programy k vytvoření projektu jako Visual Code nebo WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Nainstalujte Aspose.CAD z npm balíčku
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Otevřete soubor angular.json a přidejte položku do pole skript, tento skript se začne načítat spolu s projektem, je nutné pro zpracování souborů
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. V souboru app.component.html vytvořte vstupní typ souboru a značky img pro načtení a zobrazení kresby
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. V souboru app.component.ts popíšeme proces spuštění pomocných procesů, zpracování a uložení obrázku
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//je třeba spustit dotnet proces
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
    console.log("aspose-cad WASM se načítá...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM byl načten");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Načítání obrázku
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //uložení obrázku do png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //vytvoření src pro konvertovaný obrázek
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //stáhnout png obrázek
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
1. Spusťte aplikaci
{{< highlight plain >}}
npm start
//nebo
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Příkaz ng serve:

- Sestaví aplikaci
- Spustí vývojový server
- Sleduje zdrojové soubory
- Při provedení změn znovu vytvoří aplikaci

Pomocí příznaku --open se otevře prohlížeč na adrese http://localhost:4200.
{{% /alert %}}

## Příklad provedení

1. Vyberte soubor.<br>
![Vyberte soubor](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. Vyberte jakýkoliv soubor DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Pokud je odpověď úspěšná, soubor bude zobrazen na obrazovce a nabídne možnost jeho stažení.<br>
![Konvertovat obrázek](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## Viz také

- [Instalace Angular CLI](https://angular.io/guide/setup-local/)
- [Instalace Visual Code](https://code.visualstudio.com/)
- [Instalace Node.js](https://nodejs.org/cs/)
