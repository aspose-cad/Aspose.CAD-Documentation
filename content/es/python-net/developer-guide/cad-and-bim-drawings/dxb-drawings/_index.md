---
title: DXB Drawings
type: docs
weight: 90
url: /es/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exportando formato DXB a PDF**

Aspose.CAD para Python permite a los desarrolladores exportar un archivo DXB a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de DXB a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo DXB utilizando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **vector_rasterization_options**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

## Código de ejemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
