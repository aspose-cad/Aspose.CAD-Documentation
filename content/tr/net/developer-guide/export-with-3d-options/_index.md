---
title: 3D Seçenekleri ile Dışa Aktarma
type: docs
weight: 40
url: /tr/net/developer-guide/export-with-3d-options/
---

## **3D Seçenekleri ile Dışa Aktarma**

İlgili FBX, OBJ, STL formatlarından 3D modelleri PDF/raster olarak dışa aktarmak için birkaç seçenek tanıtıldı.

İşte farklı açılardan 3D sahnenin örnekleri:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Farklı açılardan figürler](/cad/_assets/guide/3d/fig2.png)

ObserverPoint özelliği, 3D sahneyi belirtilen eksenler etrafında belirli açılarla döndürmeyi sağlar. Bu örnek, bazı rastgele döndürme açıları kullanılarak kodu ve dışa aktarma sonucunu göstermektedir.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Dönme ile dışa aktarma](/cad/_assets/guide/3d/fig3.png)

ObserverAngle'ı ObserverPoint = new ObserverPoint(5, 60, 0) olarak değiştirmek, sahneyi döndürmeyi sağlar.

![Değiştirilmiş döndürme ile dışa aktarma](/cad/_assets/guide/3d/fig4.png)

Diğer RenderMode3D özelliği, dışa aktarma sonucunun nasıl sunulacağını belirtmeyi sağlar. 3 mod vardır: Katı (varsayılan), Kablolu ve Kenarlarla Katı.

Aşağıdaki örnek, küresel nesne için kablolu model oluşturmayı sağlar.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Kablolu mod](/cad/_assets/guide/3d/fig5.png)

Aşağıdaki örnek, Katı ve Kenarlarla Katı modları arasındaki farkı göstermektedir.

![Katı mod](/cad/_assets/guide/3d/fig6.png)
![Kenar moduyla katı](/cad/_assets/guide/3d/fig7.png)
