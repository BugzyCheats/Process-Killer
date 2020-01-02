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
        Me.ControlBox = New Process_Killer.UbuntuControlBox()
        Me.KillProcess = New Process_Killer.UbuntuButtonOrange()
        Me.ProcessName = New Process_Killer.UbuntuTextBox()
        Me.ExitApplication = New Process_Killer.UbuntuCheckBox()
        Me.MainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainForm
        '
        Me.MainForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.MainForm.Controls.Add(Me.ExitApplication)
        Me.MainForm.Controls.Add(Me.ControlBox)
        Me.MainForm.Controls.Add(Me.KillProcess)
        Me.MainForm.Controls.Add(Me.ProcessName)
        Me.MainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainForm.Location = New System.Drawing.Point(0, 0)
        Me.MainForm.Name = "MainForm"
        Me.MainForm.Size = New System.Drawing.Size(374, 119)
        Me.MainForm.TabIndex = 0
        Me.MainForm.Text = "Process Killer"
        '
        'ControlBox
        '
        Me.ControlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBox.BackColor = System.Drawing.Color.Transparent
        Me.ControlBox.Font = New System.Drawing.Font("Marlett", 7.0!)
        Me.ControlBox.Location = New System.Drawing.Point(309, 2)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Size = New System.Drawing.Size(75, 23)
        Me.ControlBox.TabIndex = 2
        Me.ControlBox.Text = "UbuntuControlBox1"
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
        'ExitApplication
        '
        Me.ExitApplication.BackColor = System.Drawing.Color.White
        Me.ExitApplication.Checked = False
        Me.ExitApplication.ForeColor = System.Drawing.Color.Maroon
        Me.ExitApplication.Location = New System.Drawing.Point(12, 96)
        Me.ExitApplication.Name = "ExitApplication"
        Me.ExitApplication.Size = New System.Drawing.Size(145, 14)
        Me.ExitApplication.TabIndex = 3
        Me.ExitApplication.Text = "Exit application on kill"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 119)
        Me.Controls.Add(Me.MainForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MainForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainForm As UbuntuTheme
    Friend WithEvents KillProcess As UbuntuButtonOrange
    Friend WithEvents ProcessName As UbuntuTextBox
    Friend WithEvents ControlBox As UbuntuControlBox
    Friend WithEvents ExitApplication As UbuntuCheckBox
End Class
