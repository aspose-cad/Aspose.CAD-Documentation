---
title: Jak spustit příklady
type: docs
weight: 70
url: /cs/jak-spustit-priklady/
---

## **Požadavky na software**

Před stažením a spuštěním příkladů se ujistěte, že splňujete následující požadavky.

1. Visual Studio 2010 nebo novější
1. Nainstalovaný správce balíčků NuGet ve Visual Studiu. Ujistěte se, že je nainstalována nejnovější verze NuGet API ve Visual Studiu. Podrobnosti o instalaci správce balíčků NuGet naleznete na https://docs.microsoft.com/cs-cz/nuget/install-nuget-client-tools
1. Přejděte do Nástroje->Možnosti->Správce balíčků NuGet->Zdroje balíčků a ujistěte se, že je zaškrtnuta možnost **nuget.org**
1. Příkladový projekt využívá funkci automatické obnovy balíčků NuGet, proto musíte mít aktivní internetové připojení. Pokud na počítači, kde se mají příklady provádět, nemáte aktivní internetové připojení, přejděte na [Instalace](/cs/cad/net/installace/) a přidejte odkaz na Aspose.CAD.dll do příkladového projektu.

## **Stažení z GitHubu**

Všechny příklady Aspose.CAD pro .NET jsou hostovány na [GitHubu](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Buď si můžete repozitář naklonovat pomocí vašeho oblíbeného klienta GitHub nebo stáhnout ZIP soubor odtud (https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Rozbalte obsah ZIP souboru do libovolné složky na vašem počítači. Všechny příklady jsou umístěny ve složce **Příklady**.
- K dispozici je soubor řešení pro C#.
- Projekty jsou vytvořeny ve Visual Studiu 2013, ale soubory řešení jsou kompatibilní s Visual Studiem 2010 SP1 a novějším.
- Otevřete soubor řešení ve Visual Studiu a sestavte projekt.
- Při prvním spuštění budou závislosti automaticky stahovány pomocí NuGet.
- **Data** složka ve složce **Příklady** obsahuje vstupní soubory, které jsou použity v příkladech v C#. Je důležité stáhnout složku **Data** společně s příklady projektu.
- Otevřete soubor RunExamples.cs, všechny příklady jsou volány odtud.
- Zabraňte komentářům příkladů, které chcete spustit uvnitř projektu.

Nebojte se obrátit na nás prostřednictvím našich fór, pokud máte problémy s nastavením nebo spuštěním příkladů.

## **Přispět**

Pokud chcete přidat nebo vylepšit příklad, vyzýváme vás k přispění do projektu. Všechny příklady a ukázkové projekty v tomto repozitáři jsou open source a mohou být volně použity ve vašich vlastních aplikacích.

K přispění můžete naklonovat repozitář, upravit zdrojový kód a vytvořit požadavek na začlenění. Změny budeme posuzovat a začleníme je do repozitáře, pokud se ukážou jako užitečné.
