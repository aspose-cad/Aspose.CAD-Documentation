---
title: Vysvětlení chování mezipaměti Aspose.CAD
type: docs
weight: 20
url: /cs/common/caching-behaviour-explanation/
---


## **Jak Aspose.CAD ukládá data do mezipaměti**

Veškeré ukládání do mezipaměti prováděné programem Aspose.CAD je zcela automatické, bez nutnosti nebo možnosti zásahu uživatele. Existují v podstatě tři druhy mezipaměti, všechny se týkají písem.

### **Mezipaměť názvů písem**

Mezipaměť názvů písem se používá k usnadnění rychlejšího spuštění tím, že předzpracovává všechny nalezené soubory písem a sestavuje seznam názvů písem přítomných v těchto souborech, protože jeden soubor písma může obsahovat více než jedno písmo. Je uložena jako dočasný soubor a velikost většiny systémů je maximálně několik desítek kilobajtů.

### **Mezipaměť dat glyphů písem**

Mezipaměť v paměti pro všechny glyphy, které byly použity během životního cyklu aplikace, aby se snížilo opakované čtení skutečných souborů písem na disku během následných exportů. Jak to dopadá, vedlo by to ke stálému zvyšování spotřeby paměti, pokud by následné exporty obsahovaly soubory, které se odkazují na nová písma a/nebo obsahují znaky, které dříve nebyly použity. Nicméně, v praxi, i na celém testovacím balíku Aspose.CAD, se tisíci soubory v různých jazycích, je jeho spotřeba paměti přibližně 200 megabajtů, což není pro moderní systém příliš signifikantní.

### **Mezipaměť záložního písma na základě znaků**

Mezipaměť v paměti, která ukládá písma, která obsahují daný znak pro všechny znaky Unicode, aby se usnadnilo výběr náhradního písma v případě, že písmo dodané textovou entitou v kresbě neobsahuje znak v obsahu textu této entity. Je vybudována při prvním exportu během životního cyklu aplikace a zůstává až do ukončení aplikace. Na našich relativně skromných testovacích strojích s masivními sbírkami písem používanými v testovacích sadách trvá vybudování mezipaměti přibližně 30 sekund a zabírá 70 megabajtů. Jakmile je vybudována, již nezabírá žádný čas a neroste.
