import { defineConfig } from 'vite';
import { importAssertionsPlugin } from 'rollup-plugin-import-assert';
import { importAssertions } from 'acorn-import-assertions';
import fs from 'fs';

export default defineConfig({
    // server: {
    //     https: {
    //         key: fs.readFileSync('./.ssl/localhost.key'),
    //         cert: fs.readFileSync('./.ssl/localhost.pem'),
    //     },
    // },
    build: {
        rollupOptions: {
            acornInjectPlugins: [ importAssertions ],
            plugins: [ importAssertionsPlugin() ]
        }
    }
})