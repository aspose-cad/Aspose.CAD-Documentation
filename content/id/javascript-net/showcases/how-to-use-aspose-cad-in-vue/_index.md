---
title: Cara menggunakan Aspose.CAD di Vue
type: docs
description: "Gunakan Aspose.CAD di Vue."
weight: 75
url: /id/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Prasyarat
- Vue CLI
- Visual Code
- Node.js

## Mengonversi gambar dgn ke png dan menampilkannya di browser

Dalam contoh ini, Anda membuat program konversi sederhana yang mengonversi gambar dan menyimpannya sebagai gambar.

## Membuat Proyek Vue

1. Pastikan Anda tidak berada di direktori workspace Vue yang sudah ada.
1. Mulai yang baru dan kemudian beri nama program atau gunakan program lain untuk membuat proyek seperti Visual Code atau WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Install Aspose.CAD dari paket npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Buat input tipe file dan tag img untuk memuat dan menampilkan gambar
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. Di App.vue, kami menjelaskan proses memulai proses pembantu, memproses dan menampilkan gambar
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // perlu untuk memulai proses perakitan
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
      
      console.log("memuat WASM...");
      await dotnet.boot();
      console.log("WASM dimuat");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // MUAT
              let file = Image.load(array);
              console.log(file);

              // SIMPAN
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
    <img alt="Logo Vue" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Contoh aspose.cad untuk Vue.</p>
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
1. Mulai aplikasi
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Contoh pelaksanaan

1. Pilih file.<br>
![Pilih file](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Pilih file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG apa pun.
1. Jika jawabannya berhasil, file akan ditampilkan di layar dan akan menawarkan untuk mengunduhnya.<br>
![Konversi gambar](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Lihat Juga

- [Instal Visual Code](https://code.visualstudio.com/)
- [Instal Node.js](https://nodejs.org/en/)
