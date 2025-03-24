---
title: Aspose.CAD'i Vue'da Nasıl Kullanılır
type: docs
description: "Aspose.CAD'i Vue'da kullanın."
weight: 75
url: /tr/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Ön Koşullar
- Vue CLI
- Visual Code
- Node.js

## DGN görüntüsünü PNG'ye çevirin ve tarayıcıda görüntüleyin

Bu örnekte, bir çizimi dönüştüren ve bir resim olarak kaydeden basit bir dönüşüm programı oluşturuyorsunuz.

## Vue Projesi Oluşturma

1. Zaten bir Vue çalışma alanı dizininde olmadığınızdan emin olun.
1. Yeni bir tane başlatın ve ardından programın adını verin veya Visual Code veya WebStorm gibi diğer programları kullanarak bir proje oluşturun:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. npm paketinden Aspose.CAD'i yükleyin
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Çizimi yükleyip görüntülemek için bir giriş türü dosyası ve img etiketleri oluşturun
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. App.vue'de, yardımcı işlemleri başlatma, işleme ve resmi gösterme sürecini tanımlıyoruz
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //montaj sürecini başlatmak için gerekli
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
      
      console.log("WASM yükleniyor...");
      await dotnet.boot();
      console.log("WASM yüklendi");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // YÜKLE
              let file = Image.load(array);
              console.log(file);

              // KAYDET
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
    <img alt="Vue logosu" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Vue için aspose.cad örneği.</p>
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
1. Uygulamayı başlatın
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Uygulama örneği

1. Dosya seçin.<br>
![Dosya seç](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Yanıt başarılıysa, dosya ekranda görüntülenecek ve indirilmesi teklif edilecektir.<br>
![Görüntüyü dönüştür](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Ayrıca Bakınız

- [Visual Code'u Yükleyin](https://code.visualstudio.com/)
- [Node.js'i Yükleyin](https://nodejs.org/en/)
