---
title: Сущности с структурой SAT/SAB
type: docs
weight: 40
url: /ru/net/developer-guide/entities_with-sat-and-sab/
---

## **Сущности с структурой SAT/SAB**

Некоторые сущности хранят свои структурные данные в формате ACIS SAT/SAB. Эти сущности могут быть частично экспортированы в режиме 2D каркаса. Поддерживаемые сущности включают:

*	3DSOLID объекты: короб, сфера, пирамида, клин, конус, цилиндр, тор, полисолит
*	ПОВЕРХНОСТЬ: плоская, экструзия, вращение, обтекаемая
*	РЕГИОН

Ниже приведен пример результата экспорта (файл DWG слева, результат PDF справа).

![Экспорт конуса и сфер](/cad/_assets/guide/coneAndSpheres.png)

Экспортировать сущности ACIS не требует каких-либо специальных опций. Чтобы оптимизировать размер чертежа, особенно когда чертеж содержит только сущности ACIS, рассмотрите возможность использования функции cadImage.UpdateSize() для точной настройки начальных размеров чертежа.

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
