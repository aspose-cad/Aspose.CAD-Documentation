---
title: मौजूदा श्रृंखलाओं के दाईं ओर नए TEXT/MTEXT इकाइयां जोड़ें 
type: docs
weight: 17
url: /hi/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **मौजूदा श्रृंखलाओं के दाईं ओर नए TEXT/MTEXT इकाइयां जोड़ने का तरीका**

**समस्या:** मौजूदा श्रृंखलाओं के दाईं ओर नए TEXT/MTEXT इकाइयां कैसे जोड़ें (CADNET-8172)।

**टिप्स:** ऐसा करने के लिए, एक CadBaseEntity वस्तु बनाएं, CadMText या CadText को टेक्स्ट के साथ बनाएं, नए वस्तु में SoftOwner फ़ील्ड में cadImage.Layouts["Model"].BlockTableRecordHandle को ड्राइंग से जोड़ें और इसे cadImage.BlockEntities[" *MODEL_SPACE"] ब्लॉक में जोड़ें और नई वस्तु को ड्राइंग इकाइयों में जोड़ें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
