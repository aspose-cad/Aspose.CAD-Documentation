---
title: Measurements
type: docs
weight: 40
url: /net/measurements/
---

## **Area and length measurements**

Certain entities support calculation of area and length (perimeter): CIRCLE, ELLIPSE, ARC and LWPOLYLINE. Additionally, POLYLINE entity supports calculation of length but not the area. Other entities throw NotImplementedException.

Here is the example how to calculate length and area:

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

