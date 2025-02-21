---
title: Praca z tekstem
type: docs
weight: 40
url: /pl/net/developer-guide/drawing-api/work-with-text/
---

## **Praca z tekstem**

Prawie wszystkie rysunki zawierają obiekty tekstowe i te przykłady pokazują, jak przeprowadzać operacje na nich. 
Istnieją różne typy encji dla DWG/DXF, które mogą przechowywać tekst, są to [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Dwa ostatnie typy są zazwyczaj związane 
z [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
i są przechowywane wewnątrz niego lub w odpowiednim bloku.

Oto kilka przykładów opisujących operacje z tekstem.

### **Wyszukiwanie tekstu**

Ten przykład pokazuje, jak znaleźć wartości tekstowe w pliku DWG/DXF i może być użyty również do zamiany wartości tekstowych.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Dodawanie nowych elementów Text i MText**

Oto przykład, jak dodać nowe obiekty Text/Mtext do rysunku. Dodanie nowych encji może zmienić rozmiar rysunku, dlatego zaleca się
wywołanie UpdateSize() po tych operacjach.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
