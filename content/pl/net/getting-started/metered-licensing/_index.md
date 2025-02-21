---
title: Licencjonowanie z pomiarem
type: docs
weight: 60
url: /pl/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD umożliwia deweloperom stosowanie licencji z pomiarem. Jest to nowy mechanizm licencjonowania. Nowy mechanizm licencjonowania będzie stosowany razem z istniejącą metodą licencjonowania. Klienci, którzy chcą być obciążani na podstawie wykorzystania funkcji API, mogą skorzystać z licencjonowania z pomiarem. Aby uzyskać więcej informacji, zapoznaj się z sekcją [Często zadawane pytania dotyczące licencjonowania z pomiarem](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licencjonowanie z pomiarem**
Oto proste kroki, aby użyć klasy Metered.

1. Utwórz instancję klasy Metered.
1. Przekaż klucze publiczny i prywatny do metody SetMeteredKey.
1. Wykonaj przetwarzanie (wykonaj zadanie).
1. Wywołaj metodę GetConsumptionQuantity klasy Metered.
1. Zwróci to ilość/ilość żądań API, które do tej pory wykorzystałeś.

Poniżej znajduje się przykładowy kod ilustrujący, jak ustawić publiczny i prywatny klucz z pomiarem.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
