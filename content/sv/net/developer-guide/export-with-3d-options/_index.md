---
title: Exportera med 3D-alternativ
type: docs
weight: 40
url: /sv/net/developer-guide/export-with-3d-options/
---

## **Exportera med 3D-alternativ**

Flera alternativ har introducerats för att exportera 3D-modeller till PDF/raster från motsvarande FBX, OBJ, STL-format.

Här är exempel på 3D-scenen från olika synpunkter:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

ObserverPoint-egenskapen tillåter att rotera 3D-scenen enligt angivna vinklar runt axeln. Detta exempel visar koden och exportresultatet med hjälp av några godtyckliga rotationsvinklar.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export with rotation](/_assets/guide/3d/fig3.png)

Genom att ändra ObserverAngle till ObserverPoint = new ObserverPoint(5, 60, 0) kan vi rotera scenen.

![Export with changed rotation](/_assets/guide/3d/fig4.png)

Den andra RenderMode3D-egenskapen tillåter att specificera hur exportresultatet ska presenteras. Det finns 3 lägen: Solid (standard), Wireframe och SolidWithEdges.

Exemplet nedan möjliggör skapandet av en wireframe-modell för den sfäriska objektet.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

Exemplet nedan visar skillnaden mellan Solid och SolidWithEdges lägena.

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)
