---
title: Поддержка файлов CTB
type: docs
weight: 40
url: /ru/java/developer-guide/support-ctb/
---

## **Поддержка файлов CTB**

Иногда цвет, линии и некоторые другие параметры для чертежей могут использоваться не только из самих чертежей, но и из стилей печати в отдельных файлах CTB. 
Самый простой способ использовать эту информацию — разместить соответствующие файлы CTB рядом с файлом чертежа в формате DWG/DXF, и информация из них будет применяться 
автоматически во время экспорта.

Также возможно загрузить все файлы CTB в форме потока, используя 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) свойство объекта 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

Вот пример, как это сделать:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
