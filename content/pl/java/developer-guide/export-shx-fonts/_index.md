---
title: Eksportowanie czcionek SHX
type: docs
weight: 40
url: /pl/java/developer-guide/export-shx-fonts/
---

## **Eksport czcionek SHX dla rysunków DXF/DWG**

Niektóre rysunki mogą zawierać czcionki w specjalnym formacie SHX, który przechowuje symbole czcionki w formie kształtów.
Ten format wymaga dodatkowej procedury ładowania dla każdej czcionki użytej w rysunku.
Apose.CAD może eksportować rysunki z tekstem napisanym w SHX i ma różne opcje, aby to zrobić.
Najprostszym sposobem na to jest użycie [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-)
właściwości obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Każda czcionka SHX ma przypisaną odpowiednią stronę kodową. Te powiązania są znane i częściowo wbudowane w Aspose.CAD dla znanych czcionek SHX.
W przypadku użycia niestandardowej czcionki SHX możliwe jest zastosowanie właściwości **setShxCodePages** i ustawienie ścieżki do pliku SHX oraz odpowiedniej strony kodowej.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
