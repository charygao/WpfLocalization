REM  Template for re-embedding BAML and RESX resources into a localized assembly
REM  Pass:   a locale (de-DE) and main file name (WpfLocalization)
REM  ASSUME: If you have additional resource files beyond Properties.Resources.Resx 
REM          add them to al.exe command line
CLS
echo off

REM Parm1 is culture to translate to
REM Assumes: RES folder with de-DE.csv file
REM Assumes: Global Resources for de-DE exist
set culture=de
if NOT "%1" == "" (set culture=%1)
echo Culture: %culture%

set filename=WpfLocalizationLocBaml
if NOT "%2" == "" (set filename=%2)
echo Filename: %filename%

REM object path for compiled raw .resource files
set objPath=..\..\obj\debug
set objrelPath=..\...\obj\release

REM Generate raw .resource file in de-DE path so we can manually merge it with 
LocBaml.exe /generate %objPath%\%filename%.g.en-US.resources /trans:..\..\Res\%culture%.csv /out:%culture% /culture:%culture%


REM Combine resource files
REM ADD ANY RESOURCE FILES HERE EXPLICITLY WITH ADDITIONAL /embed switches
REM /embed:%objPath%\%filename%.Path.ResFileName.%culture%.resources
al /template:"%filename%.exe" /embed:%culture%\%filename%.g.%culture%.resources /embed:%objPath%\%filename%.Properties.Resources.%culture%.resources  /culture:%culture%  /out:%culture%\%filename%.resources.dll

REM remove the intermediate resource file
REM del "%culture%\%filename%.g.%culture%.resources" 

pause