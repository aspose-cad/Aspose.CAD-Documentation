---
title: DWG DXF-t PDF-be C# | AutoCAD fájlok PDF JPEG PNG formátumba konvertálása C# .NET-ben
type: docs
weight: 30
url: /hu/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG PDF-be C#, DXF PDF-be C#, DWF DWT PDF-be C#, AutoCAD konvertálása, DWG konvertálása, DWF konvertálása, DWT konvertálása, DXF konvertálása, AutoCAD PDF-be konvertálása, DWG PDF-be konvertálása, DWG PNG-be konvertálása, DWG TIFF-be konvertálása, DWG JPG-be konvertálása"
description: Használja a C# .NET AutoCAD PDF konvertert DWG vagy DXF PDF-be konvertálásához C#-ban. A DWG, DWF, DWT és DXF PDF-be, JPEG-be, PNG-be, BMP-be, GIF-be és TIFF-be konvertálható C# .NET-ben is.
---

## **DWG vagy DXF konvertálása PNG JPEG BMP GIF vagy TIFF formátumba C#-ban**

Az Aspose.CAD .NET számára képes AutoCAD rajzformátumokat, például a [DXF](https://docs.fileformat.com/cad/dxf/) és a [DWG](https://docs.fileformat.com/cad/dwg/) konvertálni [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) és [GIF](https://docs.fileformat.com/image/gif/) formátumba. Hatékony és könnyen használható API-t biztosít ennek a célnak az elérésére.

Bármely támogatott AutoCAD rajzformátumot képes konvertálni raszteres képfomátumokra az alábbi lépések egyszerű követésével.

1. Töltse be az AutoCAD DWG vagy DXF fájlt a [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) osztályba.
1. Hozzon létre egy példányt a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályból.
1. Állítsa be/változtassa meg a kép méretét a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) és [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) tulajdonságok használatával.
1. Hozzon létre egy példányt a [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) osztályból.
1. Állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) tulajdonságot a korábban létrehozott [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) példányra.
1. Mentse el az AutoCAD rajzot PDF formátumba az [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) metódus használatával, megadva a fájl elérési útját (vagy egy MemoryStream objektumot), valamint a korábban létrehozott [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) példányt.

Itt a teljes forráskód.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Alapértelmezés szerint az API csak a "Model" elrendezést rendereli. Azonban a CAD rajzok képpé konvertálásakor megadhatja a választott elrendezéseket is.

## **CAD konverzió testreszabása**

A CAD PDF-re és raszteres kép formátumokra történő konvertálás eljárásai nagymértékben konfigurálhatók, mivel a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályt úgy valósították meg, hogy számos opcionális funkciót kínál, amelyek beállításával felülírhatja a renderelési folyamatot az alkalmazás igényeinek megfelelően.

### **CadRasterizationOptions Osztály**

A **CadRasterizationOptions** osztály közös minden támogatott CAD formátumhoz, mint például a DWG és DXF, ezért a cikkben megosztott információ érvényes a fent említett CAD formátumokra is.

A leghasznosabb **CadRasterizationOptions** osztály tulajdonságai:

|**Tulajdonság**|**Alapértelmezett érték**|**Kötelező**|**Leírás**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Igen|Megadja az oldal szélességét.|
|**PageHeight**|**0**|Igen|Megadja az oldal magasságát.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nem|Megadja, hogy a rajz automatikusan méretezésre kerüljön-e. Az alapértelmezett érték automatikusan kicsinyíti a képet, hogy illeszkedjen a vászon méretéhez. Áswitcheljen a **GrowToFit** módra, vagy használja a **None** beállítást az automatikus méretezés letiltásához.|
|**BackgroundColor**|**Color.White**|Nem|Megadja a kimeneti kép háttérszínét.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nem|Megadja az entitások színezési módját. Adja meg a **UseObjectColor** lehetőséget az entitások natív színük használatával történő rajzolásához, vagy a **UseDrawColor** lehetőséget a natív színek felülírásához.|
|**DrawColor**|**Color.Black**|Nem|Megadja a felülírt entitás színét (csak ha a **DrawType** beállítása **UseDrawColor** tulajdonság értéke).|
|**AutomaticLayoutsScaling**|False|Nem|Megadja, hogy el kell-e végezni az automatikus elrendezés méretezését a Model elrendezéshez való illeszkedéshez.|

### **A vászon méretének és módjának beállítása**

A CAD PDF-re vagy CAD raszteres képformátumokra való exportálása nem triviális feladat. Mivel a kapott PDF-nek vagy képeknek meg kell határozni a vászon méretét, meg kell adnunk az output dimenziókat a PDF oldalhoz, hogy helyesen rendereljük a rajzot. Különösen állítsa be a **CadRasterizationOptions.PageWidth** és **CadRasterizationOptions.PageHeight** tulajdonságokat, különben **ImageSaveException**-t kaphat.

Továbbá, megadhat dimenzió méretezési lehetőségeket is. A méretezési lehetőségeket a **CadRasterizationOptions.ScaleMethod** tulajdonsággal állítják be. Használja ezt a lehetőséget a kép dimenzióinak automatikus beállításához a **CadRasterizationOptions.PageWidth** és **CadRasterizationOptions.PageHeight** értékek szerint. Alapértelmezés szerint a **CadRasterizationOptions.ScaleMethod** beállítása **ScaleType.ShrinkToFit** módra van állítva. Ez a tulajdonság a következő viselkedést határozza meg:

- Ha a CAD rajz dimenziói nagyobbak, mint a kapott vászon mérete, akkor a rajz dimenzióit úgy csökkentik, hogy illeszkedjenek a kapott vászonhoz, megőrizve az arányokat.
- Ha a CAD rajz dimenziói kisebbek, mint a kapott vászon mérete, állítsa be a **CadRasterizationOptions.ScaleMethod** tulajdonságot **ScaleType.GrowToFit** értékre, hogy a rajz méretét növelje, hogy illeszkedjen a PDF vászonhoz, miközben megőrzi az arányokat.
- Vagy tiltsa le az automatikus méretezést a **ScaleType.None** lehetőséggel.

Az alábbi kódpéldában az automatikus méretezési lehetőséget használják.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **A háttér- és rajzolási színek beállítása**

Alapértelmezés szerint a kapott vászon színpalettája a közönséges dokumentumsémához van beállítva. Ez azt jelenti, hogy az összes entitás a CAD rajzban fekete színű tollal van rajzolva egy tiszta fehér háttéren. Ezeket a beállításokat a **CadRasterizationOptions.BackgroundColor** és **CadRasterizationOptions.DrawColor** tulajdonságokkal meg lehet változtatni. A **CadRasterizationOptions.DrawColor** tulajdonság megváltoztatása szintén megköveteli a **CadRasterizationOptions.DrawType** tulajdonság beállítását ahhoz, hogy használni tudja a rajzolási színt. A **CadRasterizationOptions.DrawType** tulajdonság szabályozza, hogy a CAD entitások megőrizzék-e színeiket, vagy testre szabott színekre konvertálják őket. Az entitás színek megőrzéséhez a **CadRasterizationOptions.DrawType** tulajdonságot **CadDrawTypeMode.UseObjectColor**-ra kell állítani, ellenkező esetben a **CadDrawTypeMode.UseDrawColor** értéket kell megadni.

Az alábbi kódpélda megmutatja, hogyan használhatók a különböző színtulajdonságok.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Automatikus elrendezés méretezés beállítása**

A legtöbb CAD rajz több elrendezést tartalmaz egyetlen fájlban, és minden elrendezés különböző dimenziókkal bírhat. A CAD rajzok PDF-be való renderelésekor a PDF minden oldala eltérő méretezéssel bírhat az elrendezés méretének függvényében. A homogén renderelés érdekében az Aspose.CAD API-k kiexponálták a **CadRasterizationOptions.AutomaticLayoutsScaling** tulajdonságot. Alapértelmezett értéke **false**, de ha igazra állítják, az API megpróbálja keresni a megfelelő méretet minden egyes elrendezéshez és azokat megfelelő módon megrajzolni, automatikus átméretezési műveletet végezve az oldalméret szerint.

Itt van, hogyan működik a **CadRasterizationOptions.AutomaticLayoutsScaling** tulajdonság együtt a **CadRasterizationOptions.ScaleMethod** tulajdonsággal.

1. Ha a **ScaleMethod** értéke **ScaleType.ShrinkToFit** vagy **ScaleType.GrowToFit**, míg az **AutomaticLayoutsScaling** értéke false, akkor az összes elrendezés (beleértve a Modelt is) az első opció szerint lesz feldolgozva.
1. Ha a **ScaleMethod** értéke **ScaleType.ShrinkToFit** vagy **ScaleType.GrowToFit**, míg az **AutomaticLayoutsScaling** értéke igaz, akkor az összes elrendezés (kivéve a Modelt) az alapján lesz feldolgozva, míg a Model az első opció szerint.
1. Ha a **ScaleMethod** értéke **ScaleType.None** és az **AutomaticLayoutsScaling** igazra vagy hamisra van állítva, akkor nem lesz átméretezés.

Az alábbi kódpélda megmutatja, hogyan állítható be az automatikus elrendezés méretezése a CAD PDF konvertálásához.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **AutoCAD DXF vagy DWG elrendezések konvertálása PNG vagy más kép formátumokba C#-ban**

Az Aspose.CAD .NET API képes a támogatott formátumok CAD elrendezéseit, mint például DXF és DWG, PNG BMP TIFF JPEG és GIF formátumokba konvertálni. Az API támogatást is nyújt a CAD rajz különböző elrendezései különböző PSD rétegekre történő rendereléséhez.

Íme, hogyan érheti el ugyanezt az alábbi egyszerű lépésekben.

- Töltse be az AutoCAD DWG vagy DXF fájlt az **Image** osztály használatával.
- Állítsa be/változtassa meg a kép szélességét és magasságát.
- Állítsa be a kívánt elrendezés nevét (a) a CadRasterizationOptions.Layouts tulajdonság használatával.
- Hozzon létre egy példányt az **ImageOptionsBase**-ból, és állítsa be a **VectorRasterizationOptions** tulajdonságát a korábban létrehozott **CadRasterizationOptions** példányra.
- Mentse el a CAD elrendezést TIFF vagy képként.

Itt a teljes forráskód.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

A **CadRasterizationOptions.Layouts** tulajdonság típusa egy string tömb, így egyidejűleg megadhat többet is az elrendezések közül a képformátumokhoz való lehetséges konvertáláshoz. Több elrendezés megadása esetén a **CadRasterizationOptions.Layouts** tulajdonságnál a kapott TIFF kép több oldalt fog tartalmazni, a GIF kép több képkockát, a [PSD](https://docs.fileformat.com/image/psd/) formátum pedig több réteget, ahol minden oldal/képkocka/réteg egy külön AutoCAD elrendezést képvisel. Ha bármilyen más képformátum, például PNG, BMP, JPEG választásra kerül a végeredmény tárolásához, akkor az API csak az alapértelmezett elrendezést rendereli, vagyis a "Modelt".

{{% /alert %}}

## **Követés engedélyezése a CAD renderelési folyamat során**

Az Aspose.CAD egy sor osztályt és támogató enumerációs mezőt vezetett be a CAD renderelési folyamat nyomon követésének elősegítésére. Ezen változások révén a CAD PDF-re való konvertálása mostantól az alábbiak szerint érhető el, miközben engedélyezi a nyomon követést.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

A CAD renderelési folyamat követése a következő lehetséges problémákat tudja észlelni.

1. Hiányzó vagy sérült fejlécinformáció.
1. Hiányzó elrendezési információ.
1. Hiányzó blokk entitások.
1. Hiányzó méretstílusok.
1. Hiányzó stílusok.

## **Betűtípusok helyettesítése CAD rajzok konvertálásakor**

Előfordulhat, hogy egy adott CAD rajz olyan speciális betűtípust használ, amely nem áll rendelkezésre azon a gépen, ahol a CAD PDF-re vagy CAD raszteres képformátumokra való konverzió történik. Ilyen helyzetekben az Aspose.CAD API megfelelő kivételt aktivál, hogy kiemelje a hiányzó betűtípusokat, és leállítja a konverziós folyamatot, mert az API-nak szüksége van ezekre a betűtípusokra, hogy helyesen renderelje a tartalmakat a kapott PDF-be vagy képekre.

Az Aspose.CAD API egyszerű módot biztosít a szükséges betűtípusok helyettesítésére a rendelkezésre álló betűtípusokkal. A **CadImage.Styles** tulajdonság egy **CadStylesDictionary** példányt ad vissza, amely tartalmazza a **CadStyleTableObject**-ot minden stílushoz a CAD rajzban, amelyben a **CadStyleTableObject.PrimaryFontName** a rendelkezésre álló betűtípus nevének megadására használható.

Az alábbi kódpélda bemutatja az Aspose.CAD .NET API használatát a CAD rajz összes stílusának betűtípusa megváltoztatására.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Az is lehetséges, hogy csak egy adott stílus betűtípusát megváltoztassa, ha a stílus nevén keresztül hozzáfér. Az alábbi kódpélda bemutatja ezt a megközelítést.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **CAD rétegek konvertálása raszteres képformátumokra**

Az Aspose.CAD .NET API hatékony és könnyen használható módot biztosít a szükséges CAD réteg neve megadására és annak raszteres képformátumra való renderelésére. Íme, hogyan érheti el ugyanazt 5 egyszerű lépésben, ahogyan az alábbiakban felsorolva található.

1. Töltse be a CAD fájlt egy **Image** példányba a **Load** gyári metódus használatával.
1. Hozzon létre egy **CadRasterizationOptions** példányt, és állítsa be kötelező tulajdonságait, mint például **PageWidth** és **PageHeight**.
1. Adja hozzá a kívánt réteg nevét a **CadRasterizationOptions.Layers.Add** metódus használatával.
1. Hozzon létre egy **ImageOptionsBase** példányt, és állítsa be a **VectorRasterizationOptions** tulajdonságát a korábban létrehozott **CadRasterizationOptions** példányra.
1. Hívja meg a **Image.Save** metódust a fájl elérési útjának (vagy egy MemoryStream objektum) megadásával, valamint a korábban létrehozott **ImageOptionsBase** példányt.

Itt a teljes forráskód.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Minden CAD réteg konvertálása külön képekké**

Minden réteg megszerezhető a CAD rajzból a **CadImage.Layers** segítségével, és minden réteg külön képeként renderelhető, ahogyan az az alábbiakban bemutatásra kerül.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **DWF CAD rétegek konvertálása raszteres képformátumokra**

Az Aspose.CAD .NET API hatékony és könnyen használható módot biztosít a szükséges CAD réteg neve megadására és annak raszteres képformátumra való renderelésére. Íme, hogyan érheti el ugyanezt 5 egyszerű lépésben, ahogyan az alábbiakban felsorolva található.

1. Töltse be a DWF CAD fájlt egy **Image** példányba a **Load** gyári metódus használatával.
1. Hozzon létre egy **CadRasterizationOptions** példányt, és állítsa be kötelező tulajdonságait, mint például **PageWidth** és **PageHeight**.
1. Adja hozzá a kívánt réteg nevét a **CadRasterizationOptions.Layers.Add** metódus használatával.
1. Hozzon létre egy **ImageOptionsBase** példányt, és állítsa be a **VectorRasterizationOptions** tulajdonságát a korábban létrehozott **CadRasterizationOptions** példányra.
1. Hívja meg a **Image.Save** metódust a fájl elérési útjának (vagy egy MemoryStream objektum) megadásával, valamint a korábban létrehozott **ImageOptionsBase** példányt.

Itt a teljes forráskód.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Az Aspose.CAD .NET közvetlenül írja ki az API és a verziószám információit a kimeneti dokumentumokba. Például, amikor egy dokumentumot PDF formátumba renderel, az Aspose.CAD .NET az 'Aspose.CAD' értékkel tölti fel az Alkalmazás mezőt, és az PDF Producer mezőt például 'Aspose.CAD v 17.10' értékkel.

Kérem, vegye figyelembe, hogy az Aspose.CAD .NET-t nem utasíthatja arra, hogy megváltoztassa vagy eltávolítsa ezeket az információkat a kimeneti dokumentumokból.
