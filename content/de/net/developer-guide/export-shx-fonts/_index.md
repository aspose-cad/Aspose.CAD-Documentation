---
title: Exportieren von SHX-Schriften
type: docs
weight: 40
url: /de/net/developer-guide/export-shx-fonts/
---

## **Exportieren von SHX-Schriften für DXF/DWG-Zeichnungen**

Einige Zeichnungen können Schriften im speziellen SHX-Format enthalten, das Symbole der Schrift in Form von Formen speichert. Dieses Format erfordert ein zusätzliches
Ladeverfahren für jede im Zeichenpapier verwendete Schrift. Apose.CAD kann Zeichnungen mit Text, der in SHX geschrieben wurde, exportieren und bietet verschiedene Optionen dafür. Der einfachste Weg, dies zu tun, besteht darin, die 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) Eigenschaft des 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) Objekts zu verwenden.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


Es ist möglich, die Einrichtung aller Pfade zu mehreren SHX-Schriften mit dem folgenden Beispiel zu vermeiden:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts mit Ordnerbeispiel.cs">}}
	
Jede SHX-Schrift kommt mit dem entsprechenden Codepage, der damit verbunden ist. Diese Zuordnungen sind bekannt und teilweise im Aspose.CAD für bekannte SHX-Schriften eingebettet.
Im Falle einer benutzerdefinierten SHX-Schrift kann die ShxCodePages-Eigenschaft angewendet und der Pfad zur SHX-Datei und zur entsprechenden Codepage festgelegt werden. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
