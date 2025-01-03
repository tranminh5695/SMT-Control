<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportEcn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportEcn))
        Me.pbEcnShow = New System.Windows.Forms.PictureBox()
        Me.txtEcnCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEcnApplyWeek = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEcnPcb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEcnNote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEcnSaveData = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpEcnApplyDay = New System.Windows.Forms.DateTimePicker()
        Me.dgvEcnImport = New System.Windows.Forms.DataGridView()
        Me.btnEcnInfoRefresh = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Image1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Image2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Image3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Image4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Image5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Image6 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.pbEcnShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEcnImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbEcnShow
        '
        Me.pbEcnShow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbEcnShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEcnShow.Location = New System.Drawing.Point(323, 9)
        Me.pbEcnShow.Name = "pbEcnShow"
        Me.pbEcnShow.Size = New System.Drawing.Size(703, 533)
        Me.pbEcnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEcnShow.TabIndex = 0
        Me.pbEcnShow.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbEcnShow, "Double-click to copy image")
        '
        'txtEcnCode
        '
        Me.txtEcnCode.Location = New System.Drawing.Point(12, 54)
        Me.txtEcnCode.Name = "txtEcnCode"
        Me.txtEcnCode.Size = New System.Drawing.Size(302, 20)
        Me.txtEcnCode.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ECN Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Apply Week"
        '
        'txtEcnApplyWeek
        '
        Me.txtEcnApplyWeek.Location = New System.Drawing.Point(12, 142)
        Me.txtEcnApplyWeek.Name = "txtEcnApplyWeek"
        Me.txtEcnApplyWeek.Size = New System.Drawing.Size(302, 20)
        Me.txtEcnApplyWeek.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Apply Pcb"
        '
        'txtEcnPcb
        '
        Me.txtEcnPcb.Location = New System.Drawing.Point(12, 186)
        Me.txtEcnPcb.Multiline = True
        Me.txtEcnPcb.Name = "txtEcnPcb"
        Me.txtEcnPcb.Size = New System.Drawing.Size(302, 123)
        Me.txtEcnPcb.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Note"
        '
        'txtEcnNote
        '
        Me.txtEcnNote.Location = New System.Drawing.Point(12, 333)
        Me.txtEcnNote.Multiline = True
        Me.txtEcnNote.Name = "txtEcnNote"
        Me.txtEcnNote.Size = New System.Drawing.Size(305, 307)
        Me.txtEcnNote.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "ECN INFORMATION"
        '
        'btnEcnSaveData
        '
        Me.btnEcnSaveData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEcnSaveData.Location = New System.Drawing.Point(113, 649)
        Me.btnEcnSaveData.Name = "btnEcnSaveData"
        Me.btnEcnSaveData.Size = New System.Drawing.Size(103, 39)
        Me.btnEcnSaveData.TabIndex = 18
        Me.btnEcnSaveData.Text = "Save"
        Me.btnEcnSaveData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEcnSaveData.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Apply Day"
        '
        'dtpEcnApplyDay
        '
        Me.dtpEcnApplyDay.CustomFormat = "dd - MM - yyyy"
        Me.dtpEcnApplyDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEcnApplyDay.Location = New System.Drawing.Point(12, 98)
        Me.dtpEcnApplyDay.Name = "dtpEcnApplyDay"
        Me.dtpEcnApplyDay.Size = New System.Drawing.Size(302, 20)
        Me.dtpEcnApplyDay.TabIndex = 42
        '
        'dgvEcnImport
        '
        Me.dgvEcnImport.AllowUserToAddRows = False
        Me.dgvEcnImport.AllowUserToDeleteRows = False
        Me.dgvEcnImport.AllowUserToResizeColumns = False
        Me.dgvEcnImport.AllowUserToResizeRows = False
        Me.dgvEcnImport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEcnImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEcnImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEcnImport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Image1, Me.Image2, Me.Image3, Me.Image4, Me.Image5, Me.Image6})
        Me.dgvEcnImport.Location = New System.Drawing.Point(323, 548)
        Me.dgvEcnImport.MultiSelect = False
        Me.dgvEcnImport.Name = "dgvEcnImport"
        Me.dgvEcnImport.RowHeadersWidth = 20
        Me.dgvEcnImport.Size = New System.Drawing.Size(703, 140)
        Me.dgvEcnImport.TabIndex = 43
        '
        'btnEcnInfoRefresh
        '
        Me.btnEcnInfoRefresh.BackColor = System.Drawing.Color.PowderBlue
        Me.btnEcnInfoRefresh.Image = CType(resources.GetObject("btnEcnInfoRefresh.Image"), System.Drawing.Image)
        Me.btnEcnInfoRefresh.Location = New System.Drawing.Point(190, 7)
        Me.btnEcnInfoRefresh.Name = "btnEcnInfoRefresh"
        Me.btnEcnInfoRefresh.Size = New System.Drawing.Size(26, 24)
        Me.btnEcnInfoRefresh.TabIndex = 54
        Me.btnEcnInfoRefresh.UseVisualStyleBackColor = False
        '
        'Image1
        '
        Me.Image1.HeaderText = "Image 1"
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image1.Name = "Image1"
        '
        'Image2
        '
        Me.Image2.HeaderText = "Image 2"
        Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
        Me.Image2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image2.Name = "Image2"
        '
        'Image3
        '
        Me.Image3.HeaderText = "Image 3"
        Me.Image3.Image = CType(resources.GetObject("Image3.Image"), System.Drawing.Image)
        Me.Image3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image3.Name = "Image3"
        '
        'Image4
        '
        Me.Image4.HeaderText = "Image 4"
        Me.Image4.Image = CType(resources.GetObject("Image4.Image"), System.Drawing.Image)
        Me.Image4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image4.Name = "Image4"
        '
        'Image5
        '
        Me.Image5.HeaderText = "Image 5"
        Me.Image5.Image = CType(resources.GetObject("Image5.Image"), System.Drawing.Image)
        Me.Image5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image5.Name = "Image5"
        '
        'Image6
        '
        Me.Image6.HeaderText = "Image 6"
        Me.Image6.Image = CType(resources.GetObject("Image6.Image"), System.Drawing.Image)
        Me.Image6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image6.Name = "Image6"
        '
        'frmImportEcn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 700)
        Me.Controls.Add(Me.btnEcnInfoRefresh)
        Me.Controls.Add(Me.dgvEcnImport)
        Me.Controls.Add(Me.dtpEcnApplyDay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEcnSaveData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEcnNote)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEcnPcb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEcnApplyWeek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEcnCode)
        Me.Controls.Add(Me.pbEcnShow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImportEcn"
        Me.Text = "Import/Update Ecn"
        CType(Me.pbEcnShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEcnImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbEcnShow As PictureBox
    Friend WithEvents txtEcnCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEcnApplyWeek As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEcnPcb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEcnNote As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEcnSaveData As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpEcnApplyDay As DateTimePicker
    Friend WithEvents dgvEcnImport As DataGridView
    Friend WithEvents btnEcnInfoRefresh As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Image1 As DataGridViewImageColumn
    Friend WithEvents Image2 As DataGridViewImageColumn
    Friend WithEvents Image3 As DataGridViewImageColumn
    Friend WithEvents Image4 As DataGridViewImageColumn
    Friend WithEvents Image5 As DataGridViewImageColumn
    Friend WithEvents Image6 As DataGridViewImageColumn
End Class
