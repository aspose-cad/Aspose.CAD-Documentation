---
title: תמיכה בקבצי CTB
type: docs
weight: 40
url: /he/java/developer-guide/support-ctb/
---

## **תמיכה בקבצי CTB**

לפעמים צבעים, עובי קווים וכמה אפשרויות נוספות לדיאגרמות עשויים להיות בשימוש לא רק מדיאגרמות עצמן אלא גם מסגנונות הדפסה בקובצי CTB נפרדים. 
הדרך הפשוטה ביותר להשתמש במידע זה היא למקם את קובצי CTB המתאימים ליד הקובץ עם הדיאגרמה בפורמט DWG/DXF והמידע מהם ייושם 
באופן אוטומטי במהלך הייצוא.

כמו כן אפשרי לטעון את כל קובצי CTB בצורת זרם באמצעות 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) של 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 

הנה הדוגמה כיצד לעשות זאת:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
