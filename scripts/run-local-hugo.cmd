cmd /c "cd /d .. && npm install"
explorer http://localhost:1313/cad
"../node_modules/hugo-extended/vendor/hugo" server --source ../ --logLevel debug --panicOnWarning --baseURL http://localhost:1313/cad --config lutsk-aspose-prototype/config.toml,lutsk-aspose-prototype/configs/docs.aspose.com-cad.toml --contentDir content --disableFastRender