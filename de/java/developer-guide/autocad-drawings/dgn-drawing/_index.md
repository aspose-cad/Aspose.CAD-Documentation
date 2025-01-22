---
title: Zeichnen im DGN-Format
type: docs
weight: 10
url: /de/java/dgn-zeichnung/
---

## **Zeichnen im DGN-Format als Teil von DWG**

Aspose.CAD für Java ermöglicht es Entwicklern, eine DWG-Datei mit eingebettetem DGN-Unterlage zu exportieren. Im Folgenden ist der Code dargestellt, der zeigt, wie auf die DGN-Unterlage in einer DWG-Datei zugegriffen wird, während die DWG-Datei exportiert wird.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Beispiele-src-main-java-com-aspose-cad-Beispiele-ExportierenDGN-ExpoortDGNAlsTeilvonDWG-ExportDGNAlsTeilvonDWG.java" >}}

## **Unterstützung von 3D-Entitäten für DGN v7**

Aspose.CAD für Java API hat die Funktionalität eingeführt, eine DGN-AutoCAD-Datei zu laden und 3D-Entitäten für DGN v7 zu unterstützen. Die [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) Klasse erfüllt diesen Zweck. Jedes DGN-Bild unterstützt 9 vordefinierte Ansichten. Es ist von 1 bis 9 aufgelistet. Wenn Ansicht beim Export nicht definiert ist, werden für mehrseitige Ausgabeformate (wie PDF) alle Ansichten exportiert, jeweils auf einer separaten Seite. 3D-Entitäten werden im DGN-Dateiformat unterstützt, ebenso wie 2D.
VectorRasterizationOptions.TypeOfEntities wird nicht mehr für das DGN-Format verwendet (2D und 3D werden gleichzeitig unterstützt).

Beispielcode, um unterstützte DGN-Elemente anzusehen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Beispiele-src-main-java-com-aspose-cad-Beispiele-ExportierenDGN-UnterstuetzungFuerDGNV7-UnterstuetzungFuerDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Beispiele-src-main-java-com-aspose-cad-Beispiele-ExportierenDGN-UnterstuetzteDGNElemente-UnterstuetzteDGNElemente.java" >}}
