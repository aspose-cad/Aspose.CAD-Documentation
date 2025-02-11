---
title: Dibujos 3DS
type: docs
weight: 70
url: /es/net/3ds-drawings/
---

## **Exportando formato 3DS a PDF**

Aspose.CAD para .NET permite a los desarrolladores exportar un archivo [3DS](https://docs.fileformat.com/3d/3ds/) al formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [3DS](https://docs.fileformat.com/3d/3ds/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargue el archivo de dibujo [3DS](https://docs.fileformat.com/3d/3ds/) usando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Cree un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establezca las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Cree un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establezca la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Llame a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

## Código de ejemplo

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
