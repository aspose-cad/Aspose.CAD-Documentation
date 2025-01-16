---
title: Рисунки COLLADA
type: docs
weight: 20
url: /bg/python-net/collada-drawings/
---

## **Изнасяне на Формат COLLADA в PDF**

Aspose.CAD за Python позволява на разработчиците да изнасят файл във формат [COLLADA](https://docs.fileformat.com/3d/dae/) във формат [PDF](https://docs.fileformat.com/pdf/). Процесът на конвертиране от [COLLADA](https://docs.fileformat.com/3d/dae/) в [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Зареждане на файла с рисунка във формат [COLLADA](https://docs.fileformat.com/3d/dae/) с помощта на фабричния метод **Image.load**.
2. Създаване на обект от класа **CadRasterizationOptions** и задаване на свойствата **page_height** и **page_width**.
3. Създаване на обект от класа **PdfOptions** и задаване на свойството **vector_rasterization_options**.
4. Извикване на **Image.save**, като се подава обект от **PdfOptions** като втори параметър.

## Примерен Код

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
