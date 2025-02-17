---
title: מדידות
type: docs
weight: 40
url: /he/net/developer-guide/measurements/
---

## **מדידות שטח ואורך**

ישויות מסוימות תומכות בחישוב שטח ואורך (פרמטר): מעגל, אליפסה, קשת ו-LWPOLYLINE. בנוסף, ישות POLYLINE תומכת בחישוב אורך אך לא בשטח. ישויות אחרות זורקות NotImplementedException.

הנה דוגמה כיצד לחשב אורך ושטח:

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
              // כאן תוכל לטפל בחריגה
         }
     }
}
```
