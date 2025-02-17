---
title: ייצוא גופני SHX
type: docs
weight: 40
url: /he/python-net/developer-guide/export-shx-fonts/
---

## **ייצוא גופני SHX עבור רישומים DXF/DWG**

חלק מהתרשימים עשויים להכיל גופנים בפורמט SHX מיוחד, אשר מאחסן סמלים של הגופן בצורה של צורות. פורמט זה דורש הליך טעינה נוסף עבור כל גופן שמשתמשים בו בתרשים. Apose.CAD יכול לייצא תרשימים עם טקסט כתוב ב-SHX ויש לו אפשרויות שונות לעשות זאת. הדרך הפשוטה ביותר לעשות זאת היא להשתמש ב
**ShxFonts** מאפיין של 
**CadRasterizationOptions** אובייקט.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
