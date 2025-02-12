---
title: Cómo usar Aspose.CAD en TypeScript
type: docs
description: "Usar Aspose.CAD en TypeScript."
weight: 74
url: /es/javascript-net/how-to-use-aspose-cad-in-typescript
---


## Requisitos previos
- Visual Code + Live Server
- Node.js

## Convertir imagen dgn a png y mostrar en el navegador

En este ejemplo, crearás un programa de conversión simple que convierte un dibujo y lo guarda como una imagen.

## Creando el JavaScript

1. Crea package.json en la carpeta del proyecto
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Modifica package.json, añade las dependencias de aspose-cad
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
1. Crea index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //OBTENER_FORMATO_DE_ARCHIVO
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // CARGAR
    var file = Image.load(array);
    console.log(file);
    
    // GUARDAR
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Usa el comando npm para crear index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Crea index.html
{{< highlight plain >}}
<!DOCTYPE html>
Abre la consola (Ctrl+Shift+I) para ver la salida.

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
          
		  //OBTENER_FORMATO_DE_ARCHIVO
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // CARGAR
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // GUARDAR
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

1. Instala los paquetes usando el comando npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Inicia la aplicación con [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) o yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Ejemplo de ejecución

1. Elige un archivo.<br>
![Elegir archivo](/_assets/javascript-net/typescript/choose-file.png)<br>
1. Selecciona cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la respuesta es exitosa, el archivo se mostrará en pantalla y ofrecerá descargarlo.<br>
![Convertir imagen](/_assets/javascript-net/typescript/convert-image.png)<br>
## Véase también

- [Instalar Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Instalar Node.js](https://nodejs.org/en/)
