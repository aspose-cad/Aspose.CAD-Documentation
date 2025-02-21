---
title: Làm việc với văn bản
type: docs
weight: 40
url: /vi/net/developer-guide/drawing-api/work-with-text/
---

## **Làm việc với văn bản**

Hầu hết tất cả các bản vẽ đều chứa các đối tượng văn bản và các ví dụ này cho thấy cách thực hiện các thao tác với chúng. 
Có nhiều loại thực thể cho DWG/DXF có thể lưu trữ văn bản, đó là [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Hai loại cuối cùng thường liên quan 
đến [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
và được lưu trữ bên trong nó hoặc trong khối tương ứng.

Dưới đây là một số ví dụ mô tả các thao tác với văn bản.

### **Tìm kiếm văn bản**

Ví dụ này cho thấy cách tìm giá trị văn bản trong tệp DWG/DXF và cũng có thể được sử dụng để thay thế các giá trị văn bản.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Thêm các mục Text và MText mới**

Dưới đây là ví dụ về cách thêm các đối tượng Text/MText mới vào bản vẽ. Việc thêm các thực thể mới có thể thay đổi kích thước của bản vẽ, vì vậy được khuyến nghị
gọi UpdateSize() sau các thao tác này.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
