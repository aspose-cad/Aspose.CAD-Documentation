---
title: Licencování
type: docs
weight: 50
url: /cs/net/licensing/
---

{{% alert color="primary" %}}

Jakmile budete spokojeni s vaším hodnocením Aspose.CAD pro .NET, zakupte licenci na webu společnosti Aspose: [Nákupní portál](https://purchase.aspose.com/buy). Seznamte se s různými dostupnými typy licencí. Pokud máte nějaké otázky, [kontaktujte prodejní tým Aspose](https://about.aspose.com/contact) a rádi vám pomohou.

Každá licence Aspose zahrnuje roční předplatné s možností zdarma aktualizací na nové verze nebo opravy, které budou v tomto období vydány. Poskytujeme zdarma a neomezenou technickou podporu jak registrovaným, tak uživatelům ve fázi hodnocení.

Licence je soubor ve formátu XML, který obsahuje detaily, jako je název produktu, počet licencovaných vývojářů, datum vypršení předplatného atd. Soubor je digitálně podepsán, takže neprovaďte žádné úpravy: i přidání dalšího odřádkování do souboru jej neplatným.

{{% /alert %}}

## **Kdy aplikovat licenci**

Postupujte podle těchto jednoduchých pravidel:

- Licence je potřeba nastavit pouze jednou na aplikační doméně.
- Musíte nastavit licenci před použitím jakýchkoli jiných tříd Aspose.CAD.
- Volání SetLicense vícekrát není škodlivé, ale zbytečně zatěžuje procesor.
- Pokud vyvíjíte aplikaci Windows Forms nebo konsolovou aplikaci, zavolejte SetLicense v kódu spuštění před použitím tříd Aspose.CAD.
- Při vývoji webové aplikace ASP.NET, zavolejte SetLicense z Global.asax.cs (Global.asax.vb) souboru v metodě Application_Start. Tato metoda je zavolána jednou při spuštění aplikace.
- Nevolejte SetLicense uvnitř metod Page_Load, protože to znamená, že licence bude načtena pokaždé, kdy je načtena webová stránka.
- Pokud vytváříte knihovnu tříd, zavolejte SetLicense ze statického konstruktoru třídy, která používá Aspose.CAD. Statický konstruktor se vykoná před vytvořením instance třídy, což zajistí, že licence Aspose.CAD bude správně nastavena.

## **Aplikace licence pomocí souboru nebo objektu streamu**

Použijte metodu **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** k licencování komponenty. Nejjednodušší způsob nastavení licence je umístit licenční soubor do stejné složky jako Aspose.CAD.dll a specifikovat název souboru, bez cesty, jak je ukázáno níže.

### **Načtení licence ze souboru**

Tento kód inicializuje licenci uloženou v souboru nebo zabudovaném prostředku.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Načtení licence z objektu streamu**

Tento kód inicializuje licenci ze streamu.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
