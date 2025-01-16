---
title: Measurements
type: docs
weight: 40
url: /ar/net/measurements/
---

## **قياسات المساحة والطول**

تدعم بعض الكيانات حساب المساحة والطول (المحيط): الدائرة، البيضاوي، القوس و LWPOLYLINE. بالإضافة إلى ذلك، تدعم كيان POLYLINE حساب الطول ولكن ليس المساحة. الكيانات الأخرى ترمي استثناء NotImplementedException.

إليك مثال على كيفية حساب الطول والمساحة:

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
              ...
         }
     }
}
```
