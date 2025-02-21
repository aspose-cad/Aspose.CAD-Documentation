---
title: Desenhos DXB
type: docs
weight: 90
url: /pt/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exportando o Formato DXB para PDF**

Aspose.CAD para Python permite que os desenvolvedores exportem um arquivo DXB para o formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de DXB para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte forma:

1. Carregue o arquivo de desenho DXB usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e configure as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **PdfOptions** e configure a propriedade **vector_rasterization_options**.
1. Chame **Image.save** passando um objeto de **PdfOptions** como segundo parâmetro.

## Código de Exemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
