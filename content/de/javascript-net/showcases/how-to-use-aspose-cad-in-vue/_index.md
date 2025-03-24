---
title: Wie man Aspose.CAD in Vue verwendet
type: docs
description: "Verwenden Sie Aspose.CAD in Vue."
weight: 75
url: /de/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Voraussetzungen
- Vue CLI
- Visual Studio Code
- Node.js

## Umwandeln eines DGN-Bildes in PNG und Anzeigen im Browser

In diesem Beispiel erstellen Sie ein einfaches Konvertierungsprogramm, das eine Zeichnung umwandelt und als Bild speichert.

## Erstellen des Vue-Projekts

1. Stellen Sie sicher, dass Sie sich nicht bereits in einem Vue-Arbeitsbereisverzeichnis befinden.
1. Starten Sie ein neues und dann geben Sie den Namen des Programms ein oder verwenden Sie andere Programme wie Visual Studio Code oder WebStorm, um ein Projekt zu erstellen:
{{< highlight plain >}}
vue create vue-beispiel
{{< /highlight >}}
1. Installieren Sie Aspose.CAD aus dem npm-Paket
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Erstellen Sie einen Input-Typ Datei und img-Tags, um die Zeichnung zu laden und anzuzeigen
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. In App.vue beschreiben wir den Prozess des Startens der Hilfsprozesse, der Verarbeitung und zeigen das Bild
{{< highlight plain >}}
<script>
import { Drawing, PngOptions } from "aspose-cad";

export default {
  beforeCreate: function () {
    // Notwendig für den Start des Zusammenbau-Prozesses
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
      
      console.log("WASM wird geladen...");
      await dotnet.boot();
      console.log("WASM geladen");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // LADEN
              let file = Image.load(array);
              console.log(file);

              // SPEICHERN
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
    <img alt="Vue Logo" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Beispiel aspose.cad für Vue.</p>
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
1. Anwendung starten
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Ausführungsbeispiel

1. Datei auswählen.<br>
![Datei auswählen](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Wählen Sie eine beliebige DXF-, DWG-, DGN-, DWF-, DWFX-, IFC-, STL-, DWT-, IGES-, PLT-, CF2-, OBJ-, HPGL-, IGS-, PCL-, FBX-, PDF-, SVG-Datei aus.
1. Wenn die Antwort erfolgreich ist, wird die Datei auf dem Bildschirm angezeigt und es wird angeboten, sie herunterzuladen.<br>
![Bild konvertieren](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Siehe auch

- [Visual Studio Code installieren](https://code.visualstudio.com/)
- [Node.js installieren](https://nodejs.org/en/)
