---
title: Условная лицензия
type: docs
weight: 60
url: /ru/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD позволяет разработчикам использовать условный ключ. Это новый механизм лицензирования. Новый механизм лицензирования будет использоваться вместе с существующим методом лицензирования. Клиенты, которые хотят получать счета на основе использования функций API, могут использовать условную лицензию. Для получения дополнительной информации, пожалуйста, обратитесь к разделу [Часто задаваемые вопросы по условным лицензиям](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Условная лицензия**
Вот простые шаги для использования класса Metered.

1. Создайте экземпляр класса Metered.
1. Передайте открытые и закрытые ключи в метод SetMeteredKey.
1. Выполните обработку (выполните задачу).
1. Вызовите метод GetConsumptionQuantity класса Metered.
1. Он вернет количество запросов API, которые вы использовали до сих пор.

Следующий пример кода демонстрирует, как установить условный открытый и закрытый ключ.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
