---
title: วิธีการใช้ Aspose.CAD ใน Vue
type: docs
description: "ใช้ Aspose.CAD ใน Vue."
weight: 75
url: /th/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## ข้อกำหนดเบื้องต้น
- Vue CLI
- Visual Code
- Node.js

## แปลงภาพ dgn เป็น png และแสดงในเบราว์เซอร์

ในตัวอย่างนี้ คุณจะสร้างโปรแกรมการแปลงง่ายๆ ที่แปลงภาพวาดและบันทึกเป็นภาพ

## การสร้างโปรเจกต์ Vue

1. ตรวจสอบให้แน่ใจว่าคุณไม่ได้อยู่ในไดเรกทอรีพื้นที่ทำงาน Vue อยู่แล้ว
1. เริ่มโปรเจกต์ใหม่และตั้งชื่อโปรแกรมหรือใช้โปรแกรมอื่นๆ ในการสร้างโปรเจกต์ เช่น Visual Code หรือ WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. ติดตั้ง Aspose.CAD จาก npm package
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. สร้างแท็กไฟล์ประเภท input และ img เพื่อโหลดและแสดงภาพวาด
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. ใน App.vue เราจะอธิบายขั้นตอนในการเริ่มต้นกระบวนการช่วยเหลือ การประมวลผลและแสดงภาพ
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //จำเป็นสำหรับเริ่มต้นกระบวนการประกอบ
    let recaptchaScript = document.createElement('script')
    recaptchaScript.setAttribute('src', '/node_modules/aspose-cad/dotnet.js')
    document.head.appendChild(recaptchaScript)

    let dotnet;
  },
  mounted() {
    window.addEventListener('load', this.onWindowLoad)
  },
  methods: {
    async onWindowLoad() {
      
      console.log("กำลังโหลด WASM...");
      await dotnet.boot();
      console.log("โหลด WASM เสร็จสมบูรณ์");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // โหลด
              let file = Image.load(array);
              console.log(file);

              // บันทึก
              let exportedFilePromise = Image.save(array, new PngOptions());
              exportedFilePromise.then(exportedFile => {
                console.log(exportedFile);

                let urlCreator = window.URL || window.webkitURL;
                let blob = new Blob([exportedFile], { type: 'application/octet-stream' });
                let imageUrl = urlCreator.createObjectURL(blob);
                document.querySelector("#image").src = imageUrl;
              });
            }

            reader.readAsArrayBuffer(this.files[0]);
          },
          false);
    },
  },
}
</script>

<template>
  <header>
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>ตัวอย่าง aspose.cad สำหรับ Vue.</p>
  </header>

  <main>
    <input id="file" type="file">
    <br/>
    <img id="image" />
  </main>
</template>

<style scoped>
header {
  line-height: 1.5;
}
main{
  text-align: center;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }


  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
{{< /highlight >}}
1. เริ่มแอปพลิเคชัน
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## ตัวอย่างการทำงาน

1. เลือกไฟล์.<br>
![เลือกไฟล์](/_assets/javascript-net/vue/choose-file.png)<br>
1. เลือกไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG ใด ๆ
1. หากการตอบกลับสำเร็จ ไฟล์จะแสดงบนหน้าจอและเสนอให้ดาวน์โหลด<br>
![แปลงภาพ](/_assets/javascript-net/vue/convert-image.png)<br>

## ดูเพิ่มเติม

- [ติดตั้ง Visual Code](https://code.visualstudio.com/)
- [ติดตั้ง Node.js](https://nodejs.org/en/)
