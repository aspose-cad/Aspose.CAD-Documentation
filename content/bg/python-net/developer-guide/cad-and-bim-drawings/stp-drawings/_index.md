---
title: Изчертания на STP
type: документация
weight: 160
url: /bg/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Експортиране на формат STP към PDF**

Aspose.CAD за Python позволява на разработчиците да експортират файл [STP](https://docs.fileformat.com/3d/stp/) във формат [PDF](https://docs.fileformat.com/pdf/). Процесът на конвертиране от [STP](https://docs.fileformat.com/3d/stp/) към [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Заредете файл за изчертаване [STP](https://docs.fileformat.com/3d/stp/) чрез фабричния метод **Image.load**.
1. Създайте обект на класа **CadRasterizationOptions** и задайте свойствата **page_height** и **page_width**.
1. Създайте обект на класа **PdfOptions** и задайте свойството **vector_rasterization_options**.
1. Извикайте **Image.save**, като подадете обект на **PdfOptions** като втори параметър.

## Образецен код

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
