---
title: Mérések
type: docs
weight: 40
url: /hu/net/developer-guide/measurements/
---

## **Terület és hossz mérések**

Bizonyos entitások támogatják a terület és hossz (kerület) számítását: KÖR, ELIPSZIS, ÍV és LWPOLYLINE. Ezenkívül a POLYLINE entitás támogatja a hossz számítását, de nem a területét. Más entitások NotImplementedException kivételt dobnak.

Íme egy példa, hogyan lehet kiszámítani a hosszúságot és a területet:

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
              // A kivétel kezelése
         }
     }
}
```
