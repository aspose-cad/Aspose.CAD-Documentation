---
title: Exportálás 3D lehetőségekkel
type: docs
weight: 40
url: /hu/java/developer-guide/export-with-3d-options/
---

## **Exportálás 3D lehetőségekkel**

Néhány lehetőség került bevezetésre a 3D modellek PDF/raster formátumba történő exportálásához a megfelelő FBX, OBJ, STL formátumokból.

Itt vannak a 3D jelenet példái különböző nézőpontokból:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

Az ObserverPoint tulajdonság lehetővé teszi a 3D jelenet forgatását a megadott szögkörök körül. Ez a példa megmutatja a kódot és az export eredményét néhány önkényes forgatási szöggel.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/cad/_assets/guide/3d/fig3.png)

Az ObserverAngle ObserverPoint = new ObserverPoint(5, 60, 0) értékre állítása lehetővé teszi a jelenet forgatását.

![Export with changed rotation](/cad/_assets/guide/3d/fig4.png)

A másik RenderMode3D tulajdonság lehetővé teszi, hogy megadjuk, hogyan kell bemutatni az export eredményt. Három mód létezik: Solid (alapértelmezett), Wireframe és SolidWithEdges.

Az alábbi példa lehetővé teszi, hogy huzalozott modellt hozzunk létre a gömb alakú objektumhoz.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

Az alábbi példa megmutatja a különbséget a Solid és a SolidWithEdges mód között.

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
