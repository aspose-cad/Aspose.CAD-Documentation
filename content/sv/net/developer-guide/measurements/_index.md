---
title: Mätningsdata
type: docs
weight: 40
url: /sv/net/developer-guide/measurements/
---

## **Area och längdmätningar**

Vissa enheter stöder beräkning av area och längd (omkrets): CIRKEL, ELLIPS, BÅGE och LWPOLYLINE. Dessutom stöder POLYLINE-enheten beräkning av längd men inte area. Andra enheter kastar NotImplementedException.

Här är ett exempel på hur man beräknar längd och area:

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
              // Här hanteras undantaget
         }
     }
}
```
