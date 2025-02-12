---
title: Dibujos DXF
type: docs
weight: 60
url: /es/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Exportando Dibujos DXF a PDF**

Aspose.CAD proporciona la función de cargar entidades de dibujo DXF de AutoCAD y renderizarlas como un dibujo completo en formato PDF. El enfoque de conversión de DXF a PDF funciona de la siguiente manera:

1. Carga el archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y establece las propiedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) y [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crea un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) y establece la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Llama a Image.Save pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como segundo parámetro.

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Formatos Soportados**

En este momento, soportamos completamente los formatos de archivo DXF de AutoCAD 2010. Las versiones anteriores de DXF no están garantizadas para ser 100% válidas. Estamos planeando incluir más formatos y características en futuras versiones de Aspose.CAD.

### **Entidades Soportadas**

En este momento, soportamos todas las entidades 2D ampliamente utilizadas y sus parámetros básicos predeterminados como sigue:

1. Dimensión Alineada
1. Dimensión Angular
1. Arco
1. Atributo
1. Referencia de Bloque
1. Círculo
1. Dimensión de Diámetro
1. Elipse
1. Sombreado
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

Si durante el análisis encontramos alguna entidad o propiedad que no soportamos, la entidad o propiedad será ignorada silenciosamente.

{{% /alert %}}

### **Gestión de Memoria**

La propiedad [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) se puede utilizar para controlar la realocación de memoria. La realocación es más probable que ocurra para cachés prealocados. Puede ocurrir cuando el sistema determina que el espacio asignado no será suficiente.

- Si se establece [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) en el valor predeterminado, **False**, el espacio se vuelve a asignar al mismo medio.
- Cuando se establece en **True**, la realocación no puede exceder el espacio máximo especificado. En este caso, el caché en memoria existente (que requiere realocación) se libera y se asigna espacio extendido en el disco.

## **Exportando Capa Específica de Dibujos DXF a PDF**

Este enfoque funciona de la siguiente manera:

1. Abre un archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y especifica las propiedades [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) y [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Agrega capas al objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crea una instancia de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) y establece su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporta el dibujo a PDF utilizando el método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

El siguiente ejemplo de código muestra cómo convertir una capa específica de DXF a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exportando Capa Específica de Dibujos DXF a Imagen**

Este enfoque funciona de la siguiente manera:

1. Abre un archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y especifica las propiedades [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) y [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Agrega capas al objeto de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crea una instancia de [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) y establece su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporta el dibujo a PDF utilizando el método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

El siguiente ejemplo de código muestra cómo convertir una capa específica de DXF a Imagen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Renderizar Archivos PDF como Parte de Dibujos DXF**

Este enfoque funciona de la siguiente manera:

1. Carga un archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y carga archivos PDF.
1. Establece las propiedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) y [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Llama a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) y guarda el archivo.

El siguiente ejemplo de código muestra cómo renderizar archivos PDF como parte de dibujos DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Exportar DXF a WMF**

Este enfoque funciona de la siguiente manera:

1. Carga un archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y carga archivos PDF.
1. Establece las propiedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) y [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Llama a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) y guarda el archivo.

El siguiente ejemplo de código muestra cómo exportar DXF a WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Soporte para Guardar Archivos DXF**

Aspose.CAD proporciona la función de cargar archivos DXF de AutoCAD, realizar cambios en ellos y guardarlos nuevamente como un archivo DXF. El siguiente ejemplo de código muestra cómo lograr los requisitos especificados.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Exportar Subyacente DGN Embebido para el Formato DXF**

Aspose.CAD proporciona la función de cargar archivos DXF de AutoCAD y exportar la subyacente DGN embebida para el formato DXF.

El siguiente ejemplo de código muestra cómo lograr los requisitos especificados.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Exportando Diseño DXF Específico a PDF**

Este enfoque funciona de la siguiente manera:

1. Abre un archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y especifica las propiedades [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) y [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Especifica el(los) nombre(s) de diseño deseado(s) utilizando la propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Crea una instancia de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) y establece su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exporta el dibujo a PDF utilizando el método [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

El siguiente ejemplo de código muestra cómo convertir un diseño específico de DXF a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

La propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) es de tipo matriz de cadenas, por lo que puedes especificar más de un diseño a la vez para posible conversión a formato PDF. Al especificar múltiples diseños para la propiedad [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), el PDF resultante tendría múltiples páginas, donde cada página representa un diseño individual de AutoCAD.

{{% /alert %}}

## **Acceder a Objetos ATTRIB y MTEXT**

Este enfoque funciona de la siguiente manera:

1. Abre un archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Accede a las entidades dentro del archivo CAD.
1. Comprueba las entidades [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) y [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Añade a la lista temporal para su posterior procesamiento.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Descomponer Objetos de Inserción CAD**

Este enfoque funciona de la siguiente manera:

1. Abre un archivo de dibujo **DXF** utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Accede a las entidades dentro del archivo CAD.
1. Comprueba las entidades [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Comprueba la lista de tipos [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Procesa las entidades.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Soporte de Recorte de Bloques**

Aspose.CAD proporciona la función de Recorte de Bloques. El enfoque de Recorte de Bloques funciona de la siguiente manera:

1. Carga un archivo de dibujo DXF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y carga archivos PDF.
1. Establece las propiedades deseadas de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Llama a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como segundo parámetro y guarda el archivo.

El siguiente ejemplo de código muestra cómo funciona el Recorte de Bloques.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Exportar Imágenes a DXF**

Usando Aspose.CAD, puedes exportar imágenes al formato DXF. Usando este enfoque, puedes realizar las siguientes acciones:

1. Establecer nueva fuente
1. Ocultar entidades
1. Actualizar texto

El siguiente fragmento de código muestra cómo realizar las acciones mencionadas anteriormente.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
