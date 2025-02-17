---
title: DWF Rajzok
type: docs
weight: 20
url: /hu/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **DWF Rajzok PDF-be exportálása**

Az Aspose.CAD for Java API képes DWF formátumú AutoCAD rajzokat betölteni, és PDF-be konvertálni. Ez a téma bemutatja az Aspose.CAD API használatát a DWF PDF formátumra való átalakítására egyszerű lépésekben, ahogy az alább meghatározva van.

### **DWF Fájlok PDF-re konvertálása**

A DWF PDF-re történő konvertálásához az alábbi egyszerű lépések szükségesek.

1. Töltse be a DWF fájlt egy [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) példányba.
2. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból, és állítsa be a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) és [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) tulajdonságokat.
3. Hozzon létre egy objektumot a [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) osztályból, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságot.
4. Hívja meg a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust, miközben egy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) objektumot ad át második paraméterként.

Az alábbi kódrészlet bemutatja, hogyan lehet DWF rajzokat PDF-be exportálni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Rétegek támogatása DWF-ben**

Az Aspose.CAD lehetőséget nyújt AutoCAD DWF rajz entitások betöltésére és azok teljes rajzként JPG formátumba való renderelésére.

1. Töltse be a DWF rajz fájlt a [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) gyári metódussal.
2. Hozzon létre egy objektumot a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztályból.
3. Adja hozzá a kívánt rétegeket.
4. Hívja meg a [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metódust, miközben egy [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) objektumot ad át második paraméterként.

Az alábbi kódrészlet bemutatja, hogyan lehet egy fájlt konvertálni az alapértelmezett beállításokkal.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
