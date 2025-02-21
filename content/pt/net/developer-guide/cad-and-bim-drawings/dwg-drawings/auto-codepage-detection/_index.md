---
title: Detecção Automática de Pagecode
type: docs
weight: 10
url: /pt/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Detecção Automática de Pagecode**

Aspose.CAD suporta a detecção automática de pagecode para arquivos [DWG](https://docs.fileformat.com/cad/dwg/) e [DWF](https://docs.fileformat.com/cad/dwf/). Se você não desejar usar esse recurso, pode desativá-lo definindo as seguintes propriedades da classe [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): define a codificação usada para ler dados de texto de formatos DXF e DWG não-Unicode. É autodetectado por padrão.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): define a codificação usada para ler símbolos codificados em MIF de codificações CJK (formato M+nXXXX). É autodetectado por padrão.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): define se caracteres CIF (U+XXXX) e MIF-encoded serão decodificados se não tiverem o formato apropriado do AutoCAD (o AutoCAD precede esses símbolos com uma barra invertida). Por padrão, eles são decodificados.

## Exemplo de Código

O exemplo de código abaixo mostra como desativar a detecção automática de pagecode no Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
