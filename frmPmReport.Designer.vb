<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPmReport
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
        Dim DataGridViewCellStyle74 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle66 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle70 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle71 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle72 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle73 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle75 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle76 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle79 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle80 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPmReport))
        Me.dgvPmPlan = New System.Windows.Forms.DataGridView()
        Me.PmLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PmMachine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PmPic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PmContent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PmDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PmStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PmImgBefore1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PmImgBefore2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PmImgBefore3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PmImgAfter1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PmImgAfter2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PmImgAfter3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PmDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbPmLine = New System.Windows.Forms.CheckedListBox()
        Me.cbPmMachine = New System.Windows.Forms.CheckedListBox()
        Me.dtpPmDateSelect = New System.Windows.Forms.DateTimePicker()
        Me.btnEcnSaveData = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnReportInfoRefresh = New System.Windows.Forms.Button()
        Me.pbPmImageBefore = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbPmImageAfter = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPmPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPmImageBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPmImageAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPmPlan
        '
        Me.dgvPmPlan.AllowDrop = True
        Me.dgvPmPlan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPmPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPmPlan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PmLine, Me.PmMachine, Me.PmPic, Me.PmContent, Me.PmDetail, Me.PmStatus, Me.PmImgBefore1, Me.PmImgBefore2, Me.PmImgBefore3, Me.PmImgAfter1, Me.PmImgAfter2, Me.PmImgAfter3, Me.PmDelete})
        DataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle74.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPmPlan.DefaultCellStyle = DataGridViewCellStyle74
        Me.dgvPmPlan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvPmPlan.Location = New System.Drawing.Point(12, 369)
        Me.dgvPmPlan.Name = "dgvPmPlan"
        Me.dgvPmPlan.RowHeadersWidth = 24
        Me.dgvPmPlan.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPmPlan.RowTemplate.Height = 80
        Me.dgvPmPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPmPlan.Size = New System.Drawing.Size(1055, 329)
        Me.dgvPmPlan.TabIndex = 0
        '
        'PmLine
        '
        Me.PmLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PmLine.DefaultCellStyle = DataGridViewCellStyle61
        Me.PmLine.FillWeight = 40.0!
        Me.PmLine.HeaderText = "Line"
        Me.PmLine.Name = "PmLine"
        Me.PmLine.ReadOnly = True
        Me.PmLine.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PmMachine
        '
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.PmMachine.DefaultCellStyle = DataGridViewCellStyle62
        Me.PmMachine.HeaderText = "Machine"
        Me.PmMachine.Name = "PmMachine"
        Me.PmMachine.ReadOnly = True
        '
        'PmPic
        '
        Me.PmPic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PmPic.DefaultCellStyle = DataGridViewCellStyle63
        Me.PmPic.FillWeight = 70.0!
        Me.PmPic.HeaderText = "PIC"
        Me.PmPic.Name = "PmPic"
        Me.PmPic.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PmPic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PmContent
        '
        Me.PmContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PmContent.DefaultCellStyle = DataGridViewCellStyle64
        Me.PmContent.FillWeight = 130.0!
        Me.PmContent.HeaderText = "Content"
        Me.PmContent.Name = "PmContent"
        '
        'PmDetail
        '
        Me.PmDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PmDetail.DefaultCellStyle = DataGridViewCellStyle65
        Me.PmDetail.FillWeight = 130.0!
        Me.PmDetail.HeaderText = "Detail"
        Me.PmDetail.Name = "PmDetail"
        '
        'PmStatus
        '
        Me.PmStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.PmStatus.DefaultCellStyle = DataGridViewCellStyle66
        Me.PmStatus.FillWeight = 50.0!
        Me.PmStatus.HeaderText = "Status"
        Me.PmStatus.Items.AddRange(New Object() {"Pending", "Done"})
        Me.PmStatus.Name = "PmStatus"
        '
        'PmImgBefore1
        '
        Me.PmImgBefore1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle67.NullValue = "ompareBOM.My.Resources.Resources.iconpictureempty"
        Me.PmImgBefore1.DefaultCellStyle = DataGridViewCellStyle67
        Me.PmImgBefore1.FillWeight = 40.0!
        Me.PmImgBefore1.HeaderText = "Before"
        Me.PmImgBefore1.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.PmImgBefore1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PmImgBefore1.Name = "PmImgBefore1"
        '
        'PmImgBefore2
        '
        Me.PmImgBefore2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle68.NullValue = "System.Drawing.Bitmap"
        Me.PmImgBefore2.DefaultCellStyle = DataGridViewCellStyle68
        Me.PmImgBefore2.FillWeight = 40.0!
        Me.PmImgBefore2.HeaderText = ""
        Me.PmImgBefore2.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.PmImgBefore2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PmImgBefore2.Name = "PmImgBefore2"
        '
        'PmImgBefore3
        '
        Me.PmImgBefore3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle69.NullValue = "System.Drawing.Bitmap"
        Me.PmImgBefore3.DefaultCellStyle = DataGridViewCellStyle69
        Me.PmImgBefore3.FillWeight = 40.0!
        Me.PmImgBefore3.HeaderText = ""
        Me.PmImgBefore3.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.PmImgBefore3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PmImgBefore3.Name = "PmImgBefore3"
        '
        'PmImgAfter1
        '
        Me.PmImgAfter1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle70.NullValue = "System.Drawing.Bitmap"
        Me.PmImgAfter1.DefaultCellStyle = DataGridViewCellStyle70
        Me.PmImgAfter1.FillWeight = 40.0!
        Me.PmImgAfter1.HeaderText = "After"
        Me.PmImgAfter1.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.PmImgAfter1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PmImgAfter1.Name = "PmImgAfter1"
        '
        'PmImgAfter2
        '
        Me.PmImgAfter2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle71.NullValue = "System.Drawing.Bitmap"
        Me.PmImgAfter2.DefaultCellStyle = DataGridViewCellStyle71
        Me.PmImgAfter2.FillWeight = 40.0!
        Me.PmImgAfter2.HeaderText = ""
        Me.PmImgAfter2.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.PmImgAfter2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PmImgAfter2.Name = "PmImgAfter2"
        '
        'PmImgAfter3
        '
        Me.PmImgAfter3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle72.NullValue = "System.Drawing.Bitmap"
        Me.PmImgAfter3.DefaultCellStyle = DataGridViewCellStyle72
        Me.PmImgAfter3.FillWeight = 40.0!
        Me.PmImgAfter3.HeaderText = ""
        Me.PmImgAfter3.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.PmImgAfter3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PmImgAfter3.Name = "PmImgAfter3"
        '
        'PmDelete
        '
        Me.PmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle73.NullValue = "Delete"
        Me.PmDelete.DefaultCellStyle = DataGridViewCellStyle73
        Me.PmDelete.FillWeight = 35.0!
        Me.PmDelete.HeaderText = "Delete"
        Me.PmDelete.Name = "PmDelete"
        Me.PmDelete.Text = "Delete"
        Me.PmDelete.UseColumnTextForButtonValue = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 20)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "MAINTENANCE PM PLAN"
        '
        'cbPmLine
        '
        Me.cbPmLine.CheckOnClick = True
        Me.cbPmLine.FormattingEnabled = True
        Me.cbPmLine.Items.AddRange(New Object() {"All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbPmLine.Location = New System.Drawing.Point(48, 550)
        Me.cbPmLine.Name = "cbPmLine"
        Me.cbPmLine.Size = New System.Drawing.Size(92, 79)
        Me.cbPmLine.TabIndex = 73
        Me.cbPmLine.Visible = False
        '
        'cbPmMachine
        '
        Me.cbPmMachine.CheckOnClick = True
        Me.cbPmMachine.FormattingEnabled = True
        Me.cbPmMachine.Items.AddRange(New Object() {"All", "Printer", "Reflow", "PAOI", "MAOI", "SAOI", "Mounter#1", "Mounter#2", "Mounter#3", "Mounter#4", "Mounter#5", "Mounter#6", "Mounter#7", "WorkTable", "InLoader", "Unloader", "NG Buffer", "Vaccum Loader", "Feeder"})
        Me.cbPmMachine.Location = New System.Drawing.Point(146, 550)
        Me.cbPmMachine.Name = "cbPmMachine"
        Me.cbPmMachine.Size = New System.Drawing.Size(92, 79)
        Me.cbPmMachine.TabIndex = 75
        Me.cbPmMachine.Visible = False
        '
        'dtpPmDateSelect
        '
        Me.dtpPmDateSelect.CustomFormat = "dd-MM-yy"
        Me.dtpPmDateSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPmDateSelect.Location = New System.Drawing.Point(230, 12)
        Me.dtpPmDateSelect.Name = "dtpPmDateSelect"
        Me.dtpPmDateSelect.Size = New System.Drawing.Size(66, 20)
        Me.dtpPmDateSelect.TabIndex = 105
        '
        'btnEcnSaveData
        '
        Me.btnEcnSaveData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEcnSaveData.Location = New System.Drawing.Point(347, 3)
        Me.btnEcnSaveData.Name = "btnEcnSaveData"
        Me.btnEcnSaveData.Size = New System.Drawing.Size(103, 39)
        Me.btnEcnSaveData.TabIndex = 107
        Me.btnEcnSaveData.Text = "Save"
        Me.btnEcnSaveData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEcnSaveData.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle75.NullValue = "ompareBOM.My.Resources.Resources.iconpictureempty"
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle75
        Me.DataGridViewImageColumn1.FillWeight = 40.0!
        Me.DataGridViewImageColumn1.HeaderText = "Before"
        Me.DataGridViewImageColumn1.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle76.NullValue = "System.Drawing.Bitmap"
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle76
        Me.DataGridViewImageColumn2.FillWeight = 40.0!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle77.NullValue = "System.Drawing.Bitmap"
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle77
        Me.DataGridViewImageColumn3.FillWeight = 40.0!
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle78.NullValue = "System.Drawing.Bitmap"
        Me.DataGridViewImageColumn4.DefaultCellStyle = DataGridViewCellStyle78
        Me.DataGridViewImageColumn4.FillWeight = 40.0!
        Me.DataGridViewImageColumn4.HeaderText = "After"
        Me.DataGridViewImageColumn4.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle79.NullValue = "System.Drawing.Bitmap"
        Me.DataGridViewImageColumn5.DefaultCellStyle = DataGridViewCellStyle79
        Me.DataGridViewImageColumn5.FillWeight = 40.0!
        Me.DataGridViewImageColumn5.HeaderText = ""
        Me.DataGridViewImageColumn5.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle80.NullValue = "System.Drawing.Bitmap"
        Me.DataGridViewImageColumn6.DefaultCellStyle = DataGridViewCellStyle80
        Me.DataGridViewImageColumn6.FillWeight = 40.0!
        Me.DataGridViewImageColumn6.HeaderText = ""
        Me.DataGridViewImageColumn6.Image = Global.CompareBOM.My.Resources.Resources.iconwhite
        Me.DataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        '
        'btnReportInfoRefresh
        '
        Me.btnReportInfoRefresh.BackColor = System.Drawing.Color.PowderBlue
        Me.btnReportInfoRefresh.Image = CType(resources.GetObject("btnReportInfoRefresh.Image"), System.Drawing.Image)
        Me.btnReportInfoRefresh.Location = New System.Drawing.Point(302, 10)
        Me.btnReportInfoRefresh.Name = "btnReportInfoRefresh"
        Me.btnReportInfoRefresh.Size = New System.Drawing.Size(26, 24)
        Me.btnReportInfoRefresh.TabIndex = 71
        Me.btnReportInfoRefresh.UseVisualStyleBackColor = False
        '
        'pbPmImageBefore
        '
        Me.pbPmImageBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPmImageBefore.Location = New System.Drawing.Point(12, 57)
        Me.pbPmImageBefore.Name = "pbPmImageBefore"
        Me.pbPmImageBefore.Size = New System.Drawing.Size(523, 306)
        Me.pbPmImageBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPmImageBefore.TabIndex = 1
        Me.pbPmImageBefore.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Before"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(779, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "After"
        '
        'pbPmImageAfter
        '
        Me.pbPmImageAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPmImageAfter.Location = New System.Drawing.Point(544, 57)
        Me.pbPmImageAfter.Name = "pbPmImageAfter"
        Me.pbPmImageAfter.Size = New System.Drawing.Size(523, 306)
        Me.pbPmImageAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPmImageAfter.TabIndex = 110
        Me.pbPmImageAfter.TabStop = False
        '
        'frmPmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 710)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbPmImageAfter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEcnSaveData)
        Me.Controls.Add(Me.cbPmMachine)
        Me.Controls.Add(Me.cbPmLine)
        Me.Controls.Add(Me.dtpPmDateSelect)
        Me.Controls.Add(Me.btnReportInfoRefresh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pbPmImageBefore)
        Me.Controls.Add(Me.dgvPmPlan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPmReport"
        Me.Text = "PM Report"
        CType(Me.dgvPmPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPmImageBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPmImageAfter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbPmImageBefore As PictureBox
    Friend WithEvents btnReportInfoRefresh As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbPmLine As CheckedListBox
    Friend WithEvents cbPmMachine As CheckedListBox
    Public WithEvents dgvPmPlan As DataGridView
    Friend WithEvents dtpPmDateSelect As DateTimePicker
    Friend WithEvents btnEcnSaveData As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents PmLine As DataGridViewTextBoxColumn
    Friend WithEvents PmMachine As DataGridViewTextBoxColumn
    Friend WithEvents PmPic As DataGridViewTextBoxColumn
    Friend WithEvents PmContent As DataGridViewTextBoxColumn
    Friend WithEvents PmDetail As DataGridViewTextBoxColumn
    Friend WithEvents PmStatus As DataGridViewComboBoxColumn
    Friend WithEvents PmImgBefore1 As DataGridViewImageColumn
    Friend WithEvents PmImgBefore2 As DataGridViewImageColumn
    Friend WithEvents PmImgBefore3 As DataGridViewImageColumn
    Friend WithEvents PmImgAfter1 As DataGridViewImageColumn
    Friend WithEvents PmImgAfter2 As DataGridViewImageColumn
    Friend WithEvents PmImgAfter3 As DataGridViewImageColumn
    Friend WithEvents PmDelete As DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents pbPmImageAfter As PictureBox
End Class
