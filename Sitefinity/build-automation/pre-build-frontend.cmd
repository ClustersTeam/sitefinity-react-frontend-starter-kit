@echo off

echo %1
cd %1

cd ..\
set PROJ_PATH=%CD%

cd %1

call yarn install
call yarn build