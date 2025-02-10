---
title: Същности със структури SAT/SAB
type: docs
weight: 40
url: /bg/net/support-sat-sab/
---

## **Същности със структури SAT/SAB**

Някои същности съхраняват структурните си данни в формата ACIS SAT/SAB. Тези същности могат да бъдат частично експортирани в 2D wireframe режим. Поддържаните същности включват:

* 3DSOLID обекти: кутия, сфера, пирамида, клин, конус, цилиндър, тор, полисолид
* ПОВРЪХНОСТ: плоска, екструдирана, завъртяна, изтеглена
* РЕГИОН

По-долу е пример за резултат от експорта (DWG файл отляво, PDF резултат отдясно).

![Експорт на конус и сфери](/_assets/coneAndSpheres.png)

Експортирането на ACIS същности не изисква специални опции. За оптимизиране на размера на чертежа, особено когато чертежът съдържа изключително ACIS същности, помислете за използването на функцията cadImage.UpdateSize() за точно настройване на началните размери на чертежа.

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
