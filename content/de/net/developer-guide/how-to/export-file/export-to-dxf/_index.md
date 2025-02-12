---
title: Exportieren nach DXF
type: docs
weight: 20
url: /de/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **Wie man nach DXF exportiert**

**Problem:** Wie man nach DXF exportiert.

**Tipps:** Dazu können Sie DxfOption, sowohl binär als auch normal, in den Datei-Speicheroptionen verwenden.

**Hinweis:** Eine der interessanten Funktionen ist die Möglichkeit, jedes unterstützte Dateiformat nach dxf zu speichern.
Es ist eine wirklich gute Funktion, hat jedoch mehrere Nuancen:
Das Speichern aus DXF/DWG-Dateiformaten - führt einen Export mit genauen Entitäten des Quellformats durch
Der Export aus anderen Formaten - führt den Export nur mit Linien- und Textentitäten durch.
Außerdem unterstützen wir ASCII- und binäre DXF-Dateiformate.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
