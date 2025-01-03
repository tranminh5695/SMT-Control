<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSheetPlan
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
        Me.lbSheetPlan = New System.Windows.Forms.ListBox()
        Me.btnSelectSheetPlan = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbSheetPlan
        '
        Me.lbSheetPlan.FormattingEnabled = True
        Me.lbSheetPlan.Location = New System.Drawing.Point(12, 11)
        Me.lbSheetPlan.Name = "lbSheetPlan"
        Me.lbSheetPlan.Size = New System.Drawing.Size(209, 121)
        Me.lbSheetPlan.TabIndex = 0
        '
        'btnSelectSheetPlan
        '
        Me.btnSelectSheetPlan.Location = New System.Drawing.Point(27, 138)
        Me.btnSelectSheetPlan.Name = "btnSelectSheetPlan"
        Me.btnSelectSheetPlan.Size = New System.Drawing.Size(85, 22)
        Me.btnSelectSheetPlan.TabIndex = 1
        Me.btnSelectSheetPlan.Text = "Select"
        Me.btnSelectSheetPlan.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(118, 138)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 22)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSelectSheetPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 166)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelectSheetPlan)
        Me.Controls.Add(Me.lbSheetPlan)
        Me.Name = "frmSelectSheetPlan"
        Me.Text = "Select Sheet Plan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbSheetPlan As ListBox
    Friend WithEvents btnSelectSheetPlan As Button
    Friend WithEvents btnCancel As Button
End Class
