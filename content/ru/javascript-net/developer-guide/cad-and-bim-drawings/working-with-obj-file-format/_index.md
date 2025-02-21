---
title: Работа с форматом OBJ
type: docs
weight: 120
url: /ru/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD теперь поддерживает формат файла OBJ. Формат файла OBJ представляет собой 3D геометрию, которая содержит текстурные карты, 3D координаты, полигоны и другую информацию об объекте.

{{% /alert %}}

## **Экспорт формата OBJ в PNG**

Aspose.CAD для Javascript в Angular позволяет разработчикам экспортировать файл [OBJ](https://docs.fileformat.com/3d/obj/) в формат [PNG](https://docs.fileformat.com/image/png/).
Подход к конвертации [OBJ](https://docs.fileformat.com/3d/obj/) в [PNG](https://docs.fileformat.com/image/png/) работает следующим образом:

1. Загрузите файл чертежа [OBJ](https://docs.fileformat.com/3d/obj/) с помощью метода **Image.load**.
1. Вызовите **Image.save**, передавая объект **PngOptions** в качестве второго параметра.

## Пример кода

Код ниже демонстрирует, как достичь той же цели с помощью Aspose.CAD для JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
