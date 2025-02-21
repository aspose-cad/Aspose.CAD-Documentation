---
title: Exportando fontes SHX
type: docs
weight: 40
url: /pt/java/developer-guide/export-shx-fonts/
---

## **Exportar fontes SHX para desenhos DXF/DWG**

Alguns desenhos podem conter fontes no formato especial SHX, que armazena símbolos da fonte na forma de formas.
Esse formato requer um procedimento de carregamento adicional para cada fonte usada no desenho.
Apose.CAD pode exportar desenhos com texto escrito em SHX e possui diferentes opções para fazer isso.
A maneira mais simples de fazer isso é usar a propriedade [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) do objeto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Cada fonte SHX vem com a página de código apropriada associada a ela. Essas associações são conhecidas e parcialmente incorporadas no Aspose.CAD para fontes SHX conhecidas.
No caso de alguma fonte SHX personalizada ser usada, é possível aplicar a propriedade **setShxCodePages** e configurar o caminho para o arquivo SHX e a página de código correspondente.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
