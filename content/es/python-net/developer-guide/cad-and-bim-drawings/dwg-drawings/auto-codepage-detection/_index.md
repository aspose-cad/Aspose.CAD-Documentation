---
title: Detección Automática de Código de Página
type: docs
weight: 10
url: /es/python-net/auto-codepage-detection/
---

## **Detección Automática de Código de Página**

Aspose.CAD soporta la detección automática de código de página para archivos [DWG](https://docs.fileformat.com/cad/dwg/) y [DWF](https://docs.fileformat.com/cad/dwf/). Si no desea utilizar esta función, puede anularla configurando las siguientes propiedades de la clase **LoadOptions**.

- **specified_encoding**: establece la codificación utilizada para leer datos de texto de formatos DXF y DWG que no son Unicode. Se autodetecta por defecto.
- **specified_mif_encoding**: establece la codificación utilizada para leer símbolos codificados en MIF de codificaciones CJK (formato M+nXXXX). Se autodetecta por defecto.
- **recover_malformed_cif_mif**: define si los caracteres CIF (U+XXXX) y MIF codificados serán decodificados si no tienen un formato adecuado de AutoCAD (AutoCAD precede a estos símbolos con una barra invertida). Por defecto, son decodificados.

## Código de Ejemplo

El siguiente ejemplo de código muestra cómo anular la detección automática de código de página en Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
