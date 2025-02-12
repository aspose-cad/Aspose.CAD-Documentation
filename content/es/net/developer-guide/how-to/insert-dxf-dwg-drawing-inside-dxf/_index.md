---
title: Insertar dibujo DXF/DWG dentro de DXF
type: docs
weight: 39
url: /es/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Cómo insertar un dibujo DXF/DWG dentro de DXF**

**Problema:** Cómo insertar un dibujo DXF/DWG dentro de DXF.

**Consejos:** Para hacer esto, primero debes crear un CadInsertObject con los valores necesarios, luego obtener todos los bloques en el CadBlockDictionary, crear un nuevo bloque CadBlockEntity y añadirlo al CadBlockDictionary, añadir el CadBlockDictionary a los BlockEntities del dibujo, añadir un CadInsertObject a las entidades del dibujo para la matriz.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
