---
title: Esporta con opzioni 3D
type: docs
weight: 40
url: /it/java/developer-guide/export-with-3d-options/
---

## **Esporta con opzioni 3D**

Sono state introdotte alcune opzioni per esportare modelli 3D in PDF/raster dai formati FBX, OBJ, STL corrispondenti.

Ecco gli esempi della scena 3D da diversi punti di vista:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

La proprietà ObserverPoint consente di ruotare la scena 3D in base agli angoli specificati attorno all'asse. Questo esempio mostra il codice e il risultato dell'esportazione utilizzando alcuni angoli di rotazione arbitrari.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/_assets/guide/3d/fig3.png)

Cambiando l'ObserverAngle in ObserverPoint = new ObserverPoint(5, 60, 0) si consente di ruotare la scena.

![Export with changed rotation](/_assets/guide/3d/fig4.png)

L'altra proprietà RenderMode3D consente di specificare come dovrebbe essere presentato il risultato dell'esportazione. Ci sono 3 modalità: Solido (la predefinita), Wireframe e SolidoConBordi.

L'esempio seguente consente di creare un modello wireframe per l'oggetto sferico.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

L'esempio seguente mostra la differenza tra le modalità Solido e SolidoConBordi.

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)
