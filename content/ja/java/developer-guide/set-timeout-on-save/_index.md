---
title: 保存時のタイムアウトを設定する
type: docs
weight: 70
url: /ja/java/developer-guide/set-timeout-on-save/
---

## **保存時のタイムアウトを設定する**

Aspose.CAD for Java APIを使用すると、保存時にタイムアウトを設定できます。これは、保存プロセスに時間がかかる場合や多くのメモリを消費している場合に役立ちます。このために、APIは [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) クラスを提供します。 [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) クラスは、長時間の操作を中断するために使用されるトークンを提供します。

## サンプルコード

次のコードスニペットは、 [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) クラスの使用を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
