---
title: Błędy wywołania podczas eksportu i ładowania
type: docs
weight: 40
url: /pl/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Przegląd błędów wywołania podczas eksportu i ładowania**

Możliwe, że podczas eksportu lub ładowania rysunku napotkamy błędy związane z strukturą pliku 
(np. sekcje w pliku są teraz wymagane, ale wcześniej nie były). 
Niektóre z nich są krytyczne i w takich przypadkach zgłaszany jest wyjątek, ale możemy również zignorować niektóre z nich wewnętrznie i powiadomić o tym za pomocą komunikatów zwrotnych.
Tak czy inaczej, wszystkie te wiadomości wymagają uwagi, ponieważ mogą wyjaśnić np. brakujące encje w wynikach eksportu lub inne efekty.

### **Błędy podczas eksportu**

Istnieje pole RenderResult w [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
które zawiera IsRenderComplete, aby sprawdzić, czy wystąpiły błędy podczas eksportu i wydrukować informacje o nich:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Błędy podczas ładowania**

Niektóre problemy z rysunkami mogą być zauważone wcześniej, zanim proces eksportu się rozpocznie. 
Właściwość [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) w
obiekcie [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) jest używana do przechowywania komunikatów o nich.
Właściwość [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) jest przydatna do podjęcia decyzji, czy 
wymagane jest zgłoszenie wyjątku w przypadku błędów ładowania, czy nie.

Oto przykład użycia właściwości Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
