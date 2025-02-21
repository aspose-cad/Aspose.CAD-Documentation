---
title: 获取外部文件的引用
type: docs
weight: 36
url: /zh/net/developer-guide/how-to/get-references-to-external-files/
---

## **如何获取外部文件的引用**

**问题：** 如何获取外部文件的引用 (CADNET-110)。

**提示：** 要获取实体块中图纸的外部文件的引用，可以使用 XRef PathName 字段，对于光栅图像使用 CadRasterImage Def， 对于外部底图使用 CadDgnUnderlay，并使用其 UnderlayPath 字段。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
