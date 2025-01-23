---
title: Vykreslení DXF
type: docs
weight: 10
url: /cs/python-net/dxf-drawings/
---

## **Exportování vykreslení DXF do PDF**

Aspose.CAD poskytuje funkci načítání entit výkresů AutoCAD DXF a jejich vykreslování jako celého výkresu ve formátu PDF. Přístup k převodu DXF na PDF funguje následovně:

1. Načtěte soubor s výkresem DXF pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **VectorRasterizationOptions**.
1. Zavolejte **Image.save** a jako druhý parametr předejte objekt **PdfOptions**.

Následující ukázka kódu ukazuje, jak převést soubor s použitím výchozích nastavení.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Podporované formáty**

V současné době plně podporujeme formáty souborů AutoCAD DXF 2010. Předchozí verze DXF nejsou zaručeně 100% platné. Plánujeme zahrnout více formátů a funkcí v budoucích verzích Aspose.CAD.

### **Podporované entity**

V současné době podporujeme všechny běžné 2D entity a jejich základní výchozí parametry, a to:

1. Zarovnané rozměry
1. Úhlové rozměry
1. Kružnice
1. Atribut
1. Reference bloku
1. Kruh
1. Průměrové rozměry
1. Elipsa
1. Šrafy
1. Úsečka
1. Víceřádkový text
1. Osobní rozměr
1. Bod
1. Nultá linie
1. Radiální rozměry
1. Paprsek
1. Otočené rozměry
1. Tabulka
1. Text
1. X-čára

{{% alert color="primary" %}}

Pokud během parsování narazíme na nějakou entitu nebo vlastnost, kterou nepodporujeme, entita nebo vlastnost bude bez upozornění ignorována.

{{% /alert %}}

## **Export vloženého podkladu DGN pro formát DXF**

Aspose.CAD poskytuje funkci načítání souborů AutoCAD DXF a exportování vloženého podkladu DGN pro formát DXF.

Následující ukázka kódu ukazuje, jak dosáhnout stanovených požadavků.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Podpora pro ukládání souborů DXF**

Aspose.CAD poskytuje funkci načítání souborů AutoCAD DXF, provádění změn v nich a opětovné uložení jako souboru DXF.

Následující ukázka kódu ukazuje, jak dosáhnout stanovených požadavků.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Export DXF do WMF**

Tento přístup funguje následovně:

1. Načtěte soubor s výkresem DXF pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a načtěte soubory PDF.
1. Nastavte vlastnosti **page_height** a **page_width**.
1. Zavolejte **Image.save** a uložte soubor.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
