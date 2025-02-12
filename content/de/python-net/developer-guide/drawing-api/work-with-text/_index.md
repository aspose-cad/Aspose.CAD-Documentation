---
title: Mit Text arbeiten
type: docs
weight: 40
url: /de/python-net/developer-guide/drawing-api/work-with-text/
---

## **Mit Text arbeiten**

Fast alle Zeichnungen enthalten Textobjekte, und diese Beispiele zeigen, wie man Operationen mit ihnen durchführt. Es gibt verschiedene Arten von Entitäten für DWG/DXF, die Text speichern können, nämlich **CadText**, **CadMText**, CadAttDef, CadAttrib. Die letzten beiden Typen sind typischerweise mit **CadInsertObject** verbunden und werden innerhalb davon oder im entsprechenden Block gespeichert.

Hier sind einige Beispiele, die Operationen mit Text beschreiben.

### **Text suchen**

Dieses Beispiel zeigt, wie man Textwerte in der DWG/DXF-Datei findet und kann auch zum Ersetzen von Textwerten verwendet werden.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
