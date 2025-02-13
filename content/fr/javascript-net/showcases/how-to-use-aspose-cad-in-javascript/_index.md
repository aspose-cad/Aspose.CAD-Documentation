---
title: Comment utiliser Aspose.CAD en JavaScript
type: docs
description: "utiliser Aspose.CAD en JavaScript."
weight: 73
url: /fr/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Prérequis
- Visual Code + Live Server
- Node.js

## Convertir une image dgn en png et l'afficher dans le navigateur

Dans cet exemple, vous créez un simple programme de conversion qui convertit un dessin et l'enregistre en tant qu'image.

## Création du JavaScript

1. Créez package.json avec les dépendances aspose-cad
{{< highlight plain >}}
"dependencies": {
    "aspose-cad": "^23.1.0"
  },
 "devDependencies": {
    "live-server": "^1.2.1",
    "typescript": "^3.3.3333",
    "yarn": "^1.22.19"
  }
{{< /highlight >}}
1. Créez index.html
{{< highlight plain >}}
<!DOCTYPE html>
Ouvrez la console (Ctrl+Shift+I) pour voir la sortie.

<script src="./node_modules/aspose-cad/dotnet.js"></script>
<script type="module" src="./node_modules/aspose-cad/es2015/index-js.js"></script>

<body>
	<input id="file" type="file">
	<img id="image" />
</body>

<script>
window.onload = async function () {
	document.querySelector('input').addEventListener('change', function() {
      var reader = new FileReader();
      reader.onload = function() {
      
          var arrayBuffer = this.result;
          var array = new Uint8Array(arrayBuffer);
          
		  //OBTENIR_FORMAT_DE_FICHIER
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // CHARGER
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // SAUVEGARDER
		  exportedFilePromise = Aspose.CAD.Image.save(array, new Aspose.CAD.PngOptions());
		  exportedFilePromise.then(exportedFile => {
			console.log(exportedFile);
			
			var urlCreator = window.URL || window.webkitURL;
			var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            document.querySelector("#image").src = imageUrl;
		  });
      }
	  
      reader.readAsArrayBuffer(this.files[0]);
    }, 
	false);
};
</script>
{{< /highlight >}}

1. Installez les paquets en utilisant la commande npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Démarrez l'application avec [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) ou yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Exemple d'exécution

1. Choisissez un fichier.<br>
![Choisir un fichier](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Sélectionnez n'importe quel fichier DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la réponse est réussie, le fichier sera affiché à l'écran et proposera de le télécharger.<br>
![Convertir l'image](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Voir aussi

- [Installer Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Installer Node.js](https://nodejs.org/en/)
