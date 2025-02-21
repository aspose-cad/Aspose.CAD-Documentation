---
title: Lavora con il testo
type: docs
weight: 40
url: /it/net/developer-guide/drawing-api/work-with-text/
---

## **Lavora con il testo**

Quasi tutti i disegni contengono oggetti di testo e questi esempi mostrano come eseguire operazioni con essi. 
Ci sono diversi tipi di entità per DWG/DXF che possono memorizzare testo, sono [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Gli ultimi due tipi sono tipicamente correlati 
a [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
e memorizzati all'interno di esso o nel blocco corrispondente.

Ecco alcuni esempi che descrivono operazioni con il testo.

### **Cerca il testo**

Questo esempio mostra come trovare valori di testo nel file DWG/DXF e può essere utilizzato anche per sostituire i valori di testo.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Aggiunta di nuovi elementi di testo e MText**

Ecco l'esempio di come aggiungere nuovi oggetti Text/Mtext al disegno. L'aggiunta di nuove entità può cambiare la dimensione del disegno, quindi si raccomanda di 
chiamare UpdateSize() dopo queste operazioni.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
