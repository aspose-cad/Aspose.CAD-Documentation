---
title: Eksport do DXF
type: docs
weight: 20
url: /pl/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **Jak eksportować do DXF**

**Problem:** Jak eksportować do DXF.

**Wskazówki:** Aby to zrobić, możesz użyć DxfOption, zarówno binarnej, jak i normalnej, w opcjach zapisu pliku.

**Uwaga:** Jedną z interesujących funkcji jest możliwość zapisywania dowolnego obsługiwanego formatu pliku do dxf.
To naprawdę dobra funkcja, ma również kilka niuansów:
Zapisywanie z formatów plików DXF/DWG - wykonuje eksport z dokładnymi encjami, które ma format źródłowy.
Eksport z innych formatów - wykonuje eksport, używając tylko linii i encji tekstowych.
Dodatkowo obsługujemy pliki DXf w formacie ASCII i binarnym.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
