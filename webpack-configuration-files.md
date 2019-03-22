## Please find below in which files you need to reconfigure webpack paths to files and such

* webpack.config.prod.js - here you'll find output and file paths that you'll need to change if for some reason you need to reconstruct the file structure that the starter kit comes with
* webpack.config.dev.js - same goes for this one as well
* in the "tools" folder you'll find all of the build tasks
```
    /tools
        - analyzeBundle.js - It will create an interactive treemap visualization of the contents of all your bundles.
        - build.js - that's the task triggered for production build of your files
        - chalkConfig.js - used to add color to console.log statements.
        - config.entry.js - those are your entry's for your files. When adding new file you also need to add it here if you want it to be compiled as a sepparate bundle.
        - distServer.js - used for browsersynk to open your production built files. Here you have the "baseDir" and "files" to reconfigure if needed.
        - srcServer.js - This file configures the development web server. Used for browsersynk to open your dev built files. Here you have the "baseDir" and "files" to reconfigure if needed.
        - startMessage.js - console-logs start message
        - nodeVersionCheck.js - checks the node versions.
```