---
title: Как использовать Aspose.CAD в Vue
type: docs
description: "Используйте Aspose.CAD в Vue."
weight: 75
url: /ru/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Предварительные требования
- Vue CLI
- Visual Code
- Node.js

## Преобразование изображения dgn в png и отображение в браузере

В этом примере вы создадите простую программу преобразования, которая конвертирует чертеж и сохраняет его как изображение.

## Создание проекта Vue

1. Убедитесь, что вы не находитесь уже в каталоге рабочего пространства Vue.
1. Начните новый проект и задайте имя программы или используйте другие программы для создания проекта, такие как Visual Code или WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Установите Aspose.CAD из npm пакета
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Создайте теги ввода типа файл и изображение для загрузки и отображения чертежа
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. В App.vue мы описываем процесс запуска вспомогательных процессов, обработки и отображения изображения
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // необходимо для начала процесса сборки
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
      
      console.log("загрузка WASM...");
      await dotnet.boot();
      console.log("WASM загружен");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // ЗАГРУЗКА
              let file = Image.load(array);
              console.log(file);

              // СОХРАНЕНИЕ
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
    <p>Пример aspose.cad для Vue.</p>
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
1. Запустите приложение
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Пример выполнения

1. Выберите файл.<br>
![Выбор файла](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Выберите любой файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Если ответ будет успешным, файл будет отображён на экране и предложит его скачать.<br>
![Преобразовать изображение](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Смотрите также

- [Установить Visual Code](https://code.visualstudio.com/)
- [Установить Node.js](https://nodejs.org/en/)
