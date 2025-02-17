---
title: CAD Rajzok PDF és Raszter Képformátumokká Konvertálása
type: docs
weight: 30
url: /hu/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Az Aspose.CAD for Java közvetlenül írja ki az API és Verziószám információit a kimeneti dokumentumokba. Például, amikor egy Dokumentumot PDF-re renderálunk, az Aspose.CAD for Java az Alkalmazás mezőt az 'Aspose.CAD' értékkel és a PDF Producer mezőt egy például 'Aspose.CAD v 17.9' értékkel tölti fel.

Kérjük, vegye figyelembe, hogy nem tudja utasítani az Aspose.CAD for Java-t, hogy megváltoztassa vagy eltávolítsa ezeket az információkat a kimeneti dokumentumokból.

{{% /alert %}} 
## **CAD Rajzok Konvertálása Raszter Képformátumokká**
Az Aspose.CAD for Java képes konvertálni a támogatott CAD rajzformátumokat, mint például a [**DXF**](https://docs.fileformat.com/cad/dxf/) és [**DWG**](https://docs.fileformat.com/cad/dwg/) raszter képformátumokká, mint például [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) és [**GIF**](https://docs.fileformat.com/image/gif/). Az Aspose.CAD for Java API hatékony és könnyen használható eszközöket kínál e cél eléréséhez.
Bármely támogatott CAD rajzformátumot raszter képformátumokká konvertálhat a lentebb részletezett egyszerű lépések követésével.

1. Töltse be a CAD fájlt egy [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) példányba.
1. Hozzon létre egy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) példányt, és állítsa be a kötelező tulajdonságait, mint például a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) és a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Hozzon létre egy **ImageOptionsBase** példányt, és állítsa be a [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) tulajdonságát a korábban létrehozott **CadRasterizationOptions** példányra.
1. Hívja meg a **Image.save**-et, átadva a fájl elérési útját (vagy a MemoryStream objektumot), valamint a korábban létrehozott [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) példányt.

Itt van a teljes forráskód.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Alapértelmezés szerint az API csak a "Model" elrendezést rendereli. Azonban a CAD rajzok képformátumokká konvertálása során megadhatja a kívánt elrendezéseket is.
## **CAD Konverzió Testreszabása**
A CAD PDF-re és raszter képformátumokra való konvertálási eljárások erősen konfigurálhatóak, mivel a [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) osztály úgy lett implementálva, hogy számos opcionális funkciót biztosítson, amelyek beállítása során felülírhatják a renderelési folyamatot az alkalmazás igényei szerint.
### **CadRasterizationOptions Osztály**
A [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) osztály közös minden támogatott CAD formátum számára, mint például [**DWG**](https://docs.fileformat.com/cad/dwg/) és [DXF](https://docs.fileformat.com/cad/dxf/), ezért az itt megosztott információ érvényes mindkét fent említett CAD formátumra.

A legfontosabb **CadRasterizationOptions** osztály tulajdonságai:

|**Tulajdonság**|**Alapértelmezett Érték**|**Kötelező**|**Leírás**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Igen|Megadja az oldal szélességét.|
|**PageHeight**|**0**|Igen|Megadja az oldal magasságát.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nem|Megadja, hogy a rajzot automatikusan méretezni kell-e. Az alapértelmezett érték automatikusan kicsinyíti a képet, hogy illeszkedjen a vászon méretéhez. Váltson a **GrowToFit** módra, vagy használja a **None** beállítást az automatikus méretezés letiltásához.|
|**BackgroundColor**|**Color.White**|Nem|Megadja a kimeneti kép háttérszínét.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nem|Megadja a színezési módot az entitások számára. A **UseObjectColor** opciót válassza az entitások natív színnel való megrajzolásához, vagy a **UseDrawColor** opciót az alapértelmezett színek felülírásához.|
|**DrawColor**|**Color.Black**|Nem|Megadja a felülírt entitás színét (csak ha a **DrawType** a **UseDrawColor** tulajdonság értékére van állítva).|
|**AutomaticLayoutsScaling**|Hamisság|Nem|Megadja, hogy automatikus elrendezés méretezésnek kell-e végrehajtódnia, hogy illeszkedjen a Model elrendezéshez.|
### **A Vászon Méretének és Módjának Beállítása**
A CAD-ból PDF-re vagy CAD-ból raszter képformátumokra való exportálás nem triviális feladat. Mivel a kimeneti PDF-nek vagy képnek meg kell határoznia a vászon méretét, meg kell adnia a PDF oldal kimeneti méreteit, hogy a rajz megfelelően renderelődhessen. Kifejezetten állítsa be a **CadRasterizationOptions.PageWidth** és a **CadRasterizationOptions.PageHeight** tulajdonságokat, vagy **ImageSaveException**-t kaphat.

Ezen kívül megadhat méretarány-beállítási lehetőségeket. A méretezési lehetőségeket a **CadRasterizationOptions.ScaleMethod** tulajdonság állítja be. Használja ezt a lehetőséget a kép méreteinek automatikus beállításához a **CadRasterizationOptions.PageWidth** és **CadRasterizationOptions.PageHeight** értékei szerint. Alapértelmezés szerint a **CadRasterizationOptions.ScaleMethod** az **ScaleType.ShrinkToFit** módra van állítva. Ez a tulajdonság a következő viselkedést határozza meg:

- Ha a CAD rajz méretei nagyobbak, mint a kimeneti vászon mérete, akkor a rajz méretei csökkentésre kerülnek, hogy illeszkedjenek a kimeneti vászonra, miközben megőrzik az arányokat.
- Ha a CAD rajz méretei kisebbek, mint a kimeneti vászon mérete, állítsa a **CadRasterizationOptions.ScaleMethod** tulajdonságot **ScaleType.GrowToFit** értékre, hogy növelje a rajz méretét, hogy illeszkedjen a PDF vászonra, miközben megőrzi az arányokat.
- Vagy tiltsa le az automatikus méretezést a **ScaleType.None** opcióval.

Az alábbi kódminta bemutatja az automatikus méretezési lehetőség alkalmazását.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **A Háttér- és Rajzszínek Beállítása**
Alapértelmezés szerint a kimeneti vászon színpalettája a közös dokumentum sémára van beállítva. Ez azt jelenti, hogy minden entitás a CAD rajzban fekete színű tollal van megrajzolva egy tiszta fehér háttérrel. Ezek a beállítások megváltoztathatók a **CadRasterizationOptions.BackgroundColor** és **CadRasterizationOptions.DrawColor** tulajdonságokkal. A **CadRasterizationOptions.DrawColor** tulajdonság módosítása a **CadRasterizationOptions.DrawType** tulajdonság beállítását is megköveteli, hogy a rajz színeit tudja használni. A **CadRasterizationOptions.DrawType** tulajdonság irányítja, hogy a CAD entitások megőrizzék-e színeiket, vagy át legyenek konvertálva egyedi színekre. Az entitás színek megőrzéséhez állítsa a **CadRasterizationOptions.DrawType** tulajdonságot **CadDrawTypeMode.UseObjectColor** értékre, különben adja meg a **CadDrawTypeMode.UseDrawColor** értéket.

Az alábbi kódminta bemutatja, hogyan lehet különböző szín tulajdonságokat használni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Automatikus Elrendezés Méretezés Beállítása**
A legtöbb CAD rajznak több elrendezése van elmentve egy fájlban, és minden elrendezés különböző méretekkel rendelkezhet. Amikor ilyen CAD rajzokat PDF-re renderelnek, a PDF egyes oldalai különböző méretezéssel rendelkezhetnek az elrendezés mérete szerint. Az egységes renderelés érdekében az Aspose.CAD API kiemelte a **CadRasterizationOptions.AutomaticLayoutsScaling** tulajdonságot. Alapértelmezett értéke **hamis**, de ha igazra állítják, az API megpróbálja megkeresni a megfelelő méretarányt minden egyes elkülönített elrendezéshez és azokat a megfelelő módon fogja megrajzolni, az oldal mérete szerint végrehajtott automatikus átméretezés segítségével.

Itt van, hogyan működik a **CadRasterizationOptions.AutomaticLayoutsScaling** tulajdonság együtt a **CadRasterizationOptions.ScaleMethod** tulajdonsággal.

1. Ha a **ScaleMethod** értéke **ScaleType.ShrinkToFit** vagy **ScaleType.GrowToFit**, és az **AutomaticLayoutsScaling** hamisra van állítva, akkor minden elrendezést (a Modelt beleértve) az első opció szerint fog feldolgozni.
1. Ha a **ScaleMethod** értéke **ScaleType.ShrinkToFit** vagy **ScaleType.GrowToFit**, és az **AutomaticLayoutsScaling** igazra van állítva, akkor minden elrendezést (kivéve a Modelt) a méretük szerint fognak feldolgozni, míg a Modelt az első opció szerint.
1. Ha a **ScaleMethod** értéke **ScaleType.None**, és az **AutomaticLayoutsScaling** igazra vagy hamisra van állítva, akkor nem lesz méretezés.

Az alábbi kódminta bemutatja, hogyan lehet beállítani az automatikus elrendezés méretezést a CAD-ból PDF konvertálás során.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **CAD Elrendezések Konvertálása Raszter Képformátumokká**
Az Aspose.CAD for Java API hatékony és könnyen használható módszert kínál a kültartó CAD elrendezések konvertálására támogatott formátumokból, mint például DXF és DWG, raszteres képekké, mint például PNG, BMP, TIFF, JPEG és GIF. Az API támogatást biztosít a CAD rajz specifikus elrendezésének különböző PSD rétegekbe való renderelésére is.
Az Aspose.CAD for Java API hatékony és könnyen használható módszert kínál a szükséges CAD elrendezések listájának meghatározására és annak raszter képformátumokká történő renderelésére. Itt van, hogyan érheti el mindezt 5 egyszerű lépésben, ahogy lentebb felsoroltuk.

1. Töltse be a CAD fájlt egy **Image** példányba a **load** gyári metódus használatával.
1. Hozzon létre egy **CadRasterizationOptions** példányt, és állítsa be kötelező tulajdonságait, mint például **PageWidth** és **PageHeight**.
1. Határozza meg a kívánt elrendezés nevét (neveit) a CadRasterizationOptions.Layouts tulajdonság használatával.
1. Hozzon létre egy **ImageOptionsBase** példányt, és állítsa be a **VectorRasterizationOptions** tulajdonságát a korábban létrehozott **CadRasterizationOptions** példányra.
1. Hívja meg a **Image.Save** metódust, átadva a fájl elérési útját (vagy egy MemoryStream objektumot), valamint a korábban létrehozott **ImageOptionsBase** példányt.

Itt van a teljes forráskód.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

A **CadRasterizationOptions.Layouts** tulajdonság típusának string tömbje van, tehát egyszerre több elrendezést is megadhat a képformátumokba való lehetséges konvertáláshoz. Amikor több elrendezést ad meg a **CadRasterizationOptions.Layouts** tulajdonsághoz, a kimeneti TIFF kép több oldalt fog tartalmazni, a GIF kép több keretet, és a PSD formátum több réteget fog tartalmazni, ahol minden oldal/keret/réteg egyedi AutoCAD elrendezést képvisel. Ha bármilyen más képformátumot, például PNG, BMP, JPEG választ, hogy tárolja az eredményt, akkor az API csak az alapértelmezett elrendezést fogja renderelni; ez a "Model".

{{% /alert %}} 
## **Nyomkövetés Engedélyezése a CAD Renderelési Folyamatban**
Az Aspose.CAD bevezetett egy sor osztályt és támogató felsorolási mezőket a CAD renderelési folyamat nyomkövetésének segítésére. Ezekkel a változtatásokkal a CAD-ból PDF konvertálás mostantól lehetséges nyomkövetés engedélyezésével.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



A CAD renderelési folyamat nyomkövetése a következő lehetséges problémákat tudja észlelni.

1. Hiányzó vagy sérült fejléc információ.
1. Hiányzó elrendezés információ.
1. Hiányzó blokk entitások.
1. Hiányzó méretstílusok.
1. Hiányzó stílusok.
## **Betűtípusok Helyettesítése CAD Rajzok Konvertálása Során**
Nagyon lehetséges, hogy egy adott CAD rajz egyedi betűtípust használ, amely nem elérhető azon a gépen, ahol a CAD-ból PDF-re vagy CAD-ból raszter képformátumokra történő konvertálás történik. Ilyen helyzetekben az Aspose.CAD API megfelelő kivételt generál, hogy kiemelje a hiányzó betűtípusokat, és megállítja a konvertálási folyamatot, mivel az API-nak szüksége van ezekre a betűtípusokra a tartalom megfelelő rendereléséhez az eredmény PDF-be és/vagy képekbe.
Az Aspose.CAD API egy kényelmes módot kínál a szükséges betűtípusok elérhető betűtípusokkal való helyettesítésére. A **CadImage.Styles** tulajdonság visszaadja a **CadStylesDictionary** példányt, amely viszont tartalmazza a **CadStyleTableObject**-ot minden stílushoz a CAD rajzban, míg a **CadStyleTableObject.PrimaryFontName**-t használhatja az elérhető betűtípus megadásához.

Az alábbi kódrészlet bemutatja az Aspose.CAD for Java API használatát az összes stílus betűtípusának megváltoztatására egy CAD rajzban.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Ezen kívül lehetséges egy adott stílus betűtípusának megváltoztatása is, ha az a stílus neve alapján van megadva. Az alábbi kódrészlet bemutatja ennek a megközelítésnek a használatát.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **CAD Rétegek Konvertálása Raszter Képformátumokká**
Az Aspose.CAD for Java API hatékony és könnyen használható eszközt kínál egy szükséges CAD réteg nevének meghatározására és annak raszter képformátumokká való renderelésére. Itt van, hogyan érheti el mindezt 5 egyszerű lépésben, ahogy lentebb felsoroltuk.

1. Töltse be a CAD fájlt egy **Image** példányba a **load** gyári metódus használatával.
1. Hozzon létre egy **CadRasterizationOptions** példányt, és állítsa be kötelező tulajdonságait, mint például **PageWidth** és **PageHeight**.
1. Adja hozzá a kívánt réteg nevét a **CadRasterizationOptions.Layers.add** metódussal.
1. Hozzon létre egy **ImageOptionsBase** példányt, és állítsa be a **VectorRasterizationOptions** tulajdonságát a korábban létrehozott **CadRasterizationOptions** példányra.
1. Hívja meg a **Image.save** metódust a fájl elérési útjának (vagy egy MemoryStream objektumnak) átadásával, valamint a korábban létrehozott **ImageOptionsBase** példányt.

Itt van a teljes forráskód.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Minden CAD Réteg Konvertálása Külön Képekbe**
Minden réteg lekérdezhető egy CAD rajzból a **CadImage.Layers** használatával, és minden réteg külön képbe renderelhető, ahogyan az alábbiakban bemutatjuk.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **DWF CAD Rétegek Konvertálása Raszter Képformátumokká**
Az Aspose.CAD for Java API hatékony és könnyen használható eszközt kínál egy szükséges CAD réteg nevének meghatározására és annak raszter képformátumokká való renderelésére. Itt van, hogyan érheti el mindezt 5 egyszerű lépésben, ahogy lentebb felsoroltuk.

1. Töltse be a DWF CAD fájlt egy **Image** példányba a **Load** gyári metódus használatával.
1. Hozzon létre egy **CadRasterizationOptions** példányt, és állítsa be kötelező tulajdonságait, mint például **PageWidth** és **PageHeight**.
1. Adja hozzá a kívánt réteg nevét a **CadRasterizationOptions.Layers.Add** metódussal.
1. Hozzon létre egy **ImageOptionsBase** példányt, és állítsa be a **VectorRasterizationOptions** tulajdonságát a korábban létrehozott **CadRasterizationOptions** példányra.
1. Hívja meg a **Image.Save** metódust a fájl elérési útjának (vagy egy MemoryStream objektumnak) átadásával, valamint a korábban létrehozott **ImageOptionsBase** példányt.

Itt van a teljes forráskód.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
