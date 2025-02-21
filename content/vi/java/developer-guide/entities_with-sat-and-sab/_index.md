---
title: Các thực thể có cấu trúc SAT/SAB
type: docs
weight: 40
url: /vi/java/developer-guide/entities_with-sat-and-sab/
---

## **Các thực thể có cấu trúc SAT/SAB**

Một số thực thể lưu trữ dữ liệu cấu trúc của chúng ở định dạng ACIS SAT/SAB. Những thực thể này có thể được xuất một phần trong chế độ wireframe 2D. Các thực thể được hỗ trợ bao gồm:

* Các đối tượng 3DSOLID: hình hộp, hình cầu, kim tự tháp, hình chóp, hình nón, hình trụ, hình xoắn ốc, polysolid
* BỀ MẶT: phẳng, kéo dài, xoay, quét
* KHU VỰC

Dưới đây là ví dụ về kết quả xuất (tệp DWG bên trái, kết quả PDF bên phải).

![Xuất hình nón và hình cầu](/_assets/guide/coneAndSpheres.png)

Việc xuất các thực thể ACIS không yêu cầu bất kỳ tùy chọn đặc biệt nào. Để tối ưu hóa kích thước bản vẽ, đặc biệt khi bản vẽ chỉ chứa các thực thể ACIS, hãy xem xét việc sử dụng hàm cadImage.updateSize() để điều chỉnh chính xác kích thước bản vẽ ban đầu.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
