---
title: Aspose.CAD के कैशिंग व्यवहार की व्याख्या
type: docs
weight: 20
url: /hi/common/caching-behaviour-explanation/
---


## **Aspose.CAD डेटा को कैसे कैश करता है**

Aspose.CAD द्वारा किया गया सभी कैश पूरी तरह से स्वचालित है, बिना किसी उपयोगकर्ता इनपुट की आवश्यकता या संभावना के। मूलतः, तीन प्रकार के कैश हैं, जो सभी फ़ॉन्ट्स से संबंधित हैं।

### **फ़ॉन्ट नाम कैश**

फ़ॉन्ट नाम कैश का उपयोग तेज़ प्रारंभ को सक्षम बनाने के लिए किया जाता है, सभी पाए गए फ़ॉन्ट फ़ाइलों को पूर्व-प्रसंस्करण करके और इन फ़ाइलों में मौजूद फ़ॉन्ट नामों की सूची को संकलित करके, क्योंकि एक फ़ॉन्ट फ़ाइल में एक से अधिक फ़ॉन्ट हो सकते हैं। इसे एक अस्थायी फ़ाइल के रूप में संग्रहीत किया जाता है और यह अधिकांश प्रणालियों के लिए अधिकतम दस किलोबाइट आकार में होता है।

### **फ़ॉन्ट ग्लिफ डेटा कैश**

सभी ग्लिफ्स का एक इन-मेमोरी कैश जो एप्लिकेशन के जीवनकाल के दौरान उपयोग किए गए हैं ताकि अपेक्षित निर्यात के दौरान वास्तविक डिस्क पर फ़ॉन्ट फ़ाइलों को दोबारा पढ़ने से बचा जा सके। इस प्रकार, यदि आगामी निर्यात के दौरान फ़ाइलें नई फ़ॉन्ट्स का संदर्भ देती हैं और/या पहले सामना नहीं किए गए वर्णों को含क करती हैं, तो इससे लगातार मेमोरी खपत बढ़ने का परिणाम होगा। हालांकि, व्यवहार में, यहां तक कि पूरी 
Aspose.CAD की परीक्षण श्रृंखला में, जिसमें विभिन्न भाषाओं में फ़ाइलें शामिल हैं, इसकी मेमोरी खपत लगभग 200 मेगाबाइट्स है, जो एक आधुनिक प्रणाली के लिए बहुत महत्वपूर्ण नहीं है।

### **प्रति-अक्षर फ़ॉन्ट फॉलबैक कैश**

एक इन-मेमोरी कैश जो सभी यूनिकोड वर्णों के लिए दिए गए वर्ण को含क करने वाले फ़ॉन्ट्स को संग्रहीत करता है, ताकि किसी चित्रण में टेक्स्ट एंटिटी द्वारा आपूर्ति की जाने वाली फ़ॉन्ट में उस एंटिटी के टेक्स्ट सामग्री में कोई वर्ण न होने की स्थिति में एक प्रतिस्थापन फ़ॉन्ट का चयन करने में सहायता मिल सके। इसे एप्लिकेशन के जीवनकाल के दौरान पहले निर्यात ऑपरेशन पर बनाया जाता है और एप्लिकेशन समाप्त होने तक रहता है। हमारे अपेक्षाकृत विनम्र परीक्षण मशीनों पर विशाल फ़ॉन्ट संग्रह के साथ प्रयोग किया गया, कैश बनाने में लगभग 30 सेकंड लगते हैं और 70 मेगाबाइट जगह लेता है। एक बार बनने के बाद, इसे अब कोई समय नहीं लगता है और यह नहीं बढ़ता है।
