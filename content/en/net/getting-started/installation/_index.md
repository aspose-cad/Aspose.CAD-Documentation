---
title: Installation
type: docs
weight: 30
url: /net/installation/
---

## **Installing Aspose.CAD for .NET through NuGet**

NuGet is the easiest way to download and install Aspose APIs for .NET. Open Microsoft Visual Studio and NuGet package manager. Search "aspose" to find the desired Aspose API. Click on "Install", the selected API will be downloaded and referenced in your project.

![todo:image_alt_text](/_assets/installation_1.png)

## **Referencing Aspose.CAD from a .NET Project**

Follow these steps (assuming you use Microsoft Visual Studio):

1. In **Solution Explorer** , expand the project node to which you want to add a reference.
1. Right-click the **References** node for the project and select **Add Reference** from the shortcut menu.
1. In the **Add Reference** dialog box and browse to the DLL file location.
1. Select the *Aspose.CAD* DLL file and click the **OK** button.
1. The *Aspose.CAD* reference will appear under the **References** node of your project.

![todo:image_alt_text](/_assets/installation_2.png)

### **Install or Update Aspose.CAD using the Package Manager Console**

You can follow the steps below to reference the [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) using the package manager console:

1. Open your solution/project in Visual Studio.
1. Select Tools -> Library Package Manager -> Package Manager Console from the menu to open package manager console.

![todo:image_alt_text](/_assets/installation_3.png)

Type the command “**Install-Package Aspose.CAD**” and press enter to install latest full release into your application. Alternatively you can add the "**-prerelease**" suffix to the command in order to specify that the latest release including hot fixes is to be installed as well.

![todo:image_alt_text](/_assets/installation_4.png)

You will see that the "Downloading Aspose.CAD..." tip appears down the bottom left of the window indicating that the download is process. 

![todo:image_alt_text](/_assets/installation_5.png)

Once downloaded you will see the following confirmation messages. If you are not familiar with the [Aspose EULA](https://about.aspose.com/legal/eula) then it is a good idea to read the license referenced in the URL.

![todo:image_alt_text](/_assets/installation_6.png)

You should now find that Aspose.CAD has successfully been added and referenced in your application for you.

![todo:image_alt_text](/_assets/installation_7.png)

In the package manager console, you can also use the command “**Update-Package Aspose.CAD**” and press enter to check for any updates to the Aspose.CAD package and install them if present. You can also add the "-prerelease" suffix to update latest release.

## **Considerations When Running on a Shared Server Environment**

All Aspose .NET components are recommended to run with Full Trust permission set. This is because Aspose .NET component sometimes need to access registry settings and files located in places other than the virtual directory e.g. for reading fonts etc. Furthermore, Aspose.NET components are based on core .NET system classes, some of which also require Full Trust permission to run in some cases.

Internet Service Providers hosting multiple applications from different companies mostly enforce Medium Trust security level. In the case of .NET 2.0, such a security level may set the following constraints which could affect the ability of Aspose.CAD to perform properly.

- **RegistryPermission** is not available. This means you cannot access the registry, which is required to enumerate installed fonts when rendering documents.
- **FileIOPermission** is restricted. This means you can only access files in your application’s virtual directory hierarchy. This potentially means fonts cannot be read during export.

For these reasons specified above, it is recommended that Aspose.CAD is run on Full Trust permissions. You may find that some features of library will work when performing different tasks in Medium trust while some won't (rendering for example) which may due to calls to GDI+ image processing.

## **System Requirements**

### **Operating Systems**

Aspose.CAD for .NET supports any 32-bit or 64-bit operating system where .NET or Mono framework is installed including, but not limited to:

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) and server operating systems (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS and others)
- Mac OS X

### **Frameworks**

Aspose.CAD for .NET supports:

- .NET Framework versions from 2.0 to 4.5 including Client Profile versions
- .NET Core
- Mono 2.6.7 or later

### **Development Environments**

You can use Aspose.CAD for .NET to develop applications in any development environment that targets the .NET platform, but the following environments are explicitly supported:

- Microsoft Visual Studio 2010 or Higher
- MonoDevelop 2.4 and later
