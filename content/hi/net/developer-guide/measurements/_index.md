---
title: माप
type: docs
weight: 40
url: /hi/net/developer-guide/measurements/
---

## **क्षेत्रफल और लंबाई के माप**

कुछ संस्थाएँ क्षेत्रफल और लंबाई (परिमिति) का गणना समर्थन करती हैं: CIRCLE, ELLIPSE, ARC और LWPOLYLINE। इसके अतिरिक्त, POLYLINE संस्था लंबाई की गणना का समर्थन करती है लेकिन क्षेत्रफल की नहीं। अन्य संस्थाएँ NotImplementedException फेंकती हैं।

यहाँ लंबाई और क्षेत्रफल की गणना करने का एक उदाहरण है:

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
