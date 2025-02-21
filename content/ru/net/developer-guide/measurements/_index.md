---
title: Измерения
type: docs
weight: 40
url: /ru/net/developer-guide/measurements/
---

## **Измерения площади и длины**

Некоторые сущности поддерживают расчет площади и длины (периметра): CIRCLE, ELLIPSE, ARC и LWPOLYLINE. Кроме того, сущность POLYLINE поддерживает расчет длины, но не площади. Другие сущности вызывают NotImplementedException.

Вот пример, как рассчитать длину и площадь:

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
              // Обработка исключения
         }
     }
}
```
