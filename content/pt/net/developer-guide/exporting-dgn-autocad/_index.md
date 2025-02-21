---
title: Exportando o formato DGN AutoCAD
type: docs
weight: 50
url: /pt/net/developer-guide/exporting-dgn-autocad/
---

## **Exportando o formato DGN AutoCAD para PDF**

O Aspose.CAD para a API .NET introduziu a funcionalidade de carregar um arquivo DGN AutoCAD e convertê-lo para o formato PDF. A classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) serve para esse propósito.

Você precisa carregar um arquivo DGN existente como [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina diferentes propriedades. Crie uma instância da classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e passe a instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Agora chame o método [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) da instância da classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Código de Exemplo

A seguir está a demonstração de código para converter/exportar [DGN](https://docs.fileformat.com/cad/dgn/) para o formato [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Exportando o formato DGN AutoCAD para formato de imagem raster**

O Aspose.CAD para a API .NET introduziu a funcionalidade de carregar um arquivo DGN AutoCAD e convertê-lo em uma imagem raster. A classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) serve para esse propósito.

Você precisa carregar um arquivo DGN existente como [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Crie uma instância da classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e defina diferentes propriedades. Crie uma instância da classe [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) e passe a instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Agora chame o método [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) da instância da classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Código de Exemplo

A seguir está a demonstração de código para converter/exportar [DGN](https://docs.fileformat.com/cad/dgn/) para imagem [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Suporte a entidades 3D para DGN v7**

O Aspose.CAD para a API .NET introduziu a funcionalidade de carregar um arquivo [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD e suportar entidades 3D para DGN v7. A classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) serve para esse propósito. Cada imagem [DGN](https://docs.fileformat.com/cad/dgn/) suporta 9 visões predefinidas. Elas são enumeradas de 1 a 9. Se a visão não for definida na exportação, para formatos de saída de várias páginas (como PDF) todas as visões serão exportadas, cada uma em uma página separada. Entidades 3D são suportadas no formato DGN, assim como 2D. Para isso, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) é usado, TypeOfEntities não é mais utilizado para o formato DGN (tanto 2D quanto 3D suportados simultaneamente).

### Código de Exemplo

A seguir está o código de exemplo para verificar os elementos DGN suportados.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
