---
title: Автообнаружение кодовой страницы
type: docs
weight: 10
url: /ru/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Автообнаружение кодовой страницы**

Aspose.CAD поддерживает автоматическое обнаружение кодовой страницы для [DWG](https://docs.fileformat.com/cad/dwg/) и [DWF](https://docs.fileformat.com/cad/dwf/) файлов. Если вы не хотите использовать эту функцию, вы можете переопределить это, установив следующие свойства класса [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): устанавливает кодировку, используемую для чтения текстовых данных из форматов DXF и DWG, не поддерживающих Unicode. По умолчанию она определяется автоматически.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): устанавливает кодировку, используемую для чтения символов, закодированных в MIF в кодировках CJK (формат M+nXXXX). По умолчанию она определяется автоматически.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): определяет, будут ли декодированы символы, закодированные в CIF (U+XXXX) и MIF, если у них нет правильного форматирования AutoCAD (AutoCAD предшествует этим символам обратной косой чертой). По умолчанию они декодируются.

## Пример кода

Пример кода ниже показывает, как переопределить автоматическое обнаружение кодовой страницы в Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
