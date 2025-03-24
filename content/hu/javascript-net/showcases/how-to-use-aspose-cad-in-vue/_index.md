---
title: Hogyan használjuk az Aspose.CAD-ot Vue-ban
type: docs
description: "Használja az Aspose.CAD-ot Vue-ban."
weight: 75
url: /hu/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Előfeltételek
- Vue CLI
- Visual Code
- Node.js

## DGN kép átkonvertálása PNG-ra és megjelenítése a böngészőben

Ebben a példában létrehoz egy egyszerű átkonvertáló programot, amely egy rajzot konvertál és képként menti.

## Vue Projekt létrehozása

1. Győződjön meg arról, hogy nincs már egy Vue munkahelyi könyvtárban.
1. Indítson egy újat, majd adja meg a program nevét, vagy használjon más programokat projekt létrehozásához, például a Visual Code-ot vagy a WebStorm-ot:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Telepítse az Aspose.CAD-ot az npm csomagból
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Hozzon létre egy input fájl típusú elemet és img címkéket a rajz betöltésére és megjelenítésére
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. Az App.vue fájlban leírjuk a segédprocesszusok indításának, feldolgozásának és a kép megjelenítésének folyamatát
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // szükséges az összeszerelési folyamat indításához
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
      
      console.log("WASM betöltése...");
      await dotnet.boot();
      console.log("WASM betöltve");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // BETÖLTÉS
              let file = Image.load(array);
              console.log(file);

              // MEGTAKARÍTÁS
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
    <p>Példa az aspose.cad használatára Vue-ban.</p>
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
1. Alkalmazás indítása
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Végrehajtási példa

1. Válassza ki a fájlt.<br>
![Fájl kiválasztása](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Válasszon bármilyen DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG fájlt.
1. Ha a válasz sikeres, a fájl megjelenik a képernyőn, és felajánlja a letöltését.<br>
![Kép átkonvertálása](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Lásd még

- [Visual Code telepítése](https://code.visualstudio.com/)
- [Node.js telepítése](https://nodejs.org/en/)
