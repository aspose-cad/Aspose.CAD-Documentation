---
title: Odczyt, aktualizacja i zapis pliku DWG
type: docs
weight: 11
url: /pl/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Jak odczytać, zaktualizować i zapisać plik DWG**

**Problem:** Jak odczytać, zaktualizować i zapisać plik DWG.

**Porady:** Aby to zrobić, możesz uzyskać plik za pomocą metody load, pobrać niezbędne byty i wprowadzić zmiany, takie jak zmiana punktów początkowych i końcowych lub grubości linii.

**Uwagi:** Ten fragment kodu pokazuje przykład odczytywania pliku dwg, zmieniając obiekty: pozycje linii, okręgów, wartości tekstowe (możesz dodać zmiany do innych obiektów i ich wartości, dla których odczyt/zapis jest obsługiwany) i następnie zapisywanie do nowego pliku. Możesz otworzyć nowy plik w AutoCAD i zobaczyć obiekty z zmienionymi wartościami.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
