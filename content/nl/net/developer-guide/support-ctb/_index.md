---
title: Ondersteuning van CTB-bestanden
type: docs
weight: 40
url: /nl/net/developer-guide/support-ctb/
---

## **Ondersteuning van CTB-bestanden**

Soms kunnen kleur, lijndiktes en andere opties voor tekeningen niet alleen vanuit de tekeningen zelf, maar ook vanuit plotstijlen in afzonderlijke CTB-bestanden worden gebruikt. 
De eenvoudigste manier om deze informatie te gebruiken, is door de bijbehorende CTB-bestanden naast het bestand met de tekening in DWG/DXF-formaat te plaatsen, en de informatie daaruit zal automatisch 
worden toegepast tijdens de export.

Het is ook mogelijk om alle CTB-bestanden in de vorm van een Stream te laden met behulp van 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) eigenschap van 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) object.

Hier is een voorbeeld van hoe dit te doen:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
