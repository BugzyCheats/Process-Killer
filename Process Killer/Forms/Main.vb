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
            If ProcessName.Text.Contains(".exe") Then
                MsgBox("Please remove the process extension.", MsgBoxStyle.Critical, "Process Killer")
            Else
                Kill() 'Immediately stops the associated process.
                MsgBox("Killed " + ProcessName.Text + ".exe", MsgBoxStyle.Information, "Process Killer")

                If ExitApplication.Checked = True Then
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub Source_Click(sender As Object, e As EventArgs) Handles Source.Click
        Process.Start("https://github.com/RealBugzy/Process-Killer")
    End Sub
End Class