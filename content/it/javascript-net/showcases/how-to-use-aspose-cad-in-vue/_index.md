---
title: Come utilizzare Aspose.CAD in Vue
type: docs
description: "Utilizza Aspose.CAD in Vue."
weight: 75
url: /it/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Requisiti
- Vue CLI
- Visual Code
- Node.js

## Convertire un'immagine dgn in png e visualizzarla nel browser

In questo esempio, crei un semplice programma di conversione che converte un disegno e lo salva come immagine.

## Creare il Progetto Vue

1. Assicurati di non trovarti già in una directory di lavoro di Vue.
1. Inizia una nuova directory e poi il nome del programma o utilizza altri programmi per creare un progetto come Visual Code o WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Installa Aspose.CAD dal pacchetto npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Crea un input di tipo file e i tag img per caricare e visualizzare il disegno
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. In App.vue, descriviamo il processo di avvio dei processi ausiliari, elaborazione e visualizzazione dell'immagine
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //necessario per avviare il processo di assemblaggio
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
      
      console.log("caricamento WASM...");
      await dotnet.boot();
      console.log("WASM caricato");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // CARICA
              let file = Image.load(array);
              console.log(file);

              // SALVA
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
    <p>Esempio di aspose.cad per Vue.</p>
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
1. Avviare l'applicazione
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Esempio di esecuzione

1. Scegli un file.<br>
![Scegli file](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Seleziona qualsiasi file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se la risposta è positiva, il file verrà visualizzato sullo schermo e verrà offerta la possibilità di scaricarlo.<br>
![Converti immagine](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Vedi Anche

- [Installa Visual Code](https://code.visualstudio.com/)
- [Installa Node.js](https://nodejs.org/en/)
