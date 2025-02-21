---
title: Automatyczne wykrywanie kodowania
type: docs
weight: 10
url: /pl/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatyczne wykrywanie kodowania**

Aspose.CAD wspiera automatyczne wykrywanie kodowania dla [DWG](https://docs.fileformat.com/cad/dwg/) i [DWF](https://docs.fileformat.com/cad/dwf/) plików. Jeśli nie chcesz korzystać z tej funkcji, możesz to nadpisać, ustawiając następujące właściwości klasy [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): ustawia kodowanie używane do odczytu danych tekstowych z formatów DXF i DWG, które nie są w formacie Unicode. Jest automatycznie wykrywane domyślnie.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): ustawia kodowanie używane do odczytu symboli zakodowanych w MIF z kodowań CJK (format M+nXXXX). Jest automatycznie wykrywane domyślnie.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): definiuje, czy znaki kodowane w CIF (U+XXXX) i MIF zostaną zdekodowane, jeśli nie mają odpowiedniego formatowania AutoCAD (AutoCAD poprzedza te symbole znakiem backslash). Domyślnie są dekodowane.

## Przykładowy kod

Poniższy przykład kodu pokazuje, jak nadpisać automatyczne wykrywanie kodowania w Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
