##################
#setup 
##################

Clear-Host

$arrTargetJavascriptFiles = @();
$arrTargetLessFiles = @();
$doOptimizeImages = $false;

#Change to the current script's directory
$scriptpath = $MyInvocation.MyCommand.Path;
$dir = Split-Path $scriptpath;
cd $dir;

#import modules
Import-Module (".\modules\minJS\minJS");
Import-Module (".\modules\image\Image.psm1");

#import executable
$fileOpt = Get-ChildItem -recurse | 
    Where-Object { $_.Name -match 'FileOptimizer64.exe'}

#change to the assets directory
cd ..
$assetsFolder = Get-ChildItem -Directory | 
    Where-Object { $_.Name -match 'assets-\d' }
cd $assetsFolder;

<#
TODO
Create the css directory if it doesn't exist.
In the meantime, just create it manually.
#>





##################
#process less
##################
Write-Host(@'
------------------
process lesscss
------------------
'@)
$lessFiles = Get-ChildItem -recurse -include *.less | 
    Where-Object { $arrTargetLessFiles.Count -eq 0 -or $arrTargetLessFiles -contains $_.BaseName }
foreach ($file in $lessFiles)
{       
    $savePath = $file.FullName -replace "less", "css";    
    lessc $file.FullName > $savePath; #run lesscss   
    Write-Host($savePath);
}





##################
#process js
##################
Write-Host(@'
------------------
process js
------------------
'@)
$jsFiles = Get-ChildItem -recurse -include *.js -exclude *.min.js | 
    Where-Object { $arrTargetJavascriptFiles.Count -eq 0 -or $arrTargetJavascriptFiles -contains $_.BaseName }
foreach ($file in $jsFiles)
{           
    $str = Get-Content -Path $file.FullName;
    $min = (minify -inputData $str -inputDataType "js");    
    $savePath = ($file.FullName -replace "`\.js", '.min.js');    
    $min | Out-File $savePath;    
    Write-Host($savePath);
}





##################
#resize images
##################
Write-Host(@'
------------------
resize images
------------------
'@)
$imgFiles = Get-ChildItem -recurse -include *.png, *jpeg, *jpg | 
    Where-Object { $_.BaseName -notlike "*-resize*" }

foreach ($file in $imgFiles)
{    
    $img = $file | Get-image

    #TODO save the original file in a folder called 'originals'

    $fullName = $img.FullName;
    $suffixIndex = $fullName.LastIndexOf('.');
    $aspectRatio = $img.Height / $img.Width;
    $newHeight = 0;

    $largeWidth = 1200;
    $desktopWidth = 980;
    $portraitTabletWidth = 768;
    $phoneToTabletWidth = 480;
    $phoneWidth = 320;

    Function ResizeAndRenameImage($newWidth, $newSuffix)
    {
        $newHeight = $aspectRatio * $newWidth;           
        $savePath = $fullName.Insert($suffixIndex,$newSuffix);
        $img.Resize($newWidth, $newHeight);
        #TODO over-write the file if it exists
        $img.SaveFile($savePath); 
    }

    ResizeAndRenameImage $largeWidth '-resizeLarge'
    ResizeAndRenameImage $desktopWidth '-resizeDesktop'
    ResizeAndRenameImage $portraitTabletWidth '-resizePortraitTablet'
    ResizeAndRenameImage $phoneToTabletWidth '-resizePhoneToTablet'
    ResizeAndRenameImage $phoneWidth '-resizePhone'
    
}


##################
#optimize images
##################
Write-Host(@'
------------------
optimize images
------------------
'@)
if($doOptimizeImages) {
    & $fileOpt.FullName $assetsFolder.FullName
} else {
    Write-Host('User opted out of image optimization');
}






##################
#prevent exiting
##################
Write-Host(@'
------------------
Press any key to exit.
------------------
'@)
Read-Host
Exit