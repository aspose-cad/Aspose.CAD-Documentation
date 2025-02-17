---
title: सहेजने पर समय सीमा सेट करें
type: docs
weight: 70
url: /hi/java/developer-guide/set-timeout-on-save/
---

## **सहेजने पर समय सीमा सेट करें**

Aspose.CAD for Java API आपको सहेजने पर एक समय सीमा सेट करने की अनुमति देती है। यह उन मामलों में सहायक हो सकता है जहां सहेजने की प्रक्रिया बहुत समय ले रही है या बहुत अधिक मेमोरी का उपभोग कर रही है। इसके लिए, API [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) क्लास प्रदान करती है। [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) क्लास एक टोकन प्रदान करती है जिसका उपयोग लंबे समय तक चलने वाले ऑपरेशनों को बाधित करने के लिए किया जाता है।

## नमूना कोड

निम्नलिखित कोड टुकड़ा [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) क्लास के उपयोग को प्रदर्शित करता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
