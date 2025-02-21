---
title: Phát hiện mã trang tự động
type: docs
weight: 10
url: /vi/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Phát hiện mã trang tự động**

Aspose.CAD hỗ trợ phát hiện mã trang tự động cho [DWG](https://docs.fileformat.com/cad/dwg/) và [DWF](https://docs.fileformat.com/cad/dwf/) files. Nếu bạn không muốn sử dụng tính năng này, bạn có thể ghi đè bằng cách thiết lập các thuộc tính sau của lớp **LoadOptions**.

- **specified_encoding**: thiết lập mã hóa được sử dụng để đọc dữ liệu văn bản từ định dạng DXF và DWG không phải Unicode. Nó được phát hiện tự động theo mặc định.
- **specified_mif_encoding**: thiết lập mã hóa được sử dụng để đọc các ký hiệu mã hóa MIF của các mã CJK (định dạng M+nXXXX). Nó được phát hiện tự động theo mặc định.
- **recover_malformed_cif_mif**: xác định xem các ký tự CIF (U+XXXX) và MIF-encoded có được giải mã nếu chúng không có định dạng AutoCAD đúng (AutoCAD đặt dấu gạch chéo ngược trước các ký hiệu này). Theo mặc định, chúng được giải mã.

## Mã mẫu

Mẫu mã dưới đây cho thấy cách ghi đè phát hiện mã trang tự động trong Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
