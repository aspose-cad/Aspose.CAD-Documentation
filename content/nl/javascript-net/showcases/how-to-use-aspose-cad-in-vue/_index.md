---
title: Hoe Aspose.CAD te gebruiken in Vue
type: docs
description: "Gebruik Aspose.CAD in Vue."
weight: 75
url: /nl/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Vereisten
- Vue CLI
- Visual Code
- Node.js

## Converteer dgn-afbeelding naar png en toon in browser

In dit voorbeeld maak je een eenvoudig conversieprogramma dat een tekening omzet en deze opslaat als een afbeelding.

## Het maken van het Vue-project

1. Zorg ervoor dat je je nog niet in een Vue-werkruimte directory bevindt.
1. Start een nieuwe en geef de naam van het programma op of gebruik andere programma's om een project te maken zoals Visual Code of WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Installeer Aspose.CAD van npm-pakket
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Maak een input type bestand en img-tags om de tekening te laden en weer te geven
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. In App.vue beschrijven we het proces van het starten van de helperprocessen, verwerken en tonen van de afbeelding
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // nodig voor het starten van het assemblageproces
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

      console.log("laden WASM...");
      await dotnet.boot();
      console.log("WASM geladen");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // LAAD
              let file = Image.load(array);
              console.log(file);

              // OPSLAAN
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
    <img alt="Vue-logo" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Voorbeeld aspose.cad voor Vue.</p>
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
1. Start applicatie
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Voorbeeld van uitvoering

1. Kies bestand.<br>
![Kies bestand](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Selecteer een DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-bestand.
1. Als de reactie succesvol is, wordt het bestand op het scherm weergegeven en wordt er een aanbod gedaan om het te downloaden.<br>
![Afbeelding converteren](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Zie Ook

- [Installeer Visual Code](https://code.visualstudio.com/)
- [Installeer Node.js](https://nodejs.org/en/)
