---
title: Các phép đo
type: docs
weight: 40
url: /vi/net/developer-guide/measurements/
---

## **Các phép đo diện tích và chiều dài**

Một số thực thể hỗ trợ tính toán diện tích và chiều dài (chu vi): CIRCLE, ELLIPSE, ARC và LWPOLYLINE. Ngoài ra, thực thể POLYLINE hỗ trợ tính toán chiều dài nhưng không tính diện tích. Những thực thể khác sẽ ném ra NotImplementedException.

Dưới đây là ví dụ về cách tính toán chiều dài và diện tích:

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
              // Xử lý trường hợp không được thực hiện
         }
     }
}
```
