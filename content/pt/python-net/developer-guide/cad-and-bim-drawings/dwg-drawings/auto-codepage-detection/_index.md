---
title: Detecção Automática de Codepage
type: docs
weight: 10
url: /pt/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Detecção Automática de Codepage**

Aspose.CAD suporta detecção automática de codepage para arquivos [DWG](https://docs.fileformat.com/cad/dwg/) e [DWF](https://docs.fileformat.com/cad/dwf/). Se você não desejar usar este recurso, pode substituí-lo definindo as seguintes propriedades da classe **LoadOptions**.

- **specified_encoding**: define a codificação usada para ler dados de texto dos formatos DXF e DWG não-Unicode. É detectado automaticamente por padrão.
- **specified_mif_encoding**: define a codificação usada para ler símbolos codificados em MIF de codificações CJK (formato M+nXXXX). É detectado automaticamente por padrão.
- **recover_malformed_cif_mif**: define se caracteres CIF (U+XXXX) e MIF codificados serão decodificados se não tiverem a formatação adequada do AutoCAD (o AutoCAD precede esses símbolos com uma barra invertida). Por padrão, eles são decodificados.

## Código de Exemplo

O exemplo de código abaixo mostra como substituir a detecção automática de codepage no Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
