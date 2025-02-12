---
title: Exportando fuentes SHX
type: docs
weight: 40
url: /es/java/developer-guide/export-shx-fonts/
---

## **Exportar fuentes SHX para dibujos DXF/DWG**

Algunos dibujos pueden contener fuentes en formato SHX especial, que almacena símbolos de la fuente en forma de formas.
Este formato requiere un procedimiento de carga adicional para cada fuente utilizada en el dibujo.
Apose.CAD puede exportar dibujos con texto escrito en SHX y tiene diferentes opciones para hacerlo.
La forma más simple de hacerlo es usar la propiedad [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) del objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Cada fuente SHX viene con la página de código adecuada asociada a ella. Estas asociaciones son conocidas y están parcialmente incrustadas en Aspose.CAD para fuentes SHX conocidas.
En el caso de que se utilice alguna fuente SHX personalizada, es posible aplicar la propiedad **setShxCodePages** y configurar la ruta al archivo SHX y la página de código correspondiente.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
