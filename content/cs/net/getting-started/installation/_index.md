---
title: Instalace
type: docs
weight: 30
url: /cs/net/getting-started/installation/
---

## **Instalace Aspose.CAD pro .NET pomocí NuGet**

NuGet je nejjednodušší způsob, jak stáhnout a nainstalovat Aspose API pro .NET. Otevřete Microsoft Visual Studio a správce balíčků NuGet. Vyhledejte "aspose", abyste našli požadované Aspose API. Klepnutím na tlačítko "Instalovat" se vybrané API stáhne a bude odkazováno ve vašem projektu.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **Odkazování na Aspose.CAD z projektu .NET**

Postupujte podle těchto kroků (pokud používáte Microsoft Visual Studio):

1. V **Prohlížeči řešení** rozbalte uzel projektu, ke kterému chcete přidat odkaz.
1. Klikněte pravým tlačítkem na uzel **Odkazy** pro projekt a vyberte možnost **Přidat odkaz** z kontextového menu.
1. V dialogovém okně **Přidat odkaz** přejděte k umístění souboru DLL.
1. Vyberte soubor DLL *Aspose.CAD* a klepněte na tlačítko **OK**.
1. Odkaz *Aspose.CAD* se objeví pod uzlem **Odkazy** vašeho projektu.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **Instalace nebo Aktualizace Aspose.CAD pomocí konzole správce balíčků**

Následujte následující kroky pro odkazování na [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) pomocí konzole správce balíčků:

1. Otevřete vaše řešení/projekt v aplikaci Visual Studio.
1. Vyberte Nástroje -> Správce balíčků -> Konzole správce balíčků z menu pro otevření konzole správce balíčků.

![todo:image_alt_text](/_assets/install/installation_3.png)

Zadejte příkaz “**Install-Package Aspose.CAD**” a stiskněte enter pro instalaci nejnovější plné verze do vaší aplikace. Volitelně můžete k příkazu přidat sufix "**-prerelease**" pro specifikaci, že má být nainstalována také nejnovější verze včetně oprav chyb.

![todo:image_alt_text](/_assets/install/installation_4.png)

Uvidíte, že se zobrazí zpráva "Stahuji Aspose.CAD..." v levém spodním rohu okna, což naznačuje, že probíhá stahování. 

![todo:image_alt_text](/_assets/install/installation_5.png)

Po stažení uvidíte následující potvrzovací zprávy. Pokud neznáte [EULA Aspose](https://about.aspose.com/legal/eula), je dobrý nápad přečíst licenci, na kterou je odkazováno v URL.

![todo:image_alt_text](/_assets/install/installation_6.png)

Nyní byste měli zjistit, že byl Aspose.CAD úspěšně přidán a odkazován ve vaší aplikaci.

![todo:image_alt_text](/_assets/install/installation_7.png)

V konzoli správce balíčků můžete také použít příkaz “**Update-Package Aspose.CAD**” a stisknout enter pro zjištění aktualizací balíčku Aspose.CAD a jejich nainstalování, pokud jsou k dispozici. Můžete také přidat sufix "-prerelease" k aktualizaci nejnovější verze.

## **Úvahy při běhu na sdíleném serverovém prostředí**

Všechny komponenty Aspose .NET se doporučuje spouštět s nastavenou zárukou plného důvěření. To je z důvodu, že komponenty Aspose .NET někdy potřebují přistupovat k nastavením registru a souborům umístěným na jiných místech než virtuální adresář, například pro čtení písem atd. Navíc jsou komponenty Aspose.NET založeny na základních třídách systému .NET, některé z nich také vyžadují oprávnění plného důvěře k běhu v některých případech.

Poskytovatelé internetových služeb hostující různé aplikace od různých společností obvykle uplatňují úroveň zabezpečení Střední důvěra. V případě .NET 2.0 může taková úroveň zabezpečení nastavit následující omezení, která by mohla ovlivnit schopnost Aspose.CAD správně fungovat.

- **RegistryPermission** není k dispozici. To znamená, že nemůžete přistupovat k registru, což je vyžadováno pro výčet nainstalovaných písem při vykreslování dokumentů.
- **FileIOPermission** je omezeno. To znamená, že můžete přistupovat pouze k souborům ve hierarchii virtuálního adresáře vaší aplikace. To potenciálně znamená, že písma nelze číst během exportu.

Z těchto důvodů, které byly uvedeny výše, se doporučuje spouštět Aspose.CAD s oprávněním plného důvěry. Můžete zjistit, že některé funkce knihovny budou fungovat při provádění různých úkolů ve Středním důvěře, zatímco některé ne (například vykreslování), což může být způsobeno volání procesů zpracování obrazu GDI+.

## **Systémové požadavky**

### **Operační systémy**

Aspose.CAD pro .NET podporuje jakýkoliv 32bitový nebo 64bitový operační systém, kde je nainstalován framework .NET nebo Mono, včetně, ale neomezeně:

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) a serverové operační systémy (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS a další)
- Mac OS X

### **Frameworky**

Aspose.CAD pro .NET podporuje:

- Verze .NET Framework od 2.0 do 4.5 včetně verzí Client Profile
- .NET Core
- Mono 2.6.7 nebo novější

### **Vývojová prostředí**

Můžete použít Aspose.CAD pro .NET k vývoji aplikací v libovolném vývojovém prostředí, které cílí na platformu .NET, ale následující prostředí jsou explicitně podporována:

- Microsoft Visual Studio 2010 nebo novější
- MonoDevelop 2.4 a novější
