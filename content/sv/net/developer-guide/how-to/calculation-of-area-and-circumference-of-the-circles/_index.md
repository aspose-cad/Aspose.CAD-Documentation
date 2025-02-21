---
title: Beräkning av area och omkrets av cirklar
type: docs
weight: 18
url: /sv/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **Hur man beräknar area och omkrets av cirklar**

**Problem:** Hur man beräknar area och omkrets av cirklar (CADNET-1153).

**Tips:** För att göra detta, hämta radien från CadEntityTypeName.CIRCLE från enheterna och använd formeln **"2 * Math.PI * radius"**.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
