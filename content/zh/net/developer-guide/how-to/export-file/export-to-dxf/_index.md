---
title: 导出到 DXF
type: docs
weight: 20
url: /zh/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **如何导出到 DXF**

**问题：** 如何导出到 DXF。

**提示：** 为此，您可以在文件保存选项中使用 DxfOption，既可以选择二进制也可以选择普通。

**注意：** 其中一个有趣的功能是能够将任何支持的文件格式保存为 dxf。
这是一个非常好的功能，还有几个细节：
从 DXF/DWG 文件格式保存 - 执行导出，准确保留源格式的实体
从其他格式导出 - 仅使用线条和文本实体进行导出。
此外，我们支持 ASCII 和二进制 DXf 文件格式。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
