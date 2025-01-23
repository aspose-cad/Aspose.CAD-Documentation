set ORIGINAL_DIR=%cd%
set SCRIPT_DIR=%~dp0

cd %SCRIPT_DIR%
cmd /c "cd /d .. && npm install"
"../node_modules/hugo-extended/vendor/hugo" --minify --source ../ --destination dist --cleanDestinationDir --logLevel debug --panicOnWarning --config lutsk-aspose-prototype/config.toml,lutsk-aspose-prototype/configs/docs.aspose.com-cad.toml --contentDir content
cd %ORIGINAL_DIR%