<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumberToStartAt = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CollatzLog = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Number"
        '
        'NumberToStartAt
        '
        Me.NumberToStartAt.Location = New System.Drawing.Point(3, 16)
        Me.NumberToStartAt.Name = "NumberToStartAt"
        Me.NumberToStartAt.Size = New System.Drawing.Size(114, 20)
        Me.NumberToStartAt.TabIndex = 1
        Me.NumberToStartAt.Text = "1"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(3, 42)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(114, 23)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Begin"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(3, 71)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(114, 23)
        Me.StopButton.TabIndex = 3
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(3, 100)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Complete Log"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CollatzLog
        '
        Me.CollatzLog.Location = New System.Drawing.Point(123, 0)
        Me.CollatzLog.Name = "CollatzLog"
        Me.CollatzLog.Size = New System.Drawing.Size(166, 117)
        Me.CollatzLog.TabIndex = 5
        Me.CollatzLog.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 119)
        Me.Controls.Add(Me.CollatzLog)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.NumberToStartAt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Collatz Conjecture POC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NumberToStartAt As TextBox
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CollatzLog As RichTextBox
End Class
