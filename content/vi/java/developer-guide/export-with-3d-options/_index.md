---
title: Xuất với tùy chọn 3D
type: docs
weight: 40
url: /vi/java/developer-guide/export-with-3d-options/
---

## **Xuất với tùy chọn 3D**

Một số tùy chọn đã được giới thiệu để xuất mô hình 3D sang PDF/hình raster từ các định dạng FBX, OBJ, STL tương ứng.

Dưới đây là những ví dụ về cảnh 3D từ các góc độ khác nhau:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

Thuộc tính ObserverPoint cho phép xoay cảnh 3D theo các góc được chỉ định xung quanh trục. Ví dụ này cho thấy mã và kết quả xuất sử dụng một số góc xoay tùy ý.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Xuất với xoay](/cad/_assets/guide/3d/fig3.png)

Việc thay đổi ObserverAngle thành ObserverPoint = new ObserverPoint(5, 60, 0) cho phép xoay cảnh.

![Xuất với xoay đã thay đổi](/cad/_assets/guide/3d/fig4.png)

Thuộc tính RenderMode3D khác cho phép chỉ định cách kết quả xuất nên được trình bày. Có 3 chế độ: Đặc (mặc định), Lưới, và ĐặcCóĐườngViền.

Ví dụ dưới đây cho phép tạo mô hình lưới cho đối tượng hình cầu.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Chế độ lưới](/cad/_assets/guide/3d/fig5.png)

Ví dụ dưới đây cho thấy sự khác biệt giữa chế độ Đặc và ĐặcCóĐườngViền.

![Chế độ đặc](/cad/_assets/guide/3d/fig6.png)
![Chế độ đặc có đường viền](/cad/_assets/guide/3d/fig7.png)
