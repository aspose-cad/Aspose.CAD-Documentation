---
title: DRC Drawings
type: docs
weight: 40
url: /es/python-net/drc-drawings/
---

## **Exportar formato DRC a PDF**

Aspose.CAD para Python permite a los desarrolladores exportar un archivo [DRC](https://docs.fileformat.com/3d/drc/) a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [DRC](https://docs.fileformat.com/3d/drc/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo DRC utilizando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y configurar las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **VectorRasterizationOptions**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

## Código de muestra

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
