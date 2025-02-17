---
title: नए जोड़े गए स्तरों के साथ सम्मिलनों का रंगाई
type: docs
weight: 23
url: /hi/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **नए जोड़े गए स्तरों के साथ सम्मिलनों का रंगाई कैसे करें (CADNET-1146)**

**समस्या:** नए जोड़े गए स्तरों के साथ सम्मिलनों का रंगाई कैसे करें (CADNET-1146)।

**टिप्स:** इसके लिए, CadLayerTable क्लास का उपयोग करें ताकि एक स्तर बनाया जा सके जिससे आप चित्रण में नया स्तर जोड़ सकें, आप कई स्तरों को जोड़ने के लिए CadLayersList का भी उपयोग कर सकते हैं।

**उदाहरण:**

{{% alert color="primary" %}}

प्रारंभिक फ़ाइल में "1", "2", "3", "4" और "5" नाम के 5 सम्मिलन हैं और ये सभी डिफ़ॉल्ट 0 स्तर में हैं।

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
