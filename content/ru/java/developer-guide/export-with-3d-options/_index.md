---
title: Экспорт с 3D опциями
type: docs
weight: 40
url: /ru/java/developer-guide/export-with-3d-options/
---

## **Экспорт с 3D опциями**

Несколько опций были введены для экспорта 3D моделей в PDF/растровый формат из соответствующих FBX, OBJ, STL.

Вот примеры 3D сцены с разных точек зрения:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

Свойство ObserverPoint позволяет вращать 3D сцену в соответствии с указанными углами вокруг оси. Этот пример показывает код и результат экспорта с использованием некоторых произвольных углов вращения.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/_assets/guide/3d/fig3.png)

Изменение ObserverAngle на ObserverPoint = new ObserverPoint(5, 60, 0) позволяет вращать сцену.

![Export with changed rotation](/_assets/guide/3d/fig4.png)

Другой параметр RenderMode3D позволяет указать, как результат экспорта должен быть представлен. Существует 3 режима: Solid (по умолчанию), Wireframe и SolidWithEdges.

Пример ниже позволяет создать каркасную модель для сферического объекта.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

Пример ниже показывает разницу между режимами Solid и SolidWithEdges.

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)
