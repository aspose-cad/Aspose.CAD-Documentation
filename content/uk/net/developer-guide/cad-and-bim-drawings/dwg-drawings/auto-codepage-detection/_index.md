---
title: Автоматичне виявлення кодування
type: docs
weight: 10
url: /uk/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Автоматичне виявлення кодування**

Aspose.CAD підтримує автоматичне виявлення кодування для [DWG](https://docs.fileformat.com/cad/dwg/) та [DWF](https://docs.fileformat.com/cad/dwf/) файлів. Якщо ви не бажаєте використовувати цю функцію, ви можете перевизначити це, встановивши наступні властивості класу [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): встановлює кодування, яке використовується для читання текстових даних з не-Unicode форматів DXF та DWG. За замовчуванням виявляється автоматично.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): встановлює кодування, яке використовується для читання MIF-кодованих символів CJK кодувань (формат M+nXXXX). За замовчуванням виявляється автоматично.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): визначає, чи будуть декодовані символи CIF (U+XXXX) та MIF-кодування, якщо вони не мають належного форматування AutoCAD (AutoCAD передує цим символам зворотною косою рискою). За замовчуванням вони декодуються.

## Приклад коду

Наведених нижче кодовий приклад показує, як перевизначити автоматичне виявлення кодування в Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
