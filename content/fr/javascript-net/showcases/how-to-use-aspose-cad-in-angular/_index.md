---
title: Comment utiliser Aspose.CAD dans Angular
type: docs
description: "Utiliser Aspose.CAD dans Angular."
weight: 71
url: /fr/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Prérequis
- Angular CLI
- Visual Code
- Node.js

## Convertir une image dgn en png et l'afficher dans le navigateur

Dans cet exemple, vous créez un simple programme de conversion qui convertit un dessin et l'enregistre en tant qu'image.

## Création du projet Angular

1. Assurez-vous que vous n'êtes pas déjà dans un répertoire de travail Angular.
1. Démarrez un nouveau et ensuite nommez le programme ou utilisez d'autres programmes pour créer un projet tel que Visual Code ou WebStorm :
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Installez Aspose.CAD à partir du package npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Ouvrez le fichier angular.json et ajoutez une entrée dans le champ des scripts, ce script commence à charger avec le projet, il est nécessaire pour commencer à traiter les fichiers
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. Dans app.component.html, créez un input de type fichier et des balises img pour charger et afficher le dessin
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. Dans app.component.ts, nous décrivons le processus de démarrage des processus d'aide, de traitement et de sauvegarde de l'image
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//nécessite de démarrer le processus dotnet
declare let dotnet: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular-example';

  imageUrl: any;
  imgFile: Uint8Array | null | undefined;

  constructor(private sanitizer: DomSanitizer) {
  }

  // @ts-ignore
  async ngOnInit() {
    console.log("aspose-cad WASM chargement...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM a été chargé");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Charger l'image
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //sauvegarder l'image en png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //créer src pour l'image convertie
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //télécharger l'image png
      let url = window.URL.createObjectURL(blob);
      let a = document.createElement('a');
      document.body.appendChild(a);
      a.setAttribute('style', 'display: none');
      a.href = url;
      a.download = "file.png";
      a.click();
      window.URL.revokeObjectURL(url);
      a.remove();

    });
  }
}
{{< /highlight >}}
1. Démarrez l'application
{{< highlight plain >}}
npm start
//ou
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
La commande ng serve :

- construit l'application
- démarre le serveur de développement
- surveille les fichiers sources
- reconstruit l'application au fur et à mesure que vous apportez des modifications

Le flag --open ouvre un navigateur à http://localhost:4200.
{{% /alert %}}

## Exemple d'exécution

1. Choisissez un fichier.<br>
![Choisir un fichier](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. Sélectionnez tout fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la réponse est réussie, le fichier sera affiché à l'écran et proposera de le télécharger.<br>
![Convertir l'image](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## Voir aussi

- [Installer Angular CLI](https://angular.io/guide/setup-local/)
- [Installer Visual Code](https://code.visualstudio.com/)
- [Installer Node.js](https://nodejs.org/en/)
