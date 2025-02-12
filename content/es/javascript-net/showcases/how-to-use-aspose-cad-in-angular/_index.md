---
title: Cómo usar Aspose.CAD en Angular
type: docs
description: "Usar Aspose.CAD en Angular."
weight: 71
url: /es/javascript-net/how-to-use-aspose-cad-in-angular
---

## Requisitos previos
- Angular CLI
- Visual Code
- Node.js

## Convertir imagen dgn a png y mostrar en el navegador

En este ejemplo, crearás un programa de conversión simple que convierte un dibujo y lo guarda como una imagen.

## Creando el Proyecto Angular

1. Asegúrate de que no estés ya en un directorio de espacio de trabajo de Angular.
1. Inicia uno nuevo y luego el nombre del programa o utiliza otros programas para crear un proyecto como Visual Code o WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Instala Aspose.CAD desde el paquete npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Abre el archivo angular.json y agrega una entrada en el campo de scripts, este script comienza a cargarse con el proyecto, es necesario para comenzar a procesar los archivos
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. En app.component.html, crea un input de tipo archivo y etiquetas img para cargar y mostrar el dibujo
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. En app.component.ts, describimos el proceso de inicio de los procesos auxiliares, procesamiento y guardado de la imagen
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//necesita iniciar el proceso dotnet
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
    console.log("aspose-cad WASM cargando...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM ha sido cargado");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Cargar imagen
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //guardar imagen como png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //crear src para la imagen convertida
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //descargar imagen png
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
1. Iniciar aplicación
{{< highlight plain >}}
npm start
//o
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
El comando ng serve:

- Compila la aplicación
- Inicia el servidor de desarrollo
- Observa los archivos fuente
- recompila la aplicación a medida que realizas cambios

La bandera --open abre un navegador en http://localhost:4200.
{{% /alert %}}

## Ejemplo de ejecución

1. Elegir archivo.<br>
![Elegir archivo](/_assets/javascript-net/angular/choose-file.png)<br>
1. Seleccionar cualquier archivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Si la respuesta es exitosa, el archivo se mostrará en la pantalla y ofrecerá descargarlo.<br>
![Convertir imagen](/_assets/javascript-net/angular/convert-image.png)<br>

## Véase también

- [Instalar Angular CLI](https://angular.io/guide/setup-local/)
- [Instalar Visual Code](https://code.visualstudio.com/)
- [Instalar Node.js](https://nodejs.org/en/)
