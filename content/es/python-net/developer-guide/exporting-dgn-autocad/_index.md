---
title: Exportando DGN AutoCAD
type: docs
weight: 50
url: /es/python-net/exporting-dgn-autocad/
---

## **Exportando el Formato DGN AutoCAD a PDF**

Aspose.CAD para la API de Python ha introducido la funcionalidad para cargar un archivo DGN de AutoCAD y convertirlo al formato PDF. La clase **CadImage** cumple con este propósito.

Necesita cargar un archivo DGN existente como **CadImage**. Cree una instancia de la clase **CadRasterizationOptions** y establezca diferentes propiedades. Cree una instancia de la clase **PdfOptions** y pase la instancia de **CadRasterizationOptions**. Ahora llame al método **save** de la instancia de la clase **CadImage**.

### Código de Ejemplo

A continuación se muestra la demostración del código para convertir/exportar [DGN](https://docs.fileformat.com/cad/dgn/) a [PDF](https://docs.fileformat.com/pdf/) formato.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Exportando el Formato DGN AutoCAD a Formato de Imagen Rasterizada**

Aspose.CAD para la API de Python ha introducido la funcionalidad para cargar un archivo DGN de AutoCAD y convertirlo a una imagen rasterizada. La clase **CadImage** cumple con este propósito.

Necesita cargar un archivo DGN existente como **CadImage**. Cree una instancia de la clase **CadRasterizationOptions** y establezca diferentes propiedades. Cree una instancia de la clase **JpegOptions** y pase la instancia de **CadRasterizationOptions**. Ahora llame al método **save** de la instancia de la clase **CadImage**.

### Código de Ejemplo

A continuación se muestra la demostración del código para convertir/exportar [DGN](https://docs.fileformat.com/cad/dgn/) a imagen [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Soporte de entidades 3D para DGN v7**

Aspose.CAD para la API de Python ha introducido la funcionalidad para cargar un archivo [DGN](https://docs.fileformat.com/cad/dgn/) de AutoCAD y soportar entidades 3D para DGN v7. La clase **CadImage** cumple con este propósito. Cada imagen [DGN](https://docs.fileformat.com/cad/dgn/) soporta 9 vistas predefinidas. Se enumeran del 1 al 9. Si la vista no está definida al exportar, para formatos de salida de varias páginas (como PDF) se exportarán todas las vistas, cada una en una página separada. Las entidades 3D son compatibles con el formato de archivo DGN, así como las 2D. Para esto, se utiliza **VectorRasterizationOptions**, TypeOfEntities ya no se utiliza para el formato DGN (tanto 2D como 3D son soportados simultáneamente).

### Código de Ejemplo

A continuación se muestra un código de ejemplo para ver los elementos DGN soportados.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
