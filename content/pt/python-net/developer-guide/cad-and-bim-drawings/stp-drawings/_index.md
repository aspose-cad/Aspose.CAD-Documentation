---
title: Desenhos STP
type: docs
weight: 160
url: /pt/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportando o Formato STP para PDF**

Aspose.CAD para Python permite que os desenvolvedores exportem um arquivo [STP](https://docs.fileformat.com/3d/stp/) para o formato [PDF](https://docs.fileformat.com/pdf/). A abordagem de conversão de [STP](https://docs.fileformat.com/3d/stp/) para [PDF](https://docs.fileformat.com/pdf/) funciona da seguinte forma:

1. Carregue o arquivo de desenho [STP](https://docs.fileformat.com/3d/stp/) usando o método de fábrica **Image.load**.
1. Crie um objeto da classe **CadRasterizationOptions** e defina as propriedades **page_height** e **page_width**.
1. Crie um objeto da classe **PdfOptions** e defina a propriedade **vector_rasterization_options**.
1. Chame **Image.save** passando um objeto de **PdfOptions** como segundo parâmetro.

## Código de Exemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
