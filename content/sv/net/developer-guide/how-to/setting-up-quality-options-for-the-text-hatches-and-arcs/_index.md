---
title: Ställa in kvalitetsalternativ för text, hatcher och bågar
type: docs
weight: 46
url: /sv/net/developer-guide/how-to/setting-up-quality-options-for-the-text-hatches-and-arcs/
---

## **Hur man ställer in kvalitetsalternativ för text, hatcher och bågar**

**Problem:** Hur man ställer in kvalitetsalternativ för text, hatcher och bågar (CADNET-986).

**Tips:** För att justera kvalitetsparametrarna för text, linjer och bågar görs dessa justeringar i klassen rasterizationOptions (rasterizationOptions.Quality.Text, rasterizationOptions.Quality.Hatch, rasterizationOptions.Quality.Arc, rasterizationOptions.Quality.ObjectsPrecision).

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "setting-up-quality-options-for-the-text-hatches-and-arcs.cs" >}}
