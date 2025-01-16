---
title: Същности с структура SAT/SAB
type: docs
weight: 40
url: /bg/java/support-sat-sab/
---

## **Същности с структура SAT/SAB**

Определени същности съхраняват своите структурни данни в формата ACIS SAT/SAB. Тези същности могат да бъдат частично експортирани в 2D wireframe режим. Поддържаните същности включват:

*	3DSOLID обекти: кутия, сфера, пирамидa, клин, конус, цилиндър, торус, полисолид
*	PART: плоски, екструдирани, завъртяни, избутани
*	РЕГИОН

По-долу е пример за резултата от експорта (DWG файл в лявата част, PDF резултат в дясната).

![Експорт на конус и сфери](coneAndSpheres.png)

Експортирането на ACIS същности не изисква специални опции. За да оптимизирате размера на чертежа, особено когато чертежът съдържа изключително ACIS същности, обмислете използването на функцията cadImage.updateSize() за точно регулиране на началните размери на чертежа.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
