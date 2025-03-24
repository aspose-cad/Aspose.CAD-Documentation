---
title: Як використовувати Aspose.CAD у Vue
type: docs
description: "Використовуйте Aspose.CAD у Vue."
weight: 75
url: /uk/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Попередні вимоги
- Vue CLI
- Visual Code
- Node.js

## Перетворення зображення dgn у png та відображення у браузері

У цьому прикладі ви створюєте просту програму для конвертації, яка перетворює малюнок і зберігає його як зображення.

## Створення проекту Vue

1. Переконайтеся, що ви вже не в каталозі робочого простору Vue.
1. Розпочніть новий і введіть назву програми або використовуйте інші програми для створення проекту, такі як Visual Code або WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Встановіть Aspose.CAD з npm пакету
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Створіть елемент input типу file та теги img для завантаження та відображення малюнка
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. У App.vue ми описуємо процес запуску допоміжних процесів, обробки та відображення зображення
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //потрібно для запуску процесу збирання
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
      
      console.log("завантаження WASM...");
      await dotnet.boot();
      console.log("WASM завантажено");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // ЗАВАНТАЖИТИ
              let file = Image.load(array);
              console.log(file);

              // ЗБЕРЕГТИ
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
    <img alt="Логотип Vue" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Приклад aspose.cad для Vue.</p>
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
1. Запустіть програму
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Приклад виконання

1. Виберіть файл.<br>
![Виберіть файл](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Виберіть будь-який файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Якщо відповідь успішна, файл буде відображено на екрані, і ви зможете його завантажити.<br>
![Перетворити зображення](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Також дивіться

- [Встановити Visual Code](https://code.visualstudio.com/)
- [Встановити Node.js](https://nodejs.org/en/)
