---
title: Підтримка CTB файлів
type: docs
weight: 40
url: /uk/net/developer-guide/support-ctb/
---

## **Підтримка CTB файлів**

Іноді кольори, товщина ліній та деякі інші параметри для креслень можуть використовуватися не тільки з самих креслень, а й з стильових карток в окремих CTB файлах. 
Найпростіший спосіб використати цю інформацію – розмістити відповідні CTB файли поруч з файлом креслення у форматі DWG/DXF, і інформація з них буде застосована
автоматично під час експорту.

Також можливо завантажити всі CTB файли у формі потоку, використовуючи 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) властивість 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) об'єкта.

Ось приклад, як це зробити:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
