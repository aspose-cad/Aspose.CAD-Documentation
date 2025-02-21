---
title: Експорт креслень і макетів DWG/DXF у вказаному розмірі
type: docs
weight: 40
url: /uk/java/developer-guide/export-into-size/
---

## **Експорт моделі та всіх макетів у формат PDF розміром A4**

API Aspose.CAD дозволяє експортувати всі листи файлу DWG/DXF у вказаному фізичному розмірі PDF. 
Наступний приклад коду налаштовує розмір об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) для досягнення бажаного розміру PDF. 
Розмір листа A4 становить 210x297 міліметрів або 8.27x11.69 дюймів, і ці значення використовуються в коді.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Експорт макетів CAD у PDF в різному розмірі**

Іноді необхідно експортувати макет у його фізичному розмірі. Нижче наведено приклад експорту креслення у багатосторінковий PDF, де кожна сторінка з вмістом макета має свій фізичний розмір PDF. Цей приклад використовує властивість [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
