Clear-Host

#Change to the current script's directory
$scriptpath = $MyInvocation.MyCommand.Path;
$dir = Split-Path $scriptpath;
cd $dir;

#import the image module


#change to the assets-N directory
cd..


$img = dir *.jpg -recurse |
    Get-Image |
    Select-Object -First 1 

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
    $img.Resize($newWidth, $newHeight);
    $savePath = $fullName.Insert($suffixIndex,$newSuffix);
    $img.SaveFile($savePath);
    Write-Host $savePath;
}

ResizeAndRenameImage $largeWidth '-large'
ResizeAndRenameImage $desktopWidth '-desktop'
ResizeAndRenameImage $portraitTabletWidth '-portraitTablet'
ResizeAndRenameImage $phoneToTabletWidth '-phoneToTablet'
ResizeAndRenameImage $phoneWidth '-phone'

    
    