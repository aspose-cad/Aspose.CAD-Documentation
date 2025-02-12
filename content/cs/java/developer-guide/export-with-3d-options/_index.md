---
title: Export s 3D možnostmi
type: docs
weight: 40
url: /cs/java/export-with-3d-options/
---

## **Export s 3D možnostmi**

Byly zavedeny některé možnosti pro export 3D modelů do formátu PDF/raster z odpovídajících formátů FBX, OBJ, STL.

Zde jsou příklady 3D scény z různých pohledů:

![Obrázky](/_assets/guide/3d/fig1.png)

![Obrázky z jiných pohledů](/_assets/guide/3d/fig2.png)

Vlastnost ObserverPoint umožňuje otáčet 3D scénou podle specifikovaných úhlů kolem osy. Tento příklad ukazuje kód a výsledek exportu s nějakými libovolnými úhly rotace.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-vlastnost.java">}}


![Export s rotací](/_assets/guide/3d/fig3.png)

Změna úhlu pozorovatele na ObserverPoint = new ObserverPoint(5, 60, 0) umožňuje rotovat scénu.

![Export se změněnou rotací](/_assets/guide/3d/fig4.png)

Další vlastnost RenderMode3D umožňuje specifikovat, jak by měl být prezentován výsledek exportu. Existují 3 režimy: Solid (výchozí), Drátěný model a Solid s hranami.

Následující příklad umožňuje vytvořit drátěný model pro sférický objekt.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-vlastnost.java">}}

![Režim drátového modelu](/_assets/guide/3d/fig5.png)

Následující příklad ukazuje rozdíl mezi režimy Solid a Solid s hranami.

![Režim Solid](/_assets/guide/3d/fig6.png)
![Režim Solid s hranami](/_assets/guide/3d/fig7.png)
