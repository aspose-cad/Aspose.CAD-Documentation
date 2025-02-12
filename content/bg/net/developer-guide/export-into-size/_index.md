---
title: Износ на чертежи и оформления DWG/DXF в определен размер
type: docs
weight: 40
url: /bg/net/developer-guide/export-into-size/
---

## **Износ на модела и всички оформления в размер A4 PDF**

Aspose.CAD API позволява да износите всички листове на DWG/DXF файла в определен физически PDF размер.

Следният примерен код настройва размера на обекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) за постигане на желания PDF размер.
Размерът на листа A4 е 210x297 милиметра или 8.27x11.69 инча и тези стойности се използват в кода.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Износ на CAD оформления в PDF в различен размер**

Понякога се изисква да се изнесе оформление в неговия физически размер. Следващият пример демонстрира износа на чертежа в многостраничен PDF, където всяка страница с содержанието на оформлението
има свой собствен физически PDF размер. Този пример използва [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/)
свойството.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
