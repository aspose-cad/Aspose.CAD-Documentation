---
title: Obliczanie pola i obwodu okręgów
type: docs
weight: 18
url: /pl/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **Jak obliczyć pole i obwód okręgów**

**Problem:** Jak obliczyć pole i obwód okręgów (CADNET-1153).

**Wskazówki:** Aby to zrobić, pobierz promień z CadEntityTypeName.CIRCLE z jednostek i użyj wzoru **"2 * Math.PI * promień"**.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
