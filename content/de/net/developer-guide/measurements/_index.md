---
title: Messungen
type: docs
weight: 40
url: /de/net/measurements/
---

## **Fläche- und Längenmessungen**

Bestimmte Entitäten unterstützen die Berechnung von Fläche und Länge (Umfang): KREIS, ELLIPSE, BOGEN und LWPOLYLINE. Darüber hinaus unterstützt die POLYLINE-Entität die Berechnung von Länge, aber nicht von Fläche. Andere Entitäten werfen eine NotImplementedException.

Hier ist ein Beispiel, wie man Länge und Fläche berechnet:

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
