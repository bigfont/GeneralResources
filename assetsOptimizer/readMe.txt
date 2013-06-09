1 Copy the entire <AssetOptimizer-Process> directory.
2 Paste it as a sibling (not a child) of the assets-N directory.
2 Run process.ps1 in PowerShell.

Results
LESS files are compiled, renamed to .css, and placed into a sibling css directory.
JAVASCRIPT files are minified, renamed to .min.js, and placed into the same directory.
IMAGES are stripped of metadata and compressed.

Known Issues
-Sometimes pngout.exe crashes. Close pngout.exe if alerted to do so.