---
title: Konverze výkresů CAD do formátů PDF a rastrových obrázků
type: docs
weight: 30
url: /cs/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD pro Java přímo zapisuje informace o API a verzi do výstupních dokumentů. Například při vykreslování dokumentu do formátu PDF, Aspose.CAD pro Java vyplňuje pole Aplikace hodnotou 'Aspose.CAD' a pole Výrobce PDF hodnotou, např. 'Aspose.CAD v 17.9'.

Všimněte si, že nemůžete nasměrovat Aspose.CAD pro Java k tomu, aby tuto informaci z výstupních dokumentů změnil nebo odstranil.

{{% /alert %}} 

## **Konvertování výkresů CAD do rastrových obrazových formátů**
Aspose.CAD pro Java je schopný konvertovat formáty výkresů CAD, jako jsou [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) do podporovaných rastrových obrazových formátů, jako jsou [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). API Aspose.CAD pro Java poskytuje efektivní a snadno použitelné prostředky k dosažení tohoto cíle.
Můžete konvertovat jakýkoli podporovaný formát výkresu CAD do rastrových obrazových formátů pomocí jednoduchých kroků, jak je níže podrobně popsáno.

1. Načtěte soubor CAD do instance [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Vytvořte instanci [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte její povinné vlastnosti, jako je [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Vytvořte instanci **ImageOptionsBase** a nastavte její vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) na instanci **CadRasterizationOptions** vytvořenou v předchozím kroku.
1. Zavolejte metodu **Image.save** předáním cesty k souboru (nebo objektu MemoryStream) a instance [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) vytvořené v předchozím kroku.

Zde je kompletní zdrojový kód.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Ve výchozím nastavení API vykresluje pouze rozvržení "Model". Nicméně je také možné specifikovat požadovaná rozvržení při konvertování výkresů CAD do obrazových formátů.
## **Přizpůsobení konverze CAD**
Procedury konverze z CAD do [PDF](https://docs.fileformat.com/pdf/) a z CAD do rastrových obrazových formátů jsou vysoce konfigurovatelné, protože třída [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) byla implementována tak, že poskytuje mnoho nepovinných funkcí, které po nastavení mohou přepsat proces vykreslování podle potřeb aplikace.
### **Třída CadRasterizationOptions**
Třída [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) je společná pro všechny podporované formáty CAD, jako jsou [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), proto jsou sdílené informace v tomto článku platné pro oba výše zmíněné formáty CAD.

Nejpoužitečnější vlastnosti třídy **CadRasterizationOptions** jsou:

|**Vlastnost**|**Výchozí Hodnota**|**Povinná**|**Popis**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ano|Specifikuje šířku stránky.|
|**PageHeight**|**0**|Ano|Specifikuje výšku stránky.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Ne|Specifikuje, zda má být výkres automaticky zvětšen nebo zmenšen. Výchozí hodnota automaticky zmenší obrázek, aby zapadl do velikosti plátna. Přepněte do režimu **GrowToFit** nebo použijte nastavení **None** k deaktivaci automatického měřítka.|
|**BackgroundColor**|**Color.White**|Ne|Specifikuje barvu pozadí výstupního obrazu.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Ne|Určuje režim barevnosti entity. Specifikujte možnost **UseObjectColor** pro vykreslování entit jejich vlastní barvou nebo možnost **UseDrawColor** pro přepsání původních barev.|
|**DrawColor**|**Color.Black**|Ne|Specifikuje přepsanou barvu entity (pouze pokud je **DrawType** nastaven na hodnotu vlastnosti **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Ne|Určuje, zda má být provedeno automatické škálování rozvržení pro shodu s modelovým rozvržením.|
### **Nastavení Velikosti Plátna a Režimu**
Exportování z CAD do PDF nebo z CAD do rastrových obrazových formátů není triviální úloha. Protože výsledný PDF nebo obrázek vyžaduje definovanou velikost plátna, je třeba specifikovat výstupní rozměry pro stránku PDF, aby bylo možné výkres správně vykreslit. Explicitně nastavte vlastnosti **CadRasterizationOptions.PageWidth** a **CadRasterizationOptions.PageHeight**, abyste zabránili výjimce **ImageSaveException**.

Dále můžete specifikovat volby změny měřítka. Možnosti měřítka jsou nastaveny vlastností **CadRasterizationOptions.ScaleMethod**. Použijte tuto možnost k automatickému nastavení rozměrů obrázku podle hodnot **CadRasterizationOptions.PageWidth** a **CadRasterizationOptions.PageHeight**. Výchozí hodnota vlastnosti **CadRasterizationOptions.ScaleMethod** je nastavena na režim **ScaleType.ShrinkToFit**. Tato vlastnost definuje následující chování:

- Pokud jsou rozměry CAD výkresu větší než velikost výsledného plátna, jsou rozměry výkresu zmenšeny, aby se vešly do výsledného plátna a současně byl zachován poměr stran.
- Pokud jsou rozměry CAD výkresu menší než velikost výsledného plátna, nastavte vlastnost **CadRasterizationOptions.ScaleMethod** na **ScaleType.GrowToFit**, abyste zvětšili rozměry výkresu do velikosti PDF plátna a současně zachovali poměr stran.
- Nebo zakážete automatické škálování pomocí možnosti **ScaleType.None**.

Následující ukázkový kód ukazuje použití možnosti automatického škálování.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Nastavení Barev Pozadí a Kreslení**
Ve výchozím nastavení je barevná paleta pro výsledné plátno nastavena na běžný barevný schéma dokumentu. To znamená, že všechny entity uvnitř CAD výkresu jsou vykresleny černým perem na pevném bílém pozadí. Tyto nastavení lze změnit pomocí vlastností **CadRasterizationOptions.BackgroundColor** a **CadRasterizationOptions.DrawColor**. Změna vlastnosti **CadRasterizationOptions.DrawColor** vyžaduje také nastavení vlastnosti **CadRasterizationOptions.DrawType**, abyste mohli použít vykreslení barvy. Vlastnost **CadRasterizationOptions.DrawType** řídí, zda mají CAD entity zachovat své barvy nebo být převedeny na vlastní barvy. Pro zachování barev entit zadejte **CadRasterizationOptions.DrawType** jako **CadDrawTypeMode.UseObjectColor**, jinak zadejte hodnotu **CadDrawTypeMode.UseDrawColor**.

Následující ukázkový kód ukazuje použití různých barevných vlastností.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Nastavení Automatického Škálování Rozvržení**
Většina CAD výkresů obsahuje více než jedno rozvržení uložené v jediném souboru a každé rozvržení může mít různé rozměry. Při vykreslování takových CAD výkresů do PDF každá stránka PDF může mít jiné měřítko podle velikosti rozvržení. Aby bylo dosaženo homogenního vykreslování, Aspose.CAD API umožňuje nastavit vlastnost **CadRasterizationOptions.AutomaticLayoutsScaling**. Výchozí hodnota je **false**, ale pokud je nastavena na **true**, API bude hledat odpovídající měřítko pro každé samostatné rozvržení a vykreslí je odpovídajícím způsobem provádějíce automatickou operaci zvětšení nebo zmenšení podle velikosti stránky.

Níže je uvedeno, jak vlastnost **CadRasterizationOptions.AutomaticLayoutsScaling** spolupracuje s vlastností **CadRasterizationOptions.ScaleMethod**.

1. Pokud je **ScaleMethod** nastaven na **ScaleType.ShrinkToFit** nebo **ScaleType.GrowToFit** s **AutomaticLayoutsScaling** nastaven na false, pak všechna rozvržení (včetně Modelu) budou zpracována podle první možnosti.
1. Pokud je **ScaleMethod** nastaven na **ScaleType.ShrinkToFit** nebo **ScaleType.GrowToFit** s **AutomaticLayoutsScaling** nastaveno na true, pak všechna rozvržení (kromě Modelu) budou zpracována podle své velikosti, zatímco Model bude zpracován podle první možnosti.
1. Pokud je **ScaleMethod** nastaven na **ScaleType.None** s **AutomaticLayoutsScaling** nastaveno na true nebo false, pak se neprovede žádné škálování.

Následující ukázkový kód ukazuje, jak nastavit automatické škálování rozvržení pro konverzi CAD do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Konvertování rozvržení CAD do rastrových obrazových formátů**
API Aspose.CAD pro Java umožňuje konvertovat rozvržení CAD podporovaných formátů, jako jsou DXF & DWG, do rastrových obrázků, jako jsou PNG, BMP, TIFF, JPEG & GIF. API také nabízí podporu k vykreslení konkrétních rozvržení CAD k různým vrstvám PSD.
API Aspose.CAD pro Java poskytuje efektivní a snadno použitelné prostředky k určení seznamu požadovaných rozvržení CAD a jejich vykreslení do rastrových obrazových formátů. Níže je popsáno, jak toho můžete dosáhnout v 5 jednoduchých krocích.

1. Načtěte CAD soubor do instance **Image** pomocí tovární metody **load**.
1. Vytvořte instanci **CadRasterizationOptions** a nastavte její povinné vlastnosti, jako jsou **PageWidth** a **PageHeight**.
1. Specifikujte požadovaný název rozvržení pomocí vlastnosti **CadRasterizationOptions.Layouts**.
1. Vytvořte instanci **ImageOptionsBase** a nastavte její vlastnost **VectorRasterizationOptions** na instanci **CadRasterizationOptions** vytvořenou v předchozím kroku.
1. Zavolejte metodu **Image.Save** předáním cesty k souboru (nebo objektu MemoryStream) a instance **ImageOptionsBase** vytvořené v předchozím kroku.

Zde je kompletní zdrojový kód.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

{{% alert color="primary" %}} 

Vlastnost **CadRasterizationOptions.Layouts** je typu pole řetězců, takže můžete současně určit více rozvržení k možné konverzi do obrázkových formátů. Po specifikování více rozvržení pro vlastnost **CadRasterizationOptions.Layouts** bude výsledný obrázek TIFF obsahovat více stránek, obrázek GIF bude obsahovat více snímků a formát PSD bude obsahovat více vrstev, kde každá stránka/snímek/vrstva představuje jednotlivé rozvržení AutoCADu. V případě výběru jakéhokoli jiného obrázkového formátu, jako jsou PNG, BMP, JPEG, na uložení výsledku

{{% /alert %}}