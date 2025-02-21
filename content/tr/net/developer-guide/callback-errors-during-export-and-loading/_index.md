---
title: Dışa aktarma ve yükleme sırasında geri çağırma hataları
type: docs
weight: 40
url: /tr/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Dışa aktarma ve yükleme sırasında geri çağırma hatalarının gözden geçirilmesi**

Dışa aktarma veya çizimin yüklenmesi sırasında dosya yapısıyla ilgili hatalarla karşılaşabiliriz 
(örneğin dosyadaki bölümler artık gereklidir ama daha önce değildi). 
Bunların bazıları kritik öneme sahiptir ve bu durumlarda bir istisna fırlatılır, ancak bazılarını içsel olarak görmezden gelebiliriz ve bununla ilgili geri çağırma mesajları kullanarak bildirimde bulunabiliriz.
Her durumda, bu mesajların hepsi dikkat gerektirir çünkü dışa aktarma sonuçlarında eksik varlıklar veya diğer etkiler gibi konuları açıklayabilirler.


### **Dışa aktarma sırasında hatalar**

[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) içinde RenderResult alanı vardır, 
bu alan dışa aktarım sırasında hata olup olmadığını anlamak için IsRenderComplete'i içerir ve bunlar hakkında bilgi yazdırır:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Yükleme sırasında hatalar**

Çizimlerle ilgili bazı sorunlar, dışa aktarma işlemi başlamadan önce gözlemlenebilir. 
[**Hatalar**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) özelliği
 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) nesnesinde, bu hatalar hakkında mesajları depolamak için kullanılır.
[**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) özelliği, 
yükleme hataları hakkında istisna fırlatmanın gerekip gerekmediğini belirlemek için yararlıdır. 

Hatalar özelliğinin kullanımına dair bir örnek:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
