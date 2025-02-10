---
title: DGN Drawing
type: docs
weight: 10
url: /es/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Dibujo del formato DGN como parte de DWG**

Aspose.CAD para Java permite a los desarrolladores exportar un archivo DWG con un fondo DGN incrustado. A continuación, se muestra el código que demuestra cómo acceder al fondo DGN dentro de un archivo DWG al exportar el archivo DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Soporte de entidades 3D para DGN v7**

La API Aspose.CAD para Java ha introducido la funcionalidad para cargar un archivo DGN de AutoCAD y soportar entidades 3D para DGN v7. La clase [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) sirve para este propósito. Cada imagen DGN soporta 9 vistas predefinidas. Estas se enumeran de 1 a 9. Si no se define la vista en la exportación, para formatos de salida de varias páginas (como PDF) se exportarán todas las vistas, cada una en una página separada. Se soportan entidades 3D en el formato de archivo DGN, así como entidades 2D. 
VectorRasterizationOptions.TypeOfEntities ya no se utiliza para el formato DGN (tanto 2D como 3D se soportan simultáneamente).

Código de muestra para observar los elementos DGN soportados.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
