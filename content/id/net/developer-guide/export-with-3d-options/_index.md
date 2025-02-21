---
title: Ekspor dengan opsi 3D
type: docs
weight: 40
url: /id/net/developer-guide/export-with-3d-options/
---

## **Ekspor dengan opsi 3D**

Beberapa opsi diperkenalkan untuk mengekspor model 3D ke PDF/raster dari format FBX, OBJ, STL yang sesuai.

Berikut adalah contoh pemandangan 3D dari sudut pandang yang berbeda:

![Figures](/_assets/guide/3d/fig1.png)

![Figures dari sudut pandang lain](/_assets/guide/3d/fig2.png)

Properti ObserverPoint memungkinkan untuk memutar pemandangan 3D sesuai dengan sudut yang ditentukan di sekitar sumbu. Contoh ini menunjukkan kode dan hasil ekspor menggunakan beberapa sudut rotasi sembarangan.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Ekspor dengan rotasi](/_assets/guide/3d/fig3.png)

Mengubah ObserverAngle menjadi ObserverPoint = new ObserverPoint(5, 60, 0) memungkinkan untuk memutar pemandangan.

![Ekspor dengan rotasi yang diubah](/_assets/guide/3d/fig4.png)

Properti RenderMode3D lainnya memungkinkan untuk menentukan bagaimana hasil ekspor harus disajikan. Ada 3 mode: Solid (default), Wireframe, dan SolidWithEdges.

Contoh di bawah ini memungkinkan untuk membuat model wireframe untuk objek sferis.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Mode wireframe](/_assets/guide/3d/fig5.png)

Contoh di bawah ini menunjukkan perbedaan antara mode Solid dan SolidWithEdges.

![Mode solid](/_assets/guide/3d/fig6.png)
![Mode solid dengan tepi](/_assets/guide/3d/fig7.png)
