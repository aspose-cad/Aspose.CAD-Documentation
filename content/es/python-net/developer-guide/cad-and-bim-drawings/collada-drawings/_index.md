---
title: COLLADA Drawings
type: docs
weight: 20
url: /es/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Exportando el formato COLLADA a PDF**

Aspose.CAD para Python permite a los desarrolladores exportar un archivo [COLLADA](https://docs.fileformat.com/3d/dae/) a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [COLLADA](https://docs.fileformat.com/3d/dae/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [COLLADA](https://docs.fileformat.com/3d/dae/) utilizando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **vector_rasterization_options**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

## Código de ejemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
