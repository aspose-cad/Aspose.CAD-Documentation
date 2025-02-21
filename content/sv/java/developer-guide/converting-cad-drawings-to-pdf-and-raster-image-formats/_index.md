---
title: Konvertera CAD-ritningar till PDF och Rasterbildformat
type: docs
weight: 30
url: /sv/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD för Java skriver direkt information om API och versionsnummer i utdata dokumenten. Till exempel, vid rendering av dokument till PDF, fyller Aspose.CAD för Java i fältet "Application" med värdet "Aspose.CAD" och PDF Producer-fältet med ett värde, t.ex. "Aspose.CAD v 17.9".

Observera att du inte kan instruera Aspose.CAD för Java att ändra eller ta bort denna information från utdata dokument.

{{% /alert %}} 
## **Konvertera CAD-ritningar till Rasterbildformat**
Aspose.CAD för Java kan konvertera CAD-ritningsformat som [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) till de stödda rasterbildformat som [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). Aspose.CAD för Java API har expanderat effektiva och användarvänliga medel för att uppnå detta mål.
Du kan konvertera vilket som helst stödda CAD-ritningsformat till rasterbildformat genom att följa de enkla stegen som redovisas nedan.

1. Ladda CAD-filen i en instans av [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in dess obligatoriska egenskaper som [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Skapa en instans av **ImageOptionsBase** och ställ in dess [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) egenskap till instansen av **CadRasterizationOptions** som skapades i det föregående steget.
1. Anropa **Image.save** genom att skicka filvägen (eller ett objekt av MemoryStream) såväl som instansen av [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) som skapades i det föregående steget.

Här är den kompletta källkoden.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Som standard renderar API:t bara "Model"-layouten. Du kan dock också ange de layoutalternativ du vill ha när du konverterar CAD-ritningar till bildformat.
## **Anpassning av CAD-konvertering**
CAD till [PDF](https://docs.fileformat.com/pdf/) och CAD till rasterbildkonverteringsprocedurerna är mycket konfigurerbara eftersom [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) klassen har implementerats på ett sätt som ger många valfria funktioner som vid inställning kan åsidosätta renderingsprocessen enligt applikationens behov.
### **CadRasterizationOptions-klass**
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klassen är gemensam för alla stödda CAD-format som [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), därför är informationen som delas i denna artikel giltig för båda nämnda CAD-format.

De mest användbara egenskaperna i **CadRasterizationOptions**-klassen är:

|**Egenskap**|**Standardvärde**|**Obligatorisk**|**Beskrivning**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ja|Anger sidbredd.|
|**PageHeight**|**0**|Ja|Anger sidans höjd|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nej|Anger om ritningen automatiskt ska skalas. Standardvärdet minskar automatiskt bilden så att den passar in i storleken på duken. Växla till **GrowToFit**-läge, eller använd inställningen **None** för att inaktivera automatisk skalning.|
|**BackgroundColor**|**Color.White**|Nej|Anger bakgrundsfärgen för den utgående bilden.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nej|Anger färgläggningsmetoden för enheten. Ange **UseObjectColor**-alternativet för att rita enheter med deras ursprungliga färg eller **UseDrawColor**-alternativet för att åsidosätta ursprungliga färger.|
|**DrawColor**|**Color.Black**|Nej|Anger den åsidosatta enhetens färg (endast om **DrawType** är inställt på värdet **UseDrawColor** egenskap).|
|**AutomaticLayoutsScaling**|False|Nej|Anger om automatisk layoutskalning utförs för att matcha Model-layouten.|
### **Inställning av dukstorlek och läge**
Exporten från CAD till PDF eller CAD till rasterbildformat är inte en trivial uppgift. Eftersom den resulterande PDF:en eller bilden kräver att dukstorleken definieras, måste vi ange utdata dimensionerna för PDF-sidan för att korrekt rendera ritningen. Ställ in **CadRasterizationOptions.PageWidth** och **CadRasterizationOptions.PageHeight** egenskaperna uttryckligen, annars kan du få ett **ImageSaveException**.

Dessutom kan du ange dimensionalskalaalternativ. Skalaalternativen anges av **CadRasterizationOptions.ScaleMethod**-egenskapen. Använd detta alternativ för att automatiskt justera bildens dimensioner i enlighet med **CadRasterizationOptions.PageWidth** och **CadRasterizationOptions.PageHeight** värden. Som standard är **CadRasterizationOptions.ScaleMethod** inställt på **ScaleType.ShrinkToFit**-läge. Denna egenskap definierar följande beteende:

- Om CAD-ritningens dimensioner är större än den resulterande dukens storlek minskas ritningens dimensioner för att passa in i den resulterande duken samtidigt som bildförhållandet bevaras.
- Om CAD-ritningens dimensioner är mindre än den resulterande dukens storlek, sätt **CadRasterizationOptions.ScaleMethod**-egenskapen till **ScaleType.GrowToFit** för att öka ritningens storlek så att det passar in i PDF-duken samtidigt som bildförhållandet bevaras.
- Eller inaktivera automatisk skalning med alternativet **ScaleType.None**.

Kodexemplet nedan visar det automatiska skalningsalternativet i bruk.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Inställning av bakgrund och ritfärger**
Som standard är färgpaletten för den resulterande duken inställd på den gemensamma dokumentplanen. Det innebär att alla enheter i CAD-ritningen ritas med en svart färgpenna på en solid vit bakgrund. Dessa inställningar kan ändras med **CadRasterizationOptions.BackgroundColor** och **CadRasterizationOptions.DrawColor**-egenskaper. Att ändra **CadRasterizationOptions.DrawColor**-egenskapen kräver också att **CadRasterizationOptions.DrawType**-egenskapen ställs in för att kunna utnyttja den ritfärg som ska användas. **CadRasterizationOptions.DrawType**-egenskapen kontrollerar huruvida CAD-enheter bevarar sina färger eller konverteras till anpassade färger. För att bevara enhetsfärger, ange **CadRasterizationOptions.DrawType** som **CadDrawTypeMode.UseObjectColor**, annars ange värdet **CadDrawTypeMode.UseDrawColor**.

Kodexemplet nedan visar hur man använder olika färgegenskaper.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Inställning av automatisk layoutskalning**
De flesta CAD-ritningar har mer än en layout lagrad i en enda fil, och varje layout kan ha olika dimensioner. När sådana CAD-ritningar renderas till PDF, kan varje sida i PDF:en ha olika skalning enligt layoutstorleken. För att göra renderingen homogen har Aspose.CAD API:er exponerat **CadRasterizationOptions.AutomaticLayoutsScaling**-egenskapen. Dess standardvärde är **false** men när det är sant kommer API:t att försöka söka efter en motsvarande skala för varje separat layout och rita dem på ett motsvarande sätt genom att utföra automatisk storleksändring i förhållande till sidstorlek.

Så här fungerar **CadRasterizationOptions.AutomaticLayoutsScaling**-egenskapen i samarbete med **CadRasterizationOptions.ScaleMethod**-egenskapen.

1. Om **ScaleMethod** är inställt på **ScaleType.ShrinkToFit** eller **ScaleType.GrowToFit** med **AutomaticLayoutsScaling** inställt på false, kommer alla layouter (inklusive Model) att behandlas enligt det första alternativet.
1. Om **ScaleMethod** är inställt på **ScaleType.ShrinkToFit** eller **ScaleType.GrowToFit** med **AutomaticLayoutsScaling** inställt på true, kommer alla layouter (utom Model) att behandlas enligt sina storlekar medan Model kommer att behandlas enligt det första alternativet.
1. Om **ScaleMethod** är inställt på **ScaleType.None** med **AutomaticLayoutsScaling** inställt på true eller false, kommer ingen skalning att utföras.

Kodexemplet nedan visar hur man ställer in automatisk layoutskalning för CAD till PDF-konvertering.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Konvertera CAD-layouter till Rasterbildformat**
Aspose.CAD för Java API kan konvertera CAD-layouter i stödda format som DXF & DWG till rasterbilder som PNG, BMP, TIFF, JPEG & GIF. API:t tillhandahåller också stöd för att rendera specifika layouter av en CAD-ritning till olika PSD-lager. 
Aspose.CAD för Java API har expanderat effektiva och användarvänliga medel för att ange listan över önskade CAD-layouter och rendera dem till rasterbildformat. Så här kan du uppnå samma sak i 5 enkla steg som listas nedan.

1. Ladda CAD-filen i en instans av **Image** med hjälp av fabriksmetoden **load**.
1. Skapa en instans av **CadRasterizationOptions** och ställ in dess obligatoriska egenskaper som **PageWidth** & **PageHeight**.
1. Ange de önskade layoutnamnen med hjälp av CadRasterizationOptions.Layouts-egenskapen.
1. Skapa en instans av **ImageOptionsBase** och ställ in dess **VectorRasterizationOptions**-egenskap till instansen av **CadRasterizationOptions** som skapades i det föregående steget.
1. Anropa **Image.Save** genom att skicka filvägen (eller ett objekt av MemoryStream) såväl som instansen av **ImageOptionsBase** som skapades i det föregående steget.

Här är den kompletta källkoden.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Egenskapen **CadRasterizationOptions.Layouts** är av typen string-array så du kan ange mer än en layout åt gången för möjlig konvertering till bildformat. När du anger flera layouter för **CadRasterizationOptions.Layouts**-egenskapen, skulle den resulterande TIFF-bilden ha flera sidor, GIF-bilden skulle ha flera ramar och PSD-formatet skulle ha flera lager, där varje sida/ram/lager representerar en individuell AutoCAD-layout. Om något annat bildformat som PNG, BMP, JPEG väljs för att lagra resultatet, kommer API:t att rendera endast standardlayouten; det vill säga "Model".

{{% /alert %}} 
## **Aktivera spårning för CAD-renderingsprocessen**
Aspose.CAD har introducerat en serie klasser och stödjande uppräkningsfält för att hjälpa till med spårningen av CAD-renderingsprocessen. Med dessa förändringar på plats kan CAD till PDF-konvertering nu uppnås som följer när spårning aktiveras.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Spårning av CAD-renderingsprocessen kan upptäcka följande möjliga problem.

1. Saknad eller korrupt headerinformation.
1. Saknad layoutinformation.
1. Saknade block-enheter.
1. Saknade dimensionstylar.
1. Saknade stilar.
## **Ersätta teckensnitt vid konvertering av CAD-ritningar**
Det är ganska möjligt att en viss CAD-ritning använder ett specifikt teckensnitt som inte finns tillgängligt på den maskin där CAD till PDF eller CAD till rasterbildkonvertering pågår. I sådana situationer kommer Aspose.CAD API att utlösa ett lämpligt undantag för att belysa saknade teckensnitt och stoppa konverteringsprocessen eftersom API:t kräver dessa teckensnitt för att korrekt rendera innehållet på den resulterande PDF:en och/eller bilder.
Aspose.CAD API ger ett enkelt sätt att använda mekanismen för att ersätta de nödvändiga teckensnitten med de tillgängliga teckensnitten. Egenskapen **CadImage.Styles** returnerar en instans av **CadStylesDictionary** som i sin tur innehåller **CadStyleTableObject** för varje stil i CAD-ritningen, medan **CadStyleTableObject.PrimaryFontName** kan användas för att specificera det tillgängliga teckensnittsnamnet.

Följande kodsnutt demonstrerar användningen av Aspose.CAD för Java API för att ändra teckensnittet för alla stilar i en CAD-ritning.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Det är också möjligt att ändra teckensnittet för endast en viss stil genom att få tillgång till det via stilnamnet. Följande kodsnutt demonstrerar användningen av detta tillvägagångssätt.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Konvertera CAD-lager till Rasterbildformat**
Aspose.CAD för Java API har expanderat en effektiv och användarvänlig metod för att specificera namnet på det nödvändiga CAD-lagret och rendera det till rasterbildformat. Så här kan du uppnå samma sak i 5 enkla steg som listas nedan.

1. Ladda CAD-filen i en instans av **Image** med hjälp av fabriksmetoden **load**.
1. Skapa en instans av **CadRasterizationOptions** och ställ in dess obligatoriska egenskaper som **PageWidth** & **PageHeight**.
1. Lägg till det önskade lagernamnet med hjälp av **CadRasterizationOptions.Layers.add**-metoden.
1. Skapa en instans av **ImageOptionsBase** och ställ in dess **VectorRasterizationOptions**-egenskap till instansen av **CadRasterizationOptions** som skapades i det föregående steget.
1. Anropa metoden **Image.save** genom att skicka filvägen (eller ett objekt av MemoryStream) samt instansen av **ImageOptionsBase** som skapades i det föregående steget.

Här är den kompletta källkoden.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Konvertera Alla CAD-lager till Separata Bilder**
Du kan få alla lager från en CAD-ritning med hjälp av **CadImage.Layers** och rendera varje lager till en separat bild som demonstrerat nedan.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Konvertera DWF CAD-lager till Rasterbildformat**
Aspose.CAD för Java API har expanderat en effektiv och användarvänlig metod för att specificera namnet på det nödvändiga CAD-lagret och rendera det till rasterbildformat. Så här kan du uppnå samma sak i 5 enkla steg som listas nedan.

1. Ladda DWF CAD-filen i en instans av **Image** med hjälp av fabriksmetoden **Load**.
1. Skapa en instans av **CadRasterizationOptions** och ställ in dess obligatoriska egenskaper som **PageWidth** & **PageHeight**.
1. Lägg till det önskade lagernamnet med hjälp av **CadRasterizationOptions.Layers.Add**-metoden.
1. Skapa en instans av **ImageOptionsBase** och ställ in dess **VectorRasterizationOptions**-egenskap till instansen av **CadRasterizationOptions** som skapades i det föregående steget.
1. Anropa metoden **Image.Save** genom att skicka filvägen (eller ett objekt av MemoryStream) samt instansen av **ImageOptionsBase** som skapades i det föregående steget.

Här är den kompletta källkoden.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
