---
title: Експорт формату DGN AutoCAD
type: docs
weight: 50
url: /uk/python-net/developer-guide/exporting-dgn-autocad/
---

## **Експорт формату DGN AutoCAD до PDF**

Aspose.CAD для Python API впровадив функціональність для завантаження файлу DGN AutoCAD та конвертації його в формат PDF. **CadImage** клас виконує цю мету.

Вам потрібно завантажити існуючий файл DGN як **CadImage**. Створіть екземпляр класу **CadRasterizationOptions** та налаштуйте різні властивості. Створіть екземпляр класу **PdfOptions** та передайте екземпляр **CadRasterizationOptions**. Тепер викличте метод **save** екземпляра класу **CadImage**.

### Приклад коду

Наступний код демонструє, як конвертувати/експортувати [DGN](https://docs.fileformat.com/cad/dgn/) у [PDF](https://docs.fileformat.com/pdf/) формат.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Експорт формату DGN AutoCAD до растрового зображення**

Aspose.CAD для Python API впровадив функціональність для завантаження файлу DGN AutoCAD та конвертації його в растрове зображення. **CadImage** клас виконує цю мету.

Вам потрібно завантажити існуючий файл DGN як **CadImage**. Створіть екземпляр класу **CadRasterizationOptions** та налаштуйте різні властивості. Створіть екземпляр класу **JpegOptions** та передайте екземпляр **CadRasterizationOptions**. Тепер викличте метод **save** екземпляра класу **CadImage**.

### Приклад коду

Наступний код демонструє, як конвертувати/експортувати [DGN](https://docs.fileformat.com/cad/dgn/) у [JPEG](https://docs.fileformat.com/image/jpeg/) зображення.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Підтримка 3D-об'єктів для DGN v7**

Aspose.CAD для Python API впровадив функціональність для завантаження [DGN](https://docs.fileformat.com/cad/dgn/) файлу AutoCAD та підтримки 3D-об'єктів для DGN v7. **CadImage** клас виконує цю мету. Кожне зображення [DGN](https://docs.fileformat.com/cad/dgn/) підтримує 9 попередньо визначених видів. Вони нумеруються від 1 до 9. Якщо вид не визначений під час експорту, для багатосторінкових вихідних форматів (таких як PDF) всі види будуть експортовані, кожен на окремій сторінці. 3D-об'єкти підтримуються у форматі файлу DGN, так само як і 2D. Для цього використовується **VectorRasterizationOptions**, TypeOfEntities більше не використовується для формату DGN (обидва 2D та 3D підтримуються одночасно).

### Приклад коду

Наступний приклад коду демонструє підтримувані елементи DGN.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
