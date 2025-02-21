---
title: Điều chỉnh kích thước bản vẽ CAD
type: docs
weight: 10
url: /vi/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Bằng cách sử dụng thư viện Aspose.CAD cho .NET, các nhà phát triển có thể điều chỉnh kích thước bản vẽ CAD trong quá trình chuyển đổi sang bất kỳ định dạng được hỗ trợ nào. Chủ đề này giải thích cách tiếp cận để điều chỉnh kích thước tự động hoặc thủ công bằng cách sử dụng enum [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) của lớp [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Điều chỉnh kích thước bản vẽ CAD**

Aspose.CAD cho .NET cung cấp enum [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) để điều chỉnh kích thước bản vẽ trong quá trình chuyển đổi định dạng CAD. Có hai cách để điều chỉnh kích thước bản vẽ.

1. Điều chỉnh kích thước tự động.
1. Điều chỉnh kích thước bằng cách sử dụng enum [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) của lớp [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

Đối với việc điều chỉnh kích thước tự động, các nhà phát triển không cần cung cấp các thuộc tính Width và Height của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Dưới đây là đoạn mã mẫu minh họa điều chỉnh kích thước tự động.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

Enum [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) cung cấp khả năng điều chỉnh tỷ lệ khi các thuộc tính Width và Height không được thiết lập. Dưới đây là đoạn mã mẫu minh họa cách sử dụng [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
