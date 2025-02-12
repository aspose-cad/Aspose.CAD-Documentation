---
title: إضافة صورة كخلفية في DWG
type: docs
weight: 15
url: /ar/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **كيفية إضافة صورة كخلفية في DWG**

**المشكلة:** كيفية إضافة صورة كخلفية في DWG.

**نصائح:** للقيام بذلك، قم بإنشاء كائن CadRasterImageDef للصورة الخلفية، أنشئ كائن CadRasterImage لإدخال الخلفية للرسم، أضف كائن CadRasterImage إلى كائنات الرسم، أنشئ كائن CadBaseObject وأضفه إلى cadImage.Objects، قم بمعالجة كل شيء عبر CadBlockTableObject.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
