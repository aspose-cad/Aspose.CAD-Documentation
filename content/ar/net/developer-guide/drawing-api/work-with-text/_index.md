---
title: العمل مع النصوص
type: docs
weight: 40
url: /ar/net/work-with-text/
---

## **العمل مع النصوص**

تقريبًا جميع الرسومات تحتوي على كائنات نصية وهذه الأمثلة توضح كيف يمكن إجراء العمليات معها. 
هناك أنواع مختلفة من الكائنات لـ DWG/DXF يمكنها تخزين النص، وهي [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/)، 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/)،
CadAttDef، CadAttrib. أما النوعان الأخيران فعادة ما يرتبطان 
بـ [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
وتُخزن داخلها أو في الكتلة المقابلة.

إليك بعض الأمثلة التي تصف العمليات مع النص.

### **البحث عن النص**

توضح هذه المثال كيفية العثور على قيم النص في ملف DWG/DXF ويمكن استخدامها أيضًا لاستبدال قيم النص.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **إضافة عناصر نص و MText جديدة**

إليك المثال الذي يوضح كيفية إضافة كائنات نصية / Mtext جديدة إلى الرسم. قد تؤدي إضافة كائنات جديدة إلى تغيير حجم الرسم، لذلك يُنصح 
بـ استدعاء UpdateSize() بعد هذه العمليات.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
