---
title: Exportando o formato DGN AutoCAD
type: docs
weight: 50
url: /pt/python-net/developer-guide/exporting-dgn-autocad/
---

## **Exportando o formato DGN AutoCAD para PDF**

Aspose.CAD para Python API introduziu a funcionalidade de carregar um arquivo DGN AutoCAD e convertê-lo para o formato PDF. A classe **CadImage** serve para esse propósito.

Você precisa carregar um arquivo DGN existente como **CadImage**. Crie uma instância da classe **CadRasterizationOptions** e defina diferentes propriedades. Crie uma instância da classe **PdfOptions** e passe a instância de **CadRasterizationOptions**. Agora chame o método **save** da instância da classe **CadImage**.

### Código de Exemplo

Segue a demonstração de código para converter/exportar [DGN](https://docs.fileformat.com/cad/dgn/) para [PDF](https://docs.fileformat.com/pdf/) formato.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Exportando o formato DGN AutoCAD para formato de imagem raster**

Aspose.CAD para Python API introduziu a funcionalidade de carregar um arquivo DGN AutoCAD e convertê-lo em uma imagem raster. A classe **CadImage** serve para esse propósito.

Você precisa carregar um arquivo DGN existente como **CadImage**. Crie uma instância da classe **CadRasterizationOptions** e defina diferentes propriedades. Crie uma instância da classe **JpegOptions** e passe a instância de **CadRasterizationOptions**. Agora chame o método **save** da instância da classe **CadImage**.

### Código de Exemplo

Segue a demonstração de código para converter/exportar [DGN](https://docs.fileformat.com/cad/dgn/) para imagem [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Suporte a entidades 3D para DGN v7**

Aspose.CAD para Python API introduziu a funcionalidade de carregar um arquivo [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD e suportar entidades 3D para DGN v7. A classe **CadImage** serve para esse propósito. Cada imagem [DGN](https://docs.fileformat.com/cad/dgn/) suporta 9 visões predefinidas. Elas são enumeradas de 1 a 9. Se a visão não for definida na exportação, para formatos de saída em várias páginas (como PDF) todas as visões serão exportadas, cada uma em uma página separada. Entidades 3D são suportadas no formato de arquivo DGN, assim como 2D. Para isso, **VectorRasterizationOptions** é usado, TypeOfEntities não é mais usado para o formato DGN (tanto 2D quanto 3D suportados simultaneamente).

### Código de Exemplo

O seguinte é o código de exemplo para observar os elementos DGN suportados.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
