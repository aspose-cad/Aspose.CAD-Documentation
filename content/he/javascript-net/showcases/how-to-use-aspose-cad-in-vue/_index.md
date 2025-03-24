---
title: כיצד להשתמש ב-Aspose.CAD ב-Vue
type: docs
description: "שתמשו ב-Aspose.CAD ב-Vue."
weight: 75
url: /he/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## דרישות קודמות
- Vue CLI
- Visual Code
- Node.js

## המרת תמונת dgn ל-png והצגתה בדפדפן

בדוגמה זו, תיצור תוכנית המרה פשוטה שממירה שרטוט ושומרת אותו כתמונה.

## יצירת פרויקט Vue

1. ודא שאינך כבר במדריך עבודה של Vue.
1. התחל חדש ואז את שם התוכנית או השתמש בתוכניות אחרות כדי ליצור פרויקט כמו Visual Code או WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. התקן את Aspose.CAD מחבילת npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. צור תגי קלט מסוג קובץ ותג img כדי לטעון ולהציג את השרטוט
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. ב-App.vue, אנו מתארים את התהליך של הפעלת תהליכים עזר, עיבוד והצגת התמונה
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //נדרש להתחלת תהליך ההרכבה
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
      
      console.log("טוען WASM...");
      await dotnet.boot();
      console.log("WASM נטען");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // טען
              let file = Image.load(array);
              console.log(file);

              // שמור
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
    <img alt="לוגו Vue" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>דוגמה ל-aspose.cad עבור Vue.</p>
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
1. הפעל את היישום
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## דוגמת ביצוע

1. בחר קובץ.<br>
![בחר קובץ](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. בחר כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. אם התשובה היא מוצלחת, הקובץ יוצג על המסך ויוצע להוריד אותו.<br>
![המרת תמונה](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## ראה גם

- [התקן Visual Code](https://code.visualstudio.com/)
- [התקן Node.js](https://nodejs.org/en/)
