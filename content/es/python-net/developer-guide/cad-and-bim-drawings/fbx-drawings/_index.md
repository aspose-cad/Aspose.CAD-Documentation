---
title: Dibujos FBX
type: docs
weight: 110
url: /es/python-net/fbx-drawings/
---

## **Exportando Formato FBX a PDF**

Aspose.CAD para Python permite a los desarrolladores exportar un archivo [FBX](https://docs.fileformat.com/3d/fbx/) a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [FBX](https://docs.fileformat.com/3d/fbx/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [FBX](https://docs.fileformat.com/3d/fbx/) utilizando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **PageHeight** y **PageWidth**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **vector_rasterization_options**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

## Código de Ejemplo

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
