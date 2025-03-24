---
title: Exporteren met 3D-opties
type: docs
weight: 40
url: /nl/net/developer-guide/export-with-3d-options/
---

## **Exporteren met 3D-opties**

Er zijn enkele opties geïntroduceerd om 3D-modellen naar PDF/raster te exporteren vanuit de bijbehorende FBX-, OBJ-, STL-formaten.

Hier zijn de voorbeelden van de 3D-scène vanuit verschillende gezichtspunten:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures vanuit andere gezichtspunten](/cad/_assets/guide/3d/fig2.png)

De ObserverPoint-eigenschap maakt het mogelijk om de 3D-scène te draaien volgens specifieke hoeken rondom de as. Dit voorbeeld toont de code en het exportresultaat met behulp van enkele willekeurige rotatiehoeken.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Exporteren met rotatie](/cad/_assets/guide/3d/fig3.png)

Het wijzigen van de ObserverAngle naar ObserverPoint = new ObserverPoint(5, 60, 0) maakt het mogelijk om de scène te draaien.

![Exporteren met gewijzigde rotatie](/cad/_assets/guide/3d/fig4.png)

De andere RenderMode3D-eigenschap maakt het mogelijk om aan te geven hoe het exportresultaat gepresenteerd moet worden. Er zijn 3 modi: Solid (de standaard), Wireframe en SolidWithEdges.

Het voorbeeld hieronder maakt het mogelijk om een wireframe-model voor het sferische object te creëren.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe-modus](/cad/_assets/guide/3d/fig5.png)

Het voorbeeld hieronder toont het verschil tussen de Solid- en SolidWithEdges-modi.

![Solid-modus](/cad/_assets/guide/3d/fig6.png)
![Solid met rand-modus](/cad/_assets/guide/3d/fig7.png)
