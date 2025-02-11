---
title: Dibujos SVG
type: docs
weight: 170
url: /es/python-net/svg-drawings/
---

## **Exportar formato SVG a PDF**

Aspose.CAD para Python permite a los desarrolladores exportar un [SVG](https://docs.fileformat.com/page-description-language/svg/) a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [SVG](https://docs.fileformat.com/page-description-language/svg/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo SVG utilizando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **VectorRasterizationOptions**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

## Código de ejemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
