<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPcbLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPcbLocation))
        Me.locationPanel = New System.Windows.Forms.Panel()
        Me.txtSearchLocation = New System.Windows.Forms.TextBox()
        Me.dgvLocationList = New System.Windows.Forms.DataGridView()
        Me.dgvBomLocationDetail = New System.Windows.Forms.DataGridView()
        Me.cbSideSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.framePanel = New System.Windows.Forms.Panel()
        Me.lbZoom = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSelectCadColor = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cdLocationView = New System.Windows.Forms.ColorDialog()
        Me.btnSelectBomColor = New System.Windows.Forms.Button()
        Me.btnSelectPointColor = New System.Windows.Forms.Button()
        Me.btnSelectBackgroundColor = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResultCount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSelectLocation = New System.Windows.Forms.TextBox()
        Me.txtSelectPart = New System.Windows.Forms.TextBox()
        Me.btnTextColor = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTextShow = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPanelRefresh = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvLocationList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBomLocationDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.framePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'locationPanel
        '
        Me.locationPanel.AutoScroll = True
        Me.locationPanel.Location = New System.Drawing.Point(4, 4)
        Me.locationPanel.Name = "locationPanel"
        Me.locationPanel.Size = New System.Drawing.Size(228, 410)
        Me.locationPanel.TabIndex = 0
        '
        'txtSearchLocation
        '
        Me.txtSearchLocation.Location = New System.Drawing.Point(7, 174)
        Me.txtSearchLocation.Name = "txtSearchLocation"
        Me.txtSearchLocation.Size = New System.Drawing.Size(92, 20)
        Me.txtSearchLocation.TabIndex = 2
        '
        'dgvLocationList
        '
        Me.dgvLocationList.AllowUserToAddRows = False
        Me.dgvLocationList.AllowUserToDeleteRows = False
        Me.dgvLocationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLocationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocationList.Location = New System.Drawing.Point(7, 226)
        Me.dgvLocationList.Name = "dgvLocationList"
        Me.dgvLocationList.ReadOnly = True
        Me.dgvLocationList.RowHeadersWidth = 5
        Me.dgvLocationList.Size = New System.Drawing.Size(232, 218)
        Me.dgvLocationList.TabIndex = 3
        '
        'dgvBomLocationDetail
        '
        Me.dgvBomLocationDetail.AllowUserToAddRows = False
        Me.dgvBomLocationDetail.AllowUserToDeleteRows = False
        Me.dgvBomLocationDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBomLocationDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBomLocationDetail.Location = New System.Drawing.Point(7, 34)
        Me.dgvBomLocationDetail.Name = "dgvBomLocationDetail"
        Me.dgvBomLocationDetail.ReadOnly = True
        Me.dgvBomLocationDetail.RowHeadersWidth = 5
        Me.dgvBomLocationDetail.Size = New System.Drawing.Size(232, 121)
        Me.dgvBomLocationDetail.TabIndex = 4
        '
        'cbSideSelect
        '
        Me.cbSideSelect.FormattingEnabled = True
        Me.cbSideSelect.Items.AddRange(New Object() {"Top", "Bot"})
        Me.cbSideSelect.Location = New System.Drawing.Point(105, 173)
        Me.cbSideSelect.Name = "cbSideSelect"
        Me.cbSideSelect.Size = New System.Drawing.Size(51, 21)
        Me.cbSideSelect.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Side"
        '
        'framePanel
        '
        Me.framePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.framePanel.AutoScroll = True
        Me.framePanel.BackColor = System.Drawing.Color.Gray
        Me.framePanel.Controls.Add(Me.locationPanel)
        Me.framePanel.Location = New System.Drawing.Point(245, 7)
        Me.framePanel.Name = "framePanel"
        Me.framePanel.Size = New System.Drawing.Size(789, 645)
        Me.framePanel.TabIndex = 8
        '
        'lbZoom
        '
        Me.lbZoom.AutoSize = True
        Me.lbZoom.Location = New System.Drawing.Point(148, 13)
        Me.lbZoom.Name = "lbZoom"
        Me.lbZoom.Size = New System.Drawing.Size(34, 13)
        Me.lbZoom.TabIndex = 11
        Me.lbZoom.Text = "Zoom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "No Mount Point"
        '
        'btnSelectCadColor
        '
        Me.btnSelectCadColor.Location = New System.Drawing.Point(109, 539)
        Me.btnSelectCadColor.Name = "btnSelectCadColor"
        Me.btnSelectCadColor.Size = New System.Drawing.Size(107, 22)
        Me.btnSelectCadColor.TabIndex = 13
        Me.btnSelectCadColor.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 488)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Mount Point"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Point Select Color"
        '
        'btnSelectBomColor
        '
        Me.btnSelectBomColor.Location = New System.Drawing.Point(109, 483)
        Me.btnSelectBomColor.Name = "btnSelectBomColor"
        Me.btnSelectBomColor.Size = New System.Drawing.Size(107, 22)
        Me.btnSelectBomColor.TabIndex = 16
        Me.btnSelectBomColor.UseVisualStyleBackColor = True
        '
        'btnSelectPointColor
        '
        Me.btnSelectPointColor.Location = New System.Drawing.Point(109, 511)
        Me.btnSelectPointColor.Name = "btnSelectPointColor"
        Me.btnSelectPointColor.Size = New System.Drawing.Size(107, 22)
        Me.btnSelectPointColor.TabIndex = 17
        Me.btnSelectPointColor.UseVisualStyleBackColor = True
        '
        'btnSelectBackgroundColor
        '
        Me.btnSelectBackgroundColor.Location = New System.Drawing.Point(109, 567)
        Me.btnSelectBackgroundColor.Name = "btnSelectBackgroundColor"
        Me.btnSelectBackgroundColor.Size = New System.Drawing.Size(107, 22)
        Me.btnSelectBackgroundColor.TabIndex = 19
        Me.btnSelectBackgroundColor.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 572)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Background"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(164, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Search Count"
        '
        'txtResultCount
        '
        Me.txtResultCount.Enabled = False
        Me.txtResultCount.Location = New System.Drawing.Point(163, 173)
        Me.txtResultCount.Name = "txtResultCount"
        Me.txtResultCount.Size = New System.Drawing.Size(76, 20)
        Me.txtResultCount.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 12)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Di chuyển chuột vào khung để xem điểm được chọn ->"
        '
        'txtSelectLocation
        '
        Me.txtSelectLocation.Enabled = False
        Me.txtSelectLocation.Location = New System.Drawing.Point(7, 200)
        Me.txtSelectLocation.Name = "txtSelectLocation"
        Me.txtSelectLocation.Size = New System.Drawing.Size(113, 20)
        Me.txtSelectLocation.TabIndex = 23
        '
        'txtSelectPart
        '
        Me.txtSelectPart.Enabled = False
        Me.txtSelectPart.Location = New System.Drawing.Point(126, 200)
        Me.txtSelectPart.Name = "txtSelectPart"
        Me.txtSelectPart.Size = New System.Drawing.Size(113, 20)
        Me.txtSelectPart.TabIndex = 24
        '
        'btnTextColor
        '
        Me.btnTextColor.Location = New System.Drawing.Point(109, 595)
        Me.btnTextColor.Name = "btnTextColor"
        Me.btnTextColor.Size = New System.Drawing.Size(52, 22)
        Me.btnTextColor.TabIndex = 26
        Me.btnTextColor.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 600)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Text"
        '
        'cbTextShow
        '
        Me.cbTextShow.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbTextShow.Location = New System.Drawing.Point(167, 597)
        Me.cbTextShow.Name = "cbTextShow"
        Me.cbTextShow.Size = New System.Drawing.Size(49, 20)
        Me.cbTextShow.TabIndex = 27
        Me.cbTextShow.Text = "Show"
        Me.cbTextShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTextShow.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 12)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Bấm giữ nguyên chuột phải để di chuyển khung hình ->"
        '
        'btnPanelRefresh
        '
        Me.btnPanelRefresh.BackColor = System.Drawing.Color.PowderBlue
        Me.btnPanelRefresh.Image = CType(resources.GetObject("btnPanelRefresh.Image"), System.Drawing.Image)
        Me.btnPanelRefresh.Location = New System.Drawing.Point(116, 7)
        Me.btnPanelRefresh.Name = "btnPanelRefresh"
        Me.btnPanelRefresh.Size = New System.Drawing.Size(26, 24)
        Me.btnPanelRefresh.TabIndex = 52
        Me.btnPanelRefresh.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Location View"
        '
        'frmPcbLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 664)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnPanelRefresh)
        Me.Controls.Add(Me.lbZoom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.framePanel)
        Me.Controls.Add(Me.cbTextShow)
        Me.Controls.Add(Me.btnTextColor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSelectPart)
        Me.Controls.Add(Me.txtSelectLocation)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtResultCount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSelectBackgroundColor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSelectPointColor)
        Me.Controls.Add(Me.btnSelectBomColor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSelectCadColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBomLocationDetail)
        Me.Controls.Add(Me.cbSideSelect)
        Me.Controls.Add(Me.txtSearchLocation)
        Me.Controls.Add(Me.dgvLocationList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmPcbLocation"
        Me.Text = "Location View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvLocationList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBomLocationDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.framePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchLocation As TextBox
    Friend WithEvents dgvLocationList As DataGridView
    Friend WithEvents dgvBomLocationDetail As DataGridView
    Friend WithEvents cbSideSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents framePanel As Panel
    Friend WithEvents lbZoom As Label
    Public WithEvents locationPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSelectCadColor As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cdLocationView As ColorDialog
    Friend WithEvents btnSelectBomColor As Button
    Friend WithEvents btnSelectPointColor As Button
    Friend WithEvents btnSelectBackgroundColor As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtResultCount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSelectLocation As TextBox
    Friend WithEvents txtSelectPart As TextBox
    Friend WithEvents btnTextColor As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cbTextShow As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPanelRefresh As Button
    Friend WithEvents Label11 As Label
End Class
