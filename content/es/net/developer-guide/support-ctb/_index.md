---
title: Soporte de archivos CTB
type: docs
weight: 40
url: /es/net/developer-guide/support-ctb/
---

## **Soporte de archivos CTB**

A veces, los colores, pesos de línea y algunas otras opciones para los dibujos pueden ser utilizados no solo de los propios dibujos, sino también de los estilos de impresión en archivos CTB separados.  
La forma más sencilla de utilizar esta información es colocar los archivos CTB correspondientes cerca del archivo con el dibujo en formato DWG/DXF y la información de estos se aplicará automáticamente durante la exportación.

También es posible cargar todos los archivos CTB en forma de Stream utilizando 
la propiedad [**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) del 
objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).

Aquí hay un ejemplo de cómo hacer esto:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
