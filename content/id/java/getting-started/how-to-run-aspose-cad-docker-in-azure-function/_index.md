---
title: Cara Menjalankan Gambar Docker Aspose.CAD di Fungsi Azure
type: docs
description: "Jalankan Gambar Docker Aspose.CAD di Fungsi Azure."
weight: 71
url: /id/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Prasyarat
- Docker harus terpasang di sistem Anda. Untuk informasi tentang cara menginstal Docker di Windows atau Mac, lihat tautan di bagian "Lihat Juga".
- IntelliJ IDEA.
- Azure Toolkit untuk IntelliJ.
- Postman.

## Fungsi Azure

Dalam contoh ini, Anda membuat fungsi konversi sederhana yang mengonversi file CAD dan menyimpannya sebagai gambar. Aplikasi kemudian dapat dibangun di Docker dan dijalankan di Fungsi Azure.

## Membuat Fungsi Azure

Untuk membuat program Fungsi Azure, ikuti langkah-langkah di bawah ini:
1. Setelah Docker terpasang, pastikan bahwa ia menggunakan Kontainer Linux (default). Jika perlu, pilih opsi Beralih ke kontainer Linux dari menu Docker Desktops.
1. Buat proyek Fungsi Azure di IntelliJ IDEA.<br>
![Buat proyek fungsi azure](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Buat proyek fungsi azure-final](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->Masuk dan pilih autentikasi OAuth 2.0.<br>
![Masuk Azure](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Masuk di browser.
1. Pilih nama Langganan.
1. Tambahkan dukungan docker.<br>
![Masuk Azure](/_assets/java/java-azure/add-docker-support.png)<br>
1. Edit DockerFile seperti di bagian <a href="#configuring-a-dockerfile">Mengonfigurasi Dockerfile</a>.
1. Tambahkan blok untuk repositori aspose.cad di pom.xml.
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. Ketika semua dependensi yang diperlukan ditambahkan, tulis program sederhana yang membuat sebuah elips dan menyimpannya sebagai gambar:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Fungsi ini mendengarkan di endpoint "/api/HttpExample". Dua cara untuk memanggilnya menggunakan perintah "curl" di bash:
     * 1. curl -d "HTTP Body" {host Anda}/api/HttpExample
     * 2. curl "{host Anda}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Pemicu HTTP Java memproses permintaan.");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### Mengonfigurasi Dockerfile

 Langkah selanjutnya adalah membuat dan mengonfigurasi Dockerfile di folder proyek root.

1. Di Dockerfile, tentukan:
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

 Di atas adalah Dockerfile sederhana, yang berisi instruksi berikut:

- Gambar SDK yang akan digunakan. Docker akan mengunduhnya saat build dijalankan. Versi SDK ditentukan sebagai tag.
- Direktori kerja, yang ditentukan di baris berikutnya.
- Perintah untuk menyalin semuanya ke kontainer, menerbitkan aplikasi, dan menentukan titik masuk.

## Docker Hub
1. Masuk ke Docker Hub
1. Buat Repositori Publik

## Membangun dan Menjalankan Aplikasi di Docker
 
 Sekarang aplikasi dapat dibangun dan dijalankan di Docker. Buka command prompt favorit Anda, ganti direktori ke folder dengan aplikasi (folder tempat file solusi dan Dockerfile ditempatkan) dan jalankan perintah berikut:


1. Bangun perintah dockerfile di konsol
{{< highlight plain >}}
//contoh
docker build -t <nama pengguna>/<nama repositori> .

docker build -t pengguna/asposefunction .
{{< /highlight >}}
 
1. Saat pertama kali Anda menjalankan perintah ini, mungkin akan memakan waktu lebih lama karena Docker perlu mengunduh gambar yang diperlukan. Setelah perintah sebelumnya selesai, jalankan perintah berikut untuk mendorong gambar ke docker hub.
{{< highlight plain >}}
//contoh
docker push <nama pengguna>/<nama repositori>:tagname

docker push pengguna/aspose-cad-java:latest
{{< /highlight >}}

1. Jalankan dockerfile di IDE dan setelah itu dorong ke docker hub.<br>
![Jalankan docker di ide](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Masukkan nama gambar, seperti di repositori Docker Hub.<br>
![Jalankan docker di ide-next](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Tunggu sampai selesai.

## Azure

1. Masuk ke Azure.
1. Pilih layanan Azure.
1. Pilih Fungsi App dan buat fungsi.<br>
![Tombol buat fungsi Azure](/_assets/java/java-azure/create-function-azure.png)<br>
1. Ulangi pengaturan dasar seperti pada gambar di bawah ini.<br>
![Pengaturan buat fungsi Azure](/_assets/java/java-azure/create-function-settings.png)<br>
1. Klik 'Tinjau + buat' -> Buat.
1. Tunggu hingga pengiriman selesai.
1. Klik tombol 'Pergi ke sumber daya'.<br>
![Tombol sumber daya](/_assets/java/java-azure/go-to-resource.png)<br>
1. Hentikan fungsi aspose-cad-docker-example.<br>
![Hentikan kontainer](/_assets/java/java-azure/stop-container.png)<br>
1. Masuk ke menu pusat pengiriman dan buat pengaturan yang sesuai.<br>
![Pusat pengiriman](/_assets/java/java-azure/deployment-center.png)<br>
1. Simpan pengaturan
1. Salin URL Webhook dari pengaturan pusat pengiriman.<br>
![URL Webhook](/_assets/java/java-azure/webhook-url.png)<br>
1. Pergi ke Docker Hub, pilih repositori Anda dan pilih webhooks.
1. Tempelkan 'URL Webhook' dari Azure di URL webhook Docker Hub dan atur namanya.<br>
![Pengaturan webhook di docker](/_assets/java/java-azure/webhook.png)<br>
1. Klik tombol buat.
1. Kembali ke fungsi azure overview dan mulai kontainer.<br>
![Menu overview](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Mungkin diperlukan beberapa menit bagi fungsi untuk mulai.
{{% /alert %}}

## Contoh Eksekusi

1. Pengaturan Postman.<br>
![Menu overview](/_assets/java/java-azure/postman-settings.png)<br>
1. Pilih file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Klik tombol kirim.
1. Simpan hasil
![Simpan respons](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Jika jawabannya berhasil, klik Simpan ke file dan Anda akan menerima file yang dikonversi dalam format png
{{% /alert %}}

## Lebih Banyak Contoh

Untuk lebih banyak contoh tentang cara Anda dapat menggunakan Aspose.CAD di Docker, lihat [contoh](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lihat Juga

- [Instal Docker Desktop di Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instal Docker Desktop di Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- Opsi [Beralih ke kontainer Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
