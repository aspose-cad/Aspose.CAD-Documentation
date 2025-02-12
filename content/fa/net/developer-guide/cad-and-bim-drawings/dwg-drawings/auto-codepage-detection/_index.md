---
title: شناسایی خودکار صفحه کد
type: docs
weight: 10
url: /fa/net/auto-codepage-detection/
---

## **شناسایی خودکار صفحه کد**

Aspose.CAD از شناسایی خودکار صفحه کد برای [DWG](https://docs.fileformat.com/cad/dwg/) و [DWF](https://docs.fileformat.com/cad/dwf/) پشتیبانی می‌کند. اگر نمی‌خواهید از این ویژگی استفاده کنید، می‌توانید با تنظیم خواص زیر از کلاس [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) این کار را نادیده بگیرید.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): کدگذاری استفاده شده برای خواندن داده‌های متنی از فرمت‌های DXF و DWG غیر Unicode را تنظیم می‌کند. به طور پیش‌فرض خودکار شناسایی می‌شود.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): کدگذاری استفاده شده برای خواندن نمادهای کدگذاری شده MIF از کدگذاری‌های CJK (فرمت M+nXXXX) را تنظیم می‌کند. به طور پیش‌فرض خودکار شناسایی می‌شود.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): تعیین می‌کند که آیا کاراکترهای CIF (U+XXXX) و کدگذاری شده MIF در صورت عدم داشتن فرمت مناسب AutoCAD (AutoCAD این نمادها را با یک بک‌اسلش پیش از خود می‌آورد) رمزگشایی خواهند شد یا خیر. به طور پیش‌فرض، آن‌ها رمزگشایی می‌شوند.

## نمونه کد

نمونه کد زیر نشان می‌دهد که چگونه می‌توان شناسایی خودکار صفحه کد را در Aspose.CAD نادیده گرفت.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
