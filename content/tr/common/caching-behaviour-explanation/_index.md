---
title: Aspose.CAD'in önbellekleme davranışını açıklamak
type: docs
weight: 20
url: /tr/common/caching-behaviour-explanation/
---


## **Aspose.CAD verileri nasıl önbelleğe alır**

Aspose.CAD tarafından yapılan tüm önbellekleme tamamen otomatik olup, kullanıcı girişi gerektirmemektedir veya mümkün değildir. Temelde üç tür önbellekleme vardır ve bunların hepsi fontlarla ilgilidir.

### **Font adı önbelleği**

Font adı önbelleği, bulunan tüm font dosyalarını ön işleyerek ve bu dosyalarda bulunan font adlarının listesini derleyerek daha hızlı bir başlangıç sağlamak için kullanılır; çünkü bir font dosyası birden fazla font içerebilir. Geçici bir dosya olarak depolanır ve çoğu sistem için boyutu en fazla birkaç kilobayttır.

### **Font glif verisi önbelleği**

Uygulama süresi boyunca kullanılan tüm gliflerin bellek içindeki bir önbelleğidir; bu, sonraki dışa aktarımlar sırasında gerçek diskteki font dosyalarının yeniden okunmasını azaltır. Bu durumda, sonraki dışa aktarımlar yeni fontlara referans veren dosyalar ve/veya daha önce karşılaşılmamış karakterler içeriyorsa, bellek tüketiminin sürekli artmasına neden olur. Ancak pratikte, özellikle Aspose.CAD'in test setinde, içinde farklı dillerde dosyalar da dahil olmak üzere binlerce dosya bulunan test setinde, bellek tüketimi yaklaşık 200 megabayttır ki bu da modern bir sistem için çok önemli değildir.

### **Karakter başına font yedekleme önbelleği**

Verilen bir karakteri içeren fontları tüm Unicode karakterleri için depolayan bellek içi bir önbellek olup, bir çizim içindeki bir metin varlığı tarafından sağlanan bir fontun o varlığın metin içeriğinde bir karakter içermemesi durumunda yedek bir font seçimini kolaylaştırmak için kullanılır. Uygulama süresi boyunca ilk dışa aktarma işlemi sırasında oluşturulur ve uygulama kapatılana kadar kalır. Test setlerinde kullanılan büyük font koleksiyonlarına sahip, göreceli olarak mütevazı test makinelerimizde, önbelleğin oluşturulması yaklaşık 30 saniye sürüyor ve 70 megabayt yer kaplıyor. Bir kez oluşturulduğunda, daha fazla zaman almaz ve büyümez.
