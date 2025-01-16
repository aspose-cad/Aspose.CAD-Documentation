---
title: Експортиране на DGN AutoCAD
type: docs
weight: 50
url: /bg/python-net/експортиране-на-dgn-autocad/
---

## **Експортиране на формат DGN AutoCAD в PDF**

Aspose.CAD за Python API въведе функционалност за зареждане на файл DGN AutoCAD и конвертиране във формат PDF. Класът **CadImage** служи за целта.

Трябва да заредите съществуващ файл DGN като **CadImage**. Създайте инстанция на класа **CadRasterizationOptions** и задайте различни свойства. Създайте инстанция на класа **PdfOptions** и предайте инстанцията на **CadRasterizationOptions**. Сега извикайте метода **save** на инстанцията на класа **CadImage**.

### Примерен код

Долу е демонстрация на кода за конвертиране/експортиране на [DGN](https://docs.fileformat.com/cad/dgn/) към [PDF](https://docs.fileformat.com/pdf/) формат.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Експортиране на формат DGN AutoCAD във формат на равно инчово изображение**

Aspose.CAD за Python API въведе функционалност за зареждане на файл DGN AutoCAD и конвертиране в равноинчово изображение. Класът **CadImage** служи за целта.

Трябва да заредите съществуващ файл DGN като **CadImage**. Създайте инстанция на класа **CadRasterizationOptions** и задайте различни свойства. Създайте инстанция на класа **JpegOptions** и предайте инстанцията на **CadRasterizationOptions**. Сега извикайте метода **save** на инстанцията на класа **CadImage**.

### Примерен код

Долу е демонстрация на кода за конвертиране/експортиране на [DGN](https://docs.fileformat.com/cad/dgn/) към изображение във формата [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Поддръжка на същества 3D за DGN v7**

Aspose.CAD за Python API въведе функционалност за зареждане на файл на [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD и поддръжка на 3D обекти за DGN v7. Класът **CadImage** служи за целта. Всяка [DGN](https://docs.fileformat.com/cad/dgn/) снимка поддържа 9 предварително зададени изгледа. Те са номерирани от 1 до 9. Ако изгледът не е зададен при експортиране, за форматите за изход с няколко страници (като PDF) всички изгледи ще бъдат експортирани, всеки на отделна страница. Съществата 3D се поддържат във файловия формат DGN, както и 2D. За това се използва **VectorRasterizationOptions**, TypeOfEntities вече не се използва за формата DGN (и двата 2D и 3D се поддържат едновременно).

### Примерен код

Долу е представен примерен код за разглеждане на поддържаните елементи на DGN.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
