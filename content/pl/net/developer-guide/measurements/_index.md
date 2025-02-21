---
title: Pomiary
type: docs
weight: 40
url: /pl/net/developer-guide/measurements/
---

## **Pomiary powierzchni i długości**

Niektóre jednostki wspierają obliczanie powierzchni i długości (obwód): CIRCLE, ELLIPSE, ARC i LWPOLYLINE. Dodatkowo, jednostka POLYLINE wspiera obliczanie długości, ale nie powierzchni. Inne jednostki zgłaszają wyjątek NotImplementedException.

Oto przykład, jak obliczyć długość i powierzchnię:

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
