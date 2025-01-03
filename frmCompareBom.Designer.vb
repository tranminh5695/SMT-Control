<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompareBom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompareBom))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbCopyRight = New System.Windows.Forms.Label()
        Me.ttButton = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbBomVersion2 = New System.Windows.Forms.CheckBox()
        Me.cbBomVersion1 = New System.Windows.Forms.CheckBox()
        Me.cbReportSkipDateFilter = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnCreateReport = New System.Windows.Forms.Button()
        Me.btnRefreshDailyReport = New System.Windows.Forms.Button()
        Me.btnAddPmPlan = New System.Windows.Forms.Button()
        Me.btnRefreshPmList = New System.Windows.Forms.Button()
        Me.Config = New System.Windows.Forms.TabPage()
        Me.btnRefreshConfigTable = New System.Windows.Forms.Button()
        Me.dgvDbConfig = New System.Windows.Forms.DataGridView()
        Me.DbName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateDb = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLineCount = New System.Windows.Forms.TextBox()
        Me.txtParentCodeFilter = New System.Windows.Forms.TextBox()
        Me.txtDescriptionFilter = New System.Windows.Forms.TextBox()
        Me.txtMaterialColFilter = New System.Windows.Forms.TextBox()
        Me.txtLocColFilter = New System.Windows.Forms.TextBox()
        Me.txtParentCode = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtMaterialCol = New System.Windows.Forms.TextBox()
        Me.txtLocCol = New System.Windows.Forms.TextBox()
        Me.btnLineCountUpdate = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.TabPage()
        Me.tabControlData = New System.Windows.Forms.TabControl()
        Me.TotalData = New System.Windows.Forms.TabPage()
        Me.btnRefreshDataTotal = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearchDataTotal = New System.Windows.Forms.TextBox()
        Me.dgvDataTotal = New System.Windows.Forms.DataGridView()
        Me.CadData = New System.Windows.Forms.TabPage()
        Me.dgvPcbSize = New System.Windows.Forms.DataGridView()
        Me.PCBDataCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCBLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCBWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCBThickness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCadDelete = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCadData = New System.Windows.Forms.TextBox()
        Me.lbCadList = New System.Windows.Forms.ListBox()
        Me.btnUpdateOtpInfo = New System.Windows.Forms.Button()
        Me.txtSearchImportCad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgvCadImport = New System.Windows.Forms.DataGridView()
        Me.btnImportCad = New System.Windows.Forms.Button()
        Me.dgvOtpInfo = New System.Windows.Forms.DataGridView()
        Me.BomData = New System.Windows.Forms.TabPage()
        Me.btnViewLocation = New System.Windows.Forms.Button()
        Me.btnCollapseAllBomTree = New System.Windows.Forms.Button()
        Me.btnExpandAllBomTree = New System.Windows.Forms.Button()
        Me.tvBomList = New System.Windows.Forms.TreeView()
        Me.btnBomDelete = New System.Windows.Forms.Button()
        Me.lbBomLastUpdate = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnBomExport = New System.Windows.Forms.Button()
        Me.dgvBomCodeView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pcb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBomData = New System.Windows.Forms.TextBox()
        Me.dgvBomOtp = New System.Windows.Forms.DataGridView()
        Me.txtSearchBom = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvBomData = New System.Windows.Forms.DataGridView()
        Me.btnImportBom = New System.Windows.Forms.Button()
        Me.MaterialData = New System.Windows.Forms.TabPage()
        Me.btnMaterialDataRefresh = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtMaterialData = New System.Windows.Forms.TextBox()
        Me.dgvMaterialData = New System.Windows.Forms.DataGridView()
        Me.EcnManager = New System.Windows.Forms.TabPage()
        Me.btnImportEcn = New System.Windows.Forms.Button()
        Me.btnRefreshEcnData = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtSearchEcn = New System.Windows.Forms.TextBox()
        Me.dgvEcnData = New System.Windows.Forms.DataGridView()
        Me.BomCompare = New System.Windows.Forms.TabPage()
        Me.tabControlBomCompare = New System.Windows.Forms.TabControl()
        Me.CompareBom = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbBomFilterSide = New System.Windows.Forms.ComboBox()
        Me.dgvCompareBomNoteInfo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clbBomCheckFilter = New System.Windows.Forms.CheckedListBox()
        Me.cbBomFilterData = New System.Windows.Forms.ComboBox()
        Me.txtBomFilter = New System.Windows.Forms.TextBox()
        Me.btnCompareBom = New System.Windows.Forms.Button()
        Me.btnExportBomCompare = New System.Windows.Forms.Button()
        Me.txtBom2 = New System.Windows.Forms.TextBox()
        Me.dgvCompareBom = New System.Windows.Forms.DataGridView()
        Me.lbBom2 = New System.Windows.Forms.ListBox()
        Me.lbBom1 = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtBom1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvBom1Code = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBom2Code = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCompareCount = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BomRelate = New System.Windows.Forms.TabPage()
        Me.dgvBomRelateOrg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbBomRelate = New System.Windows.Forms.ListBox()
        Me.txtRelateFilter = New System.Windows.Forms.TextBox()
        Me.cbRelateFilter = New System.Windows.Forms.ComboBox()
        Me.pbBomRelate = New System.Windows.Forms.ProgressBar()
        Me.txtBomRelate = New System.Windows.Forms.TextBox()
        Me.dgvBomRelate = New System.Windows.Forms.DataGridView()
        Me.btnBomRelate = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BomFilter = New System.Windows.Forms.TabPage()
        Me.lbProgressBar = New System.Windows.Forms.Label()
        Me.pbBomFilter = New System.Windows.Forms.ProgressBar()
        Me.txtFilePathSave = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtFilePathBom = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvListBomFilter = New System.Windows.Forms.DataGridView()
        Me.AssyCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BotCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcbCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramCheck = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnRefreshProgramCheckTable = New System.Windows.Forms.Button()
        Me.tabControlPgCheck = New System.Windows.Forms.TabControl()
        Me.AoiCheck = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtSearchCheckAoi = New System.Windows.Forms.TextBox()
        Me.dgvCheckAoi = New System.Windows.Forms.DataGridView()
        Me.MounterCheck = New System.Windows.Forms.TabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtSearchCheckMounter = New System.Windows.Forms.TextBox()
        Me.dgvCheckMounter = New System.Windows.Forms.DataGridView()
        Me.PrinterCheck = New System.Windows.Forms.TabPage()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtSearchCheckPrinter = New System.Windows.Forms.TextBox()
        Me.dgvCheckPrinter = New System.Windows.Forms.DataGridView()
        Me.DailyPlan = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpPlanDate = New System.Windows.Forms.DateTimePicker()
        Me.btnPlanRefresh = New System.Windows.Forms.Button()
        Me.btnExportPlan = New System.Windows.Forms.Button()
        Me.btnImportPlan = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbPlanShiftFilter = New System.Windows.Forms.ComboBox()
        Me.cbPlanLineFilter = New System.Windows.Forms.ComboBox()
        Me.txtPlanCodeFilter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPlan = New System.Windows.Forms.DataGridView()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.Maintenance = New System.Windows.Forms.TabPage()
        Me.tabControlMaintenance = New System.Windows.Forms.TabControl()
        Me.MachineReport = New System.Windows.Forms.TabPage()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cbReportMachine = New System.Windows.Forms.ComboBox()
        Me.cbReportLine = New System.Windows.Forms.ComboBox()
        Me.dtpReportEndDay = New System.Windows.Forms.DateTimePicker()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.dtpReportStartDay = New System.Windows.Forms.DateTimePicker()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtSearchReport = New System.Windows.Forms.TextBox()
        Me.dgvDailyReport = New System.Windows.Forms.DataGridView()
        Me.PmPlan = New System.Windows.Forms.TabPage()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvPmPlan = New System.Windows.Forms.DataGridView()
        Me.SparePart = New System.Windows.Forms.TabPage()
        Me.Improvement = New System.Windows.Forms.TabPage()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ttReportStartDay = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExportDailyReport = New System.Windows.Forms.Button()
        Me.Config.SuspendLayout()
        CType(Me.dgvDbConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data.SuspendLayout()
        Me.tabControlData.SuspendLayout()
        Me.TotalData.SuspendLayout()
        CType(Me.dgvDataTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CadData.SuspendLayout()
        CType(Me.dgvPcbSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCadImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOtpInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BomData.SuspendLayout()
        CType(Me.dgvBomCodeView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBomOtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBomData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialData.SuspendLayout()
        CType(Me.dgvMaterialData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EcnManager.SuspendLayout()
        CType(Me.dgvEcnData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BomCompare.SuspendLayout()
        Me.tabControlBomCompare.SuspendLayout()
        Me.CompareBom.SuspendLayout()
        CType(Me.dgvCompareBomNoteInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompareBom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBom1Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBom2Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompareCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BomRelate.SuspendLayout()
        CType(Me.dgvBomRelateOrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBomRelate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BomFilter.SuspendLayout()
        CType(Me.dgvListBomFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProgramCheck.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabControlPgCheck.SuspendLayout()
        Me.AoiCheck.SuspendLayout()
        CType(Me.dgvCheckAoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MounterCheck.SuspendLayout()
        CType(Me.dgvCheckMounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrinterCheck.SuspendLayout()
        CType(Me.dgvCheckPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DailyPlan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.Maintenance.SuspendLayout()
        Me.tabControlMaintenance.SuspendLayout()
        Me.MachineReport.SuspendLayout()
        CType(Me.dgvDailyReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PmPlan.SuspendLayout()
        CType(Me.dgvPmPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCopyRight
        '
        Me.lbCopyRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbCopyRight.AutoSize = True
        Me.lbCopyRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCopyRight.Location = New System.Drawing.Point(4, 720)
        Me.lbCopyRight.Name = "lbCopyRight"
        Me.lbCopyRight.Size = New System.Drawing.Size(118, 15)
        Me.lbCopyRight.TabIndex = 1
        Me.lbCopyRight.Text = "Created by T.N.Minh"
        '
        'cbBomVersion2
        '
        Me.cbBomVersion2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbBomVersion2.Location = New System.Drawing.Point(695, 4)
        Me.cbBomVersion2.Name = "cbBomVersion2"
        Me.cbBomVersion2.Size = New System.Drawing.Size(75, 23)
        Me.cbBomVersion2.TabIndex = 42
        Me.cbBomVersion2.Text = "Current Bom"
        Me.cbBomVersion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttButton.SetToolTip(Me.cbBomVersion2, "Chang to using Old Bom")
        Me.cbBomVersion2.UseVisualStyleBackColor = True
        '
        'cbBomVersion1
        '
        Me.cbBomVersion1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbBomVersion1.Location = New System.Drawing.Point(301, 4)
        Me.cbBomVersion1.Name = "cbBomVersion1"
        Me.cbBomVersion1.Size = New System.Drawing.Size(75, 23)
        Me.cbBomVersion1.TabIndex = 41
        Me.cbBomVersion1.Text = "Current Bom"
        Me.cbBomVersion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttButton.SetToolTip(Me.cbBomVersion1, "Change to using Old Bom")
        Me.cbBomVersion1.UseVisualStyleBackColor = True
        '
        'cbReportSkipDateFilter
        '
        Me.cbReportSkipDateFilter.AutoSize = True
        Me.cbReportSkipDateFilter.Checked = True
        Me.cbReportSkipDateFilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbReportSkipDateFilter.Location = New System.Drawing.Point(669, 34)
        Me.cbReportSkipDateFilter.Name = "cbReportSkipDateFilter"
        Me.cbReportSkipDateFilter.Size = New System.Drawing.Size(15, 14)
        Me.cbReportSkipDateFilter.TabIndex = 94
        Me.ttButton.SetToolTip(Me.cbReportSkipDateFilter, "Filter Day")
        Me.cbReportSkipDateFilter.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(441, 34)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 109
        Me.ttButton.SetToolTip(Me.CheckBox1, "Filter Day")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnCreateReport
        '
        Me.btnCreateReport.Image = CType(resources.GetObject("btnCreateReport.Image"), System.Drawing.Image)
        Me.btnCreateReport.Location = New System.Drawing.Point(739, 29)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(26, 24)
        Me.btnCreateReport.TabIndex = 64
        Me.ttButton.SetToolTip(Me.btnCreateReport, "Add Report")
        Me.btnCreateReport.UseVisualStyleBackColor = True
        '
        'btnRefreshDailyReport
        '
        Me.btnRefreshDailyReport.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRefreshDailyReport.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnRefreshDailyReport.Image = CType(resources.GetObject("btnRefreshDailyReport.Image"), System.Drawing.Image)
        Me.btnRefreshDailyReport.Location = New System.Drawing.Point(707, 29)
        Me.btnRefreshDailyReport.Name = "btnRefreshDailyReport"
        Me.btnRefreshDailyReport.Size = New System.Drawing.Size(26, 24)
        Me.btnRefreshDailyReport.TabIndex = 63
        Me.ttButton.SetToolTip(Me.btnRefreshDailyReport, "Refresh")
        Me.btnRefreshDailyReport.UseVisualStyleBackColor = False
        '
        'btnAddPmPlan
        '
        Me.btnAddPmPlan.Image = CType(resources.GetObject("btnAddPmPlan.Image"), System.Drawing.Image)
        Me.btnAddPmPlan.Location = New System.Drawing.Point(511, 29)
        Me.btnAddPmPlan.Name = "btnAddPmPlan"
        Me.btnAddPmPlan.Size = New System.Drawing.Size(26, 24)
        Me.btnAddPmPlan.TabIndex = 100
        Me.ttButton.SetToolTip(Me.btnAddPmPlan, "Add Report")
        Me.btnAddPmPlan.UseVisualStyleBackColor = True
        '
        'btnRefreshPmList
        '
        Me.btnRefreshPmList.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRefreshPmList.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnRefreshPmList.Image = CType(resources.GetObject("btnRefreshPmList.Image"), System.Drawing.Image)
        Me.btnRefreshPmList.Location = New System.Drawing.Point(479, 29)
        Me.btnRefreshPmList.Name = "btnRefreshPmList"
        Me.btnRefreshPmList.Size = New System.Drawing.Size(26, 24)
        Me.btnRefreshPmList.TabIndex = 99
        Me.ttButton.SetToolTip(Me.btnRefreshPmList, "Refresh")
        Me.btnRefreshPmList.UseVisualStyleBackColor = False
        '
        'Config
        '
        Me.Config.Controls.Add(Me.btnRefreshConfigTable)
        Me.Config.Controls.Add(Me.dgvDbConfig)
        Me.Config.Controls.Add(Me.Label1)
        Me.Config.Controls.Add(Me.txtLineCount)
        Me.Config.Controls.Add(Me.txtParentCodeFilter)
        Me.Config.Controls.Add(Me.txtDescriptionFilter)
        Me.Config.Controls.Add(Me.txtMaterialColFilter)
        Me.Config.Controls.Add(Me.txtLocColFilter)
        Me.Config.Controls.Add(Me.txtParentCode)
        Me.Config.Controls.Add(Me.txtDescription)
        Me.Config.Controls.Add(Me.txtMaterialCol)
        Me.Config.Controls.Add(Me.txtLocCol)
        Me.Config.Controls.Add(Me.btnLineCountUpdate)
        Me.Config.Controls.Add(Me.Label27)
        Me.Config.Controls.Add(Me.Label14)
        Me.Config.Controls.Add(Me.Label13)
        Me.Config.Controls.Add(Me.Label9)
        Me.Config.Controls.Add(Me.Label10)
        Me.Config.Controls.Add(Me.Label11)
        Me.Config.Controls.Add(Me.Label12)
        Me.Config.Controls.Add(Me.Label6)
        Me.Config.Controls.Add(Me.Label5)
        Me.Config.Controls.Add(Me.Label4)
        Me.Config.Controls.Add(Me.Label3)
        Me.Config.Location = New System.Drawing.Point(4, 37)
        Me.Config.Name = "Config"
        Me.Config.Padding = New System.Windows.Forms.Padding(3)
        Me.Config.Size = New System.Drawing.Size(1024, 699)
        Me.Config.TabIndex = 1
        Me.Config.Text = "Config"
        Me.Config.UseVisualStyleBackColor = True
        '
        'btnRefreshConfigTable
        '
        Me.btnRefreshConfigTable.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRefreshConfigTable.Image = CType(resources.GetObject("btnRefreshConfigTable.Image"), System.Drawing.Image)
        Me.btnRefreshConfigTable.Location = New System.Drawing.Point(598, 7)
        Me.btnRefreshConfigTable.Name = "btnRefreshConfigTable"
        Me.btnRefreshConfigTable.Size = New System.Drawing.Size(26, 24)
        Me.btnRefreshConfigTable.TabIndex = 52
        Me.btnRefreshConfigTable.UseVisualStyleBackColor = False
        '
        'dgvDbConfig
        '
        Me.dgvDbConfig.AllowUserToAddRows = False
        Me.dgvDbConfig.AllowUserToDeleteRows = False
        Me.dgvDbConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDbConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDbConfig.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DbName, Me.IPDb, Me.TableDb, Me.Uname, Me.PassDb, Me.UpdateDb})
        Me.dgvDbConfig.Location = New System.Drawing.Point(524, 35)
        Me.dgvDbConfig.Name = "dgvDbConfig"
        Me.dgvDbConfig.RowHeadersWidth = 5
        Me.dgvDbConfig.Size = New System.Drawing.Size(492, 180)
        Me.dgvDbConfig.TabIndex = 42
        '
        'DbName
        '
        Me.DbName.HeaderText = "Database"
        Me.DbName.Name = "DbName"
        Me.DbName.ReadOnly = True
        '
        'IPDb
        '
        Me.IPDb.HeaderText = "IP"
        Me.IPDb.Name = "IPDb"
        '
        'TableDb
        '
        Me.TableDb.HeaderText = "Table"
        Me.TableDb.Name = "TableDb"
        '
        'Uname
        '
        Me.Uname.HeaderText = "User"
        Me.Uname.Name = "Uname"
        '
        'PassDb
        '
        DataGridViewCellStyle1.Format = "*******"
        DataGridViewCellStyle1.NullValue = "*******"
        Me.PassDb.DefaultCellStyle = DataGridViewCellStyle1
        Me.PassDb.HeaderText = "Pass"
        Me.PassDb.Name = "PassDb"
        '
        'UpdateDb
        '
        Me.UpdateDb.HeaderText = "Update"
        Me.UpdateDb.Name = "UpdateDb"
        Me.UpdateDb.Text = "Update"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(842, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Line Count"
        '
        'txtLineCount
        '
        Me.txtLineCount.Location = New System.Drawing.Point(906, 221)
        Me.txtLineCount.Name = "txtLineCount"
        Me.txtLineCount.Size = New System.Drawing.Size(48, 20)
        Me.txtLineCount.TabIndex = 25
        '
        'txtParentCodeFilter
        '
        Me.txtParentCodeFilter.Location = New System.Drawing.Point(387, 51)
        Me.txtParentCodeFilter.Name = "txtParentCodeFilter"
        Me.txtParentCodeFilter.Size = New System.Drawing.Size(48, 20)
        Me.txtParentCodeFilter.TabIndex = 16
        Me.txtParentCodeFilter.Text = "2"
        '
        'txtDescriptionFilter
        '
        Me.txtDescriptionFilter.Location = New System.Drawing.Point(387, 103)
        Me.txtDescriptionFilter.Name = "txtDescriptionFilter"
        Me.txtDescriptionFilter.Size = New System.Drawing.Size(48, 20)
        Me.txtDescriptionFilter.TabIndex = 14
        Me.txtDescriptionFilter.Text = "5"
        '
        'txtMaterialColFilter
        '
        Me.txtMaterialColFilter.Location = New System.Drawing.Point(387, 77)
        Me.txtMaterialColFilter.Name = "txtMaterialColFilter"
        Me.txtMaterialColFilter.Size = New System.Drawing.Size(48, 20)
        Me.txtMaterialColFilter.TabIndex = 12
        Me.txtMaterialColFilter.Text = "4"
        '
        'txtLocColFilter
        '
        Me.txtLocColFilter.Location = New System.Drawing.Point(387, 129)
        Me.txtLocColFilter.Name = "txtLocColFilter"
        Me.txtLocColFilter.Size = New System.Drawing.Size(48, 20)
        Me.txtLocColFilter.TabIndex = 11
        Me.txtLocColFilter.Text = "3"
        '
        'txtParentCode
        '
        Me.txtParentCode.Location = New System.Drawing.Point(134, 51)
        Me.txtParentCode.Name = "txtParentCode"
        Me.txtParentCode.Size = New System.Drawing.Size(48, 20)
        Me.txtParentCode.TabIndex = 8
        Me.txtParentCode.Text = "3"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(134, 103)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(48, 20)
        Me.txtDescription.TabIndex = 6
        Me.txtDescription.Text = "5"
        '
        'txtMaterialCol
        '
        Me.txtMaterialCol.Location = New System.Drawing.Point(134, 77)
        Me.txtMaterialCol.Name = "txtMaterialCol"
        Me.txtMaterialCol.Size = New System.Drawing.Size(48, 20)
        Me.txtMaterialCol.TabIndex = 4
        Me.txtMaterialCol.Text = "4"
        '
        'txtLocCol
        '
        Me.txtLocCol.Location = New System.Drawing.Point(134, 129)
        Me.txtLocCol.Name = "txtLocCol"
        Me.txtLocCol.Size = New System.Drawing.Size(48, 20)
        Me.txtLocCol.TabIndex = 3
        Me.txtLocCol.Text = "17"
        '
        'btnLineCountUpdate
        '
        Me.btnLineCountUpdate.Location = New System.Drawing.Point(960, 222)
        Me.btnLineCountUpdate.Name = "btnLineCountUpdate"
        Me.btnLineCountUpdate.Size = New System.Drawing.Size(56, 20)
        Me.btnLineCountUpdate.TabIndex = 24
        Me.btnLineCountUpdate.Text = "Change"
        Me.btnLineCountUpdate.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(531, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 13)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "DATABASE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(285, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "CONFIG FOR FILTERED BOM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(46, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "CONFIG FOR ORG BOM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(285, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Column Parent"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(285, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Column Description"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(285, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Column Material"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(285, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Column Location"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Column Parent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Column Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Column Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Column Location"
        '
        'Data
        '
        Me.Data.Controls.Add(Me.tabControlData)
        Me.Data.Location = New System.Drawing.Point(4, 37)
        Me.Data.Name = "Data"
        Me.Data.Padding = New System.Windows.Forms.Padding(3)
        Me.Data.Size = New System.Drawing.Size(1024, 699)
        Me.Data.TabIndex = 4
        Me.Data.Text = "Data"
        Me.Data.UseVisualStyleBackColor = True
        '
        'tabControlData
        '
        Me.tabControlData.Controls.Add(Me.TotalData)
        Me.tabControlData.Controls.Add(Me.CadData)
        Me.tabControlData.Controls.Add(Me.BomData)
        Me.tabControlData.Controls.Add(Me.MaterialData)
        Me.tabControlData.Controls.Add(Me.EcnManager)
        Me.tabControlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlData.ItemSize = New System.Drawing.Size(130, 25)
        Me.tabControlData.Location = New System.Drawing.Point(3, 3)
        Me.tabControlData.Name = "tabControlData"
        Me.tabControlData.SelectedIndex = 0
        Me.tabControlData.Size = New System.Drawing.Size(1018, 693)
        Me.tabControlData.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControlData.TabIndex = 56
        '
        'TotalData
        '
        Me.TotalData.Controls.Add(Me.btnRefreshDataTotal)
        Me.TotalData.Controls.Add(Me.Label8)
        Me.TotalData.Controls.Add(Me.txtSearchDataTotal)
        Me.TotalData.Controls.Add(Me.dgvDataTotal)
        Me.TotalData.Location = New System.Drawing.Point(4, 29)
        Me.TotalData.Name = "TotalData"
        Me.TotalData.Padding = New System.Windows.Forms.Padding(3)
        Me.TotalData.Size = New System.Drawing.Size(1010, 660)
        Me.TotalData.TabIndex = 5
        Me.TotalData.Text = "Total Data"
        Me.TotalData.UseVisualStyleBackColor = True
        '
        'btnRefreshDataTotal
        '
        Me.btnRefreshDataTotal.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRefreshDataTotal.Image = CType(resources.GetObject("btnRefreshDataTotal.Image"), System.Drawing.Image)
        Me.btnRefreshDataTotal.Location = New System.Drawing.Point(270, 5)
        Me.btnRefreshDataTotal.Name = "btnRefreshDataTotal"
        Me.btnRefreshDataTotal.Size = New System.Drawing.Size(26, 24)
        Me.btnRefreshDataTotal.TabIndex = 59
        Me.btnRefreshDataTotal.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Search Code"
        '
        'txtSearchDataTotal
        '
        Me.txtSearchDataTotal.Location = New System.Drawing.Point(81, 7)
        Me.txtSearchDataTotal.Name = "txtSearchDataTotal"
        Me.txtSearchDataTotal.Size = New System.Drawing.Size(183, 20)
        Me.txtSearchDataTotal.TabIndex = 57
        '
        'dgvDataTotal
        '
        Me.dgvDataTotal.AllowUserToAddRows = False
        Me.dgvDataTotal.AllowUserToDeleteRows = False
        Me.dgvDataTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDataTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDataTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataTotal.Location = New System.Drawing.Point(5, 32)
        Me.dgvDataTotal.Name = "dgvDataTotal"
        Me.dgvDataTotal.ReadOnly = True
        Me.dgvDataTotal.RowHeadersWidth = 5
        Me.dgvDataTotal.Size = New System.Drawing.Size(999, 609)
        Me.dgvDataTotal.TabIndex = 56
        '
        'CadData
        '
        Me.CadData.Controls.Add(Me.dgvPcbSize)
        Me.CadData.Controls.Add(Me.btnCadDelete)
        Me.CadData.Controls.Add(Me.Label20)
        Me.CadData.Controls.Add(Me.txtCadData)
        Me.CadData.Controls.Add(Me.lbCadList)
        Me.CadData.Controls.Add(Me.btnUpdateOtpInfo)
        Me.CadData.Controls.Add(Me.txtSearchImportCad)
        Me.CadData.Controls.Add(Me.Label19)
        Me.CadData.Controls.Add(Me.dgvCadImport)
        Me.CadData.Controls.Add(Me.btnImportCad)
        Me.CadData.Controls.Add(Me.dgvOtpInfo)
        Me.CadData.Location = New System.Drawing.Point(4, 29)
        Me.CadData.Name = "CadData"
        Me.CadData.Padding = New System.Windows.Forms.Padding(3)
        Me.CadData.Size = New System.Drawing.Size(1010, 660)
        Me.CadData.TabIndex = 0
        Me.CadData.Text = "Cad Data"
        Me.CadData.UseVisualStyleBackColor = True
        '
        'dgvPcbSize
        '
        Me.dgvPcbSize.AllowUserToAddRows = False
        Me.dgvPcbSize.AllowUserToDeleteRows = False
        Me.dgvPcbSize.AllowUserToResizeRows = False
        Me.dgvPcbSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPcbSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPcbSize.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCBDataCode, Me.PCBLength, Me.PCBWidth, Me.PCBThickness})
        Me.dgvPcbSize.Location = New System.Drawing.Point(270, 7)
        Me.dgvPcbSize.Name = "dgvPcbSize"
        Me.dgvPcbSize.ReadOnly = True
        Me.dgvPcbSize.RowHeadersWidth = 20
        Me.dgvPcbSize.Size = New System.Drawing.Size(420, 46)
        Me.dgvPcbSize.TabIndex = 66
        '
        'PCBDataCode
        '
        Me.PCBDataCode.HeaderText = "PcbCode"
        Me.PCBDataCode.Name = "PCBDataCode"
        Me.PCBDataCode.ReadOnly = True
        '
        'PCBLength
        '
        Me.PCBLength.HeaderText = "Length"
        Me.PCBLength.Name = "PCBLength"
        Me.PCBLength.ReadOnly = True
        '
        'PCBWidth
        '
        Me.PCBWidth.HeaderText = "Width"
        Me.PCBWidth.Name = "PCBWidth"
        Me.PCBWidth.ReadOnly = True
        '
        'PCBThickness
        '
        Me.PCBThickness.HeaderText = "Thickness"
        Me.PCBThickness.Name = "PCBThickness"
        Me.PCBThickness.ReadOnly = True
        '
        'btnCadDelete
        '
        Me.btnCadDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadDelete.BackColor = System.Drawing.Color.Tomato
        Me.btnCadDelete.Location = New System.Drawing.Point(3, 609)
        Me.btnCadDelete.Name = "btnCadDelete"
        Me.btnCadDelete.Size = New System.Drawing.Size(261, 35)
        Me.btnCadDelete.TabIndex = 65
        Me.btnCadDelete.Text = "Cad Remove"
        Me.btnCadDelete.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Search Code"
        '
        'txtCadData
        '
        Me.txtCadData.Location = New System.Drawing.Point(81, 7)
        Me.txtCadData.Name = "txtCadData"
        Me.txtCadData.Size = New System.Drawing.Size(183, 20)
        Me.txtCadData.TabIndex = 63
        '
        'lbCadList
        '
        Me.lbCadList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbCadList.FormattingEnabled = True
        Me.lbCadList.Location = New System.Drawing.Point(6, 58)
        Me.lbCadList.Name = "lbCadList"
        Me.lbCadList.ScrollAlwaysVisible = True
        Me.lbCadList.Size = New System.Drawing.Size(258, 433)
        Me.lbCadList.TabIndex = 62
        '
        'btnUpdateOtpInfo
        '
        Me.btnUpdateOtpInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateOtpInfo.BackColor = System.Drawing.Color.PowderBlue
        Me.btnUpdateOtpInfo.Location = New System.Drawing.Point(3, 531)
        Me.btnUpdateOtpInfo.Name = "btnUpdateOtpInfo"
        Me.btnUpdateOtpInfo.Size = New System.Drawing.Size(261, 35)
        Me.btnUpdateOtpInfo.TabIndex = 61
        Me.btnUpdateOtpInfo.Text = "Update OTP Location"
        Me.btnUpdateOtpInfo.UseVisualStyleBackColor = False
        '
        'txtSearchImportCad
        '
        Me.txtSearchImportCad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchImportCad.Location = New System.Drawing.Point(861, 33)
        Me.txtSearchImportCad.Name = "txtSearchImportCad"
        Me.txtSearchImportCad.Size = New System.Drawing.Size(141, 20)
        Me.txtSearchImportCad.TabIndex = 59
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(826, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 13)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Filter"
        '
        'dgvCadImport
        '
        Me.dgvCadImport.AllowUserToAddRows = False
        Me.dgvCadImport.AllowUserToDeleteRows = False
        Me.dgvCadImport.AllowUserToOrderColumns = True
        Me.dgvCadImport.AllowUserToResizeRows = False
        Me.dgvCadImport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCadImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCadImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCadImport.Location = New System.Drawing.Point(270, 59)
        Me.dgvCadImport.Name = "dgvCadImport"
        Me.dgvCadImport.ReadOnly = True
        Me.dgvCadImport.RowHeadersWidth = 10
        Me.dgvCadImport.Size = New System.Drawing.Size(732, 466)
        Me.dgvCadImport.TabIndex = 57
        '
        'btnImportCad
        '
        Me.btnImportCad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImportCad.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnImportCad.Location = New System.Drawing.Point(3, 570)
        Me.btnImportCad.Name = "btnImportCad"
        Me.btnImportCad.Size = New System.Drawing.Size(261, 35)
        Me.btnImportCad.TabIndex = 56
        Me.btnImportCad.Text = "Cad Import"
        Me.btnImportCad.UseVisualStyleBackColor = False
        '
        'dgvOtpInfo
        '
        Me.dgvOtpInfo.AllowUserToAddRows = False
        Me.dgvOtpInfo.AllowUserToDeleteRows = False
        Me.dgvOtpInfo.AllowUserToResizeColumns = False
        Me.dgvOtpInfo.AllowUserToResizeRows = False
        Me.dgvOtpInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOtpInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOtpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOtpInfo.Location = New System.Drawing.Point(270, 531)
        Me.dgvOtpInfo.Name = "dgvOtpInfo"
        Me.dgvOtpInfo.RowHeadersWidth = 10
        Me.dgvOtpInfo.Size = New System.Drawing.Size(732, 113)
        Me.dgvOtpInfo.TabIndex = 60
        '
        'BomData
        '
        Me.BomData.Controls.Add(Me.btnViewLocation)
        Me.BomData.Controls.Add(Me.btnCollapseAllBomTree)
        Me.BomData.Controls.Add(Me.btnExpandAllBomTree)
        Me.BomData.Controls.Add(Me.tvBomList)
        Me.BomData.Controls.Add(Me.btnBomDelete)
        Me.BomData.Controls.Add(Me.lbBomLastUpdate)
        Me.BomData.Controls.Add(Me.Label28)
        Me.BomData.Controls.Add(Me.btnBomExport)
        Me.BomData.Controls.Add(Me.dgvBomCodeView)
        Me.BomData.Controls.Add(Me.Label21)
        Me.BomData.Controls.Add(Me.txtBomData)
        Me.BomData.Controls.Add(Me.dgvBomOtp)
        Me.BomData.Controls.Add(Me.txtSearchBom)
        Me.BomData.Controls.Add(Me.Label18)
        Me.BomData.Controls.Add(Me.dgvBomData)
        Me.BomData.Controls.Add(Me.btnImportBom)
        Me.BomData.Location = New System.Drawing.Point(4, 29)
        Me.BomData.Name = "BomData"
        Me.BomData.Padding = New System.Windows.Forms.Padding(3)
        Me.BomData.Size = New System.Drawing.Size(1010, 660)
        Me.BomData.TabIndex = 1
        Me.BomData.Text = "Bom Data"
        Me.BomData.UseVisualStyleBackColor = True
        '
        'btnViewLocation
        '
        Me.btnViewLocation.Location = New System.Drawing.Point(696, 7)
        Me.btnViewLocation.Name = "btnViewLocation"
        Me.btnViewLocation.Size = New System.Drawing.Size(123, 45)
        Me.btnViewLocation.TabIndex = 72
        Me.btnViewLocation.Text = "View Location"
        Me.btnViewLocation.UseVisualStyleBackColor = True
        '
        'btnCollapseAllBomTree
        '
        Me.btnCollapseAllBomTree.Location = New System.Drawing.Point(136, 32)
        Me.btnCollapseAllBomTree.Name = "btnCollapseAllBomTree"
        Me.btnCollapseAllBomTree.Size = New System.Drawing.Size(128, 20)
        Me.btnCollapseAllBomTree.TabIndex = 71
        Me.btnCollapseAllBomTree.Text = "Show Less"
        Me.btnCollapseAllBomTree.UseVisualStyleBackColor = True
        '
        'btnExpandAllBomTree
        '
        Me.btnExpandAllBomTree.Location = New System.Drawing.Point(5, 32)
        Me.btnExpandAllBomTree.Name = "btnExpandAllBomTree"
        Me.btnExpandAllBomTree.Size = New System.Drawing.Size(128, 20)
        Me.btnExpandAllBomTree.TabIndex = 70
        Me.btnExpandAllBomTree.Text = "Show All"
        Me.btnExpandAllBomTree.UseVisualStyleBackColor = True
        '
        'tvBomList
        '
        Me.tvBomList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvBomList.Location = New System.Drawing.Point(6, 58)
        Me.tvBomList.Name = "tvBomList"
        Me.tvBomList.Size = New System.Drawing.Size(258, 467)
        Me.tvBomList.TabIndex = 69
        '
        'btnBomDelete
        '
        Me.btnBomDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBomDelete.BackColor = System.Drawing.Color.Tomato
        Me.btnBomDelete.Location = New System.Drawing.Point(3, 609)
        Me.btnBomDelete.Name = "btnBomDelete"
        Me.btnBomDelete.Size = New System.Drawing.Size(261, 35)
        Me.btnBomDelete.TabIndex = 68
        Me.btnBomDelete.Text = "Bom Remove"
        Me.btnBomDelete.UseVisualStyleBackColor = False
        '
        'lbBomLastUpdate
        '
        Me.lbBomLastUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbBomLastUpdate.AutoSize = True
        Me.lbBomLastUpdate.Location = New System.Drawing.Point(896, 14)
        Me.lbBomLastUpdate.Name = "lbBomLastUpdate"
        Me.lbBomLastUpdate.Size = New System.Drawing.Size(11, 13)
        Me.lbBomLastUpdate.TabIndex = 67
        Me.lbBomLastUpdate.Text = "*"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(825, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 13)
        Me.Label28.TabIndex = 66
        Me.Label28.Text = "Bom cập nhật:"
        '
        'btnBomExport
        '
        Me.btnBomExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBomExport.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBomExport.Location = New System.Drawing.Point(3, 531)
        Me.btnBomExport.Name = "btnBomExport"
        Me.btnBomExport.Size = New System.Drawing.Size(261, 35)
        Me.btnBomExport.TabIndex = 65
        Me.btnBomExport.Text = "Bom Export"
        Me.btnBomExport.UseVisualStyleBackColor = False
        '
        'dgvBomCodeView
        '
        Me.dgvBomCodeView.AllowUserToAddRows = False
        Me.dgvBomCodeView.AllowUserToDeleteRows = False
        Me.dgvBomCodeView.AllowUserToResizeRows = False
        Me.dgvBomCodeView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBomCodeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBomCodeView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Pcb})
        Me.dgvBomCodeView.Location = New System.Drawing.Point(270, 7)
        Me.dgvBomCodeView.Name = "dgvBomCodeView"
        Me.dgvBomCodeView.ReadOnly = True
        Me.dgvBomCodeView.RowHeadersWidth = 20
        Me.dgvBomCodeView.Size = New System.Drawing.Size(420, 46)
        Me.dgvBomCodeView.TabIndex = 64
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Assy Code"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Top Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Bot Code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Pcb
        '
        Me.Pcb.HeaderText = "Pcb Code"
        Me.Pcb.Name = "Pcb"
        Me.Pcb.ReadOnly = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "Search Code"
        '
        'txtBomData
        '
        Me.txtBomData.Location = New System.Drawing.Point(81, 7)
        Me.txtBomData.Name = "txtBomData"
        Me.txtBomData.Size = New System.Drawing.Size(183, 20)
        Me.txtBomData.TabIndex = 62
        '
        'dgvBomOtp
        '
        Me.dgvBomOtp.AllowUserToAddRows = False
        Me.dgvBomOtp.AllowUserToDeleteRows = False
        Me.dgvBomOtp.AllowUserToResizeColumns = False
        Me.dgvBomOtp.AllowUserToResizeRows = False
        Me.dgvBomOtp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBomOtp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBomOtp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBomOtp.Location = New System.Drawing.Point(270, 531)
        Me.dgvBomOtp.Name = "dgvBomOtp"
        Me.dgvBomOtp.ReadOnly = True
        Me.dgvBomOtp.RowHeadersWidth = 10
        Me.dgvBomOtp.Size = New System.Drawing.Size(731, 113)
        Me.dgvBomOtp.TabIndex = 61
        '
        'txtSearchBom
        '
        Me.txtSearchBom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchBom.Location = New System.Drawing.Point(860, 32)
        Me.txtSearchBom.Name = "txtSearchBom"
        Me.txtSearchBom.Size = New System.Drawing.Size(141, 20)
        Me.txtSearchBom.TabIndex = 60
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(825, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Filter"
        '
        'dgvBomData
        '
        Me.dgvBomData.AllowUserToAddRows = False
        Me.dgvBomData.AllowUserToDeleteRows = False
        Me.dgvBomData.AllowUserToOrderColumns = True
        Me.dgvBomData.AllowUserToResizeRows = False
        Me.dgvBomData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBomData.Location = New System.Drawing.Point(270, 59)
        Me.dgvBomData.Name = "dgvBomData"
        Me.dgvBomData.ReadOnly = True
        Me.dgvBomData.RowHeadersWidth = 10
        Me.dgvBomData.Size = New System.Drawing.Size(732, 466)
        Me.dgvBomData.TabIndex = 58
        '
        'btnImportBom
        '
        Me.btnImportBom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImportBom.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnImportBom.Location = New System.Drawing.Point(3, 570)
        Me.btnImportBom.Name = "btnImportBom"
        Me.btnImportBom.Size = New System.Drawing.Size(261, 35)
        Me.btnImportBom.TabIndex = 57
        Me.btnImportBom.Text = "Bom Import"
        Me.btnImportBom.UseVisualStyleBackColor = False
        '
        'MaterialData
        '
        Me.MaterialData.Controls.Add(Me.btnMaterialDataRefresh)
        Me.MaterialData.Controls.Add(Me.Label35)
        Me.MaterialData.Controls.Add(Me.txtMaterialData)
        Me.MaterialData.Controls.Add(Me.dgvMaterialData)
        Me.MaterialData.Location = New System.Drawing.Point(4, 29)
        Me.MaterialData.Name = "MaterialData"
        Me.MaterialData.Padding = New System.Windows.Forms.Padding(3)
        Me.MaterialData.Size = New System.Drawing.Size(1010, 660)
        Me.MaterialData.TabIndex = 4
        Me.MaterialData.Text = "Material Data"
        Me.MaterialData.UseVisualStyleBackColor = True
        '
        'btnMaterialDataRefresh
        '
        Me.btnMaterialDataRefresh.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMaterialDataRefresh.Image = CType(resources.GetObject("btnMaterialDataRefresh.Image"), System.Drawing.Image)
        Me.btnMaterialDataRefresh.Location = New System.Drawing.Point(270, 5)
        Me.btnMaterialDataRefresh.Name = "btnMaterialDataRefresh"
        Me.btnMaterialDataRefresh.Size = New System.Drawing.Size(26, 24)
        Me.btnMaterialDataRefresh.TabIndex = 55
        Me.btnMaterialDataRefresh.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 7)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(69, 13)
        Me.Label35.TabIndex = 54
        Me.Label35.Text = "Search Code"
        '
        'txtMaterialData
        '
        Me.txtMaterialData.Location = New System.Drawing.Point(81, 7)
        Me.txtMaterialData.Name = "txtMaterialData"
        Me.txtMaterialData.Size = New System.Drawing.Size(183, 20)
        Me.txtMaterialData.TabIndex = 53
        '
        'dgvMaterialData
        '
        Me.dgvMaterialData.AllowUserToAddRows = False
        Me.dgvMaterialData.AllowUserToDeleteRows = False
        Me.dgvMaterialData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMaterialData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMaterialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterialData.Location = New System.Drawing.Point(5, 32)
        Me.dgvMaterialData.Name = "dgvMaterialData"
        Me.dgvMaterialData.RowHeadersWidth = 5
        Me.dgvMaterialData.Size = New System.Drawing.Size(999, 613)
        Me.dgvMaterialData.TabIndex = 2
        '
        'EcnManager
        '
        Me.EcnManager.Controls.Add(Me.btnImportEcn)
        Me.EcnManager.Controls.Add(Me.btnRefreshEcnData)
        Me.EcnManager.Controls.Add(Me.Label36)
        Me.EcnManager.Controls.Add(Me.txtSearchEcn)
        Me.EcnManager.Controls.Add(Me.dgvEcnData)
        Me.EcnManager.Location = New System.Drawing.Point(4, 29)
        Me.EcnManager.Name = "EcnManager"
        Me.EcnManager.Padding = New System.Windows.Forms.Padding(3)
        Me.EcnManager.Size = New System.Drawing.Size(1010, 660)
        Me.EcnManager.TabIndex = 3
        Me.EcnManager.Text = "ECN Manager"
        Me.EcnManager.UseVisualStyleBackColor = True
        '
        'btnImportEcn
        '
        Me.btnImportEcn.Image = CType(resources.GetObject("btnImportEcn.Image"), System.Drawing.Image)
        Me.btnImportEcn.Location = New System.Drawing.Point(302, 4)
        Me.btnImportEcn.Name = "btnImportEcn"
        Me.btnImportEcn.Size = New System.Drawing.Size(26, 24)
        Me.btnImportEcn.TabIndex = 59
        Me.btnImportEcn.UseVisualStyleBackColor = True
        '
        'btnRefreshEcnData
        '
        Me.btnRefreshEcnData.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRefreshEcnData.Image = CType(resources.GetObject("btnRefreshEcnData.Image"), System.Drawing.Image)
        Me.btnRefreshEcnData.Location = New System.Drawing.Point(270, 4)
        Me.btnRefreshEcnData.Name = "btnRefreshEcnData"
        Me.btnRefreshEcnData.Size = New System.Drawing.Size(26, 24)
        Me.btnRefreshEcnData.TabIndex = 58
        Me.btnRefreshEcnData.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 6)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(69, 13)
        Me.Label36.TabIndex = 57
        Me.Label36.Text = "Search Code"
        '
        'txtSearchEcn
        '
        Me.txtSearchEcn.Location = New System.Drawing.Point(81, 6)
        Me.txtSearchEcn.Name = "txtSearchEcn"
        Me.txtSearchEcn.Size = New System.Drawing.Size(183, 20)
        Me.txtSearchEcn.TabIndex = 56
        '
        'dgvEcnData
        '
        Me.dgvEcnData.AllowUserToAddRows = False
        Me.dgvEcnData.AllowUserToDeleteRows = False
        Me.dgvEcnData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEcnData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEcnData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEcnData.Location = New System.Drawing.Point(6, 32)
        Me.dgvEcnData.Name = "dgvEcnData"
        Me.dgvEcnData.ReadOnly = True
        Me.dgvEcnData.RowHeadersWidth = 10
        Me.dgvEcnData.Size = New System.Drawing.Size(998, 626)
        Me.dgvEcnData.TabIndex = 7
        '
        'BomCompare
        '
        Me.BomCompare.Controls.Add(Me.tabControlBomCompare)
        Me.BomCompare.Location = New System.Drawing.Point(4, 37)
        Me.BomCompare.Name = "BomCompare"
        Me.BomCompare.Padding = New System.Windows.Forms.Padding(3)
        Me.BomCompare.Size = New System.Drawing.Size(1024, 699)
        Me.BomCompare.TabIndex = 6
        Me.BomCompare.Text = "Bom Compare"
        Me.BomCompare.UseVisualStyleBackColor = True
        '
        'tabControlBomCompare
        '
        Me.tabControlBomCompare.Controls.Add(Me.CompareBom)
        Me.tabControlBomCompare.Controls.Add(Me.BomRelate)
        Me.tabControlBomCompare.Controls.Add(Me.BomFilter)
        Me.tabControlBomCompare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlBomCompare.ItemSize = New System.Drawing.Size(130, 25)
        Me.tabControlBomCompare.Location = New System.Drawing.Point(3, 3)
        Me.tabControlBomCompare.Name = "tabControlBomCompare"
        Me.tabControlBomCompare.SelectedIndex = 0
        Me.tabControlBomCompare.Size = New System.Drawing.Size(1018, 693)
        Me.tabControlBomCompare.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControlBomCompare.TabIndex = 41
        '
        'CompareBom
        '
        Me.CompareBom.Controls.Add(Me.Label22)
        Me.CompareBom.Controls.Add(Me.cbBomFilterSide)
        Me.CompareBom.Controls.Add(Me.dgvCompareBomNoteInfo)
        Me.CompareBom.Controls.Add(Me.clbBomCheckFilter)
        Me.CompareBom.Controls.Add(Me.cbBomFilterData)
        Me.CompareBom.Controls.Add(Me.txtBomFilter)
        Me.CompareBom.Controls.Add(Me.btnCompareBom)
        Me.CompareBom.Controls.Add(Me.btnExportBomCompare)
        Me.CompareBom.Controls.Add(Me.cbBomVersion2)
        Me.CompareBom.Controls.Add(Me.cbBomVersion1)
        Me.CompareBom.Controls.Add(Me.txtBom2)
        Me.CompareBom.Controls.Add(Me.dgvCompareBom)
        Me.CompareBom.Controls.Add(Me.lbBom2)
        Me.CompareBom.Controls.Add(Me.lbBom1)
        Me.CompareBom.Controls.Add(Me.Label24)
        Me.CompareBom.Controls.Add(Me.txtBom1)
        Me.CompareBom.Controls.Add(Me.Label23)
        Me.CompareBom.Controls.Add(Me.dgvBom1Code)
        Me.CompareBom.Controls.Add(Me.dgvBom2Code)
        Me.CompareBom.Controls.Add(Me.dgvCompareCount)
        Me.CompareBom.Location = New System.Drawing.Point(4, 29)
        Me.CompareBom.Name = "CompareBom"
        Me.CompareBom.Padding = New System.Windows.Forms.Padding(3)
        Me.CompareBom.Size = New System.Drawing.Size(1010, 660)
        Me.CompareBom.TabIndex = 0
        Me.CompareBom.Text = "Compare Bom"
        Me.CompareBom.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(959, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Filter"
        '
        'cbBomFilterSide
        '
        Me.cbBomFilterSide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBomFilterSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBomFilterSide.FormattingEnabled = True
        Me.cbBomFilterSide.Items.AddRange(New Object() {"All", "Top", "Bot"})
        Me.cbBomFilterSide.Location = New System.Drawing.Point(939, 295)
        Me.cbBomFilterSide.Name = "cbBomFilterSide"
        Me.cbBomFilterSide.Size = New System.Drawing.Size(65, 21)
        Me.cbBomFilterSide.TabIndex = 38
        '
        'dgvCompareBomNoteInfo
        '
        Me.dgvCompareBomNoteInfo.AllowUserToAddRows = False
        Me.dgvCompareBomNoteInfo.AllowUserToDeleteRows = False
        Me.dgvCompareBomNoteInfo.AllowUserToResizeColumns = False
        Me.dgvCompareBomNoteInfo.AllowUserToResizeRows = False
        Me.dgvCompareBomNoteInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCompareBomNoteInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCompareBomNoteInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompareBomNoteInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7})
        Me.dgvCompareBomNoteInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCompareBomNoteInfo.Enabled = False
        Me.dgvCompareBomNoteInfo.Location = New System.Drawing.Point(939, 322)
        Me.dgvCompareBomNoteInfo.MultiSelect = False
        Me.dgvCompareBomNoteInfo.Name = "dgvCompareBomNoteInfo"
        Me.dgvCompareBomNoteInfo.ReadOnly = True
        Me.dgvCompareBomNoteInfo.RowHeadersWidth = 4
        Me.dgvCompareBomNoteInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCompareBomNoteInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvCompareBomNoteInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompareBomNoteInfo.Size = New System.Drawing.Size(65, 112)
        Me.dgvCompareBomNoteInfo.TabIndex = 37
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.FillWeight = 91.37052!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'clbBomCheckFilter
        '
        Me.clbBomCheckFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clbBomCheckFilter.CheckOnClick = True
        Me.clbBomCheckFilter.FormattingEnabled = True
        Me.clbBomCheckFilter.Items.AddRange(New Object() {"Bom1", "Bom2", "Dif", "Same"})
        Me.clbBomCheckFilter.Location = New System.Drawing.Point(939, 225)
        Me.clbBomCheckFilter.Name = "clbBomCheckFilter"
        Me.clbBomCheckFilter.Size = New System.Drawing.Size(65, 64)
        Me.clbBomCheckFilter.TabIndex = 36
        '
        'cbBomFilterData
        '
        Me.cbBomFilterData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBomFilterData.AutoCompleteCustomSource.AddRange(New String() {"Location", "Bom Part 1", "Bom Part 2"})
        Me.cbBomFilterData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBomFilterData.FormattingEnabled = True
        Me.cbBomFilterData.Items.AddRange(New Object() {"Location", "Part Bom 1", "Part Bom 2"})
        Me.cbBomFilterData.Location = New System.Drawing.Point(939, 172)
        Me.cbBomFilterData.Name = "cbBomFilterData"
        Me.cbBomFilterData.Size = New System.Drawing.Size(65, 21)
        Me.cbBomFilterData.TabIndex = 34
        '
        'txtBomFilter
        '
        Me.txtBomFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBomFilter.Location = New System.Drawing.Point(939, 199)
        Me.txtBomFilter.Name = "txtBomFilter"
        Me.txtBomFilter.Size = New System.Drawing.Size(65, 20)
        Me.txtBomFilter.TabIndex = 33
        '
        'btnCompareBom
        '
        Me.btnCompareBom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompareBom.Location = New System.Drawing.Point(942, 9)
        Me.btnCompareBom.Name = "btnCompareBom"
        Me.btnCompareBom.Size = New System.Drawing.Size(65, 138)
        Me.btnCompareBom.TabIndex = 27
        Me.btnCompareBom.Text = "Compare"
        Me.btnCompareBom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCompareBom.UseVisualStyleBackColor = True
        '
        'btnExportBomCompare
        '
        Me.btnExportBomCompare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportBomCompare.Location = New System.Drawing.Point(938, 602)
        Me.btnExportBomCompare.Name = "btnExportBomCompare"
        Me.btnExportBomCompare.Size = New System.Drawing.Size(65, 46)
        Me.btnExportBomCompare.TabIndex = 29
        Me.btnExportBomCompare.Text = "Export"
        Me.btnExportBomCompare.UseVisualStyleBackColor = True
        '
        'txtBom2
        '
        Me.txtBom2.Location = New System.Drawing.Point(443, 6)
        Me.txtBom2.Name = "txtBom2"
        Me.txtBom2.Size = New System.Drawing.Size(246, 20)
        Me.txtBom2.TabIndex = 26
        '
        'dgvCompareBom
        '
        Me.dgvCompareBom.AllowDrop = True
        Me.dgvCompareBom.AllowUserToAddRows = False
        Me.dgvCompareBom.AllowUserToDeleteRows = False
        Me.dgvCompareBom.AllowUserToOrderColumns = True
        Me.dgvCompareBom.AllowUserToResizeRows = False
        Me.dgvCompareBom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCompareBom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCompareBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompareBom.Location = New System.Drawing.Point(6, 150)
        Me.dgvCompareBom.Name = "dgvCompareBom"
        Me.dgvCompareBom.ReadOnly = True
        Me.dgvCompareBom.Size = New System.Drawing.Size(926, 498)
        Me.dgvCompareBom.TabIndex = 28
        '
        'lbBom2
        '
        Me.lbBom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBom2.FormattingEnabled = True
        Me.lbBom2.HorizontalScrollbar = True
        Me.lbBom2.Location = New System.Drawing.Point(400, 32)
        Me.lbBom2.Name = "lbBom2"
        Me.lbBom2.ScrollAlwaysVisible = True
        Me.lbBom2.Size = New System.Drawing.Size(371, 95)
        Me.lbBom2.TabIndex = 40
        Me.lbBom2.Visible = False
        '
        'lbBom1
        '
        Me.lbBom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBom1.FormattingEnabled = True
        Me.lbBom1.HorizontalScrollbar = True
        Me.lbBom1.Location = New System.Drawing.Point(6, 32)
        Me.lbBom1.Name = "lbBom1"
        Me.lbBom1.ScrollAlwaysVisible = True
        Me.lbBom1.Size = New System.Drawing.Size(371, 95)
        Me.lbBom1.TabIndex = 39
        Me.lbBom1.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "BOM 1"
        '
        'txtBom1
        '
        Me.txtBom1.Location = New System.Drawing.Point(49, 6)
        Me.txtBom1.Name = "txtBom1"
        Me.txtBom1.Size = New System.Drawing.Size(246, 20)
        Me.txtBom1.TabIndex = 24
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(397, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 13)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "BOM 2"
        '
        'dgvBom1Code
        '
        Me.dgvBom1Code.AllowUserToAddRows = False
        Me.dgvBom1Code.AllowUserToDeleteRows = False
        Me.dgvBom1Code.AllowUserToResizeRows = False
        Me.dgvBom1Code.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBom1Code.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBom1Code.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.dgvBom1Code.Location = New System.Drawing.Point(6, 32)
        Me.dgvBom1Code.Name = "dgvBom1Code"
        Me.dgvBom1Code.ReadOnly = True
        Me.dgvBom1Code.Size = New System.Drawing.Size(371, 112)
        Me.dgvBom1Code.TabIndex = 30
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.FillWeight = 71.06599!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Assy"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.FillWeight = 128.934!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvBom2Code
        '
        Me.dgvBom2Code.AllowUserToAddRows = False
        Me.dgvBom2Code.AllowUserToDeleteRows = False
        Me.dgvBom2Code.AllowUserToResizeRows = False
        Me.dgvBom2Code.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBom2Code.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBom2Code.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dgvBom2Code.Location = New System.Drawing.Point(400, 32)
        Me.dgvBom2Code.Name = "dgvBom2Code"
        Me.dgvBom2Code.ReadOnly = True
        Me.dgvBom2Code.Size = New System.Drawing.Size(371, 112)
        Me.dgvBom2Code.TabIndex = 31
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.FillWeight = 71.06599!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Assy"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.FillWeight = 128.934!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvCompareCount
        '
        Me.dgvCompareCount.AllowUserToAddRows = False
        Me.dgvCompareCount.AllowUserToDeleteRows = False
        Me.dgvCompareCount.AllowUserToResizeRows = False
        Me.dgvCompareCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCompareCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompareCount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvCompareCount.Location = New System.Drawing.Point(777, 32)
        Me.dgvCompareCount.Name = "dgvCompareCount"
        Me.dgvCompareCount.ReadOnly = True
        Me.dgvCompareCount.RowHeadersWidth = 5
        Me.dgvCompareCount.Size = New System.Drawing.Size(152, 112)
        Me.dgvCompareCount.TabIndex = 32
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.FillWeight = 91.37052!
        Me.DataGridViewTextBoxColumn8.HeaderText = ""
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.FillWeight = 90.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Top"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.FillWeight = 90.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Bot"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BomRelate
        '
        Me.BomRelate.Controls.Add(Me.dgvBomRelateOrg)
        Me.BomRelate.Controls.Add(Me.lbBomRelate)
        Me.BomRelate.Controls.Add(Me.txtRelateFilter)
        Me.BomRelate.Controls.Add(Me.cbRelateFilter)
        Me.BomRelate.Controls.Add(Me.pbBomRelate)
        Me.BomRelate.Controls.Add(Me.txtBomRelate)
        Me.BomRelate.Controls.Add(Me.dgvBomRelate)
        Me.BomRelate.Controls.Add(Me.btnBomRelate)
        Me.BomRelate.Controls.Add(Me.Label15)
        Me.BomRelate.Location = New System.Drawing.Point(4, 29)
        Me.BomRelate.Name = "BomRelate"
        Me.BomRelate.Padding = New System.Windows.Forms.Padding(3)
        Me.BomRelate.Size = New System.Drawing.Size(1010, 660)
        Me.BomRelate.TabIndex = 1
        Me.BomRelate.Text = "Bom Relate"
        Me.BomRelate.UseVisualStyleBackColor = True
        '
        'dgvBomRelateOrg
        '
        Me.dgvBomRelateOrg.AllowUserToAddRows = False
        Me.dgvBomRelateOrg.AllowUserToDeleteRows = False
        Me.dgvBomRelateOrg.AllowUserToResizeRows = False
        Me.dgvBomRelateOrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBomRelateOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBomRelateOrg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.dgvBomRelateOrg.Location = New System.Drawing.Point(518, 5)
        Me.dgvBomRelateOrg.Name = "dgvBomRelateOrg"
        Me.dgvBomRelateOrg.ReadOnly = True
        Me.dgvBomRelateOrg.RowHeadersWidth = 20
        Me.dgvBomRelateOrg.Size = New System.Drawing.Size(377, 46)
        Me.dgvBomRelateOrg.TabIndex = 59
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Assy Code"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Top Code"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Bot Code"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Pcb Code"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'lbBomRelate
        '
        Me.lbBomRelate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBomRelate.FormattingEnabled = True
        Me.lbBomRelate.HorizontalScrollbar = True
        Me.lbBomRelate.ItemHeight = 15
        Me.lbBomRelate.Location = New System.Drawing.Point(65, 31)
        Me.lbBomRelate.Name = "lbBomRelate"
        Me.lbBomRelate.ScrollAlwaysVisible = True
        Me.lbBomRelate.Size = New System.Drawing.Size(447, 124)
        Me.lbBomRelate.TabIndex = 58
        Me.lbBomRelate.Visible = False
        '
        'txtRelateFilter
        '
        Me.txtRelateFilter.Location = New System.Drawing.Point(65, 33)
        Me.txtRelateFilter.Name = "txtRelateFilter"
        Me.txtRelateFilter.Size = New System.Drawing.Size(447, 20)
        Me.txtRelateFilter.TabIndex = 57
        '
        'cbRelateFilter
        '
        Me.cbRelateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRelateFilter.FormattingEnabled = True
        Me.cbRelateFilter.Items.AddRange(New Object() {"All", "Assy", "Top", "Bot"})
        Me.cbRelateFilter.Location = New System.Drawing.Point(12, 31)
        Me.cbRelateFilter.Name = "cbRelateFilter"
        Me.cbRelateFilter.Size = New System.Drawing.Size(47, 21)
        Me.cbRelateFilter.TabIndex = 56
        '
        'pbBomRelate
        '
        Me.pbBomRelate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbBomRelate.Location = New System.Drawing.Point(6, 624)
        Me.pbBomRelate.Name = "pbBomRelate"
        Me.pbBomRelate.Size = New System.Drawing.Size(996, 23)
        Me.pbBomRelate.TabIndex = 55
        '
        'txtBomRelate
        '
        Me.txtBomRelate.Location = New System.Drawing.Point(65, 7)
        Me.txtBomRelate.Name = "txtBomRelate"
        Me.txtBomRelate.Size = New System.Drawing.Size(447, 20)
        Me.txtBomRelate.TabIndex = 53
        '
        'dgvBomRelate
        '
        Me.dgvBomRelate.AllowUserToAddRows = False
        Me.dgvBomRelate.AllowUserToDeleteRows = False
        Me.dgvBomRelate.AllowUserToResizeColumns = False
        Me.dgvBomRelate.AllowUserToResizeRows = False
        Me.dgvBomRelate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBomRelate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBomRelate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBomRelate.Location = New System.Drawing.Point(6, 57)
        Me.dgvBomRelate.Name = "dgvBomRelate"
        Me.dgvBomRelate.ReadOnly = True
        Me.dgvBomRelate.RowHeadersWidth = 10
        Me.dgvBomRelate.Size = New System.Drawing.Size(996, 561)
        Me.dgvBomRelate.TabIndex = 52
        '
        'btnBomRelate
        '
        Me.btnBomRelate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBomRelate.Location = New System.Drawing.Point(906, 5)
        Me.btnBomRelate.Name = "btnBomRelate"
        Me.btnBomRelate.Size = New System.Drawing.Size(96, 46)
        Me.btnBomRelate.TabIndex = 51
        Me.btnBomRelate.Text = "Relate Bom"
        Me.btnBomRelate.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "BOM File"
        '
        'BomFilter
        '
        Me.BomFilter.Controls.Add(Me.lbProgressBar)
        Me.BomFilter.Controls.Add(Me.pbBomFilter)
        Me.BomFilter.Controls.Add(Me.txtFilePathSave)
        Me.BomFilter.Controls.Add(Me.Label16)
        Me.BomFilter.Controls.Add(Me.btnFilter)
        Me.BomFilter.Controls.Add(Me.txtFilePathBom)
        Me.BomFilter.Controls.Add(Me.Label17)
        Me.BomFilter.Controls.Add(Me.dgvListBomFilter)
        Me.BomFilter.Location = New System.Drawing.Point(4, 29)
        Me.BomFilter.Name = "BomFilter"
        Me.BomFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.BomFilter.Size = New System.Drawing.Size(1010, 660)
        Me.BomFilter.TabIndex = 2
        Me.BomFilter.Text = "Bom Filter"
        Me.BomFilter.UseVisualStyleBackColor = True
        '
        'lbProgressBar
        '
        Me.lbProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbProgressBar.AutoSize = True
        Me.lbProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.lbProgressBar.Location = New System.Drawing.Point(485, 627)
        Me.lbProgressBar.Name = "lbProgressBar"
        Me.lbProgressBar.Size = New System.Drawing.Size(39, 13)
        Me.lbProgressBar.TabIndex = 44
        Me.lbProgressBar.Text = "Label4"
        Me.lbProgressBar.Visible = False
        '
        'pbBomFilter
        '
        Me.pbBomFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbBomFilter.Location = New System.Drawing.Point(6, 622)
        Me.pbBomFilter.Name = "pbBomFilter"
        Me.pbBomFilter.Size = New System.Drawing.Size(996, 23)
        Me.pbBomFilter.TabIndex = 43
        '
        'txtFilePathSave
        '
        Me.txtFilePathSave.Location = New System.Drawing.Point(91, 34)
        Me.txtFilePathSave.Name = "txtFilePathSave"
        Me.txtFilePathSave.Size = New System.Drawing.Size(202, 20)
        Me.txtFilePathSave.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Save File Path"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(310, 7)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 48)
        Me.btnFilter.TabIndex = 40
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtFilePathBom
        '
        Me.txtFilePathBom.Location = New System.Drawing.Point(91, 8)
        Me.txtFilePathBom.Name = "txtFilePathBom"
        Me.txtFilePathBom.Size = New System.Drawing.Size(202, 20)
        Me.txtFilePathBom.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "BOM File"
        '
        'dgvListBomFilter
        '
        Me.dgvListBomFilter.AllowUserToAddRows = False
        Me.dgvListBomFilter.AllowUserToDeleteRows = False
        Me.dgvListBomFilter.AllowUserToResizeColumns = False
        Me.dgvListBomFilter.AllowUserToResizeRows = False
        Me.dgvListBomFilter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListBomFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListBomFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListBomFilter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AssyCode, Me.TopCode, Me.BotCode, Me.PcbCode, Me.status})
        Me.dgvListBomFilter.Location = New System.Drawing.Point(6, 60)
        Me.dgvListBomFilter.Name = "dgvListBomFilter"
        Me.dgvListBomFilter.ReadOnly = True
        Me.dgvListBomFilter.Size = New System.Drawing.Size(996, 553)
        Me.dgvListBomFilter.TabIndex = 37
        '
        'AssyCode
        '
        Me.AssyCode.HeaderText = "Assy Code"
        Me.AssyCode.Name = "AssyCode"
        Me.AssyCode.ReadOnly = True
        '
        'TopCode
        '
        Me.TopCode.HeaderText = "Top Code"
        Me.TopCode.Name = "TopCode"
        Me.TopCode.ReadOnly = True
        '
        'BotCode
        '
        Me.BotCode.HeaderText = "Bot Code"
        Me.BotCode.Name = "BotCode"
        Me.BotCode.ReadOnly = True
        '
        'PcbCode
        '
        Me.PcbCode.HeaderText = "Pcb Code"
        Me.PcbCode.Name = "PcbCode"
        Me.PcbCode.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Trạng thái"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'ProgramCheck
        '
        Me.ProgramCheck.Controls.Add(Me.GroupBox2)
        Me.ProgramCheck.Controls.Add(Me.tabControlPgCheck)
        Me.ProgramCheck.Location = New System.Drawing.Point(4, 37)
        Me.ProgramCheck.Name = "ProgramCheck"
        Me.ProgramCheck.Padding = New System.Windows.Forms.Padding(3)
        Me.ProgramCheck.Size = New System.Drawing.Size(1024, 699)
        Me.ProgramCheck.TabIndex = 0
        Me.ProgramCheck.Text = "Program Check"
        Me.ProgramCheck.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.btnRefreshProgramCheckTable)
        Me.GroupBox2.Location = New System.Drawing.Point(761, -12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 37)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(34, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(225, 16)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = "*Note: X: TOP | O: BOT | E: ECN"
        '
        'btnRefreshProgramCheckTable
        '
        Me.btnRefreshProgramCheckTable.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRefreshProgramCheckTable.Image = CType(resources.GetObject("btnRefreshProgramCheckTable.Image"), System.Drawing.Image)
        Me.btnRefreshProgramCheckTable.Location = New System.Drawing.Point(2, 12)
        Me.btnRefreshProgramCheckTable.Name = "btnRefreshProgramCheckTable"
        Me.btnRefreshProgramCheckTable.Size = New System.Drawing.Size(26, 24)
        Me.btnRefreshProgramCheckTable.TabIndex = 51
        Me.btnRefreshProgramCheckTable.UseVisualStyleBackColor = False
        '
        'tabControlPgCheck
        '
        Me.tabControlPgCheck.Controls.Add(Me.AoiCheck)
        Me.tabControlPgCheck.Controls.Add(Me.MounterCheck)
        Me.tabControlPgCheck.Controls.Add(Me.PrinterCheck)
        Me.tabControlPgCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlPgCheck.ItemSize = New System.Drawing.Size(130, 25)
        Me.tabControlPgCheck.Location = New System.Drawing.Point(3, 3)
        Me.tabControlPgCheck.Name = "tabControlPgCheck"
        Me.tabControlPgCheck.SelectedIndex = 0
        Me.tabControlPgCheck.Size = New System.Drawing.Size(1018, 693)
        Me.tabControlPgCheck.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControlPgCheck.TabIndex = 53
        '
        'AoiCheck
        '
        Me.AoiCheck.Controls.Add(Me.Label7)
        Me.AoiCheck.Controls.Add(Me.Label30)
        Me.AoiCheck.Controls.Add(Me.txtSearchCheckAoi)
        Me.AoiCheck.Controls.Add(Me.dgvCheckAoi)
        Me.AoiCheck.Location = New System.Drawing.Point(4, 29)
        Me.AoiCheck.Name = "AoiCheck"
        Me.AoiCheck.Padding = New System.Windows.Forms.Padding(3)
        Me.AoiCheck.Size = New System.Drawing.Size(1010, 660)
        Me.AoiCheck.TabIndex = 0
        Me.AoiCheck.Text = "AOI Check"
        Me.AoiCheck.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "AOI PROGRAM CHECK"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 13)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "Search Code"
        '
        'txtSearchCheckAoi
        '
        Me.txtSearchCheckAoi.Location = New System.Drawing.Point(84, 22)
        Me.txtSearchCheckAoi.Name = "txtSearchCheckAoi"
        Me.txtSearchCheckAoi.Size = New System.Drawing.Size(195, 20)
        Me.txtSearchCheckAoi.TabIndex = 51
        '
        'dgvCheckAoi
        '
        Me.dgvCheckAoi.AllowUserToAddRows = False
        Me.dgvCheckAoi.AllowUserToDeleteRows = False
        Me.dgvCheckAoi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheckAoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckAoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckAoi.Location = New System.Drawing.Point(6, 48)
        Me.dgvCheckAoi.Name = "dgvCheckAoi"
        Me.dgvCheckAoi.RowHeadersWidth = 5
        Me.dgvCheckAoi.Size = New System.Drawing.Size(999, 593)
        Me.dgvCheckAoi.TabIndex = 1
        '
        'MounterCheck
        '
        Me.MounterCheck.Controls.Add(Me.Label33)
        Me.MounterCheck.Controls.Add(Me.Label31)
        Me.MounterCheck.Controls.Add(Me.txtSearchCheckMounter)
        Me.MounterCheck.Controls.Add(Me.dgvCheckMounter)
        Me.MounterCheck.Location = New System.Drawing.Point(4, 29)
        Me.MounterCheck.Name = "MounterCheck"
        Me.MounterCheck.Padding = New System.Windows.Forms.Padding(3)
        Me.MounterCheck.Size = New System.Drawing.Size(1010, 660)
        Me.MounterCheck.TabIndex = 1
        Me.MounterCheck.Text = "Mounter Check"
        Me.MounterCheck.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(7, 3)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(217, 16)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "MOUNTER PROGRAM CHECK"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(69, 13)
        Me.Label31.TabIndex = 55
        Me.Label31.Text = "Search Code"
        '
        'txtSearchCheckMounter
        '
        Me.txtSearchCheckMounter.Location = New System.Drawing.Point(84, 22)
        Me.txtSearchCheckMounter.Name = "txtSearchCheckMounter"
        Me.txtSearchCheckMounter.Size = New System.Drawing.Size(195, 20)
        Me.txtSearchCheckMounter.TabIndex = 54
        '
        'dgvCheckMounter
        '
        Me.dgvCheckMounter.AllowUserToAddRows = False
        Me.dgvCheckMounter.AllowUserToDeleteRows = False
        Me.dgvCheckMounter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheckMounter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckMounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckMounter.Location = New System.Drawing.Point(6, 48)
        Me.dgvCheckMounter.Name = "dgvCheckMounter"
        Me.dgvCheckMounter.RowHeadersWidth = 5
        Me.dgvCheckMounter.Size = New System.Drawing.Size(999, 593)
        Me.dgvCheckMounter.TabIndex = 53
        '
        'PrinterCheck
        '
        Me.PrinterCheck.Controls.Add(Me.Label45)
        Me.PrinterCheck.Controls.Add(Me.Label34)
        Me.PrinterCheck.Controls.Add(Me.Label32)
        Me.PrinterCheck.Controls.Add(Me.txtSearchCheckPrinter)
        Me.PrinterCheck.Controls.Add(Me.dgvCheckPrinter)
        Me.PrinterCheck.Location = New System.Drawing.Point(4, 29)
        Me.PrinterCheck.Name = "PrinterCheck"
        Me.PrinterCheck.Size = New System.Drawing.Size(1010, 660)
        Me.PrinterCheck.TabIndex = 2
        Me.PrinterCheck.Text = "Printer Check"
        Me.PrinterCheck.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(285, 3)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(112, 39)
        Me.Label45.TabIndex = 67
        Me.Label45.Text = "*Solder Type:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type 4: 0202-001830 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type 5: 0202-002133 "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(7, 3)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(208, 16)
        Me.Label34.TabIndex = 57
        Me.Label34.Text = "PRINTER PROGRAM CHECK"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(7, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 13)
        Me.Label32.TabIndex = 55
        Me.Label32.Text = "Search Code"
        '
        'txtSearchCheckPrinter
        '
        Me.txtSearchCheckPrinter.Location = New System.Drawing.Point(84, 22)
        Me.txtSearchCheckPrinter.Name = "txtSearchCheckPrinter"
        Me.txtSearchCheckPrinter.Size = New System.Drawing.Size(195, 20)
        Me.txtSearchCheckPrinter.TabIndex = 54
        '
        'dgvCheckPrinter
        '
        Me.dgvCheckPrinter.AllowUserToAddRows = False
        Me.dgvCheckPrinter.AllowUserToDeleteRows = False
        Me.dgvCheckPrinter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheckPrinter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckPrinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckPrinter.Location = New System.Drawing.Point(6, 48)
        Me.dgvCheckPrinter.Name = "dgvCheckPrinter"
        Me.dgvCheckPrinter.RowHeadersWidth = 5
        Me.dgvCheckPrinter.Size = New System.Drawing.Size(999, 593)
        Me.dgvCheckPrinter.TabIndex = 53
        '
        'DailyPlan
        '
        Me.DailyPlan.Controls.Add(Me.GroupBox1)
        Me.DailyPlan.Controls.Add(Me.Label26)
        Me.DailyPlan.Controls.Add(Me.Label25)
        Me.DailyPlan.Controls.Add(Me.cbPlanShiftFilter)
        Me.DailyPlan.Controls.Add(Me.cbPlanLineFilter)
        Me.DailyPlan.Controls.Add(Me.txtPlanCodeFilter)
        Me.DailyPlan.Controls.Add(Me.Label2)
        Me.DailyPlan.Controls.Add(Me.dgvPlan)
        Me.DailyPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailyPlan.Location = New System.Drawing.Point(4, 37)
        Me.DailyPlan.Name = "DailyPlan"
        Me.DailyPlan.Padding = New System.Windows.Forms.Padding(3)
        Me.DailyPlan.Size = New System.Drawing.Size(1024, 699)
        Me.DailyPlan.TabIndex = 8
        Me.DailyPlan.Text = "Daily Plan"
        Me.DailyPlan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtpPlanDate)
        Me.GroupBox1.Controls.Add(Me.btnPlanRefresh)
        Me.GroupBox1.Controls.Add(Me.btnExportPlan)
        Me.GroupBox1.Controls.Add(Me.btnImportPlan)
        Me.GroupBox1.Location = New System.Drawing.Point(807, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 36)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'dtpPlanDate
        '
        Me.dtpPlanDate.CustomFormat = "dd - MM - yyyy"
        Me.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPlanDate.Location = New System.Drawing.Point(97, 11)
        Me.dtpPlanDate.Name = "dtpPlanDate"
        Me.dtpPlanDate.Size = New System.Drawing.Size(107, 20)
        Me.dtpPlanDate.TabIndex = 41
        '
        'btnPlanRefresh
        '
        Me.btnPlanRefresh.BackColor = System.Drawing.Color.PowderBlue
        Me.btnPlanRefresh.Image = CType(resources.GetObject("btnPlanRefresh.Image"), System.Drawing.Image)
        Me.btnPlanRefresh.Location = New System.Drawing.Point(65, 9)
        Me.btnPlanRefresh.Name = "btnPlanRefresh"
        Me.btnPlanRefresh.Size = New System.Drawing.Size(26, 24)
        Me.btnPlanRefresh.TabIndex = 53
        Me.btnPlanRefresh.UseVisualStyleBackColor = False
        '
        'btnExportPlan
        '
        Me.btnExportPlan.Image = CType(resources.GetObject("btnExportPlan.Image"), System.Drawing.Image)
        Me.btnExportPlan.Location = New System.Drawing.Point(33, 9)
        Me.btnExportPlan.Name = "btnExportPlan"
        Me.btnExportPlan.Size = New System.Drawing.Size(26, 24)
        Me.btnExportPlan.TabIndex = 42
        Me.btnExportPlan.UseVisualStyleBackColor = True
        '
        'btnImportPlan
        '
        Me.btnImportPlan.Image = CType(resources.GetObject("btnImportPlan.Image"), System.Drawing.Image)
        Me.btnImportPlan.Location = New System.Drawing.Point(1, 9)
        Me.btnImportPlan.Name = "btnImportPlan"
        Me.btnImportPlan.Size = New System.Drawing.Size(26, 24)
        Me.btnImportPlan.TabIndex = 46
        Me.btnImportPlan.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(312, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 13)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Shift"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(208, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 13)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "Line"
        '
        'cbPlanShiftFilter
        '
        Me.cbPlanShiftFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlanShiftFilter.FormattingEnabled = True
        Me.cbPlanShiftFilter.Items.AddRange(New Object() {"All", "Day", "Night"})
        Me.cbPlanShiftFilter.Location = New System.Drawing.Point(346, 6)
        Me.cbPlanShiftFilter.Name = "cbPlanShiftFilter"
        Me.cbPlanShiftFilter.Size = New System.Drawing.Size(65, 21)
        Me.cbPlanShiftFilter.TabIndex = 47
        '
        'cbPlanLineFilter
        '
        Me.cbPlanLineFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlanLineFilter.FormattingEnabled = True
        Me.cbPlanLineFilter.Items.AddRange(New Object() {"All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbPlanLineFilter.Location = New System.Drawing.Point(241, 6)
        Me.cbPlanLineFilter.Name = "cbPlanLineFilter"
        Me.cbPlanLineFilter.Size = New System.Drawing.Size(65, 21)
        Me.cbPlanLineFilter.TabIndex = 45
        '
        'txtPlanCodeFilter
        '
        Me.txtPlanCodeFilter.Location = New System.Drawing.Point(53, 6)
        Me.txtPlanCodeFilter.Name = "txtPlanCodeFilter"
        Me.txtPlanCodeFilter.Size = New System.Drawing.Size(149, 20)
        Me.txtPlanCodeFilter.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Search"
        '
        'dgvPlan
        '
        Me.dgvPlan.AllowUserToAddRows = False
        Me.dgvPlan.AllowUserToDeleteRows = False
        Me.dgvPlan.AllowUserToOrderColumns = True
        Me.dgvPlan.AllowUserToResizeRows = False
        Me.dgvPlan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlan.Location = New System.Drawing.Point(6, 35)
        Me.dgvPlan.Name = "dgvPlan"
        Me.dgvPlan.RowHeadersWidth = 10
        Me.dgvPlan.Size = New System.Drawing.Size(1010, 641)
        Me.dgvPlan.TabIndex = 40
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.DailyPlan)
        Me.tabControl.Controls.Add(Me.ProgramCheck)
        Me.tabControl.Controls.Add(Me.Maintenance)
        Me.tabControl.Controls.Add(Me.BomCompare)
        Me.tabControl.Controls.Add(Me.Data)
        Me.tabControl.Controls.Add(Me.Config)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.ItemSize = New System.Drawing.Size(130, 33)
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1032, 740)
        Me.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControl.TabIndex = 0
        Me.tabControl.Tag = ""
        '
        'Maintenance
        '
        Me.Maintenance.Controls.Add(Me.tabControlMaintenance)
        Me.Maintenance.Location = New System.Drawing.Point(4, 37)
        Me.Maintenance.Name = "Maintenance"
        Me.Maintenance.Padding = New System.Windows.Forms.Padding(3)
        Me.Maintenance.Size = New System.Drawing.Size(1024, 699)
        Me.Maintenance.TabIndex = 9
        Me.Maintenance.Text = "Maintenance"
        Me.Maintenance.UseVisualStyleBackColor = True
        '
        'tabControlMaintenance
        '
        Me.tabControlMaintenance.Controls.Add(Me.MachineReport)
        Me.tabControlMaintenance.Controls.Add(Me.PmPlan)
        Me.tabControlMaintenance.Controls.Add(Me.SparePart)
        Me.tabControlMaintenance.Controls.Add(Me.Improvement)
        Me.tabControlMaintenance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlMaintenance.ItemSize = New System.Drawing.Size(130, 25)
        Me.tabControlMaintenance.Location = New System.Drawing.Point(3, 3)
        Me.tabControlMaintenance.Name = "tabControlMaintenance"
        Me.tabControlMaintenance.SelectedIndex = 0
        Me.tabControlMaintenance.Size = New System.Drawing.Size(1018, 693)
        Me.tabControlMaintenance.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControlMaintenance.TabIndex = 1
        '
        'MachineReport
        '
        Me.MachineReport.Controls.Add(Me.btnExportDailyReport)
        Me.MachineReport.Controls.Add(Me.Label47)
        Me.MachineReport.Controls.Add(Me.cbReportSkipDateFilter)
        Me.MachineReport.Controls.Add(Me.cbReportMachine)
        Me.MachineReport.Controls.Add(Me.cbReportLine)
        Me.MachineReport.Controls.Add(Me.dtpReportEndDay)
        Me.MachineReport.Controls.Add(Me.Label41)
        Me.MachineReport.Controls.Add(Me.dtpReportStartDay)
        Me.MachineReport.Controls.Add(Me.Label40)
        Me.MachineReport.Controls.Add(Me.Label39)
        Me.MachineReport.Controls.Add(Me.Label38)
        Me.MachineReport.Controls.Add(Me.btnCreateReport)
        Me.MachineReport.Controls.Add(Me.btnRefreshDailyReport)
        Me.MachineReport.Controls.Add(Me.Label37)
        Me.MachineReport.Controls.Add(Me.txtSearchReport)
        Me.MachineReport.Controls.Add(Me.dgvDailyReport)
        Me.MachineReport.Location = New System.Drawing.Point(4, 29)
        Me.MachineReport.Name = "MachineReport"
        Me.MachineReport.Padding = New System.Windows.Forms.Padding(3)
        Me.MachineReport.Size = New System.Drawing.Size(1010, 660)
        Me.MachineReport.TabIndex = 0
        Me.MachineReport.Text = "Machine Report"
        Me.MachineReport.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(9, 9)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(230, 16)
        Me.Label47.TabIndex = 95
        Me.Label47.Text = "MAINTENANCE DAILY REPORT"
        '
        'cbReportMachine
        '
        Me.cbReportMachine.AllowDrop = True
        Me.cbReportMachine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbReportMachine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbReportMachine.FormattingEnabled = True
        Me.cbReportMachine.Location = New System.Drawing.Point(352, 31)
        Me.cbReportMachine.Name = "cbReportMachine"
        Me.cbReportMachine.Size = New System.Drawing.Size(92, 21)
        Me.cbReportMachine.TabIndex = 93
        '
        'cbReportLine
        '
        Me.cbReportLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReportLine.FormattingEnabled = True
        Me.cbReportLine.Location = New System.Drawing.Point(265, 31)
        Me.cbReportLine.Name = "cbReportLine"
        Me.cbReportLine.Size = New System.Drawing.Size(36, 21)
        Me.cbReportLine.TabIndex = 92
        '
        'dtpReportEndDay
        '
        Me.dtpReportEndDay.CustomFormat = "dd-MM-yy"
        Me.dtpReportEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReportEndDay.Location = New System.Drawing.Point(597, 31)
        Me.dtpReportEndDay.Name = "dtpReportEndDay"
        Me.dtpReportEndDay.Size = New System.Drawing.Size(66, 20)
        Me.dtpReportEndDay.TabIndex = 74
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(571, 35)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(20, 13)
        Me.Label41.TabIndex = 73
        Me.Label41.Text = "To"
        '
        'dtpReportStartDay
        '
        Me.dtpReportStartDay.CustomFormat = "dd-MM-yy"
        Me.dtpReportStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReportStartDay.Location = New System.Drawing.Point(499, 31)
        Me.dtpReportStartDay.Name = "dtpReportStartDay"
        Me.dtpReportStartDay.Size = New System.Drawing.Size(66, 20)
        Me.dtpReportStartDay.TabIndex = 72
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(463, 35)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(30, 13)
        Me.Label40.TabIndex = 67
        Me.Label40.Text = "From"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(307, 35)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 13)
        Me.Label39.TabIndex = 66
        Me.Label39.Text = "Machine"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(232, 35)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(27, 13)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Line"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 35)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(76, 13)
        Me.Label37.TabIndex = 62
        Me.Label37.Text = "Search Report"
        '
        'txtSearchReport
        '
        Me.txtSearchReport.Location = New System.Drawing.Point(81, 31)
        Me.txtSearchReport.Name = "txtSearchReport"
        Me.txtSearchReport.Size = New System.Drawing.Size(145, 20)
        Me.txtSearchReport.TabIndex = 61
        '
        'dgvDailyReport
        '
        Me.dgvDailyReport.AllowUserToAddRows = False
        Me.dgvDailyReport.AllowUserToDeleteRows = False
        Me.dgvDailyReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDailyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDailyReport.Location = New System.Drawing.Point(6, 59)
        Me.dgvDailyReport.Name = "dgvDailyReport"
        Me.dgvDailyReport.ReadOnly = True
        Me.dgvDailyReport.RowHeadersWidth = 10
        Me.dgvDailyReport.Size = New System.Drawing.Size(998, 594)
        Me.dgvDailyReport.TabIndex = 60
        '
        'PmPlan
        '
        Me.PmPlan.Controls.Add(Me.Label42)
        Me.PmPlan.Controls.Add(Me.CheckBox1)
        Me.PmPlan.Controls.Add(Me.DateTimePicker1)
        Me.PmPlan.Controls.Add(Me.Label43)
        Me.PmPlan.Controls.Add(Me.DateTimePicker2)
        Me.PmPlan.Controls.Add(Me.Label44)
        Me.PmPlan.Controls.Add(Me.Label48)
        Me.PmPlan.Controls.Add(Me.TextBox1)
        Me.PmPlan.Controls.Add(Me.dgvPmPlan)
        Me.PmPlan.Controls.Add(Me.btnAddPmPlan)
        Me.PmPlan.Controls.Add(Me.btnRefreshPmList)
        Me.PmPlan.Location = New System.Drawing.Point(4, 29)
        Me.PmPlan.Name = "PmPlan"
        Me.PmPlan.Padding = New System.Windows.Forms.Padding(3)
        Me.PmPlan.Size = New System.Drawing.Size(1010, 660)
        Me.PmPlan.TabIndex = 1
        Me.PmPlan.Text = "PM Plan"
        Me.PmPlan.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(9, 9)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(185, 16)
        Me.Label42.TabIndex = 110
        Me.Label42.Text = "MAINTENANCE PM PLAN"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(369, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(66, 20)
        Me.DateTimePicker1.TabIndex = 106
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(343, 35)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(20, 13)
        Me.Label43.TabIndex = 105
        Me.Label43.Text = "To"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(271, 31)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(66, 20)
        Me.DateTimePicker2.TabIndex = 104
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(235, 35)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(30, 13)
        Me.Label44.TabIndex = 103
        Me.Label44.Text = "From"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(6, 35)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(76, 13)
        Me.Label48.TabIndex = 98
        Me.Label48.Text = "Search Report"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 97
        '
        'dgvPmPlan
        '
        Me.dgvPmPlan.AllowUserToAddRows = False
        Me.dgvPmPlan.AllowUserToDeleteRows = False
        Me.dgvPmPlan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPmPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPmPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPmPlan.Location = New System.Drawing.Point(6, 59)
        Me.dgvPmPlan.Name = "dgvPmPlan"
        Me.dgvPmPlan.ReadOnly = True
        Me.dgvPmPlan.RowHeadersWidth = 10
        Me.dgvPmPlan.Size = New System.Drawing.Size(998, 598)
        Me.dgvPmPlan.TabIndex = 96
        '
        'SparePart
        '
        Me.SparePart.Location = New System.Drawing.Point(4, 29)
        Me.SparePart.Name = "SparePart"
        Me.SparePart.Size = New System.Drawing.Size(1010, 660)
        Me.SparePart.TabIndex = 2
        Me.SparePart.Text = "Spare Part"
        Me.SparePart.UseVisualStyleBackColor = True
        '
        'Improvement
        '
        Me.Improvement.Location = New System.Drawing.Point(4, 29)
        Me.Improvement.Name = "Improvement"
        Me.Improvement.Size = New System.Drawing.Size(1010, 660)
        Me.Improvement.TabIndex = 3
        Me.Improvement.Text = "Improvement"
        Me.Improvement.UseVisualStyleBackColor = True
        '
        'ttReportStartDay
        '
        Me.ttReportStartDay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'btnExportDailyReport
        '
        Me.btnExportDailyReport.Image = CType(resources.GetObject("btnExportDailyReport.Image"), System.Drawing.Image)
        Me.btnExportDailyReport.Location = New System.Drawing.Point(771, 29)
        Me.btnExportDailyReport.Name = "btnExportDailyReport"
        Me.btnExportDailyReport.Size = New System.Drawing.Size(26, 24)
        Me.btnExportDailyReport.TabIndex = 96
        Me.btnExportDailyReport.UseVisualStyleBackColor = True
        '
        'frmCompareBom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 740)
        Me.Controls.Add(Me.lbCopyRight)
        Me.Controls.Add(Me.tabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompareBom"
        Me.Text = "SMT Control Ver 24.12.30.01"
        Me.Config.ResumeLayout(False)
        Me.Config.PerformLayout()
        CType(Me.dgvDbConfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data.ResumeLayout(False)
        Me.tabControlData.ResumeLayout(False)
        Me.TotalData.ResumeLayout(False)
        Me.TotalData.PerformLayout()
        CType(Me.dgvDataTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CadData.ResumeLayout(False)
        Me.CadData.PerformLayout()
        CType(Me.dgvPcbSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCadImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOtpInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BomData.ResumeLayout(False)
        Me.BomData.PerformLayout()
        CType(Me.dgvBomCodeView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBomOtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBomData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialData.ResumeLayout(False)
        Me.MaterialData.PerformLayout()
        CType(Me.dgvMaterialData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EcnManager.ResumeLayout(False)
        Me.EcnManager.PerformLayout()
        CType(Me.dgvEcnData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BomCompare.ResumeLayout(False)
        Me.tabControlBomCompare.ResumeLayout(False)
        Me.CompareBom.ResumeLayout(False)
        Me.CompareBom.PerformLayout()
        CType(Me.dgvCompareBomNoteInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompareBom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBom1Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBom2Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompareCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BomRelate.ResumeLayout(False)
        Me.BomRelate.PerformLayout()
        CType(Me.dgvBomRelateOrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBomRelate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BomFilter.ResumeLayout(False)
        Me.BomFilter.PerformLayout()
        CType(Me.dgvListBomFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProgramCheck.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabControlPgCheck.ResumeLayout(False)
        Me.AoiCheck.ResumeLayout(False)
        Me.AoiCheck.PerformLayout()
        CType(Me.dgvCheckAoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MounterCheck.ResumeLayout(False)
        Me.MounterCheck.PerformLayout()
        CType(Me.dgvCheckMounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrinterCheck.ResumeLayout(False)
        Me.PrinterCheck.PerformLayout()
        CType(Me.dgvCheckPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DailyPlan.ResumeLayout(False)
        Me.DailyPlan.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.Maintenance.ResumeLayout(False)
        Me.tabControlMaintenance.ResumeLayout(False)
        Me.MachineReport.ResumeLayout(False)
        Me.MachineReport.PerformLayout()
        CType(Me.dgvDailyReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PmPlan.ResumeLayout(False)
        Me.PmPlan.PerformLayout()
        CType(Me.dgvPmPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCopyRight As Label
    Friend WithEvents ttButton As ToolTip
    Friend WithEvents Config As TabPage
    Friend WithEvents btnRefreshConfigTable As Button
    Friend WithEvents dgvDbConfig As DataGridView
    Friend WithEvents DbName As DataGridViewTextBoxColumn
    Friend WithEvents IPDb As DataGridViewTextBoxColumn
    Friend WithEvents TableDb As DataGridViewTextBoxColumn
    Friend WithEvents Uname As DataGridViewTextBoxColumn
    Friend WithEvents PassDb As DataGridViewTextBoxColumn
    Friend WithEvents UpdateDb As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLineCount As TextBox
    Friend WithEvents txtParentCodeFilter As TextBox
    Friend WithEvents txtDescriptionFilter As TextBox
    Friend WithEvents txtMaterialColFilter As TextBox
    Friend WithEvents txtLocColFilter As TextBox
    Friend WithEvents txtParentCode As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtMaterialCol As TextBox
    Friend WithEvents txtLocCol As TextBox
    Friend WithEvents btnLineCountUpdate As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Data As TabPage
    Public WithEvents tabControlData As TabControl
    Friend WithEvents CadData As TabPage
    Public WithEvents dgvPcbSize As DataGridView
    Friend WithEvents PCBDataCode As DataGridViewTextBoxColumn
    Friend WithEvents PCBLength As DataGridViewTextBoxColumn
    Friend WithEvents PCBWidth As DataGridViewTextBoxColumn
    Friend WithEvents PCBThickness As DataGridViewTextBoxColumn
    Friend WithEvents btnCadDelete As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCadData As TextBox
    Friend WithEvents lbCadList As ListBox
    Friend WithEvents btnUpdateOtpInfo As Button
    Friend WithEvents txtSearchImportCad As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dgvCadImport As DataGridView
    Friend WithEvents btnImportCad As Button
    Friend WithEvents dgvOtpInfo As DataGridView
    Friend WithEvents BomData As TabPage
    Friend WithEvents btnViewLocation As Button
    Friend WithEvents btnCollapseAllBomTree As Button
    Friend WithEvents btnExpandAllBomTree As Button
    Friend WithEvents tvBomList As TreeView
    Friend WithEvents btnBomDelete As Button
    Friend WithEvents lbBomLastUpdate As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnBomExport As Button
    Private WithEvents dgvBomCodeView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Pcb As DataGridViewTextBoxColumn
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBomData As TextBox
    Friend WithEvents dgvBomOtp As DataGridView
    Friend WithEvents txtSearchBom As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dgvBomData As DataGridView
    Friend WithEvents btnImportBom As Button
    Friend WithEvents MaterialData As TabPage
    Friend WithEvents btnMaterialDataRefresh As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents txtMaterialData As TextBox
    Friend WithEvents dgvMaterialData As DataGridView
    Friend WithEvents EcnManager As TabPage
    Friend WithEvents BomCompare As TabPage
    Public WithEvents tabControlBomCompare As TabControl
    Friend WithEvents CompareBom As TabPage
    Friend WithEvents cbBomVersion2 As CheckBox
    Friend WithEvents cbBomVersion1 As CheckBox
    Friend WithEvents txtBom2 As TextBox
    Friend WithEvents dgvCompareBom As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents cbBomFilterSide As ComboBox
    Friend WithEvents lbBom2 As ListBox
    Friend WithEvents dgvCompareBomNoteInfo As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents lbBom1 As ListBox
    Friend WithEvents clbBomCheckFilter As CheckedListBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtBom1 As TextBox
    Friend WithEvents cbBomFilterData As ComboBox
    Friend WithEvents txtBomFilter As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnExportBomCompare As Button
    Friend WithEvents btnCompareBom As Button
    Friend WithEvents dgvBom1Code As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents dgvBom2Code As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents dgvCompareCount As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents BomRelate As TabPage
    Private WithEvents dgvBomRelateOrg As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents lbBomRelate As ListBox
    Friend WithEvents txtRelateFilter As TextBox
    Friend WithEvents cbRelateFilter As ComboBox
    Friend WithEvents pbBomRelate As ProgressBar
    Friend WithEvents txtBomRelate As TextBox
    Friend WithEvents dgvBomRelate As DataGridView
    Friend WithEvents btnBomRelate As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents BomFilter As TabPage
    Friend WithEvents lbProgressBar As Label
    Friend WithEvents pbBomFilter As ProgressBar
    Friend WithEvents txtFilePathSave As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents txtFilePathBom As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dgvListBomFilter As DataGridView
    Friend WithEvents AssyCode As DataGridViewTextBoxColumn
    Friend WithEvents TopCode As DataGridViewTextBoxColumn
    Friend WithEvents BotCode As DataGridViewTextBoxColumn
    Friend WithEvents PcbCode As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents ProgramCheck As TabPage
    Friend WithEvents btnRefreshProgramCheckTable As Button
    Friend WithEvents Label29 As Label
    Public WithEvents tabControlPgCheck As TabControl
    Friend WithEvents AoiCheck As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtSearchCheckAoi As TextBox
    Friend WithEvents dgvCheckAoi As DataGridView
    Friend WithEvents MounterCheck As TabPage
    Friend WithEvents Label33 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtSearchCheckMounter As TextBox
    Friend WithEvents dgvCheckMounter As DataGridView
    Friend WithEvents PrinterCheck As TabPage
    Friend WithEvents Label34 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtSearchCheckPrinter As TextBox
    Friend WithEvents dgvCheckPrinter As DataGridView
    Friend WithEvents DailyPlan As TabPage
    Friend WithEvents btnPlanRefresh As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cbPlanShiftFilter As ComboBox
    Friend WithEvents btnImportPlan As Button
    Friend WithEvents cbPlanLineFilter As ComboBox
    Friend WithEvents txtPlanCodeFilter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExportPlan As Button
    Friend WithEvents dtpPlanDate As DateTimePicker
    Friend WithEvents dgvPlan As DataGridView
    Public WithEvents tabControl As TabControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TotalData As TabPage
    Friend WithEvents btnRefreshDataTotal As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearchDataTotal As TextBox
    Friend WithEvents dgvDataTotal As DataGridView
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents dgvEcnData As DataGridView
    Friend WithEvents btnRefreshEcnData As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents txtSearchEcn As TextBox
    Friend WithEvents btnImportEcn As Button
    Friend WithEvents Maintenance As TabPage
    Friend WithEvents tabControlMaintenance As TabControl
    Friend WithEvents MachineReport As TabPage
    Friend WithEvents PmPlan As TabPage
    Friend WithEvents SparePart As TabPage
    Friend WithEvents Improvement As TabPage
    Friend WithEvents btnCreateReport As Button
    Friend WithEvents btnRefreshDailyReport As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents txtSearchReport As TextBox
    Friend WithEvents dgvDailyReport As DataGridView
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents dtpReportEndDay As DateTimePicker
    Friend WithEvents Label41 As Label
    Friend WithEvents dtpReportStartDay As DateTimePicker
    Friend WithEvents cbReportMachine As ComboBox
    Friend WithEvents cbReportLine As ComboBox
    Friend WithEvents cbReportSkipDateFilter As CheckBox
    Friend WithEvents ttReportStartDay As ToolTip
    Friend WithEvents Label47 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label43 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label44 As Label
    Friend WithEvents btnAddPmPlan As Button
    Friend WithEvents btnRefreshPmList As Button
    Friend WithEvents Label48 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvPmPlan As DataGridView
    Friend WithEvents Label45 As Label
    Friend WithEvents btnExportDailyReport As Button
End Class
