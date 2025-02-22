---
title: मीटर्ड लाइसेंसिंग
type: docs
weight: 60
url: /hi/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD डेवलपर्स को मीटर्ड कुंजी लागू करने की अनुमति देता है। यह एक नया लाइसेंसिंग तंत्र है। नए लाइसेंसिंग तंत्र का उपयोग मौजूदा लाइसेंसिंग विधि के साथ किया जाएगा। वे ग्राहक जो API फीचर्स के उपयोग के आधार पर बिल किए जाना चाहते हैं, वे मीटर्ड लाइसेंसिंग का उपयोग कर सकते हैं। अधिक विवरण के लिए कृपया [मीटर्ड लाइसेंसिंग सामान्य प्रश्न](https://purchase.aspose.com/faqs/licensing/metered) अनुभाग को देखें।

{{% /alert %}} 
## **मीटर्ड लाइसेंसिंग**
मीटर्ड क्लास का उपयोग करने के लिए यहां सरल चरण दिए गए हैं।

1. मीटर्ड क्लास का एक उदाहरण बनाएं।
1. SetMeteredKey विधि में सार्वजनिक और निजी कुंजियाँ पास करें।
1. प्रक्रिया करें (कार्य करें)।
1. मीटर्ड क्लास की GetConsumptionQuantity विधि को कॉल करें।
1. यह API अनुरोधों की मात्रा/संख्या को लौटाएगा जो आपने अब तक उपभोग की है।

निम्नलिखित नमूना कोड दर्शाता है कि कैसे मीटर्ड सार्वजनिक और निजी कुंजी सेट करें।

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
