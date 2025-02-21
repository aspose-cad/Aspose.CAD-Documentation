---
title: 3D Seçenekleriyle Dışa Aktarma
type: docs
weight: 40
url: /tr/java/developer-guide/export-with-3d-options/
---

## **3D Seçenekleriyle Dışa Aktarma**

PDF/rastr biçimlerine, ilgili FBX, OBJ, STL formatlarından 3D modelleri dışa aktarmak için birkaç seçenek tanıtıldı.

İşte farklı bakış açılarından 3D sahne örnekleri:

![Figürler](/_assets/guide/3d/fig1.png)

![Diğer bakış açılarından figürler](/_assets/guide/3d/fig2.png)

ObserverPoint özelliği, 3D sahneyi belirtilen açılar etrafında döndürmeye olanak tanır. Bu örnek, bazı rastgele döndürme açıları kullanarak kodu ve dışa aktarma sonucunu göstermektedir.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Döndürme ile dışa aktarma](/_assets/guide/3d/fig3.png)

ObserverAngle'ı ObserverPoint = new ObserverPoint(5, 60, 0) olarak değiştirmek sahneyi döndürmeye imkan tanır.

![Değiştirilen döndürme ile dışa aktarma](/_assets/guide/3d/fig4.png)

Diğer RenderMode3D özelliği, dışa aktarma sonucunun nasıl sunulacağını belirlemek için kullanılır. 3 mod vardır: Katı (varsayılan), Kablo Şeması ve Kenarlarla Katı.

Aşağıdaki örnek, küresel nesne için kablo şeması modeli oluşturmayı sağlar.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Kablo Şeması Modu](/_assets/guide/3d/fig5.png)

Aşağıdaki örnek, Katı ve Kenarlarla Katı modları arasındaki farkı göstermektedir.

![Katı Modu](/_assets/guide/3d/fig6.png)
![Kenar ile Katı Modu](/_assets/guide/3d/fig7.png)
