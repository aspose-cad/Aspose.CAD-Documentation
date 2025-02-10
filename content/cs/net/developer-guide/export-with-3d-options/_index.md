---
title: Export s možnostmi 3D
type: docs
weight: 40
url: /cs/export-s-moznostmi-3d/
---

## **Export s možnostmi 3D**

Byly představeny některé možnosti exportu 3D modelů do formátu PDF/raster ze souborů FBX, OBJ, STL.

Zde jsou příklady 3D scény z různých pohledů:

![Figury](/_assets/fig1.png)

![Figury z jiných pohledů](/_assets/fig2.png)

Vlastnost ObserverPoint umožňuje otáčet 3D scénou podle stanovených úhlů kolem osy. Tento příklad ukazuje kód a výsledek exportu s některými libovolnými úhly rotace.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export s rotací](/_assets/fig3.png)

Změna ObserverAngle na ObserverPoint = new ObserverPoint(5, 60, 0) umožňuje otáčet scénou.

![Export s změněnou rotací](/_assets/fig4.png)

Další vlastnost RenderMode3D umožňuje stanovit, jak by měl být výsledek exportu prezentován. Existují 3 režimy: Solid (výchozí), Wireframe a SolidWithEdges.

Následující příklad umožňuje vytvořit drátěný model pro kulatý objekt.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Režim drátěného modelu](/_assets/fig5.png)

Následující příklad ukazuje rozdíl mezi režimy Solid a SolidWithEdges.

![Režim Solid](/_assets/fig6.png)
![Režim Solid s hranami](/_assets/fig7.png)
