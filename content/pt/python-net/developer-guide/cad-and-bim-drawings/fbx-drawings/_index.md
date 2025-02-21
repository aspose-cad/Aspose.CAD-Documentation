---
title: Desenhos FBX
type: docs
weight: 110
url: /pt/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exportando Formato FBX Para PDF**

Aspose.CAD para Python permite que os desenvolvedores exportem um arquivo [FBX](https://docs.fileformat.com/3d/fbx/) para o formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [FBX](https://docs.fileformat.com/3d/fbx/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte maneira:

1. Carregue o arquivo de desenho [FBX](https://docs.fileformat.com/3d/fbx/) usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **PageHeight** e **PageWidth**.
1. Crie um objeto da classe **PdfOptions** e defina a propriedade **vector_rasterization_options**.
1. Chame **Image.save** passando um objeto de **PdfOptions** como o segundo parâmetro.

## Código de Exemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
