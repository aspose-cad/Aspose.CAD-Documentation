---
title: Exportar dibujos y diseños DWG/DXF en tamaño especificado
type: docs
weight: 40
url: /es/java/export-into-size/
---

## **Exportar modelo y todos los diseños en tamaño PDF A4**

La API Aspose.CAD te permite exportar todas las hojas del archivo DWG/DXF en un tamaño físico PDF especificado.
El siguiente código de ejemplo configura el tamaño del objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) para lograr el tamaño PDF deseado.
El tamaño de la hoja de papel A4 es de 210x297 milímetros o 8.27x11.69 pulgadas y estos valores se utilizan en el código.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Exportar diseños CAD a PDF en diferentes tamaños**

A veces es necesario exportar el diseño en su tamaño físico. El ejemplo a continuación muestra la exportación del dibujo en un PDF multipágina donde cada página con contenido de diseño
tiene su propio tamaño físico PDF. Este ejemplo utiliza la propiedad [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) .

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
