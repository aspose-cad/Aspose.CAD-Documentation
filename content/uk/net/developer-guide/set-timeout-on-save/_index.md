---
title: Встановити тайм-аут на збереження
type: docs
weight: 70
url: /uk/net/developer-guide/set-timeout-on-save/
---

## **Встановити тайм-аут на збереження**

Aspose.CAD для .NET API дозволяє встановити тайм-аут на збереження. Це може бути корисно в тих випадках, коли процес збереження займає багато часу або споживає багато пам'яті. Для цього API надає  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) клас. Клас [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) надає токен, який використовується для переривання тривалих операцій.

## Приклад коду

Наведений фрагмент коду демонструє використання класу [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
