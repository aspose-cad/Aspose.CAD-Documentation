---
title: התאמת גודל שרטוט CAD
type: docs
weight: 10
url: /he/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

באמצעות Aspose.CAD לספריית Python, מפתחים יכולים להתאים את גודל שרטוט ה-CAD במהלך ההמרה לכל פורמט נתמך. נושא זה מסביר את הגישה להתאמת הגודל באופן אוטומטי או ידני באמצעות האנום **UnitType** של מחלקת **ImageOptions**.

{{% /alert %}}

## **התאמת גודל שרטוט CAD**

Aspose.CAD עבור Python מספק את האנום **UnitType** כדי להתאים את גודל השרטוט במהלך ההמרה של פורמט ה-CAD. ישנן שתי דרכים להתאמת את גודל השרטוט.

1. התאמת גודל אוטומטית.
1. התאמת גודל באמצעות האנום **UnitType** של מחלקת **ImageOptions**

בהתאמת גודל אוטומטית, מפתחים אינם צריכים לספק את תכונות ה-Width וה-Height של מחלקת **CadRasterizationOptions**. להלן קטע קוד המספק דוגמה להתאמת גודל אוטומטית.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

האנום **UnitType** נותן את היכולת להתאים את הסקאלה כאשר תכונות ה-Width וה-Height אינם מוגדרות. להלן קטע קוד הממחיש כיצד להשתמש ב-**UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
