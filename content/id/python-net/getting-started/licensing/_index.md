---
title: Lisensi
type: docs
weight: 40
url: /id/python-net/getting-started/licensing/
---
## **Panggil setLicense**
Untuk menerapkan lisensi:

Simpan file lisensi ke folder di disk Anda. Sebagai contoh C:\Lic\Aspose.CAD.Python.lic.
Panggil metode License.set_license(filename) dan masukkan nama file sebagai argumen. Ketika pernyataan ini dipanggil, lisensi akan diatur dan pesan evaluasi tidak akan muncul lagi di atas gambar.
Potongan kode berikut mengatur lisensi untuk Aspose.CAD untuk Python.

{{< highlight java >}}

// Atur lisensi

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Anda perlu memanggil metode set_license() hanya sekali per proses atau aplikasi.

{{% /alert %}}

## **Atur Parameter Ekspor lisensi di applicationContext.xml**
{{% alert color="primary" %}}
Metode ini berlaku untuk digunakan dengan JasperServer.
{{% /alert %}}
1. Unduh lisensi ke komputer Anda dan salin ke folder \apache-tomcat\webapps\jasperserver\WEB-INF, di mana adalah direktori instalasi JasperServer.
2. Temukan file \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml dan tambahkan baris berikut:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
