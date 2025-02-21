---
title: Автоматика виявлення кодової сторінки
type: docs
weight: 10
url: /uk/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Автоматика виявлення кодової сторінки**

Aspose.CAD підтримує автоматичне виявлення кодової сторінки для [DWG](https://docs.fileformat.com/cad/dwg/) та [DWF](https://docs.fileformat.com/cad/dwf/) файлів. Якщо ви не бажаєте використовувати цю функцію, ви можете скасувати це, налаштувавши наступні властивості класу [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): встановлює кодування, що використовується для читання текстових даних з не-Unicode DXF та DWG форматів. За замовчуванням воно виявляється автоматично.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): встановлює кодування, що використовується для читання MIF-кодованих символів кодувань CJK (формат M+nXXXX). За замовчуванням воно виявляється автоматично.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): визначає, чи будуть декодовані символи CIF (U+XXXX) і MIF-кодовані символи, якщо вони не мають належного форматування AutoCAD (AutoCAD попереджає ці символи зворотною скісною рискою). За замовчуванням вони декодуються.

## Приклади коду

Приклад коду нижче показує, як скасувати автоматичне виявлення кодової сторінки в Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
