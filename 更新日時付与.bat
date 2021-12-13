@echo off
for %%i in (%1) do (
  set tmp=%%~ti
)
set year=%tmp:~0,4%
set month=%tmp:~5,2%
set date=%tmp:~8,2%
set hour=%tmp:~11,2%
set min=%tmp:~14,2%
set sec=%tep:~17,2%
set dt=%year%%month%%date%%hour%%min%

cd "%~dp1"
rename "%~nx1" "%dt%_%~nx1"

https://az764295.vo.msecnd.net/stable/7db1a2b88f7557e0a43fec75b6ba7e50b3e9f77e/VSCode-win32-x64-1.63.0.zip
