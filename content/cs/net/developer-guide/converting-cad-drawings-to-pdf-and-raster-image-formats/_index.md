---
title: Převést DWG DXF na PDF C# | Převést soubory Auto CAD na PDF JPEG PNG v C# .NET
type: docs
weight: 30
url: /cs/net/konvertovani-cad-kresleni-do-pdf-a-rastrovych-obrazovych-formatu/
keywords: "DWG na PDF C#, DXF na PDF C#, DWF DWT na PDF C#, převést AutoCAD, převést DWG, převést DWF, převést DWT, převést DXF, převést autocad na pdf, převést DWG na PDF, převést DWG na PNG, převést DWG na TIFF, převést DWG na JPG"
description: Použijte konvertor DWG nebo DXF na PDF v C# .NET AutoCADu k převodu DWG nebo DXF na PDF v C#. Můžete převést DWG, DWF, DWT a DXF na PDF, JPEG, PNG, BMP, GIF a TIFF v C# .NET rovněž.
---

## **Převést DWG nebo DXF na PNG JPEG BMP GIF nebo TIFF v C#**

Aspose.CAD pro .NET umí konvertovat formáty kreslení v AutoCADu jako [DXF](https://docs.fileformat.com/cad/dxf/) a [DWG](https://docs.fileformat.com/cad/dwg/) do formátů [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) a [GIF](https://docs.fileformat.com/image/gif/). Poskytuje efektivní a snadno použitelné API k dosažení tohoto cíle.

Můžete převést jakýkoli podporovaný formát kreslení v AutoCADu na rastrové obrazové formáty pomocí následujících jednoduchých kroků.

1. Načtěte soubor DWG nebo DXF do třídy [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Nastavte/změňte velikost obrázku pomocí vlastností [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Vytvořte instanci třídy [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. Nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) na vytvořenou třídu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) z předchozího kroku.
1. Uložte kreslení AutoCADu jako PDF s metodou [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) při předání cesty k souboru (nebo objektu MemoryStream) a instance třídy [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) vytvořené v předchozím kroku.

Zde je kompletní zdrojový kód.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Výchozím nastavením je, že API vykresluje pouze „Model“ rozvržení. Nicméně při převodu CAD kreseb do obrazových formátů můžete také specifikovat rozvržení podle vašeho výběru.

## **Přizpůsobení konverze CAD**

Postupy konverze CAD na PDF a CAD na rastrové obrazové formáty jsou velmi konfigurovatelné, protože třída [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) byla implementována způsobem, který poskytuje mnoho volitelných funkcí, které po nastavení mohou změnit proces vykreslování podle potřeb aplikace.

### **Třída CadRasterizationOptions**

Vlastnosti třídy **CadRasterizationOptions** jsou obecné pro všechny podporované formáty CAD, jako je DWG & DXF, proto jsou informace sdílené v tomto článku platné pro oba zmíněné formáty CAD.

Nejpoužitelnější vlastnosti třídy **CadRasterizationOptions** jsou:

|**Vlastnost**|**Výchozí hodnota**|**Požadováno**|**Popis**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ano|Určuje šířku stránky.|
|**PageHeight**|**0**|Ano|Určuje výšku stránky.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Ne|Určuje, zda má být výkres automaticky zmenšen. Výchozí hodnota automaticky zmenší obrázek, aby se vešel do velikosti plátna. Přepněte do režimu **GrowToFit** nebo použijte nastavení **None** pro deaktivaci automatického zveřejňování.|
|**BackgroundColor**|**Color.White**|Ne|Určuje barvu pozadí výstupního obrázku.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Ne|Určuje režim barvení prvků. Specifikujte možnost **UseObjectColor** k vykreslení prvků pomocí jejich původní barvy nebo možnost **UseDrawColor** k přepsání původních barev.|
|**DrawColor**|**Color.Black**|Ne|Určuje přepsanou barvu prvku (pouze pokud je hodnota vlastnosti **DrawType** nastavena na hodnotu vlastnosti **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Ne|Určuje, zda se mají provádět automatické úpravy rozložení pro Modelové rozvržení.|

### **Nastavení Velikosti Plátna a Režimu**

Export z CAD do PDF nebo z CAD do rastrových obrazových formátů není triviální úloha. Vzhledem k tomu, že výsledné PDF nebo obraz vyžaduje definovanou velikost plátna, je nutné explicitně specifikovat rozměry výstupu pro PDF stránku, aby se kreslení řádně vykreslilo. Nastavte vlastnosti **CadRasterizationOptions.PageWidth** a **CadRasterizationOptions.PageHeight** explicitně, nebo můžete získat **ImageSaveException**.

Kromě toho můžete specifikovat možnosti škálování rozměrů. Nastavení škálování lze provést prostřednictvím vlastnosti **CadRasterizationOptions.ScaleMethod**. Tuto možnost použijte k automatickému přizpůsobení rozměrů obrázku podle hodnot **CadRasterizationOptions.PageWidth** a **CadRasterizationOptions.PageHeight**. Výchozí hodnota **CadRasterizationOptions.ScaleMethod** je nastavena na režim **ScaleType.ShrinkToFit**. Tato vlastnost definuje následující chování:

- Pokud jsou rozměry CAD kreslení větší než výsledná velikost plátna, jsou rozměry kreslení zmenšeny tak, aby se vešly do výsledného plátna s zachováním poměru stran.
- Pokud jsou rozměry CAD kreslení menší než výsledná velikost plátna, nastavte vlastnost **CadRasterizationOptions.ScaleMethod** na **ScaleType.GrowToFit**, aby se velikost kreslení zvětšila tak, aby se vešla do PDF plátna s zachováním poměru stran.
- Nebo deaktivujte automatické škálování pomocí možnosti **ScaleType.None**.

Následující kódový vzorek ukazuje použití možnosti automatického škálování.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Nastavení Barev Pozadí a Kreslené Barvy**

Výchozí paletu barev pro výsledné plátno je nastavena na běžný dokument. To znamená, že všechny entity uvnitř CAD kreslení jsou nakresleny černým perem na pevném bílém pozadí. Tyto nastavení lze změnit pomocí vlastností **CadRasterizationOptions.BackgroundColor** a **CadRasterizationOptions.DrawColor**. Změna vlastnosti **CadRasterizationOptions.DrawColor** vyžaduje také nastavení vlastnosti **CadRasterizationOptions.DrawType**, aby bylo možné použít barvu kreslení. Vlastnost **CadRasterizationOptions.DrawType** řídí, zda CAD entity zachovávají své barvy nebo jsou převedeny na vlastní barvy. Pro zachování barev entit specifikujte **CadRasterizationOptions.DrawType** jako **CadDrawTypeMode.UseObjectColor**, jinak specifikujte hodnotu **CadDrawTypeMode.UseDrawColor**.

Následující kódový vzorek ukazuje, jak používat různé barevné vlastnosti.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Nastavení Automatického Škálování Rozvržení**

Většina CAD kreseb má více než jedno rozvržení uložené v jediném souboru, a každé rozvržení by mohlo mít odlišné rozměry. Při vykreslování těchto CAD kreseb do PDF může každá stránka PDF mít odlišné škálování podle velikosti rozvržení. Pro zajištění homogenního vykreslování Aspose.CAD API vystavuje vlastnost **CadRasterizationOptions.AutomaticLayoutsScaling**. Výchozí hodnota je **false**, ale když je nastavena na **true**, API bude hledat odpovídající měřítko pro každé samostatné rozvržení a vykreslit je odpovídajícím způsobem prostřednictvím automatické operace změny velikosti podle velikosti stránky.

Zde je, jak vlastnost **CadRasterizationOptions.AutomaticLayoutsScaling** pracuje ve spolupráci s vlastností **CadRasterizationOptions.ScaleMethod**.

1. Pokud je **ScaleMethod** nastaveno na **ScaleType.ShrinkToFit** nebo **ScaleType.GrowToFit** s AutomaticLayoutsScaling nastaveno na false, pak budou všechna rozvržení (včetně Modelu) zpracována podle první možnosti.
1. Pokud je **ScaleMethod** nastaveno na **ScaleType.ShrinkToFit** nebo **ScaleType.GrowToFit** s AutomaticLayoutsScaling nastaveno na true, pak budou všechna rozvržení (kromě Modelu) zpracována podle jejich velikosti, zatímco Model bude zpracován podle první možnosti.
1. Pokud je **ScaleMethod** nastaveno na **ScaleType.None** s AutomaticLayoutsScaling nastaveno na true nebo false, neproběhne žádné škálování.

Následující kódový vzorek ukazuje, jak nastavit automatické škálování rozvržení pro konverzi CAD do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Převést AutoCAD DXF nebo DWG Rozvržení na PNG nebo Ostatní Obrazové Formáty v C#**

Aspose.CAD pro .NET API může převést rozvržení CAD podporovaných formátů, jako jsou DXF a DWG, na PNG BMP TIFF JPEG a GIF. API také poskytuje podporu pro vykreslení konkrétních rozvržení kreslení CAD do různých vrstev PSD.

Zde je, jak můžete dosáhnout stejného pomocí následujících jednoduchých kroků.

- Načtěte soubor AutoCADu DWG nebo DXF pomocí třídy **Image**.
- Nastavte/změňte šířku a výšku obrázku.
- Nastavte požadované jméno(y) rozvržení pomocí vlastnosti CadRasterizationOptions.Layouts.
- Vytvořte instanci **ImageOptionsBase** a nastavte jí vlastnost **VectorRasterizationOptions** na instanci **CadRasterizationOptions** vytvořené v předchozím kroku.
- Uložte CAD rozvržení jako TIFF nebo obraz.

Zde je kompletní zdrojový kód.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Vlastnost **CadRasterizationOptions.Layouts** je polem řetězců, takže můžete najednou specifikovat více než jedno rozvržení pro možnou konverzi do obrazových formátů. Při specifikaci více rozvržení pro vlastnost **CadRasterizationOptions.Layouts** bude výsledný TIFF obrázek obsahovat více stránek, GIF obrázek bude obsahovat více snímků a formát [PSD](https://docs.fileformat.com/image/psd/) bude obsahovat více vrstev, kde každá stránka/snímek/vrstva představuje individuální rozvržení AutoCADu. V případě výběru jakéhokoli jiného obrazového formátu, jako je PNG, BMP, JPEG, který se má použít k uložení výsledku, bude API vykreslovat pouze výchozí rozvržení; tedy „Model“.

{{% /alert %}}

## **Povolení Sledování Pro Proces Vykreslování CAD**

Aspose.CAD zavedl sérii tříd a podpůrných výčtových polí pro sledování procesu vykreslování CAD. S těmito změnami lze nyní konverzi CAD do PDF provést následujícím způsobem při povolení sledování.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Sledování procesu vykres