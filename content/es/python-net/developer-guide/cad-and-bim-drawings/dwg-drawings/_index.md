---
title: Dibujos DWG
type: docs
weight: 70
url: /es/python-net/dwg-drawings/
---

## **Exportando Dibujos DWG a PDF**

Aspose.CAD para la API de Python puede cargar dibujos de AutoCAD en formato [DWG](https://docs.fileformat.com/cad/dwg/) y convertirlo a [PDF](https://docs.fileformat.com/pdf/). Este tema explica el uso de la API de Aspose.CAD para lograr la conversión de DWG a PDF a través de pasos simples como se define a continuación.

{{% alert color="primary" %}}

La API es compatible con las siguientes revisiones de AutoCAD DWG:

- Versión 16.0 de DWG 2004 versión 18
- Versión 16.1 de DWG 2005
- Versión 18.0 de DWG 2010
- Versión 19.0 de DWG 2013

{{% /alert %}}

### **Formato de Archivo DWG**

Un [DWG](https://docs.fileformat.com/cad/dwg/) es un archivo binario que contiene datos de imagen vectorial y metadatos. Los datos de imagen vectorial proporcionan instrucciones a la aplicación CAD sobre cómo mostrar el DWG; los metadatos pueden contener una variedad de información sobre el archivo, incluidos datos específicos de la ubicación y datos del cliente. Las Especificaciones Abiertas para el formato de archivo DWG se pueden encontrar [en este PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertir Archivos DWG a PDF**

Los siguientes pasos simples son necesarios para convertir [DWG](https://docs.fileformat.com/cad/dwg/) a [PDF](https://docs.fileformat.com/pdf/).

1. Cargar el archivo DWG en una instancia de **Image**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **VectorRasterizationOptions**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

El siguiente ejemplo de código muestra cómo exportar dibujos DWG a PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Primitivas de AutoCAD Compatibles**

Las siguientes primitivas de AutoCAD son compatibles.

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
- DIMENSION LINEAL
- DIMENSION ALINEADA
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIO
- DIMENSION DIÁMETRO
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

## **Exportando Layout DWG Específico a PDF**

Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG usando el método de fábrica **Aspose.CAD.Image.load**.
1. Crear una instancia de la clase **CadRasterizationOptions** y establecer la altura y el ancho de la página resultante.
1. Configurar la propiedad **Layouts** para el objeto **CadRasterizationOptions**.
1. Crear una instancia de la clase **PdfOptions** y establecer su propiedad **VectorRasterizationOptions**.
1. Exportar la imagen a PDF usando el método **Image.save()**.

El siguiente ejemplo de código muestra cómo convertir un layout específico de DWG a PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Exportando DWG a PDF/A y PDF/E**

Este enfoque funciona de la siguiente manera:

1. Cargar un archivo DWG usando el método de fábrica **Image.load**.
1. Crear una instancia de la clase **CadRasterizationOptions**.
1. Crear una instancia de la clase **PdfOptions** y establecer su propiedad **VectorRasterizationOptions**.
1. Establecer la propiedad de cumplimiento de PDF y guardarlo.
1. Exportar la imagen a PDF usando el método **Image.save()**.

El siguiente ejemplo de código muestra cómo convertir un archivo DWG a PDF/A y PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Convertir Dibujos DWG a DXF**

Aspose.CAD proporciona la funcionalidad para cargar un archivo DWG de AutoCAD y exportarlo al formato DXF. El enfoque de conversión de DWG a DXF funciona de la siguiente manera:

1. Cargar el archivo de dibujo DWG usando el método de fábrica **Image.load**.
1. Exportar el dibujo DWG a DXF usando el método **Image.save()**.

El siguiente ejemplo de código muestra cómo convertir un archivo DWG a formato DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Convertir Dibujos DWG a SVG**

Aspose.CAD para la API de Python puede cargar dibujos de AutoCAD en formato DWG y convertirlo a SVG. Este tema explica el uso de la API de Aspose.CAD para lograr la conversión de DWG a formato SVG a través de pasos simples como se define a continuación.

1. Cargar el archivo DWG en una instancia de **Image**.
1. Crear un objeto de la clase **SvgOptions** y establecer las propiedades requeridas.
1. Exportar el dibujo DWG a SVG usando el método **Image.save()**.

El siguiente ejemplo de código muestra cómo convertir un archivo DWG a formato SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
