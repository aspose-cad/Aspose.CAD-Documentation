---
title: Unterstützung von CTB-Dateien
type: docs
weight: 40
url: /de/java/developer-guide/support-ctb/
---

## **Unterstützung von CTB-Dateien**

Manchmal können Farben, Linienstärken und einige andere Optionen für Zeichnungen nicht nur aus den Zeichnungen selbst, sondern auch aus Plot-Stilen in separaten CTB-Dateien verwendet werden.
Der einfachste Weg, diese Informationen zu nutzen, besteht darin, die entsprechenden CTB-Dateien neben der Datei mit der Zeichnung im DWG/DXF-Format zu platzieren, und die Informationen daraus werden automatisch während des Exports angewendet.

Es ist auch möglich, alle CTB-Dateien in Form eines Streams zu laden, indem die Eigenschaft 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) des 
Objekts [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) verwendet wird.

Hier ist ein Beispiel, wie das gemacht wird:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
