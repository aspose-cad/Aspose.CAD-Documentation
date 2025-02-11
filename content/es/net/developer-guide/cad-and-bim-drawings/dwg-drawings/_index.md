---
title: DWG Drawings
type: docs
weight: 40
url: /es/net/dwg-drawings/
---

## **Exportando Dibujos DWG a PDF**

Aspose.CAD para .NET API puede cargar dibujos de AutoCAD en formato [DWG](https://docs.fileformat.com/cad/dwg/) y convertirlos a [PDF](https://docs.fileformat.com/pdf/). Este tema explica el uso de la API Aspose.CAD para lograr la conversión de DWG a formato PDF a través de simples pasos definidos a continuación.

{{% alert color="primary" %}}

La API soporta las siguientes revisiones DWG de AutoCAD:

- DWG 2004 versión 16.0 lanzamiento 18
- DWG 2005 versión 16.1
- DWG 2010 versión 18.0
- DWG 2013 versión 19.0

{{% /alert %}}

### **Formato de Archivo DWG**

Un [DWG](https://docs.fileformat.com/cad/dwg/) es un archivo binario que contiene datos de imagen vectorial y metadatos. Los datos de imagen vectorial proporcionan instrucciones a la aplicación CAD sobre cómo mostrar el DWG; los metadatos pueden contener una variedad de información sobre el archivo, incluyendo datos específicos de la ubicación y también datos del cliente. Las especificaciones abiertas para el formato de archivo DWG se pueden encontrar [en este PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertir Archivos DWG a PDF**

Los siguientes pasos simples son necesarios para convertir [DWG](https://docs.fileformat.com/cad/dwg/) a [PDF](https://docs.fileformat.com/pdf/).

1. Cargar el archivo DWG en una instancia de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) y [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crear un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Llamar a [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) como segundo parámetro.

El siguiente fragmento de código muestra cómo exportar dibujos DWG a PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Crear Un Solo PDF con Diferentes Tamaños de Diseño**

Aspose.CAD para .NET te permite convertir un archivo DWG en un solo PDF con diferentes tamaños de diseño. Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG utilizando el método de fábrica [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crear una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establecer la altura y el ancho de la página resultante.
1. Agregar los [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) requeridos para el objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crear una instancia de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportar la imagen a PDF utilizando el método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

El siguiente fragmento de código muestra cómo crear un [PDF](https://docs.fileformat.com/pdf/) único con diferentes diseños.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Primitivas de AutoCAD Soportadas**

Las siguientes primitivas de AutoCAD son soportadas.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Exportando un Diseño DWG Específico a PDF**

Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG utilizando el método de fábrica [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crear una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establecer la altura y el ancho de la página resultante.
1. Establecer la propiedad [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) para el objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crear una instancia de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y establecer su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportar la imagen a PDF utilizando el [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) método.

El siguiente fragmento de código muestra cómo convertir un diseño específico de DWG a PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Renderizar Documento DWG Especificando Coordenadas**

Aspose.CAD para .NET API ahora proporciona una función para renderizar documentos DWG proporcionando coordenadas de la altura y el ancho del documento.

El siguiente fragmento de código muestra cómo renderizar un documento DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Exportando DWG a Raster o PDF usando Tamaño Fijo**

Aspose.CAD para .NET API puede cargar dibujos de AutoCAD en formato DWG y convertirlos a PDF o Raster usando un tamaño fijo.

El siguiente fragmento de código muestra cómo implementar esta función.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Exportando DWG a PDF/A y PDF/E**

Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG utilizando el [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) método de fábrica.
1. Crear una instancia de la [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) clase.
1. Crear una instancia de la [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) clase y establecer su [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) propiedad.
1. Establecer la propiedad de cumplimiento PDF y guardarlo.
1. Exportar la imagen a PDF usando el [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) método.

El siguiente fragmento de código muestra cómo convertir un archivo DWG a PDF/A y PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Soporte para líneas ocultas redondeadas al exportar DWG/DXF a BMP y PDF**

Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG utilizando el [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) método de fábrica.
1. Crear una instancia de la [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) clase y establecer la altura y el ancho de la página resultante.
1. Crear una instancia de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) clase y establecer su [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) propiedad.
1. Exportar la imagen a PDF usando el [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) método.

El siguiente fragmento de código muestra cómo implementar esta función.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Soporte para establecer área de impresión para imagen DWG en PDF exportado**

Aspose.CAD para .NET API puede cargar dibujos de AutoCAD en formato DWG y convertirlos a PDF. Este tema explica el uso de la API Aspose.CAD para lograr el soporte para establecer un área de impresión para la imagen DWG en el PDF exportado.

El siguiente fragmento de código muestra cómo implementar esta función.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Soporte para leer metadatos XREF para archivo DWG**

1. Cargar un archivo DWG utilizando el [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) método de fábrica.
1. Recorrer cada entidad de imagen.
1. Si una entidad es CadUnderlay, entonces la entidad XREF con metadatos.

El siguiente fragmento de código muestra cómo lograr esta función.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

La propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) es de tipo arreglo de cadenas, por lo que puedes especificar más de un diseño a la vez para posible conversión a formato PDF. Al especificar múltiples diseños para la propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), el PDF resultante tendría múltiples páginas, donde cada página representa un diseño de AutoCAD individual.

### **Listar Todos los Diseños**

Puedes listar todos los diseños presentes en un dibujo de AutoCAD utilizando el siguiente fragmento de código.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Accediendo a las Bandas de Subfondo para el Formato DWG**

Aspose.CAD para .NET ha implementado las banderas de subfondo para el formato DWG y permite a los desarrolladores acceder a ellas. A continuación, se presenta una demostración simple de código.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Soporte para Entidades DWG**

Aspose.CAD para .NET API puede cargar dibujos de AutoCAD en formato DWG y soportar diferentes entidades para trabajar.

### **Soporte para la Entidad MLeader**

Un DWG es un archivo binario que contiene datos de imagen vectorial y metadatos. Hay diferentes entidades en un archivo DWG. La siguiente sección describe un ejemplo de trabajo con la entidad MLeader dentro del archivo DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Soporte para Exportar Entidad DWG a Imagen**

Un DWG es un archivo binario que contiene datos de imagen vectorial y metadatos. Hay diferentes entidades en un archivo DWG. La siguiente sección describe un ejemplo de exportar una entidad DWG particular a la imagen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Soporte para Agregar Texto en DWG**

Aspose.CAD para .NET API puede cargar dibujos de AutoCAD en formato DWG y soportar diferentes entidades para trabajar. Un DWG es un archivo binario que contiene datos de imagen vectorial y metadatos. Hay diferentes entidades en un archivo DWG. La siguiente sección describe cómo podemos agregar texto dentro del archivo DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Soporte para Importar Imagen a Archivo DWG**

Aspose.CAD para .NET API puede cargar dibujos de AutoCAD en formato DWG y soportar diferentes entidades para trabajar. Un DWG es un archivo binario que contiene datos de imagen vectorial y metadatos. Hay diferentes entidades en un archivo DWG. La siguiente sección describe cómo podemos importar imágenes dentro del archivo DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Soporte para Malla en DWG**

Aspose.CAD para .NET API ahora puede acceder a las entidades que soportan malla, que incluyen tipos [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) y [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). El siguiente ejemplo describe cómo podemos acceder a los tipos de malla.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Convertir Dibujos DWG a DXF**

Aspose.CAD proporciona la función de cargar un archivo DWG de AutoCAD y exportarlo a formato DXF. El enfoque de conversión de DWG a DXF funciona de la siguiente manera:

1. Cargar el archivo de dibujo DWG utilizando el método de fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Exportar el dibujo DWG a DXF utilizando el método [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

El siguiente fragmento de código muestra cómo convertir un archivo DWG a un formato DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Convertir Dibujos DWG a SVG**

Aspose.CAD para .NET API puede cargar dibujos de AutoCAD en formato DWG y convertirlos a SVG. Este tema explica el uso de la API Aspose.CAD para lograr la conversión de DWG a formato SVG a través de simples pasos definidos a continuación.

1. Cargar el archivo DWG en una instancia de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Crear un objeto de la clase [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) y establecer las propiedades requeridas.
1. Exportar el dibujo DWG a SVG utilizando el [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) método.

El siguiente fragmento de código muestra cómo convertir un archivo DWG a formato SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Cargar Archivo DWG Grande**

Aspose.CAD para .NET proporciona la facilidad de abrir archivos DWG muy grandes utilizando la clase [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Ahora puedes abrir archivos grandes fácilmente con la ayuda del código de ejemplo dado a continuación.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
