---
title: Exportación de fuentes SHX
type: docs
weight: 40
url: /es/net/developer-guide/export-shx-fonts/
---

## **Exportar fuentes SHX para dibujos DXF/DWG**

Algunos dibujos pueden contener fuentes en formato SHX especial, que almacena símbolos de la fuente en forma de formas. Este formato requiere un procedimiento de carga adicional para cada fuente utilizada en el dibujo. Apose.CAD puede exportar dibujos con texto escrito en SHX y tiene diferentes opciones para hacerlo. La forma más sencilla de hacerlo es utilizar la propiedad 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) del objeto 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Ejemplo de ShxFonts.cs">}}


Es posible evitar configurar todas las rutas a múltiples fuentes SHX con el siguiente ejemplo:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Ejemplo de ShxFonts con carpeta.cs">}}
	
Cada fuente SHX viene con la página de código adecuada asociada a ella. Estas asociaciones son conocidas y están parcialmente incrustadas en Aspose.CAD para fuentes SHX conocidas.
En caso de que se utilice una fuente SHX personalizada, es posible aplicar la propiedad ShxCodePages y configurar la ruta al archivo SHX y la página de código correspondiente. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Ejemplo de ShxCodePages.cs">}}
