---
title: A minőségi beállítások konfigurálása szövegekhez, hatchingekhez és ívekhez
type: docs
weight: 46
url: /hu/net/developer-guide/how-to/setting-up-quality-options-for-the-text-hatches-and-arcs/
---

## **Hogyan konfiguráljuk a minőségi beállításokat szövegekhez, hatchingekhez és ívekhez**

**Probléma:** Hogyan konfiguráljuk a minőségi beállításokat szövegekhez, hatchingekhez és ívekhez (CADNET-986).

**Tippek:** A szövegek, vonalak és ívek minőségi paramétereinek beállításához ezeket a beállításokat a rasterizationOptions osztályban kell megtenni (rasterizationOptions.Quality.Text, rasterizationOptions.Quality.Hatch, rasterizationOptions.Quality.Arc, rasterizationOptions.Quality.ObjectsPrecision).

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "setting-up-quality-options-for-the-text-hatches-and-arcs.cs" >}}
