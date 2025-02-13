---
title: Mesures
type: docs
weight: 40
url: /fr/net/developer-guide/measurements/
---

## **Mesures de surface et de longueur**

Certaines entités prennent en charge le calcul de la surface et de la longueur (périmètre) : CIRCLE, ELLIPSE, ARC et LWPOLYLINE. De plus, l'entité POLYLINE prend en charge le calcul de la longueur mais pas de la surface. D'autres entités déclenchent NotImplementedException.

Voici un exemple de la façon de calculer la longueur et la surface :

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
              // Traitement de l'exception non implémentée
         }
     }
}
```
