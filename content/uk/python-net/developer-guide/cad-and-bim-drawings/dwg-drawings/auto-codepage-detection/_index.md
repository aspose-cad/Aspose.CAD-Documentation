---
title: Автоматичне виявлення кодових сторінок
type: docs
weight: 10
url: /uk/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Автоматичне виявлення кодових сторінок**

Aspose.CAD підтримує автоматичне виявлення кодових сторінок для [DWG](https://docs.fileformat.com/cad/dwg/) та [DWF](https://docs.fileformat.com/cad/dwf/) файлів. Якщо ви не бажаєте використовувати цю функцію, ви можете перевизначити це, встановивши наступні властивості класу **LoadOptions**.

- **specified_encoding**: встановлює кодування, яке використовується для читання текстових даних з не-Unicode DXF та DWG форматів. За замовчуванням воно автоматично визначається.
- **specified_mif_encoding**: встановлює кодування, яке використовується для читання символів, закодованих MIF, у кодуваннях CJK (формат M+nXXXX). За замовчуванням воно автоматично визначається.
- **recover_malformed_cif_mif**: визначає, чи будуть декодовані символи CIF (U+XXXX) та закодовані MIF, якщо вони не мають належного форматування AutoCAD (AutoCAD передує цим символам зворотною косою рискою). За замовчуванням вони декодуються.

## Приклад коду

Нижче наведено приклад коду, який показує, як перевизначити автоматичне виявлення кодових сторінок в Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
