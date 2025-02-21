---
title: Jak używać Aspose.CAD w Angular
type: docs
description: "Użyj Aspose.CAD w Angular."
weight: 71
url: /pl/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Wymagania wstępne
- Angular CLI
- Visual Code
- Node.js

## Konwersja obrazu dgn na png i wyświetlenie w przeglądarce

W tym przykładzie tworzysz prosty program konwertujący, który przekształca rysunek i zapisuje go jako obraz.

## Tworzenie projektu Angular

1. Upewnij się, że nie znajdujesz się już w katalogu roboczym Angular.
1. Rozpocznij nowy i podaj nazwę programu lub użyj innych programów do stworzenia projektu, takich jak Visual Code lub WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Zainstaluj Aspose.CAD z pakietu npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Otwórz plik angular.json i dodaj wpis w polu skryptów, ten skrypt rozpoczyna ładowanie z projektem, jest wymagany do rozpoczęcia przetwarzania plików
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. W pliku app.component.html utwórz tagi input typu file oraz img do ładowania i wyświetlania rysunku
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. W pliku app.component.ts opisujemy proces uruchamiania procesów pomocniczych, przetwarzania i zapisywania obrazu
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//musisz uruchomić proces dotnet
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
    console.log("ładowanie aspose-cad WASM...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM zostało załadowane");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Załaduj obraz
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //zapisz obraz jako png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //utwórz źródło dla przekonwertowanego obrazu
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //pobierz obraz png
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
1. Uruchom aplikację
{{< highlight plain >}}
npm start
//lub
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Polecenie ng serve:

- Buduje aplikację
- Uruchamia serwer deweloperski
- Obserwuje pliki źródłowe
- Ponownie buduje aplikację przy każdej zmianie

Flaga --open otwiera przeglądarkę na http://localhost:4200.
{{% /alert %}}

## Przykład wykonania

1. Wybierz plik.<br>
![Wybierz plik](/_assets/javascript-net/angular/choose-file.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Jeśli odpowiedź będzie pomyślna, plik zostanie wyświetlony na ekranie i zaoferuje możliwość jego pobrania.<br>
![Przekonwertuj obraz](/_assets/javascript-net/angular/convert-image.png)<br>

## Zobacz także

- [Zainstaluj Angular CLI](https://angular.io/guide/setup-local/)
- [Zainstaluj Visual Code](https://code.visualstudio.com/)
- [Zainstaluj Node.js](https://nodejs.org/en/)
