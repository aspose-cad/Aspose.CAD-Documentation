---
title: วิธีการใช้ Aspose.CAD ใน Angular
type: docs
description: "ใช้ Aspose.CAD ใน Angular."
weight: 71
url: /th/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## ข้อกำหนดเบื้องต้น
- Angular CLI
- Visual Code
- Node.js

## แปลงภาพ dgn เป็น png และแสดงในเบราว์เซอร์

ในตัวอย่างนี้ คุณจะสร้างโปรแกรมการแปลงง่ายๆ ที่แปลงภาพวาดและบันทึกเป็นภาพ

## การสร้างโปรเจกต์ Angular

1. ตรวจสอบให้แน่ใจว่าคุณไม่ได้อยู่ในไดเรกทอรีที่เป็นพื้นที่ทำงานของ Angular
1. สร้างใหม่และตั้งชื่อโปรแกรม หรือใช้โปรแกรมอื่นๆ เช่น Visual Code หรือ WebStorm เพื่อสร้างโปรเจกต์:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. ติดตั้ง Aspose.CAD จาก npm package
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. เปิดไฟล์ angular.json และเพิ่มรายการในฟิลด์สคริปต์ สคริปต์นี้เริ่มโหลดพร้อมโปรเจกต์ จะต้องใช้เพื่อเริ่มการประมวลผลไฟล์
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. ใน app.component.html สร้าง input type file และ img tags เพื่อโหลดและแสดงภาพวาด
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. ใน app.component.ts เราจะอธิบายกระบวนการเริ่มต้นกระบวนการช่วยเหลือ การประมวลผล และการบันทึกภาพ
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//จำเป็นต้องบูตกระบวนการ dotnet
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
    console.log("aspose-cad WASM กำลังโหลด...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM ได้ถูกโหลด");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //โหลดภาพ
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //บันทึกภาพเป็น png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //สร้าง src สำหรับภาพที่แปลง
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //ดาวน์โหลดภาพ png
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
1. เริ่มแอปพลิเคชัน
{{< highlight plain >}}
npm start
//หรือ
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
คำสั่ง ng serve:

- สร้างแอปพลิเคชัน
- เริ่มเซิร์ฟเวอร์พัฒนา
- ตรวจสอบไฟล์แหล่งที่มา
- สร้างแอปพลิเคชันใหม่เมื่อคุณทำการเปลี่ยนแปลง

ธง --open จะเปิดเบราว์เซอร์ไปที่ http://localhost:4200.
{{% /alert %}}

## ตัวอย่างการดำเนินการ

1. เลือกไฟล์.<br>
![เลือกไฟล์](/_assets/javascript-net/angular/choose-file.png)<br>
1. เลือกไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG อะไรก็ได้
1. หากคำตอบสำเร็จ ไฟล์จะแสดงบนหน้าจอและจะเสนอให้ดาวน์โหลด<br>
![แปลงภาพ](/_assets/javascript-net/angular/convert-image.png)<br>

## ดูเพิ่มเติม

- [ติดตั้ง Angular CLI](https://angular.io/guide/setup-local/)
- [ติดตั้ง Visual Code](https://code.visualstudio.com/)
- [ติดตั้ง Node.js](https://nodejs.org/en/)
