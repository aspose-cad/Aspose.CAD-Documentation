---
title: Licencjonowanie z pomiarem
type: docs
weight: 40
url: /pl/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD pozwala deweloperom zastosować klucz z pomiarem. Jest to nowy mechanizm licencjonowania. Nowy mechanizm licencjonowania będzie używany razem z istniejącą metodą licencjonowania. Ci klienci, którzy chcą być obciążani na podstawie wykorzystania funkcji API, mogą skorzystać z licencjonowania z pomiarem. Aby uzyskać więcej informacji, zapoznaj się z sekcją [FAQ dotyczące licencjonowania z pomiarem](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licencjonowanie z pomiarem**
Oto proste kroki, aby użyć klasy Metered.

1. Utwórz instancję klasy Metered.
1. Przekaż klucze publiczny i prywatny do metody SetMeteredKey.
1. Wykonaj przetwarzanie (wykonaj zadanie).
1. Wywołaj metodę GetConsumptionQuantity klasy Metered.
1. Zwróci ona ilość zapytań API, które do tej pory wykorzystałeś.

Poniżej znajduje się przykładowy kod demonstrujący, jak ustawić publiczny i prywatny klucz z pomiarem.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
