Imports System.IO
Imports System.Threading

Public Class Main

    Public Sub Kill()
        For Each process As Process In Process.GetProcessesByName(ProcessName.Text)
            process.Kill()
        Next
    End Sub

    Private Sub KillProcess_Click(sender As Object, e As EventArgs) Handles KillProcess.Click
        If ProcessName.Text = "" Then
            MsgBox("Please enter a process name.", MsgBoxStyle.Information, "Process Killer")
        Else
            Kill()
            MsgBox("Killed " + ProcessName.Text, MsgBoxStyle.Information, "Process Killer")

            If ExitApplication.Checked = True Then
                Close()
            End If
        End If
    End Sub
End Class