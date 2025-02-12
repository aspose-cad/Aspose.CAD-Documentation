---
title: Exportieren von SHX-Schriften
type: docs
weight: 40
url: /de/python-net/developer-guide/export-shx-fonts/
---

## **SHX-Schriften für DXF/DWG-Zeichnungen exportieren**

Einige Zeichnungen können Schriftarten im speziellen SHX-Format enthalten, das die Symbole der Schriftart in Form von Formen speichert. Dieses Format erfordert ein zusätzliches Ladeverfahren für jede in der Zeichnung verwendete Schriftart. Apose.CAD kann Zeichnungen mit Text, der in SHX geschrieben ist, exportieren und bietet verschiedene Optionen dafür. Der einfachste Weg, dies zu tun, besteht darin, die 
**ShxFonts**-Eigenschaft des 
**CadRasterizationOptions**-Objekts zu verwenden.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
