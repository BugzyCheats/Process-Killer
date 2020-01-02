Imports System.IO
Imports System.Threading

Public Class Main

    Public Sub Kill()
        For Each process As Process In Process.GetProcessesByName(ProcessName.Text)
            process.Kill()
        Next
    End Sub

    Private Sub KillProcess_Click(sender As Object, e As EventArgs) Handles KillProcess.Click
        Kill()
    End Sub
End Class