---
title: Desenhos SVG
type: docs
weight: 170
url: /pt/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exportando o Formato SVG para PDF**

Aspose.CAD para Python permite que desenvolvedores exportem um arquivo [SVG](https://docs.fileformat.com/page-description-language/svg/) para formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [SVG](https://docs.fileformat.com/page-description-language/svg/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte forma:

1. Carregue o arquivo de desenho SVG usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **PdfOptions** e defina a propriedade **VectorRasterizationOptions**.
1. Chame **Image.save** passando um objeto de **PdfOptions** como o segundo parâmetro.

## Código de Exemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
