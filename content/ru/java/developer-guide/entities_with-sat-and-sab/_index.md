---
title: Сущности с структурой SAT/SAB
type: docs
weight: 40
url: /ru/java/developer-guide/entities_with-sat-and-sab/
---

## **Сущности с структурой SAT/SAB**

Некоторые сущности хранят свои структурные данные в формате ACIS SAT/SAB. Эти сущности могут быть частично экспортированы в режиме 2D каркасной модели. Поддерживаемые сущности включают:

*	Объекты 3DSOLID: коробка, сфера, пирамида, клин, конус, цилиндр, торус, полисолит
*	ПОВЕРХНОСТЬ: плоская, экструзия, вращение, выемка
*	РЕГИОН

Ниже приведен пример результата экспорта (файл DWG слева, результат PDF справа).

![Экспорт конуса и сфер](/cad/_assets/guide/coneAndSpheres.png)

Экспортирование сущностей ACIS не требует никаких специальных параметров. Для оптимизации размера чертежа, особенно если чертеж состоит исключительно из сущностей ACIS, рассмотрите возможность использования функции cadImage.updateSize() для точной настройки начальных размеров чертежа.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
