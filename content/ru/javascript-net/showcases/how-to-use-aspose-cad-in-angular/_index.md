---
title: Как использовать Aspose.CAD в Angular
type: docs
description: "Используйте Aspose.CAD в Angular."
weight: 71
url: /ru/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Предварительные требования
- Angular CLI
- Visual Code
- Node.js

## Конвертация изображения dgn в png и отображение в браузере

В этом примере вы создаете простую программу конвертации, которая конвертирует чертеж и сохраняет его как изображение.

## Создание проекта Angular

1. Убедитесь, что вы еще не находитесь в каталоге рабочего пространства Angular.
1. Начните новый и затем укажите название программы или используйте другие программы для создания проекта, такие как Visual Code или WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Установите Aspose.CAD из npm пакета
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Откройте файл angular.json и добавьте запись в поле скриптов, этот скрипт начинает загружаться с проектом, он необходим для начала обработки файлов
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. В app.component.html создайте теги input с типом file и img для загрузки и отображения чертежа
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. В app.component.ts мы описываем процесс запуска вспомогательных процессов, обработки и сохранения изображения
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//нужно запустить процесс dotnet
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
    console.log("Загрузка aspose-cad WASM...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM загружен");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Загрузить изображение
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //сохранить изображение в png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //создать src для сконвертированного изображения
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //скачать изображение в формате png
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
1. Запустите приложение
{{< highlight plain >}}
npm start
//или
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Команда ng serve:

- Собирает приложение
- Запускает сервер разработки
- Наблюдает за исходными файлами
- Пересобирает приложение по мере внесения изменений

Флаг --open открывает браузер на http://localhost:4200.
{{% /alert %}}

## Пример выполнения

1. Выберите файл.<br>
![Выберите файл](/_assets/javascript-net/angular/choose-file.png)<br>
1. Выберите любой файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Если ответ успешный, файл будет отображен на экране и предложит его скачать.<br>
![Конвертировать изображение](/_assets/javascript-net/angular/convert-image.png)<br>

## Смотрите также

- [Установите Angular CLI](https://angular.io/guide/setup-local/)
- [Установите Visual Code](https://code.visualstudio.com/)
- [Установите Node.js](https://nodejs.org/en/)
