---
title: Phát hiện mã trang tự động
type: docs
weight: 10
url: /vi/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Phát hiện mã trang tự động**

Aspose.CAD hỗ trợ phát hiện mã trang tự động cho [DWG](https://docs.fileformat.com/cad/dwg/) và [DWF](https://docs.fileformat.com/cad/dwf/) files. Nếu bạn không muốn sử dụng tính năng này, bạn có thể ghi đè điều này bằng cách thiết lập các thuộc tính sau của lớp [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): thiết lập mã hóa được sử dụng để đọc dữ liệu văn bản từ các định dạng DXF và DWG không phải Unicode. Mặc định sẽ được phát hiện tự động.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): thiết lập mã hóa được sử dụng để đọc các ký hiệu mã hóa MIF của các mã CJK (định dạng M+nXXXX). Mặc định sẽ được phát hiện tự động.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): định nghĩa liệu các ký tự được mã hóa CIF (U+XXXX) và MIF sẽ được giải mã nếu chúng không có định dạng AutoCAD phù hợp (AutoCAD đưa các ký hiệu này với một dấu gạch chéo ngược). Mặc định, chúng sẽ được giải mã.

## Mẫu mã

Mẫu mã dưới đây cho thấy cách ghi đè phát hiện mã trang tự động trong Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
