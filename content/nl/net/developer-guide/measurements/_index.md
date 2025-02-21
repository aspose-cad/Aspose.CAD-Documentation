---
title: Metingen
type: docs
weight: 40
url: /nl/net/developer-guide/measurements/
---

## **Oppervlakte- en lengtemetingen**

Bepaalde entiteiten ondersteunen de berekening van oppervlakte en lengte (omtrek): CIRCLE, ELLIPSE, ARC en LWPOLYLINE. Bovendien ondersteunt de POLYLINE-entiteit de berekening van lengte, maar niet van oppervlakte. Andere entiteiten geven een NotImplementedException.

Hier is een voorbeeld hoe je lengte en oppervlakte kunt berekenen:

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
              // Opmerkingen hier indien nodig
         }
     }
}
```
