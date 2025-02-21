---
title: DWG DXF para PDF C# | Converter Arquivos Auto CAD para PDF JPEG PNG em C# .NET
type: docs
weight: 30
url: /pt/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG para PDF C#, DXF para PDF C#, DWF DWT para PDF C#, converter AutoCAD, converter DWG, converter DWF, converter DWT, converter DXF, converter autocad para pdf, converter DWG para PDF, converter DWG para PNG, converter DWG para TIFF, converter DWG para JPG"
description: Use o conversor AutoCAD para PDF em C# .NET para converter DWG ou DXF para PDF em C#. Você pode converter DWG, DWF, DWT e DXF para PDF, JPEG, PNG, BMP, GIF e TIFF em C# .NET também.
---

## **Converter DWG ou DXF para PNG JPEG BMP GIF ou TIFF em C#**

Aspose.CAD para .NET pode converter formatos de desenho AutoCAD como [DXF](https://docs.fileformat.com/cad/dxf/) e [DWG](https://docs.fileformat.com/cad/dwg/) para [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) e [GIF](https://docs.fileformat.com/image/gif/). Ele expôs uma API eficiente e fácil de usar para alcançar esse objetivo.

Você pode converter qualquer formato de desenho AutoCAD suportado para formatos de imagem raster usando as etapas simples elaboradas abaixo.

1. Carregue o arquivo AutoCAD DWG ou DXF na classe [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Crie uma instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Defina/mude o tamanho da imagem usando [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Crie uma instância de [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. Defina a propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) para as opções [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) criadas na etapa anterior.
1. Salve o desenho AutoCAD como PDF com [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) passando o caminho do arquivo (ou um objeto de MemoryStream) bem como a instância de [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) criada na etapa anterior.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Por padrão, a API renderiza apenas o layout "Modelo". No entanto, você também pode especificar os layouts de sua escolha ao converter desenhos CAD para formatos de imagem.

## **Personalizando a Conversão CAD**

Os procedimentos de conversão CAD para [PDF](https://docs.fileformat.com/pdf/) e CAD para imagem raster são altamente configuráveis porque a classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) foi implementada de tal forma que fornece muitos recursos opcionais que, ao serem configurados, podem sobrescrever o processo de renderização de acordo com as necessidades da aplicação.

### **Classe CadRasterizationOptions**

A classe **CadRasterizationOptions** é comum para todos os formatos CAD suportados, como DWG e DXF, portanto, as informações compartilhadas neste artigo são válidas para ambos os formatos CAD mencionados.

As propriedades mais úteis da classe **CadRasterizationOptions** são:

|**Propriedade**|**Valor Padrão**|**Requerido**|**Descrição**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Sim|Especifica a largura da página.|
|**PageHeight**|**0**|Sim|Especifica a altura da página.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Não|Especifica se o desenho deve ser dimensionado automaticamente. O valor padrão reduz automaticamente a imagem para caber no tamanho da tela. Mude para o modo **GrowToFit**, ou use a configuração **None** para desabilitar o dimensionamento automático.|
|**BackgroundColor**|**Color.White**|Não|Especifica a cor de fundo da imagem de saída.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Não|Especifica o modo de coloração da entidade. Especifique a opção **UseObjectColor** para desenhar entidades usando sua cor nativa, ou a opção **UseDrawColor** para sobrescrever cores nativas.|
|**DrawColor**|**Color.Black**|Não|Especifica a cor da entidade sobrescrita (somente se **DrawType** estiver definido para o valor da propriedade **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Falso|Não|Especifica se o dimensionamento automático do layout deve ser realizado para corresponder ao layout Modelo.|

### **Definindo o Tamanho e o Modo da Tela**

Exportar de CAD para PDF ou formatos de imagem raster não é uma tarefa trivial. Como o PDF ou imagem resultante requer que o tamanho da tela seja definido, precisamos especificar as dimensões de saída para que a página PDF renderize o desenho corretamente. Defina explicitamente as propriedades **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**, ou você poderá receber uma **ImageSaveException**.

Além disso, você pode especificar opções de escala de dimensão. As opções de escalonamento são definidas pela propriedade **CadRasterizationOptions.ScaleMethod**. Use esta opção para ajustar automaticamente as dimensões da imagem de acordo com os valores **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**. Por padrão, **CadRasterizationOptions.ScaleMethod** é definido como o modo **ScaleType.ShrinkToFit**. Esta propriedade define o seguinte comportamento:

- Se as dimensões do desenho CAD forem maiores do que o tamanho da tela resultante, então as dimensões do desenho são reduzidas para caber na tela resultante, preservando a proporção da imagem.
- Se as dimensões do desenho CAD forem menores do que o tamanho da tela resultante, defina a propriedade **CadRasterizationOptions.ScaleMethod** como **ScaleType.GrowToFit** para aumentar o tamanho do desenho para caber na tela do PDF, preservando a proporção da imagem.
- Ou desative o dimensionamento automático com a opção **ScaleType.None**.

O exemplo de código abaixo mostra a opção de auto-dimensionamento em uso.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Definindo as Cores de Fundo e Desenho**

Por padrão, a paleta de cores para a tela resultante está definida para o esquema de documento comum. Isso significa que todas as entidades dentro do desenho CAD são desenhadas com uma caneta preta sobre um fundo branco sólido. Essas configurações podem ser alteradas com as propriedades **CadRasterizationOptions.BackgroundColor** e **CadRasterizationOptions.DrawColor**. Alterar a propriedade **CadRasterizationOptions.DrawColor** também requer definir a propriedade **CadRasterizationOptions.DrawType** para utilizar a cor de desenho. A propriedade **CadRasterizationOptions.DrawType** controla se as entidades CAD preservam suas cores ou são convertidas em cores personalizadas. Para preservar as cores das entidades, especifique **CadRasterizationOptions.DrawType** como **CadDrawTypeMode.UseObjectColor**, caso contrário, especifique o valor **CadDrawTypeMode.UseDrawColor**.

O exemplo de código abaixo mostra como usar diferentes propriedades de cor.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Definindo o Dimensionamento Automático do Layout**

A maioria dos desenhos CAD possui mais de um layout armazenado em um único arquivo, e cada layout pode ter dimensões diferentes. Ao renderizar tais desenhos CAD para PDF, cada página do PDF pode ter dimensionamentos diferentes de acordo com o tamanho do layout. Para tornar a renderização homogênea, as APIs Aspose.CAD expuseram a propriedade **CadRasterizationOptions.AutomaticLayoutsScaling**. Seu valor padrão é **falso**, mas quando verdadeiro, a API tentará buscar uma escala correspondente para cada layout separado e desenhá-los de maneira correspondente ao realizar a operação de redimensionamento automático de acordo com o tamanho da página.

Aqui está como a propriedade **CadRasterizationOptions.AutomaticLayoutsScaling** funciona em colaboração com a propriedade **CadRasterizationOptions.ScaleMethod**.

1. Se **ScaleMethod** estiver definido como **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** com **AutomaticLayoutsScaling** definido como falso, então todos os layouts (incluindo o Modelo) serão processados de acordo com a primeira opção.
1. Se **ScaleMethod** estiver definido como **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** com **AutomaticLayoutsScaling** definido como verdadeiro, então todos os layouts (exceto Modelo) serão processados de acordo com suas dimensões, enquanto o Modelo será processado de acordo com a primeira opção.
1. Se **ScaleMethod** estiver definido como **ScaleType.None** com **AutomaticLayoutsScaling** definido como verdadeiro ou falso, então nenhum dimensionamento será realizado.

O exemplo de código abaixo mostra como definir o dimensionamento automático para a conversão CAD para PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Converter Layouts DXF ou DWG AutoCAD para PNG ou Outros Formatos de Imagem em C#**

A API Aspose.CAD para .NET pode converter layouts CAD de formatos suportados, como DXF e DWG, para PNG, BMP, TIFF, JPEG e GIF. A API também fornece suporte para renderizar os layouts específicos de um desenho CAD em diferentes camadas PSD.

Aqui está como você pode conseguir o mesmo nas seguintes etapas simples.

- Carregue o arquivo AutoCAD DWG ou DXF usando a classe **Image**.
- Defina/mude a largura e a altura da imagem.
- Defina o(s) nome(s) de layout desejado(s) usando a propriedade CadRasterizationOptions.Layouts.
- Crie uma instância de **ImageOptionsBase** e defina sua propriedade **VectorRasterizationOptions** para a instância de **CadRasterizationOptions** criada na etapa anterior.
- Salve o layout CAD como TIFF ou imagem.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

A propriedade **CadRasterizationOptions.Layouts** é do tipo array de string, então você pode especificar mais de um layout ao mesmo tempo para possível conversão para formatos de imagem. Ao especificar múltiplos layouts para a propriedade **CadRasterizationOptions.Layouts**, a imagem TIFF resultante teria várias páginas, a imagem GIF teria múltiplos quadros e o formato [PSD](https://docs.fileformat.com/image/psd/) teria múltiplas camadas, onde cada página/quadro/camada representa um layout AutoCAD individual. Caso qualquer outro formato de imagem, como PNG, BMP, JPEG seja selecionado para armazenar o resultado, então a API renderizará apenas o layout padrão; ou seja, "Modelo".

{{% /alert %}}

## **Habilitando o Rastreamento do Processo de Renderização CAD**

Aspose.CAD introduziu uma série de classes e campos de enumeração de suporte para ajudar com o rastreamento do processo de renderização CAD. Com essas mudanças em vigor, a conversão de CAD para PDF pode agora ser realizada da seguinte forma enquanto habilita o rastreamento.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

O rastreamento do processo de renderização CAD pode detectar os seguintes problemas possíveis.

1. Informações de cabeçalho ausentes ou corrompidas.
1. Informações de layout ausentes.
1. Entidades de bloco ausentes.
1. Estilos de dimensão ausentes.
1. Estilos ausentes.

## **Substituindo Fontes ao Converter Desenhos CAD**

É muito possível que um desenho CAD particular utilize uma fonte específica que não esteja disponível na máquina onde a conversão de CAD para PDF ou CAD para imagem raster está ocorrendo. Em tais situações, a API Aspose.CAD acionará uma exceção apropriada para destacar as fontes ausentes e interromper o processo de conversão porque a API requer essas fontes para renderizar corretamente o conteúdo no PDF ou imagens resultantes.

A API Aspose.CAD oferece uma maneira fácil de usar o mecanismo para substituir as fontes necessárias com as fontes disponíveis. A propriedade **CadImage.Styles** retorna uma instância de **CadStylesDictionary** que, por sua vez, contém o **CadStyleTableObject** para cada estilo no desenho CAD, enquanto o **CadStyleTableObject.PrimaryFontName** pode ser usado para especificar o nome da fonte disponível.

O trecho de código a seguir demonstra o uso da API Aspose.CAD para .NET para alterar a fonte de todos os estilos em um desenho CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Também é possível alterar a fonte de apenas um estilo particular acessando-o pelo nome do estilo. O trecho de código a seguir demonstra o uso dessa abordagem.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Convertendo Camadas CAD para Formatos de Imagem Raster**

A API Aspose.CAD para .NET expôs um meio eficiente e fácil de usar para especificar o nome da camada CAD necessária e renderizá-la em formatos de imagem raster. Aqui está como você pode alcançar o mesmo em 5 etapas simples listadas abaixo.

1. Carregue o arquivo CAD em uma instância de **Image** usando o método de fábrica **Load**.
1. Crie uma instância de **CadRasterizationOptions** e defina suas propriedades obrigatórias, como **PageWidth** e **PageHeight**.
1. Adicione o nome da camada desejada usando o método **CadRasterizationOptions.Layers.Add**.
1. Crie uma instância de **ImageOptionsBase** e defina sua propriedade **VectorRasterizationOptions** para a instância de **CadRasterizationOptions** criada na etapa anterior.
1. Chame o método **Image.Save** passando o caminho do arquivo (ou um objeto de MemoryStream) assim como a instância de **ImageOptionsBase** criada na etapa anterior.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Convertendo Todas as Camadas CAD para Imagens Separadas**

Você pode obter todas as camadas de um desenho CAD usando a propriedade **CadImage.Layers** e renderizar cada camada em uma imagem separada, como demonstrado abaixo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Convertendo Camadas CAD DWF para Formatos de Imagem Raster**

A API Aspose.CAD para .NET expôs um meio eficiente e fácil de usar para especificar o nome da camada CAD necessária e renderizá-la em formatos de imagem raster. Aqui está como você pode alcançar o mesmo em 5 etapas simples listadas abaixo.

1. Carregue o arquivo CAD DWF em uma instância de **Image** usando o método de fábrica **Load**.
1. Crie uma instância de **CadRasterizationOptions** e defina suas propriedades obrigatórias, como **PageWidth** e **PageHeight**.
1. Adicione o nome da camada desejada usando o método **CadRasterizationOptions.Layers.Add**.
1. Crie uma instância de **ImageOptionsBase** e defina sua propriedade **VectorRasterizationOptions** para a instância de **CadRasterizationOptions** criada na etapa anterior.
1. Chame o método **Image.Save** passando o caminho do arquivo (ou um objeto de MemoryStream) assim como a instância de **ImageOptionsBase** criada na etapa anterior.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

A API Aspose.CAD para .NET escreve diretamente as informações sobre a API e o número da versão nos documentos de saída. Por exemplo, ao renderizar um Documento como PDF, a API Aspose.CAD para .NET preenche o campo Aplicativo com o valor 'Aspose.CAD' e o campo Produtor PDF com um valor, por exemplo 'Aspose.CAD v 17.10'.

Por favor, note que você não pode instruir a API Aspose.CAD para .NET a alterar ou remover estas informações dos Documentos de saída.
