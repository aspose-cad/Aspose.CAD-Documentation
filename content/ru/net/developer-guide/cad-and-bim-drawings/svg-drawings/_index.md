---
title: SVG Рисунки
type: docs
weight: 70
url: /ru/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Экспорт SVG Формата в PDF**

Aspose.CAD для .NET позволяет разработчикам экспортировать файл SVG в [PDF](https://docs.fileformat.com/pdf/) формат. Подход к конвертации SVG в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл рисунка SVG с помощью метода [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передав объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
