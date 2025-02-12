---
title: Автоматично разпознаване на кодна страница
type: docs
weight: 10
url: /bg/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Автоматично разпознаване на кодна страница**

Aspose.CAD поддържа автоматично разпознаване на кодна страница за [DWG](https://docs.fileformat.com/cad/dwg/) и [DWF](https://docs.fileformat.com/cad/dwf/) файлове. Ако не желаете да използвате тази функция, можете да я заместите, като зададете следните свойства на класа [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): задава кодирането, използвано за четене на текстови данни от формати DXF и DWG, различни от Юникод. По подразбиране то се определя автоматично.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): задава кодирането, използвано за четене на символи, кодирани във формат MIF на кодирания CJK (формат M+nXXXX). По подразбиране то се определя автоматично.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): определя дали символите, кодирани в CIF (U+XXXX) и MIF, ще бъдат декодирани, ако нямат правилно форматиране от AutoCAD (AutoCAD предшества тези символи с обратна наклонена черта). По подразбиране те се декодират.

## Примерен код

Подолу е показан примерен код, който показва как да заместите автоматичното разпознаване на кодна страница в Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
