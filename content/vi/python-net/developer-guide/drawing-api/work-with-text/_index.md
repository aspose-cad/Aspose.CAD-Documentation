---
title: Làm việc với văn bản
type: docs
weight: 40
url: /vi/python-net/developer-guide/drawing-api/work-with-text/
---

## **Làm việc với văn bản**

Hầu hết tất cả các bản vẽ đều chứa các đối tượng văn bản và những ví dụ này cho thấy cách thực hiện các thao tác với chúng. 
Có nhiều loại thực thể cho DWG/DXF có thể lưu trữ văn bản, đó là **CadText**, **CadMText**, CadAttDef, CadAttrib. Hai loại cuối thường liên quan 
đến **CadInsertObject** và được lưu trữ bên trong nó hoặc trong khối tương ứng.

Dưới đây là một số ví dụ mô tả các thao tác với văn bản.

### **Tìm kiếm văn bản**

Ví dụ này cho thấy cách tìm các giá trị văn bản trong tệp DWG/DXF và có thể được sử dụng để thay thế các giá trị văn bản.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
