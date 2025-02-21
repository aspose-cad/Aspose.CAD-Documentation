---
title: Entidades com estrutura SAT/SAB
type: docs
weight: 40
url: /pt/net/developer-guide/entities_with-sat-and-sab/
---

## **Entidades com estrutura SAT/SAB**

Certas entidades armazenam seus dados estruturais no formato ACIS SAT/SAB. Essas entidades podem ser exportadas parcialmente em modo de wireframe 2D. As entidades suportadas incluem:

*	Objetos 3DSOLID: caixa, esfera, pirâmide, cunha, cone, cilindro, toro, polissólido
*	SUPERFÍCIE: planar, extrudada, revolvida, varrida
*	REGIÃO

Abaixo está o exemplo do resultado da exportação (arquivo DWG na parte esquerda, resultado em PDF na parte direita).

![Exportação de cone e esferas](/_assets/guide/coneAndSpheres.png)

Exportar entidades ACIS não requer opções especiais. Para otimizar o tamanho do desenho, especialmente quando o desenho contém exclusivamente entidades ACIS, considere usar a função cadImage.UpdateSize() para ajustar as dimensões iniciais do desenho com precisão.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
