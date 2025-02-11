---
title: Dibujos DWF
type: docs
weight: 50
url: /es/python-net/dwf-drawings/
---

## **Exportando Dibujos DWF a PDF**

Aspose.CAD proporciona la función de cargar entidades de dibujo de AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) y renderizarlas como un dibujo completo en formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [DWF](https://docs.fileformat.com/cad/dwf/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) utilizando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **vector_rasterization_options**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

### Código de Ejemplo

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Exportando Dibujos DWF a BMP**

Aspose.CAD proporciona la función de cargar entidades de dibujo de AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) y renderizarlas como un dibujo completo en formato [BMP](https://docs.fileformat.com/image/bmp/). El enfoque de conversión de [DWF](https://docs.fileformat.com/cad/dwf/) a [BMP](https://docs.fileformat.com/image/bmp/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) utilizando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **BmpOptions** y establecer la propiedad **vector_rasterization_options**.
1. Llamar a **Image.save** pasando un objeto de **BmpOptions** como segundo parámetro.

### Código de Ejemplo

El siguiente ejemplo de código muestra cómo convertir un archivo [DWF](https://docs.fileformat.com/cad/dwf/) a [BMP](https://docs.fileformat.com/image/bmp/) utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
