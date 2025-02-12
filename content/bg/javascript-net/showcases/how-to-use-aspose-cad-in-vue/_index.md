---
title: Как да използвате Aspose.CAD в Vue
type: docs
description: "Използвайте Aspose.CAD в Vue."
weight: 75
url: /bg/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Предварителни изисквания
- Vue CLI
- Visual Code
- Node.js

## Конвертиране на dgn изображение в png и показване в браузъра

В този пример създавате проста програма за конвертиране, която конвертира чертеж и го запазва като изображение.

## Създаване на Vue проект

1. Уверете се, че не сте вече в директория на Vue работно пространство.
1. Започнете ново и след това името на програмата или използвайте други програми за създаване на проект, като Visual Code или WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Инсталирайте Aspose.CAD от npm пакет
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Създайте input тип файл и img тагове за зареждане и показване на чертежа
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. В App.vue описваме процеса на стартиране на помощните процеси, обработка и показване на изображението
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //нужно за стартиране на процеса на асемблиране
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
      
      console.log("зареждане на WASM...");
      await dotnet.boot();
      console.log("зареден WASM");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // ЗАРЕЖДАНЕ
              let file = Image.load(array);
              console.log(file);

              // ЗАПАЗВАНЕ
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
    <img alt="Vue лого" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Пример aspose.cad за Vue.</p>
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
1. Стартирайте приложението
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Пример за изпълнение

1. Изберете файл.<br>
![Изберете файл](/_assets/javascript-net/vue/choose-file.png)<br>
1. Изберете всеки DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG файл.
1. Ако отговорът е успешен, файлът ще бъде показан на екрана и ще предложи да го изтеглите.<br>
![Конвертирано изображение](/_assets/javascript-net/vue/convert-image.png)<br>

## Вижте също

- [Инсталирайте Visual Code](https://code.visualstudio.com/)
- [Инсталирайте Node.js](https://nodejs.org/en/)
