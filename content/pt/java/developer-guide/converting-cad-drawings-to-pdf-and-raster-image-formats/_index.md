---
title: Convertendo Desenhos CAD para Formatos de Imagem PDF e Raster
type: docs
weight: 30
url: /pt/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java escreve diretamente as informações sobre a API e o número da versão nos documentos de saída. Por exemplo, ao renderizar o Documento em PDF, o Aspose.CAD for Java preenche o campo Aplicativo com o valor 'Aspose.CAD' e o campo Produtor PDF com um valor, por exemplo 'Aspose.CAD v 17.9'.

Por favor, note que você não pode instruir o Aspose.CAD for Java a alterar ou remover essas informações dos Documentos de saída.

{{% /alert %}} 
## **Convertendo Desenhos CAD para Formatos de Imagem Raster**
Aspose.CAD for Java é capaz de converter formatos de desenho CAD como [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) para os formatos de imagem raster suportados, como [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). A API Aspose.CAD for Java disponibilizou meios eficientes e fáceis de usar para alcançar esse objetivo.
Você pode converter qualquer formato de desenho CAD suportado para formatos de imagem raster usando os passos simples elaborados abaixo.

1. Carregue o arquivo CAD em uma instância de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crie uma instância de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e defina suas propriedades obrigatórias, como [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Crie uma instância de **ImageOptionsBase** e defina sua propriedade [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) para a instância de **CadRasterizationOptions** criada na etapa anterior.
1. Chame **Image.save** passando o caminho do arquivo (ou um objeto de MemoryStream) assim como a instância de [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) criada na etapa anterior.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Por padrão, a API renderiza apenas o layout "Modelo". No entanto, você também pode especificar os layouts de sua escolha ao converter desenhos CAD para formatos de imagem.
## **Personalizando a Conversão CAD**
Os procedimentos de conversão de CAD para [PDF](https://docs.fileformat.com/pdf/) e CAD para imagem raster são altamente configuráveis porque a classe [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) foi implementada de forma que oferece muitos recursos opcionais que, ao serem configurados, podem substituir o processo de renderização de acordo com as necessidades da aplicação.
### **Classe CadRasterizationOptions**
A classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) é comum para todos os formatos CAD suportados, como [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), portanto, as informações compartilhadas neste artigo são válidas para ambos os formatos CAD mencionados.

As propriedades mais úteis da classe **CadRasterizationOptions** são:

|**Propriedade**|**Valor Padrão**|**Obrigatório**|**Descrição**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Sim|Especifica a largura da página.|
|**PageHeight**|**0**|Sim|Especifica a altura da página.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Não|Especifica se o desenho deve ser automaticamente escalonado. O valor padrão reduz automaticamente a imagem para caber no tamanho da tela. Mude para o modo **GrowToFit**, ou use a configuração **None** para desativar a escala automática.|
|**BackgroundColor**|**Color.White**|Não|Especifica a cor de fundo da imagem de saída.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Não|Especifica o modo de coloração da entidade. Especifique a opção **UseObjectColor** para desenhar entidades usando sua cor nativa, ou a opção **UseDrawColor** para substituir as cores nativas.|
|**DrawColor**|**Color.Black**|Não|Especifica a cor da entidade substituída (apenas se **DrawType** estiver definido para o valor da propriedade **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Falso|Não|Especifica se a escala de layout automática deve ser realizada para corresponder ao layout do Modelo.|
### **Definindo o Tamanho e Modo da Tela**
A exportação de CAD para PDF ou para formatos de imagem raster não é uma tarefa trivial. Como o PDF ou a imagem resultante requer o tamanho da tela a ser definido, precisamos especificar as dimensões de saída para a página PDF para renderizar o desenho corretamente. Defina explicitamente as propriedades **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**, ou você pode receber uma **ImageSaveException**.

Além disso, você pode especificar opções de escala de dimensão. As opções de escala são definidas pela propriedade **CadRasterizationOptions.ScaleMethod**. Use esta opção para ajustar automaticamente as dimensões da imagem de acordo com os valores de **CadRasterizationOptions.PageWidth** e **CadRasterizationOptions.PageHeight**. Por padrão, **CadRasterizationOptions.ScaleMethod** é definido para o modo **ScaleType.ShrinkToFit**. Esta propriedade define o seguinte comportamento:

- Se as dimensões do desenho CAD forem maiores que o tamanho da tela resultante, então as dimensões do desenho são reduzidas para caber na tela resultante, preservando a proporção.
- Se as dimensões do desenho CAD forem menores que o tamanho da tela resultante, defina a propriedade **CadRasterizationOptions.ScaleMethod** para **ScaleType.GrowToFit** para aumentar o tamanho do desenho para caber na tela PDF, preservando a proporção.
- Ou desative a escala automática com a opção **ScaleType.None**.

O exemplo de código abaixo mostra a opção de escala automática em uso.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Definindo as Cores de Fundo e Desenho**
Por padrão, a paleta de cores para a tela resultante é definida pelo esquema comum do documento. Isso significa que todas as entidades dentro do desenho CAD são desenhadas com uma caneta de cor preta sobre um fundo branco sólido. Essas configurações podem ser mudadas com as propriedades **CadRasterizationOptions.BackgroundColor** e **CadRasterizationOptions.DrawColor**. Alterar a propriedade **CadRasterizationOptions.DrawColor** também requer definir a propriedade **CadRasterizationOptions.DrawType** para utilizar a cor do desenho a ser usada. A propriedade **CadRasterizationOptions.DrawType** controla se as entidades CAD preservam suas cores ou são convertidas para cores personalizadas. Para preservar as cores das entidades, especifique **CadRasterizationOptions.DrawType** como **CadDrawTypeMode.UseObjectColor**, caso contrário, especifique o valor **CadDrawTypeMode.UseDrawColor**.

O exemplo de código abaixo mostra como usar diferentes propriedades de cor.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Definindo a Escala Automática de Layout**
A maioria dos desenhos CAD possui mais de um layout armazenado em um único arquivo, e cada layout pode ter dimensões diferentes. Ao renderizar tais desenhos CAD em PDF, cada página do PDF pode ter escalas diferentes de acordo com o tamanho do layout. Para tornar a renderização homogênea, as APIs Aspose.CAD expuseram a propriedade **CadRasterizationOptions.AutomaticLayoutsScaling**. Seu valor padrão é **falso**, mas quando verdadeiro, a API tentará buscar uma escala correspondente para cada layout separado e desenhá-los de maneira correspondente realizando a operação de redimensionamento automático de acordo com o tamanho da página.

Aqui está como a propriedade **CadRasterizationOptions.AutomaticLayoutsScaling** funciona em colaboração com a propriedade **CadRasterizationOptions.ScaleMethod**.

1. Se **ScaleMethod** estiver definido para **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** com **AutomaticLayoutsScaling** definido como falso, então todos os layouts (incluído o Modelo) serão processados de acordo com a primeira opção.
1. Se **ScaleMethod** estiver definido para **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** com **AutomaticLayoutsScaling** definido como verdadeiro, então todos os layouts (exceto Modelo) serão processados de acordo com seu tamanho, enquanto o Modelo será processado de acordo com a primeira opção.
1. Se **ScaleMethod** estiver definido para **ScaleType.None** com **AutomaticLayoutsScaling** definido como verdadeiro ou falso, então nenhuma escala será realizada.

O exemplo de código abaixo mostra como definir a escala automática para conversão de CAD para PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Convertendo Layouts CAD para Formatos de Imagem Raster**
A API Aspose.CAD for Java é capaz de converter layouts CAD de formatos suportados como DXF e DWG para os formatos de imagem raster como PNG, BMP, TIFF, JPEG e GIF. A API também fornece suporte para renderizar os layouts específicos de um desenho CAD em diferentes camadas PSD. 
A API Aspose.CAD for Java disponibilizou meios eficientes e fáceis de usar para especificar a lista de layouts CAD necessários e renderizá-los para formatos de imagem raster. Aqui está como você pode alcançar o mesmo em 5 passos simples, como listado abaixo.

1. Carregue o arquivo CAD em uma instância de **Image** usando o método de fábrica **load**.
1. Crie uma instância de **CadRasterizationOptions** e defina suas propriedades obrigatórias, como **PageWidth** e **PageHeight**.
1. Especifique o(s) nome(s) de layout desejado(s) usando a propriedade CadRasterizationOptions.Layouts.
1. Crie uma instância de **ImageOptionsBase** e defina sua propriedade **VectorRasterizationOptions** para a instância de **CadRasterizationOptions** criada na etapa anterior.
1. Chame **Image.Save** passando o caminho do arquivo (ou um objeto de MemoryStream) assim como a instância de **ImageOptionsBase** criada na etapa anterior.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

A propriedade **CadRasterizationOptions.Layouts** é do tipo array de string, portanto, você pode especificar mais de um layout de cada vez para possível conversão para formatos de imagem. Ao especificar múltiplos layouts para a propriedade **CadRasterizationOptions.Layouts**, a imagem TIFF resultante terá várias páginas, a imagem GIF terá múltiplos quadros e o formato PSD terá várias camadas, onde cada página/quadro/camada representa um layout AutoCAD individual. Caso qualquer outro formato de imagem, como PNG, BMP, JPEG seja selecionado para armazenar o resultado, então a API renderizará apenas o layout padrão; isto é "Modelo".

{{% /alert %}} 
## **Habilitando o Acompanhamento do Processo de Renderização CAD**
Aspose.CAD introduziu uma série de classes e campos de enumeração de suporte para auxiliar no acompanhamento do processo de renderização CAD. Com essas mudanças, a conversão de CAD para PDF agora pode ser realizada da seguinte forma, enquanto habilita o acompanhamento.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



O acompanhamento do processo de renderização CAD pode detectar os seguintes problemas possíveis.

1. Informações de cabeçalho ausentes ou corrompidas.
1. Informações de layout ausentes.
1. Entidades de bloco ausentes.
1. Estilos de dimensão ausentes.
1. Estilos ausentes.
## **Substituindo Fontes ao Converter Desenhos CAD**
É bem possível que um determinado desenho CAD use alguma fonte específica que não esteja disponível na máquina onde a conversão de CAD para PDF ou CAD para imagem raster está acontecendo. Em tais situações, a API Aspose.CAD irá disparar uma exceção apropriada para destacar as fontes ausentes e interromper o processo de conversão porque a API requer essas fontes para renderizar corretamente os conteúdos no PDF e/ou imagens resultantes.
A API Aspose.CAD oferece uma maneira fácil de usar o mecanismo para substituir as fontes necessárias pelas fontes disponíveis. A propriedade **CadImage.Styles** retorna uma instância de **CadStylesDictionary** que, por sua vez, contém o **CadStyleTableObject** para cada estilo no desenho CAD, enquanto o **CadStyleTableObject.PrimaryFontName** pode ser usado para especificar o nome da fonte disponível.

O seguinte snippet de código demonstra o uso da API Aspose.CAD for Java para alterar a fonte de todos os estilos em um desenho CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




É também possível mudar a fonte de apenas um estilo particular acessando-o pelo nome do estilo. O seguinte snippet de código demonstra o uso dessa abordagem.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Convertendo Camadas CAD para Formatos de Imagem Raster**
A API Aspose.CAD for Java expôs um meio eficiente e fácil de usar para especificar o nome da camada CAD necessária e renderizá-la para formatos de imagem raster. Aqui está como você pode alcançar o mesmo em 5 passos simples, como listado abaixo.

1. Carregue o arquivo CAD em uma instância de **Image** usando o método de fábrica **load**.
1. Crie uma instância de **CadRasterizationOptions** e defina suas propriedades obrigatórias, como **PageWidth** e **PageHeight**.
1. Adicione o nome da camada desejada usando o método **CadRasterizationOptions.Layers.add**.
1. Crie uma instância de **ImageOptionsBase** e defina sua propriedade **VectorRasterizationOptions** para a instância de **CadRasterizationOptions** criada na etapa anterior.
1. Chame o método **Image.save** passando o caminho do arquivo (ou um objeto de MemoryStream) assim como a instância de **ImageOptionsBase** criada na etapa anterior.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Convertendo Todas as Camadas CAD em Imagens Separadas**
Você pode obter todas as camadas de um desenho CAD usando **CadImage.Layers** e renderizar cada camada em uma imagem separada, como demonstrado abaixo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Convertendo Camadas CAD DWF para Formatos de Imagem Raster**
A API Aspose.CAD for Java expôs um meio eficiente e fácil de usar para especificar o nome da camada CAD necessária e renderizá-la para formatos de imagem raster. Aqui está como você pode alcançar o mesmo em 5 passos simples, como listado abaixo.

1. Carregue o arquivo CAD DWF em uma instância de **Image** usando o método de fábrica **Load**.
1. Crie uma instância de **CadRasterizationOptions** e defina suas propriedades obrigatórias, como **PageWidth** e **PageHeight**.
1. Adicione o nome da camada desejada usando o método **CadRasterizationOptions.Layers.Add**.
1. Crie uma instância de **ImageOptionsBase** e defina sua propriedade **VectorRasterizationOptions** para a instância de **CadRasterizationOptions** criada na etapa anterior.
1. Chame o método **Image.Save** passando o caminho do arquivo (ou um objeto de MemoryStream) assim como a instância de **ImageOptionsBase** criada na etapa anterior.

Aqui está o código fonte completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
