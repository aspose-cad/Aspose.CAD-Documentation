---
title: Licencování
type: docs
weight: 50
url: /cs/java/licensing/
---

{{% alert color="primary" %}}

Můžete stáhnout hodnotící verzi **Aspose.CAD** pro Java z [jeho stránky s ke stažení](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). Hodnotící verze poskytuje úplně stejné funkce jako licencovaná verze produktu. Navíc se hodnotící verze jednoduše stane licencovanou, když zakoupíte licenci a přidáte pár řádek kódu k aplikaci licence.

Jakmile jste spokojeni s vaším hodnocením **Aspose.CAD**, můžete zakoupit [licenci](https://purchase.aspose.com/buy) na webové stránce Aspose. Seznamte se s různými typy předplatného nabízených. Pokud máte jakékoli dotazy, neváhejte kontaktovat tým prodeje Aspose.

Každá licence od Aspose obsahuje jednoleté předplatné pro bezplatné aktualizace na nové verze nebo opravy, které vyjdou během tohoto období. Technická podpora je bezplatná a neomezená a poskytována jak licencovaným, tak uživatelům s hodnotící verzí.

{{% /alert %}}

Pokud chcete testovat **Aspose.CAD** bez omezení hodnotící verze, požádejte o dočasnou licenci na 30 dní. Více informací naleznete v [Jak získat dočasnou licenci?](https://purchase.aspose.com/temporary-license).

## **Nastavení licence**

Licence je soubor XML s čistým textem obsahující informace, jako je název produktu, počet vývojářů, pro které je licencován, datum vypršení předplatného atd. Soubor je digitálně podepsán, takže jej neupravujte; dokonce i omylem přidání dodatečného odřádkování do souboru jej zneplatní.

Licenci musíte nastavit před prováděním jakýchkoli operací s soubory AutoCAD. Licence je zapotřebí nastavit pouze jednou na aplikaci nebo proces.

Licenci lze načíst ze streamu nebo souboru na následujících místech:

1. Explicitní cesta.
1. Složka obsahující Aspose.CAD.jar.

Použijte metodu License.setLicense() k přidání licence k komponentě. Často nejjednodušší způsob, jak nastavit licenci, je umístit licenční soubor do stejné složky jako Aspose.CAD.jar a specifikovat pouze název souboru bez cesty, jak je uvedeno v následujícím příkladu:

### **Příklad 1**

V tomto příkladu se **Aspose.CAD** pokusí najít licenční soubor ve složce obsahující JARy vaší aplikace.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Příklad 2**

Inicializace licence ze streamu.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Ověření licence**

Je možné ověřit, zda byla licence správně nastavena či nikoliv. Třída License obsahuje pole isLicensed, které vrátí true, pokud byla licence správně nastavena.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Licence je nastavena!");

}

{{< /highlight >}}
