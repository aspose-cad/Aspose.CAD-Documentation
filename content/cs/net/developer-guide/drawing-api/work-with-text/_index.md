---
title: Práce s textem
type: docs
weight: 40
url: /cs/prace-s-textem/
---

## **Práce s textem**

Téměř všechny výkresy obsahují textové objekty a tyto příklady ukazují, jak s nimi provést operace.
Existují různé typy entit pro formáty DWG/DXF, které mohou uchovávat text, jsou to [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Dva poslední typy jsou obvykle spojeny s [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
a jsou uloženy uvnitř něj nebo v odpovídajícím bloku.

Zde jsou některé příklady popisující operace s textem.

### **Vyhledání textu**

Tento příklad ukazuje, jak najít hodnoty textu v souboru DWG/DXF a lze ho použít také ke změně hodnot textu.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Vyhledání textu.cs">}}

### **Přidání nových položek Text a MText**

Zde je příklad, jak přidat nové textové/Mtextové objekty do výkresu. Přidání nových entit může změnit velikost výkresu, proto je doporučeno
zavolat UpdateSize() po těchto operacích.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Přidání text_mtext.cs">}}
