---
title: Soporte de archivos CTB
type: docs
weight: 40
url: /es/java/developer-guide/support-ctb/
---

## **Soporte de archivos CTB**

A veces, el color, el grosor de las líneas y algunas otras opciones para los dibujos pueden ser utilizados no solo de los dibujos en sí, sino también de los estilos de trama en archivos CTB separados. La forma más simple de utilizar esta información es colocar los archivos CTB correspondientes cerca del archivo con el dibujo en formato DWG/DXF y la información de ellos se aplicará automáticamente durante la exportación.

También es posible cargar todos los archivos CTB en forma de Stream usando 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) propiedad del 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objeto.

Aquí hay un ejemplo de cómo hacer esto:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
