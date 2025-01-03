<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileTypeExport
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
        Me.btnExcelType = New System.Windows.Forms.Button()
        Me.btnTextType = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTopSide = New System.Windows.Forms.Button()
        Me.btnBotSide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExcelType
        '
        Me.btnExcelType.Location = New System.Drawing.Point(12, 32)
        Me.btnExcelType.Name = "btnExcelType"
        Me.btnExcelType.Size = New System.Drawing.Size(95, 29)
        Me.btnExcelType.TabIndex = 0
        Me.btnExcelType.Text = "Excel File"
        Me.btnExcelType.UseVisualStyleBackColor = True
        '
        'btnTextType
        '
        Me.btnTextType.Location = New System.Drawing.Point(123, 32)
        Me.btnTextType.Name = "btnTextType"
        Me.btnTextType.Size = New System.Drawing.Size(95, 29)
        Me.btnTextType.TabIndex = 1
        Me.btnTextType.Text = "Text File"
        Me.btnTextType.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Chọn file muốn xuất "
        '
        'btnTopSide
        '
        Me.btnTopSide.Location = New System.Drawing.Point(12, 32)
        Me.btnTopSide.Name = "btnTopSide"
        Me.btnTopSide.Size = New System.Drawing.Size(95, 29)
        Me.btnTopSide.TabIndex = 3
        Me.btnTopSide.Text = "Top"
        Me.btnTopSide.UseVisualStyleBackColor = True
        '
        'btnBotSide
        '
        Me.btnBotSide.Location = New System.Drawing.Point(123, 33)
        Me.btnBotSide.Name = "btnBotSide"
        Me.btnBotSide.Size = New System.Drawing.Size(95, 29)
        Me.btnBotSide.TabIndex = 4
        Me.btnBotSide.Text = "Bot"
        Me.btnBotSide.UseVisualStyleBackColor = True
        '
        'frmFileTypeExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 74)
        Me.Controls.Add(Me.btnBotSide)
        Me.Controls.Add(Me.btnTopSide)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTextType)
        Me.Controls.Add(Me.btnExcelType)
        Me.Name = "frmFileTypeExport"
        Me.Text = "Thông báo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExcelType As Button
    Friend WithEvents btnTextType As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTopSide As Button
    Friend WithEvents btnBotSide As Button
End Class
