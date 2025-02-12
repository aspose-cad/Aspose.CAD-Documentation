---
title: Изображение DGN
type: docs
weight: 10
url: /bg/javascript-net/developer-guide/cad-and-bim-drawings/dgn-drawing/
---

## **Износ на DGN формат към PNG**

Aspose.CAD за JavaScript в Angular позволява на разработчиците да изнесат файл във формат [DGN](https://docs.fileformat.com/cad/dgn/) към формат [PNG](https://docs.fileformat.com/image/png/).
Подходът за конвертиране от [DGN](https://docs.fileformat.com/cad/dgn/) към [PNG](https://docs.fileformat.com/image/png/) работи по следния начин:

1. Заредете файл за чертане [DGN](https://docs.fileformat.com/cad/dgn/) с помощта на метода **Image.load**.
1. Извикайте **Image.save**, като подадете обект от **PngOptions** като втори параметър.

## Примерен код

Представеният по-долу код показва как да постигнете същата цел, използвайки Aspose.CAD за JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DGN-to-PNG-Export.js" >}}
