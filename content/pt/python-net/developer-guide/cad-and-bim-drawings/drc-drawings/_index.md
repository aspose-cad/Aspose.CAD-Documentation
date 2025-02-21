---
title: Desenhos DRC
type: docs
weight: 40
url: /pt/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exportando o formato DRC para PDF**

Aspose.CAD para Python permite que desenvolvedores exportem um arquivo [DRC](https://docs.fileformat.com/3d/drc/) para o formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [DRC](https://docs.fileformat.com/3d/drc/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte maneira:

1. Carregue o arquivo de desenho DRC usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **PdfOptions** e defina a propriedade **VectorRasterizationOptions**.
1. Chame **Image.save** passando um objeto de **PdfOptions** como o segundo parâmetro.

## Código de Exemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
