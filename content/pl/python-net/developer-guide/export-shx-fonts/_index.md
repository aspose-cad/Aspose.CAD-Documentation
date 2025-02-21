---
title: Eksportowanie czcionek SHX
type: docs
weight: 40
url: /pl/python-net/developer-guide/export-shx-fonts/
---

## **Eksportowanie czcionek SHX do rysunków DXF/DWG**

Niektóre rysunki mogą zawierać czcionki w specjalnym formacie SHX, który przechowuje symbole czcionki w formie kształtów. Format ten wymaga dodatkowej
procedury ładowania dla każdej czcionki używanej w rysunku. Apose.CAD może eksportować rysunki z tekstem zapisanym w SHX i ma różne opcje, aby to zrobić. Najprostszy sposób to po prostu użyć 
**ShxFonts** właściwości obiektu 
**CadRasterizationOptions**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
