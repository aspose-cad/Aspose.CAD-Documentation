---
title: Dibujos FBX
type: docs
weight: 70
url: /es/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exportando Formato FBX a PDF**

Aspose.CAD para .NET permite a los desarrolladores exportar un archivo [FBX](https://docs.fileformat.com/3d/fbx/) a formato [PDF](https://docs.fileformat.com/pdf/). El enfoque de conversión de [FBX](https://docs.fileformat.com/3d/fbx/) a [PDF](https://docs.fileformat.com/pdf/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [FBX](https://docs.fileformat.com/3d/fbx/) utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crear un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

## Código de Ejemplo

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
