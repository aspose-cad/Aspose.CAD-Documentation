---
title: Disegno DGN
type: docs
weight: 10
url: /it/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Disegno del formato DGN come parte del DWG**

Aspose.CAD per Java consente agli sviluppatori di esportare un file DWG con un sottolivello DGN incorporato all'interno. Di seguito è riportato il codice che dimostra come accedere al sottolivello DGN all'interno di un file DWG durante l'esportazione del file DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Supporto per entità 3D per DGN v7**

L'API Aspose.CAD per Java ha introdotto la funzionalità per caricare un file AutoCAD DGN e supportare entità 3D per DGN v7. La classe [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) serve a questo scopo. Ogni immagine DGN supporta 9 viste predefinite. È enumerato da 1 a 9. Se la vista non è definita durante l'esportazione, per formati di output a più pagine (come PDF) tutte le viste verranno esportate, ciascuna su una pagina separata. Le entità 3D sono supportate nel formato file DGN, così come le entità 2D. 
VectorRasterizationOptions.TypeOfEntities non è più utilizzato per il formato DGN (sia 2D che 3D sono supportati simultaneamente).

Codice di esempio per visualizzare gli elementi DGN supportati.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
