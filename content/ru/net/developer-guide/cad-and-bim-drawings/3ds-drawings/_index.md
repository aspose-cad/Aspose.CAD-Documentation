---
title: 3D рисунки
type: docs
weight: 70
url: /ru/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Экспорт 3DS формата в PDF**

Aspose.CAD для .NET позволяет разработчикам экспортировать файл [3DS](https://docs.fileformat.com/3d/3ds/) в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации [3DS](https://docs.fileformat.com/3d/3ds/) в [PDF](https://docs.fileformat.com/pdf/) выглядит следующим образом:

1. Загрузите файл рисования [3DS](https://docs.fileformat.com/3d/3ds/) с помощью фабричного метода [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передавая объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
