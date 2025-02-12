---
title: Dibujos STP
type: docs
weight: 70
url: /es/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportando el Formato STP a PDF**

Aspose.CAD para .NET permite a los desarrolladores exportar un archivo [STP](https://docs.fileformat.com/3d/stp/) a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [STP](https://docs.fileformat.com/3d/stp/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [STP](https://docs.fileformat.com/3d/stp/) utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crear un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

## Código de Ejemplo

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
