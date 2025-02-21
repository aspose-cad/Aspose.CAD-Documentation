---
title: Phát hiện mã trang tự động
type: docs
weight: 10
url: /vi/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Phát hiện mã trang tự động**

Aspose.CAD hỗ trợ phát hiện mã trang tự động cho [DWG](https://docs.fileformat.com/cad/dwg/) và [DWF](https://docs.fileformat.com/cad/dwf/) files. Nếu bạn không muốn sử dụng tính năng này, bạn có thể ghi đè nó bằng cách thiết lập các thuộc tính sau của lớp [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): thiết lập mã hóa được sử dụng để đọc dữ liệu văn bản từ các định dạng DXF và DWG không phải Unicode. Nó được phát hiện tự động theo mặc định.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): thiết lập mã hóa được sử dụng để đọc các ký hiệu mã hóa MIF của các mã CJK (định dạng M+nXXXX). Nó được phát hiện tự động theo mặc định.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): định nghĩa xem liệu các ký tự CIF (U+XXXX) và ký tự mã hóa MIF có được giải mã nếu chúng không có định dạng AutoCAD đúng (AutoCAD đặt các ký hiệu này với dấu gạch chéo ngược). Theo mặc định, chúng được giải mã.

## Mẫu mã

Mẫu mã dưới đây cho thấy cách ghi đè phát hiện mã trang tự động trong Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
