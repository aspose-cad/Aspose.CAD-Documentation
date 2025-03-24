---
title: Cara Menggunakan Aspose.CAD di Angular
type: docs
description: "Gunakan Aspose.CAD di Angular."
weight: 71
url: /id/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Prasyarat
- Angular CLI
- Visual Code
- Node.js

## Mengonversi gambar dgn menjadi png dan menampilkannya di browser

Dalam contoh ini, Anda membuat program konversi sederhana yang mengonversi gambar dan menyimpannya sebagai gambar.

## Membuat Proyek Angular

1. Pastikan Anda tidak berada di direktori workspace Angular.
1. Mulai yang baru dan kemudian beri nama program atau gunakan program lain untuk membuat proyek seperti Visual Code atau WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Pasang Aspose.CAD dari paket npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Buka file angular.json dan tambahkan entri di field skrip, skrip ini mulai dimuat dengan proyek, diperlukan untuk memulai pemrosesan file
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. Di app.component.html, buat input tipe file dan tag img untuk memuat dan menampilkan gambar
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. Di app.component.ts, kami menjelaskan proses memulai proses pembantu, pemrosesan dan penyimpanan gambar
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//perlu untuk mem-boot proses dotnet
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
    console.log("aspose-cad WASM sedang dimuat...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM telah dimuat");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Muat gambar
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //simpan gambar ke png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //buat src untuk gambar yang telah dikonversi
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //unduh gambar png
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
1. Jalankan aplikasi
{{< highlight plain >}}
npm start
//atau
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Perintah ng serve:

- Membangun aplikasi
- Memulai server pengembangan
- Memantau file sumber
- Membangun ulang aplikasi saat Anda melakukan perubahan

Flag --open membuka browser di http://localhost:4200.
{{% /alert %}}

## Contoh Eksekusi

1. Pilih file.<br>
![Pilih file](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. Pilih file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Jika jawaban berhasil, file akan ditampilkan di layar dan akan menawarkan untuk mengunduhnya.<br>
![Konversi gambar](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## Lihat Juga

- [Instal Angular CLI](https://angular.io/guide/setup-local/)
- [Instal Visual Code](https://code.visualstudio.com/)
- [Instal Node.js](https://nodejs.org/en/)
