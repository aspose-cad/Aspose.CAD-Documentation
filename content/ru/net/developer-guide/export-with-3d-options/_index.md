---
title: Экспорт с 3D-опциями
type: docs
weight: 40
url: /ru/net/developer-guide/export-with-3d-options/
---

## **Экспорт с 3D-опциями**

Несколько опций были введены для экспорта 3D-моделей в PDF/растр из соответствующих форматов FBX, OBJ, STL.

Вот примеры 3D-сцены с разных точек зрения:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

Свойство ObserverPoint позволяет вращать 3D-сцену в соответствии с заданными углами вокруг оси. Этот пример показывает код и результат экспорта с использованием произвольных углов вращения.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Экспорт с вращением](/cad/_assets/guide/3d/fig3.png)

Изменение ObserverAngle на ObserverPoint = new ObserverPoint(5, 60, 0) позволяет вращать сцену.

![Экспорт с изменённым вращением](/cad/_assets/guide/3d/fig4.png)

Другой параметр RenderMode3D позволяет указать, как должен быть представлен результат экспорта. Существуют 3 режима: Solid (по умолчанию), Wireframe и SolidWithEdges.

Пример ниже позволяет создать каркасную модель для сферического объекта.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

Пример ниже показывает разницу между режимами Solid и SolidWithEdges.

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
