---
title: Exportálás 3D lehetőségekkel
type: docs
weight: 40
url: /hu/net/developer-guide/export-with-3d-options/
---

## **Exportálás 3D lehetőségekkel**

Néhány lehetőség került bevezetésre 3D modellek PDF/raszter formátumba való exportálásához a megfelelő FBX, OBJ, STL formátumokból.

Íme néhány példa a 3D jelenetre különböző nézőpontokból:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

Az ObserverPoint tulajdonság lehetővé teszi a 3D jelenet forgatását a megadott szögszámok szerint. Ez a példa megjeleníti a kódot és az exportált eredményt néhány önkényesen választott forgatási szöggel.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export with rotation](/cad/_assets/guide/3d/fig3.png)

Az ObserverAngle ObserverPoint = new ObserverPoint(5, 60, 0) értékre történő megváltoztatása lehetővé teszi a jelenet forgatását.

![Export with changed rotation](/cad/_assets/guide/3d/fig4.png)

A másik RenderMode3D tulajdonság lehetővé teszi, hogy megadjuk, hogyan kell bemutatni az exportált eredményt. 3 mód létezik: Solid (az alapértelmezett), Wireframe és SolidWithEdges.

Az alábbi példa lehetőséget ad a drótváz modell létrehozására gömb alakú objektumhoz.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

Az alábbi példa bemutatja a különbséget a Solid és a SolidWithEdges módok között.

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
