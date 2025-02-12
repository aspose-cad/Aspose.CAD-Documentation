---
title: Schriften im SHX-Format exportieren
type: docs
weight: 40
url: /de/java/developer-guide/export-shx-fonts/
---

## **SHX-Schriften für DXF/DWG-Zeichnungen exportieren**

Einige Zeichnungen können Schriften im speziellen SHX-Format enthalten, das Symbole der Schrift in Form von Formen speichert.
Dieses Format erfordert ein zusätzliches Ladeverfahren für jede in der Zeichnung verwendete Schriftart.
Apose.CAD kann Zeichnungen mit Text exportieren, der in SHX geschrieben ist, und hat verschiedene Möglichkeiten, dies zu tun.
Der einfachste Weg, dies zu tun, besteht darin, einfach die Eigenschaft [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) des Objekts [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) zu verwenden.	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Jede SHX-Schriftart ist mit der entsprechenden Codepage verbunden. Diese Zuordnungen sind bekannt und teilweise in Aspose.CAD für bekannte SHX-Schriftarten eingebettet.
Im Falle der Verwendung einer benutzerdefinierten SHX-Schriftart ist es möglich, die Eigenschaft **setShxCodePages** zu verwenden und den Pfad zur SHX-Datei und die entsprechende Codepage festzulegen.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
