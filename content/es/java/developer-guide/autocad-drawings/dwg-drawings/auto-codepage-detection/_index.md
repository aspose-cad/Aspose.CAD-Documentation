---
title: Detección Automática de Codepage
type: docs
weight: 10
url: /es/java/auto-codepage-detection/
---

## **Detección Automática de Codepage**

Aspose.CAD soporta la detección automática de codepage para archivos [DWG](https://docs.fileformat.com/cad/dwg/) y [DWF](https://docs.fileformat.com/cad/dwf/). Si no deseas usar esta función, puedes anularla configurando las siguientes propiedades de la [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) clase.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): establece la codificación utilizada para leer datos de texto de formatos DXF y DWG no Unicode. Se autodetecta por defecto.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): establece la codificación utilizada para leer símbolos codificados en MIF de las codificaciones CJK (formato M+nXXXX). Se autodetecta por defecto.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): define si los caracteres CIF (U+XXXX) y MIF codificados serán decodificados si no tienen el formato adecuado de AutoCAD (AutoCAD precede estos símbolos con una barra invertida). Por defecto, son decodificados.

## Código de Ejemplo

El siguiente ejemplo de código muestra cómo anular la detección automática de codepage en Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
