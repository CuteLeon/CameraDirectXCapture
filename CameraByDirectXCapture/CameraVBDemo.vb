Imports DirectX.Capture

'DirectX.Show不支持单帧的截取
'但是可以录制音频和视频

Public Class CameraTestForm
    '在窗口列表中寻找与指定条件相符的第一个子窗口
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As Integer, ByVal hWnd2 As Integer, ByVal lpsz1 As String, ByVal lpsz2 As String) As Integer

    Dim MyFilters As Filters = New Filters
    Dim MyCapture As Capture = New Capture(MyFilters.VideoInputDevices(0), MyFilters.AudioInputDevices(0))

    Private Sub CameraTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyCapture.PreviewWindow = Panel1
        MyCapture.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VideoRendererHandle As Integer = FindWindowEx(Panel1.Handle, 0, "VideoRenderer", "ActiveMovie Window")
        MsgBox(VideoRendererHandle,, "监视区域的句柄")

        '我尝试了使用 PrintWindow API获取句柄的图像，但是逻辑不对，有时获取的图像是空的
    End Sub

End Class
