---
title: שגיאות חזרה במהלך ייצוא וטעינה
type: docs
weight: 40
url: /he/net/developer-guide/callback-errors-during-export-and-loading/
---

## **סקירה של שגיאות חזרה במהלך ייצוא וטעינה**

יתכן שבמהלך הייצוא או טעינת הקובץ ניתקל בשגיאות הקשורות למבנה הקובץ 
(למשל, חלקים בקובץ נדרשים כעת אך לא קודם). 
חלקן קריטיות ובמקרים כאלה יוצאת חריגה, אך אנו יכולים גם להתעלם מכמה מהן פנימית ולהודיע על כך באמצעות הודעות חזרה. 
בכל מקרה, כל ההודעות הללו דורשות תשומת לב כי הן עשויות להסביר למשל ישויות חסרות בתוצאות הייצוא או השפעות אחרות.

### **שגיאות במהלך ייצוא**

יש שדה RenderResult ב- [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
שמכיל את IsRenderComplete כדי לבדוק אם היו שגיאות במהלך הייצוא ולהדפיס מידע עליהם:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **שגיאות במהלך טעינה**

כמה בעיות עם ציורים עשויות להתגלות מוקדם יותר לפני שיתחיל תהליך הייצוא. 
המאפיין [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) ב-
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) משמש לאחסון הודעות על כך. 
המאפיין [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) מועיל כדי להחליט האם 
דרוש לזרוק חריגה על שגיאות טעינה או לא. 

הנה דוגמה לשימוש במאפיין Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
