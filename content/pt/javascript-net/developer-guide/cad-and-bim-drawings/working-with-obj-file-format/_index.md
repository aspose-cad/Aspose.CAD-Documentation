---
title: Trabalhando com o Formato de Arquivo OBJ
type: docs
weight: 120
url: /pt/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD agora suporta o formato de arquivo OBJ. O formato de arquivo OBJ é uma geometria 3D que contém mapas de textura, coordenadas 3D, faces poligonais e outras informações do objeto.

{{% /alert %}}

## **Exportando o Formato OBJ para PNG**

Aspose.CAD para Javascript em Angular permite que os desenvolvedores exportem um [OBJ](https://docs.fileformat.com/3d/obj/) arquivo para o formato [PNG](https://docs.fileformat.com/image/png/).
A abordagem de conversão de [OBJ](https://docs.fileformat.com/3d/obj/) para [PNG](https://docs.fileformat.com/image/png/) funciona da seguinte maneira:

1. Carregue o arquivo de desenho [OBJ](https://docs.fileformat.com/3d/obj/) usando o método **Image.load**.
1. Chame **Image.save** passando um objeto de **PngOptions** como o segundo parâmetro.

## Código de Exemplo

O código abaixo mostra como alcançar o mesmo objetivo usando Aspose.CAD para JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
