---
title: ایجاد مستطیل به عنوان پلی‌لاین و پر کردن آن با طرح
type: docs
weight: 24
url: /fa/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **چگونه مستطیل را به عنوان پلی‌لاین ایجاد کرده و آن را با طرح پر کنیم**

**مسئله:** چگونه مستطیل را به عنوان پلی‌لاین ایجاد کرده و آن را با طرح پر کنیم (CADNET-1351).

**نکات:** برای این کار، یک CadLwPolyline ایجاد کرده و مختصات نقاط را به آن اضافه کنید، از CadHatch برای کار با رنگ استفاده کنید و از CadEdgeBoundaryPath برای اتصال استفاده کنید، از CadHatch برای کار با زوایا و CadHatchPatternData برای الگو استفاده کنید.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
