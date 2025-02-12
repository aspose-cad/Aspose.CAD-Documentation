---
title: Výkresy DXF
type: docs
weight: 60
url: /cs/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportování výkresů DXF do formátu PDF**

Aspose.CAD poskytuje funkci načítání entit výkresu DXF z AutoCADu a jejich vykreslování jako celý výkres do formátu PDF. Přístup k převodu DXF na PDF funguje následovně:

1. Načtěte soubor výkresu DXF pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Zavolejte funkci [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a jako druhý parametr předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions).

Následující ukázkový kód ukazuje, jak převést soubor s výchozími nastaveními.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Podporované formáty**

V současné době plně podporujeme formáty souborů AutoCAD DXF 2010. Předchozí verze DXF nejsou zaručeny jako 100% platné. Plánujeme zahrnout více formátů a funkcí v budoucích verzích Aspose.CAD.

### **Podporované entity**

V současné době podporujeme všechny běžné 2D entity a jejich základní výchozí parametry následovně:

1. Zarovnávaná dimenze
1. Úhlová dimenze
1. Oblouk
1. Atribut
1. Odkaz na blok
1. Kružnice
1. Průměrná dimenze
1. Elipsa
1. Sít
1. Úsečka
1. Vícerozměrný text
1. Radiální dimenze
1. Bod
1. Lomená čára
1. Radiální dimenze
1. Papírová plocha
1. Text
1. Přímka

{{% alert color="primary" %}}

Pokud během zpracování narazíme na nějakou entitu nebo vlastnost, kterou nepodporujeme, entita nebo vlastnost bude tichým způsobem ignorována.

{{% /alert %}}

### **Správa paměti**

Vlastnost [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) třídy [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) se dá použít k řízení přerozdělení paměti. Přerozdělení paměti je pravděpodobné zejména u předem přidělených vyrovnávacích pamětí. Může se stát, že systém zjistí, že přidělený prostor nebude postačující.

- Pokud je [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) nastaveno na výchozí hodnotu, **False**, prostor je přerozdělen do stejného média.
- Pokud je nastaveno na **True**, přerozdělení nemůže přesáhnout maximálně stanovený prostor. V tomto případě je uvolněna existující přidělená mezipaměť (která vyžaduje přerozdělení) a rozšířený prostor je přidělen na disk.

## **Exportování specifické vrstvy výkresů DXF do PDF**

Tento přístup funguje následovně:

1. Otevřete soubor s výkresem DXF pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) a specifikujte vlastnosti [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pagewidth) a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Přidejte vrstvy do objektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions) a nastavte její vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/index).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a jako druhý parametr předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions).

Následující ukázkový kód ukazuje, jak převést konkrétní vrstvu DXF do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Vykreslení souborů PDF jako části výkresů DXF**

Tento přístup funguje následovně:

1. Načtěte soubor s výkresy DXF pomocí metody továrny [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) a načtěte soubory PDF.
1. Nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Zavolejte [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a uložte soubor.

Následující ukázkový kód ukazuje, jak vykreslit soubory PDF jako část výkresů DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Export vnořeného podkladu DGN pro formát DXF**

Aspose.CAD poskytuje funkci načítání souborů AutoCAD DXF a export vnořeného podkladu DGN pro formát DXF.

Následující ukázkový kód ukazuje, jak dosáhnout určených požadavků.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Podpora pro ukládání souborů DXF**

Aspose.CAD poskytuje funkci načítání souborů AutoCAD DXF a provádění změn v něm a opětovné uložení jako soubor DXF.

Následující ukázkový kód ukazuje, jak dosáhnout určených požadavků.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Exportování DXF do WMF**

Tento přístup funguje následovně:

1. Načtěte soubor s výkresem DXF pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) a načtěte soubory PDF.
1. Nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Zavolejte [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a uložte soubor.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exportování konkrétního DXF layoutu do PDF**

Tento přístup funguje následovně:

1. Otevřete soubor s výkresem DXF pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) a specifikujte vlastnosti [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pagewidth) a [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Specifikujte požadovaný název rozvržení použitím vlastnosti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions/properties/layouts).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions) a nastavte její vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/index).
1. Exportujte výkres do PDF zavoláním funkce [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a předáním objektu [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions) jako druhého parametru.

Následující ukázkový kód ukazuje, jak převést konkrétní rozvržení výkresu DXF do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions/properties/layouts) je typu pole řetězců, takže můžete najednou specifikovat více rozvržení pro možnou konverzi do formátu PDF. Při specifikaci více rozvržení pro vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions/properties/layouts) bude výsledné PDF obsahovat více stránek, kde každá stránka představuje jednotlivé rozvržení AutoCADu.

{{% /alert %}}

## **Podpora blokového oříznutí**

Aspose.CAD poskytuje funkci blokového oříznutí. Přístup k blokovému oříznutí funguje následovně:

1. Načtěte soubor s výkresem DXF pomocí metody továrny [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) a načtěte soubory PDF.
1. Nastavte požadované vlastnosti [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions).
1. Zavolejte funkci [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a jako druhý parametr předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions) a uložte soubor.

Následující ukázkový kód ukazuje, jak funguje blokové oříznutí.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Exportování obrázků do formátu DXF**

Pomocí Aspose.CAD můžete exportovat obrázky do formátu DXF. Pomocí tohoto přístupu můžete provést následující akce:

1. Nastavit nový font
1. Skrýt entity
1. Aktualizovat text

Následující ukázka kódu vám ukazuje, jak provést výše uvedené akce.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Exportování konkrétní vrstvy výkresů DXF do obrázku**

Tento přístup funguje následovně:

1. Otevřete soubor s výkresem DXF pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) a specifikujte vlastnosti [**PageWidth**](https://reference.aspose.com/cad