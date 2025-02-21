---
title: テキストの操作
type: docs
weight: 40
url: /ja/python-net/developer-guide/drawing-api/work-with-text/
---

## **テキストの操作**

ほとんどすべての図面にはテキストオブジェクトが含まれており、これらの例はそれらを操作する方法を示しています。
DWG/DXFにはテキストを保存できる異なるタイプのエンティティがあり、**CadText**、**CadMText**、CadAttDef、CadAttribの4つがあります。最後の2つのタイプは通常、**CadInsertObject**に関連しており、それに内部または対応するブロック内に保存されます。

以下は、テキストに関する操作を説明するいくつかの例です。

### **テキストの検索**

この例は、DWG/DXFファイル内のテキスト値を見つける方法を示しており、テキスト値の置き換えにも使用できます。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
