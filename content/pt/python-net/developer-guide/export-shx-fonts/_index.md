---
title: Exportando fontes SHX
type: docs
weight: 40
url: /pt/python-net/developer-guide/export-shx-fonts/
---

## **Exportar fontes SHX para desenhos DXF/DWG**

Alguns desenhos podem conter fontes em formato especial SHX, que armazena símbolos da fonte na forma de formas. Este formato requer um procedimento de carregamento adicional para cada fonte usada no desenho. Apose.CAD pode exportar desenhos com texto escrito em SHX e possui diferentes opções para isso. A maneira mais simples de fazer isso é apenas usar a 
propriedade **ShxFonts** do 
objeto **CadRasterizationOptions**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
