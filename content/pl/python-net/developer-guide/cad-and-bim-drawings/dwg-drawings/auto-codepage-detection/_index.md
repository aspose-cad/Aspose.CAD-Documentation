---
title: Automatyczne Wykrywanie Strony Kodowej
type: docs
weight: 10
url: /pl/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatyczne Wykrywanie Strony Kodowej**

Aspose.CAD wspiera automatyczne wykrywanie strony kodowej dla plików [DWG](https://docs.fileformat.com/cad/dwg/) i [DWF](https://docs.fileformat.com/cad/dwf/). Jeśli nie chcesz korzystać z tej funkcji, możesz to nadpisać, ustawiając następujące właściwości klasy **LoadOptions**.

- **specified_encoding**: ustawia kodowanie używane do odczytu danych tekstowych z nie-Unicode formatów DXF i DWG. Domyślnie jest automatycznie wykrywane.
- **specified_mif_encoding**: ustawia kodowanie używane do odczytu symboli zakodowanych w MIF dla kodowań CJK (format M+nXXXX). Domyślnie jest automatycznie wykrywane.
- **recover_malformed_cif_mif**: definiuje, czy znaki CIF (U+XXXX) i zakodowane w MIF będą dekodowane, jeśli nie mają odpowiedniego formatowania AutoCAD (AutoCAD poprzedza te symbole backslashem). Domyślnie są dekodowane.

## Przykładowy Kod

Poniższy przykład kodu pokazuje, jak nadpisać automatyczne wykrywanie strony kodowej w Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
