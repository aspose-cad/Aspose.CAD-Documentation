---
title: העברת נקודת המקור של ההחתמה קרוב יותר לגבול ההחתמה לשיפור ביצועים
type: docs
weight: 41
url: /he/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **איך להעביר את נקודת המקור של ההחתמה קרוב יותר לגבול ההחתמה לשיפור ביצועים**

**בעיה:** איך להעביר את נקודת המקור של ההחתמה קרוב יותר לגבול ההחתמה לשיפור ביצועים (CADNET-1340).

**טיפים:** כדי לעשות זאת, קבל את ישויות CadHatch מהסרטוט, הגדר את הנקודות הדרושות עם Point2D, חישב את המרחק וב- CadHatchPatternData הגדר את LineBasePoint עבור X ו-Y.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
