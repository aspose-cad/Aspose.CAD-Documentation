---
title: JasperServerとの統合
type: docs
weight: 20
url: /ja/jasperreports/installation/integration-with-jasperserver/
---
{{% alert color="primary" %}}
Aspose.CAD for JasperReportsをJasperServerと統合するためには、いくつかの追加のステップを踏み、JasperServerの設定ファイルを更新する必要があります。このアーティクルではその方法を説明します。
{{% /alert %}}
1. %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml設定ファイルに新しいエクスポータプロパティを追加します。
{{< highlight xml >}}
    <!--JPG-->
    <bean id="reportASJpegExporter" class="com.aspose.cad.jasperreports.jpg.ASReportJpegExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">バッチ</value>
        </property>
    </bean>

    <bean id="jpgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="jpgExportParams"/>
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="currentExporter" ref="reportASJpegExporter"/>
    </bean>

    <!--BMP-->
    <bean id="reportASBmpExporter" class="com.aspose.cad.jasperreports.bmp.ASReportBmpExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">バッチ</value>
        </property>
    </bean>

    <bean id="bmpASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="BMP - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="bmpExportParams"/>
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="currentExporter" ref="reportASBmpExporter"/>
    </bean>

    <!--GIF-->
    <bean id="reportASGifExporter" class="com.aspose.cad.jasperreports.gif.ASReportGifExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">バッチ</value>
        </property>
    </bean>

    <bean id="gifASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="GIF - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="gifExportParams"/>
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="currentExporter" ref="reportASGifExporter"/>
    </bean>

    <!--JPG2000-->
    <bean id="reportASJpg2000Exporter" class="com.aspose.cad.jasperreports.jpg2000.ASReportJpeg2000Exporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">バッチ</value>
        </property>
    </bean>

    <bean id="jpg2000ASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG2000 - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="jpg2000ExportParams"/>
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="currentExporter" ref="reportASJpg2000Exporter"/>
    </bean>

    <!--PDF-->
    <bean id="reportASPdfExporter" class="com.aspose.cad.jasperreports.pdf.ASReportPdfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">マルチページ</value>
        </property>
    </bean>

    <bean id="pdfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PDF - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="pdfExportParams"/>
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="currentExporter" ref="reportASPdfExporter"/>
    </bean>

    <!--PNG-->
    <bean id="reportASPngExporter" class="com.aspose.cad.jasperreports.png.ASReportPngExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">バッチ</value>
        </property>
    </bean>

    <bean id="pngASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PNG - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="pngExportParams"/>
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="currentExporter" ref="reportASPngExporter"/>
    </bean>

    <!--PSD-->
    <bean id="reportASPsdExporter" class="com.aspose.cad.jasperreports.psd.ASReportPsdExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">バッチ</value>
        </property>
    </bean>

    <bean id="psdASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PSD - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="psdExportParams"/>
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="currentExporter" ref="reportASPsdExporter"/>
    </bean>

    <!--SVG-->
    <bean id="reportASSvgExporter" class="com.aspose.cad.jasperreports.svg.ASReportSvgExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">シングルページ</value>
        </property>
    </bean>

    <bean id="svgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="SVG - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="svgExportParams"/>
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="currentExporter" ref="reportASSvgExporter"/>
    </bean>

    <!--TIFF-->
    <bean id="reportASTiffExporter" class="com.aspose.cad.jasperreports.tiff.ASReportTiffExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">マルチページ</value>
        </property>
    </bean>

    <bean id="tiffASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="TIFF - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="tiffExportParams"/>
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="currentExporter" ref="reportASTiffExporter"/>
    </bean>

    <!--WMF-->
    <bean id="reportASWmfExporter" class="com.aspose.cad.jasperreports.wmf.ASReportWmfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">シングルページ</value>
        </property>
    </bean>

    <bean id="wmfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="WMF - Aspose.CADからの画像エクスポート"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    エクスポートのモードを変更するには、「exportMode」という名前のプロパティを使用し、希望するモードに応じた値を設定します。 
例えば:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.jasperreports.common.ExportMode">シングルページ</value>
    </property>
{{< /highlight >}}
    com.aspose.cad.jasperreports.common.ExportMode列挙型を使用してプロパティの値をバッチ、シングルページ、またはマルチページに変更できます。

2. %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xmlファイル内で<util:map id="exporterConfigMap">...</util:map>要素を見つけ、以下の行を追加します:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- 関連エクスポータを除外/含める場合は、以下の行をコメント/アンコメントしてください
             注意: iPad用の個別設定 'exportersSupportedByiPad'
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
		
			<!-- このエントリをexporterConfigMapに追加 -->
			<!-- Aspose.CAD JasperReports 開始 -->
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
		<!-- Aspose.CAD for JasperReports 終了 -->
    </util:map>
{{< /highlight >}}
3. aspose-cad-jasperreports-xx.xx.jarを%INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\libにコピーします。
4. エクスポート機能を使用するために、%INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xmlを以下のように更新します。
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="bmpExportParameters" class="com.aspose.cad.jasperreports.bmp.ASBmpExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="gifExportParameters" class="com.aspose.cad.jasperreports.gif.ASGifExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="jpg2000ExportParameters" class="com.aspose.cad.jasperreports.jpg2000.ASJpeg2000ExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pdfASExportParameters" class="com.aspose.cad.jasperreports.pdf.ASPdfExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pngExportParameters" class="com.aspose.cad.jasperreports.png.ASPngExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="psdExportParameters" class="com.aspose.cad.jasperreports.psd.ASPsdExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="svgExportParameters" class="com.aspose.cad.jasperreports.svg.ASSvgExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>

	<bean id="tiffExportParameters" class="com.aspose.cad.jasperreports.tiff.ASTiffExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="wmfExportParameters" class="com.aspose.cad.jasperreports.wmf.ASWmfExportParametersBean">
	<!--        ライセンスを適用するためにコメントを解除し、パスを確認してください。
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>
{{< /highlight >}}

5. JasperReports Serverを再起動し、レポートを開いて表示します。前のステップが正しく実行されていれば、エクスポート形式のリストに追加の選択肢が表示されます。
![todo:image_alt_text](/cad/_assets/jasper/ExportReportView.png)

追加の形式（アイコンまたは選択肢）が表示されない場合は、\apache-tomcat\logsディレクトリ内のログファイルを確認してください。
