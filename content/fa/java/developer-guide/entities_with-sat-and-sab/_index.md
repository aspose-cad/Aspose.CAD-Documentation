---
title: موجودیت‌ها با ساختار SAT/SAB
type: docs
weight: 40
url: /fa/java/support-sat-sab/
---

## **موجودیت‌ها با ساختار SAT/SAB**

برخی موجودیت‌ها داده‌های ساختاری خود را در فرمت ACIS SAT/SAB ذخیره می‌کنند. این موجودیت‌ها می‌توانند به‌صورت جزئی در حالت سیم‌کشی 2D صادر شوند. موجودیت‌های پشتیبانی‌شده شامل:

* اشیاء 3DSOLID: جعبه، کره، هرم، لبه‌دار، مخروط، سیلندر، حلقه‌زن، چندسری
* سطح: صفحه‌ای، خارج شده، گردانده شده، جارو شده
* ناحیه

در زیر مثال نتیجه صادرات (فایل DWG در سمت چپ، نتیجه PDF در سمت راست) ارائه شده است.

![صادرات مخروط و کره‌ها](/fa/_assets/coneAndSpheres.png)

صادر کردن موجودیت‌های ACIS به هیچ گزینه خاصی نیاز ندارد. برای بهینه‌سازی اندازه رسم، به‌ویژه زمانی که رسم به‌طور انحصاری حاوی موجودیت‌های ACIS است، در نظر داشته باشید که از تابع cadImage.updateSize() برای تنظیم دقیق ابعاد اولیه رسم استفاده کنید.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
