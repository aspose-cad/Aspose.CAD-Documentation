---
title: Чертежи IFC
type: docs
weight: 70
url: /bg/javascript-net/developer-guide/cad-and-bim-drawings/ifc-drawings/
---

## **Експортиране на формата FBX към PNG**

Aspose.CAD за JavaScript в Angular позволява на разработчиците да експортират файл [IFC](https://docs.fileformat.com/cad/ifc/) във формат [PNG](https://docs.fileformat.com/image/png/).
При подхода за конвертиране от [IFC](https://docs.fileformat.com/cad/ifc/) към [PNG](https://docs.fileformat.com/image/png/) се използва следната стратегия:

1. Заредете файла с чертеж на [IFC](https://docs.fileformat.com/cad/ifc/) чрез метода **Image.load**.
1. Извикайте **Image.save**, като подадете обект от **PngOptions** като втори параметър.

## Примерен код

Представеният по-долу код показва как може да се постигне същата цел с използването на Aspose.CAD за JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-IFC-to-PNG-Export.js" >}}
