---
title: Експортиране на чертежи и оформления DWG/DXF в зададен размер
type: docs
weight: 40
url: /bg/java/export-into-size/
---

## **Експортиране на модел и всички оформления в размер A4 PDF**

Aspose.CAD API позволява да експортирате всички листове на DWG/DXF файл в зададен физически размер на PDF.
Следният примерен код настройва размера на обекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) за постигане на желания размер на PDF.
Размерът на листа A4 е 210x297 милиметра или 8.27x11.69 инча и тези стойности се използват в кода.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Експортиране на CAD оформления в PDF в различен размер**

Понякога е необходимо да се експортира оформление в неговия физически размер. Примерът по-долу демонстрира експортирането на чертеж в многостраничен PDF, където всяка страница с съдържание на оформление
има собствен физически размер на PDF. Този пример използва свойството [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
