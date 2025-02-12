---
title: Cómo usar Aspose.CAD en Vue
type: docs
description: "Usar Aspose.CAD en Vue."
weight: 75
url: /es/javascript-net/how-to-use-aspose-cad-in-vue
---

## Requisitos previos
- Vue CLI
- Visual Code
- Node.js

## Convertir imagen dgn a png y mostrar en el navegador

En este ejemplo, se crea un programa de conversión simple que convierte un dibujo y lo guarda como una imagen.

## Creando el Proyecto Vue

1. Asegúrate de que no estés ya en un directorio de espacio de trabajo de Vue.
1. Comienza uno nuevo y luego el nombre del programa o usa otros programas para crear un proyecto como Visual Code o WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Instala Aspose.CAD desde el paquete npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Crea una etiqueta de tipo archivo de entrada y etiquetas img para cargar y mostrar el dibujo
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. En App.vue, describimos el proceso de inicio de los procesos auxiliares, procesamiento y mostrar la imagen
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //necesario para iniciar el proceso de ensamblaje
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
      
      console.log("cargando WASM...");
      await dotnet.boot();
      console.log("WASM cargado");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // CARGAR
              let file = Image.load(array);
              console.log(file);

              // GUARDAR
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
    <img alt="Logo de Vue" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Ejemplo de aspose.cad para Vue.</p>
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
1. Iniciar aplicación
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Ejemplo de ejecución

1. Elegir archivo.<br>
![Elegir archivo](/_assets/javascript-net/vue/choose-file.png)<br>
1. Selecciona cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la respuesta es exitosa, el archivo se mostrará en la pantalla y ofrecerá descargarlo.<br>
![Convertir imagen](/_assets/javascript-net/vue/convert-image.png)<br>

## Véase también

- [Instalar Visual Code](https://code.visualstudio.com/)
- [Instalar Node.js](https://nodejs.org/en/)
