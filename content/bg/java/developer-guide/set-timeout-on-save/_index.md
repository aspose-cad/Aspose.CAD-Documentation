---
title: Задайте времево изчакване при запазване
type: docs
weight: 70
url: /bg/java/developer-guide/set-timeout-on-save/
---

## **Задайте времево изчакване при запазване**

Aspose.CAD за Java API позволява да зададете времево изчакване при запазване. Това може да бъде полезно в случаи, при които процесът на запазване отнема много време или консумира много памет. За това, API предоставя класа [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource). Класът [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) предоставя токен, който се използва за прекъсване на дълги операции.

## Примерен код

Следният кодов фрагмент демонстрира използването на класа [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
