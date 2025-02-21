---
title: Установить таймаут при сохранении
type: docs
weight: 70
url: /ru/net/developer-guide/set-timeout-on-save/
---

## **Установить таймаут при сохранении**

Aspose.CAD для .NET API позволяет установить таймаут при сохранении. Это может быть полезно в случаях, когда процесс сохранения занимает много времени или потребляет много памяти. Для этого API предоставляет класс  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource). Класс [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) предоставляет токен, который используется для прерывания долгих операций.

## Пример кода

Следующий фрагмент кода демонстрирует использование класса [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
