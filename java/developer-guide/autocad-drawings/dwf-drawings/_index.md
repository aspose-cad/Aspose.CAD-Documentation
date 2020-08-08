---
title: DWF Drawings
type: docs
weight: 20
url: /java/dwf-drawings/
---

## **Exporting DWF Drawings to PDF**
Aspose.CAD for Java API can load AutoCAD drawings in DWF format, and convert it to PDF. This topic explains the usage of Aspose.CAD API to achieve the conversion of DWF to PDF format through simple steps as defined ahead.
### **Convert DWF Files to PDF**
The following simple steps are required to convert DWF to PDF.

1. Load the DWF file into an instance of [**Image**](https://apireference.aspose.com/java/cad/com.aspose.cad/Image).
1. Create an object of the [**CadRasterizationOptions**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) class and set the [**PageHeight**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) properties.
1. Create an object of the [**PdfOptions**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/PdfOptions) class and set the [**VectorRasterizationOptions**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/VectorRasterizationOptions) property.
1. Call [**Image.save**](https://apireference.aspose.com/java/cad/com.aspose.cad/Image#save--) while passing an object of [**PdfOptions**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/PdfOptions) as the second parameter.

The code sample below shows how to export a DWF Drawings to PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}


### **Support of Layers in DWF**
Aspose.CAD provides the feature to load AutoCAD DWF drawing entities and render them as an entire drawing to JPG format. 

1. Load DWF drawing file using the [**Image.load**](https://apireference.aspose.com/java/cad/com.aspose.cad/Image#load-java.io.InputStream-) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) class.
1. Add desired layers.
1. Call [**Image.save**](https://apireference.aspose.com/java/cad/com.aspose.cad/Image#save--) while passing an object of [**JPEGOptions**](https://apireference.aspose.com/java/cad/com.aspose.cad.imageoptions/JpegOptions)** **as second parameter.

The code sample below shows how to convert a file using default settings.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
