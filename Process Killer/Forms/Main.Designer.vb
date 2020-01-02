<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainForm = New Process_Killer.UbuntuTheme()
        Me.KillProcess = New Process_Killer.UbuntuButtonOrange()
        Me.ProcessName = New Process_Killer.UbuntuTextBox()
        Me.MainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainForm
        '
        Me.MainForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.MainForm.Controls.Add(Me.KillProcess)
        Me.MainForm.Controls.Add(Me.ProcessName)
        Me.MainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainForm.Location = New System.Drawing.Point(0, 0)
        Me.MainForm.Name = "MainForm"
        Me.MainForm.Size = New System.Drawing.Size(374, 102)
        Me.MainForm.TabIndex = 0
        Me.MainForm.Text = "Process Killer"
        '
        'KillProcess
        '
        Me.KillProcess.BackColor = System.Drawing.Color.Transparent
        Me.KillProcess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KillProcess.Location = New System.Drawing.Point(12, 67)
        Me.KillProcess.Name = "KillProcess"
        Me.KillProcess.Size = New System.Drawing.Size(350, 23)
        Me.KillProcess.TabIndex = 1
        Me.KillProcess.Text = "Kill"
        '
        'ProcessName
        '
        Me.ProcessName.BackColor = System.Drawing.Color.White
        Me.ProcessName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ProcessName.Location = New System.Drawing.Point(12, 38)
        Me.ProcessName.MaxLength = 32767
        Me.ProcessName.Name = "ProcessName"
        Me.ProcessName.Size = New System.Drawing.Size(350, 26)
        Me.ProcessName.TabIndex = 0
        Me.ProcessName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.ProcessName.UseSystemPasswordChar = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 102)
        Me.Controls.Add(Me.MainForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MainForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainForm As UbuntuTheme
    Friend WithEvents KillProcess As UbuntuButtonOrange
    Friend WithEvents ProcessName As UbuntuTextBox
End Class
