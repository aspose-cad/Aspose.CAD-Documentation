---
title: Práce s formátem souboru OBJ
type: docs
weight: 120
url: /cs/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD nyní podporuje formát souboru OBJ. Formát souboru OBJ je 3D geometrie obsahující texturové mapy, 3D souřadnice, polygonální stěny a další informace o objektu.

{{% /alert %}}

## **Export OBJ Formátu Do PNG**

Aspose.CAD pro JavaScript v Angularu umožňuje vývojářům exportovat soubor [OBJ](https://docs.fileformat.com/3d/obj/) do formátu [PNG](https://docs.fileformat.com/image/png/).
Přístup k převodu z [OBJ](https://docs.fileformat.com/3d/obj/) do [PNG](https://docs.fileformat.com/image/png/) funguje následovně:

1. Načtěte výkresový soubor [OBJ](https://docs.fileformat.com/3d/obj/) pomocí metody **Image.load**.
1. Zavolejte **Image.save** a předejte objekt **PngOptions** jako druhý parametr.

## Ukázkový Kód

Kód níže ukazuje, jak dosáhnout stejného cíle pomocí Aspose.CAD pro JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
