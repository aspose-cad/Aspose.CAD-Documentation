---
title: Dodaj nowe encje TEXT/MTEXT po prawej stronie istniejących 
type: docs
weight: 17
url: /pl/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Jak dodać nowe encje TEXT/MTEXT po prawej stronie istniejących**

**Problem:** Jak dodać nowe encje TEXT/MTEXT po prawej stronie istniejących (CADNET-8172).

**Wskazówki:** Aby to zrobić, utwórz obiekt CadBaseEntity, utwórz obiekt CadMText lub CadText z tekstem, w nowym obiekcie dodaj do pola SoftOwner cadImage.Layouts["Model"].BlockTableRecordHandle z rysunku, a następnie dodaj go do bloku cadImage.BlockEntities[" *MODEL_SPACE"] i dodaj nowy obiekt do encji rysunku.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
