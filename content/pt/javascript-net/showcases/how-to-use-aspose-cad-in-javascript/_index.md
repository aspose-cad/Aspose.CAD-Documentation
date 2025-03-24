---
title: Como usar Aspose.CAD em JavaScript
type: docs
description: "usar Aspose.CAD em JavaScript."
weight: 73
url: /pt/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Pré-requisitos
- Visual Code + Live Server
- Node.js

## Converter imagem dgn para png e exibir no navegador

Neste exemplo, você cria um programa de conversão simples que converte um desenho e o salva como uma imagem.

## Criando o JavaScript

1. Crie o package.json com as dependências do aspose-cad
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
1. Crie o index.html
{{< highlight plain >}}
<!DOCTYPE html>
Abra o console (Ctrl+Shift+I) para ver a saída.

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
          
		  //GET_FILE_FORMAT
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // LOAD
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // SAVE
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

1. Instale os pacotes usando o comando npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Inicie a aplicação com [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) ou yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Exemplo de execução

1. Escolha o arquivo.<br>
![Escolher arquivo](/cad/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Selecione qualquer arquivo DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Se a resposta for bem-sucedida, o arquivo será exibido na tela e será oferecido para download.<br>
![Converter imagem](/cad/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Veja Também

- [Instalar Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Instalar Node.js](https://nodejs.org/en/)
