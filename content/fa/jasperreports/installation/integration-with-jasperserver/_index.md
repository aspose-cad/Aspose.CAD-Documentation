---
title: ادغام با JasperServer
type: docs
weight: 20
url: /fa/jasperreports/integration-with-jasperserver/
---
{{% alert color="primary" %}}
برای ادغام Aspose.CAD برای JasperReports با JasperServer، لازم است چند مرحله اضافی انجام شده و فایل‌های پیکربندی JasperServer به‌روزرسانی شوند. این مقاله توضیح می‌دهد که چگونه این کار انجام می‌شود.
{{% /alert %}}
1. خواص جدید صادرکننده را به فایل پیکربندی %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml اضافه کنید.
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
        <property name="descriptionKey" value="JPG - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="BMP - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="GIF - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="JPG2000 - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="PDF - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="PNG - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="PSD - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="SVG - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="TIFF - خروجی تصویر از Aspose.CAD"/>
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
        <property name="descriptionKey" value="WMF - خروجی تصویر از Aspose.CAD"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    برای تغییر حالت خروجی، از خاصیت با نام "exportMode" استفاده کنید و مقدار مورد نظر را قرار دهید. 
به عنوان مثال:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    شما می‌توانید مقدار خاصیت را به Batch، SinglePage یا Multipage با استفاده از نوع Enum com.aspose.cad.jasperreports.common.ExportMode تغییر دهید.

2. عنصر <util:map id="exporterConfigMap">...</util:map> را در فایل %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml پیدا کرده و خطوط زیر را اضافه کنید:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- هر یک از خطوط زیر را اگر می‌خواهید صادرکننده‌های مربوطه 
        	 در لیست صادرکننده‌های بیننده شامل نشود/شامل شود 
        	 توجه: پیکربندی جداگانه برای 'exportersSupportedByiPad'
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
		
			<!-- این ورودی‌ها را به exporterConfigMap اضافه کنید -->
			<!-- Aspose.CAD JasperReports شروع -->
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
		<!-- Aspose.CAD برای JasperReports پایان -->
    </util:map>
{{< /highlight >}}
3. فایل aspose-cad-jasperreports-xx.xx.jar را به %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib کپی کنید.
4. برای استفاده از ویژگی‌های خروجی، فایل %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml را به صورت زیر به‌روزرسانی کنید.
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="bmpExportParameters" class="com.aspose.cad.jasperreports.bmp.ASBmpExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="gifExportParameters" class="com.aspose.cad.jasperreports.gif.ASGifExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="jpg2000ExportParameters" class="com.aspose.cad.jasperreports.jpg2000.ASJpeg2000ExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pdfASExportParameters" class="com.aspose.cad.jasperreports.pdf.ASPdfExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pngExportParameters" class="com.aspose.cad.jasperreports.png.ASPngExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="psdExportParameters" class="com.aspose.cad.jasperreports.psd.ASPsdExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="svgExportParameters" class="com.aspose.cad.jasperreports.svg.ASSvgExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>

	<bean id="tiffExportParameters" class="com.aspose.cad.jasperreports.tiff.ASTiffExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="wmfExportParameters" class="com.aspose.cad.jasperreports.wmf.ASWmfExportParametersBean">
	<!--        زنجیره را حذف کرده و اصلاح کنید تا یک مجوز را اعمال کنید. مسیر مجوز را بررسی کنید.
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>
{{< /highlight >}}

5. سرور JasperReports را مجدداً راه‌اندازی کرده و هر گزارشی را برای مشاهده باز کنید. اگر مراحل قبلی به درستی انجام شده باشد، شما گزینه‌های اضافی را در لیست فرمت‌های خروجی خواهید دید.
![todo:image_alt_text](/fa/_assets/ExportReportView.png)

اگر گزینه‌های اضافی (آیکون‌ها یا انتخاب‌ها) را نمی‌بینید، لطفاً فایل‌های لاگ را در دایرکتوری \apache-tomcat\logs بررسی کنید.
