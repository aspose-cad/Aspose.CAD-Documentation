---
title: วิธีการใช้ Aspose.CAD ใน TypeScript
type: docs
description: "ใช้ Aspose.CAD ใน TypeScript."
weight: 74
url: /th/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---

## สิ่งที่ต้องมี
- Visual Code + Live Server
- Node.js

## แปลงภาพ dgn เป็น png และแสดงในเบราว์เซอร์

ในตัวอย่างนี้ คุณจะสร้างโปรแกรมแปลงง่ายๆ ที่แปลงภาพวาดและบันทึกเป็นภาพ

## การสร้าง JavaScript

1. สร้าง package.json ในโฟลเดอร์โปรเจ็กต์
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. แก้ไข package.json เพิ่มการพึ่งพาของ aspose-cad
{{< highlight plain >}}
"dependencies": {
    "aspose-cad": "^23.1.0"
  },
 "devDependencies": {
    "live-server": "^1.2.1",
    "typescript": "^3.3.3333",
    "yarn": "^1.22.19"
  }
{{< /highlight >}}
1. สร้าง index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //GET_FILE_FORMAT
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // LOAD
    var file = Image.load(array);
    console.log(file);
    
    // SAVE
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. ใช้คำสั่ง npm เพื่อสร้าง index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. สร้าง index.html
{{< highlight plain >}}
<!DOCTYPE html>
เปิดคอนโซล (Ctrl+Shift+I) เพื่อดูผลลัพธ์

<script src="./node_modules/aspose-cad/dotnet.js"></script>
<script type="module" src="./node_modules/aspose-cad/es2015/index-js.js"></script>

<body>
	<input id="file" type="file">
	<img id="image" />
</body>

<script>
window.onload = async function () {
	document.querySelector('input').addEventListener('change', function() {
      var reader = new FileReader();
      reader.onload = function() {
      
          var arrayBuffer = this.result;
          var array = new Uint8Array(arrayBuffer);
          
		  //GET_FILE_FORMAT
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // LOAD
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // SAVE
		  exportedFilePromise = Aspose.CAD.Image.save(array, new Aspose.CAD.PngOptions());
		  exportedFilePromise.then(exportedFile => {
			console.log(exportedFile);
			
			var urlCreator = window.URL || window.webkitURL;
			var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            document.querySelector("#image").src = imageUrl;
		  });
      }
	  
      reader.readAsArrayBuffer(this.files[0]);
    }, 
	false);
};
</script>
{{< /highlight >}}

1. ติดตั้งแพ็คเกจโดยใช้คำสั่ง npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. เริ่มแอปพลิเคชันด้วย [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) หรือ yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## ตัวอย่างการดำเนินการ

1. เลือกไฟล์.<br>
![Choose file](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. เลือกไฟล์ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG ใดก็ได้
1. หากคำตอบสำเร็จ ไฟล์จะถูกแสดงบนหน้าจอและข้อเสนอให้ดาวน์โหลด<br>
![Convert image](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## ดูเพิ่มเติม

- [ติดตั้ง Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [ติดตั้ง Node.js](https://nodejs.org/en/)
