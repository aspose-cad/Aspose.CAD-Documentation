---
title: Výkresy DXF
type: docs
weight: 60
url: /cs/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Exportování výkresů DXF do formátu PDF**

Aspose.CAD poskytuje funkci pro načítání entit výkresu AutoCAD DXF a jejich vykreslení jako celého výkresu do formátu PDF. Přístup k převodu DXF na PDF funguje následovně:

1. Načtěte soubor s výkresem DXF pomocí metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Zavolejte metodu Image.Save a předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako druhý parametr.

Následující ukázkový kód ukazuje, jak převést soubor s výkresem pomocí výchozích nastavení.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Podporované formáty**

Momentálně plně podporujeme formáty souborů AutoCAD DXF 2010. Předchozí verze DXF nejsou zaručeně 100% platné. Plánujeme zahrnout více formátů a funkcí do budoucích verzí Aspose.CAD.

### **Podporované entity**

Momentálně podporujeme všechny běžně rozšířené 2D entity a jejich základní výchozí parametry, jako jsou:

1. Zarovnaný rozměr
1. Úhlový rozměr
1. Oblouk
1. Atribut
1. Odkaz bloku
1. Kružnice
1. Průměrný rozměr
1. Elipsa
1. Šrafování
1. Úsečka
1. Víceřádkový text
1. Radikální rozměr
1. Bod
1. Polyčára
1. Radiální rozměr
1. Paprsek
1. Otočený rozměr
1. Tabulka
1. Text
1. X-čára

{{% alert color="primary" %}}

Pokud během parsování narazíme na nějakou entitu nebo vlastnost, kterou nepodporujeme, entita nebo vlastnost bude tichle ignorována.

{{% /alert %}}

### **Správa paměti**

Vlastnost [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) může být použita k řízení přerozdělování paměti. Přerozdělení paměti se pravděpodobně vyskytne u předem alokovaných mezipamětí. Může se stát, že systém zjistí, že přidělený prostor nebude postačující.

- Pokud je [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) nastavena na výchozí hodnotu, **False**, prostor je přerozdělen do stejného média.
- Pokud je nastaveno na **True**, přerozdělení nemůže přesáhnout maximálně určený prostor. V tomto případě je existující přidělená mezipaměť (která vyžaduje přerozdělení) uvolněna a rozšířený prostor je přidělen na disk.

## **Exportování konkrétní vrstvy výkresů DXF do formátu PDF**

Tento přístup funguje následovně:

1. Otevřete soubor s výkresem DXF pomocí metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a specifikujte vlastnosti [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Přidejte vrstvy do objektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte její vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportujte výkres do formátu PDF pomocí metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Následující ukázkový kód ukazuje, jak převést konkrétní vrstvu DXF do formátu PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exportování konkrétní vrstvy výkresů DXF do obrázku**

Tento přístup funguje následovně:

1. Otevřete soubor s výkresem DXF pomocí metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a specifikujte vlastnosti [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Přidejte vrstvy do objektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Vytvořte instanci třídy [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) a nastavte její vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportujte výkres do formátu PDF pomocí metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Následující ukázkový kód ukazuje, jak převést konkrétní vrstvu DXF do obrázku.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Vykreslení souborů PDF jako součást výkresů DXF**

Tento přístup funguje následovně:

1. Načtěte soubor s výkresem DXF pomocí metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a načtěte soubory PDF.
1. Nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Zavolejte [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) a uložte soubor.

Následující ukázkový kód ukazuje, jak vykreslit soubory PDF jako součást výkresů DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Exportování DXF do formátu WMF**

Tento přístup funguje následovně:

1. Načtěte soubor s výkresem DXF pomocí metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a načtěte soubory PDF.
1. Nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Zavolejte [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) a uložte soubor.

Následující ukázkový kód ukazuje, jak exportovat DXF do formátu WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Podpora uložení souborů DXF**

Aspose.CAD poskytuje funkcionalitu pro načítání souborů AutoCAD DXF a provádění změn v nich a opětovné uložení jako soubor DXF. Ukázkový kód níže ukazuje, jak dosáhnout stanovených požadavků

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Export vloženého podkladu DGN pro formát DXF**

Aspose.CAD poskytuje funkci pro načítání souborů AutoCAD DXF a export vloženého podkladu DGN pro formát DXF.

Ukázkový kód níže ukazuje, jak dosáhnout stanovených požadavků.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Exportování konkrétního rozložení DXF do formátu PDF**

Tento přístup funguje následovně:

1. Otevřete soubor s výkresem DXF pomocí metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a specifikujte vlastnosti [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) a [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Specifikujte požadovaný název(názvy) rozložení pomocí vlastnosti [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte její vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportujte výkres do formátu PDF pomocí metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Následující ukázkový kód ukazuje, jak převést konkrétní rozložení DXF do formátu PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) je typu pole řetězců, takže můžete specifikovat více než jedno rozložení najednou pro možné převedení do formátu PDF. Při specifikaci více rozložení pro vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) bude výsledné PDF obsahovat více stránek, kde každá strana reprezentuje individuální rozložení programu AutoCAD.

{{% /alert %}}

## **Přístup k objektům ATTRIB a MTEXT**

Tento přístup funguje následovně:

1. Otevřete soubor s výkresem DXF pomocí metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Přístup k entitám uvnitř souboru CAD.
1. Kontrola entit [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) a [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Přidejte do dočasného seznamu pro další z