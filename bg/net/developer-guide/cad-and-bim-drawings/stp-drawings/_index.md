---
title: Изображения на STP
type: документация
weight: 70
url: /bg/net/stp-drawings/
---

## **Експортиране на формат STP към PDF**

Aspose.CAD за .NET позволява на разработчиците да експортират файлове [STP](https://docs.fileformat.com/bg/3d/stp/) към формат [PDF](https://docs.fileformat.com/bg/pdf/). Подходът за конвертиране на [STP](https://docs.fileformat.com/bg/3d/stp/) към [PDF](https://docs.fileformat.com/bg/pdf/) работи по следния начин:

1. Зареждане на файл за чертане [STP](https://docs.fileformat.com/bg/3d/stp/) чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създаване на обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задаване на свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създаване на обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задаване на свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикване на [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като се подава обект от [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
