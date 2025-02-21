---
title: 測定
type: docs
weight: 40
url: /ja/net/developer-guide/measurements/
---

## **面積と長さの測定**

特定のエンティティは面積と長さ（周囲）の計算をサポートしています：CIRCLE、ELLIPSE、ARC、LWPOLYLINE。また、POLYLINEエンティティは長さの計算をサポートしていますが、面積はサポートしていません。他のエンティティはNotImplementedExceptionをスローします。

以下は、長さと面積を計算する方法の例です：

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
              // 実装されていません
         }
     }
}
```
