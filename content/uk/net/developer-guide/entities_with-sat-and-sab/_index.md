---
title: Сутності з структурою SAT/SAB
type: docs
weight: 40
url: /uk/net/developer-guide/entities_with-sat-and-sab/
---

## **Сутності з структурою SAT/SAB**

Певні сутності зберігають свої структурні дані у форматі ACIS SAT/SAB. Ці сутності можуть частково експортуватися в режимі 2D каркасної моделі. Підтримувані сутності включають:

*	об'єкти 3DSOLID: коробка, сфера, піраміда, клин, конус, циліндр, тор, полісолід
*	ПОВЕРХНЯ: площинна, витягнута, обернена, профільна
*	РЕГІОН

Нижче наведено приклад результату експорту (файл DWG зліва, результат PDF справа).

![Експорт конуса та сфер](/cad/_assets/guide/coneAndSpheres.png)

Експортування сутностей ACIS не вимагає жодних спеціальних опцій. Щоб оптимізувати розмір креслення, особливо коли креслення містить виключно сутності ACIS, розгляньте можливість використання функції cadImage.UpdateSize() для точного коригування початкових розмірів креслення.

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
