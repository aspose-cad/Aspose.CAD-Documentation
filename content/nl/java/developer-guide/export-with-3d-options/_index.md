---
title: Exporteren met 3D-opties
type: docs
weight: 40
url: /nl/java/developer-guide/export-with-3d-options/
---

## **Exporteren met 3D-opties**

Er zijn verschillende opties geïntroduceerd om 3D-modellen te exporteren naar PDF/raster vanuit de overeenkomstige FBX-, OBJ-, STL-formaten.

Hier zijn de voorbeelden van de 3D-scene vanuit verschillende gezichtspunten:

![Figures](/_assets/guide/3d/fig1.png)

![Figures vanuit andere gezichtspunten](/_assets/guide/3d/fig2.png)

De eigenschap ObserverPoint maakt het mogelijk om de 3D-scene te draaien volgens aangegeven hoeken rond de as. Dit voorbeeld toont de code en het exportresultaat met behulp van enkele willekeurige rotatiehoeken.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Exporteren met rotatie](/_assets/guide/3d/fig3.png)

Door de ObserverAngle te veranderen in ObserverPoint = new ObserverPoint(5, 60, 0) kan de scene worden geroteerd.

![Exporteren met veranderde rotatie](/_assets/guide/3d/fig4.png)

De andere RenderMode3D-eigenschap maakt het mogelijk om te specificeren hoe het exportresultaat gepresenteerd moet worden. Er zijn 3 modi: Solide (de standaardinstelling), Draadframe en SolideMetRanden.

Het voorbeeld hieronder maakt het mogelijk om een draadframe-model voor het sferische object te creëren.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Draadframe modus](/_assets/guide/3d/fig5.png)

Het voorbeeld hieronder toont het verschil tussen de Solide- en SolideMetRanden-modi.

![Solide modus](/_assets/guide/3d/fig6.png)
![Solide met randen modus](/_assets/guide/3d/fig7.png)
