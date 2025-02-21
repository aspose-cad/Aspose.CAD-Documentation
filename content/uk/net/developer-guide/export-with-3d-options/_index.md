---
title: Експорт з 3D параметрами
type: docs
weight: 40
url: /uk/net/developer-guide/export-with-3d-options/
---

## **Експорт з 3D параметрами**

Були введені кілька опцій для експорту 3D моделей у PDF/растрові формати з відповідних FBX, OBJ, STL форматів.

Ось приклади 3D сцени з різних точок зору:

![Фігури](/_assets/guide/3d/fig1.png)

![Фігури з інших точок зору](/_assets/guide/3d/fig2.png)

Властивість ObserverPoint дозволяє обертати 3D сцену відповідно до заданих кутів навколо осі. Цей приклад показує код і результат експорту з використанням деяких випадкових кутів обертання.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Експорт з обертанням](/_assets/guide/3d/fig3.png)

Зміна ObserverAngle на ObserverPoint = new ObserverPoint(5, 60, 0) дозволяє обертати сцену.

![Експорт з зміненим обертанням](/_assets/guide/3d/fig4.png)

Інша властивість RenderMode3D дозволяє вказати, як має бути представлений результат експорту. Є 3 режими: Solid (за замовчуванням), Wireframe та SolidWithEdges.

Наприклад, наведений нижче код дозволяє створити каркасну модель для сферичного об'єкта.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Режим Wireframe](/_assets/guide/3d/fig5.png)

Приклад нижче показує різницю між режимами Solid і SolidWithEdges.

![Режим Solid](/_assets/guide/3d/fig6.png)
![Режим Solid з краями](/_assets/guide/3d/fig7.png)
