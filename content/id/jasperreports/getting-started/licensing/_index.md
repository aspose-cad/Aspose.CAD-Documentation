---
title: Lisensi
type: docs
weight: 40
url: /id/jasperreports/getting-started/licensing/
---
## **Panggil setLicense**
Untuk menerapkan lisensi:

Simpan file lisensi ke folder di disk Anda. Misalnya C:\Lic\Aspose.CAD.JasperReport.lic.
Panggil metode License.setLicense(filename) dan masukkan nama file sebagai argumen. Ketika pernyataan ini dipanggil, lisensi akan disetel dan pesan evaluasi tidak akan lagi muncul di atas gambar.
Potongan kode berikut menetapkan lisensi untuk Aspose.CAD untuk JasperReports.

{{< highlight java >}}

// Setel lisensi

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Anda perlu memanggil metode setLicense() hanya sekali per proses atau aplikasi.

{{% /alert %}}

## **Setel Parameter Ekspor lisensi di applicationContext.xml**
{{% alert color="primary" %}}
Metode ini dapat digunakan untuk JasperServer.
{{% /alert %}}
1. Unduh lisensi ke komputer Anda dan salin ke folder \apache-tomcat\webapps\jasperserver\WEB-INF, di mana merupakan direktori instalasi JasperServer.
2. Temukan file \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml dan tambahkan baris berikut:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
