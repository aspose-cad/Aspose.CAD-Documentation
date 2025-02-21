---
title: Lavorare con il testo
type: docs
weight: 40
url: /it/python-net/developer-guide/drawing-api/work-with-text/
---

## **Lavorare con il testo**

Quasi tutti i disegni contengono oggetti di testo e questi esempi mostrano come eseguire operazioni con essi. 
Ci sono diversi tipi di entità per DWG/DXF che possono memorizzare testo, essi sono **CadText**, **CadMText**, CadAttDef, CadAttrib. Gli ultimi due tipi sono generalmente correlati 
a **CadInsertObject** e memorizzati al suo interno o nel blocco corrispondente.

Ecco alcuni esempi che descrivono operazioni con il testo.

### **Cerca il testo**

Questo esempio mostra come trovare valori di testo nel file DWG/DXF e può essere utilizzato anche per la sostituzione dei valori di testo.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
