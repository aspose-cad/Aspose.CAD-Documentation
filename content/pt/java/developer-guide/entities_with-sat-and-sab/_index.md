---
title: Entidades com estrutura SAT/SAB
type: docs
weight: 40
url: /pt/java/developer-guide/entities_with-sat-and-sab/
---

## **Entidades com estrutura SAT/SAB**

Certas entidades armazenam seus dados estruturais no formato ACIS SAT/SAB. Essas entidades podem ser exportadas parcialmente no modo de wireframe 2D. As entidades suportadas incluem:

* objetos 3DSOLID: caixa, esfera, pirâmide, cunha, cone, cilindro, toro, polysolid
* SUPERFÍCIE: planar, extrudada, revolvida, varrida
* REGIÃO

Abaixo está o exemplo do resultado da exportação (arquivo DWG na parte esquerda, resultado PDF na parte direita).

![Exportação de cone e esferas](/_assets/guide/coneAndSpheres.png)

Exportar entidades ACIS não requer opções especiais. Para otimizar o tamanho do desenho, especialmente quando o desenho contém exclusivamente entidades ACIS, considere usar a função cadImage.updateSize() para ajustar as dimensões iniciais do desenho com precisão.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
