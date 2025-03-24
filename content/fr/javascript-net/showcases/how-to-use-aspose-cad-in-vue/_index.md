---
title: Comment utiliser Aspose.CAD dans Vue
type: docs
description: "Utilisez Aspose.CAD dans Vue."
weight: 75
url: /fr/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Prérequis
- Vue CLI
- Visual Code
- Node.js

## Convertir une image dgn en png et l'afficher dans le navigateur

Dans cet exemple, vous créez un programme de conversion simple qui convertit un dessin et l'enregistre sous forme d'image.

## Création du projet Vue

1. Assurez-vous que vous n'êtes pas déjà dans un répertoire de travail Vue.
1. Démarrez un nouveau projet et spécifiez le nom du programme ou utilisez d'autres programmes pour créer un projet tel que Visual Code ou WebStorm :
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Installez Aspose.CAD depuis le paquet npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Créez des balises de type fichier et img pour charger et afficher le dessin
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. Dans App.vue, nous décrivons le processus de démarrage des processus d'assistance, de traitement et d'affichage de l'image
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // besoin de démarrer le processus d'assemblage
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
      
      console.log("chargement de WASM...");
      await dotnet.boot();
      console.log("WASM chargé");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // CHARGER
              let file = Image.load(array);
              console.log(file);

              // ENREGISTRER
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
    <p>Exemple aspose.cad pour Vue.</p>
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
1. Démarrez l'application
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Exemple d'exécution

1. Choisissez un fichier.<br>
![Choisir un fichier](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Sélectionnez n'importe quel fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la réponse est réussie, le fichier sera affiché à l'écran et proposera de le télécharger.<br>
![Convertir l'image](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Voir aussi

- [Installer Visual Code](https://code.visualstudio.com/)
- [Installer Node.js](https://nodejs.org/en/)
