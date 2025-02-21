---
title: 检查外部引用图像是否存在并替换引用
type: docs
weight: 22
url: /zh/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **如何编辑对象上的超链接**

**问题：** 如何检查外部引用的图像是否存在并替换引用 (CADNET-8088)。

**提示：** 为此，从绘图实体中获取类型为 CadObjectTypeName.IMAGEDEF 的实体，并使用 CadRasterImageDef 进行检查。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
