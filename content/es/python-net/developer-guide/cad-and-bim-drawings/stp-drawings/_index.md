---
title: Dibujos STP
type: docs
weight: 160
url: /es/python-net/stp-drawings/
---

## **Exportando formato STP a PDF**

Aspose.CAD para Python permite a los desarrolladores exportar un [STP](https://docs.fileformat.com/3d/stp/) archivo al formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [STP](https://docs.fileformat.com/3d/stp/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [STP](https://docs.fileformat.com/3d/stp/) usando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **vector_rasterization_options**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

## Código de muestra

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
