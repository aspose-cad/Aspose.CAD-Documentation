---
title: Licencjonowanie z miernikiem
type: docs
weight: 60
url: /pl/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD umożliwia programistom zastosowanie klucza z miernikiem. Jest to nowy mechanizm licencjonowania. Nowy mechanizm licencjonowania będzie używany wraz z istniejącą metodą licencjonowania. Klienci, którzy chcą być rozliczani na podstawie korzystania z funkcji API, mogą korzystać z licencjonowania z miernikiem. Aby uzyskać więcej informacji, zapoznaj się z sekcją [FAQ dotyczące licencjonowania z miernikiem](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licencjonowanie z miernikiem**
Oto proste kroki, aby użyć klasy Metered.

1. Utwórz instancję klasy Metered.
1. Przekaż klucze publiczny i prywatny do metody setMeteredKey.
1. Wykonaj przetwarzanie (wykonaj zadanie).
1. Wywołaj metodę getConsumptionQuantity klasy Metered.
1. Zwróci to ilość zapytań API, które wykorzystałeś do tej pory.

Poniżej znajduje się przykładowy kod ilustrujący, jak ustawić publiczny i prywatny klucz z miernikiem:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
