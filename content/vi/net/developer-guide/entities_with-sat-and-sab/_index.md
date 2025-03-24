---
title: Thực thể với cấu trúc SAT/SAB
type: docs
weight: 40
url: /vi/net/developer-guide/entities_with-sat-and-sab/
---

## **Thực thể với cấu trúc SAT/SAB**

Một số thực thể lưu trữ dữ liệu cấu trúc của chúng theo định dạng ACIS SAT/SAB. Những thực thể này có thể được xuất một phần ở chế độ wireframe 2D. Các thực thể được hỗ trợ bao gồm:

*	Đối tượng 3DSOLID: hộp, hình cầu, kim tự tháp, nêm, hình chóp, hình trụ, hình donut, polysolid
*	BỀ MẶT: phẳng, kéo dài, quay, quét
*	KHU VỰC

Dưới đây là ví dụ về kết quả xuất (tệp DWG ở bên trái, kết quả PDF ở bên phải).

![Xuất hình chóp và hình cầu](/cad/_assets/guide/coneAndSpheres.png)

Việc xuất các thực thể ACIS không yêu cầu bất kỳ tùy chọn đặc biệt nào. Để tối ưu hóa kích thước bản vẽ, đặc biệt khi bản vẽ chỉ chứa các thực thể ACIS, hãy xem xét việc sử dụng chức năng cadImage.UpdateSize() để điều chỉnh chính xác kích thước bản vẽ ban đầu.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
