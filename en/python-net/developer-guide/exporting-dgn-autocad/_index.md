---
title: Exporting DGN AutoCAD
type: docs
weight: 50
url: /python-net/exporting-dgn-autocad/
---

## **Exporting DGN AutoCAD Format To PDF**

Aspose.CAD for Python API has introduced the functionality to load a DGN AutoCAD file and convert it to PDF format. **CadImage** class serves the purpose.

You need to load an existing DGN file as **CadImage**. Create an instance of the **CadRasterizationOptions** class and set different properties. Create an instance of **PdfOptions** class and pass the **CadRasterizationOptions** instance. Now call the **save** method of **CadImage** class instance.

### Sample Code

Following is the code demonstration to convert/export [DGN](https://docs.fileformat.com/cad/dgn/) to [PDF](https://docs.fileformat.com/pdf/) format.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Exporting DGN AutoCAD Format To Raster Image Format**

Aspose.CAD for Python API has introduced the functionality to load a DGN AutoCAD file and convert it to a raster image. **CadImage** class serves the purpose.

You need to load an existing DGN file as **CadImage**. Create an instance of the **CadRasterizationOptions** class and set different properties. Create an instance of **JpegOptions** class and pass the **CadRasterizationOptions** instance. Now call the **save** method of **CadImage** class instance.

### Sample Code

Following is the code demonstration to convert/export [DGN](https://docs.fileformat.com/cad/dgn/) to [JPEG](https://docs.fileformat.com/image/jpeg/) image.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **3D entities support for DGN v7**

Aspose.CAD for Python API has introduced the functionality to load a [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD file and support 3D entities for DGN v7. **CadImage** class serves the purpose. Each [DGN](https://docs.fileformat.com/cad/dgn/) image supports 9 predefined views. It's enumerated from 1 to 9. If view not defined on export, for multi-paged output formats (like PDF) all views will be exported, each on a separate page. 3D entities supported on DGN file format, as well as 2D. For this, **VectorRasterizationOptions** is used, TypeOfEntities is not used anymore for DGN format (both 2D and 3D supported simultaneously).

### Sample Code

The following is the sample code to look at supported DGN elements.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
