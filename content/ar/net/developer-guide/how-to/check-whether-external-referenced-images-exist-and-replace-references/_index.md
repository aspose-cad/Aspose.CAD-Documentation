---
title: تحقق مما إذا كانت الصور المرجعية الخارجية موجودة واستبدال المراجع
type: docs
weight: 22
url: /ar/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **كيفية تحرير الارتباطات التشعبية على الكائنات**

**المشكلة:** كيفية التحقق مما إذا كانت الصور المرجعية الخارجية موجودة واستبدال المراجع (CADNET-8088).

**نصائح:** للقيام بذلك، احصل على كيان من النوع CadObjectTypeName.IMAGEDEF من كائنات الرسم واستخدم CadRasterImageDef للتحقق.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
