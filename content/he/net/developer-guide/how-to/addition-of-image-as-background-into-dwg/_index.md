---
title: הוספת תמונה כרקע ל-DWG
type: docs
weight: 15
url: /he/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **איך להוסיף תמונה כרקע ב-DWG**

**בעיה:** איך להוסיף תמונה כרקע ב-DWG.

**טיפים:** כדי לעשות זאת, צור אובייקט CadRasterImageDef עבור התמונה כרקע, צור אובייקט CadRasterImage להוסיף את הרקע עבור הציור, הוסף אובייקט CadRasterImage לאובייקטי הציור, צור אובייקט CadBaseObject והוסף אותו ל-cadImage.Objects, עבד את הכל דרך CadBlockTableObject.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
