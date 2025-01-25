---
title: Unterstützung von CTB-Dateien
type: docs
weight: 40
url: /de/net/support-ctb/
---

## **Unterstützung von CTB-Dateien**

Manchmal können Farben, Linienstärken und einige andere Optionen für Zeichnungen nicht nur aus den Zeichnungen selbst, sondern auch aus Plot-Styles in separaten CTB-Dateien verwendet werden. 
Der einfachste Weg, diese Informationen zu nutzen, besteht darin, die entsprechenden CTB-Dateien in der Nähe der Datei mit der Zeichnung im DWG/DXF-Format abzulegen, und die Informationen daraus werden automatisch beim Export angewendet.

Es ist auch möglich, alle CTB-Dateien in Form eines Streams zu laden, indem die 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) Eigenschaft des 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) Objekts verwendet wird.

Hier ist ein Beispiel, wie man dies tun kann:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
