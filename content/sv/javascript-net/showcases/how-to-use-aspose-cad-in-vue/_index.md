---
title: Hur man använder Aspose.CAD i Vue
type: docs
description: "Använd Aspose.CAD i Vue."
weight: 75
url: /sv/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Förutsättningar
- Vue CLI
- Visual Code
- Node.js

## Konvertera dgn-bild till png och visa i webbläsaren

I det här exemplet skapar du ett enkelt konverteringsprogram som konverterar en ritning och sparar den som en bild.

## Skapa Vue-projektet

1. Se till att du inte redan är i en Vue-arbetsytakatalog.
1. Starta en ny och sedan namnet på programmet eller använd andra program för att skapa ett projekt som Visual Code eller WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Installera Aspose.CAD från npm-paketet
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Skapa en inmatningstyp fil och img-taggar för att ladda och visa ritningen
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. I App.vue beskriver vi processen för att starta hjälpprocesserna, behandla och visa bilden
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // behövs för att starta samlingsprocessen
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
      
      console.log("laddar WASM...");
      await dotnet.boot();
      console.log("WASM laddad");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // LADDAR
              let file = Image.load(array);
              console.log(file);

              // SPARA
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
    <img alt="Vue-logga" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Exempel på aspose.cad för Vue.</p>
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
1. Starta applikationen
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Exempel på körning

1. Välj fil.<br>
![Välj fil](/_assets/javascript-net/vue/choose-file.png)<br>
1. Välj valfri DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-fil.
1. Om svaret är framgångsrikt kommer filen att visas på skärmen och erbjudas att laddas ner.<br>
![Konvertera bild](/_assets/javascript-net/vue/convert-image.png)<br>

## Se Även

- [Installera Visual Code](https://code.visualstudio.com/)
- [Installera Node.js](https://nodejs.org/en/)
