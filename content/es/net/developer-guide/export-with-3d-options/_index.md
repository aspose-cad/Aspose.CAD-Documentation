---
title: Exportar con opciones 3D
type: docs
weight: 40
url: /es/net/exportar-con-opciones-3d/
---

## **Exportar con opciones 3D**

Se introdujeron algunas opciones para exportar modelos 3D a PDF/raster desde los formatos FBX, OBJ, STL correspondientes.

Aquí están los ejemplos de la escena 3D desde diferentes puntos de vista:

![Figuras](/es/_assets/fig1.png)

![Figuras desde otros puntos de vista](/es/_assets/fig2.png)

La propiedad ObserverPoint permite rotar la escena 3D según los ángulos especificados alrededor del eje. Este ejemplo muestra el código y el resultado de la exportación utilizando algunos ángulos de rotación arbitrarios.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Exportar con rotación](/es/_assets/fig3.png)

Cambiar el ObserverAngle a ObserverPoint = new ObserverPoint(5, 60, 0) permite rotar la escena.

![Exportar con rotación cambiada](/es/_assets/fig4.png)

La otra propiedad RenderMode3D permite especificar cómo se debe presentar el resultado de la exportación. Hay 3 modos: Sólido (el predeterminado), Alámbrico y SólidoConBordes.

El siguiente ejemplo permite crear un modelo alámbrico para el objeto esférico.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Modo alámbrico](/es/_assets/fig5.png)

El siguiente ejemplo muestra la diferencia entre los modos Sólido y SólidoConBordes.

![Modo sólido](/es/_assets/fig6.png)
![Modo sólido con borde](/es/_assets/fig7.png)
