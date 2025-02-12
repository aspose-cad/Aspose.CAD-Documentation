---
title: Рисунки COLLADA
type: документация
weight: 70
url: /bg/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Експортиране на Формат COLLADA в PDF**

Aspose.CAD за .NET позволява на разработчиците да експортират файл във формат [COLLADA](https://docs.fileformat.com/3d/dae/) във формат [PDF](https://docs.fileformat.com/pdf/). Подходът за конвертиране на [COLLADA](https://docs.fileformat.com/3d/dae/) в [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Заредете файл с рисунка във формат [COLLADA](https://docs.fileformat.com/3d/dae/) чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създайте обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като подадете обект от клас [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
