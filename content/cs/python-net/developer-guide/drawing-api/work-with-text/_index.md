---
title: Práce s textem
type: docs
weight: 40
url: /cs/python-net/developer-guide/drawing-api/work-with-text/
---

## **Práce s textem**

Téměř všechny výkresy obsahují textové objekty a tyto příklady ukazují, jak s nimi provádět operace. Existují různé druhy entit pro formáty DWG/DXF, které mohou uchovávat text, jsou to **CadText**, **CadMText**, CadAttDef, CadAttrib. Dva poslední typy jsou obvykle spojeny s **CadInsertObject** a jsou uchovávány uvnitř něj nebo v příslušném bloku.

Zde jsou některé příklady popisující operace s textem.

### **Vyhledání textu**

Tento příklad ukazuje, jak najít textové hodnoty v souboru DWG/DXF a může být také použit k nahrazení textových hodnot.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
