```markdown
---
title: Dibujos DWG
type: docs
weight: 40
url: /es/java/dwg-drawings/
---

## **Exportando Dibujos DWG a PDF**

Aspose.CAD para Java API puede cargar dibujos de AutoCAD en formato DWG y convertirlo a PDF. Este tema explica el uso de la API de Aspose.CAD para lograr la conversión de DWG a formato PDF a través de simples pasos como se define a continuación.

{{% alert color="primary" %}}

La API soporta las siguientes revisiones de AutoCAD DWG:

- DWG 2004 versión 16.0 lanzamiento 18
- DWG 2005 versión 16.1
- DWG 2010 versión 18.0
- DWG 2013 versión 19.0

{{% /alert %}}

### **Formato de Archivo DWG**

Un DWG es un archivo binario que contiene datos de imagen vectorial y metadatos. Los datos de imagen vectorial proporcionan instrucciones a la aplicación CAD sobre cómo mostrar el DWG; los metadatos pueden contener una variedad de información sobre el archivo, incluidos datos específicos de la ubicación y también datos del cliente. Las Especificaciones Abiertas para el formato de archivo DWG se pueden encontrar [en este PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertir Archivos DWG a PDF**

Se requieren los siguientes pasos simples para convertir DWG a PDF.

1. Cargar el archivo DWG en una instancia de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crear un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) y establecer la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Llamar al método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) y pasar el objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como segundo parámetro.

El siguiente ejemplo de código muestra cómo exportar Dibujos DWG a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Crear un PDF Único con Diferentes Tamaños de Diseño**

Aspose.CAD para Java te permite convertir el archivo DWG a un único PDF con diferentes tamaños de diseño. Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG usando el método de fábrica [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crear una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y establecer la altura y ancho de página resultantes.
1. Agregar los [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) requeridos para el objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crear una instancia de la clase [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) y establecer su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportar la imagen a PDF usando el método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

El siguiente ejemplo de código muestra cómo crear un PDF único con diferentes diseños.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Exportando DWG a PDF/A y PDF/E**

Se requieren los siguientes pasos simples para convertir DWG a PDF.

1. Cargar el archivo DWG en una instancia de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crear un objeto de la [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) clase y establecer las [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) propiedades.
1. Crear un objeto de la [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) clase y establecer la [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) propiedad.
1. Llamar al [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) método y pasar el objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como el segundo parámetro.

El siguiente ejemplo de código muestra cómo exportar Dibujos DWG a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Primitivas de AutoCAD Soportadas**

Las siguientes primitivas de AutoCAD son soportadas.

- TEXTO
- MTEXT
- ATTDEF
- ATTRIB
- ARCO
- ELIPSE
- HATCH
- LÍDER
- PUNTO
- VÉRTICE 2D
- VÉRTICE 3D
- POLILÍNEA 2D
- LWPOLYLINE
- RAYO
- CÍRCULO
- DIMENSIÓN ORDENADA
- DIMENSIÓN LINEAL
- DIMENSIÓN ALINEADA
- DIMENSIÓN ÁNGULO 3Pt
- DIMENSIÓN ÁNGULO 2Ln
- DIMENSIÓN RADIO
- DIMENSIÓN DIÁMETRO
- FORMA
- SÓLIDO
- SPLINE
- MLINE
- LÍNEA
- XLINE
- ESTILO
- DIMSTYLE
- LTYPE
- MLINESTYLE
- CAPA
- VISTA
- DISEÑO

## **Exportando Diseño DWG Específico a PDF**

Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG usando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crear una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y establecer la altura y ancho de página resultantes.
1. Establecer la propiedad [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) para el objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crear una instancia de la clase [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) y establecer su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportar la imagen a PDF usando el método [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) método.

El siguiente ejemplo de código muestra cómo convertir un diseño específico de DWG a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Exportando DWG a Raster o PDF usando Tamaño Fijo**

Aspose.CAD para Java API puede cargar dibujos de AutoCAD en formato DWG, y convertirlo a PDF o Raster usando tamaño fijo.

El siguiente ejemplo de código muestra cómo implementar esta función.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Soporte para líneas ocultas redondeadas al exportar DWG/DXF a BMP y PDF**

Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG usando el [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) método de fábrica.
1. Crear una instancia de la [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) clase.
1. Crear una instancia de la [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) clase y establecer la altura y ancho de página resultantes.
1. Crear una instancia de la [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) clase y establecer su [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) propiedad.
1. Exportar la imagen a PDF usando el [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) método.

El siguiente ejemplo de código muestra cómo implementar esta función.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Soporte para establecer área de impresión para imagen DWG en PDF exportado**

Aspose.CAD para Java API puede cargar dibujos de AutoCAD en formato DWG y convertirlo a PDF. Este tema explica el uso de la API Aspose.CAD para lograr el soporte para establecer un área de impresión para la imagen DWG en el PDF exportado.

El siguiente ejemplo de código muestra cómo implementar esta función.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Soporte para leer metadatos XREF para archivo DWG**

1. Cargar un archivo DWG usando el [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) método de fábrica.
1. Recorrer cada entidad de imagen.
1. Si la entidad es [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), entonces entidad XREF con metadatos.

El siguiente ejemplo de código
