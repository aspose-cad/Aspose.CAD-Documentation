---
title: Kaydetme sırasında zaman aşımı ayarlama
type: docs
weight: 70
url: /tr/net/developer-guide/set-timeout-on-save/
---

## **Kaydetme sırasında zaman aşımı ayarlama**

Aspose.CAD for .NET API'si, kaydetme üzerinde bir zaman aşımı ayarlamanıza olanak tanır. Bu, kaydetme sürecinin çok zaman aldığı veya çok fazla bellek tükettiği durumlarda yararlı olabilir. Bunun için, API  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) sınıfını sağlar. [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) sınıfı, uzun işlemleri kesmek için kullanılan bir token sağlar.

## Örnek Kod

Aşağıdaki kod parçacığı, [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) sınıfının kullanımını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
