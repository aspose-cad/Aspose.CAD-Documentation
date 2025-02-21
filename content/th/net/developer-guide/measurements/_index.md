---
title: การวัด
type: docs
weight: 40
url: /th/net/developer-guide/measurements/
---

## **การวัดพื้นที่และความยาว**

เอนทิตีบางอย่างสนับสนุนการคำนวณพื้นที่และความยาว (เส้นรอบวง): CIRCLE, ELLIPSE, ARC และ LWPOLYLINE นอกจากนี้ เอนทิตี POLYLINE สนับสนุนการคำนวณความยาว แต่ไม่สนับสนุนพื้นที่ เอนทิตีอื่น ๆ จะเกิด NotImplementedException

นี่คือตัวอย่างวิธีการคำนวณความยาวและพื้นที่:

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
              // ...
         }
     }
}
```
