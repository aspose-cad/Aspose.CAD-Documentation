---
title: ציור DGN
type: docs
weight: 10
url: /he/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **ציור בפורמט DGN כחלק מ-DWG**

Aspose.CAD for Java מאפשר למפתחים לייצא קובץ DWG עם שכבת DGN מוטמעת בתוכו. להלן הקוד המדגים כיצד לגשת לשכבת DGN בתוך קובץ DWG בזמן ייצוא קובץ ה-DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **תמיכה ביישויות תלת-ממדיות עבור DGN v7**

API של Aspose.CAD for Java הציגה את הפונקציה לטעון קובץ DGN AutoCAD ולתמוך ביישויות תלת-ממדיות עבור DGN v7. המטרה של מחלקת [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage). כל תמונת DGN תומכת ב-9 תצוגות מוגדרות מראש. זה ממוספר מ-1 עד 9. אם לא מוגדרת תצוגה בזמן הייצוא, עבור פורמטי פלט מרובי עמודים (כגון PDF) כל התצוגות ייוצאו, כל אחת על עמוד נפרד. יישויות תלת-ממדיות נתמכות בפורמט קובץ DGN, כמו גם יישויות דו-ממדיות.
האפשרות VectorRasterizationOptions.TypeOfEntities אינה בשימוש יותר עבור פורמט DGN (גם 2D וגם 3D נתמכים בו זמנית).

קוד לדוגמה להביט ביישויות ה-DGN הנתמכות.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
