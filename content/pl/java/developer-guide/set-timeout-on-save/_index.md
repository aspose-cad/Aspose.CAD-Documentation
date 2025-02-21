---
title: Ustaw timeout podczas zapisu
type: docs
weight: 70
url: /pl/java/developer-guide/set-timeout-on-save/
---

## **Ustaw timeout podczas zapisu**

Aspose.CAD dla Java API pozwala na ustawienie timeout podczas zapisu. Może to być pomocne w przypadkach, gdy proces zapisu zajmuje dużo czasu lub zużywa dużo pamięci. W tym celu API udostępnia klasę [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource). Klasa [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) udostępnia token, który jest używany do przerywania długotrwałych operacji.

## Przykładowy kod

Poniższy fragment kodu demonstruje użycie klasy [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
