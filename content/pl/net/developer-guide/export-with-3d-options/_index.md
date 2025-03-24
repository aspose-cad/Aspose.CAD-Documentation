---
title: Eksport z opcjami 3D
type: docs
weight: 40
url: /pl/net/developer-guide/export-with-3d-options/
---

## **Eksport z opcjami 3D**

Kilka opcji wprowadzono do eksportu modeli 3D do formatu PDF/raster z odpowiednich formatów FBX, OBJ, STL.

Oto przykłady sceny 3D z różnych punktów widzenia:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

Właściwość ObserverPoint pozwala na obracanie sceny 3D według określonych kątów wokół osi. Ten przykład pokazuje kod i wynik eksportu z użyciem dowolnych kątów obrotu.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Eksport z rotacją](/cad/_assets/guide/3d/fig3.png)

Zmiana ObserverAngle na ObserverPoint = new ObserverPoint(5, 60, 0) pozwala na obrót sceny.

![Eksport z zmienioną rotacją](/cad/_assets/guide/3d/fig4.png)

Inna właściwość RenderMode3D pozwala określić, w jaki sposób powinien być przedstawiony wynik eksportu. Istnieją 3 tryby: Solid (domyślny), Wireframe i SolidWithEdges.

Przykład poniżej pozwala na stworzenie modelu siatkowego dla obiektu sferycznego.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Tryb siatkowy](/cad/_assets/guide/3d/fig5.png)

Przykład poniżej pokazuje różnicę między trybami Solid i SolidWithEdges.

![Tryb Solid](/cad/_assets/guide/3d/fig6.png)
![Tryb Solid z krawędzią](/cad/_assets/guide/3d/fig7.png)
