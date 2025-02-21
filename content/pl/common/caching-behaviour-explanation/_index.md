---
title: Wyjaśnienie zachowania pamięci podręcznej Aspose.CAD
type: docs
weight: 20
url: /pl/common/caching-behaviour-explanation/
---


## **Jak Aspose.CAD przechowuje dane w pamięci podręcznej**

Cała pamięć podręczna obsługiwana przez Aspose.CAD jest całkowicie automatyczna, nie wymaga żadnych działań ze strony użytkownika. Istnieją zasadniczo trzy rodzaje pamięci podręcznej, wszystkie są związane z czcionkami.

### **Pamięć podręczna nazw czcionek**

Pamięć podręczna nazw czcionek jest używana w celu ułatwienia szybszego uruchamiania, poprzez wstępne przetwarzanie wszystkich znalezionych plików czcionek i kompilację listy nazw czcionek obecnych w tych plikach, ponieważ jeden plik czcionki może zawierać więcej niż jedną czcionkę. Jest przechowywana jako plik tymczasowy i ma zazwyczaj kilkadziesiąt kilobajtów wielkości w większości systemów.

### **Pamięć podręczna danych glifów czcionek**

Pamięć podręczna w pamięci dla wszystkich glifów, które były używane w czasie działania aplikacji, w celu zredukowania ponownego odczytywania rzeczywistych plików czcionek na dysku podczas kolejnych eksportów. W związku z tym, prowadziłoby to do stopniowego zwiększania zużycia pamięci, jeśli kolejne eksporty miałyby pliki, które odnosiłyby się do nowych czcionek i/lub zawierałyby znaki, z którymi nie spotkano się wcześniej. Jednak w praktyce, nawet w całym zestawie testowym Aspose.CAD, z tysiącami plików w różnych językach, zużycie pamięci wynosi około 200 megabajtów, co nie jest znaczące dla nowoczesnego systemu.

### **Pamięć podręczna czcionek na każdy znak**

Pamięć podręczna w pamięci, która przechowuje czcionki zawierające dany znak dla wszystkich znaków Unicode, aby ułatwić wybór czcionki zastępczej w przypadku, gdy czcionka dostarczona przez podmiot tekstowy w rysunku nie zawiera znaku w treści tekstowej tego podmiotu. Jest budowana podczas pierwszej operacji eksportu w czasie działania aplikacji i pozostaje do momentu zakończenia działania aplikacji. Na naszych stosunkowo skromnych maszynach testowych z masywnymi kolekcjami czcionek używanych w zestawach testowych, budowa pamięci podręcznej zajmuje około 30 sekund i zajmuje 70 megabajtów. Po zbudowaniu nie zajmuje już żadnego czasu i nie rośnie.
