---
title: Авто Определение Кодировки
type: docs
weight: 10
url: /ru/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Авто Определение Кодировки**

Aspose.CAD поддерживает автоматическое определение кодировки для [DWG](https://docs.fileformat.com/cad/dwg/) и [DWF](https://docs.fileformat.com/cad/dwf/) файлов. Если вы не хотите использовать эту функцию, вы можете переопределить это, установив следующие свойства класса [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): устанавливает кодировку, используемую для чтения текстовых данных из форматов DXF и DWG, не поддерживающих Unicode. По умолчанию она определяется автоматически.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): устанавливает кодировку, используемую для чтения символов, закодированных в MIF, в CJK-кодировках (формат M+nXXXX). По умолчанию она определяется автоматически.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): определяет, будут ли декодированы символы с кодировкой CIF (U+XXXX) и MIF, если они не имеют правильного форматирования AutoCAD (AutoCAD предшествует этим символам обратной косой чертой). По умолчанию они декодируются.

## Пример Кода

Пример кода ниже демонстрирует, как переопределить автоматическое определение кодировки в Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
