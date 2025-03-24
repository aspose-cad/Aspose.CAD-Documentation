---
title: Сутності з структурою SAT/SAB
type: docs
weight: 40
url: /uk/java/developer-guide/entities_with-sat-and-sab/
---

## **Сутності з структурою SAT/SAB**

Деякі сутності зберігають свої структурні дані у форматі ACIS SAT/SAB. Ці сутності можна частково експортувати в режимі 2D каркасної моделі. Підтримувані сутності включають:

* об'єкти 3DSOLID: коробка, сфера, піраміда, клин, конус, циліндр, тор, полісолід
* SURFACE: плоска, витягнута, обернена, пройдена
* REGION

Нижче наведено приклад результату експорту (файл DWG зліва, результат PDF справа).

![Експорт конуса та сфер](/cad/_assets/guide/coneAndSpheres.png)

Експорт сутностей ACIS не вимагає жодних особливих параметрів. Для оптимізації розміру креслення, особливо коли креслення містить виключно сутності ACIS, розгляньте можливість використання функції cadImage.updateSize() для точного коригування початкових розмірів креслення.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
