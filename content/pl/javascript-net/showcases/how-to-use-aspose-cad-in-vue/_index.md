---
title: Jak używać Aspose.CAD w Vue
type: docs
description: "Użyj Aspose.CAD w Vue."
weight: 75
url: /pl/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Wymagania wstępne
- Vue CLI
- Visual Code
- Node.js

## Konwersja obrazu dgn do png i wyświetlenie w przeglądarce

W tym przykładzie tworzysz prosty program konwersji, który konwertuje rysunek i zapisuje go jako obraz.

## Tworzenie projektu Vue

1. Upewnij się, że nie jesteś już w katalogu roboczym Vue.
1. Rozpocznij nowy i następnie nazwę programu lub użyj innych programów, aby utworzyć projekt, takich jak Visual Code lub WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Zainstaluj Aspose.CAD z pakietu npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Utwórz tagi typu plik i img, aby załadować i wyświetlić rysunek
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. W App.vue opisujemy proces uruchamiania pomocniczych procesów, przetwarzania i wyświetlania obrazu
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default {
  beforeCreate: function () {
    // potrzebne do uruchomienia procesu kompilacji
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
      
      console.log("ładowanie WASM...");
      await dotnet.boot();
      console.log("załadowano WASM");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // ŁADUJ
              let file = Image.load(array);
              console.log(file);

              // ZAPISZ
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
    <p>Przykład aspose.cad dla Vue.</p>
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
main {
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
1. Uruchom aplikację
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Przykład wykonania

1. Wybierz plik.<br>
![Wybierz plik](/_assets/javascript-net/vue/choose-file.png)<br>
1. Wybierz dowolny plik DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Jeśli odpowiedź jest pozytywna, plik zostanie wyświetlony na ekranie i zostanie zaoferowane jego pobranie.<br>
![Konwertuj obraz](/_assets/javascript-net/vue/convert-image.png)<br>

## Zobacz także

- [Zainstaluj Visual Code](https://code.visualstudio.com/)
- [Zainstaluj Node.js](https://nodejs.org/en/)
