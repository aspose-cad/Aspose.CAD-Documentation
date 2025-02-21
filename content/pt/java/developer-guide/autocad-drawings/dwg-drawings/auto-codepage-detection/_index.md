---
title: Detecção Automática de Código
type: docs
weight: 10
url: /pt/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Detecção Automática de Código**

Aspose.CAD suporta a detecção automática de código para [DWG](https://docs.fileformat.com/cad/dwg/) e [DWF](https://docs.fileformat.com/cad/dwf/) arquivos. Se você não desejar usar esse recurso, pode substituí-lo definindo as seguintes propriedades da [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) classe.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): define a codificação usada para ler dados de texto de formatos DXF e DWG não-Unicode. É autodetectado por padrão.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): define a codificação usada para ler símbolos codificados em MIF de codificações CJK (formato M+nXXXX). É autodetectado por padrão.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): define se caracteres CIF (U+XXXX) e MIF codificados serão decodificados se não tiverem a formatação adequada do AutoCAD (o AutoCAD precede esses símbolos com uma barra invertida). Por padrão, eles são decodificados.

## Exemplo de Código

O exemplo de código abaixo mostra como substituir a detecção automática de código no Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
