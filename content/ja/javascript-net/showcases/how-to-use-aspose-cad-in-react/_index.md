---
title: ReactでAspose.CADを使用する方法
type: docs
description: "ReactでAspose.CADを使用する"
weight: 75
url: /ja/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## 前提条件
- Visual Code
- Node.js

## dgn画像をpngに変換してブラウザに表示する

この例では、描画を変換して画像として保存するシンプルな変換プログラムを作成します。

## Reactプロジェクトの作成

1. すでにReactワークスペースディレクトリにいないことを確認します。
1. 新しいディレクトリを作成し、プログラム名を付けるか、Visual CodeやWebStormなどの他のプログラムを使用してプロジェクトを作成します：
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. npmパッケージからAspose.CADをインストールします
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. 描画を読み込んで表示するためのinputタイプファイルおよびimgタグを作成します
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. App.tsxでは、ヘルパープロセスを開始し、処理および画像を保存するプロセスを説明します
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="converted" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("WASMを読み込み中...");
  await boot();
  console.log("WASMが読み込まれました");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // 読み込み
          var file = Image.load(array);

          // 保存
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. アプリケーションを開始します
{{< highlight plain >}}
npm start
{{< /highlight >}}

## 実行例

1. ファイルを選択します。<br>
![ファイルを選択](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. 任意のDXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVGファイルを選択します。
1. 正常な応答があれば、ファイルが画面に表示され、ダウンロードの提供が行われます。<br>
![画像を変換](/cad/_assets/javascript-net/react/convert-image.png)<br>

## 参考情報

- [Visual Codeをインストールする](https://code.visualstudio.com/)
- [Node.jsをインストールする](https://nodejs.org/en/)
