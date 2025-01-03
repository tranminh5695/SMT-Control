<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDailyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyReport))
        Me.dgvTroubleImage = New System.Windows.Forms.DataGridView()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReportSaveData = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTroubleNote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStartDay = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLosstime = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEndDay = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dgvActionImage = New System.Windows.Forms.DataGridView()
        Me.txtActionNote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPlanLot = New System.Windows.Forms.TextBox()
        Me.cbLineSelect = New System.Windows.Forms.ComboBox()
        Me.cbMachineSelect = New System.Windows.Forms.ComboBox()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbActionImageShow = New System.Windows.Forms.PictureBox()
        Me.btnReportInfoRefresh = New System.Windows.Forms.Button()
        Me.pbTroubleImageShow = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbTypeReport = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbReportNumber = New System.Windows.Forms.Label()
        Me.ttMachineSelect = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttLot = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttNoteTrouble = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttNoteAction = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbReportStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ttLosstime = New System.Windows.Forms.ToolTip(Me.components)
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvTroubleImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvActionImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbActionImageShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTroubleImageShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTroubleImage
        '
        Me.dgvTroubleImage.AllowUserToAddRows = False
        Me.dgvTroubleImage.AllowUserToDeleteRows = False
        Me.dgvTroubleImage.AllowUserToResizeColumns = False
        Me.dgvTroubleImage.AllowUserToResizeRows = False
        Me.dgvTroubleImage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTroubleImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTroubleImage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Image})
        Me.dgvTroubleImage.Location = New System.Drawing.Point(7, 92)
        Me.dgvTroubleImage.MultiSelect = False
        Me.dgvTroubleImage.Name = "dgvTroubleImage"
        Me.dgvTroubleImage.RowHeadersWidth = 20
        Me.dgvTroubleImage.Size = New System.Drawing.Size(118, 476)
        Me.dgvTroubleImage.TabIndex = 68
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CustomFormat = "HH:mm"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTime.Location = New System.Drawing.Point(652, 49)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(53, 20)
        Me.dtpStartTime.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Machine"
        '
        'btnReportSaveData
        '
        Me.btnReportSaveData.Location = New System.Drawing.Point(1010, 43)
        Me.btnReportSaveData.Name = "btnReportSaveData"
        Me.btnReportSaveData.Size = New System.Drawing.Size(62, 32)
        Me.btnReportSaveData.TabIndex = 65
        Me.btnReportSaveData.Text = "Save"
        Me.btnReportSaveData.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(442, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "REPORT INFORMATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(231, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Trouble"
        '
        'txtTroubleNote
        '
        Me.txtTroubleNote.Location = New System.Drawing.Point(7, 574)
        Me.txtTroubleNote.Multiline = True
        Me.txtTroubleNote.Name = "txtTroubleNote"
        Me.txtTroubleNote.Size = New System.Drawing.Size(524, 130)
        Me.txtTroubleNote.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Line"
        '
        'dtpStartDay
        '
        Me.dtpStartDay.CustomFormat = "dd-MM-yy"
        Me.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDay.Location = New System.Drawing.Point(710, 49)
        Me.dtpStartDay.Name = "dtpStartDay"
        Me.dtpStartDay.Size = New System.Drawing.Size(66, 20)
        Me.dtpStartDay.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(927, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Losstime"
        '
        'txtLosstime
        '
        Me.txtLosstime.Enabled = False
        Me.txtLosstime.Location = New System.Drawing.Point(930, 49)
        Me.txtLosstime.Name = "txtLosstime"
        Me.txtLosstime.Size = New System.Drawing.Size(57, 20)
        Me.txtLosstime.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(984, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 16)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "min"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(648, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Start time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(775, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "~"
        '
        'dtpEndDay
        '
        Me.dtpEndDay.CustomFormat = "dd-MM-yy"
        Me.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDay.Location = New System.Drawing.Point(852, 49)
        Me.dtpEndDay.Name = "dtpEndDay"
        Me.dtpEndDay.Size = New System.Drawing.Size(66, 20)
        Me.dtpEndDay.TabIndex = 82
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "HH:mm"
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndTime.Location = New System.Drawing.Point(792, 49)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(53, 20)
        Me.dtpEndTime.TabIndex = 81
        '
        'dgvActionImage
        '
        Me.dgvActionImage.AllowUserToAddRows = False
        Me.dgvActionImage.AllowUserToDeleteRows = False
        Me.dgvActionImage.AllowUserToResizeColumns = False
        Me.dgvActionImage.AllowUserToResizeRows = False
        Me.dgvActionImage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActionImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActionImage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1})
        Me.dgvActionImage.Location = New System.Drawing.Point(548, 92)
        Me.dgvActionImage.MultiSelect = False
        Me.dgvActionImage.Name = "dgvActionImage"
        Me.dgvActionImage.RowHeadersWidth = 20
        Me.dgvActionImage.Size = New System.Drawing.Size(118, 476)
        Me.dgvActionImage.TabIndex = 86
        '
        'txtActionNote
        '
        Me.txtActionNote.Location = New System.Drawing.Point(548, 574)
        Me.txtActionNote.Multiline = True
        Me.txtActionNote.Name = "txtActionNote"
        Me.txtActionNote.Size = New System.Drawing.Size(524, 130)
        Me.txtActionNote.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(828, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Action"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(322, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 16)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Lot"
        '
        'txtPlanLot
        '
        Me.txtPlanLot.Location = New System.Drawing.Point(325, 49)
        Me.txtPlanLot.Name = "txtPlanLot"
        Me.txtPlanLot.Size = New System.Drawing.Size(318, 20)
        Me.txtPlanLot.TabIndex = 89
        '
        'cbLineSelect
        '
        Me.cbLineSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLineSelect.FormattingEnabled = True
        Me.cbLineSelect.Location = New System.Drawing.Point(10, 49)
        Me.cbLineSelect.Name = "cbLineSelect"
        Me.cbLineSelect.Size = New System.Drawing.Size(36, 21)
        Me.cbLineSelect.TabIndex = 90
        '
        'cbMachineSelect
        '
        Me.cbMachineSelect.AllowDrop = True
        Me.cbMachineSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbMachineSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMachineSelect.FormattingEnabled = True
        Me.cbMachineSelect.Location = New System.Drawing.Point(56, 49)
        Me.cbMachineSelect.Name = "cbMachineSelect"
        Me.cbMachineSelect.Size = New System.Drawing.Size(92, 21)
        Me.cbMachineSelect.TabIndex = 91
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Image"
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 96
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(538, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2, 612)
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'pbActionImageShow
        '
        Me.pbActionImageShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbActionImageShow.Location = New System.Drawing.Point(672, 92)
        Me.pbActionImageShow.Name = "pbActionImageShow"
        Me.pbActionImageShow.Size = New System.Drawing.Size(400, 476)
        Me.pbActionImageShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbActionImageShow.TabIndex = 84
        Me.pbActionImageShow.TabStop = False
        '
        'btnReportInfoRefresh
        '
        Me.btnReportInfoRefresh.BackColor = System.Drawing.Color.PowderBlue
        Me.btnReportInfoRefresh.Image = CType(resources.GetObject("btnReportInfoRefresh.Image"), System.Drawing.Image)
        Me.btnReportInfoRefresh.Location = New System.Drawing.Point(656, 3)
        Me.btnReportInfoRefresh.Name = "btnReportInfoRefresh"
        Me.btnReportInfoRefresh.Size = New System.Drawing.Size(26, 24)
        Me.btnReportInfoRefresh.TabIndex = 69
        Me.btnReportInfoRefresh.UseVisualStyleBackColor = False
        '
        'pbTroubleImageShow
        '
        Me.pbTroubleImageShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbTroubleImageShow.Location = New System.Drawing.Point(131, 92)
        Me.pbTroubleImageShow.Name = "pbTroubleImageShow"
        Me.pbTroubleImageShow.Size = New System.Drawing.Size(400, 476)
        Me.pbTroubleImageShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTroubleImageShow.TabIndex = 55
        Me.pbTroubleImageShow.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(154, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Type"
        '
        'cbTypeReport
        '
        Me.cbTypeReport.AllowDrop = True
        Me.cbTypeReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTypeReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTypeReport.FormattingEnabled = True
        Me.cbTypeReport.Location = New System.Drawing.Point(157, 49)
        Me.cbTypeReport.Name = "cbTypeReport"
        Me.cbTypeReport.Size = New System.Drawing.Size(78, 21)
        Me.cbTypeReport.TabIndex = 94
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(789, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "End time"
        '
        'lbReportNumber
        '
        Me.lbReportNumber.AutoSize = True
        Me.lbReportNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReportNumber.Location = New System.Drawing.Point(7, 5)
        Me.lbReportNumber.Name = "lbReportNumber"
        Me.lbReportNumber.Size = New System.Drawing.Size(59, 13)
        Me.lbReportNumber.TabIndex = 96
        Me.lbReportNumber.Text = "Report No."
        '
        'ttMachineSelect
        '
        Me.ttMachineSelect.ForeColor = System.Drawing.Color.Red
        Me.ttMachineSelect.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'ttLot
        '
        Me.ttLot.ForeColor = System.Drawing.Color.Red
        Me.ttLot.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'ttNoteTrouble
        '
        Me.ttNoteTrouble.ForeColor = System.Drawing.Color.Red
        Me.ttNoteTrouble.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'ttNoteAction
        '
        Me.ttNoteAction.ForeColor = System.Drawing.Color.Red
        Me.ttNoteAction.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'cbReportStatus
        '
        Me.cbReportStatus.AllowDrop = True
        Me.cbReportStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbReportStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbReportStatus.FormattingEnabled = True
        Me.cbReportStatus.Location = New System.Drawing.Point(241, 49)
        Me.cbReportStatus.Name = "cbReportStatus"
        Me.cbReportStatus.Size = New System.Drawing.Size(78, 21)
        Me.cbReportStatus.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(238, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Status"
        '
        'ttLosstime
        '
        Me.ttLosstime.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'Image
        '
        Me.Image.HeaderText = "Image"
        Me.Image.Image = CType(resources.GetObject("Image.Image"), System.Drawing.Image)
        Me.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image.Name = "Image"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Image"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'frmDailyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1079, 710)
        Me.Controls.Add(Me.cbReportStatus)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbReportNumber)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbTypeReport)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnReportSaveData)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbMachineSelect)
        Me.Controls.Add(Me.cbLineSelect)
        Me.Controls.Add(Me.txtPlanLot)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvActionImage)
        Me.Controls.Add(Me.txtActionNote)
        Me.Controls.Add(Me.pbActionImageShow)
        Me.Controls.Add(Me.dtpEndDay)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLosstime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpStartDay)
        Me.Controls.Add(Me.btnReportInfoRefresh)
        Me.Controls.Add(Me.dgvTroubleImage)
        Me.Controls.Add(Me.dtpStartTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTroubleNote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbTroubleImageShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailyReport"
        Me.Text = "Report Issue"
        CType(Me.dgvTroubleImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvActionImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbActionImageShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTroubleImageShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReportInfoRefresh As Button
    Friend WithEvents dgvTroubleImage As DataGridView
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReportSaveData As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTroubleNote As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbTroubleImageShow As PictureBox
    Friend WithEvents dtpStartDay As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLosstime As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpEndDay As DateTimePicker
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents dgvActionImage As DataGridView
    Friend WithEvents txtActionNote As TextBox
    Friend WithEvents pbActionImageShow As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPlanLot As TextBox
    Friend WithEvents cbLineSelect As ComboBox
    Friend WithEvents cbMachineSelect As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents cbTypeReport As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbReportNumber As Label
    Friend WithEvents ttMachineSelect As ToolTip
    Friend WithEvents ttLot As ToolTip
    Friend WithEvents ttNoteTrouble As ToolTip
    Friend WithEvents ttNoteAction As ToolTip
    Friend WithEvents cbReportStatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ttLosstime As ToolTip
    Friend WithEvents Image As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
