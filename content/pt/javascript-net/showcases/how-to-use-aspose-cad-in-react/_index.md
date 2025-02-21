---
title: Como usar Aspose.CAD no React
type: docs
description: "Use Aspose.CAD no React"
weight: 75
url: /pt/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Pré-requisitos
- Visual Code
- Node.js

## Converter imagem dgn para png e exibir no navegador

Neste exemplo, você cria um programa simples de conversão que converte um desenho e o salva como uma imagem.

## Criando o Projeto React

1. Certifique-se de que você não está em um diretório de espaço de trabalho do React.
1. Inicie um novo e, em seguida, o nome do programa ou use outros programas para criar um projeto, como Visual Code ou WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Instale Aspose.CAD do pacote npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Crie um tipo de arquivo de entrada e tags de img para carregar e exibir o desenho
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="convertido" id="image" />
</span>
{{< /highlight >}}
1. No App.tsx, descrevemos o processo de inicialização dos processos auxiliares, processamento e salvamento da imagem
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
  console.log("carregando WASM...");
  await boot();
  console.log("WASM carregado");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // CARREGAR
          var file = Image.load(array);

          // SALVAR
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
1. Inicie a aplicação
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Exemplo de execução

1. Escolha o arquivo.<br>
![Escolher arquivo](/_assets/javascript-net/react/choose-file.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se a resposta for bem-sucedida, o arquivo será exibido na tela e oferecerá a opção de baixá-lo.<br>
![Converter imagem](/_assets/javascript-net/react/convert-image.png)<br>

## Veja Também

- [Instalar Visual Code](https://code.visualstudio.com/)
- [Instalar Node.js](https://nodejs.org/en/)
