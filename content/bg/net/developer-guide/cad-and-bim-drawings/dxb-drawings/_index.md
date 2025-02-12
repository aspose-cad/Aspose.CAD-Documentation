---
title: Изчертания DXB
type: документи
weight: 70
url: /bg/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Експортиране на формат DXB към PDF**

Aspose.CAD за .NET позволява на разработчиците да експортират файл DXB във [PDF](https://docs.fileformat.com/pdf/) формат. Подходът за конвертиране на DXB към [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Зареждане на файл за изчертаване DXB чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създаване на обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задаване на свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създаване на обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задаване на свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикване на [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като се подава обект от тип [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
