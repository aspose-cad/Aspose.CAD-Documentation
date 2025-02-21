---
title: DWG DXF till PDF C# | Konvertera Auto CAD-filer till PDF JPEG PNG i C# .NET
type: docs
weight: 30
url: /sv/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG till PDF C#, DXF till PDF C#, DWF DWT till PDF C#, konvertera AutoCAD, konvertera DWG, konvertera DWF, konvertera DWT, konvertera DXF, konvertera autocad till pdf, konvertera DWG till PDF, konvertera DWG till PNG, konvertera DWG till TIFF, konvertera DWG till JPG"
description: Använd C# .NET AutoCAD till PDF-konverterare för att konvertera DWG eller DXF till PDF i C#. Du kan konvertera DWG, DWF, DWT och DXF till PDF, JPEG, PNG, BMP, GIF och TIFF i C# .NET också.
---

## **Konvertera DWG eller DXF till PNG JPEG BMP GIF eller TIFF i C#**

Aspose.CAD för .NET kan konvertera AutoCAD-ritningsformat som [DXF](https://docs.fileformat.com/cad/dxf/) och [DWG](https://docs.fileformat.com/cad/dwg/) till [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) och [GIF](https://docs.fileformat.com/image/gif/). Den har exponerat ett effektivt och enkelt att använda API för att uppnå detta mål.

Du kan konvertera valfritt stödd AutoCAD-ritningsformat till rasterbildformat med hjälp av de enkla stegen som redogörs nedan.

1. Ladda AutoCAD DWG eller DXF-fil i [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) klassen.
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Ställ in/ändra storleken på bilden med [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) och [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Skapa en instans av [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Ställ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) egenskapen till den [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) som skapades i föregående steg.
1. Spara AutoCAD-ritningen som PDF med [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) genom att skicka filvägen (eller ett objekt av MemoryStream) samt instansen av [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) som skapades i föregående steg.

Här är den fullständiga källkoden.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Som standard renderar API:et endast "Modell"-layouterna. Du kan dock också specificera layouterna av ditt val när du konverterar CAD-ritningar till bildformat.

## **Customization CAD-konvertering**

CAD till [PDF](https://docs.fileformat.com/pdf/) och CAD till rasterbildkonverteringsprocedurer är mycket konfigurerbara eftersom [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klassen har implementerats på ett sådant sätt att den tillhandahåller många valfria funktioner som vid inställning kan åsidosätta renderingsprocessen enligt applikationens behov.

### **CadRasterizationOptions Class**

**CadRasterizationOptions** klassen är gemensam för alla stödda CAD-format som DWG och DXF därmed är informationen som delas i denna artikel giltig för båda de nämnda CAD-formaten.

De mest användbara egenskaperna i **CadRasterizationOptions** klassen är:

|**Egenskap**|**Standardvärde**|**Obligatoriskt**|**Beskrivning**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ja|Anger sidans bredd.|
|**PageHeight**|**0**|Ja|Anger sidans höjd.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nej|Anger om ritningen ska skalas automatiskt. Standardvärdet minskar automatiskt bilden för att passa in i dukstorleken. Byt till **GrowToFit**-läge, eller använd **None** inställningen för att inaktivera automatisk skalning.|
|**BackgroundColor**|**Color.White**|Nej|Anger bakgrundsfärgen för den utgående bilden.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nej|Anger entityns färgläggningsläge. Specificera **UseObjectColor** alternativet för att rita enheter med sin ursprungliga färg, eller **UseDrawColor** alternativet för att åsidosätta ursprungliga färger.|
|**DrawColor**|**Color.Black**|Nej|Anger den åsidosatta entitetens färg (endast om **DrawType** är inställt på **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Nej|Anger om automatisk layoutskalning ska utföras för att matcha Modell-layouterna. |

### **Inställning av dukstorlek och läge**

Export från CAD till PDF eller CAD till rasterbildformat är inte en trivial uppgift. Eftersom den resulterande PDF:en eller bilden kräver att dukstorleken definieras, behöver vi ange utgångsdimensionerna för PDF-sidan för att korrekt rendera ritningen. Ställ in **CadRasterizationOptions.PageWidth** och **CadRasterizationOptions.PageHeight** egenskaperna explicit, annars kan du få en **ImageSaveException**.

Dessutom kan du specificera dimensionen skalalternativ. Skalfunktionerna ställs in med **CadRasterizationOptions.ScaleMethod** egenskapen. Använd detta alternativ för att automatiskt justera bildens dimensioner enligt **CadRasterizationOptions.PageWidth** och **CadRasterizationOptions.PageHeight** värdena. Som standard är **CadRasterizationOptions.ScaleMethod** inställd på **ScaleType.ShrinkToFit** läge. Denna egenskap definierar följande beteende:

- Om CAD-ritningens dimensioner är större än den resulterande dukstorleken, minskas ritningens dimensioner för att passa in i den resulterande duken samtidigt som bildförhållandet bevaras.
- Om CAD-ritningens dimensioner är mindre än den resulterande dukstorleken, ställ in **CadRasterizationOptions.ScaleMethod** egenskapen till **ScaleType.GrowToFit** för att öka ritningsstorleken för att passa in i PDF-duken samtidigt som bildförhållandet bevaras.
- Eller inaktivera automatisk skalning med **ScaleType.None** alternativet.

Kodsaxeln nedan visar automatisk skalningsalternativ i användning.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Inställning av bakgrunds- och ritningsfärger**

Som standard sätts färgpaletten för den resulterande duken till det gemensamma dokumentets schema. Det betyder att alla enheter i CAD-ritningen ritas med en svart färgpenna på en solid vit bakgrund. Dessa inställningar kan ändras med **CadRasterizationOptions.BackgroundColor** och **CadRasterizationOptions.DrawColor** egenskaper. Att ändra **CadRasterizationOptions.DrawColor** egenskapen kräver även att **CadRasterizationOptions.DrawType** egenskapen sätts för att använda ritningsfärgen. **CadRasterizationOptions.DrawType** egenskapen kontrollerar om CAD-enheterna bevarar sina färger eller konverteras till anpassade färger. För att bevara enhetens färger, specificera **CadRasterizationOptions.DrawType** som **CadDrawTypeMode.UseObjectColor**, annars specificera **CadDrawTypeMode.UseDrawColor** värdet.

Kodsaxeln nedan visar hur man använder olika färgegenskaper.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Inställning av automatisk layoutskalning**

De flesta CAD-ritningarna har mer än en layout lagrad i en enda fil, och varje layout kan ha olika dimensioner. Vid renderingen av sådana CAD-ritningar till PDF, kan varje sida av PDF:en ha olika skalning enligt layoutens storlek. För att göra rendering homogen har Aspose.CAD API:erna exponerat **CadRasterizationOptions.AutomaticLayoutsScaling** egenskapen. Dess standardvärde är **false** men när den är sann kommer API:et att försöka söka efter en motsvarande skala för varje separat layout och rita dem på ett motsvarande sätt genom att utföra automatiska storleksändringsoperationer enligt sidstorleken.

Här är hur **CadRasterizationOptions.AutomaticLayoutsScaling** egenskapen fungerar i samarbete med **CadRasterizationOptions.ScaleMethod** egenskapen.

1. Om **ScaleMethod** är inställt på **ScaleType.ShrinkToFit** eller **ScaleType.GrowToFit** med **AutomaticLayoutsScaling** inställt på false kommer alla layouter (inklusive Modellen) att bearbetas enligt det första alternativet.
1. Om **ScaleMethod** är inställt på **ScaleType.ShrinkToFit** eller **ScaleType.GrowToFit** med **AutomaticLayoutsScaling** inställt på true kommer alla layouter (utöver Modell) att bearbetas enligt deras storlek medan Modell kommer att bearbetas enligt det första alternativet.
1. Om **ScaleMethod** är inställt på **ScaleType.None** med **AutomaticLayoutsScaling** inställt på true eller false kommer ingen skalning att utföras.

Kodsaxeln nedan visar hur man ställer in automatisk layoutskalning för CAD till PDF-konvertering.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Konvertera AutoCAD DXF eller DWG-layouter till PNG eller andra bildformat i C#**

Aspose.CAD för .NET API kan konvertera CAD-layouter av stödda format som DXF och DWG till PNG BMP TIFF JPEG och GIF. API:et tillhandahåller också stöd för att rendera de specifika layouterna av en CAD-ritning till olika PSD-lager.

Här är hur du kan uppnå samma sak i de följande enkla stegen.

- Ladda AutoCAD DWG eller DXF-fil med **Image** klassen.
- Ställ in/ändra bredd och höjd på bilden.
- Ställ in de önskade layoutnamnen med CadRasterizationOptions.Layouts egenskapen.
- Skapa en instans av **ImageOptionsBase** och ställ in dess **VectorRasterizationOptions** egenskap till instansen av **CadRasterizationOptions** som skapades i föregående steg.
- Spara CAD-layouten som TIFF eller bild.

Här är den fullständiga källkoden.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Egenskapen **CadRasterizationOptions.Layouts** är av typ sträng-array så att du kan specificera mer än en layout åt gången för eventuell konvertering till bildformat. När du specificerar flera layouter för **CadRasterizationOptions.Layouts** egenskapen kommer det resulterande TIFF-bilden att ha flera sidor, GIF-bilden kommer att ha flera ramar och [PSD](https://docs.fileformat.com/image/psd/) formatet kommer att ha flera lager, där varje sida/ram/lager representerar en individuell AutoCAD-layout. Om något annat bildformat som PNG, BMP, JPEG väljs för att lagra resultatet, renderar API:et endast den standardlayout som är "Modell".

{{% /alert %}}

## **Aktivera spårning för CAD-renderingsprocessen**

Aspose.CAD har introducerat en serie klasser och stödföljande uppräkning för att hjälpa till med spårningen av CAD-renderingsprocessen. Med dessa ändringar på plats kan CAD till PDF-konvertering nu uppnås på följande sätt medan spårning aktiveras.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Spårning av CAD-renderingsprocessen kan upptäcka följande möjliga problem.

1. Saknad eller korrupt headerinformation.
1. Saknad layoutinformation.
1. Saknade blockenheter.
1. Saknade dimensionsstilar.
1. Saknade stilar.

## **Ersätta typsnitt vid konvertering av CAD-ritningar**

Det är ganska möjligt att en viss CAD-ritning använder ett specifikt typsnitt som inte finns tillgängligt på maskinen där CAD till PDF eller CAD till rasterbildkonverteringen pågår. I sådana situationer kommer Aspose.CAD API:t att utlösa ett lämpligt undantag för att belysa saknade typsnitt och stoppa konverteringsprocessen eftersom API:t kräver dessa typsnitt för att korrekt rendera innehållet på den resulterande PDF:en eller bilderna.

Aspose.CAD API:t tillhandahåller ett enkelt sätt att använda mekanismen för att ersätta de nödvändiga typsnitten med de tillgängliga typsnitten. **CadImage.Styles** egenskapen returnerar en instans av **CadStylesDictionary** som i sin tur innehåller **CadStyleTableObject** för varje stil i CAD-ritningen, medan **CadStyleTableObject.PrimaryFontName** kan användas för att specificera det tillgängliga typsnittets namn.

Följande kodsnutt demonstrerar användningen av Aspose.CAD för .NET API för att ändra typsnittet för alla stilar i en CAD-ritning.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Det är också möjligt att ändra typsnittet för endast en viss stil genom att komma åt den via stilnamnet. Följande kodsnutt demonstrerar användningen av detta tillvägagångssätt.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Konvertera CAD-lager till rasterbildformat**

Aspose.CAD för .NET API har exponerat ett effektivt och enkelt sätt att specificera namnet på det erforderliga CAD-laget och rendera det till rasterbildformat. Här är hur du kan uppnå samma sak i 5 enkla steg som listas nedan.

1. Ladda CAD-filen till en instans av **Image** med hjälp av fabriksmetoden **Load**.
1. Skapa en instans av **CadRasterizationOptions** och ställ in dess obligatoriska egenskaper som **PageWidth** och **PageHeight**.
1. Lägg till det önskade lager namnet med hjälp av **CadRasterizationOptions.Layers.Add** metoden.
1. Skapa en instans av **ImageOptionsBase** och ställ in dess **VectorRasterizationOptions** egenskap till instansen av **CadRasterizationOptions** som skapades i föregående steg.
1. Anropa **Image.Save** metoden genom att skicka filvägen (eller ett objekt av MemoryStream) likaså instansen av **ImageOptionsBase** som skapades i föregående steg.

Här är den fullständiga källkoden.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Konvertera alla CAD-lager till separata bilder**

Du kan få alla lager från en CAD-ritning med hjälp av **CadImage.Layers** och rendera varje lager till separata bilder som demonstreras nedan.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Konvertera DWF CAD-lager till rasterbildformat**

Aspose.CAD för .NET API har exponerat ett effektivt och enkelt sätt att specificera namnet på det erforderliga CAD-laget och rendera det till rasterbildformat. Här är hur du kan uppnå samma sak i 5 enkla steg som listas nedan.

1. Ladda DWF CAD-filen till en instans av **Image** med hjälp av fabriksmetoden **Load**.
1. Skapa en instans av **CadRasterizationOptions** och ställ in dess obligatoriska egenskaper som **PageWidth** och **PageHeight**.
1. Lägg till det önskade lager namnet med hjälp av **CadRasterizationOptions.Layers.Add** metoden.
1. Skapa en instans av **ImageOptionsBase** och ställ in dess **VectorRasterizationOptions** egenskap till instansen av **CadRasterizationOptions** som skapades i föregående steg.
1. Anropa **Image.Save** metoden genom att skicka filvägen (eller ett objekt av MemoryStream) likaså instansen av **ImageOptionsBase** som skapades i föregående steg.

Här är den fullständiga källkoden.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD för .NET skriver direkt informationen om API och versionsnummer i utdata dokument. Till exempel, vid rendering av dokument till PDF, fyller Aspose.CAD för .NET i fältet Applikation med värdet 'Aspose.CAD' och fältet PDF-producent med ett värde, t.ex. 'Aspose.CAD v 17.10'.

Observera att du inte kan begära Aspose.CAD för .NET att ändra eller ta bort denna information från utdata dokument.
