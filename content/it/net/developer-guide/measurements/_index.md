---
title: Misurazioni
type: docs
weight: 40
url: /it/net/developer-guide/measurements/
---

## **Misurazioni di area e lunghezza**

Alenti specifici supportano il calcolo di area e lunghezza (perimetro): CIRCLE, ELLIPSE, ARC e LWPOLYLINE. Inoltre, l'entità POLYLINE supporta il calcolo della lunghezza ma non dell'area. Altre entità generano NotImplementedException.

Ecco un esempio di come calcolare lunghezza e area:

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
