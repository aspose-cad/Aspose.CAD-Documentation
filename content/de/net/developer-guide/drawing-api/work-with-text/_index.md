---
title: Arbeiten mit Text
type: docs
weight: 40
url: /de/net/work-with-text/
---

## **Arbeiten mit Text**

Fast alle Zeichnungen enthalten Textobjekte, und diese Beispiele zeigen, wie man Operationen damit durchführt. 
Es gibt verschiedene Typen von Entitäten für DWG/DXF, die Text speichern können: [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Die letzten beiden Typen stehen typischerweise in Beziehung zu 
[**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
und sind darin oder im entsprechenden Block gespeichert.

Hier sind einige Beispiele, die Operationen mit Text beschreiben.

### **Text suchen**

Dieses Beispiel zeigt, wie man Textwerte in der DWG/DXF-Datei findet und kann auch zum Ersetzen von Textwerten verwendet werden.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Neue Text- und MText-Objekte hinzufügen**

Hier ist das Beispiel, wie man neue Text/MText-Objekte zur Zeichnung hinzufügt. Das Hinzufügen neuer Entitäten kann die Größe der Zeichnung ändern, daher wird empfohlen,
UpdateSize() nach diesen Operationen aufzurufen.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
