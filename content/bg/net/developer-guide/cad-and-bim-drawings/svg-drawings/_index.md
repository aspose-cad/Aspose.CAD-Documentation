---
title: Графични изображения SVG
type: документация
weight: 70
url: /bg/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Експортиране на формат SVG в PDF**

Aspose.CAD за .NET позволява на разработчиците да експортират файл SVG във [PDF](https://docs.fileformat.com/pdf/) формат. Подходът за конвертиране на SVG към [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Заредете файл с графично изображение SVG, използвайки фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създайте обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като подадете обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
