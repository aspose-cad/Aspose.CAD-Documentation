---
title: Exportando fuentes SHX
type: docs
weight: 40
url: /es/python-net/developer-guide/export-shx-fonts/
---

## **Exportar fuentes SHX para dibujos DXF/DWG**

Algunos dibujos pueden contener fuentes en formato especial SHX, que almacena los símbolos de la fuente en forma de formas. Este formato requiere un procedimiento de carga adicional para cada fuente utilizada en el dibujo. Apose.CAD puede exportar dibujos con texto escrito en SHX y tiene diferentes opciones para hacerlo. La forma más simple de hacerlo es usar la propiedad 
**ShxFonts** del objeto 
**CadRasterizationOptions**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
