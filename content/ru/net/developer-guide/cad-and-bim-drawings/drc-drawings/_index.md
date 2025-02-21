---
title: Чертежи DRC
type: docs
weight: 15
url: /ru/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Экспорт чертежей DRC в PDF**

Aspose.CAD предоставляет возможность загружать сущности чертежей AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) и отображать их как целый чертеж в формате [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации из [DRC](https://docs.fileformat.com/3d/drc/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл чертежа [DRC](https://docs.fileformat.com/3d/drc/) с помощью метода-фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передавая объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

### Пример кода

Пример кода ниже показывает, как конвертировать файл с использованием настроек по умолчанию.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
