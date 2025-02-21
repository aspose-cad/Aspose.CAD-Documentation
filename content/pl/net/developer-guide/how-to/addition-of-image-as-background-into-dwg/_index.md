---
title: Dodawanie obrazu jako tła do DWG
type: docs
weight: 15
url: /pl/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Jak dodać obraz jako tło w DWG**

**Problem:** Jak dodać obraz jako tło w DWG.

**Porady:** Aby to zrobić, utwórz obiekt CadRasterImageDef dla obrazu tła, utwórz obiekt CadRasterImage, aby wstawić tło do rysunku, dodaj obiekt CadRasterImage do obiektów rysunku, utwórz CadBaseObject i dodaj go do cadImage.Objects, przetwarzaj wszystko za pomocą CadBlockTableObject.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
