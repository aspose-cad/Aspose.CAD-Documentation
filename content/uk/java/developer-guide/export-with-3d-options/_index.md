---
title: Експорт з 3D опціями
type: docs
weight: 40
url: /uk/java/developer-guide/export-with-3d-options/
---

## **Експорт з 3D опціями**

Було введено кілька опцій для експорту 3D моделей у PDF/растровий формат з відповідних FBX, OBJ, STL форматів.

Ось приклади 3D сцени з різних точок зору:

![Figures](/_assets/guide/3d/fig1.png)

![Фігури з інших точок зору](/_assets/guide/3d/fig2.png)

Властивість ObserverPoint дозволяє обертати 3D сцену відповідно до вказаних кутів навколо осі. Цей приклад демонструє код та результат експорту, використовуючи деякі довільні кути обертання.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Експорт з обертанням](/_assets/guide/3d/fig3.png)

Зміна ObserverAngle на ObserverPoint = new ObserverPoint(5, 60, 0) дозволяє обертати сцену.

![Експорт з зміненим обертанням](/_assets/guide/3d/fig4.png)

Інша властивість RenderMode3D дозволяє вказати, як має бути представлений результат експорту. Є 3 режими: Solid (за замовчуванням), Wireframe та SolidWithEdges.

Приклад нижче дозволяє створити каркасну модель для сферичного об'єкта.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Режим Wireframe](/_assets/guide/3d/fig5.png)

Приклад нижче демонструє різницю між режимами Solid та SolidWithEdges.

![Solid режим](/_assets/guide/3d/fig6.png)
![Solid з краєм режим](/_assets/guide/3d/fig7.png)
