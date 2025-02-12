---
title: Изображения DRC
type: документация
weight: 40
url: /bg/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Експортиране на формата DRC в PDF**

Aspose.CAD за Python позволява на разработчиците да експортират файл DRC във формат PDF. Подходът за конвертиране на [DRC](https://docs.fileformat.com/3d/drc/) към [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Зареждане на файла с рисунка DRC чрез фабричния метод **Image.load**.
1. Създаване на обект от класа **CadRasterizationOptions** и задаване на свойствата **page_height** и **page_width**.
1. Създаване на обект от класа **PdfOptions** и задаване на свойството **VectorRasterizationOptions**.
1. Извикване на **Image.save**, като се предава обект от **PdfOptions** като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
