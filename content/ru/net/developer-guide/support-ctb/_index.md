---
title: Поддержка файлов CTB
type: docs
weight: 40
url: /ru/net/developer-guide/support-ctb/
---

## **Поддержка файлов CTB**

Иногда цвет, ширина линий и некоторые другие параметры для чертежей могут использоваться не только из самих чертежей, но и из стилей печати в отдельных файлах CTB. 
Самый простой способ использовать эту информацию — разместить соответствующие файлы CTB рядом с файлом чертежа в формате DWG/DXF, и информация из них будет применяться
автоматически во время экспорта.

Также возможно загрузить все файлы CTB в форме потока, используя 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) свойство объекта 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).

Вот пример того, как это сделать:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
