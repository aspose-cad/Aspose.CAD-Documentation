---
title: Ölçümlü Lisanslama
type: docs
weight: 60
url: /tr/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD, geliştiricilerin ölçümlü anahtar uygulamasına olanak tanır. Bu yeni bir lisanslama mekanizmasıdır. Yeni lisanslama mekanizması, mevcut lisanslama yöntemiyle birlikte kullanılacaktır. API özelliklerinin kullanımı bazında faturalandırılmak isteyen müşteriler ölçümlü lisanslamayı kullanabilir. Daha fazla bilgi için lütfen [Ölçümlü Lisanslama SSS](https://purchase.aspose.com/faqs/licensing/metered) bölümüne bakın.

{{% /alert %}} 
## **Ölçümlü Lisanslama**
Ölçümlü sınıfı kullanmak için basit adımlar şunlardır.

1. Ölçümlü sınıfın bir örneğini oluşturun.
1. public ve private anahtarları setMeteredKey yöntemine geçirin.
1. İşlem yapın (görevi yerine getirin).
1. Ölçümlü sınıfın getConsumptionQuantity yöntemini çağırın.
1. Şu ana kadar tükettiğiniz API isteklerinin miktarını/dolaylı olarak döndürür.

Aşağıda, ölçümlü public ve private anahtarının nasıl ayarlanacağına dair örnek kod verilmiştir:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
