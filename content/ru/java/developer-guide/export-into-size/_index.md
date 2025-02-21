---
title: Экспортирование чертежей и макетов DWG/DXF в заданный размер
type: docs
weight: 40
url: /ru/java/developer-guide/export-into-size/
---

## **Экспорт модели и всех макетов в PDF формате A4**

Aspose.CAD API позволяет экспортировать все листы файла DWG/DXF в заданный физический размер PDF. 
Следующий пример кода настраивает размер объекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) для достижения желаемого размера PDF.
Размер листа бумаги A4 составляет 210x297 миллиметров или 8.27x11.69 дюймов, и эти значения используются в коде.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Экспорт макетов CAD в PDF в разных размерах**

Иногда требуется экспортировать макет в его физическом размере. Пример ниже демонстрирует экспорт чертежа в многопользовательский PDF, где каждая страница с содержимым макета имеет свой собственный физический размер PDF. Этот пример использует свойство [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
