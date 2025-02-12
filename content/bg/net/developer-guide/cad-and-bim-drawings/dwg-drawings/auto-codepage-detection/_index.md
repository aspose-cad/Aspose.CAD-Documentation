---
title: Автоматично откриване на кодираща страница
type: docs
weight: 10
url: /bg/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Автоматично откриване на кодираща страница**

Aspose.CAD поддържа автоматично откриване на кодиращата страница за [DWG](https://docs.fileformat.com/cad/dwg/) и [DWF](https://docs.fileformat.com/cad/dwf/) файлове. Ако не желаете да използвате тази функционалност, можете да я преопределите, като зададете следните свойства на класа [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): задава кодирането, използвано за четене на текстовите данни от нев Unicode DXF и DWG формати. По подразбиране се автоматично открива.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): задава кодирането, използвано за четене на MIF-кодирани символи на CJK кодировки (M+nXXXX формат). По подразбиране се автоматично открива.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): задава дали символите, кодирани в CIF (U+XXXX) и MIF, ще бъдат декодирани, ако нямат правилно форматиране на AutoCAD (AutoCAD предшества тези символи с обратна наклонена черта). По подразбиране те се декодират.

## Примерен код

Примерният код по-долу показва как да преопределите автоматичното откриване на кодираща страница в Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
