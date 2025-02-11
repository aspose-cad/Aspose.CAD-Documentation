---
title: Exportando DGN AutoCAD
type: docs
weight: 50
url: /es/net/exporting-dgn-autocad/
---

## **Exportando el formato DGN de AutoCAD a PDF**

Aspose.CAD para .NET API ha introducido la funcionalidad para cargar un archivo DGN de AutoCAD y convertirlo a formato PDF. La clase [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sirve para este propósito.

Necesita cargar un archivo DGN existente como [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Cree una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establezca diferentes propiedades. Cree una instancia de la clase [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) y pase la instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Ahora llame al método [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) de la instancia de la clase [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Código de ejemplo

A continuación se muestra la demostración de código para convertir/exportar [DGN](https://docs.fileformat.com/cad/dgn/) a formato [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Exportando el formato DGN de AutoCAD a formato de imagen rasterizada**

Aspose.CAD para .NET API ha introducido la funcionalidad para cargar un archivo DGN de AutoCAD y convertirlo a una imagen rasterizada. La clase [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sirve para este propósito.

Necesita cargar un archivo DGN existente como [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Cree una instancia de la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) y establezca diferentes propiedades. Cree una instancia de la clase [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) y pase la instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Ahora llame al método [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) de la instancia de la clase [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Código de ejemplo

A continuación se muestra la demostración de código para convertir/exportar [DGN](https://docs.fileformat.com/cad/dgn/) a imagen [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Soporte de entidades 3D para DGN v7**

Aspose.CAD para .NET API ha introducido la funcionalidad para cargar un archivo DGN de AutoCAD y soportar entidades 3D para DGN v7. La clase [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sirve para este propósito. Cada imagen [DGN](https://docs.fileformat.com/cad/dgn/) soporta 9 vistas predefinidas. Se enumeran del 1 al 9. Si la vista no se define en la exportación, para formatos de salida multipágina (como PDF) se exportarán todas las vistas, cada una en una página separada. Se soportan entidades 3D en el formato de archivo DGN, así como 2D. Para esto, se utiliza [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions); TypeOfEntities ya no se utiliza para el formato DGN (tanto 2D como 3D son soportados simultáneamente).

### Código de ejemplo

El siguiente es un código de ejemplo para observar los elementos DGN soportados.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
