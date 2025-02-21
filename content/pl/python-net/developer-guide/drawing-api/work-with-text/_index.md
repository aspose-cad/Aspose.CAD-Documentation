---
title: Pracuj z tekstem
type: docs
weight: 40
url: /pl/python-net/developer-guide/drawing-api/work-with-text/
---

## **Pracuj z tekstem**

Prawie wszystkie rysunki zawierają obiekty tekstowe, a te przykłady pokazują, jak przeprowadzać operacje z nimi. 
Istnieją różne typy jednostek dla DWG/DXF, które mogą przechowywać tekst, są to **CadText**, **CadMText**, CadAttDef, CadAttrib. Dwa ostatnie typy są zazwyczaj związane 
z **CadInsertObject** i przechowywane wewnątrz niego lub w odpowiednim bloku.

Oto kilka przykładów opisujących operacje z tekstem.

### **Wyszukiwanie tekstu**

Ten przykład pokazuje, jak znaleźć wartości tekstowe w pliku DWG/DXF i może być również używany do zastępowania wartości tekstowych.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
