---
title: Ölçümler
type: docs
weight: 40
url: /tr/net/developer-guide/measurements/
---

## **Alan ve uzunluk ölçümleri**

Belirli varlıklar alan ve uzunluk (çevre) hesaplamasını destekler: DİSK, ELİPSE, KİRPİ ve LWPOLYLINE. Ayrıca, POLYLINE varlığı uzunluk hesaplamasını destekler ancak alanı desteklemez. Diğer varlıklar NotImplementedException fırlatır.

İşte uzunluk ve alan hesaplamanın nasıl yapılacağına dair bir örnek:

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
              // Uygulama bu durumu desteklemiyor
         }
     }
}
```
