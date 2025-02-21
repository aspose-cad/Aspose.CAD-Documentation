---
title: Exportando fontes SHX
type: docs
weight: 40
url: /pt/net/developer-guide/export-shx-fonts/
---

## **Exportar fontes SHX para desenhos DXF/DWG**

Alguns desenhos podem conter fontes em formato especial SHX, que armazena símbolos da fonte na forma de formas. Este formato requer um procedimento de carregamento adicional para cada fonte utilizada no desenho. Apose.CAD pode exportar desenhos com texto escrito em SHX e possui diferentes opções para fazer isso. A maneira mais simples de fazê-lo é usar a propriedade 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) do objeto 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Exemplo ShxFonts.cs">}}


É possível evitar a configuração de todos os caminhos para várias fontes SHX com o seguinte exemplo:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Exemplo ShxFonts com pasta.cs">}}
	
Cada fonte SHX vem com a página de código apropriada associada a ela. Essas associações são conhecidas e parcialmente incorporadas no Aspose.CAD para fontes SHX conhecidas. 
No caso de uma fonte SHX personalizada ser usada, é possível aplicar a propriedade ShxCodePages e configurar o caminho para o arquivo SHX e a página de código correspondente. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Exemplo ShxCodePages.cs">}}
