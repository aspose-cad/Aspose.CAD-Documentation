---
title: Comment utiliser Aspose.CAD dans React
type: docs
description: "Utilisez Aspose.CAD dans React"
weight: 75
url: /fr/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Prérequis
- Visual Code
- Node.js

## Convertir une image dgn en png et l'afficher dans le navigateur

Dans cet exemple, vous créez un programme de conversion simple qui convertit un dessin et l'enregistre en tant qu'image.

## Création du projet React

1. Assurez-vous de ne pas être déjà dans un répertoire de travail React.
1. Commencez un nouveau projet et puis nommez le programme ou utilisez d'autres programmes pour créer un projet tel que Visual Code ou WebStorm :
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Installez Aspose.CAD depuis le package npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Créez une balise input de type fichier et des balises img pour charger et afficher le dessin
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converti" id="image" />
</span>
{{< /highlight >}}
1. Dans App.tsx, nous décrivons le processus de démarrage des processus auxiliaires, de traitement et de sauvegarde de l'image
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="converti" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("chargement de WASM...");
  await boot();
  console.log("WASM chargé");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // CHARGER
          var file = Image.load(array);

          // SAUVEGARDER
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. Démarrez l'application
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Exemple d'exécution

1. Choisissez un fichier.<br>
![Choisissez un fichier](/fr/_assets/javascript-net/react/choose-file.png)<br>
1. Sélectionnez n'importe quel fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la réponse est réussie, le fichier sera affiché à l'écran et proposera de le télécharger.<br>
![Convertir l'image](/fr/_assets/javascript-net/react/convert-image.png)<br>

## Voir aussi

- [Installer Visual Code](https://code.visualstudio.com/)
- [Installer Node.js](https://nodejs.org/en/)
