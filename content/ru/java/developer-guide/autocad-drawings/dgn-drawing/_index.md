---
title: DGN Чертеж
type: docs
weight: 10
url: /ru/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Чертеж формата DGN как часть DWG**

Aspose.CAD для Java позволяет разработчикам экспортировать файл DWG с встроенной подложкой DGN. Ниже приведен код, демонстрирующий, как получить доступ к подложке DGN внутри файла DWG во время экспорта файла DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Поддержка 3D элементов для DGN v7**

API Aspose.CAD для Java ввел функционал для загрузки файла DGN AutoCAD и поддержки 3D элементов для DGN v7. Класс [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) служит этой цели. Каждый DGN-изображение поддерживает 9 предопределенных видов. Они пронумерованы от 1 до 9. Если вид не определен при экспорте, для многостраничных выходных форматов (таких как PDF) все виды будут экспортированы, каждый на отдельной странице. Поддерживаются 3D элементы в формате DGN, а также 2D.
VectorRasterizationOptions.TypeOfEntities больше не используется для формата DGN (оба 2D и 3D поддерживаются одновременно).

Пример кода для просмотра поддерживаемых элементов DGN.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
