---
title: DWG-Datei lesen, aktualisieren und schreiben
type: docs
weight: 11
url: /de/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Wie man eine DWG-Datei liest, aktualisiert und schreibt**

**Problem:** Wie liest, aktualisiert und schreibt man eine DWG-Datei.

**Tipps:** Um dies zu tun, können Sie die Datei mit der Lade-Methode abrufen, die erforderlichen Entitäten erhalten und Änderungen an ihnen vornehmen, wie beispielsweise die Anfangs- und Endpunkte oder die Dicke der Linien zu ändern.

**Hinweis:** Dieser Codeausschnitt zeigt ein Beispiel zum Lesen einer DWG-Datei, das Ändern von Objekten: die Positionen von Linien, Kreisen, Textwerten (Sie können Änderungen an anderen Objekten und ihren Werten vornehmen, für die das Lesen/Schreiben unterstützt wird) und dann das Speichern in einer neuen Datei. So können Sie eine neue Datei in AutoCAD öffnen und Objekte mit geänderten Werten sehen.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
