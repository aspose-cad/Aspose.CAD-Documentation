---
title: Esportazione con opzioni 3D
type: docs
weight: 40
url: /it/net/developer-guide/export-with-3d-options/
---

## **Esportazione con opzioni 3D**

Sono state introdotte alcune opzioni per esportare modelli 3D in PDF/raster dai formati FBX, OBJ, STL corrispondenti.

Ecco gli esempi della scena 3D da diverse angolazioni:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

La proprietà ObserverPoint consente di ruotare la scena 3D in base agli angoli specificati attorno all'asse. Questo esempio mostra il codice e il risultato dell'esportazione utilizzando alcuni angoli di rotazione arbitrari.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export with rotation](/cad/_assets/guide/3d/fig3.png)

Modificando l'ObserverAngle in ObserverPoint = new ObserverPoint(5, 60, 0) consente di ruotare la scena.

![Export with changed rotation](/cad/_assets/guide/3d/fig4.png)

L'altra proprietà RenderMode3D consente di specificare come deve essere presentato il risultato dell'esportazione. Ci sono 3 modalità: Solido (il predefinito), Wireframe e SolidoConBordi.

L'esempio seguente consente di creare un modello wireframe per l'oggetto sferico.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

L'esempio seguente mostra la differenza tra le modalità Solido e SolidoConBordi.

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
