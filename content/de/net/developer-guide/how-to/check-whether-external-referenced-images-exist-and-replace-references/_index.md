---
title: Überprüfen, ob externe referenzierte Bilder existieren und Referenzen ersetzen
type: docs
weight: 22
url: /de/net/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **So bearbeiten Sie Hyperlinks auf Objekten**

**Problem:** Wie überprüfe ich, ob externe referenzierte Bilder existieren und ersetze Referenzen (CADNET-8088).

**Tipps:** Um dies zu tun, erhalten Sie eine Entität des Typs CadObjectTypeName.IMAGEDEF aus den Zeichnungselementen und verwenden Sie CadRasterImageDef zur Überprüfung.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
