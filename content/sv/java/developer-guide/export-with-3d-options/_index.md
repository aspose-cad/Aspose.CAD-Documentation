---
title: Exportera med 3D-alternativ
type: docs
weight: 40
url: /sv/java/developer-guide/export-with-3d-options/
---

## **Exportera med 3D-alternativ**

Flera alternativ introducerades för att exportera 3D-modeller till PDF/raster från motsvarande FBX, OBJ, STL-format.

Här är exempel på 3D-scenen från olika vyer:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures från andra synvinklar](/cad/_assets/guide/3d/fig2.png)

ObserverPoint egenskapen gör det möjligt att rotera 3D-scenen enligt angivna vinklar runt axeln. Detta exempel visar koden och exportresultatet med vissa godtyckliga rotationsvinklar.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export med rotation](/cad/_assets/guide/3d/fig3.png)

Genom att ändra ObserverAngle till ObserverPoint = new ObserverPoint(5, 60, 0) kan man rotera scenen.

![Export med ändrad rotation](/cad/_assets/guide/3d/fig4.png)

Den andra RenderMode3D egenskapen gör det möjligt att specificera hur exportresultatet ska presenteras. Det finns 3 lägen: Solid (standard), Wireframe och SolidWithEdges.

Exemplet nedan gör det möjligt att skapa en trådrammodell för det sfäriska objektet.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Trådramläge](/cad/_assets/guide/3d/fig5.png)

Exemplet nedan visar skillnaden mellan Solid och SolidWithEdges lägen.

![Solidläge](/cad/_assets/guide/3d/fig6.png)
![Solid med kantläge](/cad/_assets/guide/3d/fig7.png)
