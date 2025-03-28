---
title: لایسنس متری
type: docs
weight: 40
url: /fa/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD به توسعه‌دهندگان اجازه می‌دهد تا کلید متری را اعمال کنند. این یک مکانیزم لایسنس جدید است. مکانیزم لایسنس جدید با روش لایسنس موجود استفاده خواهد شد. مشتریانی که می‌خواهند بر اساس استفاده از قابلیت‌های API صورتحساب شوند، می‌توانند از لایسنس متری استفاده کنند. برای جزئیات بیشتر، لطفاً به بخش [سوالات متداول لایسنس متری](https://purchase.aspose.com/faqs/licensing/metered) مراجعه کنید.

{{% /alert %}} 
## **لایسنس متری**
این مراحل ساده برای استفاده از کلاس Metered است.

1. یک نمونه از کلاس Metered ایجاد کنید.
1. کلیدهای عمومی و خصوصی را به متد SetMeteredKey منتقل کنید.
1. پردازش را انجام دهید (وظیفه را انجام دهید).
1. متد GetConsumptionQuantity کلاس Metered را فراخوانی کنید.
1. این مقدار/تعداد درخواست‌های API را که تاکنون مصرف کرده‌اید، باز می‌گرداند.

در زیر نمونه کدی وجود دارد که نحوه تنظیم کلید عمومی و خصوصی متری را نشان می‌دهد.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
