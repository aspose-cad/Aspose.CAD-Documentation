---
title: Рисунки SVG
type: docs
weight: 70
url: /bg/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Експортиране на формат SVG към PNG**

Aspose.CAD за Javascript в Angular позволява на разработчиците да експортират файл [SVG](https://docs.fileformat.com/page-description-language/svg/) към формат [PNG](https://docs.fileformat.com/image/png/).
Подходът за конвертиране от [SVG](https://docs.fileformat.com/page-description-language/svg/) към [PNG](https://docs.fileformat.com/image/png/) работи по следния начин:

1. Зареждане на файл за чертане [SVG](https://docs.fileformat.com/page-description-language/svg/) чрез метода **Image.load**.
1. Извикване на **Image.save** като се подаде обект от **PngOptions** като втори параметър.

## Примерен код

Кода по-долу показва как да се постигне същата цел, използвайки Aspose.CAD за JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
