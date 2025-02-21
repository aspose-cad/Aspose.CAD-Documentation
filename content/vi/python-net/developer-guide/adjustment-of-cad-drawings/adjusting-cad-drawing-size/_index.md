---
title: Điều chỉnh kích thước bản vẽ CAD
type: docs
weight: 10
url: /vi/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Bằng cách sử dụng thư viện Aspose.CAD cho Python, các nhà phát triển có thể điều chỉnh kích thước bản vẽ CAD trong quá trình chuyển đổi sang bất kỳ định dạng nào được hỗ trợ. Chủ đề này giải thích cách tiếp cận để tự động hoặc thủ công điều chỉnh kích thước bằng cách sử dụng enum **UnitType** của lớp **ImageOptions**.

{{% /alert %}}

## **Điều chỉnh kích thước bản vẽ CAD**

Aspose.CAD cho Python cung cấp enum **UnitType** để điều chỉnh kích thước bản vẽ trong quá trình chuyển đổi định dạng CAD. Có hai cách để điều chỉnh kích thước bản vẽ.

1. Điều chỉnh kích thước tự động.
1. Điều chỉnh kích thước bằng cách sử dụng enum **UnitType** của lớp **ImageOptions**.

Để điều chỉnh kích thước tự động, các nhà phát triển không cần cung cấp thuộc tính Width và Height của lớp **CadRasterizationOptions**. Dưới đây là đoạn mã ví dụ về việc tự động điều chỉnh kích thước.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

Enum **UnitType** cho phép điều chỉnh tỷ lệ khi các thuộc tính Width và Height không được đặt. Dưới đây là đoạn mã ví dụ minh họa cách sử dụng **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
