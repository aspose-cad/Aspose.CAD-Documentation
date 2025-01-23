---
title: Измервания
type: docs
weight: 40
url: /bg/net/measurements/
---

## **Измервания на площ и дължина**

Определени единици поддържат изчисление на площ и дължина (периметър): КРЪГ, ЕЛИПСА, ДЪГА и LWPOLYLINE. Освен това, единицата POLYLINE поддържа изчисление на дължина, но не и на площ. Други единици хвърлят NotImplementedException.

Ето пример как да се изчисли дължина и площ:

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
