---
title: العمل مع النص
type: docs
weight: 40
url: /ar/python-net/work-with-text/
---

## **العمل مع النص**

تقريبًا كل الرسوم تحتوي على كائنات نصية وتوضح هذه الأمثلة كيفية إجراء عمليات عليها. 
هناك أنواع مختلفة من الكيانات لـ DWG/DXF يمكن أن تخزن النص، وهي **CadText**، **CadMText**، CadAttDef، CadAttrib. أنواع الإدخال الأخيرة ترتبط عادةً 
بـ **CadInsertObject** وتُخزن داخلها أو في الكتلة المقابلة.

إليك بعض الأمثلة التي تصف العمليات مع النص.

### **البحث عن النص**

تظهر هذه المثال كيفية العثور على قيم النص في ملف DWG/DXF ويمكن أيضًا استخدامها لاستبدال قيم النص.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}