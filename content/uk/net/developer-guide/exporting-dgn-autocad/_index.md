---
title: Експорт формату DGN AutoCAD
type: docs
weight: 50
url: /uk/net/developer-guide/exporting-dgn-autocad/
---

## **Експорт формату DGN AutoCAD в PDF**

Aspose.CAD для .NET API впровадила функціональність для завантаження файлу DGN AutoCAD та конвертації його в формат PDF. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) клас служить для цієї мети.

Вам потрібно завантажити наявний DGN файл у вигляді [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і налаштуйте різні властивості. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) і передайте екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Тепер викличте метод [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) екземпляра класу [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Приклад коду

Наступне - це демонстрація коду для конвертації/експорту [DGN](https://docs.fileformat.com/cad/dgn/) в [PDF](https://docs.fileformat.com/pdf/) формат.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Експорт формату DGN AutoCAD в растровий зображений формат**

Aspose.CAD для .NET API впровадила функціональність для завантаження файлу DGN AutoCAD та конвертації його в растрове зображення. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) клас служить для цієї мети.

Вам потрібно завантажити наявний DGN файл у вигляді [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).  Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і налаштуйте різні властивості. Створіть екземпляр класу [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) і передайте екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Тепер викличте метод [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) екземпляра класу [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Приклад коду

Наступне - це демонстрація коду для конвертації/експорту [DGN](https://docs.fileformat.com/cad/dgn/) в [JPEG](https://docs.fileformat.com/image/jpeg/) зображення.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Підтримка 3D об'єктів для DGN v7**

Aspose.CAD для .NET API впровадила функціональність для завантаження файлу [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD та підтримки 3D об'єктів для DGN v7. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) клас служить для цієї мети. Кожен [DGN](https://docs.fileformat.com/cad/dgn/) зображення підтримує 9 підготовлених видів. Вони перераховані з 1 до 9. Якщо вид не визначено при експорті, для багатосторінкових вихідних форматів (таких як PDF) всі види будуть експортовані, кожен на окремій сторінці. 3D об'єкти підтримуються у форматі DGN, так само як і 2D. Для цього використовується [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), TypeOfEntities більше не використовується для формату DGN (обидва 2D і 3D підтримуються одночасно).

### Приклад коду

Наведеним є приклад коду для перегляду підтримуваних елементів DGN.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
