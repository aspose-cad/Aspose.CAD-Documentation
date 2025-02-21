---
title: Ustaw czas oczekiwania na zapis
type: docs
weight: 70
url: /pl/net/developer-guide/set-timeout-on-save/
---

## **Ustaw czas oczekiwania na zapis**

Aspose.CAD dla interfejsu API .NET pozwala ustawić czas oczekiwania na zapis. Może to być przydatne w przypadkach, gdy proces zapisu trwa długo lub zużywa dużo pamięci. W tym celu API udostępnia klasę  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource). Klasa [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) dostarcza token, który jest używany do przerywania długotrwałych operacji.

## Przykładowy kod

Poniższy fragment kodu demonstruje użycie klasy [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
