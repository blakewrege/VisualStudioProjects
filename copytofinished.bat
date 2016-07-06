::Author: Blake Wrege
::Created: 7/6/2016
cd %~dp0
DEL "Updater\Updater\bin\Debug\FileSharingAppClient.exe"
DEL "Updater\Updater\bin\Debug\FileSharingAppServer.exe"
copy "FileSharingApp\FileSharingAppClient\FileSharingAppClient\bin\Debug\FileSharingAppClient.exe" "Updater\Updater\bin\Debug"
copy "FileSharingApp\FileSharingAppServer\FileSharingAppServer\bin\Debug\FileSharingAppServer.exe" "Updater\Updater\bin\Debug"
pause