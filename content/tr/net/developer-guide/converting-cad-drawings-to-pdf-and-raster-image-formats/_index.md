---
title: DWG DXF'den PDF'ye C# | Auto CAD Dosyalarını C# .NET'de PDF JPEG PNG'ye Dönüştür
type: docs
weight: 30
url: /tr/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG'den PDF'ye C#, DXF'den PDF'ye C#, DWF DWT'den PDF'ye C#, AutoCAD dönüştür, DWG dönüştür, DWF dönüştür, DWT dönüştür, DXF dönüştür, autocad'i pdf'ye dönüştür, DWG'yi PDF'ye dönüştür, DWG'yi PNG'ye dönüştür, DWG'yi TIFF'ye dönüştür, DWG'yi JPG'ye dönüştür"
description: C# .NET AutoCAD'den PDF dönüştürücü kullanarak DWG veya DXF'yi C# içinde PDF'ye dönüştürebilirsiniz. DWG, DWF, DWT ve DXF'yi C# .NET içinde PDF, JPEG, PNG, BMP, GIF ve TIFF'ye dönüştürebilirsiniz.
---

## **DWG veya DXF'yi C# ile PNG JPEG BMP GIF veya TIFF'ye Dönüştürme**

Aspose.CAD for .NET, [DXF](https://docs.fileformat.com/cad/dxf/) ve [DWG](https://docs.fileformat.com/cad/dwg/) gibi AutoCAD çizim formatlarını [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) ve [GIF](https://docs.fileformat.com/image/gif/) formatlarına dönüştürebilir. Bu hedefe ulaşmak için etkin ve kullanımı kolay bir API sunmaktadır.

Aşağıda açıklanan basit adımları takip ederek desteklenen herhangi bir AutoCAD çizim formatını raster görüntü formatlarına dönüştürebilirsiniz.

1. AutoCAD DWG veya DXF dosyasını [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) sınıfına yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir örnek oluşturun.
1. [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) kullanarak görüntünün boyutunu ayarlayın/değiştirin.
1. [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) sınıfından bir örnek oluşturun.
1. Önceki adımda oluşturulan [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) örneğini [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğine ayarlayın.
1. AutoCAD çizimini [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) ile PDF olarak kaydedin, dosya yolunu (veya bir MemoryStream objesini) ve önceki adımda oluşturulan [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) örneğini geçin.

İşte tam kaynak kodu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Varsayılan olarak, API yalnızca "Model" düzenini işler. Ancak, CAD çizimlerini görüntü formatlarına dönüştürürken tercih ettiğiniz düzenleri de belirtebilirsiniz.

## **CAD Dönüşümünü Özelleştirme**

CAD'den [PDF](https://docs.fileformat.com/pdf/) ve CAD'den raster görüntü dönüşüm prosedürleri son derece yapılandırılabilir çünkü [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfı, uygulama ihtiyaçlarına göre işleme sürecini geçersiz kılabilecek birçok isteğe bağlı özellik sunacak şekilde tasarlanmıştır.

### **CadRasterizationOptions Sınıfı**

**CadRasterizationOptions** sınıfı, desteklenen tüm CAD formatları için (DWG ve DXF gibi) ortak bir sınıftır, bu nedenle bu makalede paylaşılan bilgiler yukarıda belirtilen CAD formatları için de geçerlidir.

En faydalı **CadRasterizationOptions** sınıf özellikleri:

|**Özellik**|**Varsayılan Değer**|**Gerekli**|**Açıklama**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Evet|Sayfa genişliğini belirtir.|
|**PageHeight**|**0**|Evet|Sayfa yüksekliğini belirtir.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Hayır|Çizimin otomatik olarak ölçeklenip ölçeklenmeyeceğini belirtir. Varsayılan değer, resmi tuval boyutuna sığdırmak için otomatik olarak küçültür. **GrowToFit** moduna geçin veya otomatik ölçeklemeyi devre dışı bırakmak için **None** ayarını kullanın.|
|**BackgroundColor**|**Color.White**|Hayır|Çıktı görüntüsünün arka plan rengini belirtir.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Hayır|Varlıkların renklendirme modunu belirtir. Varlıkları kendi yerel rengiyle çizmek için **UseObjectColor** seçeneğini belirtin veya yerel renkleri geçersiz kılmak için **UseDrawColor** seçeneğini belirtin.|
|**DrawColor**|**Color.Black**|Hayır|Geçersiz kılınan varlık rengini belirtir (sadece **DrawType** **UseDrawColor** özellik değerine ayarlandığında).|
|**AutomaticLayoutsScaling**|Yanlış|Hayır|Otomatik düzen ölçeklemesinin Model düzenine uyması gerektiğini belirtir.|

### **Tuval Boyutunu ve Modunu Ayarlama**

CAD'den PDF veya CAD'den raster görüntü formatlarına aktarım basit bir iş değildir. Sonuç PDF veya görüntüsü, çizimi düzgün bir şekilde işlemek için tuval boyutunun tanımlanmasını gerektirir. Çizimi düzgün bir şekilde görüntülemek için PDF sayfasının çıktı boyutlarını tanımlamamız gerekir. **CadRasterizationOptions.PageWidth** ve **CadRasterizationOptions.PageHeight** özelliklerini açıkça ayarlayın, aksi takdirde **ImageSaveException** alabilirsiniz.

Ayrıca, boyut ölçeği seçeneklerini belirleyebilirsiniz. Ölçekleme seçenekleri **CadRasterizationOptions.ScaleMethod** özelliği ile ayarlanır. Bu seçeneği kullanarak görüntü boyutlarını **CadRasterizationOptions.PageWidth** ve **CadRasterizationOptions.PageHeight** değerlerine göre otomatik olarak ayarlayın. Varsayılan olarak, **CadRasterizationOptions.ScaleMethod** **ScaleType.ShrinkToFit** moduna ayarlanmıştır. Bu özellik aşağıdaki davranışı tanımlar:

- CAD çiziminin boyutları, sonuçtu tuval boyutundan büyükse, çizim boyutları, en-boy oranını koruyarak sonuçtu tuvale sığacak şekilde küçük boyutlara düşürülür.
- CAD çiziminin boyutları, sonuçtu tuval boyutundan küçükse, çizim boyutunu sonuçtu PDF tuvaline sığdırmak için **CadRasterizationOptions.ScaleMethod** özelliğini **ScaleType.GrowToFit** ayarlayın, bu sırada en-boy oranı korunur.
- Ya da otomatik ölçeklemeyi **ScaleType.None** seçeneği ile devre dışı bırakabilirsiniz.

Aşağıdaki kod örneği, otomatik ölçekleme seçeneğinin nasıl kullanıldığını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Arka Plan ve Çizim Renklerini Ayarlama**

Varsayılan olarak, sonuçtu tuvalin renk paleti, ortak belgeler şemasına ayarlanmıştır. Bu, CAD çizimindeki tüm varlıkların, solid beyaz bir arka plan üzerinde siyah renk kalemi ile çizileceği anlamına gelir. Bu ayarlar, **CadRasterizationOptions.BackgroundColor** ve **CadRasterizationOptions.DrawColor** özellikleri ile değiştirilebilir. **CadRasterizationOptions.DrawColor** özelliğini değiştirmek, çizim renginin kullanılabilmesi için **CadRasterizationOptions.DrawType** özelliğinin de ayarlanmasını gerektirir. **CadRasterizationOptions.DrawType** özelliği, CAD varlıklarının renklerini koruyup korumayacağını veya özel renklere dönüştürülüp dönüştürülmeyeceğini kontrol eder. Varlık renklerini korumak için, **CadRasterizationOptions.DrawType** değerini **CadDrawTypeMode.UseObjectColor** olarak belirtin, aksi takdirde **CadDrawTypeMode.UseDrawColor** değerini belirtin.

Aşağıdaki kod örneği, farklı renk özelliklerinin nasıl kullanılacağını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Otomatik Düzen Ölçeklemesini Ayarlama**

Çoğu CAD çizimi, tek bir dosyada birden fazla düzen bulundurur ve her düzenin farklı boyutları olabilir. Böyle CAD çizimlerini PDF'ye aktarırken, PDF'nin her sayfası, düzen boyutuna göre farklı ölçeklenebilir. Görselleştirmeyi homojen hale getirmek için, Aspose.CAD API'leri **CadRasterizationOptions.AutomaticLayoutsScaling** özelliğini sunmuştur. Varsayılan değeri **yanlış**’dır, ancak doğru olduğunda API, her ayrı düzen için karşılık gelen bir ölçek aramaya çalışacak ve sayfa boyutuna göre otomatik yeniden boyutlandırma işlemi gerçekleştirerek uygun şekilde çizecektir.

**CadRasterizationOptions.AutomaticLayoutsScaling** özelliğinin **CadRasterizationOptions.ScaleMethod** özelliği ile birlikte nasıl çalıştığı aşağıdaki gibidir:

1. Eğer **ScaleMethod** **ScaleType.ShrinkToFit** veya **ScaleType.GrowToFit** olarak ayarlanmışsa ve **AutomaticLayoutsScaling** yanlış olarak ayarlanmışsa, o zaman tüm düzenler (Model dahil) ilk seçeneğe göre işlenecektir.
1. Eğer **ScaleMethod** **ScaleType.ShrinkToFit** veya **ScaleType.GrowToFit** olarak ayarlanmışsa ve **AutomaticLayoutsScaling** doğru olarak ayarlanmışsa, o zaman tüm düzenler (Model hariç) kendilerine göre işlenecek, Model ise ilk seçeneğe göre işlenecektir.
1. Eğer **ScaleMethod** **ScaleType.None** olarak ayarlanmışsa ve **AutomaticLayoutsScaling** doğru veya yanlış olarak ayarlanmışsa, o zaman hiçbir ölçekleme yapılmayacaktır.

Aşağıdaki kod örneği, CAD'den PDF dönüşümü için otomatik düzen ölçeklemesinin nasıl ayarlandığını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **AutoCAD DXF veya DWG Düzenlerini C# ile PNG veya Diğer Görüntü Formatlarına Dönüştürme**

Aspose.CAD for .NET API, desteklenen formatlardaki CAD düzenlerini DXF ve DWG gibi formatları PNG, BMP, TIFF, JPEG ve GIF gibi formatlara dönüştürebilir. API ayrıca CAD çiziminin belirli düzenlerini farklı PSD katmanlarına render etme desteği de sunar.

Aşağıda, bunu nasıl gerçekleştirebileceğiniz basit adımlarla gösterilmektedir.

- **Image** sınıfını kullanarak AutoCAD DWG veya DXF dosyasını yükleyin.
- Görüntünün genişliğini ve yüksekliğini ayarlayın/değiştirin.
- **CadRasterizationOptions.Layouts** özelliğini kullanarak istenen düzen adı(ları)nı ayarlayın.
- **ImageOptionsBase** sınıfından bir örnek oluşturun ve **VectorRasterizationOptions** özelliğini önceki adımda oluşturduğunuz **CadRasterizationOptions** örneğine ayarlayın.
- CAD düzenini TIFF veya görüntü olarak kaydedin.

İşte tam kaynak kodu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

**CadRasterizationOptions.Layouts** özelliği dizi türündedir, bu nedenle bir seferde birden fazla düzen belirtebilirsiniz. **CadRasterizationOptions.Layouts** özelliği için birden fazla düzen belirtirken, sonuç TIFF görüntüsü birden fazla sayfaya, GIF görüntüsü birden fazla kareye ve [PSD](https://docs.fileformat.com/image/psd/) formatı birden fazla katmana sahip olacaktır; her sayfa/kare/katman, bireysel bir AutoCAD düzenini temsil eder. Eğer sonuçları depolamak için PNG, BMP, JPEG gibi başka bir görüntü formatı seçilirse, API yalnızca varsayılan düzeni render edecektir; yani "Model" olanı.

{{% /alert %}}

## **CAD Görselleştirme Süreci için İzlemeyi Etkinleştirme**

Aspose.CAD, CAD görselleştirme sürecinin izlenmesine yardımcı olacak bir dizi sınıf ve destekleyici enum alanları tanıtmıştır. Bu değişikliklerle birlikte, CAD'den PDF dönüşümü artık izleme etkinleştirilerek aşağıdaki şekilde gerçekleştirilebilir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

CAD görselleştirme sürecinin izlenmesi, aşağıdaki olası sorunları tespit edebilir.

1. Eksik veya bozuk başlık bilgisi.
1. Eksik düzen bilgisi.
1. Eksik blok varlıkları.
1. Eksik boyut stilleri.
1. Eksik stiller.

## **CAD Çizimlerini Dönüştürürken Fontları Değiştirme**

Belirli bir CAD çiziminin, CAD'den PDF veya CAD'den raster görüntü dönüşümünün gerçekleştiği makinede bulunmayan belirli bir font kullanması olasıdır. Böyle durumlarda, Aspose.CAD API, eksik font(lar)ı vurgulamak ve dönüşüm sürecini durdurmak için uygun bir istisna tetikler çünkü API, içeriklerini sonuç PDF veya görüntülere düzgün bir şekilde renderlemek için bu fontlara ihtiyaç duyar.

Aspose.CAD API, gerekli font(ları) mevcut font(larla) değiştirme mekanizmasını kullanmanın kolay bir yolunu sağlar. **CadImage.Styles** özelliği, CAD çizimindeki her stil için **CadStyleTableObject**'i içeren bir **CadStylesDictionary** örneği döndürür. **CadStyleTableObject.PrimaryFontName** ise mevcut font adını belirtmek için kullanılabilir.

Aşağıdaki kod örneği, Aspose.CAD for .NET API'sinin bir CAD çizimindeki tüm stillerin fontunu değiştirme kullanımını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Sadece bir belirli stilin fontunu stil adı ile erişerek değiştirmek de mümkündür. Aşağıdaki kod örneği, bu yaklaşımın kullanımını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **CAD Katmanlarını Raster Görüntü Formatlarına Dönüştürme**

Aspose.CAD for .NET API, gereken CAD katmanının adını belirlemeye ve bunu raster görüntü formatlarına render etmeye yönelik verimli ve kolay bir araç sunmaktadır. Aşağıda, bunu 5 basit adımda nasıl gerçekleştirebileceğinizi bulabilirsiniz.

1. CAD dosyasını **Image** örneğine **Load** fabrika yöntemi kullanarak yükleyin.
1. **CadRasterizationOptions** örneği oluşturun ve **PageWidth** ve **PageHeight** gibi zorunlu özelliklerini ayarlayın.
1. **CadRasterizationOptions.Layers.Add** yöntemi kullanarak gerekli katman adını ekleyin.
1. **ImageOptionsBase** sınıfından bir örnek oluşturun ve **VectorRasterizationOptions** özelliğini önceki adımda oluşturduğunuz **CadRasterizationOptions** örneğine ayarlayın.
1. **Image.Save** yöntemini çağırarak dosya yolunu (veya bir MemoryStream nesnesini) ve önceki adımda oluşturduğunuz **ImageOptionsBase** örneğini geçin.

İşte tam kaynak kodu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Tüm CAD Katmanlarını Ayrı Görüntülere Dönüştürme**

**CadImage.Layers** kullanarak CAD çiziminden tüm katmanları alabilir ve her bir katmanı ayrı görüntü olarak render edebilirsiniz, aşağıda gösterildiği gibi.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **DWF CAD Katmanlarını Raster Görüntü Formatlarına Dönüştürme**

Aspose.CAD for .NET API, gereken CAD katmanının adını belirlemeye ve bunu raster görüntü formatlarına render etmeye yönelik verimli ve kolay bir araç sunmaktadır. Aşağıda, bunu 5 basit adımda nasıl gerçekleştirebileceğinizi bulabilirsiniz.

1. DWF CAD dosyasını **Image** örneğine **Load** fabrika yöntemi kullanarak yükleyin.
1. **CadRasterizationOptions** örneği oluşturun ve **PageWidth** ve **PageHeight** gibi zorunlu özelliklerini ayarlayın.
1. **CadRasterizationOptions.Layers.Add** yöntemi kullanarak gerekli katman adını ekleyin.
1. **ImageOptionsBase** sınıfından bir örnek oluşturun ve **VectorRasterizationOptions** özelliğini önceki adımda oluşturduğunuz **CadRasterizationOptions** örneğine ayarlayın.
1. **Image.Save** yöntemini çağırarak dosya yolunu (veya bir MemoryStream nesnesini) ve önceki adımda oluşturduğunuz **ImageOptionsBase** örneğini geçin.

İşte tam kaynak kodu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD for .NET, API ve Sürüm Numarası hakkında bilgileri çıktı belgelerine doğrudan yazar. Örneğin, belgeleri PDF'ye render ettiğinde, Aspose.CAD for .NET Application alanını 'Aspose.CAD' değeri ve PDF Producing alanını 'Aspose.CAD v 17.10' gibi bir değer ile doldurur.

Lütfen Aspose.CAD for .NET'i çıktı belgelerinden bu bilgileri değiştirmesi veya kaldırması için talimat veremeyeceğinizi unutmayın.
