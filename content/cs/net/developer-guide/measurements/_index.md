---
title: Měření
type: docs
weight: 40
url: /cs/net/developer-guide/measurements/
---

## **Měření plochy a délky**

Některé entity podporují výpočet plochy a délky (obvodu): KRUŽNICE, ELIPSA, ÚHEL a LWPOLYLINE. KROMĚ TOHO, entita POLYLINE podporuje výpočet délky, ale ne plochy. Ostatní entity vyvolávají NotImplementedException.

Zde je příklad, jak vypočítat délku a plochu:

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
