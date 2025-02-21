---
title: Вимірювання
type: docs
weight: 40
url: /uk/net/developer-guide/measurements/
---

## **Вимірювання площі та довжини**

Деякі сутності підтримують обчислення площі та довжини (периметра): CIRCLE, ELLIPSE, ARC та LWPOLYLINE. Додатково, сутність POLYLINE підтримує обчислення довжини, але не площі. Інші сутності викликають NotImplementedException.

Ось приклад, як обчислити довжину та площу:

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
              // Обробка не реалізованого виключення
         }
     }
}
```
