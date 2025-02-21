---
title: Експорт малюнків та макетів DWG/DXF у вказаному розмірі
type: docs
weight: 40
url: /uk/net/developer-guide/export-into-size/
---

## **Експорт моделі та всіх макетів у розмір A4 PDF**

API Aspose.CAD дозволяє експортувати всі аркуші файлу DWG/DXF у вказаному фізичному розмірі PDF.

Наведеним нижче прикладом коду задається розмір об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) для досягнення бажаного розміру PDF.
Розмір аркуша паперу A4 складає 210x297 міліметрів або 8.27x11.69 дюйми, і ці значення використовуються в коді.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Експорт макетів CAD у PDF в різному розмірі**

Іноді потрібно експортувати макет у його фізичному розмірі. Наведений нижче приклад демонструє експорт малюнка у багатосторінковий PDF, де кожна сторінка з контентом макета має свій власний фізичний розмір PDF. Цей приклад використовує [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/)
властивість.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
