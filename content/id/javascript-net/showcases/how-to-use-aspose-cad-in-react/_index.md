---
title: Cara Menggunakan Aspose.CAD di React
type: docs
description: "Gunakan Aspose.CAD di React"
weight: 75
url: /id/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Prasyarat
- Visual Code
- Node.js

## Mengonversi gambar dgn ke png dan menampilkannya di browser

Dalam contoh ini, Anda membuat program konversi sederhana yang mengonversi gambar dan menyimpannya sebagai gambar.

## Membuat Proyek React

1. Pastikan Anda tidak sedang berada di direktori workspace React.
1. Mulai yang baru dan kemudian nama program atau gunakan program lain untuk membuat proyek seperti Visual Code atau WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Instal Aspose.CAD dari paket npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Buat tag input type file dan img untuk memuat dan menampilkan gambar
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. Di App.tsx, kita menjelaskan proses memulai proses pembantu, memproses dan menyimpan gambar
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
  console.log("loading WASM...");
  await boot();
  console.log("loaded WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // MEMUAT
          var file = Image.load(array);

          // MENYIMPAN
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
1. Jalankan aplikasi
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Contoh Eksekusi

1. Pilih file.<br>
![Choose file](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. Pilih file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG mana pun.
1. Jika jawabannya berhasil, file akan ditampilkan di layar dan akan menawarkan untuk mengunduhnya.<br>
![Convert image](/cad/_assets/javascript-net/react/convert-image.png)<br>

## Lihat Juga

- [Instal Visual Code](https://code.visualstudio.com/)
- [Instal Node.js](https://nodejs.org/en/)
