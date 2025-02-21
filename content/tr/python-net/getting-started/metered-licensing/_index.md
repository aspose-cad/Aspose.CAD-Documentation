---
title: Metreli Lisanslama
type: docs
weight: 40
url: /tr/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD, geliştiricilerin metreli anahtar uygulamasına olanak tanır. Bu yeni bir lisanslama mekanizmasıdır. Yeni lisanslama mekanizması mevcut lisanslama yöntemi ile birlikte kullanılacaktır. API özelliklerinin kullanımı üzerinden faturalandırılmak isteyen müşteriler metreli lisanslamayı kullanabilirler. Daha fazla detay için lütfen [Metreli Lisanslama SSS](https://purchase.aspose.com/faqs/licensing/metered) bölümüne bakın.

{{% /alert %}} 
## **Metreli Lisanslama**
Metreli sınıfını kullanmak için basit adımlar şunlardır.

1. Metreli sınıfının bir örneğini oluşturun.
1. SetMeteredKey yöntemine genel ve özel anahtarları iletin.
1. İşlem yapın (görev gerçekleştirin).
1. Metreli sınıfının GetConsumptionQuantity yöntemini çağırın.
1. Şu ana kadar tükettiğiniz API isteklerinin miktarını/quantitiy'sini döndürecektir.

Aşağıda, metreli genel ve özel anahtarların nasıl ayarlanacağını gösteren örnek kod bulunmaktadır.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
