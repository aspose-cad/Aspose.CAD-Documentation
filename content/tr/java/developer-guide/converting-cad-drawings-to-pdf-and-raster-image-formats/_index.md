---
title: CAD Çizimlerini PDF ve Raster Görüntü Formatlarına Dönüştürme
type: docs
weight: 30
url: /tr/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java, çıktı belgelerindeki API ve Sürüm Numarası bilgilerini doğrudan yazar. Örneğin, Belgeyi PDF'ye işlerken, Aspose.CAD for Java Uygulama alanını 'Aspose.CAD' değeri ve PDF Üretici alanını 'Aspose.CAD v 17.9' gibi bir değerle doldurur.

Lütfen, Aspose.CAD for Java'dan bu bilgileri çıktı belgelerinden değiştirmesini veya kaldırmasını isteyemeyeceğinizi unutmayın.

{{% /alert %}} 
## **CAD Çizimlerini Raster Görüntü Formatlarına Dönüştürme**
Aspose.CAD for Java, [**DXF**](https://docs.fileformat.com/cad/dxf/) ve [**DWG**](https://docs.fileformat.com/cad/dwg/) gibi CAD çizim formatlarını [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) ve [**GIF**](https://docs.fileformat.com/image/gif/) gibi desteklenen raster görüntü formatlarına dönüştürme yeteneğine sahiptir. Aspose.CAD for Java API, bu hedefe ulaşmak için verimli ve kullanımı kolay yollar sunmuştur.
Aşağıda detaylandırıldığı gibi, herhangi bir desteklenen CAD çizim formatını raster görüntü formatlarına dönüştürebilirsiniz.

1. CAD dosyasını [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) örneğine yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) örneğini oluşturun ve [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) gibi zorunlu özelliklerini ayarlayın.
1. **ImageOptionsBase** örneğini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini bir önceki adımda oluşturulan **CadRasterizationOptions** örneğine ayarlayın.
1. Dosya yolunu (veya MemoryStream nesnesini) ve bir önceki adımda oluşturulan [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) örneğini geçirerek **Image.save** çağrısı yapın.

İşte tamamlayıcı kaynak kodu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Varsayılan olarak, API yalnızca "Model" düzenini işler. Ancak, CAD çizimlerini görüntü formatlarına dönüştürürken kendi tercihlerinize göre düzenleri de belirtebilirsiniz.
## **CAD Dönüşümünü Özelleştirme**
CAD'den [PDF](https://docs.fileformat.com/pdf/) ve CAD'den raster görüntü dönüşüm prosedürleri oldukça yapılandırılabilir çünkü [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfı, uygulama ihtiyaçlarına göre yeniden yapılandırılabilen birçok isteğe bağlı özellik sunacak şekilde uygulanmıştır.
### **CadRasterizationOptions Sınıfı**
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfı, [**DWG**](https://docs.fileformat.com/cad/dwg/) ve DXF gibi tüm desteklenen CAD formatları için ortaktır, bu nedenle, bu makalede paylaşılan bilgiler yukarıda belirtilen her iki CAD formatı için geçerlidir.

En kullanışlı **CadRasterizationOptions** sınıfı özellikleri şunlardır:

|**Özellik**|**Varsayılan Değer**|**Gerekli**|**Açıklama**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Evet|Sayfa genişliğini belirtir.|
|**PageHeight**|**0**|Evet|Sayfa yüksekliğini belirtir|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Hayır|Çizimin otomatik olarak ölçeklendirilip ölçeklendirilmeyeceğini belirtir. Varsayılan değer, görüntüyü tuval boyutuna sığacak şekilde otomatik olarak küçültür. **GrowToFit** moduna geçin veya otomatik ölçeklendirmeyi devre dışı bırakmak için **None** ayarını kullanın.|
|**BackgroundColor**|**Color.White**|Hayır|Çıktı görüntüsünün arka plan rengini belirtir.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Hayır|Varlığın renklendirme modunu belirtir. Varlıkları yerel renklerini kullanarak çizmek için **UseObjectColor** seçeneğini belirtin veya yerel renkleri geçersiz kılmak için **UseDrawColor** seçeneğini belirtin.|
|**DrawColor**|**Color.Black**|Hayır|Geçersiz kılınmış varlığın rengini belirtir (yalnızca **DrawType** **UseDrawColor** özellik değeri olarak ayarlandığında).|
|**AutomaticLayoutsScaling**|False|Hayır|Otomatik düzen ölçeklemenin Model düzene karşı yapılması gerekip gerekmediğini belirtir.|
### **Tuval Boyutunu ve Modunu Ayarlama**
CAD'den PDF'ye veya CAD'den raster görüntü formatlarına aktarım basit bir görev değildir. Sonuç PDF'sinin veya görüntünün tuval boyutunun tanımlanması gerektiğinden, çizimi düzgün bir şekilde işlemek için PDF sayfasının çıktı boyutlarını belirtmemiz gerekir. **CadRasterizationOptions.PageWidth** ve **CadRasterizationOptions.PageHeight** özelliklerini açıkça ayarlayın veya bir **ImageSaveException** alabilirsiniz.

Ayrıca, boyut ölçek seçeneklerini belirtebilirsiniz. Ölçeklendirme seçenekleri **CadRasterizationOptions.ScaleMethod** özelliği ile ayarlanır. Bu seçeneği, görüntü boyutlarını **CadRasterizationOptions.PageWidth** ve **CadRasterizationOptions.PageHeight** değerlerine göre otomatik olarak ayarlamak için kullanın. Varsayılan olarak **CadRasterizationOptions.ScaleMethod** **ScaleType.ShrinkToFit** moduna ayarlanmıştır. Bu özellik, aşağıdaki davranışları tanımlar:

- CAD çizim boyutları sonuçta oluşan tuval boyutundan büyükse, çizim boyutları, en-boy oranını koruyarak sonuçta oluşan tuvale sığacak şekilde küçültülür.
- CAD çizim boyutları sonuçta oluşan tuval boyutundan küçükse, çizim boyutunu, en-boy oranını koruyarak PDF tuvaline sığacak şekilde artırmak için **CadRasterizationOptions.ScaleMethod** özelliğini **ScaleType.GrowToFit** olarak ayarlayın.
- Ya da otomatik ölçeklendirmeyi **ScaleType.None** seçeneğiyle devre dışı bırakın.

Aşağıdaki kod örneği otomatik ölçeklendirme seçeneğinin kullanımını gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Arka Plan ve Çizim Renklerini Ayarlama**
Varsayılan olarak, sonuçtaki tuval için renk paleti genel belgeler şemasına ayarlanmıştır. Bu, CAD çizimindeki tüm varlıkların beyaz bir arka planda siyah kalemle çizileceği anlamına gelir. Bu ayarlar **CadRasterizationOptions.BackgroundColor** ve **CadRasterizationOptions.DrawColor** özellikleri ile değiştirilebilir. **CadRasterizationOptions.DrawColor** özelliğini değiştirmek, kullanılacak çizim renginden yararlanmak için **CadRasterizationOptions.DrawType** özelliğinin de ayarlanmasını gerektirir. **CadRasterizationOptions.DrawType** özelliği, CAD varlıklarının renklerini koruyup koruyamayacağını veya özel renklerle dönüştürülüp dönüştürülmeyeceğini kontrol eder. Varlık renklerini korumak için **CadRasterizationOptions.DrawType** değerini **CadDrawTypeMode.UseObjectColor** olarak belirtin, aksi takdirde **CadDrawTypeMode.UseDrawColor** değerini belirtin.

Aşağıdaki kod örneği, farklı renk özelliklerini nasıl kullanacağınızı gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Otomatik Düzen Ölçeklendirmesini Ayarlama**
Çoğu CAD çizimi, tek bir dosyada birden fazla düzen saklar ve her düzen farklı boyutlara sahip olabilir. Bu tür CAD çizimlerini PDF'ye işlerken, PDF'nin her sayfası düzen boyutuna göre farklı ölçeklendirmeye sahip olabilir. İşlemeyi eşit hale getirmek için, Aspose.CAD API'leri **CadRasterizationOptions.AutomaticLayoutsScaling** özelliğini açığa çıkarmıştır. Varsayılan değeri **false**'dur ancak true olduğunda, API her ayrı düzen için karşılık gelen bir ölçek aramaya çalışır ve sayfa boyutuna göre otomatik yeniden boyutlandırma işlemi yaparak bunu uygun bir şekilde çizer.

İşte **CadRasterizationOptions.AutomaticLayoutsScaling** özelliğinin **CadRasterizationOptions.ScaleMethod** özelliği ile işbirliği içinde nasıl çalıştığı:

1. **ScaleMethod** **ScaleType.ShrinkToFit** veya **ScaleType.GrowToFit** olarak ayarlandığında ve **AutomaticLayoutsScaling** false olduğunda, tüm düzenler (Model dahil) ilk seçeneğe göre işlenecektir.
1. **ScaleMethod** **ScaleType.ShrinkToFit** veya **ScaleType.GrowToFit** olarak ayarlandığında ve **AutomaticLayoutsScaling** true olduğunda, tüm düzenler (Model hariç) boyutlarına göre işlenecek, Model ilk seçeneğe göre işlenecektir.
1. **ScaleMethod** **ScaleType.None** olarak ayarlandığında ve **AutomaticLayoutsScaling** true veya false olarak ayarlandığında, herhangi bir ölçeklendirme yapılmayacaktır.

Aşağıdaki kod örneği, CAD'den PDF dönüşümü için otomatik düzen ölçeklendirmeyi nasıl ayarlayacağınızı gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **CAD Düzenlerini Raster Görüntü Formatlarına Dönüştürme**
Aspose.CAD for Java API, DXF ve DWG gibi desteklenen formatların CAD düzenlerini PNG, BMP, TIFF, JPEG ve GIF gibi raster görüntülere dönüştürme yeteneğine sahiptir. API ayrıca, bir CAD çiziminin belirli düzenlerini farklı PSD katmanlarına render etme desteği de sunmaktadır. 
Aspose.CAD for Java API, gerekli CAD düzenlerinin listesini belirtmek ve bunları raster görüntü formatlarına render etmek için verimli ve kullanımı kolay yollar sunmuştur. Aşağıda, bunu 5 basit adımda nasıl gerçekleştirebileceğiniz listelenmiştir.

1. CAD dosyasını **Image** örneğine **load** fabrika yöntemi ile yükleyin.
1. **CadRasterizationOptions** örneğini oluşturun ve **PageWidth** ve **PageHeight** gibi zorunlu özelliklerini ayarlayın.
1. İstenen düzen adı(ları)nı CadRasterizationOptions.Layouts özelliğini kullanarak belirtin.
1. **ImageOptionsBase** örneğini oluşturun ve **VectorRasterizationOptions** özelliğini bir önceki adımda oluşturulan **CadRasterizationOptions** örneğine ayarlayın.
1. Dosya yolunu (veya MemoryStream nesnesini) ve bir önceki adımda oluşturulan **ImageOptionsBase** örneğini geçirerek **Image.Save** çağrısı yapın.

İşte tamamlayıcı kaynak kodu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

**CadRasterizationOptions.Layouts** özelliği türü dizi olduğundan, imaj formatlarına mümkün olan dönüşüm için birden fazla düzen belirleyebilirsiniz. **CadRasterizationOptions.Layouts** özelliği için birden fazla düzen belirtirken, sonuçta oluşan TIFF görüntüsü birden fazla sayfa içerecek, GIF görüntüsü birden fazla çerçeve içerecek ve PSD formatı birden fazla katman içerecektir; burada her sayfa/çerçeve/katman bireysel AutoCAD düzenine karşılık gelir. PNG, BMP, JPEG gibi farklı bir görüntü formatı seçildiğinde sonuç, yalnızca varsayılan düzen olan "Model" olacaktır.

{{% /alert %}} 
## **CAD Renderleme Süreci için İzlemeyi Etkinleştirme**
Aspose.CAD, CAD renderleme süreci ile ilgili izleme için yardımcı olacak bir dizi sınıf ve destekleyici enumerasyon alanı tanıttı. Bu değişiklikler sayesinde, CAD'den PDF dönüşümü artık izlemeyi etkinleştirerek aşağıdaki gibi gerçekleştirilebilir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



CAD renderleme sürecinin izlenmesi, aşağıdaki olası sorunları tespit edebilir.

1. Eksik veya bozuk başlık bilgisi.
1. Eksik düzen bilgisi.
1. Eksik blok nesneleri.
1. Eksik boyut stilleri.
1. Eksik stiller.
## **CAD Çizimlerini Dönüştürürken Yazı Tiplerini Değiştirme**
Belirli bir CAD çiziminin, CAD'den PDF’ye veya CAD'den raster görüntü formatlarına dönüşüm işleminin gerçekleştiği makinada bulunmayan belirli bir yazı tipi kullanması oldukça olasıdır. Bu durumlarda, Aspose.CAD API'si, eksik yazı tiplerini vurgulamak ve dönüşüm sürecini durdurmak için uygun bir istisna tetikleyecektir çünkü API, içerikleri sonuç PDF'sine ve/veya görüntülere düzgün bir şekilde render etmek için bu yazı tiplerini gerektirir.
Aspose.CAD API, gereken yazı tiplerini mevcut yazı tipleriyle değiştirmek için kolay bir mekanizma sağlar. **CadImage.Styles** özelliği, CAD çizimindeki her stil için **CadStyleTableObject**'u içeren **CadStylesDictionary** örneğini döndürürken, **CadStyleTableObject.PrimaryFontName** mevcut yazı tipi adını belirlemek için kullanılabilir.

Aşağıdaki kod parçacığı, CAD çizimindeki tüm stillerin yazı tipini değiştirmek için Aspose.CAD for Java API'sinin kullanımını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Sadece bir belirli stilin yazı tipini değiştirmek için stil adını kullanarak erişmek de mümkündür. Aşağıdaki kod parçacığı, bu yaklaşımın kullanımını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **CAD Katmanlarını Raster Görüntü Formatlarına Dönüştürme**
Aspose.CAD for Java API, gerekli CAD katmanının adını belirlemek ve bunu raster görüntü formatlarına render etmek için verimli ve kullanımı kolay yollar sunmuştur. Aşağıda, bunu 5 basit adımda nasıl gerçekleştirebileceğiniz listelenmiştir.

1. DWF CAD dosyasını **Image** örneğine **Load** fabrika yöntemi ile yükleyin.
1. **CadRasterizationOptions** örneğini oluşturun ve **PageWidth** ve **PageHeight** gibi zorunlu özelliklerini ayarlayın.
1. **CadRasterizationOptions.Layers.add** yöntemi ile istenen katman adını ekleyin.
1. **ImageOptionsBase** örneğini oluşturun ve **VectorRasterizationOptions** özelliğini bir önceki adımda oluşturulan **CadRasterizationOptions** örneğine ayarlayın.
1. Dosya yolunu (veya MemoryStream nesnesini) ve bir önceki adımda oluşturulan **ImageOptionsBase** örneğini geçirerek **Image.save** yöntemini çağırın.

İşte tamamlayıcı kaynak kodu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Tüm CAD Katmanlarını Ayrı Görüntülere Dönüştürme**
**CadImage.Layers** kullanarak bir CAD çizimindeki tüm katmanları alabilir ve her katmanı ayrı bir görüntü olarak render edebilirsiniz. Aşağıda bu konu gösterilmektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **DWF CAD Katmanlarını Raster Görüntü Formatlarına Dönüştürme**
Aspose.CAD for Java API, gerekli CAD katmanının adını belirlemek ve bunu raster görüntü formatlarına render etmek için verimli ve kullanımı kolay yollar sunmuştur. Aşağıda, bunu 5 basit adımda nasıl gerçekleştirebileceğiniz listelenmiştir.

1. DWF CAD dosyasını **Image** örneğine **Load** fabrika yöntemi ile yükleyin.
1. **CadRasterizationOptions** örneğini oluşturun ve **PageWidth** ve **PageHeight** gibi zorunlu özelliklerini ayarlayın.
1. **CadRasterizationOptions.Layers.Add** yöntemi ile istenen katman adını ekleyin.
1. **ImageOptionsBase** örneğini oluşturun ve **VectorRasterizationOptions** özelliğini bir önceki adımda oluşturulan **CadRasterizationOptions** örneğine ayarlayın.
1. Dosya yolunu (veya MemoryStream nesnesini) ve bir önceki adımda oluşturulan **ImageOptionsBase** örneğini geçirerek **Image.Save** yöntemini çağırın.

İşte tamamlayıcı kaynak kodu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
