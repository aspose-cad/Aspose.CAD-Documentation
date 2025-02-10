---
title: كيفية استخدام Aspose.CAD في Angular
type: docs
description: "استخدام Aspose.CAD في Angular."
weight: 71
url: /ar/javascript-net/how-to-use-aspose-cad-in-angular
---

## المتطلبات الأساسية
- Angular CLI
- فيجوال كود
- Node.js

## تحويل صورة dgn إلى png وعرضها في المتصفح

في هذا المثال، تقوم بإنشاء برنامج تحويل بسيط يقوم بتحويل رسم وحفظه كصورة.

## إنشاء مشروع Angular

1. تأكد أنك لست بالفعل في دليل مساحة عمل Angular.
1. ابدأ واحدة جديدة ثم اكتب اسم البرنامج أو استخدم برامج أخرى لإنشاء مشروع مثل فيجوال كود أو WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. تثبيت Aspose.CAD من حزمة npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. افتح ملف angular.json وأضف إدخالًا في حقل السكريبت، هذا السكريبت يبدأ في التحميل مع المشروع، وهو مطلوب لبدء معالجة الملفات
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. في app.component.html، أنشئ عنصر إدخال من نوع ملف وعلامات img لتحميل وعرض الرسم
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. في app.component.ts، نصف عملية بدء العمليات المساعدة، ومعالجة الصورة وحفظها
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//تحتاج إلى تشغيل عملية الدوت نت
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
    console.log("تحميل aspose-cad WASM...");
    await dotnet.boot().then((ex: any) => {
      console.log("تم تحميل aspose-cad WASM");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //تحميل الصورة
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //حفظ الصورة كـ png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //إنشاء src لصورة محولة
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //تحميل صورة png
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
1. بدء التطبيق
{{< highlight plain >}}
npm start
//أو
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
أمر ng serve:

- يقوم ببناء التطبيق
- يبدأ خادم التطوير
- يراقب ملفات المصدر
- يعيد بناء التطبيق أثناء إجراء التغييرات

علامة --open تفتح متصفحًا على http://localhost:4200.
{{% /alert %}}

## مثال على التنفيذ

1. اختر ملفًا.<br>
![اختر ملف](/_assets/choose-file.png)<br>
1. اختر أي ملف DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG.
1. إذا كانت الإجابة ناجحة، سيتم عرض الملف على الشاشة وسيتم تقديم عرض لتحميله.<br>
![تحويل الصورة](/_assets/convert-image.png)<br>

## انظر أيضًا

- [تثبيت Angular CLI](https://angular.io/guide/setup-local/)
- [تثبيت فيجوال كود](https://code.visualstudio.com/)
- [تثبيت Node.js](https://nodejs.org/en/)
