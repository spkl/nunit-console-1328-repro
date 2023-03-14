```
PS C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test> dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  nunit-console-1328-repro-lib -> C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-repro-lib\bin\Debug\net6.0-windows\nunit-console-1328-r
  epro-lib.dll
  nunit-console-1328-test -> C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\bin\Debug\net6.0-windows\nunit-console-1328-test.dll
Test run for C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\bin\Debug\net6.0-windows\nunit-console-1328-test.dll (.NETCoreApp,VersioTest run for C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\bin\Debug\net6.0-windows\nunit-console-1328-test.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 17.5.0 (x64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 5 s - nunit-console-1328-test.dll (net6.0)
PS C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test> cd .\bin\Debug\net6.0-windows\
PS C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\bin\Debug\net6.0-windows> &"C:\Users\Sebastian\Downloads\Chrome\NUnit.Console-3.16.2\bin\nunit3-console.exe" .\nunit-console-1328-test.dll
NUnit Console 3.16.2 (Release)
Copyright (c) 2022 Charlie Poole, Rob Prouse
Dienstag, 14. März 2023 18:57:18

Runtime Environment
   OS Version: Microsoft Windows NT 6.2.9200.0
   Runtime: .NET Framework CLR v4.0.30319.42000

Test Files
    .\nunit-console-1328-test.dll


Errors, Failures and Warnings

1) Error : nunit_console_1328_test.Tests.CanOpenAndCloseWindow1
System.DllNotFoundException : Unable to load DLL 'wpfgfx_cor3.dll' or one of its dependencies: Das angegebene Modul wurde nicht gefunden. (0x8007007E)
   at System.Windows.Interop.HwndTarget.AttachToHwnd(IntPtr hwnd)
   at System.Windows.Interop.HwndTarget..ctor(IntPtr hwnd)
   at System.Windows.Interop.HwndSource.Initialize(HwndSourceParameters parameters)
   at System.Windows.Interop.HwndSource..ctor(HwndSourceParameters parameters)
   at System.Windows.Window.CreateSourceWindow(Boolean duringShow)
   at System.Windows.Window.CreateSourceWindowDuringShow()
   at System.Windows.Window.SafeCreateWindowDuringShow()
   at System.Windows.Window.ShowHelper(Object booleanBox)
   at System.Windows.Window.Show()
   at nunit_console_1328_test.Tests.CanOpenAndCloseWindow1() in C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\UnitTest1.cs:line 21
   
Run Settings
    DisposeRunners: True
    WorkDirectory: C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\bin\Debug\net6.0-windows
    ImageRuntimeVersion: 4.0.30319
    ImageTargetFrameworkName: .NETCoreApp,Version=v6.0
    ImageRequiresX86: False
    ImageRequiresDefaultAppDomainAssemblyResolver: False
    TargetRuntimeFramework: netcore-6.0
    NumberOfTestWorkers: 4

Test Run Summary
  Overall result: Failed
  Test Count: 1, Passed: 0, Failed: 1, Warnings: 0, Inconclusive: 0, Skipped: 0
    Failed Tests - Failures: 0, Errors: 1, Invalid: 0
  Start time: 2023-03-14 17:57:19Z
    End time: 2023-03-14 17:57:19Z
    Duration: 0.825 seconds

Results (nunit3) saved as TestResult.xml
PS C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\bin\Debug\net6.0-windows> &"C:\Users\Sebastian\Downloads\Chrome\NUnit.Console-3.15.2\bin\net6.0\nunit3-console.exe" .\nunit-console-1328-test.dll
NUnit Console 3.15.2 (Release)
Copyright (c) 2022 Charlie Poole, Rob Prouse
Dienstag, 14. März 2023 18:58:29

Runtime Environment
   OS Version: Microsoft Windows 10.0.19044
  Runtime: .NET 6.0.14

Test Files
    .\nunit-console-1328-test.dll


Errors, Failures and Warnings

1) Error : nunit_console_1328_test.Tests.CanOpenAndCloseWindow1
System.IO.FileNotFoundException : Could not load file or assembly 'PresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'. Das System kann die angegebene Datei nicht finden.
   at nunit_console_1328_test.Tests.CanOpenAndCloseWindow1()

Run Settings
    DisposeRunners: True
    WorkDirectory: C:\Users\Sebastian\Source\Repos\nunit-console-1328-repro\nunit-console-1328-test\bin\Debug\net6.0-windows
    NumberOfTestWorkers: 4

Test Run Summary
  Overall result: Failed
  Test Count: 1, Passed: 0, Failed: 1, Warnings: 0, Inconclusive: 0, Skipped: 0
    Failed Tests - Failures: 0, Errors: 1, Invalid: 0
  Start time: 2023-03-14 17:58:29Z
    End time: 2023-03-14 17:58:30Z
    Duration: 0.179 seconds

Results (nunit3) saved as TestResult.xml
```