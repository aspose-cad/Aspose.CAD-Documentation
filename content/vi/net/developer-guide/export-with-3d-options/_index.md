---
title: Xuất với tùy chọn 3D
type: docs
weight: 40
url: /vi/net/developer-guide/export-with-3d-options/
---

## **Xuất với tùy chọn 3D**

Một vài tùy chọn đã được giới thiệu để xuất các mô hình 3D sang PDF/hình ảnh từ các định dạng FBX, OBJ, STL tương ứng.

Dưới đây là các ví dụ về cảnh 3D từ các góc nhìn khác nhau:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

Thuộc tính ObserverPoint cho phép xoay cảnh 3D theo các góc độ chỉ định quanh trục. Ví dụ này hiển thị mã và kết quả xuất sử dụng một số góc quay tùy ý.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Xuất với xoay](/_assets/guide/3d/fig3.png)

Thay đổi ObserverAngle thành ObserverPoint = new ObserverPoint(5, 60, 0) cho phép xoay cảnh.

![Xuất với xoay đã thay đổi](/_assets/guide/3d/fig4.png)

Thuộc tính RenderMode3D khác cho phép chỉ định cách kết quả xuất nên được trình bày. Có 3 chế độ: Rắn (mặc định), Mô phỏng khung dây, và Rắn với các cạnh.

Ví dụ dưới đây cho phép tạo mô hình khung dây cho đối tượng hình cầu.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Chế độ khung dây](/_assets/guide/3d/fig5.png)

Ví dụ dưới đây cho thấy sự khác biệt giữa chế độ Rắn và Rắn với các cạnh.

![Chế độ rắn](/_assets/guide/3d/fig6.png)
![Chế độ rắn với cạnh](/_assets/guide/3d/fig7.png)
