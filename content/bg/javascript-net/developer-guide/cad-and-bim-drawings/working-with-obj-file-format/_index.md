---
title: Работа с формата на файловете OBJ
type: docs
weight: 120
url: /bg/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD вече поддържа формата на файловете OBJ. Форматът на файловете OBJ е тримерно геометрично представяне, което съдържа текстурни карти, тримерни координати, полигонални лица и друга информация за обекта.

{{% /alert %}}

## **Експортиране на формат OBJ към PNG**

Aspose.CAD за Javascript в Angular позволява на разработчиците да експортират файл [OBJ](https://docs.fileformat.com/3d/obj/) във формат [PNG](https://docs.fileformat.com/image/png/).
Процесът на конвертиране от [OBJ](https://docs.fileformat.com/3d/obj/) към [PNG](https://docs.fileformat.com/image/png/) работи по следния начин:

1. Заредете файл за чертане [OBJ](https://docs.fileformat.com/3d/obj/) с помощта на метода **Image.load**.
1. Извикайте **Image.save**, като подадете обект на **PngOptions** като втори параметър.

## Примерен код

Долу е показан как да постигнете същата цел, използвайки Aspose.CAD за JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
