---
title: ליצור מלבן כקווים ולמלא אותו עם חציצה
type: docs
weight: 24
url: /he/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **איך ליצור מלבן כקווים ולמלא אותו עם חציצה**

**בעיה:** איך ליצור מלבן כקווים ולמלא אותו עם חציצה (CADNET-1351).

**טיפים:** כדי לעשות זאת, צור CadLwPolyline והוסף את קואורדינטות הנקודות אליו, השתמש ב-CadHatch לעבודה עם צבע והשתמש ב-CadEdgeBoundaryPath כדי לחבר, השתמש ב-CadHatch לעבודה עם זוויות ו-CadHatchPatternData עבור דפוס.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
