﻿# SentToDo - Desktop
Windows taskbar panel for displaying notes and tasks  
Tested on Windows 10 x64 Version 2004
> :warning: **The program is still in development**

![Alt text](Images/taskbar%201.png "Taskbar 1")

## Installing
Compile or download SentToDo release
Enter the dir with `SentToDo.dll` (`SentToDo\bin\Debug`) and run as admin:  
`%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /nologo /codebase SentToDo.dll`  
After restart `explorer` and select ToDoList panel on taskbar right click menu
  
To uninstall:  
`%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /unregister /nologo /codebase SentToDo.dll`  
And restart `explorer`