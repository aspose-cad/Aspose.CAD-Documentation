---
title: Automatyczne Wykrywanie Strony Kodowej
type: docs
weight: 10
url: /pl/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatyczne Wykrywanie Strony Kodowej**

Aspose.CAD wspiera automatyczne wykrywanie strony kodowej dla [DWG](https://docs.fileformat.com/cad/dwg/) i [DWF](https://docs.fileformat.com/cad/dwf/) plików. Jeśli nie chcesz korzystać z tej funkcji, możesz ją zastąpić, ustawiając następujące właściwości klasy [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): ustawia kodowanie używane do odczytu danych tekstowych z formatów DXF i DWG, które nie są w formacie Unicode. Domyślnie jest automatycznie wykrywane.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): ustawia kodowanie używane do odczytu symboli zakodowanych w MIF dla kodowań CJK (format M+nXXXX). Domyślnie jest automatycznie wykrywane.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): określa, czy znaki zakodowane w CIF (U+XXXX) i MIF będą dekodowane, jeśli nie mają odpowiedniego formatowania AutoCAD (AutoCAD poprzedza te symbole znakiem backslash). Domyślnie są dekodowane.

## Przykładowy Kod

Poniższy przykład kodu pokazuje, jak zastąpić automatyczne wykrywanie strony kodowej w Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
