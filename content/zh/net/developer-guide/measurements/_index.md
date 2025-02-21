---
title: 测量
type: docs
weight: 40
url: /zh/net/developer-guide/measurements/
---

## **面积和长度测量**

某些实体支持面积和长度（周长）的计算：圆、椭圆、弧和LWPOLYLINE。此外，POLYLINE实体支持长度计算，但不支持面积计算。其他实体抛出NotImplementedException。

下面是如何计算长度和面积的示例：

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
              // 处理未实现的异常
         }
     }
}
```
