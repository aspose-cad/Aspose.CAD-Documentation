---
title: Експорт DWG креслень
type: docs
weight: 70
url: /uk/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Експорт DWG креслень у PDF**

Aspose.CAD для Python API може завантажувати креслення AutoCAD у форматі [DWG](https://docs.fileformat.com/cad/dwg/) та перетворювати їх у [PDF](https://docs.fileformat.com/pdf/). Ця тема пояснює використання API Aspose.CAD для досягнення конвертації DWG у формат PDF через прості кроки, описані нижче.

{{% alert color="primary" %}}

API підтримує такі ревізії AutoCAD DWG:

- DWG 2004 версія 16.0 випуск 18
- DWG 2005 версія 16.1
- DWG 2010 версія 18.0
- DWG 2013 версія 19.0

{{% /alert %}}

### **Формат файлу DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) — це бінарний файл, що містить векторні дані зображення та метадані. Векторні дані зображення надають інструкції CAD програмі про те, як відображати DWG; метадані можуть містити різноманітну інформацію про файл, включаючи специфічні дані про розташування та також дані про клієнт. Відкриті специфікації формату файлу DWG можна знайти [в цьому PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Конвертація файлів DWG у PDF**

Потрібно виконати наступні прості кроки, щоб конвертувати [DWG](https://docs.fileformat.com/cad/dwg/) у [PDF](https://docs.fileformat.com/pdf/).

1. Завантажте файл DWG у екземпляр **Image**.
1. Створіть об'єкт класу **CadRasterizationOptions** та встановіть властивості **page_height** та **page_width**.
1. Створіть об'єкт класу **PdfOptions** та встановіть властивість **VectorRasterizationOptions**.
1. Виконайте **Image.save**, передавши об'єкт **PdfOptions** як другий параметр.

Наводиться приклад коду, що показує, як експортувати DWG креслення у PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Підтримувані примітиви AutoCAD**

Підтримуються такі примітиви AutoCAD:

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Експорт конкретного макету DWG у PDF**

Цей підхід діє наступним чином:

1. Завантажте файл DWG, використовуючи фабричний метод **Aspose.CAD.Image.load**.
1. Створіть екземпляр класу **CadRasterizationOptions** та встановіть висоту та ширину результуючої сторінки.
1. Встановіть властивість **Layouts** для об'єкта **CadRasterizationOptions**.
1. Створіть екземпляр класу **PdfOptions** та встановіть його властивість **VectorRasterizationOptions**.
1. Експортуйте зображення у PDF, використовуючи метод **Image.save()**.

Наводиться приклад коду, що показує, як конвертувати конкретний макет DWG у PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Експорт DWG у PDF/A та PDF/E**

Цей підхід діє наступним чином:

1. Завантажте файл DWG, використовуючи фабричний метод **Image.load**.
1. Створіть екземпляр класу **CadRasterizationOptions**.
1. Створіть екземпляр класу **PdfOptions** та встановіть його властивість **VectorRasterizationOptions**.
1. Встановіть властивість відповідності PDF та збережіть його.
1. Експортуйте зображення у PDF, використовуючи метод **Image.save()**.

Наводиться приклад коду, що показує, як конвертувати файл DWG у PDF/A та PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Конвертація DWG креслень у DXF**

Aspose.CAD надає можливість завантажувати файл AutoCAD DWG та експортувати його у формат DXF. Підхід конвертації DWG у DXF діє наступним чином:

1. Завантажте файл креслення DWG, використовуючи фабричний метод **Image.load**.
1. Експортуйте креслення DWG у DXF, використовуючи метод **Image.save()**.

Наводиться приклад коду, що показує, як конвертувати файл DWG у формат DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Конвертація DWG креслень у SVG**

Aspose.CAD для Python API може завантажувати креслення AutoCAD у форматі DWG та конвертувати їх у SVG. Ця тема пояснює використання API Aspose.CAD для досягнення конвертації DWG у формат SVG через прості кроки, описані нижче.

1. Завантажте файл DWG у екземпляр **Image**.
1. Створіть об'єкт класу **SvgOptions** та встановіть необхідні властивості.
1. Експортуйте креслення DWG у SVG, використовуючи метод **Image.save()**.

Наводиться приклад коду, що показує, як конвертувати файл DWG у формат SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
