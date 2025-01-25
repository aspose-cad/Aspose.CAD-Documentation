---
title: Verweise auf externe Dateien erhalten
type: docs
weight: 36
url: /de/net/how-to/get-references-to-external-files/
---

## **Wie man Verweise auf externe Dateien erhält**

**Problem:** Wie man Verweise auf externe Dateien erhält (CADNET-110).

**Tipps:** Um Verweise auf externe Dateien für Zeichnungen im Entity-Block zu erhalten, gibt es ein XRef PathName-Feld für Rasterbilder. CadRasterImage Def wird für externe Überlagerungen verwendet und CadDgnUnderlay wird verwendet, und sein UnderlayPath-Feld.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
