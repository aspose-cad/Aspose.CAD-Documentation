---
title: Изчертавания на 3DS
type: docs
weight: 70
url: /bg/javascript-net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Експортиране на формат 3DS към PNG**

Aspose.CAD за Javascript в Angular позволява на разработчиците да експортират файл [3DS](https://docs.fileformat.com/3d/3ds/) към формат [PNG](https://docs.fileformat.com/image/png/). Подходът за конверсия от [3DS](https://docs.fileformat.com/3d/3ds/) към [PNG](https://docs.fileformat.com/image/png/) работи по следния начин:

1. Зареждане на файла за изчертаване [3DS](https://docs.fileformat.com/3d/3ds/) използвайки метода **Image.load**.
1. Обаждане на **Image.save**, като се предава обект на **PngOptions** като втори параметър.

## Примерен код

Предоставеният по-долу код показва как да се постигне същата цел с помощта на Aspose.CAD за JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-3DS-to-PNG-Export.js" >}}
