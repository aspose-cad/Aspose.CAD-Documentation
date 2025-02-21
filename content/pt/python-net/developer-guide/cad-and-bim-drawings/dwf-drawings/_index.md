---
title: Desenhos DWF
type: docs
weight: 50
url: /pt/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exportando Desenhos DWF para PDF**

Aspose.CAD fornece a funcionalidade para carregar entidades de desenhos [DWF](https://docs.fileformat.com/cad/dwf/) do AutoCAD e renderizá-las como um desenho inteiro para formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [DWF](https://docs.fileformat.com/cad/dwf/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte forma:

1. Carregue o arquivo de desenho [DWF](https://docs.fileformat.com/cad/dwf/) usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **PdfOptions** e defina a propriedade **vector_rasterization_options**.
1. Chame **Image.save** passando um objeto de **PdfOptions** como segundo parâmetro.

### Exemplo de Código

O exemplo de código abaixo mostra como converter um arquivo usando as configurações padrão.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Exportando Desenhos DWF para BMP**

Aspose.CAD fornece a funcionalidade para carregar entidades de desenhos [DWF](https://docs.fileformat.com/cad/dwf/) do AutoCAD e renderizá-las como um desenho inteiro para formato [BMP](https://docs.fileformat.com/image/bmp/). A abordagem de conversão de [DWF](https://docs.fileformat.com/cad/dwf/) para [BMP](https://docs.fileformat.com/image/bmp/) funciona da seguinte forma:

1. Carregue o arquivo de desenho [DWF](https://docs.fileformat.com/cad/dwf/) usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **BmpOptions** e defina a propriedade **vector_rasterization_options**.
1. Chame **Image.save** passando um objeto de **BmpOptions** como segundo parâmetro.

### Exemplo de Código

O exemplo de código abaixo mostra como converter um arquivo [DWF](https://docs.fileformat.com/cad/dwf/) para [BMP](https://docs.fileformat.com/image/bmp/) usando as configurações padrão.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
