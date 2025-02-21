---
title: 保存時のタイムアウトを設定
type: docs
weight: 70
url: /ja/net/developer-guide/set-timeout-on-save/
---

## **保存時のタイムアウトを設定**

Aspose.CAD for .NET APIを使用すると、保存時にタイムアウトを設定できます。これは、保存プロセスに長い時間がかかる場合や多くのメモリを消費する場合に役立ちます。これに対して、APIは  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) クラスを提供します。 [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) クラスは、長時間の操作を中断するために使用されるトークンを提供します。

## サンプルコード

次のコードスニペットは [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) クラスの使用を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
