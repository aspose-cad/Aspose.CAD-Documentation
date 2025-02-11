---
title: DRC Drawings
type: docs
weight: 15
url: /es/net/drc-drawings/
---

## **Exportando Dibujos DRC a PDF**

Aspose.CAD proporciona la función para cargar entidades de dibujo de AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) y renderizarlas como un dibujo completo en formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [DRC](https://docs.fileformat.com/3d/drc/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [DRC](https://docs.fileformat.com/3d/drc/) utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crear un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

### Código de Ejemplo

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
