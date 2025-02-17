---
title: CAD आरेखों को PDF और रास्टर छवि प्रारूपों में परिवर्तित करना
type: docs
weight: 30
url: /hi/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java सीधे आउटपुट दस्तावेजों में API और संस्करण संख्या के बारे में जानकारी लिखता है। उदाहरण के लिए, दस्तावेज़ को PDF में रेंडर करते समय, Aspose.CAD for Java एप्लिकेशन फ़ील्ड को 'Aspose.CAD' के साथ मान और PDF निर्माता फ़ील्ड को मान, जैसे 'Aspose.CAD v 17.9' के साथ भरता है।

कृपया ध्यान दें कि आप Aspose.CAD for Java को इस जानकारी को आउटपुट दस्तावेज़ों से बदलने या हटाने के लिए निर्देश नहीं दे सकते।

{{% /alert %}} 
## **CAD आरेखों को रास्टर छवि प्रारूपों में परिवर्तित करना**
Aspose.CAD for Java को CAD आरेख प्रारूपों जैसे कि [**DXF**](https://docs.fileformat.com/cad/dxf/) और [**DWG**](https://docs.fileformat.com/cad/dwg/) को समर्थित रास्टर छवि प्रारूपों जैसे कि [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) और [**GIF**](https://docs.fileformat.com/image/gif/) में परिवर्तित करने की क्षमता है। Aspose.CAD for Java API ने इस लक्ष्य को प्राप्त करने के लिए प्रभावी और उपयोग में आसान तरीके उपलब्ध कराए हैं।
आप सरल चरणों का पालन करके किसी भी समर्थित CAD आरेख प्रारूप को रास्टर छवि प्रारूपों में परिवर्तित कर सकते हैं, जैसा कि नीचे विस्तृत है।

1. CAD फ़ाइल को [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) के एक उदाहरण में लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) का एक उदाहरण बनाएं और इसके अनिवार्य गुणों जैसे कि [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) को सेट करें।
1. **ImageOptionsBase** का एक उदाहरण बनाएं और उसके [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) गुण को पिछले चरण में बनाए गए **CadRasterizationOptions** के उदाहरण पर सेट करें।
1. फ़ाइल पथ (या मेमोरी स्ट्रीम का एक ऑब्जेक्ट) और पिछले चरण में बनाए गए [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) के उदाहरण को पास करके **Image.save** को कॉल करें।

यहां संपूर्ण स्रोत कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



यादृच्छिक रूप से, API केवल "मॉडल" लेआउट को रेंडर करता है। हालाँकि, आप CAD आरेखों को छवि प्रारूपों में परिवर्तित करते समय अपनी पसंद के लेआउट निर्दिष्ट कर सकते हैं।
## **CAD रूपांतरण अनुकूलन**
CAD से [PDF](https://docs.fileformat.com/pdf/) और CAD से रास्टर छवि रूपांतरण प्रक्रियाएँ अत्यधिक विन्यास योग्य हैं क्योंकि [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) वर्ग को इस तरह लागू किया गया है कि यह कई वैकल्पिक सुविधाएँ प्रदान करती हैं जिन्हें सेट करने पर आवेदन की आवश्यकताओं के अनुसार रेंडरिंग प्रक्रिया को ओवरराइड किया जा सकता है।
### **CadRasterizationOptions वर्ग**
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) वर्ग सभी समर्थित CAD प्रारूपों जैसे कि [**DWG**](https://docs.fileformat.com/cad/dwg/) और DXF के लिए सामान्य है, इसलिए इस लेख में साझा की गई जानकारी दोनों उपरोक्त CAD प्रारूपों के लिए मान्य है।

सबसे उपयोगी **CadRasterizationOptions** वर्ग गुण हैं:

|**गुण**|**डिफ़ॉल्ट मान**|**आवश्यक**|**विवरण**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|हां|पृष्ठ की चौड़ाई निर्दिष्ट करता है।|
|**PageHeight**|**0**|हां|पृष्ठ की ऊँचाई निर्दिष्ट करता है|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|नहीं|निर्धारित करता है कि आरेख को स्वचालित रूप से स्केल किया जाना चाहिए या नहीं। डिफ़ॉल्ट मान छवि को कैनवास आकार में फिट करने के लिए स्वचालित रूप से सिकुड़ता है। **GrowToFit** मोड में स्विच करें, या स्वचालित स्केलिंग को अक्षम करने के लिए **None** सेटिंग का उपयोग करें।|
|**BackgroundColor**|**Color.White**|नहीं|निर्गत छवि का पृष्ठभूमि रंग निर्दिष्ट करता है।|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|नहीं|संस्थान की रंगाई मोड को निर्दिष्ट करता है। **UseObjectColor** विकल्प निर्दिष्ट करें ताकि संस्थाओं को उनके स्वदेशी रंग का उपयोग करके खींचा जाए, या **UseDrawColor** विकल्प का उपयोग करें ताकि स्वदेशी रंगों को ओवरराइड किया जा सके।|
|**DrawColor**|**Color.Black**|नहीं|ओवरराइड किए गए संस्थाओं के रंग को निर्दिष्ट करता है (केवल यदि **DrawType** **UseDrawColor** गुण मान पर सेट किया गया है)।|
|**AutomaticLayoutsScaling**|False|नहीं|निर्धारित करता है कि क्या ऑटो लेआउट स्केलिंग मॉडल लेआउट से मेल खाने के लिए किया जाना चाहिए।|
### **कैनवास का आकार और मोड सेट करना**
CAD से PDF या CAD से रास्टर छवि प्रारूपों में निर्यात करना एक साधारण कार्य नहीं है। चूंकि परिणामी PDF या छवि के लिए कैनवास का आकार परिभाषित करना आवश्यक है, इसलिए हमें ड्राइंग को सही ढंग से रेंडर करने के लिए PDF पृष्ठ के लिए आउटपुट आयाम निर्दिष्ट करने की आवश्यकता है। **CadRasterizationOptions.PageWidth** और **CadRasterizationOptions.PageHeight** गुणों को स्पष्ट रूप से सेट करें, अन्यथा आप एक **ImageSaveException** प्राप्त कर सकते हैं।

इसके अलावा, आप आयाम स्केल विकल्पों को निर्दिष्ट कर सकते हैं। स्केलिंग विकल्प **CadRasterizationOptions.ScaleMethod** गुण द्वारा सेट किए जाते हैं। इस विकल्प का उपयोग **CadRasterizationOptions.PageWidth** और **CadRasterizationOptions.PageHeight** मान के अनुसार छवि आयाम समायोजित करने के लिए करें। डिफ़ॉल्ट रूप से **CadRasterizationOptions.ScaleMethod** को **ScaleType.ShrinkToFit** मोड पर सेट किया गया है। यह प्रॉपर्टी निम्नलिखित व्यवहार को परिभाषित करती है:

- यदि CAD आरेख के आयाम परिणामी कैनवास आकार से बड़े हैं, तो ड्राइंग आयामों को पहलू अनुपात बनाए रखते हुए परिणामी कैनवास में फिट करने के लिए कम किया जाएगा।
- यदि CAD आरेख के आयाम परिणामी कैनवास आकार से छोटे हैं, तो ड्राइंग के आकार को PDF कैनवास में फिट करने के लिए बढ़ाने के लिए **CadRasterizationOptions.ScaleMethod** गुण को **ScaleType.GrowToFit** पर सेट करें, जबकि पहलू अनुपात को बनाए रखते हुए।
- या **ScaleType.None** विकल्प के साथ स्वचालित स्केलिंग को अक्षम करें।

नीचे दिए गए कोड नमूने में उपयोग में स्वचालित स्केलिंग विकल्प दिखाया गया है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **पृष्ठभूमि और चित्रण रंग सेट करना**
डिफ़ॉल्ट रूप से, परिणामी कैनवास के लिए रंग पैलेट सामान्य दस्तावेज़ योजना पर सेट होता है। इसका मतलब है कि CAD आरेख के सभी संस्थान एक ठोस सफेद पृष्ठभूमि पर काले रंग के पेन के साथ खींचे जाते हैं। इन सेटिंग्स को **CadRasterizationOptions.BackgroundColor** और **CadRasterizationOptions.DrawColor** गुणों के साथ बदला जा सकता है। **CadRasterizationOptions.DrawColor** गुण को बदलने के लिए, ड्राइंग रंग का उपयोग करने के लिए **CadRasterizationOptions.DrawType** गुण को भी सेट करना आवश्यक है। **CadRasterizationOptions.DrawType** प्रॉपर्टी नियंत्रित करती है कि CAD संस्थान अपने रंगों को बनाए रखते हैं या कस्टम रंगों में परिवर्तित होते हैं। संस्थान के रंगों को बनाए रखने के लिए, **CadRasterizationOptions.DrawType** को **CadDrawTypeMode.UseObjectColor** के रूप में निर्दिष्ट करें, अन्यथा **CadDrawTypeMode.UseDrawColor** मान निर्दिष्ट करें।

नीचे दिए गए कोड नमूने में विभिन्न रंग गुणों का उपयोग करने का तरीका दिखाया गया है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **ऑटो लेआउट स्केलिंग सेट करना**
अधिकांश CAD आरेखों में एकल फ़ाइल में संगृहीत एक से अधिक लेआउट होते हैं, और प्रत्येक लेआउट में विभिन्न आयाम हो सकते हैं। PDF में ऐसे CAD आरेखों को रेंडर करते समय, PDF के प्रत्येक पृष्ठ का विभिन्न आकार के अनुसार स्केलिंग हो सकती है। रेंडरिंग को सामान्य बनाने के लिए, Aspose.CAD APIs ने **CadRasterizationOptions.AutomaticLayoutsScaling** गुण का पता लगाया है। इसका डिफ़ॉल्ट मान **false** है लेकिन जब true किया गया, तो API प्रत्येक अलग लेआउट के लिए एक संबंधित स्केल खोजने के लिए प्रयास करेगी और उन्हें पृष्ठ के आकार के अनुसार स्वचालित पुन: आकार ऑपरेशन करने के द्वारा संबंधित तरीके से बनाएगी।

यहाँ पर **CadRasterizationOptions.AutomaticLayoutsScaling** प्रॉपर्टी और **CadRasterizationOptions.ScaleMethod** प्रॉपर्टी के सहयोग से कैसे काम करता है।

1. यदि **ScaleMethod** को **ScaleType.ShrinkToFit** या **ScaleType.GrowToFit** पर **AutomaticLayoutsScaling** के साथ false सेट किया गया है, तो सभी लेआउट (मॉडल सहित) को पहले विकल्प के अनुसार संसाधित किया जाएगा।
2. यदि **ScaleMethod** को **ScaleType.ShrinkToFit** या **ScaleType.GrowToFit** पर **AutomaticLayoutsScaling** के साथ true सेट किया गया है, तो सभी लेआउट (मॉडल को छोड़कर) उनके आकार के अनुसार संसाधित किए जाएंगे जबकि मॉडल को पहले विकल्प के अनुसार संसाधित किया जाएगा।
3. यदि **ScaleMethod** को **ScaleType.None** पर **AutomaticLayoutsScaling** के साथ true या false पर सेट किया गया है, तो कोई स्केलिंग नहीं की जाएगी।

नीचे दिए गए कोड नमूने में CAD से PDF कन्वर्शन के लिए स्वचालित लेआउट स्केलिंग सेट करने का तरीका दिखाया गया है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **CAD लेआउट को रास्टर छवि प्रारूपों में परिवर्तित करना**
Aspose.CAD for Java API को समर्थित प्रारूपों जैसे DXF और DWG के CAD लेआउट को PNG, BMP, TIFF, JPEG और GIF जैसी रास्टर छवियों में परिवर्तित करने की क्षमता है। API यह भी प्रदान करता है कि CAD आरेख के विशिष्ट लेआउट को विभिन्न PSD परतों में रेंडर किया जा सके। 
Aspose.CAD for Java API ने आवश्यक CAD लेआउटों की सूची निर्दिष्ट करने और उन्हें रास्टर छवि प्रारूपों में रेंडर करने के लिए प्रभावी और उपयोग में आसान तरीके उपलब्ध कराए हैं। यहाँ 5 सरल चरणों में आप ऐसा कर सकते हैं, जैसा कि नीचे सूचीबद्ध है।

1. CAD फ़ाइल को **Image** के एक उदाहरण में लोड करें, जो फ़ैक्टरी विधि **load** का उपयोग करके बनाई गई है।
1. **CadRasterizationOptions** का एक उदाहरण बनाएं और इसके अनिवार्य गुणों जैसे **PageWidth** और **PageHeight** को सेट करें।
1. CadRasterizationOptions.Layouts गुण का उपयोग करके इच्छित लेआउट नाम(ओं) को निर्दिष्ट करें।
1. **ImageOptionsBase** का एक उदाहरण बनाएं और उसके **VectorRasterizationOptions** गुण को पिछले चरण में बनाए गए **CadRasterizationOptions** के उदाहरण पर सेट करें।
1. फ़ाइल पथ (या मेमोरी स्ट्रीम के एक ऑब्जेक्ट) और पिछले चरण में बनाए गए **ImageOptionsBase** के उदाहरण को पास करके **Image.Save** को कॉल करें।

यहां संपूर्ण स्रोत कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

**CadRasterizationOptions.Layouts** गुण स्ट्रिंग एरे का प्रकार है, इसलिए आप छवि प्रारूपों में संभावित रूपांतरण के लिए एक समय में एक से अधिक लेआउट निर्दिष्ट कर सकते हैं। **CadRasterizationOptions.Layouts** गुण के लिए कई लेआउट निर्दिष्ट करते समय, परिणामी TIFF छवि में कई पृष्ठ होंगे, GIF छवि में कई फ्रेम होंगे और PSD प्रारूप में कई परतें होंगी, जहां प्रत्येक पृष्ठ/फ्रेम/परत एक व्यक्तिगत AutoCAD लेआउट का प्रतिनिधित्व करता है। यदि किसी अन्य छवि प्रारूप जैसे PNG, BMP, JPEG का चयन किया जाता है तो परिणाम केवल डिफ़ॉल्ट लेआउट के रूप में रेंडर होगा; अर्थात "मॉडल"।

{{% /alert %}} 
## **CAD रेंडरिंग प्रक्रिया के लिए ट्रैकिंग सक्षम करना**
Aspose.CAD ने CAD रेंडरिंग प्रक्रिया के ट्रैकिंग में मदद करने के लिए कई वर्गों और समर्थित गणना फ़ील्डों की श्रृंखला पेश की है। इन परिवर्तनों के साथ, CAD से PDF रूपांतरण अब ट्रैकिंग को सक्षम करते हुए निम्न रूप में किया जा सकता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



CAD रेंडरिंग प्रक्रिया की ट्रैकिंग निम्नलिखित संभावित समस्याओं का पता लगा सकती है।

1. अनुपस्थित या भ्रष्ट शीर्षक जानकारी।
2. अनुपस्थित लेआउट जानकारी।
3. अनुपस्थित ब्लॉक संस्थाएँ।
4. अनुपस्थित माप प्रारूप।
5. अनुपस्थित शैलियाँ।
## **CAD आरेखों को परिवर्तित करते समय फ़ॉन्ट बदलना**
यह संभव है कि एक विशेष CAD आरेख कुछ विशिष्ट फ़ॉन्ट का उपयोग करे जो उस मशीन पर उपलब्ध न हो जहां CAD से PDF या CAD से रास्टर छवि का रूपांतरण हो रहा है। ऐसी स्थितियों में, Aspose.CAD API किसी भी गायब फ़ॉन्ट को उजागर करने और रूपांतरण प्रक्रिया को रोकने के लिए एक उचित अपवाद उत्पन्न करेगा क्योंकि API को परिणामी PDF और/या छवियों पर सामग्री को सही तरीके से रेंडर करने के लिए इन फ़ॉन्टों की आवश्यकता होती है।
Aspose.CAD API आवश्यक फ़ॉन्टों को उपलब्ध फ़ॉन्टों के साथ प्रतिस्थापित करने के तंत्र का उपयोग करने का एक आसान तरीका प्रदान करता है। **CadImage.Styles** गुण **CadStylesDictionary** का एक उदाहरण लौटाता है जिसे बदले में CAD आरेख में प्रत्येक शैली के लिए **CadStyleTableObject** शामिल करता है, जबकि **CadStyleTableObject.PrimaryFontName** का उपयोग उपलब्ध फ़ॉन्ट नाम निर्दिष्ट करने के लिए किया जा सकता है।

निम्नलिखित कोड स्निपेट Aspose.CAD for Java API का उपयोग करके CAD आरेख में सभी शैलियों के फ़ॉन्ट को बदलने का उपयोग दर्शाता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




यह केवल एक विशिष्ट शैली के फ़ॉन्ट को उसके शैली नाम के माध्यम से पहुँचाकर बदलने के लिए भी संभव है। निम्नलिखित कोड स्निपेट इस दृष्टिकोण के उपयोग को दर्शाता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **CAD परतों को रास्टर छवि प्रारूपों में परिवर्तित करना**
Aspose.CAD for Java API ने आवश्यक CAD परत के नाम को निर्दिष्ट करने और उसे रास्टर छवि प्रारूपों में रेंडर करने के लिए एक प्रभावशाली और उपयोग में आसान तरीका उपलब्ध कराया है। यहाँ, आप 5 सरल चरणों में ऐसा कर सकते हैं, जैसा कि नीचे सूचीबद्ध है।

1. CAD फ़ाइल को **Image** के एक उदाहरण में लोड करें, जो फ़ैक्टरी विधि **load** का उपयोग करके बनाई गई है।
1. **CadRasterizationOptions** का एक उदाहरण बनाएं और इसके अनिवार्य गुणों जैसे **PageWidth** और **PageHeight** को सेट करें।
1. **CadRasterizationOptions.Layers.add** विधि का उपयोग करके इच्छित परत का नाम जोड़ें।
1. **ImageOptionsBase** का एक उदाहरण बनाएं और उसके **VectorRasterizationOptions** गुण को पिछले चरण में बनाए गए **CadRasterizationOptions** के उदाहरण पर सेट करें।
1. फ़ाइल पथ (या मेमोरी स्ट्रीम के एक ऑब्जेक्ट) और पिछले चरण में बनाए गए **ImageOptionsBase** के उदाहरण को पास करके **Image.save** विधि को कॉल करें।

यहां संपूर्ण स्रोत कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **सभी CAD परतों को अलग छवियों में परिवर्तित करना**
आप **CadImage.Layers** का उपयोग करके CAD आरेख से सभी परतों को प्राप्त कर सकते हैं और प्रत्येक परत को अलग छवि में रेंडर कर सकते हैं, जैसा कि नीचे दर्शाया गया है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **DWF CAD परतों को रास्टर छवि प्रारूपों में परिवर्तित करना**
Aspose.CAD for Java API ने आवश्यक CAD परत के नाम को निर्दिष्ट करने और उसे रास्टर छवि प्रारूपों में रेंडर करने के लिए एक प्रभावशाली और उपयोग में आसान तरीका उपलब्ध कराया है। यहाँ, आप 5 सरल चरणों में ऐसा कर सकते हैं, जैसा कि नीचे सूचीबद्ध है।

1. DWF CAD फ़ाइल को **Image** के एक उदाहरण में लोड करें, जो फ़ैक्टरी विधि **Load** का उपयोग करके बनाई गई है।
1. **CadRasterizationOptions** का एक उदाहरण बनाएं और इसके अनिवार्य गुणों जैसे **PageWidth** और **PageHeight** को सेट करें।
1. **CadRasterizationOptions.Layers.Add** विधि का उपयोग करके इच्छित परत का नाम जोड़ें।
1. **ImageOptionsBase** का एक उदाहरण बनाएं और उसके **VectorRasterizationOptions** गुण को पिछले चरण में बनाए गए **CadRasterizationOptions** के उदाहरण पर सेट करें।
1. फ़ाइल पथ (या मेमोरी स्ट्रीम के एक ऑब्जेक्ट) और पिछले चरण में बनाए गए **ImageOptionsBase** के उदाहरण को पास करके **Image.Save** विधि को कॉल करें।

यहां संपूर्ण स्रोत कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
