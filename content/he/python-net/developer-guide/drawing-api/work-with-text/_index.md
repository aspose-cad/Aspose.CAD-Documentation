---
title: לעבוד עם טקסט
type: docs
weight: 40
url: /he/python-net/developer-guide/drawing-api/work-with-text/
---

## **לעבוד עם טקסט**

כמעט כל הציורים כוללים אובייקטי טקסט ודוגמאות אלו מראות כיצד לבצע פעולות איתם. 
ישנם סוגים שונים של ישויות עבור DWG/DXF שיכולים לאחסן טקסט, הם **CadText**, **CadMText**, CadAttDef, CadAttrib. שני הסוגים האחרונים מיועדים בדרך כלל ל- **CadInsertObject** ונשמרים בתוכו או בבלוק המתאים.

הנה כמה דוגמאות המתארות פעולות עם טקסט.

### **חיפוש אחרי הטקסט**

דוגמה זו מראה כיצד למצוא ערכי טקסט בקובץ DWG/DXF ועשויה לשמש גם להחלפת ערכי טקסט.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
