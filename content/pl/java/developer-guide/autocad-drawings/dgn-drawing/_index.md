---
title: Rysunek DGN
type: docs
weight: 10
url: /pl/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Rysunek w formacie DGN jako część DWG**

Aspose.CAD dla Javy pozwala deweloperom na eksportowanie pliku DWG z osadzonym podkładem DGN. Poniższy kod demonstruje, jak uzyskać dostęp do podkładu DGN wewnątrz pliku DWG podczas eksportowania pliku DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Wsparcie dla encji 3D w DGN v7**

API Aspose.CAD dla Javy wprowadziło funkcjonalność ładowania pliku AutoCAD DGN oraz wsparcie dla encji 3D w DGN v7. Klasa [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) służy temu celowi. Każdy obraz DGN obsługuje 9 zdefiniowanych widoków. Są one enumerowane od 1 do 9. Jeśli widok nie jest zdefiniowany przy eksporcie, dla formatów wyjściowych z wieloma stronami (takich jak PDF) wszystkie widoki będą eksportowane, każdy na osobnej stronie. Encje 3D są obsługiwane w formacie DGN, a także 2D. 

VectorRasterizationOptions.TypeOfEntities nie jest już używane dla formatu DGN (zarówno 2D, jak i 3D są obsługiwane jednocześnie).

Przykładowy kod do zbadania obsługiwanych elementów DGN.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
