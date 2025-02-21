---
title: DXB Чертежи
type: docs
weight: 70
url: /ru/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Экспорт формата DXB в PDF**

Aspose.CAD для .NET позволяет разработчикам экспортировать файл DXB в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации DXB в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл чертежа DXB с помощью [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) фабричного метода.
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передав объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
