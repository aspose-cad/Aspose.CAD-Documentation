---
title: شناسایی خودکار کدگذاری
type: docs
weight: 10
url: /fa/python-net/auto-codepage-detection/
---

## **شناسایی خودکار کدگذاری**

Aspose.CAD از شناسایی خودکار کدگذاری برای [DWG](https://docs.fileformat.com/cad/dwg/) و [DWF](https://docs.fileformat.com/cad/dwf/) پشتیبانی می‌کند. اگر نمی‌خواهید از این ویژگی استفاده کنید، می‌توانید با تنظیم خواص زیر در کلاس **LoadOptions** این ویژگی را نادیده بگیرید.

- **specified_encoding**: کدگذاری استفاده شده برای خواندن داده‌های متنی از فرمت‌های DXF و DWG غیر یونی‌کد را تنظیم می‌کند. به طور پیش‌فرض، به صورت خودکار شناسایی می‌شود.
- **specified_mif_encoding**: کدگذاری استفاده شده برای خواندن نمادهای MIF-encoded از کدگذاری‌های CJK (قالب M+nXXXX) را تنظیم می‌کند. به طور پیش‌فرض، به صورت خودکار شناسایی می‌شود.
- **recover_malformed_cif_mif**: تعریف می‌کند که آیا کاراکترهای CIF (U+XXXX) و MIF-encoded باید رمزگشایی شوند یا نه، اگر آنها فرمت صحیح AutoCAD را نداشته باشند (AutoCAD این نمادها را با یک بک‌اسلش پیش از آن قرار می‌دهد). به طور پیش‌فرض، آنها رمزگشایی می‌شوند.

## کد نمونه

کد نمونه زیر نشان می‌دهد که چگونه می‌توان شناسایی خودکار کدگذاری را در Aspose.CAD نادیده گرفت.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
