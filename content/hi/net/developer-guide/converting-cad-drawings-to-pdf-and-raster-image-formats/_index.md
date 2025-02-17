---
title: DWG DXF से PDF C# | ऑटो CAD फ़ाइलों को PDF JPEG PNG में C# .NET में परिवर्तित करें
type: docs
weight: 30
url: /hi/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG से PDF C#, DXF से PDF C#, DWF DWT से PDF C#, ऑटोCAD को परिवर्तित करें, DWG को परिवर्तित करें, DWF को परिवर्तित करें, DWT को परिवर्तित करें, DXF को परिवर्तित करें, ऑटोकैड को PDF में परिवर्तित करें, DWG को PDF में परिवर्तित करें, DWG को PNG में परिवर्तित करें, DWG को TIFF में परिवर्तित करें, DWG को JPG में परिवर्तित करें"
description: C# .NET ऑटोकैड से PDF कनवर्टर का उपयोग करें DWG या DXF को C# में PDF में परिवर्तित करने के लिए। आप C# .NET में DWG, DWF, DWT और DXF को PDF, JPEG, PNG, BMP, GIF और TIFF में परिवर्तित कर सकते हैं।
---

## **C# में DWG या DXF को PNG JPEG BMP GIF या TIFF में परिवर्तित करें**

Aspose.CAD for .NET ऑटोकैड ड्राइंग फ़ॉर्मेट जैसे [DXF](https://docs.fileformat.com/cad/dxf/) और [DWG](https://docs.fileformat.com/cad/dwg/) को [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) और [GIF](https://docs.fileformat.com/image/gif/) में परिवर्तित कर सकता है। इस लक्ष्य को प्राप्त करने के लिए इसमें कुशल और उपयोग में आसान एपीआई है।

आप सरल चरणों का उपयोग करके किसी भी समर्थित ऑटोकैड ड्राइंग फ़ॉर्मेट को रास्टर इमेज फ़ॉर्मेट में परिवर्तित कर सकते हैं जैसे कि नीचे विस्तृत किया गया है।

1. ऑटोकैड DWG या DXF फ़ाइल को [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) क्लास में लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) का एक उदाहरण बनाएं।
1. [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) का उपयोग करके इमेज का आकार सेट/बदलें
1. [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) का एक उदाहरण बनाएं
1. पिछले चरण में बनाए गए [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) को [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) प्रॉपर्टी पर सेट करें।
1. फ़ाइल पथ (या MemoryStream का एक ऑब्जेक्ट) और पिछले चरण में बनाए गए [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) के उदाहरण को पास करके [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) द्वारा ऑटोकैड ड्राइंग को PDF के रूप में सहेजें।

यहां पूरा स्रोत कोड है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

डिफ़ॉल्ट रूप से, एपीआई केवल "Model" लेआउट को प्रस्तुत करती है। हालाँकि, आप CAD चित्रों को चित्र फ़ॉर्मेट में परिवर्तित करते समय अपनी पसंद के लेआउट भी निर्दिष्ट कर सकते हैं।

## **CAD रूपांतरण को अनुकूलित करना**

CAD से [PDF](https://docs.fileformat.com/pdf/) और CAD से रास्टर इमेज रूपांतरण प्रक्रियाएँ अत्यधिक कॉन्फ़िगेबल हैं क्योंकि [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) क्लास इस तरीके से लागू की गई है कि यह कई वैकल्पिक विशेषताएँ प्रदान करती है जो सेट करने पर एप्लिकेशन की आवश्यकताओं के अनुसार रेंडरिंग प्रक्रिया को ओवरराइड कर सकती हैं।

### **CadRasterizationOptions क्लास**

**CadRasterizationOptions** क्लास सभी समर्थित CAD फ़ॉर्मेट जैसे DWG और DXF के लिए सामान्य है इसलिए इस लेख में साझा की गई जानकारी दोनों उपरोक्त CAD फ़ॉर्मेट के लिए मान्य है।

सबसे उपयोगी **CadRasterizationOptions** क्लास प्रॉपर्टीज हैं:

|**Property**|**Default Value**|**Required**|**Description**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|हाँ|पृष्ठ की चौड़ाई निर्दिष्ट करता है।|
|**PageHeight**|**0**|हाँ|पृष्ठ की ऊँचाई निर्दिष्ट करता है|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|नहीं|निर्दिष्ट करता है कि इमेज को स्वचालित रूप से स्केल किया जाना चाहिए या नहीं। डिफ़ॉल्ट मान स्वचालित रूप से इमेज को कैनवास के आकार में समायोजित करने के लिए छोटा करता है। **GrowToFit** मोड पर स्विच करें, या स्वचालित स्केलिंग को अक्षम करने के लिए **None** सेटिंग का उपयोग करें।|
|**BackgroundColor**|**Color.White**|नहीं|निष्कर्षित इमेज के बैकग्राउंड रंग को निर्दिष्ट करता है।|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|नहीं|कलाकृति के रंगाई मोड को निर्दिष्ट करता है। स्वदेशी रंग का उपयोग करके कलाकृतियों को खींचने के लिए **UseObjectColor** विकल्प निर्दिष्ट करें, या स्वदेशी रंगों को ओवरराइड करने के लिए **UseDrawColor** विकल्प निर्दिष्ट करें।|
|**DrawColor**|**Color.Black**|नहीं|ओवरराइड की गई कलाकृति के रंग को निर्दिष्ट करता है (केवल अगर **DrawType** को **UseDrawColor** प्रॉपर्टी मान पर सेट किया गया हो)।|
|**AutomaticLayoutsScaling**|False|नहीं|निर्दिष्ट करता है कि ऑटो-लेआउट स्केलिंग को मॉडल लेआउट से मेल खाने के लिए प्रदर्शन करना चाहिए।|

### **कैनवास आकार और मोड सेट करना**

CAD से PDF या CAD से रास्टर इमेज फ़ॉर्मेट में निर्यात करना कोई तुच्छ कार्य नहीं है। चूंकि परिणामस्वरूप PDF या इमेज के लिए कैनवास के आकार की आवश्यकता होती है, हमें ड्राइंग को ठीक से प्रस्तुत करने के लिए PDF पृष्ठ के लिए आउटपुट आयामों को निर्दिष्ट करने की आवश्यकता होती है। **CadRasterizationOptions.PageWidth** और **CadRasterizationOptions.PageHeight** प्रॉपर्टीज को स्पष्ट रूप से सेट करें, अन्यथा आपको **ImageSaveException** मिल सकती है।

अतिरिक्त रूप से, आप मात्रा मापन विकल्पों को निर्दिष्ट कर सकते हैं। मापन विकल्प **CadRasterizationOptions.ScaleMethod** प्रॉपर्टी द्वारा सेट किए जाते हैं। इस विकल्प का उपयोग करके इमेज के आयामों को **CadRasterizationOptions.PageWidth** और **CadRasterizationOptions.PageHeight** मानों के अनुसार स्वचालित रूप से समायोजित करें। डिफ़ॉल्ट रूप से **CadRasterizationOptions.ScaleMethod** को **ScaleType.ShrinkToFit** मोड पर सेट किया गया है। यह प्रॉपर्टी निम्नलिखित व्यवहार को परिभाषित करती है:

- यदि CAD ड्राइंग के आयाम परिणामस्वरूप कैनवास के आकार से बड़े हैं, तो ड्राइंग के आयामों को परिणामस्वरूप कैनवास में समायोजित करने के लिए अनुपात बनाए रखते हुए कम किया जाता है।
- यदि CAD ड्राइंग के आयाम परिणामस्वरूप कैनवास के आकार से छोटे हैं, तो **CadRasterizationOptions.ScaleMethod** प्रॉपर्टी को **ScaleType.GrowToFit** पर सेट करें ताकि ड्राइंग के आकार को PDF कैनवास में समायोजित करते समय अनुपात बनाए रखा जा सके।
- या स्वचालित स्केलिंग को **ScaleType.None** विकल्प के साथ अक्षम करें।

नीचे दिए गए कोड सैंपल में ऑटो-स्केलिंग विकल्प का उपयोग दिखाया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **बैकग्राउंड और ड्राइंग रंग सेट करना**

डिफ़ॉल्ट रूप से, परिणामस्वरूप कैनवास के लिए रंग पैलेट को सामान्य दस्तावेज़ योजना पर सेट किया गया है। इसका मतलब है कि CAD ड्राइंग के भीतर सभी कलाकृतियों को एक ठोस सफेद पृष्ठभूमि पर काले रंग की कलम से खींचा गया है। इन सेटिंग्स को **CadRasterizationOptions.BackgroundColor** और **CadRasterizationOptions.DrawColor** प्रॉपर्टीज के साथ बदला जा सकता है। **CadRasterizationOptions.DrawColor** प्रॉपर्टी को बदलने के लिए **CadRasterizationOptions.DrawType** प्रॉपर्टी को सेट करना भी आवश्यक है ताकि ड्राइंग रंग का उपयोग किया जा सके। **CadRasterizationOptions.DrawType** प्रॉपर्टी नियंत्रित करती है कि क्या CAD कलाकृतियाँ अपने रंगों को बनाए रखती हैं या कस्टम रंगों में परिवर्तित की जाती हैं। कलाकृति रंगों को बनाए रखने के लिए, **CadRasterizationOptions.DrawType** को **CadDrawTypeMode.UseObjectColor** के रूप में निर्दिष्ट करें, अन्यथा **CadDrawTypeMode.UseDrawColor** मूल्य निर्दिष्ट करें।

नीचे दिए गए कोड सैंपल में विभिन्न रंग प्रॉपर्टीज का उपयोग कैसे करें यह दिखाया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **ऑटो लेआउट स्केलिंग सेट करना**

ज्यादातर CAD ड्राइंग में एक ही फ़ाइल में एक से अधिक लेआउट होते हैं, और प्रत्येक लेआउट के अलग-अलग आयाम हो सकते हैं। ऐसे CAD ड्रॉइंग को PDF में प्रस्तुत करते समय, PDF के प्रत्येक पृष्ठ के लिए आयाम के आकार के अनुसार अलग-अलग स्केलिंग हो सकती है। प्रस्तुतिकरण को समरूप बनाने के लिए, Aspose.CAD APIs ने **CadRasterizationOptions.AutomaticLayoutsScaling** प्रॉपर्टी को पेश किया है। इसका डिफ़ॉल्ट मान **false** है लेकिन जब true हो, तो एपीआई एक एकल लेआउट के लिए संबंधित स्केल के लिए खोजेगी और स्वचालित पुनः आकार संचालन के अनुसार उन्हें प्रस्तुत करेगी।

यहां बताया गया है कि **CadRasterizationOptions.AutomaticLayoutsScaling** प्रॉपर्टी **CadRasterizationOptions.ScaleMethod** प्रॉपर्टी के साथ सहयोग में कैसे काम करती है।

1. यदि **ScaleMethod** को **ScaleType.ShrinkToFit** या **ScaleType.GrowToFit** पर सेट किया गया है और **AutomaticLayoutsScaling** को false पर सेट किया गया है तो सभी लेआउट (मॉडल सहित) पहले विकल्प के अनुसार संसाधित किए जाएंगे।
1. यदि **ScaleMethod** को **ScaleType.ShrinkToFit** या **ScaleType.GrowToFit** पर सेट किया गया है और **AutomaticLayoutsScaling** को true पर सेट किया गया है तो सभी लेआउट (मॉडल को छोड़कर) उनके आकार के अनुसार संसाधित किए जाएंगे जबकि मॉडल को पहले विकल्प के अनुसार संसाधित किया जाएगा।
1. यदि **ScaleMethod** को **ScaleType.None** पर सेट किया गया है और **AutomaticLayoutsScaling** को true या false पर सेट किया गया है, तो कोई स्केलिंग नहीं की जाएगी।

नीचे दिए गए कोड सैंपल में CAD से PDF रूपांतरण के लिए ऑटो लेआउट स्केलिंग को सेट करने का तरीका दिखाया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **C# में ऑटोकैड DXF या DWG लेआउट को PNG या अन्य इमेज फ़ॉर्मेट्स में परिवर्तित करें**

Aspose.CAD for .NET API DXF और DWG जैसे समर्थित फ़ॉर्मेट के CAD लेआउट को PNG BMP TIFF JPEG और GIF में परिवर्तित कर सकता है। API CAD ड्राइंग के विशिष्ट लेआउट को विभिन्न PSD परतों में प्रस्तुत करने का समर्थन भी प्रदान करता है।

समान प्राप्त करने के लिए आप निम्नलिखित सरल चरणों का उपयोग कर सकते हैं।

- **Image** क्लास का उपयोग करके ऑटोकैड DWG या DXF फ़ाइल को लोड करें।
- इमेज की चौड़ाई और ऊँचाई सेट/बदलें।
- CadRasterizationOptions.Layouts प्रॉपर्टी का उपयोग करके वांछित लेआउट का नाम सेट करें।
- **ImageOptionsBase** का एक उदाहरण बनाएं और उसकी **VectorRasterizationOptions** प्रॉपर्टी को पिछले चरण में बनाए गए **CadRasterizationOptions** के उदाहरण पर सेट करें।
- CAD लेआउट को TIFF या इमेज के रूप में सहेजें।

यहां पूरा स्रोत कोड है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

**CadRasterizationOptions.Layouts** प्रॉपर्टी string array के प्रकार की है इसलिए आप इमेज फ़ॉर्मेट में संभावित परिवर्तनों के लिए एक बार में एक से अधिक लेआउट निर्दिष्ट कर सकते हैं। **CadRasterizationOptions.Layouts** प्रॉपर्टी के लिए कई लेआउट निर्दिष्ट करते समय, परिणामस्वरूप TIFF इमेज में कई पृष्ठ होंगे, GIF इमेज में कई फ्रेम होंगे और [PSD](https://docs.fileformat.com/image/psd/) फ़ॉर्मेट में कई परतें होंगी, जहाँ प्रत्येक पृष्ठ/फ्रेम/परत एक व्यक्ति ऑटोकैड लेआउट का प्रतिनिधित्व करती है। यदि किसी अन्य इमेज फ़ॉर्मेट जैसे PNG, BMP, JPEG को परिणाम को स्टोर करने के लिए चुना जाता है तो एपीआई केवल डिफ़ॉल्ट लेआउट को प्रस्तुत करेगी; अर्थात "Model"।

{{% /alert %}}

## **CAD रेंडरिंग प्रक्रिया के लिए ट्रैकिंग सक्षम करना**

Aspose.CAD ने CAD रेंडरिंग प्रक्रिया के ट्रैकिंग के लिए सहायता करने के लिए कई कक्षाएं और सहायता इन्ऍमरेशन प्रस्तुति क्षेत्र प्रस्तुत किए हैं। इन परिवर्तनों के साथ, CAD से PDF रूपांतरण अब ट्रैकिंग को सक्षम करते समय इस प्रकार प्राप्त किया जा सकता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

CAD रेंडरिंग प्रक्रिया की ट्रैकिंग संभावित समस्याओं का पता लगा सकती है।

1. गायब या भ्रष्ट हेडर जानकारी।
1. गायब लेआउट जानकारी।
1. गायब ब्लॉक कलाकृतियाँ।
1. गायब माप शैली।
1. गायब शैलियाँ।

## **CAD ड्राइंग को परिवर्तित करते समय फ़ॉन्ट का स्थानापन्न करना**

यह संभव है कि किसी विशेष CAD ड्राइंग में कुछ विशिष्ट फ़ॉन्ट का उपयोग किया गया हो जो सिस्टम पर उपलब्ध न हो जहाँ CAD से PDF या CAD से रास्टर इमेज रूपांतरण किया जा रहा है। ऐसी स्थितियों में, Aspose.CAD API गायब फ़ॉन्टों को उजागर करने के लिए एक उचित अपवाद का ट्रिगर करेगी और रूपांतरण प्रक्रिया को रोक देगी क्योंकि एपीआई को परिणामस्वरूप PDF या इमेज़ पर सामग्री को ठीक से प्रस्तुत करने के लिए इन फ़ॉन्टों की आवश्यकता होती है।

Aspose.CAD API आवश्यक फ़ॉन्टों को उपलब्ध फ़ॉन्टों के साथ प्रतिस्थापित करने हेतु तंत्र का उपयोग करना एक आसान तरीका प्रदान करता है। **CadImage.Styles** प्रॉपर्टी एक **CadStylesDictionary** का उदाहरण लौटाती है जो बदले में CAD ड्राइंग में प्रत्येक स्टाइल के लिए **CadStyleTableObject** को शामिल करती है, जबकि **CadStyleTableObject.PrimaryFontName** उपलब्ध फ़ॉन्ट नाम को निर्दिष्ट करने के लिए उपयोग किया जा सकता है।

नीचे दिए गए कोड स्निपेट में Aspose.CAD for .NET API का उपयोग कैसे करें यह प्रदर्शित किया गया है ताकि CAD ड्राइंग में सभी शैलियों के फ़ॉन्ट को बदला जा सके।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

सिर्फ एक विशेष शैली के फ़ॉन्ट को बदलना भी संभव है, जिसका उपयोग उसके शैली के नाम के माध्यम से किया जा सकता है। निम्नलिखित कोड स्निपेट इस दृष्टिकोण का उपयोग कैसे करें यह प्रदर्शित करता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **CAD परतों को रास्टर इमेज फ़ॉर्मेट में परिवर्तित करना**

Aspose.CAD for .NET API ने आवश्यक CAD परत का नाम निर्दिष्ट करने और उसे रास्टर इमेज फ़ॉर्मेट में प्रस्तुत करने के लिए एक कुशल और उपयोग में आसान साधन प्रदान किया है। यहां आप कुछ सरल चरणों में कैसे कर सकते हैं।

1. फ़ैक्टरी मेथड **Load** का उपयोग करके CAD फ़ाइल को **Image** के एक उदाहरण में लोड करें।
1. **CadRasterizationOptions** का एक उदाहरण बनाएं और इसकी अनिवार्य प्रॉपर्टीज जैसे **PageWidth** और **PageHeight** सेट करें।
1. **CadRasterizationOptions.Layers.Add** मेथड का उपयोग करके वांछित परत का नाम जोड़ें।
1. **ImageOptionsBase** का एक उदाहरण बनाएं और उसकी **VectorRasterizationOptions** प्रॉपर्टी को पिछले चरण में बनाए गए **CadRasterizationOptions** के उदाहरण पर सेट करें।
1. फ़ाइल पथ (या MemoryStream का एक ऑब्जेक्ट) और पिछले चरण में बनाए गए **ImageOptionsBase** के उदाहरण को पास करते हुए **Image.Save** मेथड को कॉल करें।

यहां पूरा स्रोत कोड है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **सभी CAD परतों को अलग इमेज में परिवर्तित करना**

आप **CadImage.Layers** का उपयोग करके CAD ड्राइंग से सभी परतों को प्राप्त कर सकते हैं और प्रत्येक परत को अलग इमेज में प्रस्तुत कर सकते हैं जैसा कि नीचे दिखाया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **DWF CAD परतों को रास्टर इमेज फ़ॉर्मेट में परिवर्तित करना**

Aspose.CAD for .NET API ने आवश्यक CAD परत का नाम निर्दिष्ट करने और उसे रास्टर इमेज फ़ॉर्मेट में प्रस्तुत करने के लिए एक कुशल और उपयोग में आसान साधन प्रदान किया है। यहां आप कुछ सरल चरणों में कैसे कर सकते हैं।

1. **Load** फ़ैक्टरी मेथड का उपयोग करके DWF CAD फ़ाइल को **Image** के एक उदाहरण में लोड करें।
1. **CadRasterizationOptions** का एक उदाहरण बनाएं और इसकी अनिवार्य प्रॉपर्टीज जैसे **PageWidth** और **PageHeight** सेट करें।
1. **CadRasterizationOptions.Layers.Add** मेथड का उपयोग करके वांछित परत का नाम जोड़ें।
1. **ImageOptionsBase** का एक उदाहरण बनाएं और उसकी **VectorRasterizationOptions** प्रॉपर्टी को पिछले चरण में बनाए गए **CadRasterizationOptions** के उदाहरण पर सेट करें।
1. फ़ाइल पथ (या MemoryStream का एक ऑब्जेक्ट) और पिछले चरण में बनाए गए **ImageOptionsBase** के उदाहरण को पास करते हुए **Image.Save** मेथड को कॉल करें।

यहां पूरा स्रोत कोड है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD for .NET सीधे आउटपुट दस्तावेज़ों में API और वर्ज़न नंबर के बारे में जानकारी लिखता है। उदाहरण के लिए, दस्तावेज़ को PDF में प्रस्तुत करते समय, Aspose.CAD for .NET एप्लीकेशन फ़ील्ड को 'Aspose.CAD' के मान से और PDF निर्माता फ़ील्ड को एक मान जैसे 'Aspose.CAD v 17.10' से भरता है।

कृपया ध्यान दें कि आप Aspose.CAD for .NET को आउटपुट दस्तावेज़ों से इस जानकारी को बदलने या हटाने के लिए बता नहीं सकते।
