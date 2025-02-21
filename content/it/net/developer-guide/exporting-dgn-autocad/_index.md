---
title: Esportazione del formato DGN AutoCAD
type: docs
weight: 50
url: /it/net/developer-guide/exporting-dgn-autocad/
---

## **Esportazione del formato DGN AutoCAD in PDF**

Aspose.CAD per .NET API ha introdotto la funzionalità per caricare un file DGN AutoCAD e convertirlo in formato PDF. La classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) serve a questo scopo.

È necessario caricare un file DGN esistente come [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta diverse proprietà. Crea un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e passa l'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Ora chiama il metodo [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dell'istanza della classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Codice di esempio

Di seguito è riportata la dimostrazione del codice per convertire/esportare [DGN](https://docs.fileformat.com/cad/dgn/) in formato [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Esportazione del formato DGN AutoCAD in formato immagine raster**

Aspose.CAD per .NET API ha introdotto la funzionalità per caricare un file DGN AutoCAD e convertirlo in un'immagine raster. La classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) serve a questo scopo.

È necessario caricare un file DGN esistente come [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta diverse proprietà. Crea un'istanza della classe [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) e passa l'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Ora chiama il metodo [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) dell'istanza della classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Codice di esempio

Di seguito è riportata la dimostrazione del codice per convertire/esportare [DGN](https://docs.fileformat.com/cad/dgn/) in immagine [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Supporto di entità 3D per DGN v7**

Aspose.CAD per .NET API ha introdotto la funzionalità per caricare un file DGN AutoCAD e supportare le entità 3D per DGN v7. La classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) serve a questo scopo. Ogni immagine [DGN](https://docs.fileformat.com/cad/dgn/) supporta 9 viste predefinite. Sono enumerate da 1 a 9. Se la vista non è definita in fase di esportazione, per formati di output a più pagine (come PDF) tutte le viste verranno esportate, ciascuna su una pagina separata. Le entità 3D sono supportate nel formato del file DGN, così come le 2D. Per questo, si utilizza [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), TypeOfEntities non è più utilizzato per il formato DGN (sia 2D che 3D supportati simultaneamente).

### Codice di esempio

Di seguito è riportato il codice di esempio per visualizzare gli elementi DGN supportati.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
