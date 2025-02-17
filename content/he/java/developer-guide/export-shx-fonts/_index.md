---
title: ייצוא גופני SHX
type: docs
weight: 40
url: /he/java/developer-guide/export-shx-fonts/
---

## **ייצוא גופני SHX עבור ציורי DXF/DWG**

חלק מהציורים עשויים contain גופנים בפורמט מיוחד SHX, אשר מאחסן סמלים של הגופן בצורה של צורות.
פורמט זה דורש הליך טעינה נוסף עבור כל גופן שמשמש בציור.
Apose.CAD יכול לייצא ציורים עם טקסט כתוב בשפה SHX ויש לו אפשרויות שונות לעשות זאת.
הדרך הפשוטה ביותר לעשות זאת היא פשוט להשתמש ב-[**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) 
של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) אובייקט.	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

כל גופן SHX מגיע עם קוד דף מתאים שקשור אליו. אסוציאציות אלו ידועות וחלקן משולבות לחלקם ב-Aspose.CAD עבור גופנים ידועים SHX.
במקרה שבו גופן SHX מותאם אישית используется, ניתן להפעיל את **setShxCodePages** 
ובעת הצורך להגדיר נתיב לקובץ SHX ולקוד דף המתאים לו.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
