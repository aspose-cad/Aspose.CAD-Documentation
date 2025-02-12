---
title: Dibujos DXF
type: docs
weight: 60
url: /es/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportando Dibujos DXF a PDF**

Aspose.CAD proporciona la función de cargar las entidades de dibujo DXF de AutoCAD y renderizarlas como un dibujo completo en formato PDF. El enfoque de conversión de DXF a PDF funciona de la siguiente manera:

1. Cargar el archivo de dibujo DXF utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crear un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Formatos Soportados**

En este momento, soportamos completamente los formatos de archivo DXF de AutoCAD 2010. Las versiones anteriores de DXF no tienen garantía de ser 100% válidas. Planeamos incluir más formatos y características en futuras versiones de Aspose.CAD.

### **Entidades Soportadas**

En este momento, soportamos todas las entidades 2D ampliamente utilizadas y sus parámetros básicos predeterminados de la siguiente manera:

1. Dimensión Alineada
1. Dimensión Angular
1. Arco
1. Atributo
1. Referencia de Bloque
1. Círculo
1. Dimensión de Diámetro
1. Elipse
1. Hatch
1. Línea
1. Texto Multilínea
1. Dimensión Ordinada
1. Punto
1. Polilínea
1. Dimensión Radial
1. Rayo
1. Dimensión Rotada
1. Tabla
1. Texto
1. Xline

{{% alert color="primary" %}}

Si durante el análisis encontramos alguna entidad o propiedad que no soportamos, la entidad o propiedad será ignorada sin aviso.

{{% /alert %}}

### **Gestión de Memoria**

La propiedad [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) de la clase [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) se puede utilizar para controlar la reubicación de memoria. La reubicación es más probable que ocurra para cachés pre-asignados. Puede ocurrir cuando el sistema determina que el espacio asignado no será suficiente.

- Si [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) está establecido en el valor predeterminado, **False**, el espacio se reubica en el mismo medio.
- Cuando se establece en **True**, la reubicación no puede exceder el espacio máximo especificado. En este caso, la caché en memoria existente (que requiere reubicación) se libera y se asigna espacio extendido en disco.

## **Exportando una Capa Específica de Dibujos DXF a PDF**

Este enfoque funciona de la siguiente manera:

1. Abrir un archivo de dibujo DXF utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crear una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y especificar las propiedades [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) y [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Agregar capas al objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crear una instancia de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Llamar al método [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) y pasar el objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

El siguiente ejemplo de código muestra cómo convertir una capa específica de DXF a PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Renderizar archivos PDF como parte de dibujos DXF**

Este enfoque funciona de la siguiente manera:

1. Cargar el archivo de dibujo DXF utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y cargar archivos PDF.
1. Establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) y guardar el archivo.

El siguiente ejemplo de código muestra cómo renderizar archivos PDF como parte de dibujos DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Exportar la superposición DGN incrustada para el formato DXF**

Aspose.CAD proporciona la función de cargar archivos DXF de AutoCAD y exportar la superposición DGN incrustada para el formato DXF.

El siguiente ejemplo de código muestra cómo lograr los requisitos especificados.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Soporte para Guardar Archivos DXF**

Aspose.CAD proporciona la función de cargar archivos DXF de AutoCAD, realizar cambios en ellos y guardarlos nuevamente como un archivo DXF.

El siguiente ejemplo de código muestra cómo lograr los requisitos especificados.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Exportar DXF a WMF**

Este enfoque funciona de la siguiente manera:

1. Cargar el archivo de dibujo DXF utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y cargar archivos PDF.
1. Establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) y guardar el archivo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exportando un Layout DXF Específico a PDF**

Este enfoque funciona de la siguiente manera:

1. Abrir un archivo de dibujo DXF utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crear una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y especificar las propiedades [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) y [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Especificar el nombre(s) de layout deseado(s) utilizando la propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Crear una instancia de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportar el dibujo a PDF llamando al método [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) y pasando el objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

El siguiente ejemplo de código muestra cómo convertir un layout específico de DXF a PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

La propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) es de tipo arreglo de cadenas, por lo que se pueden especificar más de un layout a la vez para posible conversión a formato PDF. Al especificar múltiples layouts para la propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), el PDF resultante tendrá múltiples páginas, donde cada página representa un layout individual de AutoCAD.

{{% /alert %}}

## **Soporte para Recorte de Bloques**

Aspose.CAD proporciona la función de Recorte de Bloques. El enfoque de Recorte de Bloques funciona de la siguiente manera:

1. Cargar el archivo de dibujo DXF utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y cargar archivos PDF.
1. Establecer las propiedades deseadas de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro y guardar el archivo.

El siguiente ejemplo de código muestra cómo funciona el Recorte de Bloques.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Exportar Imágenes a DXF**

Usando Aspose.CAD, puedes exportar imágenes a formato DXF. Usando este enfoque, puedes realizar las siguientes acciones:

1. Establecer una nueva fuente
1. Ocultar entidades
1. Actualizar texto

El siguiente fragmento de código te muestra cómo realizar las acciones enumeradas anteriormente.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Exportando una Capa Específica de Dibujos DXF a Imagen**

Este enfoque funciona de la siguiente manera:

1. Abrir un archivo de dibujo DXF utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crear una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y especificar las propiedades [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) y [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Agregar capas al objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crear una instancia de [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) y establecer su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportar el dibujo a PDF utilizando el método [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

El siguiente ejemplo de código muestra cómo convertir una capa específica de DXF a Imagen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
