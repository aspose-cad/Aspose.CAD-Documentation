---
title: Встановлення тайм-ауту при збереженні
type: docs
weight: 70
url: /uk/java/developer-guide/set-timeout-on-save/
---

## **Встановлення тайм-ауту при збереженні**

Aspose.CAD для Java API дозволяє встановлювати тайм-аут при збереженні. Це може бути корисно в випадках, коли процес збереження займає багато часу або споживає багато пам'яті. Для цього API надає клас [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource). Клас [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) надає токен, який використовується для переривання тривалих операцій.

## Приклад коду

Наступний фрагмент коду демонструє використання класу [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
