---
title: Экспорт формата DGN AutoCAD
type: docs
weight: 50
url: /ru/net/developer-guide/exporting-dgn-autocad/
---

## **Экспорт формата DGN AutoCAD в PDF**

Aspose.CAD для .NET API представила функциональность для загрузки файла DGN AutoCAD и его преобразования в формат PDF. Класс [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) служит этой цели.

Вам нужно загрузить существующий файл DGN как [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите различные свойства. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и передайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Теперь вызовите метод [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) экземпляра класса [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Пример кода

Ниже приведена демонстрация кода для преобразования/экспорта [DGN](https://docs.fileformat.com/cad/dgn/) в формат [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Экспорт формата DGN AutoCAD в растровый формат изображения**

Aspose.CAD для .NET API представила функциональность для загрузки файла DGN AutoCAD и его преобразования в растровое изображение. Класс [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) служит этой цели.

Вам нужно загрузить существующий файл DGN как [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите различные свойства. Создайте экземпляр класса [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) и передайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Теперь вызовите метод [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) экземпляра класса [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Пример кода

Ниже приведена демонстрация кода для преобразования/экспорта [DGN](https://docs.fileformat.com/cad/dgn/) в изображение [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Поддержка 3D объектов для DGN v7**

Aspose.CAD для .NET API представила функциональность для загрузки файла [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD и поддержки 3D объектов для DGN v7. Класс [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) служит этой цели. Каждое изображение [DGN](https://docs.fileformat.com/cad/dgn/) поддерживает 9 заранее определённых представлений. Они нумеруются от 1 до 9. Если представление не определено при экспорте, для многопстраничных выходных форматов (например, PDF) будут экспортированы все представления, каждое на отдельной странице. 3D объекты поддерживаются в формате файла DGN, а также 2D. Для этого используется [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), TypeOfEntities больше не используется для формата DGN (одновременно поддерживаются как 2D, так и 3D).

### Пример кода

Ниже приведён пример кода для просмотра поддерживаемых элементов DGN.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
