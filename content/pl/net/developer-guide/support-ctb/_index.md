---
title: Wsparcie dla plików CTB
type: docs
weight: 40
url: /pl/net/developer-guide/support-ctb/
---

## **Wsparcie dla plików CTB**

Czasami kolory, grubości linii i inne opcje dla rysunków mogą być używane nie tylko z rysunków samych w sobie, ale także z stylów wydruku w oddzielnych plikach CTB. 
Najprostszym sposobem na wykorzystanie tych informacji jest umieszczenie odpowiednich plików CTB obok pliku z rysunkiem w formacie DWG/DXF, a informacje z nich zostaną zastosowane
automatycznie podczas eksportu.

Możliwe jest również załadowanie wszystkich plików CTB w formie strumienia, korzystając z 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) właściwości obiektu 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).

Oto przykład, jak to zrobić:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
