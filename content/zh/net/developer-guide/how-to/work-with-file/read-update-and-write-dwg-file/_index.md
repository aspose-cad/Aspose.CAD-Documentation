---
title: 阅读、更新和写入 DWG 文件
type: docs
weight: 11
url: /zh/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **如何阅读、更新和写入 DWG 文件**

**问题:** 如何阅读、更新和写入 DWG 文件。

**提示:** 要做到这一点，您可以使用 load 方法获取文件，获取所需的实体并对其进行更改，例如更改起始点和结束点或线条的厚度。

**注意:** 该代码片段展示了读取 dwg 文件的示例，更改对象：线条、圆形、文本值的位置（您可以对其他支持读取/写入的对象及其值进行更改）然后保存到新文件。因此，您可以在 AutoCAD 中打开一个新文件并查看值已更改的对象。

**示例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
