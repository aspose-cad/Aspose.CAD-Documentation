---
title: Mediciones
type: docs
weight: 40
url: /es/net/developer-guide/measurements/
---

## **Mediciones de área y longitud**

Ciertas entidades soportan el cálculo de área y longitud (perímetro): CÍRCULO, ELLIPSE, ARC y LWPOLYLINE. Además, la entidad POLYLINE soporta el cálculo de longitud pero no de área. Otras entidades lanzan NotImplementedException.

Aquí hay un ejemplo de cómo calcular longitud y área:

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
