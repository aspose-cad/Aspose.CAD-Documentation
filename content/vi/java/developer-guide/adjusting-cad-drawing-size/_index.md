---
title: Điều chỉnh kích thước bản vẽ CAD
type: docs
weight: 10
url: /vi/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Sử dụng Aspose.CAD cho Java, các nhà phát triển có thể điều chỉnh kích thước bản vẽ trong quá trình chuyển đổi định dạng CAD. Chủ đề này giải thích cách tiếp cận để tự động điều chỉnh hoặc điều chỉnh kích thước bằng cách sử dụng enum [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) của lớp [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Điều chỉnh kích thước bản vẽ CAD**

Aspose.CAD cho Java cung cấp enum [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) để điều chỉnh kích thước bản vẽ trong quá trình chuyển đổi định dạng CAD. Có hai cách để điều chỉnh kích thước bản vẽ.

1. Tự động điều chỉnh kích thước
1. Điều chỉnh kích thước bằng cách sử dụng enum [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) của lớp [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Để tự động điều chỉnh kích thước, các nhà phát triển không cần cung cấp thuộc tính Width và Height của lớp [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Đoạn mã dưới đây là ví dụ về kích thước tự động.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Enum [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) cho phép điều chỉnh tỷ lệ khi các thuộc tính Width và Height không được thiết lập. Đoạn mã dưới đây cho thấy cách sử dụng [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
