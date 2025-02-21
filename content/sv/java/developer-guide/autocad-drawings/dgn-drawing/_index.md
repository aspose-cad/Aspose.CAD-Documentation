---
title: DGN-ritning
type: docs
weight: 10
url: /sv/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Ritning i DGN-format som en del av DWG**

Aspose.CAD för Java tillåter utvecklare att exportera en DWG-fil med inbäddad DGN-underlag inuti. Följande är koden som demonstrerar hur man kommer åt DGN-underlaget inuti en DWG-fil vid export av DWG-filen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **3D-objektstöd för DGN v7**

Aspose.CAD för Java API har introducerat funktionaliteten att ladda en DGN AutoCAD-fil och stödja 3D-objekt för DGN v7. Klassen [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) tjänar syftet. Varje DGN-bild stöder 9 fördefinierade vyer. De är numrerade från 1 till 9. Om vy inte definieras vid export, för fler-sidiga utdataformat (som PDF) kommer alla vyer att exporteras, var och en på en separat sida. 3D-objekt stöds i DGN-filformatet, liksom 2D. 
VectorRasterizationOptions.TypeOfEntities används inte längre för DGN-formatet (både 2D och 3D stöds samtidigt).

Exempel kod för att se stödda DGN-element.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
