---
title: Metered Licensing
type: docs
weight: 40
url: /python/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD allows developers to apply metered key. It is a new licensing mechanism. The new licensing mechanism will be used along with existing licensing method. Those customers who want to be billed based on the usage of the API features can use the metered licensing. For more details, please refer to [Metered Licensing FAQ](https://purchase.aspose.com/faqs/licensing/metered) section.

{{% /alert %}} 
## **Metered Licensing**
Here are the simple steps to use the Metered class.

1. Create an instance of Metered class.
1. Pass public & private keys to SetMeteredKey method.
1. Do processing (perform task).
1. call method GetConsumptionQuantity of the Metered class.
1. It will return the amount/quantity of API requests that you have consumed so far.

Following is the sample code demonstrating how to set metered public and private key.

import aspose.cad as cad

// Access the setMeteredKey property and pass public and private keys as parameters
Aspose.CAD.Metered.SetMeteredKey("PublicKey", "PrivateKey");


// Get metered data amount before calling API
amountbefore = cad.Metered.get_consumption_quantity()

// Display information
print("Amount Consumed Before: " + amountbefore.ToString());

// Do processing
image = cad.Image.load("file.dwg");

// Get metered data amount After calling API
amountafter = cad.Metered.get_consumption_quantity()

// Display information
print("Amount Consumed After: " + amountafter);

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
