::Author: Blake Wrege
::Created: 7/6/2016
cd %~dp0
DEL "FileSharingAppBETA\FileSharingAppClient.exe"
DEL "FileSharingAppBETA\FileSharingAppServer.exe"
copy "FileSharingApp\FileSharingAppClient\FileSharingAppClient\bin\Debug\FileSharingAppClient.exe" "Updater\Updater\bin\Debug"
copy "FileSharingApp\FileSharingAppServer\FileSharingAppServer\bin\Debug\FileSharingAppServer.exe" "Updater\Updater\bin\Debug"
pause