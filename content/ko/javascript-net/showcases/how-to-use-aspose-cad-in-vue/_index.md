---
title: Vue에서 Aspose.CAD 사용하는 방법
type: docs
description: "Vue에서 Aspose.CAD를 사용하세요."
weight: 75
url: /ko/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## 전제 조건
- Vue CLI
- 비주얼 코드
- Node.js

## dgn 이미지를 png로 변환하고 브라우저에 표시하기

이 예제에서는 드로잉을 변환하고 이미지를 저장하는 간단한 변환 프로그램을 생성합니다.

## Vue 프로젝트 생성

1. 현재 Vue 작업공간 디렉토리에 있지 않은지 확인하세요.
1. 새 작업공간을 시작하고 프로그램 이름을 입력하거나 비주얼 코드 또는 웹스톰과 같은 다른 프로그램을 사용하여 프로젝트를 생성하세요:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. npm 패키지에서 Aspose.CAD 설치
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. 드로잉을 로드하고 표시하기 위한 input type file 및 img 태그를 생성합니다
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. App.vue에서 헬퍼 프로세스를 시작하고 이미지를 처리 및 표시하는 과정을 설명합니다
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // 조립 프로세스 시작에 필요합니다
    let recaptchaScript = document.createElement('script')
    recaptchaScript.setAttribute('src', '/node_modules/aspose-cad/dotnet.js')
    document.head.appendChild(recaptchaScript)

    let dotnet;
  },
  mounted() {
    window.addEventListener('load', this.onWindowLoad)
  },
  methods: {
    async onWindowLoad() {
      
      console.log("WASM 로딩 중...");
      await dotnet.boot();
      console.log("WASM 로드 완료");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // 로드
              let file = Image.load(array);
              console.log(file);

              // 저장
              let exportedFilePromise = Image.save(array, new PngOptions());
              exportedFilePromise.then(exportedFile => {
                console.log(exportedFile);

                let urlCreator = window.URL || window.webkitURL;
                let blob = new Blob([exportedFile], { type: 'application/octet-stream' });
                let imageUrl = urlCreator.createObjectURL(blob);
                document.querySelector("#image").src = imageUrl;
              });
            }

            reader.readAsArrayBuffer(this.files[0]);
          },
          false);
    },
  },
}
</script>

<template>
  <header>
    <img alt="Vue 로고" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Vue를 위한 Aspose.CAD 예제.</p>
  </header>

  <main>
    <input id="file" type="file">
    <br/>
    <img id="image" />
  </main>
</template>

<style scoped>
header {
  line-height: 1.5;
}
main{
  text-align: center;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }


  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
{{< /highlight >}}
1. 애플리케이션 시작
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## 실행 예시

1. 파일 선택하기.<br>
![파일 선택하기](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG 파일 중 하나를 선택하세요.
1. 응답이 성공적이면 파일이 화면에 표시되고 다운로드하라는 메시지가 표시됩니다.<br>
![이미지 변환](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## 참고

- [비주얼 코드 설치](https://code.visualstudio.com/)
- [Node.js 설치](https://nodejs.org/en/)
