---
title: Konwersja rysunków CAD do formatów PDF i obrazów rastrowych
type: docs
weight: 30
url: /pl/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD dla Javy bezpośrednio zapisuje informacje o API i numerze wersji w dokumentach wyjściowych. Na przykład, po renderowaniu dokumentu do PDF, Aspose.CAD dla Javy wypełnia pole aplikacji wartością 'Aspose.CAD' oraz pole producenta PDF wartością, np. 'Aspose.CAD v 17.9'.

Proszę zauważyć, że nie można polecić Aspose.CAD dla Javy zmiany lub usunięcia tych informacji z dokumentów wyjściowych.

{{% /alert %}} 
## **Konwersja rysunków CAD do formatów obrazów rastrowych**
Aspose.CAD dla Javy jest w stanie konwertować formaty rysunków CAD, takie jak [**DXF**](https://docs.fileformat.com/cad/dxf/) i [**DWG**](https://docs.fileformat.com/cad/dwg/) do obsługiwanych formatów obrazów rastrowych, takich jak [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) i [**GIF**](https://docs.fileformat.com/image/gif/). API Aspose.CAD dla Javy oferuje wydajne i łatwe w użyciu środki do osiągnięcia tego celu.
Można konwertować dowolny obsługiwany format rysunku CAD do formatów obrazów rastrowych, używając prostych kroków, jak opisano poniżej.

1. Załaduj plik CAD do instancji [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw jej obowiązkowe właściwości, takie jak [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) i [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Utwórz instancję **ImageOptionsBase** i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) na instancję **CadRasterizationOptions** utworzoną w poprzednim kroku.
1. Wywołaj **Image.save**, przekazując ścieżkę pliku (lub obiekt MemoryStream) oraz instancję [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) utworzoną w poprzednim kroku.

Oto kompletny kod źródłowy.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Domyślnie API renderuje tylko układ "Model". Możesz jednak również określić układy, które wybierzesz podczas konwersji rysunków CAD do formatów obrazów.
## **Dostosowywanie konwersji CAD**
Procedury konwersji CAD do [PDF](https://docs.fileformat.com/pdf/) i konwersji CAD do obrazów rastrowych są wysoce konfigurowalne, ponieważ klasa [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) została zaimplementowana w taki sposób, że oferuje wiele opcjonalnych funkcji, które po ustawieniu mogą nadpisywać proces renderowania zgodnie z potrzebami aplikacji.
### **Klasa CadRasterizationOptions**
Klasa [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) jest wspólna dla wszystkich obsługiwanych formatów CAD, takich jak [**DWG**](https://docs.fileformat.com/cad/dwg/) i DXF, dlatego informacje zawarte w tym artykule są ważne dla obu wymienionych formatów CAD.

Najbardziej przydatne właściwości klasy **CadRasterizationOptions** to:

|**Właściwość**|**Wartość domyślna**|**Wymagana**|**Opis**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Tak|Określa szerokość strony.|
|**PageHeight**|**0**|Tak|Określa wysokość strony|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nie|Określa, czy rysunek powinien być automatycznie skalowany. Wartość domyślna automatycznie zmniejsza obraz, aby dopasować rozmiar płótna. Przełącz na tryb **GrowToFit** lub użyj ustawienia **None**, aby wyłączyć automatyczne skalowanie.|
|**BackgroundColor**|**Color.White**|Nie|Określa kolor tła obrazu wyjściowego.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nie|Określa sposób kolorowania encji. Wybierz opcję **UseObjectColor**, aby rysować encje przy użyciu ich native'owego koloru, lub opcję **UseDrawColor**, aby nadpisać kolory native'owe.|
|**DrawColor**|**Color.Black**|Nie|Określa nadpisany kolor encji (tylko jeśli **DrawType** jest ustawione na wartość właściwości **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Fałsz|Nie|Określa, czy należy wykonać automatyczne skalowanie układu, aby dopasować go do układu Model.|
### **Ustawianie rozmiaru i trybu płótna**
Eksport z CAD do PDF lub z CAD do formatów obrazów rastrowych nie jest trywialnym zadaniem. Ponieważ powstały PDF lub obraz wymaga zdefiniowania rozmiaru płótna, musimy określić wymiary wyjściowe dla strony PDF, aby poprawnie wyświetlić rysunek. Ustaw właściwości **CadRasterizationOptions.PageWidth** i **CadRasterizationOptions.PageHeight** w sposób jawny, lub możesz napotkać **ImageSaveException**.

Dodatkowo możesz określić opcje skali wymiarów. Opcje skalowania są ustawiane przez właściwość **CadRasterizationOptions.ScaleMethod**. Użyj tej opcji, aby automatycznie dostosować wymiary obrazu zgodnie z wartościami **CadRasterizationOptions.PageWidth** i **CadRasterizationOptions.PageHeight**. Domyślnie **CadRasterizationOptions.ScaleMethod** jest ustawione na tryb **ScaleType.ShrinkToFit**. Ta właściwość definiuje następujące zachowanie:

- Jeśli wymiary rysunku CAD są większe niż rozmiar płótna, to wymiary rysunku są redukowane, aby dopasować się do powstałego płótna, zachowując proporcje.
- Jeśli wymiary rysunku CAD są mniejsze niż rozmiar płótna, ustaw właściwość **CadRasterizationOptions.ScaleMethod** na **ScaleType.GrowToFit**, aby zwiększyć rozmiar rysunku, aby dopasować się do płótna PDF, zachowując proporcje.
- Lub wyłącz automatyczne skalowanie za pomocą opcji **ScaleType.None**.

Poniższy przykład kodu pokazuje, jak wykorzystać opcję automatycznego skalowania.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Ustawianie kolorów tła i rysunku**
Domyślnie paleta kolorów dla powstałego płótna jest ustawiona na wspólny schemat dokumentu. Oznacza to, że wszystkie encje w rysunku CAD są rysowane czarnym kolorem na jednolitym białym tle. Te ustawienia można zmienić za pomocą właściwości **CadRasterizationOptions.BackgroundColor** i **CadRasterizationOptions.DrawColor**. Zmiana właściwości **CadRasterizationOptions.DrawColor** wymaga także ustawienia właściwości **CadRasterizationOptions.DrawType**, aby skorzystać z koloru rysowania. Właściwość **CadRasterizationOptions.DrawType** kontroluje, czy encje CAD zachowują swoje kolory, czy są konwertowane na kolory niestandardowe. Aby zachować kolory encji, określ **CadRasterizationOptions.DrawType** jako **CadDrawTypeMode.UseObjectColor**, w przeciwnym razie wybierz wartość **CadDrawTypeMode.UseDrawColor**.

Poniższy przykład kodu pokazuje, jak używać różnych właściwości kolorów.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Ustawianie automatycznego skalowania układu**
Większość rysunków CAD ma więcej niż jeden układ zapisany w pojedynczym pliku, a każdy układ może mieć różne wymiary. Podczas renderowania takich rysunków CAD do PDF, każda strona PDF może mieć różne skalowanie zgodnie z rozmiarami układów. Aby uczynić renderowanie jednorodnym, API Aspose.CAD udostępniło właściwość **CadRasterizationOptions.AutomaticLayoutsScaling**. Jej domyślna wartość to **false**, ale kiedy jest ustawiona na true, API spróbuje wyszukać odpowiednią skalę dla każdego osobnego układu i narysować je w odpowiedni sposób wykonując automatyczną operację zmiany rozmiaru zgodnie z rozmiarem strony.

Oto jak właściwość **CadRasterizationOptions.AutomaticLayoutsScaling** działa w połączeniu z właściwością **CadRasterizationOptions.ScaleMethod**.

1. Jeśli **ScaleMethod** jest ustawione na **ScaleType.ShrinkToFit** lub **ScaleType.GrowToFit** przy **AutomaticLayoutsScaling** ustawionym na false, wszystkie układy (w tym Model) będą przetwarzane zgodnie z pierwszą opcją.
1. Jeśli **ScaleMethod** jest ustawione na **ScaleType.ShrinkToFit** lub **ScaleType.GrowToFit** przy **AutomaticLayoutsScaling** ustawionym na true, wszystkie układy (z wyjątkiem Modelu) będą przetwarzane zgodnie z ich rozmiarami, podczas gdy Model będzie przetwarzany zgodnie z pierwszą opcją.
1. Jeśli **ScaleMethod** jest ustawione na **ScaleType.None** przy **AutomaticLayoutsScaling** ustawionym na true lub false, to żadne skalowanie nie będzie wykonywane.

Poniższy przykład kodu pokazuje, jak ustawić automatyczne skalowanie układu dla konwersji CAD do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Konwersja układów CAD do formatów obrazów rastrowych**
API Aspose.CAD dla Javy jest w stanie konwertować układy CAD obsługiwanych formatów, takich jak DXF i DWG, do obrazów rastrowych, takich jak PNG, BMP, TIFF, JPEG i GIF. API także zapewnia wsparcie do renderowania konkretnych układów rysunku CAD do różnych warstw PSD. 
API Aspose.CAD dla Javy udostępniło wydajne i łatwe w użyciu środki do określenia listy wymaganych układów CAD i renderowania ich do formatów obrazów rastrowych. Oto jak możesz to osiągnąć w 5 prostych krokach, jak wymieniono poniżej.

1. Załaduj plik CAD do instancji **Image** używając metody fabrycznej **load**.
1. Utwórz instancję **CadRasterizationOptions** i ustaw jej obowiązkowe właściwości, takie jak **PageWidth** i **PageHeight**.
1. Określ żądane nazwy układu/y przy użyciu właściwości CadRasterizationOptions.Layouts.
1. Utwórz instancję **ImageOptionsBase** i ustaw jej właściwość **VectorRasterizationOptions** na instancję **CadRasterizationOptions** utworzoną w poprzednim kroku.
1. Wywołaj **Image.Save**, przekazując ścieżkę pliku (lub obiekt MemoryStream) oraz instancję **ImageOptionsBase** utworzoną w poprzednim kroku.

Oto kompletny kod źródłowy.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Właściwość **CadRasterizationOptions.Layouts** jest typu tablica stringów, więc możesz określić więcej niż jeden układ w tym samym czasie do konwersji do formatów obrazów. Przy określaniu wielu układów dla właściwości **CadRasterizationOptions.Layouts**, powstały obraz TIFF będzie miał wiele stron, obraz GIF będzie miał wiele klatek, a format PSD będzie miał wiele warstw, gdzie każda strona/klatka/warstwa reprezentuje indywidualny układ AutoCAD. W przypadku, gdy zostanie wybrany inny format obrazu, taki jak PNG, BMP, JPEG, aby przechować wynik, wtedy API renderuje tylko domyślny układ, czyli "Model".

{{% /alert %}} 
## **Włączanie śledzenia procesu renderowania CAD**
Aspose.CAD wprowadziło szereg klas i wspierających pól wyliczeniowych, aby pomóc w śledzeniu procesu renderowania CAD. Dzięki tym zmianom, konwersję CAD do PDF można teraz osiągnąć w następujący sposób, włączając śledzenie.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Śledzenie procesu renderowania CAD może zidentyfikować następujące potencjalne problemy.

1. Brakujące lub uszkodzone informacje nagłówkowe.
1. Brakujące informacje o układzie.
1. Brakujące encje blokowe.
1. Brakujące style wymiarów.
1. Brakujące style.
## **Zastępowanie czcionek podczas konwersji rysunków CAD**
Jest całkiem możliwe, że dany rysunek CAD używa konkretnej czcionki, która nie jest dostępna na maszynie, na której odbywa się konwersja CAD do PDF lub CAD do obrazów rastrowych. W takich sytuacjach API Aspose.CAD wyzwoli odpowiedni wyjątek, aby podkreślić brakujące czcionki i przerwać proces konwersji, ponieważ API wymaga tych czcionek, aby poprawnie renderować zawartość na powstałym PDF i/lub obrazach.
API Aspose.CAD zapewnia łatwy sposób wykorzystania mechanizmu do zastępowania wymaganych czcionek czcionkami dostępnymi. Właściwość **CadImage.Styles** zwraca instancję **CadStylesDictionary**, która z kolei zawiera **CadStyleTableObject** dla każdego stylu w rysunku CAD, podczas gdy **CadStyleTableObject.PrimaryFontName** można użyć do określenia dostępnej nazwy czcionki.

Poniższy fragment kodu demonstruje użycie API Aspose.CAD dla Javy do zmiany czcionki wszystkich stylów w rysunku CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Możliwe jest także zmienienie czcionki tylko jednego konkretnego stylu, uzyskując do niego dostęp za pośrednictwem nazwy stylu. Poniższy fragment kodu demonstruje zastosowanie tego podejścia.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Konwersja warstw CAD do formatów obrazów rastrowych**
API Aspose.CAD dla Javy udostępniło wydajne i łatwe w użyciu środki do określenia nazwy wymaganej warstwy CAD i renderowania jej do formatów obrazów rastrowych. Oto jak możesz to osiągnąć w 5 prostych krokach, jak wymieniono poniżej.

1. Załaduj plik CAD do instancji **Image** używając metody fabrycznej **load**.
1. Utwórz instancję **CadRasterizationOptions** i ustaw jej obowiązkowe właściwości, takie jak **PageWidth** i **PageHeight**.
1. Dodaj żądane nazwy warstw przy użyciu metody **CadRasterizationOptions.Layers.add**.
1. Utwórz instancję **ImageOptionsBase** i ustaw jej właściwość **VectorRasterizationOptions** na instancję **CadRasterizationOptions** utworzoną w poprzednim kroku.
1. Wywołaj metodę **Image.save**, przekazując ścieżkę pliku (lub obiekt MemoryStream) oraz instancję **ImageOptionsBase** utworzoną w poprzednim kroku.

Oto kompletny kod źródłowy.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Konwersja wszystkich warstw CAD na oddzielne obrazy**
Możesz uzyskać wszystkie warstwy z rysunku CAD, używając **CadImage.Layers** i renderować każdą warstwę na oddzielnym obrazie, jak pokazano poniżej.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Konwersja warstw CAD DWF do formatów obrazów rastrowych**
API Aspose.CAD dla Javy udostępniło wydajne i łatwe w użyciu środki do określenia nazwy wymaganej warstwy CAD i renderowania jej do formatów obrazów rastrowych. Oto jak możesz to osiągnąć w 5 prostych krokach, jak wymieniono poniżej.

1. Załaduj plik CAD DWF do instancji **Image** używając metody fabrycznej **Load**.
1. Utwórz instancję **CadRasterizationOptions** i ustaw jej obowiązkowe właściwości, takie jak **PageWidth** i **PageHeight**.
1. Dodaj żądaną nazwę warstwy przy użyciu metody **CadRasterizationOptions.Layers.Add**.
1. Utwórz instancję **ImageOptionsBase** i ustaw jej właściwość **VectorRasterizationOptions** na instancję **CadRasterizationOptions** utworzoną w poprzednim kroku.
1. Wywołaj metodę **Image.Save**, przekazując ścieżkę pliku (lub obiekt MemoryStream) oraz instancję **ImageOptionsBase** utworzoną w poprzednim kroku.

Oto kompletny kod źródłowy.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
