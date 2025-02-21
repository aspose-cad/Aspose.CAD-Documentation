---
title: Como usar Aspose.CAD no Vue
type: docs
description: "Usar Aspose.CAD no Vue."
weight: 75
url: /pt/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Pré-requisitos
- Vue CLI
- Visual Code
- Node.js

## Converter imagem dgn para png e exibir no navegador

Neste exemplo, você cria um programa de conversão simples que converte um desenho e o salva como uma imagem.

## Criando o Projeto Vue

1. Certifique-se de que você não está em um diretório de espaço de trabalho do Vue.
1. Inicie um novo e, em seguida, o nome do programa ou use outros programas para criar um projeto, como Visual Code ou WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Instale Aspose.CAD do pacote npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Crie um arquivo de tipo de entrada e tags img para carregar e exibir o desenho
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. No App.vue, descrevemos o processo de início dos processos auxiliares, processamento e exibição da imagem
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //necessário para iniciar o processo de montagem
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
      
      console.log("carregando WASM...");
      await dotnet.boot();
      console.log("WASM carregado");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // CARREGAR
              let file = Image.load(array);
              console.log(file);

              // SALVAR
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
    <p>Exemplo aspose.cad para Vue.</p>
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
1. Iniciar aplicação
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Exemplo de Execução

1. Escolha o arquivo.<br>
![Escolha o arquivo](/_assets/javascript-net/vue/choose-file.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se a resposta for bem-sucedida, o arquivo será exibido na tela e oferecerá para baixá-lo.<br>
![Converter imagem](/_assets/javascript-net/vue/convert-image.png)<br>

## Veja Também

- [Instalar Visual Code](https://code.visualstudio.com/)
- [Instalar Node.js](https://nodejs.org/en/)
