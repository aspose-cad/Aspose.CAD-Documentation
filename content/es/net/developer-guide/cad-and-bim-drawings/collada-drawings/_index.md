---
title: Dibujos COLLADA
type: docs
weight: 70
url: /es/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Exportando el formato COLLADA a PDF**

Aspose.CAD para .NET permite a los desarrolladores exportar un archivo [COLLADA](https://docs.fileformat.com/3d/dae/) a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [COLLADA](https://docs.fileformat.com/3d/dae/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargue el archivo de dibujo [COLLADA](https://docs.fileformat.com/3d/dae/) utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Cree un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y configure las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Cree un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y configure la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Llame a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

## Código de ejemplo

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
