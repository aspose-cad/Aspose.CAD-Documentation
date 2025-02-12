---
title: Exportando dibujo y maquetas DWG/DXF en un tamaño especificado
type: docs
weight: 40
url: /es/net/developer-guide/export-into-size/
---

## **Exportar modelo y todas las maquetas en tamaño A4 PDF**

La API de Aspose.CAD permite exportar todas las hojas del archivo DWG/DXF en un tamaño físico de PDF especificado.

El siguiente código de ejemplo configura el tamaño del objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) para lograr el tamaño de PDF deseado. 
El tamaño de una hoja de papel A4 es de 210x297 milímetros o 8.27x11.69 pulgadas y estos valores se utilizan en el código.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calcular tamaños para A4.cs">}}

## **Exportar maquetas CAD a PDF en diferentes tamaños**

A veces se requiere exportar la maqueta en su tamaño físico. El ejemplo a continuación demuestra la exportación del dibujo a un PDF multipágina donde cada página con el contenido de la maqueta
tiene su propio tamaño físico de PDF. Este ejemplo utiliza la propiedad [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Exportar a multipágina con diferentes tamaños de páginas.cs">}}
