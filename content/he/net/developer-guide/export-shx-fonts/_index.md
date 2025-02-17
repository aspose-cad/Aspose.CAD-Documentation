---
title: ייצוא גופני SHX
type: docs
weight: 40
url: /he/net/developer-guide/export-shx-fonts/
---

## **ייצוא גופני SHX לציורי DXF/DWG**

חלק מהציורים עשויים להכיל גופנים בפורמט מיוחד SHX, ששומר סמלים של הגופן בצורה של צורות. פורמט זה דורש הליך טעינה נוסף עבור כל גופן המשמש בציור. Apose.CAD יכול לייצא ציורים עם טקסט כתוב ב-SHX ויש לו אפשרויות שונות לעשות זאת. הדרך הפשוטה ביותר לעשות זאת היא פשוט להשתמש בנכס 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) של
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) אובייקט.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


אפשר להימנע מהגדרת כל הנתיבים לגופני SHX מרובים עם הדוגמה הבאה:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
כל גופן SHX מגיע עם קודי שפות מתאימים המשויכים אליו. קשרים אלו ידועים וחלקם משולבים ב-Aspose.CAD עבור גופני SHX ידועים.
במקרה שבו נעשה שימוש בגופן SHX מותאם אישית, ניתן להחיל את הנכס ShxCodePages ולהגדיר את הנתיב לקובץ SHX ואת קוד השפה המתאים. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
