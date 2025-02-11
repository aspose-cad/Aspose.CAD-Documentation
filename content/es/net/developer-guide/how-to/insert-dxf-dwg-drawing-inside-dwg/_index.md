---
title: Insertar dibujo DXF/DWG dentro de DWG
type: docs
weight: 38
url: /es/net/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Cómo insertar un dibujo DXF/DWG dentro de DWG**

**Problema:** Cómo insertar un dibujo DXF/DWG dentro de DWG.

**Consejos:** Para hacer esto, primero crea un CadInsertObject con los valores requeridos, luego obtén todos los bloques en un CadBlockDictionary, crea un nuevo bloque CadBlockEntity y agrégalo al CadBlockDictionary, agrega un CadBlockDictionary a los BlockEntities del dibujo, agrega un CadInsertObject a la entidad del dibujo para el arreglo, crea un CadBlockTableObject por referencia y luego agrega un bloque al dibujo.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
