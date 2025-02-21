---
title: Робота з форматом файлів OBJ
type: docs
weight: 120
url: /uk/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD тепер підтримує формат файлів OBJ. Формат файлів OBJ – це 3D геометрія, яка містить текстурні карти, 3D координати, полігональні обличчя та іншу інформацію про об'єкти.

{{% /alert %}}

## **Експорт формату OBJ у PNG**

Aspose.CAD для Javascript в Angular дозволяє розробникам експортувати файл [OBJ](https://docs.fileformat.com/3d/obj/) у формат [PNG](https://docs.fileformat.com/image/png/).
Підхід конвертації [OBJ](https://docs.fileformat.com/3d/obj/) у [PNG](https://docs.fileformat.com/image/png/) працює наступним чином:

1. Завантажте файл малюнка [OBJ](https://docs.fileformat.com/3d/obj/) за допомогою методу **Image.load**.
1. Викличте **Image.save**, передавши об'єкт **PngOptions** як другий параметр.

## Приклад коду

Код нижче показує, як досягти тієї ж мети за допомогою Aspose.CAD для JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
