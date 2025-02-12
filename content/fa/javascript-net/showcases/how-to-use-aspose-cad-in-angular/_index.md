---
title: نحوه استفاده از Aspose.CAD در Angular
type: docs
description: "استفاده از Aspose.CAD در Angular."
weight: 71
url: /fa/javascript-net/how-to-use-aspose-cad-in-angular
---

## ملزومات
- Angular CLI
- Visual Code
- Node.js

## تبدیل تصویر dgn به png و نمایش در مرورگر

در این مثال، شما یک برنامه تبدیل ساده ایجاد می‌کنید که یک نقاشی را تبدیل کرده و آن را به عنوان یک تصویر ذخیره می‌کند.

## ایجاد پروژه Angular

1. اطمینان حاصل کنید که در یک دایرکتوری کارفضای Angular نیستید.
1. یکی جدید شروع کنید و سپس نام برنامه را وارد کنید یا از برنامه‌های دیگر مانند Visual Code یا WebStorm برای ایجاد یک پروژه استفاده کنید:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Aspose.CAD را از بسته npm نصب کنید
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. فایل angular.json را باز کرده و یک ورودی در فیلد script اضافه کنید، این اسکریپت به محض بارگذاری با پروژه شروع به کار می‌کند و برای پردازش فایل‌ها لازم است
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. در app.component.html، یک input از نوع فایل و تگ‌های img برای بارگذاری و نمایش نقاشی ایجاد کنید
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. در app.component.ts، فرایند شروع helper processes، پردازش و ذخیره تصویر را توصیف می‌کنیم
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//نیاز به راه‌اندازی فرایند دات‌نت
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
    console.log("بارگذاری aspose-cad WASM...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM بارگذاری شده است");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //بارگذاری تصویر
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //ذخیره تصویر به png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //ایجاد منبع برای تصویر تبدیل شده
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //دانلود تصویر png
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
1. برنامه را شروع کنید
{{< highlight plain >}}
npm start
//یا
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
دستور ng serve:

- برنامه را می‌سازد
- سرور توسعه را آغاز می‌کند
- به بررسی فایل‌های منبع می‌پردازد
- برنامه را دوباره می‌سازد زمانی که تغییراتی ایجاد می‌شود

پرچم --open یک مرورگر را به http://localhost:4200 باز می‌کند.
{{% /alert %}}

## مثال اجرا

1. فایل را انتخاب کنید.<br>
![انتخاب فایل](/fa/_assets/choose-file.png)<br>
1. هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. اگر پاسخ موفقیت‌آمیز باشد، فایل در صفحه نمایش داده می‌شود و پیشنهاد می‌شود آن را دانلود کنید.<br>
![تبدیل تصویر](/fa/_assets/convert-image.png)<br>

## همچنین ببینید

- [نصب Angular CLI](https://angular.io/guide/setup-local/)
- [نصب Visual Code](https://code.visualstudio.com/)
- [نصب Node.js](https://nodejs.org/en/)
