---
title: Licensing
type: docs
weight: 50
url: /net/getting-started/licensing/
---

{{% alert color="primary" %}}

Once you are happy with your evaluation of Aspose.CAD for .NET, buy a license at the Aspose website: [Purchase Portal](https://purchase.aspose.com/buy). Make yourself familiar with the different license types available. If you have any questions, [contact the Aspose sales team](https://about.aspose.com/contact) and they'll be happy to help you.

Every Aspose license carries a one-year subscription for free upgrades to any new versions or fixes that come out during this time. We provide free and unlimited technical support to both licensed and evaluation users.

The license is a plain text XML file that contains details such as the product name, number of licensed developers, subscription expiry date and so on. The file is digitally signed, so do not modify the file: even adding an extra line break to the file invalidates it.

{{% /alert %}}

## **When to Apply a License**

Follow these simple rules:

- The license only needs to be set once per application domain.
- You need to set the license before using any other Aspose.CAD classes.
- Calling SetLicense multiple times is not harmful, but wastes processor time.
- If you are developing a Windows Forms or console application, call SetLicense in the startup code, before using Aspose.CAD classes.
- When developing an ASP.NET application, call SetLicense from the Global.asax.cs (Global.asax.vb) file, in the Application_Start protected method. It is called once when the application starts.
- Do not call SetLicense from within the Page_Load methods since it means the license will be loaded every time a web page is loaded.
- If you are developing a class library, you call SetLicense from a static constructor of the class that uses Aspose.CAD. The static constructor executes before an instance of your class is created making sure Aspose.CAD license is properly set.

## **Apply License using File or Stream Object**

Use the **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** method to license the component. The easiest way to set a license is to put the license file in the same folder as the Aspose.CAD.dll and specify the filename, without a path, as shown below.

### **Loading a License from File**

This code snippet initialize a license stored in a file or in an embedded resource.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Loading a License from a Stream Object**

This code snippet initialize the license from stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
