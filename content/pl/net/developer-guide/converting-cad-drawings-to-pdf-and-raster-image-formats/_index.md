---
title: DWG DXF do PDF C# | Konwertuj pliki Auto CAD do PDF JPEG PNG w C# .NET
type: docs
weight: 30
url: /pl/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG do PDF C#, DXF do PDF C#, DWF DWT do PDF C#, konwertuj AutoCAD, konwertuj DWG, konwertuj DWF, konwertuj DWT, konwertuj DXF, konwertuj autocad do pdf, konwertuj DWG do PDF, konwertuj DWG do PNG, konwertuj DWG do TIFF, konwertuj DWG do JPG"
description: Użyj konwertera PDF C# .NET AutoCAD, aby konwertować DWG lub DXF na PDF w C#. Możesz konwertować DWG, DWF, DWT i DXF na PDF, JPEG, PNG, BMP, GIF i TIFF w C# .NET.
---

## **Konwertuj DWG lub DXF na PNG JPEG BMP GIF lub TIFF w C#**

Aspose.CAD dla .NET może konwertować formaty rysunków AutoCAD, takie jak [DXF](https://docs.fileformat.com/cad/dxf/) i [DWG](https://docs.fileformat.com/cad/dwg/) na [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) i [GIF](https://docs.fileformat.com/image/gif/). Oferuje efektywne i łatwe w użyciu API, aby osiągnąć ten cel.

Możesz konwertować dowolny obsługiwany format rysunków AutoCAD na formaty obrazów rastrowych, korzystając z prostych kroków, jak opisano poniżej.

1. Załaduj plik AutoCAD DWG lub DXF do klasy [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Ustaw/zmień rozmiar obrazu, używając [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) i [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Utwórz instancję [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. Ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) na [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) utworzoną w poprzednim kroku.
1. Zapisz rysunek AutoCAD jako PDF za pomocą [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), przekazując ścieżkę do pliku (lub obiekt MemoryStream) oraz instancję [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) utworzoną w poprzednim kroku.

Oto pełny kod źródłowy.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Domyślnie API renderuje tylko layout "Model". Możesz jednak również określić layouty według własnego wyboru podczas konwertowania rysunków CAD na formaty obrazów.

## **Dostosowywanie konwersji CAD**

Procedury konwersji CAD do [PDF](https://docs.fileformat.com/pdf/) i CAD do obrazów rastrowych są wysoce konfigurowalne, ponieważ klasa [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) została zaimplementowana w taki sposób, że oferuje wiele opcjonalnych funkcji, które po ustawieniu mogą nadpisać proces renderowania zgodnie z potrzebami aplikacji.

### **Klasa CadRasterizationOptions**

Klasa **CadRasterizationOptions** jest wspólna dla wszystkich obsługiwanych formatów CAD, takich jak DWG i DXF, dlatego informacje zawarte w tym artykule są ważne dla obu wymienionych formatów CAD.

Najbardziej przydatne właściwości klasy **CadRasterizationOptions** to:

|**Właściwość**|**Wartość domyślna**|**Wymagana**|**Opis**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Tak|Określa szerokość strony.|
|**PageHeight**|**0**|Tak|Określa wysokość strony.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nie|Określa, czy rysunek powinien być automatycznie skalowany. Wartość domyślna automatycznie zmniejsza obraz, aby pasował do rozmiaru płótna. Przełącz w tryb **GrowToFit** lub użyj ustawienia **None**, aby wyłączyć automatyczne skalowanie.|
|**BackgroundColor**|**Color.White**|Nie|Określa kolor tła obrazu wyjściowego.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nie|Określa tryb kolorowania obiektu. Określ opcję **UseObjectColor**, aby rysować obiekty używając ich oryginalnego koloru, lub opcję **UseDrawColor**, aby nadpisać oryginalne kolory.|
|**DrawColor**|**Color.Black**|Nie|Określa nadpisany kolor obiektu (tylko jeśli **DrawType** jest ustawione na wartość właściwości **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Fałsz|Nie|Określa, czy automatyczne skalowanie układów ma być wykonane w celu dopasowania do układu Model. |

### **Ustawienie rozmiaru i trybu płótna**

Eksport z CAD do PDF lub CAD do formatów obrazów rastrowych nie jest trywialnym zadaniem. Ponieważ uzyskany PDF lub obraz wymaga określenia rozmiaru płótna, musimy podać wymiary wyjściowe strony PDF, aby poprawnie renderować rysunek. Wyraźnie ustaw właściwości **CadRasterizationOptions.PageWidth** i **CadRasterizationOptions.PageHeight**, w przeciwnym razie możesz napotkać **ImageSaveException**.

Dodatkowo możesz określić opcje skali wymiarów. Opcje skalowania są ustawiane za pomocą właściwości **CadRasterizationOptions.ScaleMethod**. Użyj tej opcji, aby automatycznie dostosować wymiary obrazu do wartości **CadRasterizationOptions.PageWidth** i **CadRasterizationOptions.PageHeight**. Domyślnie **CadRasterizationOptions.ScaleMethod** jest ustawione na tryb **ScaleType.ShrinkToFit**. Ta właściwość definiuje następujące zachowanie:

- Jeśli wymiary rysunku CAD są większe niż wynikowy rozmiar płótna, wówczas wymiary rysunku są zmniejszane, aby pasowały do wynikowego płótna, zachowując proporcje.
- Jeśli wymiary rysunku CAD są mniejsze niż rozmiar wynikowego płótna, ustawić właściwość **CadRasterizationOptions.ScaleMethod** na **ScaleType.GrowToFit**, aby zwiększyć rozmiar rysunku, aby pasował do płótna PDF, zachowując proporcje.
- Lub wyłączyć automatyczne skalowanie za pomocą opcji **ScaleType.None**.

Przykład poniższego kodu pokazuje, jak użyć opcji automatycznego skalowania.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Ustawienie kolorów tła i rysowania**

Domyślnie paleta kolorów dla wynikowego płótna jest ustawiona na wspólny schemat dokumentu. Oznacza to, że wszystkie obiekty wewnątrz rysunku CAD są rysowane czarnym pisakiem na białym tle. Te ustawienia można zmienić za pomocą właściwości **CadRasterizationOptions.BackgroundColor** i **CadRasterizationOptions.DrawColor**. Zmiana właściwości **CadRasterizationOptions.DrawColor** wymaga również ustawienia właściwości **CadRasterizationOptions.DrawType**, aby użyć koloru rysowania. Właściwość **CadRasterizationOptions.DrawType** kontroluje, czy obiekty CAD zachowują swoje kolory, czy są konwertowane na kolory niestandardowe. Aby zachować kolory obiektów, określ **CadRasterizationOptions.DrawType** jako **CadDrawTypeMode.UseObjectColor**, w przeciwnym razie określ wartość **CadDrawTypeMode.UseDrawColor**.

Przykład poniższego kodu pokazuje, jak używać różnych właściwości koloru.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Ustawienie automatycznego skalowania układów**

Większość rysunków CAD ma więcej niż jeden układ zapisany w jednym pliku, a każdy układ może mieć różne wymiary. Podczas renderowania takich rysunków CAD do PDF, każda strona PDF może mieć różne skalowanie zgodnie z rozmiarem układu. Aby uczynić renderowanie jednorodnym, API Aspose.CAD ujawnili właściwość **CadRasterizationOptions.AutomaticLayoutsScaling**. Jego wartość domyślna to **fałsz**, ale gdy jest ustawiona na wartość prawda, API spróbuje znaleźć odpowiednią skalę dla każdego osobnego układu i narysować je w odpowiedni sposób, przeprowadzając automatyczną operację zmiany rozmiaru zgodnie z rozmiarem strony. 

Oto jak działa właściwość **CadRasterizationOptions.AutomaticLayoutsScaling** w połączeniu z właściwością **CadRasterizationOptions.ScaleMethod**.

1. Jeśli **ScaleMethod** jest ustawione na **ScaleType.ShrinkToFit** lub **ScaleType.GrowToFit** z **AutomaticLayoutsScaling** ustawionym na fałsz, wszystkie układy (w tym model) będą przetwarzane zgodnie z pierwszą opcją.
1. Jeśli **ScaleMethod** jest ustawione na **ScaleType.ShrinkToFit** lub **ScaleType.GrowToFit** z **AutomaticLayoutsScaling** ustawionym na prawda, wszystkie układy (z wyjątkiem modelu) będą przetwarzane zgodnie z ich rozmiarem, podczas gdy model będzie przetwarzany według pierwszej opcji.
1. Jeśli **ScaleMethod** jest ustawione na **ScaleType.None** z **AutomaticLayoutsScaling** ustawionym na prawda lub fałsz, nie będzie przeprowadzane żadne skalowanie.

Przykład poniższego kodu pokazuje, jak ustawić automatyczne skalowanie układów dla konwersji CAD do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Konwertuj układy AutoCAD DXF lub DWG na PNG lub inne formaty obrazów w C#**

API Aspose.CAD dla .NET może konwertować układy CAD obsługiwanych formatów, takich jak DXF i DWG, na PNG BMP TIFF JPEG i GIF. API oferuje również wsparcie dla renderowania konkretnych układów rysunku CAD na różne warstwy PSD.

Oto jak możesz osiągnąć to samo, wykonując kilka prostych kroków.

- Załaduj plik AutoCAD DWG lub DXF za pomocą klasy **Image**.
- Ustaw/zmień szerokość i wysokość obrazu.
- Ustaw nazwę pożądanych układów używając właściwości CadRasterizationOptions.Layouts.
- Utwórz instancję **ImageOptionsBase** i ustaw jej właściwość **VectorRasterizationOptions** na instancję **CadRasterizationOptions** utworzoną w poprzednim kroku.
- Zapisz układ CAD jako TIFF lub obraz.

Oto pełny kod źródłowy.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Właściwość **CadRasterizationOptions.Layouts** jest typu tablicy string, więc możesz określić więcej niż jeden układ jednocześnie do możliwej konwersji na formaty obrazów. Podczas określania wielu układów dla właściwości **CadRasterizationOptions.Layouts**, wynikowy obraz TIFF będzie miał wiele stron, obraz GIF będzie miał wiele klatek, a format [PSD](https://docs.fileformat.com/image/psd/) będzie miał wiele warstw, gdzie każda strona/klatka/warstwa reprezentuje indywidualny układ AutoCAD. W przypadku wybrania innego formatu obrazu, takiego jak PNG, BMP, JPEG, aby przechować wynik, API renderuje tylko domyślny układ; to znaczy "Model".

{{% /alert %}}

## **Włączenie śledzenia procesu renderowania CAD**

Aspose.CAD wprowadził szereg klas i wspierających pól enumeracji, aby wspomagać śledzenie procesu renderowania CAD. Dzięki tym zmianom konwersja CAD do PDF może być teraz osiągnięta w następujący sposób, włączając śledzenie.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Śledzenie procesu renderowania CAD może wykryć następujące możliwe problemy.

1. Brakujące lub uszkodzone informacje nagłówkowe.
1. Brakujące informacje o układzie.
1. Brakujące jednostki blokowe.
1. Brakujące style wymiarów.
1. Brakujące style.

## **Zamiana czcionek podczas konwersji rysunków CAD**

Możliwe jest, że dany rysunek CAD korzysta z jakiejś konkretnej czcionki, która nie jest dostępna na maszynie, na której odbywa się konwersja CAD do PDF lub CAD do rastrowych obrazów. W takich przypadkach API Aspose.CAD wywoła odpowiedni wyjątek, aby podkreślić brakujące czcionki i zatrzymać proces konwersji, ponieważ API wymaga tych czcionek, aby poprawnie renderować zawartość w wynikowym PDF lub obrazach.

API Aspose.CAD oferuje prosty sposób użycia mechanizmu zamiany wymaganych czcionek na dostępne czcionki. Właściwość **CadImage.Styles** zwraca instancję **CadStylesDictionary**, która z kolei zawiera **CadStyleTableObject** dla każdego stylu w rysunku CAD, podczas gdy **CadStyleTableObject.PrimaryFontName** można wykorzystać do określenia nazwy dostępnej czcionki.

Poniższy fragment kodu demonstruje użycie API Aspose.CAD dla .NET, aby zmienić czcionkę wszystkich stylów w rysunku CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Możliwe jest również zmienienie czcionki tylko jednego konkretnego stylu, uzyskując do niej dostęp za pośrednictwem nazwy stylu. Poniższy fragment kodu demonstruje zastosowanie tego podejścia.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Konwertowanie warstw CAD na formaty obrazów rastrowych**

ASP.NET API Aspose.CAD ujawnia efektywne i łatwe w użyciu środki do określenia wymaganego nazwy warstwy CAD i renderowania jej do formatów obrazów rastrowych. Oto jak możesz osiągnąć to samo w 5 prostych krokach, jak podano poniżej.

1. Załaduj plik CAD do instancji **Image** przy użyciu metody fabrycznej **Load**.
1. Utwórz instancję **CadRasterizationOptions** i ustaw jej obowiązkowe właściwości takie jak **PageWidth** i **PageHeight**.
1. Dodaj pożądaną nazwę warstwy, używając metody **CadRasterizationOptions.Layers.Add**.
1. Utwórz instancję **ImageOptionsBase** i ustaw jej właściwość **VectorRasterizationOptions** na instancję **CadRasterizationOptions**, utworzoną w poprzednim kroku.
1. Wywołaj metodę **Image.Save**, przekazując ścieżkę do pliku lub obiekt MemoryStream, a także instancję **ImageOptionsBase** utworzoną w poprzednim kroku.

Oto pełny kod źródłowy.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Konwertowanie wszystkich warstw CAD na oddzielne obrazy**

Możesz uzyskać wszystkie warstwy z rysunku CAD, używając **CadImage.Layers**, i renderować każdą warstwę na oddzielny obraz, jak pokazano poniżej.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Konwertowanie warstw DWF CAD na formaty obrazów rastrowych**

API Aspose.CAD dla .NET ujawnia efektywne i łatwe w użyciu środki do określenia wymaganej nazwy warstwy CAD i renderowania jej do formatów obrazów rastrowych. Oto jak możesz osiągnąć to samo w 5 prostych krokach, jak podano poniżej.

1. Załaduj plik DWF CAD do instancji **Image** przy użyciu metody fabrycznej **Load**.
1. Utwórz instancję **CadRasterizationOptions** i ustaw jej obowiązkowe właściwości takie jak **PageWidth** i **PageHeight**.
1. Dodaj pożądaną nazwę warstwy, używając metody **CadRasterizationOptions.Layers.Add**.
1. Utwórz instancję **ImageOptionsBase** i ustaw jej właściwość **VectorRasterizationOptions** na instancję **CadRasterizationOptions** utworzoną w poprzednim kroku.
1. Wywołaj metodę **Image.Save**, przekazując ścieżkę do pliku (lub obiekt MemoryStream) oraz instancję **ImageOptionsBase** utworzoną w poprzednim kroku.

Oto pełny kod źródłowy.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD dla .NET bezpośrednio zapisuje informacje o API oraz numerze wersji w dokumentach wyjściowych. Na przykład podczas renderowania dokumentu do PDF, Aspose.CAD dla .NET wypełnia pole Aplikacja wartością 'Aspose.CAD' oraz pole Producent PDF wartością, np. 'Aspose.CAD v 17.10'.

Należy pamiętać, że nie możesz polecić Aspose.CAD dla .NET zmiany lub usunięcia tych informacji z dokumentów wyjściowych.
