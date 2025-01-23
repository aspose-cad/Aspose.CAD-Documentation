---
title: Рисунки за DRC
type: docs
weight: 15
url: /bg/net/drc-drawings/
---

## **Експортиране на рисунките за DRC в PDF формат**

Aspose.CAD предоставя възможността за зареждане на съществата за чертане на AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) и тяхното изобразяване като цял чертеж във формат [PDF](https://docs.fileformat.com/pdf/). Подходът за конвертиране на [DRC](https://docs.fileformat.com/3d/drc/) в [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Заредете файла за чертане на [DRC](https://docs.fileformat.com/3d/drc/) с помощта на фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създайте обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикайте метода [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като подадете обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

### Примерен код

Долу е показан примерен код за конвертиране на файл с настройки по подразбиране.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
