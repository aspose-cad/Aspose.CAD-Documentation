---
title: Set timeout on save
type: docs
weight: 70
url: /fa/net/developer-guide/set-timeout-on-save/
---

## **تنظیم زمان توقف در ذخیره‌سازی**

Aspose.CAD برای API .NET به شما این امکان را می‌دهد که زمانی برای توقف هنگام ذخیره‌سازی تنظیم کنید. این ممکن است در مواردی که فرآیند ذخیره‌سازی زمان زیادی می‌برد یا مصرف بالای حافظه دارد، مفید باشد. برای این منظور، API کلاس  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) را فراهم می‌کند. کلاس [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) یک توکن را ارائه می‌دهد که برای قطع عملیات‌های طولانی استفاده می‌شود.

## کد نمونه

کد نمونه زیر نحوه استفاده از کلاس [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
