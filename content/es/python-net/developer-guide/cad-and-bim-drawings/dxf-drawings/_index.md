---
title: Dibujos DXF
type: docs
weight: 10
url: /es/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportando dibujos DXF a PDF**

Aspose.CAD proporciona la función de cargar entidades de dibujo DXF de AutoCAD y renderizarlas como un dibujo completo en formato PDF. El enfoque de conversión de DXF a PDF funciona de la siguiente manera:

1. Cargar el archivo de dibujo DXF usando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y establecer las propiedades **page_height** y **page_width**.
1. Crear un objeto de la clase **PdfOptions** y establecer la propiedad **VectorRasterizationOptions**.
1. Llamar a **Image.save** pasando un objeto de **PdfOptions** como segundo parámetro.

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Formatos soportados**

En este momento, apoyamos completamente los formatos de archivo DXF 2010 de AutoCAD. Las versiones anteriores de DXF no están garantizadas al 100% válidas. Planeamos incluir más formatos y características en futuras versiones de Aspose.CAD.

### **Entidades soportadas**

En este momento, apoyamos todas las entidades 2D generalizadas y sus parámetros básicos predeterminados de la siguiente manera:

1. Dimensión alineada
1. Dimensión angular
1. Arco
1. Atributo
1. Referencia de bloque
1. Círculo
1. Dimensión de diámetro
1. Elipse
1. Hatch
1. Línea
1. Texto en varias líneas
1. Dimensión ordinada
1. Punto
1. Polilínea
1. Dimensión radial
1. Rayo
1. Dimensión rotada
1. Tabla
1. Texto
1. Xline

{{% alert color="primary" %}}

Si durante el análisis encontramos alguna entidad o propiedad que no soportamos, la entidad o propiedad será ignorada silenciosamente.

{{% /alert %}}

## **Exportar superposición DGN embebida para formato DXF**

Aspose.CAD proporciona la función de cargar archivos DXF de AutoCAD y exportar superposiciones DGN embebidas para el formato DXF.

El siguiente ejemplo de código muestra cómo lograr los requisitos especificados.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Soporte para guardar archivos DXF**

Aspose.CAD proporciona la función de cargar archivos DXF de AutoCAD, realizar cambios en ellos y guardarlos nuevamente como un archivo DXF.

El siguiente ejemplo de código muestra cómo lograr los requisitos especificados.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Exportar DXF a WMF**

Este enfoque funciona de la siguiente manera:

1. Cargar el archivo de dibujo DXF usando el método de fábrica **Image.load**.
1. Crear un objeto de la clase **CadRasterizationOptions** y cargar archivos PDF.
1. Establecer las propiedades **page_height** y **page_width**.
1. Llamar a **Image.save** y guardar el archivo.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
