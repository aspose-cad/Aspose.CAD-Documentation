---
title: Detección Automática de Codepage
type: docs
weight: 10
url: /es/net/auto-codepage-detection/
---

## **Detección Automática de Codepage**

Aspose.CAD admite la detección automática de codepage para archivos [DWG](https://docs.fileformat.com/cad/dwg/) y [DWF](https://docs.fileformat.com/cad/dwf/). Si no desea utilizar esta función, puede anularla configurando las siguientes propiedades de la clase [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): estabelece la codificación utilizada para leer datos de texto de formatos DXF y DWG que no son Unicode. Se detecta automáticamente por defecto.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): establece la codificación utilizada para leer símbolos codificados en MIF de codificaciones CJK (formato M+nXXXX). Se detecta automáticamente por defecto.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): define si los caracteres CIF (U+XXXX) y MIF codificados serán decodificados si no tienen el formato adecuado de AutoCAD (AutoCAD precede estos símbolos con una barra invertida). Por defecto, se decodifican.

## Código de Ejemplo

El fragmento de código a continuación muestra cómo anular la detección automática de codepage en Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
