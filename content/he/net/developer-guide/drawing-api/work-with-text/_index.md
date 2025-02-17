---
title: עבודה עם טקסט
type: docs
weight: 40
url: /he/net/developer-guide/drawing-api/work-with-text/
---

## **עבודה עם טקסט**

כמעט כל ציור מכיל אובייקטים של טקסט ודוגמאות אלו מציגות כיצד לבצע פעולות עימם. 
יש סוגים שונים של ישויות עבור DWG/DXF שיכולות לאחסן טקסט, הם [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. שני הסוגים האחרונים בדרך כלל קשורים 
ל[**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
ואוחסנים בתוכו או בבלוק התואם.

הנה כמה דוגמאות המתארות פעולות עם טקסט.

### **חיפוש הטקסט**

דוגמה זו מראה כיצד למצוא ערכי טקסט בקובץ DWG/DXF והיא יכולה להיות בשימוש גם בשביל החלפת ערכי טקסט.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **הוספת פריטי טקסט ו-MText חדשים**

הנה הדוגמה כיצד להוסיף אובייקטים של טקסט/Mtext חדשים לציור. הוספת ישויות חדשות עשויה לשנות את גודל הציור, לכן מומלץ
לקרוא ל-UpdateSize() לאחר פעולות אלו.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
