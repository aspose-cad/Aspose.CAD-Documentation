---
title: Adición de imagen como fondo en DWG
type: docs
weight: 15
url: /es/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Cómo agregar una imagen como fondo en DWG**

**Problema:** Cómo agregar una imagen como fondo en DWG.

**Consejos:** Para hacer esto, crea un objeto CadRasterImageDef para la imagen de fondo, crea un objeto CadRasterImage para insertar el fondo en el dibujo, agrega un objeto CadRasterImage a los objetos de dibujo, crea un CadBaseObject y agrégalo a cadImage.Objects, procesa todo a través de CadBlockTableObject.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
