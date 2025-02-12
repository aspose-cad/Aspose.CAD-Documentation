---
title: Dibujo DWF
type: docs
weight: 20
url: /es/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Exportando Dibujos DWF a PDF**

Aspose.CAD para Java API puede cargar dibujos de AutoCAD en formato DWF y convertirlos a PDF. Este tema explica el uso de la API de Aspose.CAD para lograr la conversión de DWF a formato PDF a través de pasos simples como se define a continuación.

### **Convertir Archivos DWF a PDF**

Se requieren los siguientes pasos simples para convertir DWF a PDF.

1. Cargar el archivo DWF en una instancia de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y establecer las propiedades [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) y [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crear un objeto de la clase [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) y establecer la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Llamar a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) pasando un objeto de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) como segundo parámetro.

El siguiente ejemplo de código muestra cómo exportar un dibujo DWF a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Soporte de Capas en DWF**

Aspose.CAD proporciona la función de cargar entidades de dibujo DWF de AutoCAD y renderizarlas como un dibujo completo en formato JPG.

1. Cargar el archivo de dibujo DWF utilizando el método de fábrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crear un objeto de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Agregar las capas deseadas.
1. Llamar a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) pasando un objeto de [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) como segundo parámetro.

El siguiente ejemplo de código muestra cómo convertir un archivo utilizando la configuración predeterminada.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
