---
title: Medidas
type: docs
weight: 40
url: /pt/net/developer-guide/measurements/
---

## **Medições de área e comprimento**

Certas entidades suportam o cálculo de área e comprimento (perímetro): CÍRCULO, ELLIPSE, ARCO e LWPOLYLINE. Além disso, a entidade POLYLINE suporta o cálculo de comprimento, mas não da área. Outras entidades geram NotImplementedException.

Aqui está um exemplo de como calcular comprimento e área:

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
