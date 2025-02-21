---
title: การรวมเข้ากับ JasperServer
type: docs
weight: 20
url: /th/jasperreports/installation/integration-with-jasperserver/
---
{{% alert color="primary" %}}
ในการรวม Aspose.CAD สำหรับ JasperReports เข้ากับ JasperServer จะต้องทำตามขั้นตอนเพิ่มเติมหลายประการและอัปเดตไฟล์การกำหนดค่าของ JasperServer บทความนี้จะอธิบายวิธีการ
{{% /alert %}}
1. เพิ่มคุณสมบัติ exporter ใหม่ลงในไฟล์ config %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml
{{< highlight xml >}}
    <!--JPG-->
    <bean id="reportASJpegExporter" class="com.aspose.cad.jasperreports.jpg.ASReportJpegExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="jpgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="jpgExportParams"/>
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="currentExporter" ref="reportASJpegExporter"/>
    </bean>

    <!--BMP-->
    <bean id="reportASBmpExporter" class="com.aspose.cad.jasperreports.bmp.ASReportBmpExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="bmpASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="BMP - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="bmpExportParams"/>
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="currentExporter" ref="reportASBmpExporter"/>
    </bean>

    <!--GIF-->
    <bean id="reportASGifExporter" class="com.aspose.cad.jasperreports.gif.ASReportGifExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="gifASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="GIF - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="gifExportParams"/>
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="currentExporter" ref="reportASGifExporter"/>
    </bean>

    <!--JPG2000-->
    <bean id="reportASJpg2000Exporter" class="com.aspose.cad.jasperreports.jpg2000.ASReportJpeg2000Exporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="jpg2000ASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG2000 - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="jpg2000ExportParams"/>
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="currentExporter" ref="reportASJpg2000Exporter"/>
    </bean>

    <!--PDF-->
    <bean id="reportASPdfExporter" class="com.aspose.cad.jasperreports.pdf.ASReportPdfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Multipage</value>
        </property>
    </bean>

    <bean id="pdfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PDF - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="pdfExportParams"/>
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="currentExporter" ref="reportASPdfExporter"/>
    </bean>

    <!--PNG-->
    <bean id="reportASPngExporter" class="com.aspose.cad.jasperreports.png.ASReportPngExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="pngASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PNG - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="pngExportParams"/>
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="currentExporter" ref="reportASPngExporter"/>
    </bean>

    <!--PSD-->
    <bean id="reportASPsdExporter" class="com.aspose.cad.jasperreports.psd.ASReportPsdExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="psdASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PSD - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="psdExportParams"/>
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="currentExporter" ref="reportASPsdExporter"/>
    </bean>

    <!--SVG-->
    <bean id="reportASSvgExporter" class="com.aspose.cad.jasperreports.svg.ASReportSvgExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
        </property>
    </bean>

    <bean id="svgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="SVG - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="svgExportParams"/>
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="currentExporter" ref="reportASSvgExporter"/>
    </bean>

    <!--TIFF-->
    <bean id="reportASTiffExporter" class="com.aspose.cad.jasperreports.tiff.ASReportTiffExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Multipage</value>
        </property>
    </bean>

    <bean id="tiffASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="TIFF - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="tiffExportParams"/>
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="currentExporter" ref="reportASTiffExporter"/>
    </bean>

    <!--WMF-->
    <bean id="reportASWmfExporter" class="com.aspose.cad.jasperreports.wmf.ASReportWmfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
        </property>
    </bean>

    <bean id="wmfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="WMF - การส่งออกภาพจาก Aspose.CAD"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    เพื่อเปลี่ยนโหมดการส่งออกให้ใช้คุณสมบัติที่มีชื่อว่า "exportMode" และใส่ค่าให้ตรงกับโหมดที่ต้องการ
ตัวอย่างเช่น:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    คุณสามารถเปลี่ยนค่าของคุณสมบัตินี้เป็น Batch, SinglePage หรือ Multipage โดยใช้ประเภท enum type ของ com.aspose.cad.jasperreports.common.ExportMode

2. ค้นหาตัวอย่าง <util:map id="exporterConfigMap">...</util:map> ในไฟล์ %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml และเพิ่มบรรทัดต่อไปนี้:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- คอมเมนต์/ยกเลิกการคอมเมนต์แถวใดๆ ด้านล่างหากคุณต้องการให้ exporter ที่เกี่ยวข้อง 
        	 ถูกยกเว้น/รวมในรายการ exporter ของผู้ดู
        	 หมายเหตุ: การกำหนดค่าแยกสำหรับ iPad 'exportersSupportedByiPad'
        	 -->
        	 
        <entry key="pdf" value-ref="pdfExporterConfiguration"/>
        <entry key="xls" value-ref="xlsExporterConfiguration"/>
        <entry key="xlsNoPag" value-ref="xlsNoPaginationExporterConfiguration"/>
        <entry key="csv" value-ref="csvExporterConfiguration"/>
        <entry key="docx" value-ref="docxExporterConfiguration"/>
        <entry key="rtf" value-ref="rtfExporterConfiguration"/>
        <entry key="odt" value-ref="odtExporterConfiguration"/>
        <entry key="ods" value-ref="odsExporterConfiguration"/>
        <entry key="xlsx" value-ref="xlsxExporterConfiguration"/>
        <entry key="xlsxNoPag" value-ref="xlsxNoPaginationExporterConfiguration"/>
        <entry key="pptx" value-ref="pptxExporterConfiguration"/>
        <!-- 
        <entry key="txt" value-ref="txtExporterConfiguration"/>
        -->
		
			<!-- เพิ่มรายการเหล่านี้ลงใน exporterConfigMap -->
			<!-- Aspose.CAD JasperReports เริ่มต้น -->
		<entry key="as_jpg" value-ref="jpgASExporterParameters"/>
		<entry key="as_bmp" value-ref="bmpASExporterParameters"/>
		<entry key="as_gif" value-ref="gifASExporterParameters"/>
		<entry key="as_jpg2000" value-ref="jpg2000ASExporterParameters"/>
		<entry key="as_pdf" value-ref="pdfASExporterParameters"/>
		<entry key="as_png" value-ref="pngASExporterParameters"/>
		<entry key="as_psd" value-ref="psdASExporterParameters"/>
		<entry key="as_svg" value-ref="svgASExporterParameters"/>
		<entry key="as_tiff" value-ref="tiffASExporterParameters"/>
		<entry key="as_wmf" value-ref="wmfASExporterParameters"/>
		<!-- Aspose.CAD สำหรับ JasperReports สิ้นสุด -->
    </util:map>
{{< /highlight >}}
3. คัดลอก aspose-cad-jasperreports-xx.xx.jar ไปยัง %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib.
4. เพื่อใช้ฟีเจอร์การส่งออก ให้ปรับปรุง %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml ดังนี้
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="bmpExportParameters" class="com.aspose.cad.jasperreports.bmp.ASBmpExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="gifExportParameters" class="com.aspose.cad.jasperreports.gif.ASGifExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="jpg2000ExportParameters" class="com.aspose.cad.jasperreports.jpg2000.ASJpeg2000ExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pdfASExportParameters" class="com.aspose.cad.jasperreports.pdf.ASPdfExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pngExportParameters" class="com.aspose.cad.jasperreports.png.ASPngExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="psdExportParameters" class="com.aspose.cad.jasperreports.psd.ASPsdExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="svgExportParameters" class="com.aspose.cad.jasperreports.svg.ASSvgExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>

	<bean id="tiffExportParameters" class="com.aspose.cad.jasperreports.tiff.ASTiffExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="wmfExportParameters" class="com.aspose.cad.jasperreports.wmf.ASWmfExportParametersBean">
	<!--        ยกเลิกการคอมเมนต์และปรับเปลี่ยนเพื่อใช้ใบอนุญาต ตรวจสอบเส้นทางใบอนุญาต
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>
{{< /highlight >}}

5. เริ่มต้นใหม่ JasperReports Server และเปิดรายงานใดๆ เพื่อดู หากขั้นตอนก่อนหน้านี้ทำอย่างถูกต้อง คุณจะเห็นตัวเลือกเพิ่มเติมในรายการรูปแบบการส่งออก
![todo:image_alt_text](/_assets/jasper/ExportReportView.png)

หากคุณไม่เห็นรูปแบบเพิ่มเติม (ไอคอนหรือทางเลือก) โปรดตรวจสอบไฟล์บันทึกในไดเรกทอรี \apache-tomcat\logs
