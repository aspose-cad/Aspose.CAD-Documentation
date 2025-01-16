---
title: Vysvětlení chování vyrovnávací paměti Aspose.CAD
type: docs
weight: 20
url: /cs/common/vysvetleni-chovani-vyrovnavaci-pameti
---

## **Jak Aspose.CAD ukládá data do mezipaměti**

Veškeré ukládání do mezipaměti provedené pomocí Aspose.CAD je zcela automatické, bez nutnosti jakéhokoli uživatelského vstupu nebo možnosti takového. Existují základně tři druhy vyrovnávací paměti, které jsou všechny spojeny s písmy.

### **Vyrovnávací paměť pro názvy písem**

Vyrovnávací paměť pro názvy písem slouží k urychlení startu prostřednictvím předzpracování všech nalezených souborů písem a sestavení seznamu názvů písem obsažených v těchto souborech, protože jeden soubor písma může obsahovat více než jedno písmo. Uchovává se jako dočasný soubor a pro většinu systémů má velikost maximálně několik desítek kilobytů.

### **Vyrovnávací paměť pro údaje o glyfech písem**

Vyrovnávací paměť v operační paměti všech glyfů, které byly během života aplikace použity, aby se snížilo znovunačítání skutečných souborů písem na disku během následných exportů. Takové chování by vedlo ke stabilnímu nárůstu spotřeby paměti, pokud by následné exporty obsahovaly soubory, které odkazují na nová písma a/nebo obsahují znaky, které se dosud nevyskytly. V praxi se však i při provedení celé sady testů Aspose.CAD s tisíci soubory v různých jazycích spotřeba paměti pohybuje kolem 200 megabytů, což pro moderní systém není příliš významné.

### **Vyrovnávací paměť pro automatický výběr písma podle znaků**

Vyrovnávací paměť v operační paměti ukládá písma, která obsahují daný znak pro všechny unicode znaky, aby usnadnila výběr náhradního písma v případě, že písmo dodané textovou entitou v kresbě neobsahuje znak ve zadaném textu této entity. Při první exportní operaci během života aplikace je vytvořena a zůstává až do ukončení aplikace. Na našich relativně skromných testovacích strojích s rozsáhlými kolekcemi písem používanými v testovací sadě tvoří tato paměť přibližně 30 sekund na vytvoření a zabírá 70 megabytů. Jakmile je vytvořena, nepotřebuje již žádný čas a nezvyšuje svou velikost.
