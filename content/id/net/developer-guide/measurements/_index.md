---
title: Pengukuran
type: docs
weight: 40
url: /id/net/developer-guide/measurements/
---

## **Pengukuran area dan panjang**

Entitas tertentu mendukung perhitungan area dan panjang (perimeter): CIRCLE, ELLIPSE, ARC, dan LWPOLYLINE. Selain itu, entitas POLYLINE mendukung perhitungan panjang tetapi tidak area. Entitas lainnya akan mengeluarkan NotImplementedException.

Berikut adalah contoh cara menghitung panjang dan area:

```csharp
using (CadImage cadImage = (CadImage)Aspose.CAD.Image.Load(sourceFilePath))
{
     foreach (CadEntityBase eb in cadImage.Entities)
     {
         try
         {
             System.Console.WriteLine(eb.TypeName + " " + eb.Area + " " + eb.Length);
         }
         catch (NotImplementedException ex)
         {
              // penanganan kecuali jika tidak diimplementasikan
         }
     }
}
```
