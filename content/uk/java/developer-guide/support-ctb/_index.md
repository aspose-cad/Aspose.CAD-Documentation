---
title: Підтримка файлів CTB
type: docs
weight: 40
url: /uk/java/developer-guide/support-ctb/
---

## **Підтримка файлів CTB**

Іноді кольори, товщина ліній та деякі інші параметри для малюнків можуть використовуватися не лише з самих малюнків, але й з стильових файлів у окремих файлах CTB.
Найпростіший спосіб використати цю інформацію — це помістити відповідні файли CTB поряд із файлом з малюнком у форматі DWG/DXF, і інформація з них буде застосована
автоматично під час експорту.

Також можливе завантаження всіх файлів CTB у формі потоку за допомогою 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) властивості 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) об'єкта.

Ось приклад того, як це зробити:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
