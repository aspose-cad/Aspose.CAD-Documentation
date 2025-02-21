---
title: Exportar com opções 3D
type: docs
weight: 40
url: /pt/net/developer-guide/export-with-3d-options/
---

## **Exportar com opções 3D**

Poucas opções foram introduzidas para exportar modelos 3D para PDF/raster a partir dos formatos FBX, OBJ, STL correspondentes.

Aqui estão os exemplos da cena 3D de diferentes pontos de vista:

![Figures](/_assets/guide/3d/fig1.png)

![Figuras de outros pontos de vista](/_assets/guide/3d/fig2.png)

A propriedade ObserverPoint permite rotacionar a cena 3D de acordo com os ângulos especificados em torno do eixo. Este exemplo mostra o código e o resultado da exportação usando alguns ângulos de rotação arbitrários.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Exportação com rotação](/_assets/guide/3d/fig3.png)

Alterar o ObserverAngle para ObserverPoint = new ObserverPoint(5, 60, 0) permite rotacionar a cena.

![Exportação com rotação alterada](/_assets/guide/3d/fig4.png)

A outra propriedade RenderMode3D permite especificar como o resultado da exportação deve ser apresentado. Existem 3 modos: Sólido (o padrão), Wireframe e SólidoComBordas.

O exemplo abaixo permite criar um modelo wireframe para o objeto esférico.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Modo wireframe](/_assets/guide/3d/fig5.png)

O exemplo abaixo mostra a diferença entre os modos Sólido e SólidoComBordas.

![Modo sólido](/_assets/guide/3d/fig6.png)
![Modo sólido com borda](/_assets/guide/3d/fig7.png)
