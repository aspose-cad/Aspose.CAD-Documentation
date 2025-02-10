---
title: Как да използвате Aspose.CAD в Angular
type: docs
description: "Използвайте Aspose.CAD в Angular."
weight: 71
url: /bg/javascript-net/how-to-use-aspose-cad-in-angular
---

## Предварителни условия
- Angular CLI
- Visual Code
- Node.js

## Конвертиране на dgn изображение в png и показване в браузъра

В този пример създавате проста програма за конвертиране, която конвертира чертеж и го записва като изображение.

## Създаване на Angular проект

1. Убедете се, че не сте в директория на Angular работно пространство.
1. Започнете ново и след това задайте името на програмата или използвайте други програми за създаване на проект, като Visual Code или WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Инсталирайте Aspose.CAD от npm пакета
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Отворете файла angular.json и добавете запис в полето за скриптове, този скрипт започва да се зарежда с проекта, изисква се за стартиране на обработката на файловете
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. В app.component.html, създайте входен тип файл и img тагове за зареждане и показване на чертежа
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. В app.component.ts, описваме процеса на стартиране на помощните процеси, обработка и запазване на изображението
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//нужно е да стартирате dotnet процес
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
    console.log("aspose-cad WASM зареждане...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM е зареден");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Зареждане на изображение
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //запазване на изображение в png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //създаване на src за конвертирано изображение
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //изтегляне на png изображение
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
1. Стартирайте приложението
{{< highlight plain >}}
npm start
//или
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Командата ng serve:

- Създава приложението
- Стартира сървъра за разработка
- Следи изходните файлове
- Пресъздава приложението, докато правите промени

Флагът --open отваря браузър на http://localhost:4200.
{{% /alert %}}

## Пример за изпълнение

1. Изберете файл.<br>
![Изберете файл](/_assets/choose-file.png)<br>
1. Изберете всякакъв DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG файл.
1. Ако отговорът е успешен, файлът ще бъде показан на екрана и ще предложи да го изтеглите.<br>
![Конвертиране на изображение](/_assets/convert-image.png)<br>

## Вижте също

- [Инсталирайте Angular CLI](https://angular.io/guide/setup-local/)
- [Инсталирайте Visual Code](https://code.visualstudio.com/)
- [Инсталирайте Node.js](https://nodejs.org/en/)
