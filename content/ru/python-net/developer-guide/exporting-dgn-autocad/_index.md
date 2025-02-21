---
title: Экспорт формата DGN AutoCAD
type: docs
weight: 50
url: /ru/python-net/developer-guide/exporting-dgn-autocad/
---

## **Экспорт формата DGN AutoCAD в PDF**

Aspose.CAD для Python API представил функциональность загрузки файла DGN AutoCAD и его конвертации в формат PDF. **CadImage** класс выполняет эту задачу.

Вам необходимо загрузить существующий файл DGN как **CadImage**. Создайте экземпляр класса **CadRasterizationOptions** и настройте различные свойства. Создайте экземпляр класса **PdfOptions** и передайте экземпляр **CadRasterizationOptions**. Теперь вызовите метод **save** экземпляра класса **CadImage**.

### Пример кода

Следующий демонстрирует код для конвертации/экспорта [DGN](https://docs.fileformat.com/cad/dgn/) в [PDF](https://docs.fileformat.com/pdf/) формат.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Экспорт формата DGN AutoCAD в растровый формат изображения**

Aspose.CAD для Python API представил функциональность загрузки файла DGN AutoCAD и его конвертации в растровое изображение. **CadImage** класс выполняет эту задачу.

Вам необходимо загрузить существующий файл DGN как **CadImage**. Создайте экземпляр класса **CadRasterizationOptions** и настройте различные свойства. Создайте экземпляр класса **JpegOptions** и передайте экземпляр **CadRasterizationOptions**. Теперь вызовите метод **save** экземпляра класса **CadImage**.

### Пример кода

Следующий демонстрирует код для конвертации/экспорта [DGN](https://docs.fileformat.com/cad/dgn/) в [JPEG](https://docs.fileformat.com/image/jpeg/) изображение.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Поддержка 3D-сущностей для DGN v7**

Aspose.CAD для Python API представил функциональность загрузки файла [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD и поддержки 3D-сущностей для DGN v7. **CadImage** класс выполняет эту задачу. Каждое [DGN](https://docs.fileformat.com/cad/dgn/) изображение поддерживает 9 предопределенных видов. Они нумеруются от 1 до 9. Если вид не определен при экспорте, для многостраничных форматов вывода (таких как PDF) будут экспортированы все виды, каждый на отдельной странице. 3D-сущности поддерживаются в формате DGN, а также 2D. Для этого используется **VectorRasterizationOptions**, TypeOfEntities больше не используется для формата DGN (оба 2D и 3D поддерживаются одновременно).

### Пример кода

Следующий пример демонстрирует код для просмотра поддерживаемых элементов DGN.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
