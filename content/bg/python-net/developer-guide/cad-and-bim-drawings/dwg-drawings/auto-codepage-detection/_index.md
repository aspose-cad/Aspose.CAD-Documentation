---
title: Автоматично разпознаване на кодова страница
type: docs
weight: 10
url: /bg/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Автоматично разпознаване на кодова страница**

Aspose.CAD поддържа автоматично разпознаване на кодова страница за [DWG](https://docs.fileformat.com/cad/dwg/) и [DWF](https://docs.fileformat.com/cad/dwf/) файлове. Ако не желаете да използвате тази функция, можете да я замените, като зададете следните свойства на класа **LoadOptions**.

- **specified_encoding**: задава кодирането, използвано за четене на текстови данни от форматите DXF и DWG, които не са Unicode. По подразбиране се извършва автоматично разпознаване.
- **specified_mif_encoding**: задава кодирането, използвано за четене на символи, кодирани в MIF, на CJK кодирания (формат M+nXXXX). По подразбиране се извършва автоматично разпознаване.
- **recover_malformed_cif_mif**: определя дали да се декодират символи, кодирани в CIF (U+XXXX) и MIF, ако те нямат правилно форматиране за AutoCAD (AutoCAD предва посочените символи с обратна наклонена черта). По подразбиране те се декодират.

## Примерен код

Примерният код по-долу показва как да замените автоматичното разпознаване на кодова страница в Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
