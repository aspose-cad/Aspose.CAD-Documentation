---
title: SVG Чертежи
type: docs
weight: 70
url: /ru/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Экспортирование SVG формата в PNG**

Aspose.CAD для Javascript в Angular позволяет разработчикам экспортировать файл [SVG](https://docs.fileformat.com/page-description-language/svg/) в формат [PNG](https://docs.fileformat.com/image/png/).
Подход к конвертации [SVG](https://docs.fileformat.com/page-description-language/svg/) в [PNG](https://docs.fileformat.com/image/png/) работает следующим образом:

1. Загрузите файл чертежа [SVG](https://docs.fileformat.com/page-description-language/svg/) с помощью метода **Image.load**.
1. Вызовите **Image.save**, передав объект **PngOptions** в качестве второго параметра.

## Пример кода

Код ниже показывает, как достичь той же цели с использованием Aspose.CAD для JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
