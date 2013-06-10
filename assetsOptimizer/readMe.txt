1 Copy the entire <assetOptimizer-Process> directory.
2 Paste it as a sibling (not a child) of your sites assets-N directory.
3 Edit the user preferences to choose what to process.
4 Run assetOptimizer-Process\process.ps1 in PowerShell.

Results
Compiles and minifies LESS. Saves the results as .min.css in a css sibling directory.
Minifies JAVASCRIPT. Saves the results as .min.js in the same directory.
Strips, compresses, and resizes IMAGES for responsive layouts. Save results in same directory.

Known Issues
-Sometimes pngout.exe crashes. Close pngout.exe if alerted to do so.