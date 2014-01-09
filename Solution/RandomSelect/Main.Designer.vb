<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.LBItems = New System.Windows.Forms.ListBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBItems
        '
        Me.LBItems.FormattingEnabled = True
        Me.LBItems.Location = New System.Drawing.Point(13, 13)
        Me.LBItems.Name = "LBItems"
        Me.LBItems.Size = New System.Drawing.Size(285, 277)
        Me.LBItems.TabIndex = 8
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(305, 14)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(265, 110)
        Me.txtAdd.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(304, 159)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(171, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add to list"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(304, 188)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(171, 23)
        Me.btnImport.TabIndex = 3
        Me.btnImport.Text = "Import from list"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(304, 218)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(171, 23)
        Me.btnRandom.TabIndex = 4
        Me.btnRandom.Text = "Randomly select"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(304, 248)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(86, 13)
        Me.lblNo.TabIndex = 5
        Me.lblNo.Text = "Number of items:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(307, 265)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(13, 13)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "0"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(481, 159)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(481, 188)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(89, 23)
        Me.btnClearAll.TabIndex = 6
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(481, 218)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(89, 23)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(304, 130)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(265, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate Random Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 296)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.LBItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 335)
        Me.MinimumSize = New System.Drawing.Size(600, 335)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Select"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBItems As System.Windows.Forms.ListBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button

End Class
