---
title: התאמת גודל שרטוט CAD
type: docs
weight: 10
url: /he/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

על ידי שימוש בספריית Aspose.CAD עבור .NET, מפתחים יכולים להתאים את גודל שרטוט ה-CAD במהלך ההמרה לכל פורמט נתמך. נושא זה מסביר את הגישה להתאים את הגודל באופן אוטומטי או ידני באמצעות הה enum של [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) של [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **התאמת גודל שרטוט CAD**

Aspose.CAD עבור .NET מספק את הה enum של [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) כדי להתאים את גודל השרטוט במהלך ההמרה של פורמט CAD. ישנם שני דרכים להתאים את גודל השרטוט.

1. התאמת גודל אוטומטית.
1. התאמת גודל על ידי שימוש ב[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) של [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

להתאמת גודל אוטומטית, מפתחים אינם זקוקים לספק את מאפייני Width ו-Height של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) . הקוד לדוגמה המוצג למטה הוא דוגמה של גודל אוטומטי.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

ה enum של [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) נותן את היכולת להתאים את הקטנה כאשר מאפייני Width ו-Height אינם מוגדרים. הקוד לדוגמה המוצג למטה מדגים כיצד להשתמש ב[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
