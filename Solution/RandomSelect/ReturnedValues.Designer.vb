<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnedValues
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnedValues))
        Me.lbRandom = New System.Windows.Forms.ListBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbRandom
        '
        Me.lbRandom.FormattingEnabled = True
        Me.lbRandom.Location = New System.Drawing.Point(12, 26)
        Me.lbRandom.Name = "lbRandom"
        Me.lbRandom.Size = New System.Drawing.Size(359, 199)
        Me.lbRandom.TabIndex = 0
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(13, 10)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(124, 13)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Your list of random items:"
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(12, 231)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(359, 23)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "Write to file"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'ReturnedValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lbRandom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "ReturnedValues"
        Me.Text = "ReturnedValues"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbRandom As System.Windows.Forms.ListBox
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnWrite As System.Windows.Forms.Button
End Class
