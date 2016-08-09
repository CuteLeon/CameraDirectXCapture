
---------------------------------------------------------------------

 DirectX.Capture
 A .NET class library for video and audio capture to AVI files.
 
 
 
 Demo:
 If you downloaded the demo application run:
    CaptureTest\bin\Release\CaptureTest.exe
 
 
 
 Project Layout:
 
 \DShowNET\             The DirectShow interop layer. The compiled
                        DShowNET must be in the same folder as
                        DirectX.Capture.dll. When you add a reference
                        to DirectX.Capture, VisualStudio.NET should
                        automatically copy this dll as well.
 
 \DirectX.Capture\      The class library. To use in your own project, 
                        add a reference to this project or the compiled dll.
                     
 \CaptureTest\          The sample app. Demonstrates the class library.
 
 \DirectX.Capture.sln   A VisualStudio.NET solution containing the above
                        three projects. Should be ready to run.
                      
 \DirectX.Capture.chm   Documentation and examples on using this 
                        class library



  Copyright (c) 2003 Brian Low
---------------------------------------------------------------------
