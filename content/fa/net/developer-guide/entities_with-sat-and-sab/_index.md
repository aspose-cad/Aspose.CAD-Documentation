---
title: موجودیت‌های با ساختار SAT/SAB
type: docs
weight: 40
url: /fa/net/support-sat-sab/
---

## **موجودیت‌های با ساختار SAT/SAB**

برخی موجودیت‌ها داده‌های ساختاری خود را در فرمت ACIS SAT/SAB ذخیره می‌کنند. این موجودیت‌ها می‌توانند به‌طور جزئی در حالت سیمی دوب بعدی صادر شوند. موجودیت‌های پشتیبانی‌شده شامل:

* اشیاء 3DSOLID: جعبه، کره، هرم، لبه، مخروط، سیلندر، حلقه، پلی‌سولید
* سطح: صفحه‌ای، برآمده، چرخشی، جاروی
* ناحیه

در زیر نمونه‌ای از نتیجه صادرات (فایل DWG در سمت چپ، نتیجه PDF در سمت راست) آمده است.

![صادرات مخروط و کره‌ها](/fa/_assets/coneAndSpheres.png)

صادرات موجودیت‌های ACIS نیاز به گزینه‌های خاصی ندارد. برای بهینه‌سازی اندازه ترسیم، به‌ویژه زمانی که ترسیم فقط شامل موجودیت‌های ACIS باشد، در نظر داشته باشید که از تابع cadImage.UpdateSize() برای تنظیم دقیق ابعاد ترسیم اولیه استفاده کنید.

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
