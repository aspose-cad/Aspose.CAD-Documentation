---
title: تشخیص خودکار کد صفحه
type: docs
weight: 10
url: /fa/java/auto-codepage-detection/
---

## **تشخیص خودکار کد صفحه**

Aspose.CAD از تشخیص خودکار کد صفحه برای [DWG](https://docs.fileformat.com/cad/dwg/) و [DWF](https://docs.fileformat.com/cad/dwf/) پشتیبانی می‌کند. اگر نمی‌خواهید از این ویژگی استفاده کنید، می‌توانید با تنظیم خصوصیات زیر از کلاس [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) این را نادیده بگیرید.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): تنظیم کدگذاری که برای خواندن داده‌های متنی از فرمت‌های غیر یونیکد DXF و DWG استفاده می‌شود. به‌طور پیش‌فرض به‌طور خودکار تشخیص داده می‌شود.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): تنظیم کدگذاری که برای خواندن نمادهای کدگذاری شده MIF از کدگذاری‌های CJK (فرمت M+nXXXX) استفاده می‌شود. به‌طور پیش‌فرض به‌طور خودکار تشخیص داده می‌شود.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): تعریف می‌کند که آیا کاراکترهای کدگذاری شده CIF (U+XXXX) و MIF در صورتی که دارای فرمت‌بندی مناسب AutoCAD نباشند (AutoCAD این نمادها را با یک بک‌اسلش پیشوند می‌دهد) رمزگشایی می‌شوند یا خیر. به‌طور پیش‌فرض، آن‌ها رمزگشایی می‌شوند.

## کد نمونه

کد نمونه زیر نشان می‌دهد که چگونه می‌توان تشخیص خودکار کد صفحه را در Aspose.CAD نادیده گرفت.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
