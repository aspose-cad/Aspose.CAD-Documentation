---
title: Рисуване на DGN формат като част от DWG
type: документация
weight: 10
url: /bg/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Рисуване на DGN формат като част от DWG**

Aspose.CAD за Java позволява на разработчиците да експортират DWG файл с вграден DGN подложен файл. По-долу е показан код, който демонстрира как да се достъпи DGN подложен файл в DWG файл по време на експорта на DWG файла.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Поддръжка на 3D същества за DGN v7**

Aspose.CAD за Java API въведе функционалност за зареждане на DGN AutoCAD файл и поддръжка на 3D същества за DGN v7. Класът [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) служи за целта. Всеки DGN образ поддържа 9 предварително дефинирани изгледи. Те са пронумерирани от 1 до 9. Ако изгледът не е дефиниран при експортиране, за форматите с множество страници (като PDF) всички изгледи ще бъдат експортирани, всеки на отделна страница. 3D съществата се поддържат върху формата на файл DGN, както и 2D.
VectorRasterizationOptions.TypeOfEntities вече не се използва за формата DGN (и двете - 2D и 3D се поддържат едновременно).

Примерен код за разглеждане на поддържаните DGN елементи.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
