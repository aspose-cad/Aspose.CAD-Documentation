---
title: Esportazione del formato DGN AutoCAD
type: docs
weight: 50
url: /it/python-net/developer-guide/exporting-dgn-autocad/
---

## **Esportazione del formato DGN AutoCAD in PDF**

Aspose.CAD per Python API ha introdotto la funzionalità per caricare un file DGN AutoCAD e convertirlo in formato PDF. La classe **CadImage** serve a questo scopo.

È necessario caricare un file DGN esistente come **CadImage**. Crea un'istanza della classe **CadRasterizationOptions** e imposta diverse proprietà. Crea un'istanza della classe **PdfOptions** e passa l'istanza di **CadRasterizationOptions**. Ora chiama il metodo **save** dell'istanza della classe **CadImage**.

### Codice di esempio

Di seguito è riportata la dimostrazione del codice per convertire/esportare [DGN](https://docs.fileformat.com/cad/dgn/) in formato [PDF](https://docs.fileformat.com/pdf/).


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Esportazione del formato DGN AutoCAD in formato immagine raster**

Aspose.CAD per Python API ha introdotto la funzionalità per caricare un file DGN AutoCAD e convertirlo in un'immagine raster. La classe **CadImage** serve a questo scopo.

È necessario caricare un file DGN esistente come **CadImage**. Crea un'istanza della classe **CadRasterizationOptions** e imposta diverse proprietà. Crea un'istanza della classe **JpegOptions** e passa l'istanza di **CadRasterizationOptions**. Ora chiama il metodo **save** dell'istanza della classe **CadImage**.

### Codice di esempio

Di seguito è riportata la dimostrazione del codice per convertire/esportare [DGN](https://docs.fileformat.com/cad/dgn/) in immagine [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Supporto entità 3D per DGN v7**

Aspose.CAD per Python API ha introdotto la funzionalità per caricare un file [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD e supportare le entità 3D per DGN v7. La classe **CadImage** serve a questo scopo. Ogni immagine [DGN](https://docs.fileformat.com/cad/dgn/) supporta 9 viste predefinite. Sono numerate da 1 a 9. Se la vista non è definita all'esportazione, per i formati di output a più pagine (come il PDF) verranno esportate tutte le viste, ciascuna su una pagina separata. Le entità 3D sono supportate nel formato file DGN, così come le 2D. Per questo, viene utilizzato **VectorRasterizationOptions**, mentre TypeOfEntities non è più utilizzato per il formato DGN (sia 2D che 3D supportati simultaneamente).

### Codice di esempio

Di seguito è riportato un esempio di codice per visualizzare gli elementi DGN supportati.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
