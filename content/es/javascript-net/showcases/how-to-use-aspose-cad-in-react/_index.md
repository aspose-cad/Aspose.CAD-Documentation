---
title: Cómo usar Aspose.CAD en React
type: docs
description: "Usar Aspose.CAD en React"
weight: 75
url: /es/javascript-net/how-to-use-aspose-cad-in-react
---

## Requisitos Previos
- Visual Code
- Node.js

## Convertir imagen dgn a png y mostrar en el navegador

En este ejemplo, creas un programa de conversión simple que convierte un dibujo y lo guarda como una imagen.

## Crear el Proyecto React

1. Asegúrate de que no estás ya en un directorio de espacio de trabajo de React.
1. Inicia uno nuevo y luego el nombre del programa o usa otros programas para crear un proyecto como Visual Code o WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Instala Aspose.CAD desde el paquete npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Crea un archivo de entrada tipo file y etiquetas img para cargar y mostrar el dibujo
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="convertido" id="image" />
</span>
{{< /highlight >}}
1. En App.tsx, describimos el proceso de inicio de los procesos auxiliares, procesamiento y guardado de la imagen
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
          <img alt="convertido" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("cargando WASM...");
  await boot();
  console.log("WASM cargado");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // CARGAR
          var file = Image.load(array);

          // GUARDAR
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
1. Iniciar aplicación
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Ejemplo de Ejecución

1. Elegir archivo.<br>
![Elegir archivo](/es/_assets/choose-file.png)<br>
1. Seleccionar cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la respuesta es exitosa, el archivo se mostrará en la pantalla y se ofrecerá descargarlo.<br>
![Convertir imagen](/es/_assets/convert-image.png)<br>

## Véase También

- [Instalar Visual Code](https://code.visualstudio.com/)
- [Instalar Node.js](https://nodejs.org/en/)
