---
title: Μετρήσεις
type: docs
weight: 40
url: /el/net/measurements/
---

## **Μετρήσεις επιφάνειας και μήκους**

Ορισμένες οντότητες υποστηρίζουν τον υπολογισμό επιφάνειας και μήκους (περίμετρος): ΚΥΚΛΟΣ, ΕΛΛΕΙΨΗ, ΤΟΞΟ και LWPOLYLINE. Επιπλέον, η οντότητα POLYLINE υποστηρίζει τον υπολογισμό μήκους αλλά όχι επιφάνειας. Άλλες οντότητες εκτοξεύουν NotImplementedException.

Ακολουθεί το παράδειγμα πώς να υπολογίσετε μήκος και επιφάνεια:

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
