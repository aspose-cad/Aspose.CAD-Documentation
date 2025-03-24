---
title: Як використовувати Aspose.CAD в Angular
type: docs
description: "Використовуйте Aspose.CAD в Angular."
weight: 71
url: /uk/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Передумови
- Angular CLI
- Visual Code
- Node.js

## Перетворення зображення dgn у png та відображення в браузері

У цьому прикладі ви створюєте просту програму конвертації, яка перетворює малюнок і зберігає його як зображення.

## Створення проекту Angular

1. Переконайтеся, що ви не знаходитесь у директорії робочого простору Angular.
1. Створіть новий і введіть назву програми або використовуйте інші програми для створення проекту, такі як Visual Code або WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Встановіть Aspose.CAD з npm пакету
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Відкрийте файл angular.json і додайте запис у поле скриптів, цей скрипт починає завантаження з проектом, він необхідний для початку обробки файлів
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. У app.component.html створіть тег input типу file та теги img для завантаження та відображення малюнка
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. У app.component.ts ми описуємо процес запуску допоміжних процесів, обробки та збереження зображення
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//необхідно запустити процес dotnet
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
    console.log("aspose-cad WASM завантажується...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM було завантажено");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Завантажити зображення
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //зберегти зображення у форматі png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //створити src для конвертованого зображення
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //завантажити зображення png
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
1. Запустіть застосунок
{{< highlight plain >}}
npm start
//або
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Команда ng serve:

- Будує застосунок
- Запускає сервер розробки
- Слідкує за вихідними файлами
- Збирає застосунок заново, коли ви вносите зміни

Прапор --open відкриває браузер на http://localhost:4200.
{{% /alert %}}

## Приклад виконання

1. Виберіть файл.<br>
![Виберіть файл](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Якщо відповідь успішна, файл буде відображено на екрані і запропонує його завантажити.<br>
![Конвертуйте зображення](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## Дивіться також

- [Встановіть Angular CLI](https://angular.io/guide/setup-local/)
- [Встановіть Visual Code](https://code.visualstudio.com/)
- [Встановіть Node.js](https://nodejs.org/en/)
