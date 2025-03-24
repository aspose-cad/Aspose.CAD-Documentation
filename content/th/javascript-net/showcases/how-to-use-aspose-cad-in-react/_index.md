---
title: วิธีการใช้ Aspose.CAD ใน React
type: docs
description: "ใช้ Aspose.CAD ใน React"
weight: 75
url: /th/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## ข้อกำหนดเบื้องต้น
- Visual Code
- Node.js

## แปลงภาพ dgn เป็น png และแสดงในเบราว์เซอร์

ในตัวอย่างนี้ คุณจะสร้างโปรแกรมการแปลงที่ง่ายซึ่งจะทำการแปลงภาพวาดและบันทึกเป็นภาพ

## การสร้างโปรเจกต์ React

1. ตรวจสอบให้แน่ใจว่าคุณไม่ได้อยู่ในไดเรกทอรีพื้นที่ทำงานของ React แล้ว
1. เริ่มใหม่และจากนั้นชื่อโปรแกรมหรือใช้โปรแกรมอื่นเพื่อสร้างโปรเจกต์เช่น Visual Code หรือ WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. ติดตั้ง Aspose.CAD จากแพ็คเกจ npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. สร้างแท็ก input type file และ img เพื่อโหลดและแสดงภาพวาด
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. ใน App.tsx เราจะอธิบายกระบวนการเริ่มต้นกระบวนการช่วย ประมวลผลและบันทึกภาพ
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="converted" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("กำลังโหลด WASM...");
  await boot();
  console.log("โหลด WASM เสร็จสมบูรณ์");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // โหลด
          var file = Image.load(array);

          // บันทึก
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. เริ่มแอปพลิเคชัน
{{< highlight plain >}}
npm start
{{< /highlight >}}

## ตัวอย่างการดำเนินการ

1. เลือกไฟล์.<br>
![เลือกไฟล์](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. เลือกรูปแบบไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG ใดก็ได้
1. หากคำตอบสำเร็จ ไฟล์จะปรากฏบนหน้าจอและจะมีการเสนอให้ดาวน์โหลด.<br>
![แปลงภาพ](/cad/_assets/javascript-net/react/convert-image.png)<br>

## ดูเพิ่มเติม

- [ติดตั้ง Visual Code](https://code.visualstudio.com/)
- [ติดตั้ง Node.js](https://nodejs.org/en/)
