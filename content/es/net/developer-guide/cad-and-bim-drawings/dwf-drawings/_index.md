---
title: Dibujo DWF
type: docs
weight: 20
url: /es/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exportar Dibujo DWF a PDF**

Aspose.CAD proporciona la función de cargar entidades de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) de AutoCAD y representarlas como un dibujo completo en formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [DWF](https://docs.fileformat.com/cad/dwf/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargue el archivo de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) usando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Cree un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establezca las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Cree un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establezca la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Llame a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

### Código de Ejemplo

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Extraer Capas del Dibujo DWF**

Aspose.CAD proporciona la función de cargar entidades de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) de AutoCAD y representarlas como un dibujo completo en formato [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Cargue el archivo de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) usando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Cree un objeto de la clase [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
3. Cree un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
4. Extraiga el nombre de las capas utilizando el objeto [JPEG](https://docs.fileformat.com/image/jpeg/).
5. Llame a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) como segundo parámetro.

### Código de Ejemplo

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Soporte de Capas en DWF**

Aspose.CAD proporciona la función de cargar entidades de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) de AutoCAD y representarlas como un dibujo completo en formato [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Cargue el archivo de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) usando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Cree un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
3. Agregue las capas deseadas.
4. Llame a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) como segundo parámetro.

### Código de Ejemplo

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Exportar Dibujo DWF a BMP**

Aspose.CAD proporciona la función de cargar entidades de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) de AutoCAD y representarlas como un dibujo completo en formato [BMP](https://docs.fileformat.com/image/bmp/). El enfoque de conversión de [DWF](https://docs.fileformat.com/cad/dwf/) a [BMP](https://docs.fileformat.com/image/bmp/) funciona de la siguiente manera:

1. Cargue el archivo de dibujo [DWF](https://docs.fileformat.com/cad/dwf/) usando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Cree un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establezca las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Cree un objeto de la clase [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) y establezca la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Llame a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) como segundo parámetro.

### Código de Ejemplo

El siguiente ejemplo de código muestra cómo convertir un archivo [DWF](https://docs.fileformat.com/cad/dwf/) a [BMP](https://docs.fileformat.com/image/bmp/) utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
