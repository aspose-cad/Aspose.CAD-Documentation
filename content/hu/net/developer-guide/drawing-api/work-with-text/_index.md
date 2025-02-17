---
title: Munka szöveggel
type: docs
weight: 40
url: /hu/net/developer-guide/drawing-api/work-with-text/
---

## **Munka szöveggel**

Szinte minden rajz szöveges objektumokat tartalmaz, és ezek a példák megmutatják, hogyan lehet műveleteket végezni velük. 
Különböző típusú entitások léteznek a DWG/DXF fájlformátumban, amelyek tárolhatnak szöveget, ezek a következők: [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Az utolsó két típus általában kapcsolódik 
a [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
és bennfoglaltatik benne vagy a megfelelő blokkban.

Itt van néhány példa a szöveggel végzett műveletek leírására.

### **Szöveg keresése**

Ez a példa megmutatja, hogyan lehet megtalálni a szöveges értékeket a DWG/DXF fájlban, és szöveges értékek cseréjére is használható.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Új Text és MText elemek hozzáadása**

Itt van egy példa, hogyan lehet új Text/MText objektumokat hozzáadni a rajzhoz. Az új entitások hozzáadása megváltoztathatja a rajz méretét, ezért ajánlott
az UpdateSize() hívása ezen műveletek után.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
