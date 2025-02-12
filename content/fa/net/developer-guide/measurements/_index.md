---
title: Measurements
type: docs
weight: 40
url: /fa/net/measurements/
---

## **اندازه‌گیری مساحت و طول**

برخی موجودیت‌ها از محاسبه مساحت و طول (محیط) پشتیبانی می‌کنند: دایره، بیضی، قوس و LWPOLYLINE. علاوه بر این، موجودیت POLYLINE از محاسبه طول پشتیبانی می‌کند اما نه مساحت. سایر موجودیت‌ها استثنای NotImplementedException را پرتاب می‌کنند.

در اینجا مثالی برای محاسبه طول و مساحت آورده شده است:

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
              // اینجا یک استثنای نه پیاده‌سازی شده رخ داده است
         }
     }
}
```
