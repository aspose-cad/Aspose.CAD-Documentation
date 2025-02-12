---
title: Изчертавания на STP
type: документация
weight: 70
url: /bg/javascript-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Експортиране на STP формат към PNG**

Aspose.CAD за Javascript в Angular позволява на разработчиците да експортират файл в [STP](https://docs.fileformat.com/3d/stp/) формат към [PNG](https://docs.fileformat.com/image/png/).

Процесът за конвертиране на [STP](https://docs.fileformat.com/3d/stp/) в [PNG](https://docs.fileformat.com/image/png/) работи по следния начин:

1. Зареждане на файла с чертеж във формат [STP](https://docs.fileformat.com/3d/stp/) използвайки метода **Image.load**.
2. Извикване на **Image.save**, като се предаде обект от тип **PngOptions** като втори параметър.

## Примерен Код

Долу е показан как да постигнете същата цел, използвайки Aspose.CAD за JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-STP-to-PNG-Export.js" >}}
