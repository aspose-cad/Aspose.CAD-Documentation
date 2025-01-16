---
title: Výkres formátu DGN
type: docs
weight: 10
url: /cs/java/dgn-drawing/
---

## **Kreslení formátu DGN jako součást DWG**

Aspose.CAD pro Javu umožňuje vývojářům exportovat soubor DWG s vloženým podkladem DGN uvnitř. Následující kód ukazuje, jak přistupovat k podkladu DGN uvnitř souboru DWG během exportu souboru DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Podpora 3D prvků pro DGN v7**

API Aspose.CAD pro Javu zavedlo funkci načítání souboru DGN AutoCAD a podporu 3D prvků pro DGN v7. Třída [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) plní tuto úlohu. Každý obraz DGN podporuje 9 předdefinovaných zobrazení. Jsou vyjmenovány od 1 do 9. Pokud není zobrazení definováno při exportu, pro formáty s více stránkami (jako PDF) budou exportována všechna zobrazení, každé na samostatné stránce. 3D prvky jsou podporovány ve formátu souboru DGN, stejně jako 2D. Typ prvků VectorRasterizationOptions.TypeOfEntities se pro formát DGN (2D i 3D jsou podporovány současně) již nepoužívá.

Ukázkový kód pro prohlížení podporovaných prvků DGN.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
