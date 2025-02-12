---
title: Рисунки 3DS
type: docs
weight: 70
url: /bg/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Експортиране на формат 3DS в PDF**

Aspose.CAD за .NET позволява на разработчиците да експортират файл във формат [3DS](https://docs.fileformat.com/3d/3ds/) към формат [PDF](https://docs.fileformat.com/pdf/). Подходът за конвертиране на [3DS](https://docs.fileformat.com/3d/3ds/) към [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Зареждане на файл с чертеж във формат [3DS](https://docs.fileformat.com/3d/3ds/) чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създаване на обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и настройка на свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създаване на обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и настройка на свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикване на [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) като се подаде обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
