---
title: Eksportowanie czcionek SHX
type: docs
weight: 40
url: /pl/net/developer-guide/export-shx-fonts/
---

## **Eksportowanie czcionek SHX dla rysunków DXF/DWG**

Niektóre rysunki mogą zawierać czcionki w specjalnym formacie SHX, który przechowuje symbole czcionki w formie kształtów. Ten format wymaga dodatkowej
procedury ładowania dla każdej czcionki użytej w rysunku. Apose.CAD może eksportować rysunki z tekstem napisanym w SHX i ma różne opcje, aby to zrobić. Najprostszy sposób to po prostu użyć 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) właściwości 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) obiektu.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


Możliwe jest uniknięcie ustawiania wszystkich ścieżek do wielu czcionek SHX w następującym przykładzie:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
Każda czcionka SHX jest powiązana z odpowiednią stroną kodową. Te powiązania są znane i częściowo wbudowane w Aspose.CAD dla znanych czcionek SHX.
W przypadku używania niestandardowej czcionki SHX, możliwe jest zastosowanie właściwości ShxCodePages i ustawienie ścieżki do pliku SHX oraz odpowiadającej strony kodowej. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
