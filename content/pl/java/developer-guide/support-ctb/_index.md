---
title: Wsparcie plików CTB
type: docs
weight: 40
url: /pl/java/developer-guide/support-ctb/
---

## **Wsparcie plików CTB**

Czasami kolory, grubości linii i niektóre inne opcje dla rysunków mogą być używane nie tylko z rysunków samych w sobie, ale także z stylów wydruku w osobnych plikach CTB.
Najprostszym sposobem na wykorzystanie tych informacji jest umieszczenie odpowiednich plików CTB obok pliku z rysunkiem w formacie DWG/DXF, a informacje z nich będą stosowane
automatycznie podczas eksportu.

Możliwe jest również załadowanie wszystkich plików CTB w formie strumienia za pomocą 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) właściwości 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

Oto przykład, jak to zrobić:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
