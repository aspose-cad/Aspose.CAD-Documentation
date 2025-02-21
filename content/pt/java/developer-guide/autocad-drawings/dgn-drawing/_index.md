---
title: Desenho DGN
type: docs
weight: 10
url: /pt/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Desenhando o Formato DGN Como Parte do DWG**

Aspose.CAD para Java permite que desenvolvedores exportem um arquivo DWG com sobreposição DGN incorporada. A seguir está o código que demonstra como acessar a sobreposição DGN dentro de um arquivo DWG ao exportar o arquivo DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Suporte a entidades 3D para DGN v7**

A API Aspose.CAD para Java introduziu a funcionalidade para carregar um arquivo DGN do AutoCAD e suportar entidades 3D para DGN v7. A classe [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) serve a esse propósito. Cada imagem DGN suporta 9 visualizações predefinidas. Elas são enumeradas de 1 a 9. Se a visualização não estiver definida na exportação, para formatos de saída de várias páginas (como PDF) todas as visualizações serão exportadas, cada uma em uma página separada. Entidades 3D são suportadas no formato de arquivo DGN, assim como 2D. 
VectorRasterizationOptions.TypeOfEntities não é mais utilizado para o formato DGN (tanto 2D quanto 3D são suportados simultaneamente).

Código de exemplo para visualizar os elementos DGN suportados.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
