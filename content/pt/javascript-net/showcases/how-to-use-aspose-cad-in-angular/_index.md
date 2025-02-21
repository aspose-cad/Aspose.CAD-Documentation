---
title: Como usar Aspose.CAD no Angular
type: docs
description: "Use Aspose.CAD no Angular."
weight: 71
url: /pt/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Pré-requisitos
- Angular CLI
- Visual Code
- Node.js

## Converter imagem dgn para png e exibir no navegador

Neste exemplo, você cria um programa de conversão simples que converte um desenho e o salva como uma imagem.

## Criando o Projeto Angular

1. Certifique-se de que você não está em um diretório de espaço de trabalho Angular.
1. Inicie um novo e, em seguida, o nome do programa ou use outros programas para criar um projeto, como Visual Code ou WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Instale Aspose.CAD do pacote npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Abra o arquivo angular.json e adicione uma entrada no campo script, este script começa a carregar com o projeto, é necessário para iniciar o processamento dos arquivos
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. No app.component.html, crie um input do tipo file e tags img para carregar e exibir o desenho
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. No app.component.ts, descrevemos o processo de inicialização dos processos auxiliares, processamento e salvamento da imagem
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//precisa inicializar o processo dotnet
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
    console.log("aspose-cad WASM carregando...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM foi carregado");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Carregar imagem
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //salvar imagem como png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //criar src para a imagem convertida
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //baixar imagem png
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
1. Inicie a aplicação
{{< highlight plain >}}
npm start
//ou
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
O comando ng serve:

- Compila a aplicação
- Inicia o servidor de desenvolvimento
- Monitora os arquivos de origem
- Recompila a aplicação à medida que você faz alterações

A flag --open abre um navegador em http://localhost:4200.
{{% /alert %}}

## Exemplo de execução

1. Escolha o arquivo.<br>
![Escolher arquivo](/_assets/javascript-net/angular/choose-file.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se a resposta for bem-sucedida, o arquivo será exibido na tela e oferecerá a opção de baixá-lo.<br>
![Converter imagem](/_assets/javascript-net/angular/convert-image.png)<br>

## Veja Também

- [Instalar Angular CLI](https://angular.io/guide/setup-local/)
- [Instalar Visual Code](https://code.visualstudio.com/)
- [Instalar Node.js](https://nodejs.org/en/)
