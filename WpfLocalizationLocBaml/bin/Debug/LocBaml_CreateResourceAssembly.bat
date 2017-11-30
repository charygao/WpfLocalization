CLS
ECHO OFF


REM Translate resources and write out full resource DLL 
REM NOTE: Works only if you have no other RESX Resources
LocBaml.exe /generate en-US/WpfLocalizationLocBaml.resources.dll /trans:Res/de.csv /out:de /culture:de

pause