---
title: Авто детекция кодовой страницы
type: docs
weight: 10
url: /ru/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Авто детекция кодовой страницы**

Aspose.CAD поддерживает автоматическую детекцию кодовой страницы для [DWG](https://docs.fileformat.com/cad/dwg/) и [DWF](https://docs.fileformat.com/cad/dwf/) файлов. Если вы не хотите использовать эту функцию, вы можете переопределить ее, установив следующие свойства класса **LoadOptions**.

- **specified_encoding**: устанавливает кодировку, используемую для чтения текстовых данных из не-Unicode форматов DXF и DWG. По умолчанию она определяется автоматически.
- **specified_mif_encoding**: устанавливает кодировку, используемую для чтения символов, закодированных в MIF для кодировок CJK (формат M+nXXXX). По умолчанию она определяется автоматически.
- **recover_malformed_cif_mif**: определяет, будут ли декодированы символы CIF (U+XXXX) и MIF, если они не имеют правильного форматирования AutoCAD (AutoCAD предшествует этим символам обратной косой чертой). По умолчанию они декодируются.

## Пример кода

Пример кода ниже показывает, как переопределить автоматическую детекцию кодовой страницы в Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
