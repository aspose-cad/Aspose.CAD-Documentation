---
title: Exportation du format DGN AutoCAD
type: docs
weight: 50
url: /fr/java/developer-guide/exporting-dgn-autocad/
---

## **Exporter le format DGN AutoCAD en PDF**

Aspose.CAD pour l'API Java a introduit la fonctionnalité pour charger un fichier AutoCAD [DGN](https://docs.fileformat.com/cad/dgn/) et le convertir en format [PDF](https://docs.fileformat.com/pdf/). La classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) sert à cet effet.

Vous devez charger un fichier DGN existant comme [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez différentes propriétés. Créez une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) et passez l'instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Maintenant, appelez la méthode [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) de l'instance de la classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Exemple de Code

Voici une démonstration du code pour convertir/exporter DGN en format PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Exporter le format DGN AutoCAD en format d'image raster**

Aspose.CAD pour l'API Java a introduit la fonctionnalité pour charger un fichier AutoCAD [DGN](https://docs.fileformat.com/cad/dgn/) et le convertir en une image raster. La classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) sert à cet effet.

Vous devez charger un fichier DGN existant comme [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez différentes propriétés. Créez une instance de la classe [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) et passez l'instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Maintenant, appelez la méthode [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) de l'instance de la classe [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Exemple de Code

Voici une démonstration du code pour convertir/exporter [DGN](https://docs.fileformat.com/cad/dgn/) en image [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
