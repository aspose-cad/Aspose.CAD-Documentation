---
title: Jak používat Aspose.CAD ve Vue
type: docs
description: "Použití Aspose.CAD ve Vue."
weight: 75
url: /cs/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Předpoklady
- Vue CLI
- Visual Studio Code
- Node.js

## Převod obrázku ve formátu DGN na PNG a zobrazení v prohlížeči

V tomto příkladu vytvoříte jednoduchý konverzní program, který převede výkres a uloží ho jako obrázek.

## Vytvoření Vue projektu

1. Ujistěte se, že se nenacházíte již v pracovním adresáři Vue.
1. Spusťte nový a poté pojmenujte program nebo použijte jiné programy k vytvoření projektu, jako je Visual Studio Code nebo WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Nainstalujte Aspose.CAD pomocí npm balíčku
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Vytvořte vstupní typ souboru a značky img pro načtení a zobrazení výkresu
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. V souboru App.vue popíšeme proces spouštění pomocných procesů, zpracování a zobrazení obrázku
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //potřeba pro spuštění procesu sestavení
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
      
      console.log("načítání WASM...");
      await dotnet.boot();
      console.log("WASM načten");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // NAHRÁT
              let file = Image.load(array);
              console.log(file);

              // ULOŽIT
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
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Příklad aspose.cad pro Vue.</p>
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
1. Spusťte aplikaci
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Příklad spuštění

1. Vyberte soubor.<br>
![Vyberte soubor](/_assets/javascript-net/vue/choose-file.png)<br>
1. Vyberte jakýkoliv soubor ve formátech DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Pokud je odpověď úspěšná, soubor bude zobrazen na obrazovce a nabídne možnost jej stáhnout.<br>
![Převod obrázku](/_assets/javascript-net/vue/convert-image.png)<br>

## Viz také

- [Instalace Visual Studio Code](https://code.visualstudio.com/)
- [Instalace Node.js](https://nodejs.org/en/)
