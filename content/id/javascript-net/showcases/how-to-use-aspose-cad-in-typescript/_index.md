---
title: Cara Menggunakan Aspose.CAD di TypeScript
type: docs
description: "Gunakan Aspose.CAD di TypeScript."
weight: 74
url: /id/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## Prasyarat
- Visual Code + Live Server
- Node.js

## Mengonversi gambar dgn ke png dan menampilkannya di browser

Dalam contoh ini, Anda membuat program konversi sederhana yang mengonversi gambar dan menyimpannya sebagai gambar.

## Membuat JavaScript

1. Buat package.json di folder proyek
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Modifikasi package.json, tambahkan ketergantungan aspose-cad
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
1. Buat index.ts
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
1. Gunakan perintah npm untuk membuat index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Buat index.html
{{< highlight plain >}}
<!DOCTYPE html>
Buka konsol (Ctrl+Shift+I) untuk melihat output.

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

1. Instal paket menggunakan perintah npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Jalankan aplikasi dengan [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) atau yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Contoh Eksekusi

1. Pilih file.<br>
![Pilih file](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. Pilih file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG mana saja.
1. Jika jawabannya berhasil, file akan ditampilkan di layar dan akan menawarkan untuk mengunduhnya.<br>
![Konversi gambar](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## Lihat Juga

- [Instal Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Instal Node.js](https://nodejs.org/en/)
