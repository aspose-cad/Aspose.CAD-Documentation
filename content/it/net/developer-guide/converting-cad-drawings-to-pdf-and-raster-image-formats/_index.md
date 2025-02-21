---
title: DWG DXF a PDF C# | Convertire file Auto CAD in PDF JPEG PNG in C# .NET
type: docs
weight: 30
url: /it/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG a PDF C#, DXF a PDF C#, DWF DWT a PDF C#, convertire AutoCAD, convertire DWG, convertire DWF, convertire DWT, convertire DXF, convertire autocad in pdf, convertire DWG in PDF, convertire DWG in PNG, convertire DWG in TIFF, convertire DWG in JPG"
description: Utilizza il convertitore AutoCAD a PDF in C# .NET per convertire DWG o DXF in PDF. Puoi convertire DWG, DWF, DWT e DXF in PDF, JPEG, PNG, BMP, GIF e TIFF in C# .NET.
---

## **Convertire DWG o DXF in PNG JPEG BMP GIF o TIFF in C#**

Aspose.CAD per .NET può convertire formati di disegno AutoCAD come [DXF](https://docs.fileformat.com/cad/dxf/) e [DWG](https://docs.fileformat.com/cad/dwg/) in [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) e [GIF](https://docs.fileformat.com/image/gif/). Ha esposto un'API efficiente e facile da usare per raggiungere questo obiettivo.

Puoi convertire qualsiasi formato di disegno AutoCAD supportato in formati di immagine raster utilizzando i semplici passaggi descritti di seguito.

1. Carica il file AutoCAD DWG o DXF nella classe [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Imposta/cambia le dimensioni dell'immagine utilizzando [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Crea un'istanza di [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) sull'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) creata nel passaggio precedente.
1. Salva il disegno AutoCAD come PDF con [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) passando il percorso del file (o un oggetto MemoryStream) e l'istanza di [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) creata nel passaggio precedente.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Per impostazione predefinita, l'API rende solo il layout "Model". Tuttavia, puoi anche specificare i layout a tua scelta durante la conversione dei disegni CAD in formati immagine.

## **Personalizzare la Conversione CAD**

Le procedure di conversione da CAD a [PDF](https://docs.fileformat.com/pdf/) e da CAD a immagini raster sono altamente configurabili perché la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) è stata implementata in modo tale da fornire molte funzionalità opzionali che, se impostate, possono sovrascrivere il processo di rendering in base alle esigenze dell'applicazione.

### **Classe CadRasterizationOptions**

La classe **CadRasterizationOptions** è comune a tutti i formati CAD supportati come DWG e DXF pertanto, le informazioni condivise in questo articolo sono valide per entrambi i formati CAD suddetti.

Le proprietà più utili della classe **CadRasterizationOptions** sono:

|**Proprietà**|**Valore di Default**|**Richiesto**|**Descrizione**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Sì|Specifica la larghezza della pagina.|
|**PageHeight**|**0**|Sì|Specifica l'altezza della pagina|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|No|Specifica se il disegno deve essere scalato automaticamente. Il valore predefinito riduce automaticamente l'immagine per adattarla alle dimensioni della tela. Passa alla modalità **GrowToFit**, o usa l'impostazione **None** per disabilitare il ridimensionamento automatico.|
|**BackgroundColor**|**Color.White**|No|Specifica il colore di sfondo dell'immagine di output.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|No|Specifica la modalità di colorazione dell'entità. Specifica l'opzione **UseObjectColor** per disegnare entità utilizzando il loro colore nativo, oppure l'opzione **UseDrawColor** per sovrascrivere i colori nativi.|
|**DrawColor**|**Color.Black**|No|Specifica il colore sovrascritto dell'entità (solo se **DrawType** è impostato sul valore della proprietà **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|No|Specifica se deve essere eseguito il ridimensionamento automatico dei layout per adattarsi al layout Model.|

### **Impostare le dimensioni e la modalità della tela**

Esportare da CAD a PDF o da CAD a formati immagine raster non è un compito banale. Poiché il PDF risultante o l'immagine richiedono che la dimensione della tela venga definita, dobbiamo specificare le dimensioni di output per la pagina PDF per visualizzare correttamente il disegno. Imposta esplicitamente le proprietà **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**, altrimenti potresti ricevere un'**ImageSaveException**.

Inoltre, puoi specificare le opzioni di scala delle dimensioni. Le opzioni di scalatura vengono impostate dalla proprietà **CadRasterizationOptions.ScaleMethod**. Usa questa opzione per regolare automaticamente le dimensioni dell'immagine in base ai valori di **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**. Per impostazione predefinita, **CadRasterizationOptions.ScaleMethod** è impostato sulla modalità **ScaleType.ShrinkToFit**. Questa proprietà definisce il seguente comportamento:

- Se le dimensioni del disegno CAD sono maggiori delle dimensioni della tela risultante, le dimensioni del disegno vengono ridotte per adattarsi alla tela risultante mantenendo il rapporto d'aspetto.
- Se le dimensioni del disegno CAD sono inferiori rispetto alle dimensioni della tela risultante, imposta la proprietà **CadRasterizationOptions.ScaleMethod** su **ScaleType.GrowToFit** per aumentare le dimensioni del disegno in modo che si adatti alla tela PDF mantenendo il rapporto d'aspetto.
- Oppure disabilita il ridimensionamento automatico con l'opzione **ScaleType.None**.

Il campione di codice sottostante mostra l'opzione di scalatura automatica in uso.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Impostare i colori di sfondo e di disegno**

Per impostazione predefinita, la tavolozza dei colori per la tela risultante è impostata sullo schema documento comune. Ciò significa che tutte le entità all'interno del disegno CAD vengono disegnate con una penna di colore nero su uno sfondo bianco uniforme. Queste impostazioni possono essere modificate con le proprietà **CadRasterizationOptions.BackgroundColor** e **CadRasterizationOptions.DrawColor**. Cambiare la proprietà **CadRasterizationOptions.DrawColor** richiede anche di impostare la proprietà **CadRasterizationOptions.DrawType** per poter utilizzare il colore di disegno. La proprietà **CadRasterizationOptions.DrawType** controlla se le entità CAD preservano i loro colori o vengono convertite in colori personalizzati. Per preservare i colori delle entità, specifica **CadRasterizationOptions.DrawType** come **CadDrawTypeMode.UseObjectColor**, altrimenti specifica il valore **CadDrawTypeMode.UseDrawColor**.

Il campione di codice sottostante mostra come utilizzare le diverse proprietà di colore.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Impostare il ridimensionamento automatico del layout**

La maggior parte dei disegni CAD ha più di un layout memorizzato in un singolo file, e ogni layout potrebbe avere dimensioni diverse. Durante il rendering di tali disegni CAD in PDF, ogni pagina del PDF potrebbe avere scale diverse in base alle dimensioni del layout. Per rendere il rendering omogeneo, le API Aspose.CAD hanno esposto la proprietà **CadRasterizationOptions.AutomaticLayoutsScaling**. Il suo valore predefinito è **false** ma quando è vero, l'API cercherà di trovare una scala corrispondente per ciascun layout separato e disegnarli in modo corrispondente eseguendo un'operazione di ridimensionamento automatico in base alla dimensione della pagina.

Ecco come funziona la proprietà **CadRasterizationOptions.AutomaticLayoutsScaling** in collaborazione con la proprietà **CadRasterizationOptions.ScaleMethod**.

1. Se **ScaleMethod** è impostato su **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** impostato su false, allora tutti i layout (inclusa la Model) verranno elaborati secondo la prima opzione.
1. Se **ScaleMethod** è impostato su **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** impostato su true, allora tutti i layout (eccetto il Model) verranno elaborati in base alle loro dimensioni mentre il Model verrà elaborato in base alla prima opzione.
1. Se **ScaleMethod** è impostato su **ScaleType.None** con **AutomaticLayoutsScaling** impostato su true o false, allora non verrà eseguito alcun ridimensionamento.

Il campione di codice sottostante mostra come impostare il ridimensionamento automatico del layout per la conversione da CAD a PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Convertire layout DXF o DWG di AutoCAD in PNG o altri formati immagine in C#**

L'API Aspose.CAD per .NET può convertire layout CAD di formati supportati come DXF e DWG in PNG BMP TIFF JPEG e GIF. L'API fornisce anche supporto per rendere i layout specifici di un disegno CAD in diversi livelli PSD.

Ecco come puoi ottenere lo stesso in semplici passaggi.

- Carica il file AutoCAD DWG o DXF utilizzando la classe **Image**.
- Imposta/cambia la larghezza e l'altezza dell'immagine.
- Imposta il/i nome/i del layout desiderato utilizzando la proprietà CadRasterizationOptions.Layouts.
- Crea un'istanza di **ImageOptionsBase** e imposta la sua proprietà **VectorRasterizationOptions** sull'istanza di **CadRasterizationOptions** creata nel passaggio precedente.
- Salva il layout CAD come TIFF o immagine.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

La proprietà **CadRasterizationOptions.Layouts** è di tipo array di stringhe, quindi puoi specificare più layout contemporaneamente per la possibile conversione in formati immagine. Quando specifichi più layout per la proprietà **CadRasterizationOptions.Layouts**, l'immagine TIFF risultante avrà più pagine, l'immagine GIF avrà più frame e il formato [PSD](https://docs.fileformat.com/image/psd/) avrà più livelli, dove ciascuna pagina/frame/livello rappresenta un layout AutoCAD individuale. Nel caso venga selezionato un altro formato immagine come PNG, BMP, JPEG per memorizzare il risultato, allora l'API renderizzerà solo il layout predefinito; ovvero "Model".

{{% /alert %}}

## **Abilitare il tracciamento del processo di rendering CAD**

Aspose.CAD ha introdotto una serie di classi e campi di enumerazione di supporto per assistere con il tracciamento del processo di rendering CAD. Con queste modifiche in atto, la conversione da CAD a PDF può ora essere realizzata come segue abilitando il tracciamento.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Il tracciamento del processo di rendering CAD può rilevare i seguenti possibili problemi.

1. Mancanza o corruzione di informazioni nell'intestazione.
1. Mancanza di informazioni sul layout.
1. Mancanza di entità blocco.
1. Mancanza di stili di dimensione.
1. Mancanza di stili.

## **Sostituire i font durante la conversione dei disegni CAD**

È possibile che un particolare disegno CAD utilizzi un font specifico che non è disponibile sulla macchina in cui sta avvenendo la conversione da CAD a PDF o da CAD a immagine raster. In tali situazioni, l'API Aspose.CAD genererà un'eccezione appropriata per evidenziare i font mancanti e fermare il processo di conversione perché l'API richiede questi font per visualizzare correttamente i contenuti nei PDF o nelle immagini risultanti.

L'API Aspose.CAD fornisce un modo semplice per utilizzare il meccanismo per sostituire i font richiesti con i font disponibili. La proprietà **CadImage.Styles** restituisce un'istanza di **CadStylesDictionary** che a sua volta contiene il **CadStyleTableObject** per ciascun stile nel disegno CAD, mentre **CadStyleTableObject.PrimaryFontName** può essere utilizzato per specificare il nome del font disponibile.

Il seguente snippet di codice dimostra l'uso dell'API Aspose.CAD per .NET per cambiare il font di tutti gli stili in un disegno CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

È anche possibile cambiare il font di un particolare stile accedendovi tramite il nome dello stile. Il seguente snippet di codice dimostra l'uso di questo approccio.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Convertire gli strati CAD in formati immagine raster**

L'API Aspose.CAD per .NET ha esposto un mezzo efficiente e facile da usare per specificare il nome dello strato CAD richiesto e renderizzarlo in formati immagine raster. Ecco come puoi raggiungere il risultato in 5 semplici passaggi come elencato di seguito.

1. Carica il file CAD in un'istanza di **Image** utilizzando il metodo di fabbrica **Load**.
1. Crea un'istanza di **CadRasterizationOptions** e imposta le sue proprietà obbligatorie come **PageWidth** e **PageHeight**.
1. Aggiungi il nome dello strato desiderato utilizzando il metodo **CadRasterizationOptions.Layers.Add**.
1. Crea un'istanza di **ImageOptionsBase** e imposta la sua proprietà **VectorRasterizationOptions** sull'istanza di **CadRasterizationOptions** creata nel passaggio precedente.
1. Chiama il metodo **Image.Save** passando il percorso del file (o un oggetto MemoryStream) e l'istanza di **ImageOptionsBase** creata nel passaggio precedente.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Convertire tutti gli strati CAD in immagini separate**

Puoi ottenere tutti gli strati da un disegno CAD utilizzando **CadImage.Layers** e renderizzare ciascun strato in un'immagine separata come dimostrato di seguito.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Convertire strati CAD DWF in formati immagine raster**

L'API Aspose.CAD per .NET ha esposto un mezzo efficiente e facile da usare per specificare il nome dello strato CAD richiesto e renderizzarlo in formati immagine raster. Ecco come puoi raggiungere il risultato in 5 semplici passaggi come elencato di seguito.

1. Carica il file CAD DWF in un'istanza di **Image** utilizzando il metodo di fabbrica **Load**.
1. Crea un'istanza di **CadRasterizationOptions** e imposta le sue proprietà obbligatorie come **PageWidth** e **PageHeight**.
1. Aggiungi il nome dello strato desiderato utilizzando il metodo **CadRasterizationOptions.Layers.Add**.
1. Crea un'istanza di **ImageOptionsBase** e imposta la sua proprietà **VectorRasterizationOptions** sull'istanza di **CadRasterizationOptions** creata nel passaggio precedente.
1. Chiama il metodo **Image.Save** passando il percorso del file (o un oggetto MemoryStream) e l'istanza di **ImageOptionsBase** creata nel passaggio precedente.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD per .NET scrive direttamente le informazioni su API e numero di versione nei documenti di output. Ad esempio, durante il rendering del documento in PDF, Aspose.CAD per .NET popola il campo Applicazione con valore 'Aspose.CAD' e il campo Produttore PDF con un valore, ad esempio 'Aspose.CAD v 17.10'.

Si prega di notare che non puoi istruire Aspose.CAD per .NET a modificare o rimuovere queste informazioni dai documenti di output.
