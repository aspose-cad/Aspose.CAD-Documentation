---
title: Экспорт рисунка и макетов DWG/DXF в указанный размер
type: docs
weight: 40
url: /ru/net/developer-guide/export-into-size/
---

## **Экспорт модели и всех макетов в размер PDF A4**

Aspose.CAD API позволяет экспортировать все листы файла DWG/DXF в указанный физический размер PDF.

Следующий пример кода настраивает размер объекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) для достижения желаемого размера PDF.
Размер листа бумаги A4 составляет 210x297 миллиметров или 8.27x11.69 дюймов, и эти значения используются в коде.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Экспорт макетов CAD в PDF в другом размере**

Иногда необходимо экспортировать макет в его физическом размере. Пример ниже демонстрирует экспорт чертежа в многостраничный PDF, где каждая страница с содержимым макета
имеет свой собственный физический размер PDF. Этот пример использует свойство [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
