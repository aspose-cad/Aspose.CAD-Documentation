---
title: Exportar con opciones 3D
type: docs
weight: 40
url: /es/java/developer-guide/export-with-3d-options/
---

## **Exportar con opciones 3D**

Se introdujeron algunas opciones para exportar modelos 3D a PDF/raster desde los formatos FBX, OBJ, STL correspondientes.

Aquí están los ejemplos de la escena 3D desde diferentes puntos de vista:

![Figuras](/cad/_assets/guide/3d/fig1.png)

![Figuras desde otros puntos de vista](/cad/_assets/guide/3d/fig2.png)

La propiedad ObserverPoint permite rotar la escena 3D según los ángulos especificados alrededor del eje. Este ejemplo muestra el código y el resultado de la exportación utilizando algunos ángulos de rotación arbitrarios.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Exportar con rotación](/cad/_assets/guide/3d/fig3.png)

Cambiar el ObserverAngle a ObserverPoint = new ObserverPoint(5, 60, 0) permite rotar la escena.

![Exportar con rotación cambiada](/cad/_assets/guide/3d/fig4.png)

La otra propiedad RenderMode3D permite especificar cómo se debe presentar el resultado de la exportación. Hay 3 modos: Sólido (el predeterminado), Malha de alambre y Sólido con bordes.

El ejemplo a continuación permite crear un modelo de malla de alambre para el objeto esférico.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Modo de malla de alambre](/cad/_assets/guide/3d/fig5.png)

El ejemplo a continuación muestra la diferencia entre los modos Sólido y Sólido con bordes.

![Modo sólido](/cad/_assets/guide/3d/fig6.png)
![Modo sólido con borde](/cad/_assets/guide/3d/fig7.png)
