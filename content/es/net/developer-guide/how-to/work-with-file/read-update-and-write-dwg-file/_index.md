---
title: Leer, actualizar y escribir archivo DWG
type: docs
weight: 11
url: /es/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Cómo leer, actualizar y escribir un archivo DWG**

**Problema:** Cómo leer, actualizar y escribir un archivo DWG.

**Consejos:** Para hacer esto, puedes obtener el archivo utilizando el método de carga, obtener las entidades necesarias y hacer cambios en ellas, como cambiar los puntos de inicio y fin o el grosor de las líneas.

**Nota:** Este fragmento de código muestra un ejemplo de lectura de un archivo dwg, cambiando objetos: las posiciones de líneas, círculos, valores de texto (puedes agregar cambios a otros objetos y sus valores para los cuales se admite la lectura/escritura) y luego guardando en un nuevo archivo. Así podrás abrir un nuevo archivo en AutoCAD y ver objetos con valores cambiados.

**Ejemplo:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
