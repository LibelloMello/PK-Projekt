cd C:\Users\Hallkvist\Desktop\FileFinderByWSDL
wsdl /out:FileService.cs http://localhost:15285/FileService.asmx?wsdl
csc /t:library /out:FileService.dll FileService.cs
csc /r:FileService.dll Client.cs
Client.exe
pause