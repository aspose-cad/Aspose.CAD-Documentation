---
title: Convertire i Disegni CAD in Formati PDF e Immagine Raster
type: docs
weight: 30
url: /it/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD per Java scrive direttamente le informazioni su API e Numero di Versione nei documenti di output. Ad esempio, durante il rendering del Documento in PDF, Aspose.CAD per Java popola il campo Application con il valore 'Aspose.CAD' e il campo PDF Producer con un valore, ad esempio 'Aspose.CAD v 17.9'.

Si prega di notare che non puoi istruire Aspose.CAD per Java a cambiare o rimuovere queste informazioni dai documenti di output.

{{% /alert %}} 
## **Convertire i Disegni CAD in Formati di Immagine Raster**
Aspose.CAD per Java è in grado di convertire i formati di disegno CAD come [**DXF**](https://docs.fileformat.com/cad/dxf/) e [**DWG**](https://docs.fileformat.com/cad/dwg/) in formati di immagine raster supportati come [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) e [**GIF**](https://docs.fileformat.com/image/gif/). L'API Aspose.CAD per Java ha esposto mezzi efficienti e facili da usare per raggiungere questo obiettivo.
Puoi convertire qualsiasi formato di disegno CAD supportato in formati di immagine raster seguendo i semplici passaggi descritti di seguito.

1. Carica il file CAD in un'istanza di [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e imposta le proprietà obbligatorie come [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) e [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Crea un'istanza di **ImageOptionsBase** e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) all'istanza di **CadRasterizationOptions** creata nel passaggio precedente.
1. Chiama **Image.save** passando il percorso del file (o un oggetto di MemoryStream) e l'istanza di [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) creata nel passaggio precedente.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Per impostazione predefinita, l'API rende solo il layout "Model". Tuttavia, puoi anche specificare i layout di tua scelta mentre converte i disegni CAD in formati immagine.
## **Personalizzare la Conversione CAD**
Le procedure di conversione da CAD a [PDF](https://docs.fileformat.com/pdf/) e da CAD a immagine raster sono altamente configurabili perché la classe [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) è stata implementata in modo tale da fornire molte funzionalità opzionali che, una volta impostate, possono sovrascrivere il processo di rendering secondo le esigenze dell'applicazione.
### **Classe CadRasterizationOptions**
La classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) è comune per tutti i formati CAD supportati come [**DWG**](https://docs.fileformat.com/cad/dwg/) e [DXF](https://docs.fileformat.com/cad/dxf/), pertanto, le informazioni condivise in questo articolo sono valide per entrambi i formati CAD sopra citati.

Le proprietà più utili della classe **CadRasterizationOptions** sono:

|**Proprietà**|**Valore Predefinito**|**Richiesta**|**Descrizione**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Sì|Specificare la larghezza della pagina.|
|**PageHeight**|**0**|Sì|Specificare l'altezza della pagina.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|No|Specifica se il disegno deve essere ridimensionato automaticamente. Il valore predefinito riduce automaticamente l'immagine per adattarsi alle dimensioni della tela. Passa alla modalità **GrowToFit** o utilizza l'impostazione **None** per disattivare il ridimensionamento automatico.|
|**BackgroundColor**|**Color.White**|No|Specifica il colore di sfondo dell'immagine di output.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|No|Specifica il modo di colorazione dell'entità. Specifica l'opzione **UseObjectColor** per disegnare entità utilizzando il loro colore nativo, oppure l'opzione **UseDrawColor** per sovrascrivere i colori nativi.|
|**DrawColor**|**Color.Black**|No|Specifica il colore dell'entità sovrascritto (solo se **DrawType** è impostato sul valore della proprietà **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|No|Specifica se deve essere eseguito il ridimensionamento automatico del layout per adattarsi al layout Model.|
### **Impostazione delle Dimensioni e della Modalità della Tela**
L'esportazione da CAD a PDF o da CAD a formati immagine raster non è un compito banale. Poiché il PDF risultante o l'immagine richiede che la dimensione della tela sia definita, è necessario specificare le dimensioni di output per la pagina PDF al fine di rendere correttamente il disegno. Imposta esplicitamente le proprietà **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**, altrimenti potresti ricevere un'**ImageSaveException**.

Inoltre, puoi specificare opzioni di scala delle dimensioni. Le opzioni di scaling sono impostate dalla proprietà **CadRasterizationOptions.ScaleMethod**. Utilizza questa opzione per regolare automaticamente le dimensioni dell'immagine in base ai valori **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**. Per impostazione predefinita, la **CadRasterizationOptions.ScaleMethod** è impostata sulla modalità **ScaleType.ShrinkToFit**. Questa proprietà definisce il seguente comportamento:

- Se le dimensioni del disegno CAD sono maggiori delle dimensioni della tela risultante, le dimensioni del disegno vengono ridotte per adattarsi alla tela risultante mantenendo il rapporto d'aspetto.
- Se le dimensioni del disegno CAD sono più piccole delle dimensioni della tela risultante, impostare la proprietà **CadRasterizationOptions.ScaleMethod** su **ScaleType.GrowToFit** per aumentare la dimensione del disegno affinché si adatti alla tela PDF mantenendo il rapporto d'aspetto.
- Oppure disattivare il ridimensionamento automatico con l'opzione **ScaleType.None**.

Il campione di codice qui sotto mostra l'opzione di ridimensionamento automatico in uso.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Impostazione dei Colori di Sfondo e di Disegno**
Per impostazione predefinita, la tavolozza dei colori per la tela risultante è impostata sullo schema del documento comune. Ciò significa che tutte le entità all'interno del disegno CAD sono disegnate con una penna di colore nero su uno sfondo bianco solido. Queste impostazioni possono essere modificate con le proprietà **CadRasterizationOptions.BackgroundColor** e **CadRasterizationOptions.DrawColor**. La modifica della proprietà **CadRasterizationOptions.DrawColor** richiede anche di impostare la proprietà **CadRasterizationOptions.DrawType** per utilizzare il colore di disegno. La proprietà **CadRasterizationOptions.DrawType** controlla se le entità CAD preservano i loro colori o vengono convertite in colori personalizzati. Per preservare i colori delle entità, specificare **CadRasterizationOptions.DrawType** come **CadDrawTypeMode.UseObjectColor**, altrimenti specificare il valore **CadDrawTypeMode.UseDrawColor**.

Il campione di codice qui sotto mostra come utilizzare le diverse proprietà di colore.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Impostazione del Ridimensionamento Automatico del Layout**
La maggior parte dei disegni CAD ha più di un layout memorizzato in un singolo file, e ogni layout potrebbe avere dimensioni diverse. Durante il rendering di tali disegni CAD in PDF, ogni pagina del PDF potrebbe avere scaling diverso in base alle dimensioni del layout. Per rendere il rendering omogeneo, le API Aspose.CAD hanno esposto la proprietà **CadRasterizationOptions.AutomaticLayoutsScaling**. Il suo valore predefinito è **false** ma quando è impostato a true, l'API cercherà di trovare una scala corrispondente per ciascun layout separato e disegnarli in modo corrispondente eseguendo un'operazione di ridimensionamento automatico in base alla dimensione della pagina.

Ecco come funziona la proprietà **CadRasterizationOptions.AutomaticLayoutsScaling** in collaborazione con la proprietà **CadRasterizationOptions.ScaleMethod**.

1. Se **ScaleMethod** è impostato su **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** impostato su false, tutti i layout (inclusa la Model) saranno elaborati secondo la prima opzione.
1. Se **ScaleMethod** è impostato su **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** impostato su true, tutti i layout (eccetto Model) saranno elaborati in base alle loro dimensioni mentre la Model sarà elaborata secondo la prima opzione.
1. Se **ScaleMethod** è impostato su **ScaleType.None** con **AutomaticLayoutsScaling** impostato su true o false, non verrà eseguito alcun ridimensionamento.

Il campione di codice qui sotto mostra come impostare il ridimensionamento automatico del layout per la conversione da CAD a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Convertire i Layout CAD in Formati di Immagine Raster**
L'API Aspose.CAD per Java è in grado di convertire i layout CAD di formati supportati come DXF e DWG in immagini raster come PNG, BMP, TIFF, JPEG e GIF. L'API fornisce anche supporto per il rendering dei layout specifici di un disegno CAD su diversi livelli PSD. 
L'API Aspose.CAD per Java ha esposto mezziefficienti e facili da usare per specificare l'elenco dei layout CAD richiesti e renderli in formati di immagine raster. Ecco come puoi raggiungere lo stesso in 5 semplici passaggi come elencato di seguito.

1. Carica il file CAD in un'istanza di **Image** utilizzando il metodo factory **load**.
1. Crea un'istanza di **CadRasterizationOptions** e imposta le sue proprietà obbligatorie come **PageWidth** e **PageHeight**.
1. Specifica il nome del layout desiderato utilizzando la proprietà CadRasterizationOptions.Layouts.
1. Crea un'istanza di **ImageOptionsBase** e imposta la sua proprietà **VectorRasterizationOptions** all'istanza di **CadRasterizationOptions** creata nel passaggio precedente.
1. Chiama il metodo **Image.Save** passando il percorso del file (o un oggetto di MemoryStream) e l'istanza di **ImageOptionsBase** creata nel passaggio precedente.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

La proprietà **CadRasterizationOptions.Layouts** è di tipo array di stringhe quindi puoi specificare più di un layout alla volta per la possibile conversione in formati immagine. Specificando più layout per la proprietà **CadRasterizationOptions.Layouts**, l'immagine TIFF risultante avrà più pagine, l'immagine GIF avrà più frame e il formato PSD avrà più livelli, dove ogni pagina/frame/livello rappresenta un layout AutoCAD individuale. Nel caso venga selezionato un altro formato immagine come PNG, BMP, JPEG per memorizzare il risultato, l'API renderà solo il layout predefinito; ovvero "Model".

{{% /alert %}} 
## **Abilitare il Monitoraggio per il Processo di Rendering CAD**
Aspose.CAD ha introdotto una serie di classi e campi di enumerazione di supporto per assistere nel monitorare il processo di rendering CAD. Con questi cambiamenti in atto, la conversione da CAD a PDF può ora essere effettuata come segue abilitando il monitoraggio.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Il monitoraggio del processo di rendering CAD può rilevare i seguenti problemi potenziali.

1. Informazioni di intestazione mancanti o danneggiate.
1. Informazioni di layout mancanti.
1. Entità di blocco mancanti.
1. Stili dimensionale mancanti.
1. Stili mancanti.
## **Sostituire i Font durante la Conversione dei Disegni CAD**
È possibile che un particolare disegno CAD utilizzi un font specifico che non è disponibile sulla macchina in cui si sta effettuando la conversione da CAD a PDF o da CAD a immagine raster. In tali situazioni, l'API Aspose.CAD attiverà un'eccezione appropriata per evidenziare il/ i font mancanti e interrompere il processo di conversione poiché l'API richiede questi font per rendere correttamente i contenuti sul PDF risultante e/o sulle immagini.
L'API Aspose.CAD fornisce un modo semplice per utilizzare il meccanismo per sostituire i font richiesti con i font disponibili. La proprietà **CadImage.Styles** restituisce un'istanza di **CadStylesDictionary** che a sua volta contiene il **CadStyleTableObject** per ogni stile nel disegno CAD, mentre il **CadStyleTableObject.PrimaryFontName** può essere utilizzato per specificare il nome del font disponibile.

Il seguente snippet di codice dimostra l'uso dell'API Aspose.CAD per Java per cambiare il font di tutti gli stili in un disegno CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




È anche possibile cambiare il font di un particolare stile accedendo ad esso tramite il nome dello stile. Il seguente snippet di codice dimostra l'uso di questo approccio.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Convertire i Layer CAD in Formati di Immagine Raster**
L'API Aspose.CAD per Java ha esposto un mezzo efficiente e facile da usare per specificare il nome del layer CAD richiesto e renderlo in formati di immagine raster. Ecco come puoi raggiungere lo stesso in 5 semplici passaggi come elencato di seguito.

1. Carica il file CAD in un'istanza di **Image** utilizzando il metodo factory **load**.
1. Crea un'istanza di **CadRasterizationOptions** e imposta le sue proprietà obbligatorie come **PageWidth** e **PageHeight**.
1. Aggiungi il nome del layer desiderato utilizzando il metodo **CadRasterizationOptions.Layers.add**.
1. Crea un'istanza di **ImageOptionsBase** e imposta la sua proprietà **VectorRasterizationOptions** all'istanza di **CadRasterizationOptions** creata nel passaggio precedente.
1. Chiama il metodo **Image.save** passando il percorso del file (o un oggetto di MemoryStream) e l'istanza di **ImageOptionsBase** creata nel passaggio precedente.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Convertire Tutti i Layer CAD in Immagini Separate**
Puoi ottenere tutti i layer da un disegno CAD utilizzando **CadImage.Layers** e rendere ogni layer in un'immagine separata come dimostrato qui sotto.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Convertire i Layer CAD DWF in Formati di Immagine Raster**
L'API Aspose.CAD per Java ha esposto un mezzo efficiente e facile da usare per specificare il nome del layer CAD richiesto e renderlo in formati di immagine raster. Ecco come puoi raggiungere lo stesso in 5 semplici passaggi come elencato di seguito.

1. Carica il file CAD DWF in un'istanza di **Image** utilizzando il metodo factory **Load**.
1. Crea un'istanza di **CadRasterizationOptions** e imposta le sue proprietà obbligatorie come **PageWidth** e **PageHeight**.
1. Aggiungi il nome del layer desiderato utilizzando il metodo **CadRasterizationOptions.Layers.Add**.
1. Crea un'istanza di **ImageOptionsBase** e imposta la sua proprietà **VectorRasterizationOptions** all'istanza di **CadRasterizationOptions** creata nel passaggio precedente.
1. Chiama il metodo **Image.Save** passando il percorso del file (o un oggetto di MemoryStream) e l'istanza di **ImageOptionsBase** creata nel passaggio precedente.

Ecco il codice sorgente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
