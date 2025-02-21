---
title: Ölçümlü Lisanslama
type: docs
weight: 60
url: /tr/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD, geliştiricilerin ölçümlü anahtar uygulamasına izin verir. Bu, yeni bir lisanslama mekanizmasıdır. Yeni lisanslama mekanizması mevcut lisanslama yöntemi ile birlikte kullanılacaktır. API özelliklerinin kullanımı temelinde faturalandırılmak isteyen müşteriler ölçümlü lisanslamayı kullanabilirler. Daha fazla bilgi için lütfen [Ölçümlü Lisanslama SSS](https://purchase.aspose.com/faqs/licensing/metered) bölümüne bakın.

{{% /alert %}} 
## **Ölçümlü Lisanslama**
Ölçümlü sınıfı kullanmak için basit adımlar şunlardır:

1. Ölçümlü sınıfının bir örneğini oluşturun.
1. SetMeteredKey yöntemine genel ve özel anahtarları iletin.
1. İşlem yapın (görev gerçekleştirin).
1. Ölçümlü sınıfının GetConsumptionQuantity yöntemini çağırın.
1. Şu ana kadar tükettiğiniz API isteklerinin miktarını/nikliğini döndürecektir.

Aşağıda ölçümlü genel ve özel anahtarı nasıl ayarlayacağınızı gösteren örnek kod bulunmaktadır.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
