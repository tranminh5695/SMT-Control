Imports ClosedXML.Excel '
Imports SQLitePCL
Imports System.IO '

Public Class frmCompareBom
    Public filePath1 As String
    Public filePath2 As String
    Public filePathFilter As String
    Public filePathFilterSave As String
    Public fileCadImport As String
    Public fileBomImport As String()
    Public resultsRelate As New DataTable()
    Public resultsRelateView As New DataView(resultsRelate)
    Public resutlsCadTable As New DataTable()
    Public resutlsCadTableView As New DataView(resutlsCadTable)
    Public resutlsBomTable As New DataTable()
    Public resutlsBomTableView As New DataView(resutlsBomTable)
    Public resutlsCheckAoi As New DataTable()
    Public resutlsCheckAoiView As New DataView(resutlsCheckAoi)
    Public resutlsCheckMounter As New DataTable()
    Public resutlsCheckMounterView As New DataView(resutlsCheckMounter)
    Public resutlsCheckPrinter As New DataTable()
    Public resutlsCheckPrinterView As New DataView(resutlsCheckPrinter)
    Public resultsOtp As New DataTable()
    Public resultsBomOtp As New DataTable()
    Public resultsBomCompare As New DataTable()
    Public resultsBomCompareView As New DataView(resultsBomCompare)
    Public resutlsPlanTable As New DataTable()
    Public resutlsPlanTableView As New DataView(resutlsPlanTable)
    Public resutlsMaterial As New DataTable()
    Public resutlsMaterialView As New DataView(resutlsMaterial)
    Public resutlsDataTotal As New DataTable()
    Public resutlsDataTotalView As New DataView(resutlsDataTotal)
    Public resutlsEcnData As New DataTable()
    Public resutlsEcnDataView As New DataView(resutlsEcnData)
    Public resutlsDailyReportData As New DataTable()
    Public resutlsDailyReportDataView As New DataView(resutlsDailyReportData)
    Public resutlsPmPlanData As New DataTable()
    Public resutlsPmPlanDataView As New DataView(resutlsPmPlanData)

    'Form Bom compare load
    Private Sub frmCompareBOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isDbConnect As Boolean
        'Create column for result datatable
        With resultsBomCompare.Columns
            .Add("Check", GetType(String))
            .Add("Location", GetType(String))
            .Add("Side", GetType(String))
            .Add("Bom1", GetType(String))
            .Add("Bom2", GetType(String))
        End With
        'Create column for result bom relate datatable
        With resultsRelate
            .Columns.Add("Assy", GetType(String))
            .Columns("Assy").ColumnName = "Assy"
            .Columns.Add("Top", GetType(String))
            .Columns("Top").ColumnName = "Top"
            .Columns.Add("Bot", GetType(String))
            .Columns("Bot").ColumnName = "Bot"
            .Columns.Add("AddTop", GetType(Integer))
            .Columns("AddTop").ColumnName = "Thêm Top"
            .Columns.Add("RemoveTop", GetType(Integer))
            .Columns("RemoveTop").ColumnName = "Gỡ Top"
            .Columns.Add("ReplaceTop", GetType(Integer))
            .Columns("ReplaceTop").ColumnName = "Thay Top"
            .Columns.Add("SumTop", GetType(Integer))
            .Columns("SumTop").ColumnName = "Tổng Top"
            .Columns.Add("AddBot", GetType(Integer))
            .Columns("AddBot").ColumnName = "Thêm Bot"
            .Columns.Add("RemoveBot", GetType(Integer))
            .Columns("RemoveBot").ColumnName = "Gỡ Bot"
            .Columns.Add("ReplaceBot", GetType(Integer))
            .Columns("ReplaceBot").ColumnName = "Thay Bot"
            .Columns.Add("SumBot", GetType(Integer))
            .Columns("SumBot").ColumnName = "Tổng Bot"
        End With
        'Create column for result cad datatable
        With resutlsCadTable.Columns
            .Clear()
            .Add("No.", GetType(Integer))
            .Add("Location", GetType(String))
            .Add("X_Cor", GetType(String))
            .Add("Y_Cor", GetType(String))
            .Add("Angle", GetType(String))
            .Add("Side", GetType(String))
        End With
        'Create column for result bom datatable
        With resutlsBomTable.Columns
            .Clear()
            .Add("No.", GetType(Integer))
            .Add("Assy Code", GetType(String))
            .Add("SMT Code", GetType(String))
            .Add("Location", GetType(String))
            .Add("Side", GetType(String))
            .Add("Component", GetType(String))
            .Add("Description", GetType(String))
        End With

        'Create column for resutl plan datatable
        Dim colPlan As String() = {"Line", "Shift", "TT", "Capa", "Start", "Finish", $"Work{vbCrLf}Time",
            $"MC", "SMT", "Assy", "PCB", "Array", "Qty", "Side", "Solder", "Printer", "Mounter", "Aoi", "ECN", "Note"}
        With resutlsPlanTable.Columns
            For Each col In colPlan
                If col = "Qty" Then
                    .Add(col, GetType(Integer))
                Else
                    .Add(col, GetType(String))
                End If
            Next
        End With

        Dim colDataTotal As String() = {"Assy", "Top", "Bot", "Pcb", "Top Point", "Bot Point", "Last Update", "Ecn"}
        With resutlsDataTotal.Columns
            For Each col In colDataTotal
                .Add(col, GetType(String))
            Next
        End With

        Dim colEcnData As String() = {"Ecn Code", "Week", "Pcb", "Apply Day"}
        With resutlsEcnData.Columns
            For Each col In colEcnData
                .Add(col, GetType(String))
            Next
        End With

        Dim colDailyReportData As String() = {"id", "Day", "Line", "Machine", "Type", "Status", "Lot", "Start", "End", "Losstime"}
        With resutlsDailyReportData.Columns
            For Each col In colDailyReportData
                If col.ToLower = "id" Or col.ToLower = "losstime" Or col.ToLower = "line" Then
                    .Add(col, GetType(Integer))
                ElseIf col.ToLower = "day" Or col.ToLower = "Start" Or col.ToLower = "End" Then
                    .Add(col, GetType(DateTime))
                Else
                    .Add(col, GetType(String))
                End If
            Next
        End With

        Dim colPmData As String() = {"Day", "Percent"}
        With resutlsPmPlanData.Columns
            For Each col In colPmData
                If col.ToLower = "day" Then
                    .Add(col, GetType(DateTime))
                Else
                    .Add(col, GetType(String))
                End If
            Next
        End With

        'Create column for OTP datatable
        With resultsOtp.Columns
            .Add("OTP", GetType(String))
            .Add("Location", GetType(String))
        End With
        'Create column for Bom OTP datatable
        With resultsBomOtp.Columns
            .Add("OTP", GetType(String))
            .Add("Location", GetType(String))
            .Add("Side", GetType(String))
            .Add("Raw", GetType(String))
            .Add("Code", GetType(String))
        End With

        'Add Note Information
        With dgvCompareBomNoteInfo
            .Rows.Add("Same")
            .Rows.Add("Different")
            .Rows.Add("Bom1 Exist")
            .Rows.Add("Bom2 Exist")
            .Rows(0).DefaultCellStyle.BackColor = Color.FromArgb(198, 224, 252)
            .Rows(1).DefaultCellStyle.BackColor = Color.LightPink
            .Rows(2).DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196)
            .Rows(3).DefaultCellStyle.BackColor = Color.FromArgb(189, 236, 182)
            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
        End With

        cbReportLine.Items.Clear()
        cbReportLine.Items.Add("All")
        For i = 1 To 20
            cbReportLine.Items.Add(i)
        Next
        cbReportLine.Text = "All"

        'Add item to machine select
        cbReportMachine.Items.Clear()
        Dim listMachine As String() = {"All", "Printer", "Reflow", "PAOI", "MAOI", "SAOI",
                               "Mounter", "WorkTable", "InLoader", "Unloader", "VaccumLoader", "NG Buffer", "Feeder"}
        cbReportMachine.Items.AddRange(listMachine)
        cbReportMachine.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbReportMachine.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim autoCompleteMachine As New AutoCompleteStringCollection()
        autoCompleteMachine.AddRange(listMachine)
        cbReportMachine.AutoCompleteCustomSource = autoCompleteMachine
        cbReportMachine.Text = "All"

        dtpReportEndDay.Value = Today.Date
        dtpReportStartDay.Value = Today.Date.AddDays(-14)



        'Load database connection string
        CreateConfigDb()
        With dgvDbConfig
            .Rows.Clear()
            For Each db In LoadConfigDb()
                .Rows.Add(db.key, db.ip, db.dataTable, db.username, db.pass)
            Next
        End With
        GetConnectString()

        isDbConnect = CheckConnectDb()

        If isDbConnect = True Then
            ' Thêm cột Button để mở hình ảnh
            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = "Mở File Bom"
            buttonColumn.Text = "Mở File"
            buttonColumn.UseColumnTextForButtonValue = True
            dgvListBomFilter.Columns.Add(buttonColumn)

            'Set all to RelateFilter
            cbRelateFilter.Text = "All"

            'Add item for cad list view data
            lbCadList.Items.Clear()
            For Each cad In GetPcbCadList()
                lbCadList.Items.Add(cad)
            Next

            'Add item for treeview bom data
            tvBomList.Nodes.Clear()
            For Each bom In GetBomList()
                Dim bomDetail As Array = bom.ToString().Split(" "c)
                Dim parentNode As TreeNode = tvBomList.Nodes.Cast(Of TreeNode)().FirstOrDefault(Function(node) node.Text = bomDetail(3))
                'Thêm PcbCode cha nếu chưa tồn tại
                If parentNode Is Nothing Then
                    parentNode = tvBomList.Nodes.Add(bomDetail(3))
                End If
                'Thêm bom vào PcbCode cha
                If Not parentNode.Nodes.Cast(Of TreeNode)().Any(Function(node) node.Text = bom) Then
                    parentNode.Nodes.Add(bom)
                End If
            Next

            'Load line count
            txtLineCount.Text = GetLineCount()
            CreateProgramCheckLineColumn(Convert.ToInt32(txtLineCount.Text), "checkaoi")
            CreateProgramCheckLineColumn(Convert.ToInt32(txtLineCount.Text), "checkmounter")
            CreateProgramCheckLineColumn(Convert.ToInt32(txtLineCount.Text), "checkprinter")
            CreateConfigDb()

            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed
            tabControlPgCheck.DrawMode = TabDrawMode.OwnerDrawFixed
            tabControlBomCompare.DrawMode = TabDrawMode.OwnerDrawFixed
            tabControlData.DrawMode = TabDrawMode.OwnerDrawFixed
            tabControlMaintenance.DrawMode = TabDrawMode.OwnerDrawFixed
            'Set all to PlanFilter
            cbPlanLineFilter.Text = "All"
            cbPlanShiftFilter.Text = "All"
        Else
            MessageBox.Show("Kiểm tra kết nối db trong tab Config!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Chú thích
        ttButton.SetToolTip(btnExportPlan, "Tải plan")
        ttButton.SetToolTip(btnImportPlan, "Cập nhật plan")
        ttButton.SetToolTip(btnPlanRefresh, "Tải lại dữ liệu")
        ttButton.SetToolTip(btnRefreshProgramCheckTable, "Làm mới")
        ttButton.SetToolTip(btnRefreshConfigTable, "Làm mới")
        ttButton.SetToolTip(dtpPlanDate, "Chọn ngày plan")
        ttButton.SetToolTip(txtPlanCodeFilter, "Tìm kiếm")
        ttButton.SetToolTip(btnFilter, "Lọc Bom")
        ttButton.SetToolTip(btnCompareBom, "So sánh Bom")
        ttButton.SetToolTip(txtCadData, "Tìm kiếm")
        ttButton.SetToolTip(txtBomData, "Tìm kiếm")
    End Sub

    'Compare bom data
    Private Sub btnCompareBom_Click(sender As Object, e As EventArgs) Handles btnCompareBom.Click
        Dim dataBom1 As New List(Of (assy As String, smt As String, loc As String, com As String, des As String))
        Dim dataBom2 As New List(Of (assy As String, smt As String, loc As String, com As String, des As String))
        Dim cadData As New List(Of (side As String, loc As String, x As String, y As String, angle As String))
        Dim existsBom1 As Boolean
        Dim existsBom2 As Boolean
        Dim indexFindBom1 As Integer
        Dim indexFindBom2 As Integer
        Dim topBom1Count, topBom2Count, topDifCount, topSameCount, botBom1Count, botBom2Count, botDifCount, botSameCount As Integer

        Dim bomDetail1 As Array = txtBom1.Text.ToString().Split(" "c)
        Dim bomDetail2 As Array = txtBom2.Text.ToString().Split(" "c)

        resultsBomCompare.Rows.Clear()

        If txtBom1.Text = "" Or txtBom2.Text = "" Then
            MessageBox.Show(Me, "Chọn 2 Bom để compare!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'Get Cad data
        If bomDetail1.Length >= 4 And bomDetail2.Length >= 4 Then
            If bomDetail1(3) <> bomDetail2(3) And InStr(1, bomDetail1(3), "BN41-") > 0 And InStr(1, bomDetail2(3), "BN41-") > 0 Then
                MessageBox.Show(Me, "Bom khác Pcb!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Else
            MessageBox.Show(Me, "Kiểm tra lại tên Code!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Get Bom data
        If Not cbBomVersion1.Checked Then
            dataBom1 = GetBomData(txtBom1.Text)
        Else
            dataBom1 = GetBomOldData(txtBom1.Text)
        End If

        If Not cbBomVersion2.Checked Then
            dataBom2 = GetBomData(txtBom2.Text)
        Else
            dataBom2 = GetBomOldData(txtBom2.Text)
        End If
        cadData = GetPcbCadData(bomDetail1(3))

        For Each locPoint In cadData
            'Kiểm tra location có trong Bom không
            existsBom1 = dataBom1.Any(Function(item) item.loc = locPoint.loc)
            existsBom2 = dataBom2.Any(Function(item) item.loc = locPoint.loc)

            'Nếu có thì lấy vị trí trong list
            If existsBom1 Then
                indexFindBom1 = dataBom1.FindIndex(Function(code) code.loc = locPoint.loc)
            End If
            If existsBom2 Then
                indexFindBom2 = dataBom2.FindIndex(Function(code) code.loc = locPoint.loc)
            End If

            'Compare
            If existsBom1 = True And existsBom2 = False Then ' Bom1 có, Bom 2 ko
                resultsBomCompare.Rows.Add("Bom1", locPoint.loc, locPoint.side.ToUpper, dataBom1(indexFindBom1).com, "")
            ElseIf existsBom1 = False And existsBom2 = True Then ' Bom 1 ko, Bom 2 có
                resultsBomCompare.Rows.Add("Bom2", locPoint.loc, locPoint.side.ToUpper, "", dataBom2(indexFindBom2).com)
            ElseIf existsBom1 = True And existsBom2 = True Then ' Bom 1 có, Bom 2 có
                If dataBom1(indexFindBom1).com <> dataBom2(indexFindBom2).com Then
                    resultsBomCompare.Rows.Add("Dif", locPoint.loc, locPoint.side.ToUpper, dataBom1(indexFindBom1).com, dataBom2(indexFindBom2).com)
                Else
                    resultsBomCompare.Rows.Add("Same", locPoint.loc, locPoint.side.ToUpper, dataBom1(indexFindBom1).com, dataBom2(indexFindBom2).com)
                End If
            End If
        Next

        topBom1Count = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Bom1" _
                                                                        And row.Field(Of String)("Side") = "TOP")
        topBom2Count = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Bom2" _
                                                                        And row.Field(Of String)("Side") = "TOP")
        topDifCount = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Dif" _
                                                                        And row.Field(Of String)("Side") = "TOP")
        topSameCount = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Same" _
                                                                        And row.Field(Of String)("Side") = "TOP")
        botBom1Count = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Bom1" _
                                                                        And row.Field(Of String)("Side") = "BOT")
        botBom2Count = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Bom2" _
                                                                        And row.Field(Of String)("Side") = "BOT")
        botDifCount = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Dif" _
                                                                        And row.Field(Of String)("Side") = "BOT")
        botSameCount = resultsBomCompare.AsEnumerable().Count(Function(row) row.Field(Of String)("Check") = "Same" _
                                                                        And row.Field(Of String)("Side") = "BOT")
        dgvCompareBom.DataSource = resultsBomCompareView

        dgvCompareCount.Rows.Clear()
        With dgvCompareCount.Rows
            .Add("Bom1", topBom1Count, botBom1Count)
            .Add("Bom2", topBom2Count, botBom2Count)
            .Add("Different", topDifCount, botDifCount)
            .Add("Same", topSameCount, botSameCount)
        End With

        BomFilterDefault()
        ApplyFilterDataBomCompare()
    End Sub


    'Relate Bom
    Private Sub btnBomRelate_Click(sender As Object, e As EventArgs) Handles btnBomRelate.Click
        If txtBomRelate.Text = "" Then
            MessageBox.Show("Chọn BOM để compare!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        resultsRelate.Clear()
        dgvBomRelateOrg.Rows.Clear()
        Application.DoEvents()
        'Dim countTopBom1, countTopBom2, countTopDif, countTopSame, countBotBom1, countBotBom2, countBotDif, countBotSame As Integer
        'Dim pcbCodeBom1, pcbCodeBom2 As String
        Dim dataBom1 As New List(Of (assy As String, smt As String, loc As String, com As String, des As String))
        Dim dataBom2 As New List(Of (assy As String, smt As String, loc As String, com As String, des As String))
        Dim bomList As New List(Of String)
        Dim cadData As New List(Of (side As String, loc As String, x As String, y As String, angle As String))
        Dim codeDetail As Array = txtBomRelate.Text.ToString().Split(" "c)
        Dim codeRelateDetail As Array
        Dim existsBom1 As Boolean
        Dim existsBom2 As Boolean
        Dim indexFindBom1 As Integer
        Dim indexFindBom2 As Integer
        Dim topBom1Count, topBom2Count, topDifCount, botBom1Count, botBom2Count, botDifCount As Integer

        dataBom1 = GetBomData(txtBomRelate.Text)
        cadData = GetPcbCadData(codeDetail(3))
        dgvBomRelateOrg.Rows.Add(codeDetail(0), codeDetail(1), codeDetail(2), codeDetail(3))

        'Lấy danh sách list bom chung pcb
        For Each bom In GetBomList()
            codeRelateDetail = bom.ToString().Split(" "c)
            If codeDetail(3) = codeRelateDetail(3) And codeRelateDetail(3) <> "" Then
                bomList.Add(bom)
            End If
        Next

        pbBomRelate.Minimum = 0
        pbBomRelate.Value = 0
        pbBomRelate.Maximum = bomList.Count
        pbBomRelate.Step = 1

        For Each bom In bomList
            topBom1Count = 0
            topBom2Count = 0
            topDifCount = 0
            botBom1Count = 0
            botBom2Count = 0
            botDifCount = 0

            codeRelateDetail = bom.ToString().Split(" "c)
            dataBom2 = GetBomData(bom)

            For Each locPoint In cadData
                'Kiểm tra location có trong Bom không
                existsBom1 = dataBom1.Any(Function(item) item.loc = locPoint.loc)
                existsBom2 = dataBom2.Any(Function(item) item.loc = locPoint.loc)

                'Nếu có thì lấy vị trí trong list
                If existsBom1 Then
                    indexFindBom1 = dataBom1.FindIndex(Function(code) code.loc = locPoint.loc)
                End If
                If existsBom2 Then
                    indexFindBom2 = dataBom2.FindIndex(Function(code) code.loc = locPoint.loc)
                End If

                'Compare
                If existsBom1 = True And existsBom2 = False Then ' Bom1 có, Bom 2 ko
                    If locPoint.side.ToLower = "top" Then
                        topBom1Count += 1
                    Else
                        botBom1Count += 1
                    End If
                ElseIf existsBom1 = False And existsBom2 = True Then ' Bom 1 ko, Bom 2 có
                    If locPoint.side.ToLower = "top" Then
                        topBom2Count += 1
                    Else
                        botBom2Count += 1
                    End If
                ElseIf existsBom1 = True And existsBom2 = True Then ' Bom 1 có, Bom 2 có
                    If dataBom1(indexFindBom1).com <> dataBom2(indexFindBom2).com Then
                        If locPoint.side.ToLower = "top" Then
                            topDifCount += 1
                        Else
                            botDifCount += 1
                        End If
                    End If
                End If
            Next
            pbBomRelate.PerformStep()
            resultsRelate.Rows.Add(codeRelateDetail(0), codeRelateDetail(1), codeRelateDetail(2), topBom2Count, topBom1Count, topDifCount, topBom1Count + topBom2Count + topDifCount, botBom2Count, botBom1Count, botDifCount, botBom1Count + botBom2Count + botDifCount)
            Application.DoEvents()
        Next
        dgvBomRelate.DataSource = resultsRelateView
        SetDgvBomRelateColumns()
        MessageBox.Show(Me, "Đã hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtBomRelate.Text = ""
    End Sub

    'Filter Bom
    Private Async Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim currentAssyCode As String
        Dim fileExcelName As String
        Dim rowCount As Integer
        Dim bomCount As Integer
        Dim isExportFile As String
        Dim listBom As List(Of (assyCode As String, topCode As String, botCode As String, pcbCode As String))
        Dim listCad As List(Of (assyCode As String, parentCode As String, Location As String, part As String, description As String))

        If filePathFilter = "" Or filePathFilterSave = "" Then
            MessageBox.Show("Chọn file BOM và đường dẫn lưu file để Lọc Bom!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        pbBomFilter.Value = 0
        Await BomFilterProgress("bom", 0)
        Application.DoEvents()
        listBom = GetListOfBom(filePathFilter)
        Await BomFilterProgress("cad", 0)
        Application.DoEvents()
        listCad = GetListOfCad(filePathFilter)

        dgvListBomFilter.Rows.Clear()

        FilterProgressBarConfig(listBom.Count)

        For Each bom In listBom
            currentAssyCode = bom.assyCode
            fileExcelName = String.Join(" ", bom.assyCode, bom.topCode, bom.botCode, bom.pcbCode) & ".xlsx"
            Using workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add(bom.assyCode)

                worksheet.Style.Font.FontName = "Arial"
                worksheet.Style.Font.FontSize = 10

                ' Ghi thông tin header cho cột
                worksheet.Cell(1, 1).Value = "Assy Code"
                worksheet.Cell(1, 2).Value = "SMT Code"
                worksheet.Cell(1, 3).Value = "Location"
                worksheet.Cell(1, 4).Value = "Component"
                worksheet.Cell(1, 5).Value = "Description"
                worksheet.Row(1).Style.Font.Bold = True

                If bom.topCode <> "" Then
                    rowCount = worksheet.RowsUsed.Count + 1
                    worksheet.Cell(rowCount, 1).Value = bom.assyCode
                    worksheet.Cell(rowCount, 2).Value = bom.topCode
                    worksheet.Cell(rowCount, 5).Value = "ASSY SMD TOP"
                End If
                If bom.botCode <> "" Then
                    rowCount = worksheet.RowsUsed.Count + 1
                    worksheet.Cell(rowCount, 1).Value = bom.assyCode
                    worksheet.Cell(rowCount, 2).Value = bom.botCode
                    worksheet.Cell(rowCount, 5).Value = "ASSY SMD BOT"
                End If

                rowCount = worksheet.RowsUsed.Count + 1
                For Each cad In listCad
                    If bom.assyCode = cad.assyCode Then
                        worksheet.Cell(rowCount, 1).Value = cad.assyCode
                        worksheet.Cell(rowCount, 2).Value = cad.parentCode
                        worksheet.Cell(rowCount, 3).Value = cad.Location
                        worksheet.Cell(rowCount, 4).Value = cad.part
                        worksheet.Cell(rowCount, 5).Value = cad.description
                        rowCount = rowCount + 1
                    End If
                Next

                worksheet.Columns().AdjustToContents()

                If isFileExcelOpen(filePathFilterSave & "\" & bom.pcbCode & "\" & fileExcelName) Then
                    isExportFile = "NG"
                Else
                    CreatePcbFolder(filePathFilterSave & "\" & bom.pcbCode)
                    ' Lưu file Excel
                    workbook.SaveAs(filePathFilterSave & "\" & bom.pcbCode & "\" & fileExcelName)
                    isExportFile = "OK"
                    bomCount = bomCount + 1
                End If
                dgvListBomFilter.Rows.Add(bom.assyCode, bom.topCode, bom.botCode, bom.pcbCode, isExportFile)
                workbook.Dispose()
            End Using
            pbBomFilter.PerformStep()
            Await BomFilterProgress("count", bomCount)
            Application.DoEvents()
        Next
        For Each row As DataGridViewRow In dgvListBomFilter.Rows
            If row.Cells(4).Value = "NG" Then
                row.DefaultCellStyle.BackColor = System.Drawing.Color.OrangeRed
            Else
                row.DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow
            End If
        Next

        dgvListBomFilter.Sort(dgvListBomFilter.Columns(4), System.ComponentModel.ListSortDirection.Ascending)
        MessageBox.Show("Bom Filter đã hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Import Cad Data
    Private Sub btnImportCad_Click(sender As Object, e As EventArgs) Handles btnImportCad.Click
        Dim pcbName As String
        Dim cadList As New List(Of (side As String, loc As String, x As String, y As String, angle As String))
        Dim otpInfo As New List(Of (mainIC As String, sub1 As String, sub2 As String, sub3 As String))
        Dim rowCount As Integer = 0

        fileCadImport = OpenFileSelect()

        If fileCadImport = "" Then
            MessageBox.Show("Chọn file CAD cần Import!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        resultsOtp.Clear()
        resutlsCadTable.Clear()
        lbCadList.SelectedItem = Nothing

        pcbName = Path.GetFileNameWithoutExtension(fileCadImport)

        'Clear old table data and filter data
        txtSearchImportCad.Text = ""
        resutlsCadTableView.RowFilter = ""
        resutlsCadTable.Clear()

        cadList = LoadCadFile(fileCadImport)

        If cadList IsNot Nothing Then
            ImportCadToDataBase(pcbName, cadList)
            txtCadData.Text = pcbName
            lbCadList.SelectedItem = pcbName
            MessageBox.Show("Kiểm tra và câp nhật thông tin IC OTP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Cad view data
    Private Sub lbCadList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCadList.SelectedIndexChanged
        Dim cadList As New List(Of (side As String, loc As String, x As String, y As String, angle As String))
        Dim rowCount As Integer = 0
        Dim otpInfo As New List(Of (mainIC As String, sub1 As String, sub2 As String, sub3 As String))
        Dim pcbName As String = lbCadList.Text
        Dim pcbLength, pcbWidth, pcbThickness As String


        If lbCadList.SelectedItem Is Nothing Then
            Return
        End If

        cadList = GetPcbCadData(pcbName)

        'Clear old table data and filter data
        fileCadImport = ""
        txtSearchImportCad.Text = ""
        resutlsCadTableView.RowFilter = ""
        resutlsCadTable.Clear()
        resultsOtp.Clear()


        For Each cadPoint In cadList
            rowCount += 1
            resutlsCadTable.Rows.Add(rowCount, cadPoint.loc, cadPoint.x, cadPoint.y, cadPoint.angle, cadPoint.side.ToUpper)
            If cadPoint.loc.ToLower = "pcbsize" Then
                pcbLength = cadPoint.x
                pcbWidth = cadPoint.y
                pcbThickness = cadPoint.angle
            End If
        Next
        dgvCadImport.DataSource = resutlsCadTableView
        dgvCadImport.Columns("No.").FillWeight = 50

        otpInfo = GetOtpInfo(pcbName)
        For Each info In otpInfo
            resultsOtp.Rows.Add("Main OTP", info.mainIC)
            resultsOtp.Rows.Add("Sub1", info.sub1)
            resultsOtp.Rows.Add("Sub2", info.sub2)
            resultsOtp.Rows.Add("Sub3", info.sub3)
        Next
        dgvOtpInfo.DataSource = resultsOtp

        dgvPcbSize.Rows.Clear()
        dgvPcbSize.Rows.Add(pcbName, pcbLength, pcbWidth, pcbThickness)
    End Sub

    'Update OTP Infor
    Private Sub btnUpdateOtpInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateOtpInfo.Click
        Dim otpInfoUpdate As New List(Of (mainIC As String, sub1 As String, sub2 As String, sub3 As String))
        Dim mainIcUpdate, sub1Update, sub2Update, sub3Update As String
        Dim pcbName As String = ""

        If lbCadList.SelectedItem <> "" Then
            pcbName = lbCadList.SelectedItem
        End If

        If pcbName <> "" And resultsOtp.Rows.Count > 0 Then
            mainIcUpdate = If(IsDBNull(resultsOtp.Rows(0)(1)), "", resultsOtp.Rows(0)(1).ToString.ToUpper)
            sub1Update = If(IsDBNull(resultsOtp.Rows(1)(1)), "", resultsOtp.Rows(1)(1).ToString.ToUpper)
            sub2Update = If(IsDBNull(resultsOtp.Rows(2)(1)), "", resultsOtp.Rows(2)(1).ToString.ToUpper)
            sub3Update = If(IsDBNull(resultsOtp.Rows(3)(1)), "", resultsOtp.Rows(3)(1).ToString.ToUpper)

            otpInfoUpdate.Add((mainIcUpdate, sub1Update, sub2Update, sub3Update))
            UpdateOtpInfo(pcbName, otpInfoUpdate)
            MessageBox.Show("Cập nhật OTP thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Chọn CAD hoặc Import CAD để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    'Export file compare bom data
    Private Sub btnExportBomCompare_Click(sender As Object, e As EventArgs) Handles btnExportBomCompare.Click
        If resultsBomCompareView Is Nothing OrElse resultsBomCompareView.Table.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        frmFileTypeExport.ShowDialog()
        If frmFileTypeExport.fileExportType = "Excel" Then
            ExportFileExcel(resultsBomCompareView, dgvBom1Code.Rows(3).Cells(1).Value)
        ElseIf frmFileTypeExport.fileExportType = "Text" Then
            If frmFileTypeExport.fileExportSide = "top" Then
                ExportFileTextCompare(resultsBomCompareView, dgvBom1Code.Rows(3).Cells(1).Value, "top")
            ElseIf frmFileTypeExport.fileExportSide = "bot" Then
                ExportFileTextCompare(resultsBomCompareView, dgvBom1Code.Rows(3).Cells(1).Value, "bot")
            End If
        End If
    End Sub
    'Export Bom
    Private Sub btnBomExport_Click(sender As Object, e As EventArgs) Handles btnBomExport.Click
        If resutlsBomTableView Is Nothing OrElse resutlsBomTableView.Table.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim bomDetail As Array = tvBomList.SelectedNode.Text.Split(" "c)
        frmFileTypeExport.ShowDialog()
        resutlsBomTableView.RowFilter = Nothing
        If frmFileTypeExport.fileExportType = "Excel" Then
            ExportFileExcel(resutlsBomTableView, dgvBomCodeView.Rows(0).Cells(3).Value)
        ElseIf frmFileTypeExport.fileExportType = "Text" Then
            If frmFileTypeExport.fileExportSide = "top" Then
                ExportFileText(resutlsBomTableView, dgvBomCodeView.Rows(0).Cells(3).Value, bomDetail(1), "top")
            ElseIf frmFileTypeExport.fileExportSide = "bot" Then
                ExportFileText(resutlsBomTableView, dgvBomCodeView.Rows(0).Cells(3).Value, bomDetail(2), "bot")
            End If
        End If
    End Sub

    'Select file Bom to Filter
    Private Sub txtFilePathBom_Click(sender As Object, e As EventArgs) Handles txtFilePathBom.Click
        filePathFilter = OpenFileSelect()
        txtFilePathBom.Text = filePathFilter
    End Sub

    'Select file path to save Bom Filter
    Private Sub txtFilePathSave_Click(sender As Object, e As EventArgs) Handles txtFilePathSave.Click
        filePathFilterSave = SaveFilePath()
        txtFilePathSave.Text = filePathFilterSave
    End Sub

    Private Sub txtRelateFilter_TextChanged(sender As Object, e As EventArgs) Handles txtRelateFilter.TextChanged
        ApplyFilterDataRelate()
    End Sub

    'Apply filter bom compare
    Private Sub txtBomFilter_TextChanged(sender As Object, e As EventArgs) Handles txtBomFilter.TextChanged
        ApplyFilterDataBomCompare()
    End Sub
    Private Sub cbBomFilterSide_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBomFilterSide.SelectedIndexChanged
        ApplyFilterDataBomCompare()
    End Sub
    Private Sub clbBomCheckFilter_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbBomCheckFilter.ItemCheck
        Me.BeginInvoke(New Action(Sub() ApplyFilterDataBomCompare()))
    End Sub
    Private Sub dgvCompareBom_Sorted(sender As Object, e As EventArgs) Handles dgvCompareBom.Sorted
        ApplyFilterDataBomCompare()
    End Sub
    Private Sub txtSearchImportCad_TextChanged(sender As Object, e As EventArgs) Handles txtSearchImportCad.TextChanged
        ApplyFilterCadView()
    End Sub
    Private Sub txtSearchBom_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBom.TextChanged
        ApplyFilterBomView()
    End Sub

    'Filter Bom Progressbar config
    Public Sub FilterProgressBarConfig(maxValue As Integer)
        pbBomFilter.Minimum = 0
        pbBomFilter.Maximum = maxValue
        pbBomFilter.Step = 1
    End Sub
    'Filter program check
    Private Sub txtSearchCheckAoi_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCheckAoi.TextChanged
        ApplyFilterCheckAoi()
    End Sub
    Private Sub txtSearchCheckMounter_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCheckMounter.TextChanged
        ApplyFilterCheckMounter()
    End Sub
    Private Sub txtSearchCheckPrinter_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCheckPrinter.TextChanged
        ApplyFilterCheckPrinter()
    End Sub


    'FIlter plan
    Private Sub cbPlanLineFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlanLineFilter.SelectedIndexChanged
        ApplyFilterPlanView()
    End Sub

    Private Sub cbPlanShiftFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlanShiftFilter.SelectedIndexChanged
        ApplyFilterPlanView()
    End Sub

    Private Sub txtPlanCodeFilter_TextChanged(sender As Object, e As EventArgs) Handles txtPlanCodeFilter.TextChanged
        ApplyFilterPlanView()
    End Sub

    Private Sub txtMaterialData_TextChanged(sender As Object, e As EventArgs) Handles txtMaterialData.TextChanged
        ApplyFilterMaterial()
    End Sub

    Private Sub txtSearchDataTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDataTotal.TextChanged
        ApplyFilterTotalData()
    End Sub

    Private Sub cbReportLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReportLine.SelectedIndexChanged
        ApplyFilterDailyReport()
    End Sub

    Private Sub cbReportMachine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReportMachine.SelectedIndexChanged
        ApplyFilterDailyReport()
    End Sub

    Private Sub txtSearchReport_TextChanged(sender As Object, e As EventArgs) Handles txtSearchReport.TextChanged
        ApplyFilterDailyReport()
    End Sub
    Private Sub dtpReportStartDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpReportStartDay.ValueChanged
        If dtpReportStartDay.Value.Date > dtpReportEndDay.Value.Date Then
            ' Cấu hình ToolTip
            ttReportStartDay.Show("Ngày bắt đầu lớn hơn ngày kết thúc!", dtpReportStartDay, dtpReportStartDay.Width / 2, dtpReportStartDay.Height, 1000)
        End If

        ApplyFilterDailyReport()
    End Sub
    Private Sub dtpReportEndDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpReportEndDay.ValueChanged
        ApplyFilterDailyReport()
    End Sub

    'Change status in Filter Bom Progressbar
    Private Async Function BomFilterProgress(period As String, bomCount As Integer) As Task
        If period = "bom" Then
            lbProgressBar.Text = "Đếm số lượng Bom..."
        ElseIf period = "cad" Then
            lbProgressBar.Text = "Lấy dữ liệu Bom..."
        ElseIf period = "count" Then
            lbProgressBar.Text = "Đã lọc được " & bomCount & "/" & pbBomFilter.Maximum & " Bom"
        End If
        lbProgressBar.Location = New Point(pbBomFilter.Location.X + pbBomFilter.Width / 2 - lbProgressBar.Width / 2, lbProgressBar.Location.Y)
        lbProgressBar.Show()
    End Function

    Private Sub btnImportBom_Click(sender As Object, e As EventArgs) Handles btnImportBom.Click
        fileBomImport = OpenMultiFileSelect()
        If fileBomImport Is Nothing Then
            Return
        End If
        txtBomData.Text = ""
        ImportBomToDataBase(fileBomImport)
        LoadProgramCheck("checkaoi")
        LoadProgramCheck("checkmounter")
        LoadPrinterPcbCheck("checkprinter")
        MessageBox.Show("Import Bom hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Search for Bom list data
    Private Sub txtBomData_TextChanged(sender As Object, e As EventArgs) Handles txtBomData.TextChanged
        Dim input As String = txtBomData.Text
        Dim bomDetail As Array

        Dim allItems As List(Of String) = GetBomList()
        ' Lọc kết quả gợi ý
        Dim filteredItems = allItems.Where(Function(item) item.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0).ToList()

        tvBomList.Nodes.Clear()
        For Each item In filteredItems
            bomDetail = item.ToString().Split(" "c)
            Dim parentNode As TreeNode = tvBomList.Nodes.Cast(Of TreeNode)().FirstOrDefault(Function(node) node.Text = bomDetail(3))
            'Thêm PcbCode cha nếu chưa tồn tại
            If parentNode Is Nothing Then
                parentNode = tvBomList.Nodes.Add(bomDetail(3))
            End If
            'Thêm bom vào PcbCode cha
            If Not parentNode.Nodes.Cast(Of TreeNode)().Any(Function(node) node.Text = item) Then
                parentNode.Nodes.Add(item)
            End If
        Next
    End Sub

    Private Sub tvBomList_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvBomList.AfterSelect
        Dim selectedNode As TreeNode = e.Node
        ' Kiểm tra nếu là TreeNode con
        If selectedNode.Parent IsNot Nothing Then
            Dim bomList As New List(Of (assy As String, smt As String, loc As String, com As String, des As String))
            Dim rowCount As Integer = 0
            Dim otpInfo As New List(Of (mainIC As String, sub1 As String, sub2 As String, sub3 As String))
            Dim pcbName As String = Mid(selectedNode.Text, InStr(1, selectedNode.Text.ToString, "BN41-"), selectedNode.Text.ToString.Length)
            Dim otpDetail As New List(Of (loc As String, raw As String, otpcode As String))
            Dim codeDetail As Array = selectedNode.Text.ToString().Split(" "c)
            Dim cadData As New List(Of (side As String, loc As String, x As String, y As String, angle As String))
            Dim topCount, botCount As Integer

            bomList = GetBomData(selectedNode.Text)
            cadData = GetPcbCadData(codeDetail(3))
            'Clear old data
            resutlsBomTable.Clear()
            resultsBomOtp.Clear()
            dgvBomCodeView.Rows.Clear()
            txtSearchBom.Text = ""

            For Each bomPoint In bomList
                Dim side As String = cadData.Where(Function(data) data.loc = bomPoint.loc).Select(Function(data) data.side).FirstOrDefault()
                If String.IsNullOrEmpty(side) Then
                    side = ""
                End If
                If side.ToLower = "top" Then
                    topCount += 1
                ElseIf side.ToLower = "bot" Then
                    botCount += 1
                End If

                rowCount += 1
                resutlsBomTable.Rows.Add(rowCount, bomPoint.assy, bomPoint.smt, bomPoint.loc, side.ToUpper, bomPoint.com, bomPoint.des)
            Next

            dgvBomData.DataSource = resutlsBomTableView
            dgvBomData.Columns("No.").FillWeight = 50

            otpInfo = GetOtpInfo(pcbName)

            otpDetail = GetBomOtpInfo(otpInfo, bomList)
            rowCount = 0
            For Each info In otpDetail
                If String.IsNullOrEmpty(info.loc) Then
                    Continue For
                End If

                Dim sideResult As String = cadData.Where(Function(data) data.loc = info.loc).Select(Function(data) data.side).FirstOrDefault().ToUpper
                rowCount += 1
                Select Case rowCount
                    Case 1
                        resultsBomOtp.Rows.Add("Main OTP", info.loc, sideResult, info.raw, info.otpcode)
                    Case 2
                        resultsBomOtp.Rows.Add("Sub1", info.loc, sideResult, info.raw, info.otpcode)
                    Case 3
                        resultsBomOtp.Rows.Add("Sub2", info.loc, sideResult, info.raw, info.otpcode)
                    Case 4
                        resultsBomOtp.Rows.Add("Sub3", info.loc, sideResult, info.raw, info.otpcode)
                End Select
            Next
            dgvBomOtp.DataSource = resultsBomOtp

            dgvBomCodeView.Rows.Add(codeDetail(0), codeDetail(1), codeDetail(2), codeDetail(3))
            lbBomLastUpdate.Text = GetBomLastUpdate(selectedNode.Text)
        End If
    End Sub


    'Search for Cad list data
    Private Sub txtCadData_TextChanged(sender As Object, e As EventArgs) Handles txtCadData.TextChanged
        Dim input As String = txtCadData.Text
        Dim allItems As List(Of String) = GetPcbCadList()
        ' Lọc kết quả gợi ý
        Dim filteredItems = allItems.Where(Function(item) item.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0).ToList()

        ' Hiển thị kết quả trong ListBox
        lbCadList.Items.Clear()
        For Each item In filteredItems
            lbCadList.Items.Add(item)
        Next
    End Sub

    'Search Bom 1 to Compare
    Private Sub txtBom1_TextChanged(sender As Object, e As EventArgs) Handles txtBom1.TextChanged
        Dim input As String = txtBom1.Text
        Dim allItems As List(Of String)

        If Not cbBomVersion1.Checked Then
            allItems = GetBomList()
        Else
            allItems = GetBomOldList()
        End If

        ' Lọc kết quả gợi ý
        Dim filteredItems = allItems.Where(Function(item) item.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0).ToList()

        ' Hiển thị kết quả trong ListBox
        lbBom1.Items.Clear()
        If filteredItems.Count > 0 And txtBom1.Text <> "" Then
            For Each item In filteredItems
                lbBom1.Items.Add(item)
            Next
            lbBom1.Visible = True
        Else
            lbBom1.Visible = False
        End If
    End Sub

    'Show recomend code for bom 1
    Private Sub lbBom1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBom1.SelectedIndexChanged
        If lbBom1.SelectedItem IsNot Nothing Then
            txtBom1.Text = lbBom1.SelectedItem.ToString()
            lbBom1.Visible = False
            Dim codeDetail As Array = txtBom1.Text.ToString().Split(" "c)
            resultsBomCompare.Rows.Clear()
            dgvCompareCount.Rows.Clear()
            dgvBom1Code.Rows.Clear()
            With dgvBom1Code.Rows
                .Add("Smd", codeDetail(0))
                .Add("Top", codeDetail(1))
                .Add("Bot", codeDetail(2))
                .Add("PCB", codeDetail(3))
            End With
        End If
    End Sub

    'Search Bom 2 to Compare
    Private Sub txtBom2_TextChanged(sender As Object, e As EventArgs) Handles txtBom2.TextChanged
        Dim allItems As List(Of String)

        Dim input As String = txtBom2.Text

        If Not cbBomVersion2.Checked Then
            allItems = GetBomList()
        Else
            allItems = GetBomOldList()
        End If
        ' Lọc kết quả gợi ý
        Dim filteredItems = allItems.Where(Function(item) item.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0).ToList()

        ' Hiển thị kết quả trong ListBox
        lbBom2.Items.Clear()
        If filteredItems.Count > 0 And txtBom2.Text <> "" Then
            For Each item In filteredItems
                lbBom2.Items.Add(item)
            Next
            lbBom2.Visible = True
        Else
            lbBom2.Visible = False
        End If
    End Sub

    'Show recomend code for bom 2
    Private Sub lbBom2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBom2.SelectedIndexChanged
        If lbBom2.SelectedItem IsNot Nothing Then
            txtBom2.Text = lbBom2.SelectedItem.ToString()
            lbBom2.Visible = False
            Dim codeDetail As Array = txtBom2.Text.ToString().Split(" "c)
            resultsBomCompare.Rows.Clear()
            dgvCompareCount.Rows.Clear()
            dgvBom2Code.Rows.Clear()
            With dgvBom2Code.Rows
                .Add("Smd", codeDetail(0))
                .Add("Top", codeDetail(1))
                .Add("Bot", codeDetail(2))
                .Add("PCB", codeDetail(3))
            End With
        End If
    End Sub

    'Search Bom Relate to Compare
    Private Sub txtBomRelate_TextChanged(sender As Object, e As EventArgs) Handles txtBomRelate.TextChanged
        Dim input As String = txtBomRelate.Text
        Dim allItems As List(Of String) = GetBomList()
        ' Lọc kết quả gợi ý
        Dim filteredItems = allItems.Where(Function(item) item.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0).ToList()

        ' Hiển thị kết quả trong ListBox
        lbBomRelate.Items.Clear()
        If filteredItems.Count > 0 And txtBomRelate.Text <> "" Then
            For Each item In filteredItems
                lbBomRelate.Items.Add(item)
            Next
            lbBomRelate.Visible = True
        Else
            lbBomRelate.Visible = False
        End If
    End Sub

    'Show recomend code for bom 2
    Private Sub lbBomRelate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBomRelate.SelectedIndexChanged
        If lbBomRelate.SelectedItem IsNot Nothing Then
            txtBomRelate.Text = lbBomRelate.SelectedItem.ToString()
            lbBomRelate.Visible = False
        End If
    End Sub

    ' Xử lý sự kiện DrawItem của TabControl
    Private Sub tabControl_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tabControl.DrawItem
        Dim tabControl As TabControl = CType(sender, TabControl)

        ' Kiểm tra nếu tab hiện tại là tab được chọn
        Dim isSelectedTab As Boolean = (e.Index = tabControl.SelectedIndex)

        ' Vẽ màu nền
        If isSelectedTab Then
            ' Tab đang được chọn - tô màu khác biệt
            e.Graphics.FillRectangle(New SolidBrush(Color.LightGreen), e.Bounds)
        Else
            ' Tab không được chọn - giữ nguyên màu nền mặc định
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.Control), e.Bounds)
        End If

        ' Lấy icon tương ứng
        Dim icon As Image = Nothing
        Select Case e.Index
            Case 0
                icon = My.Resources.iconplan ' Tab plan
            Case 1
                icon = My.Resources.iconcheck ' Tab program check
            Case 2
                icon = My.Resources.iconmaintenance ' Tab maintenance
            Case 3
                icon = My.Resources.iconcompare ' Tab compare bom
            Case 4
                icon = My.Resources.icondata ' Tab compare bom
            Case 5
                icon = My.Resources.iconconfig ' Tab config
        End Select

        ' Vẽ icon (nếu có)
        If icon IsNot Nothing Then
            Dim iconRect As New Rectangle(e.Bounds.X + 5, e.Bounds.Y + (e.Bounds.Height - 23) \ 2, 23, 23)
            e.Graphics.DrawImage(icon, iconRect)
        End If

        ' Vẽ text của ta
        Dim tabText As String = tabControl.TabPages(e.Index).Text
        Dim textBrush As Brush = If(e.Index = tabControl.SelectedIndex, Brushes.Black, Brushes.Black)
        Dim font As New Font(tabControl.Font.OriginalFontName, tabControl.Font.Size + 1, FontStyle.Regular)
        Dim stringFormat As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center
        }
        ' Tính toán vùng vẽ text để tránh trùng icon
        Dim textRect As Rectangle = e.Bounds
        textRect.X += 29 ' Dời text qua phải để không đè lên icon
        e.Graphics.DrawString(tabText, font, textBrush, textRect, stringFormat)
    End Sub
    'Tab control check program
    Private Sub tabControlPgCheck_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tabControlPgCheck.DrawItem
        Dim tabControl As TabControl = CType(sender, TabControl)

        ' Kiểm tra nếu tab hiện tại là tab được chọn
        Dim isSelectedTab As Boolean = (e.Index = tabControl.SelectedIndex)

        ' Vẽ màu nền
        If isSelectedTab Then
            ' Tab đang được chọn - tô màu khác biệt
            e.Graphics.FillRectangle(New SolidBrush(Color.LightBlue), e.Bounds)
        Else
            ' Tab không được chọn - giữ nguyên màu nền mặc định
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.Control), e.Bounds)
        End If

        ' Lấy icon tương ứng
        Dim icon As Image = Nothing
        Select Case e.Index
            Case 0
                icon = My.Resources.iconaoi ' Tab aoi
            Case 1
                icon = My.Resources.iconmounter ' Tab mounter
            Case 2
                icon = My.Resources.iconprinter ' Tab printer
        End Select

        ' Vẽ icon (nếu có)
        If icon IsNot Nothing Then
            Dim iconRect As New Rectangle(e.Bounds.X + 5, e.Bounds.Y + (e.Bounds.Height - 20) \ 2, 20, 20)
            e.Graphics.DrawImage(icon, iconRect)
        End If

        ' Vẽ text của tab

        Dim tabText As String = tabControl.TabPages(e.Index).Text
        Dim textBrush As Brush = If(e.Index = tabControl.SelectedIndex, Brushes.Black, Brushes.Black)
        Dim stringFormat As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center
        }
        ' Tính toán vùng vẽ text để tránh trùng icon
        Dim textRect As Rectangle = e.Bounds
        textRect.X += 25 ' Dời text qua phải để không đè lên icon
        e.Graphics.DrawString(tabText, tabControl.Font, textBrush, textRect, stringFormat)
    End Sub

    Private Sub tabControlBomCompare_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tabControlBomCompare.DrawItem
        Dim tabControl As TabControl = CType(sender, TabControl)

        ' Kiểm tra nếu tab hiện tại là tab được chọn
        Dim isSelectedTab As Boolean = (e.Index = tabControl.SelectedIndex)

        ' Vẽ màu nền
        If isSelectedTab Then
            ' Tab đang được chọn - tô màu khác biệt
            e.Graphics.FillRectangle(New SolidBrush(Color.LightBlue), e.Bounds)
        Else
            ' Tab không được chọn - giữ nguyên màu nền mặc định
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.Control), e.Bounds)
        End If

        ' Lấy icon tương ứng
        Dim icon As Image = Nothing
        Select Case e.Index
            Case 0
                icon = My.Resources.imgcompare ' Tab bom compare
            Case 1
                icon = My.Resources.iconbomrelate ' Tab bom relate
            Case 2
                icon = My.Resources.iconbomfilter ' Tab bom filter
        End Select

        ' Vẽ icon (nếu có)
        If icon IsNot Nothing Then
            Dim iconRect As New Rectangle(e.Bounds.X + 5, e.Bounds.Y + (e.Bounds.Height - 20) \ 2, 20, 20)
            e.Graphics.DrawImage(icon, iconRect)
        End If

        ' Vẽ text của tab

        Dim tabText As String = tabControl.TabPages(e.Index).Text
        Dim textBrush As Brush = If(e.Index = tabControl.SelectedIndex, Brushes.Black, Brushes.Black)
        Dim stringFormat As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center
        }
        ' Tính toán vùng vẽ text để tránh trùng icon
        Dim textRect As Rectangle = e.Bounds
        textRect.X += 25 ' Dời text qua phải để không đè lên icon
        e.Graphics.DrawString(tabText, tabControl.Font, textBrush, textRect, stringFormat)
    End Sub

    Private Sub tabControlData_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tabControlData.DrawItem
        Dim tabControl As TabControl = CType(sender, TabControl)

        ' Kiểm tra nếu tab hiện tại là tab được chọn
        Dim isSelectedTab As Boolean = (e.Index = tabControl.SelectedIndex)

        ' Vẽ màu nền
        If isSelectedTab Then
            ' Tab đang được chọn - tô màu khác biệt
            e.Graphics.FillRectangle(New SolidBrush(Color.LightBlue), e.Bounds)
        Else
            ' Tab không được chọn - giữ nguyên màu nền mặc định
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.Control), e.Bounds)
        End If

        ' Lấy icon tương ứng
        Dim icon As Image = Nothing
        Select Case e.Index
            Case 0
                icon = My.Resources.icontotaldata ' Tab total data
            Case 1
                icon = My.Resources.iconcad ' Tab cad
            Case 2
                icon = My.Resources.iconbom ' Tab bom
            Case 3
                icon = My.Resources.iconmaterial ' Tab material
            Case 4
                icon = My.Resources.iconecn ' Tab ecn
        End Select

        ' Vẽ icon (nếu có)
        If icon IsNot Nothing Then
            Dim iconRect As New Rectangle(e.Bounds.X + 5, e.Bounds.Y + (e.Bounds.Height - 20) \ 2, 20, 20)
            e.Graphics.DrawImage(icon, iconRect)
        End If

        ' Vẽ text của tab

        Dim tabText As String = tabControl.TabPages(e.Index).Text
        Dim textBrush As Brush = If(e.Index = tabControl.SelectedIndex, Brushes.Black, Brushes.Black)
        Dim stringFormat As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center
        }
        ' Tính toán vùng vẽ text để tránh trùng icon
        Dim textRect As Rectangle = e.Bounds
        textRect.X += 25 ' Dời text qua phải để không đè lên icon
        e.Graphics.DrawString(tabText, tabControl.Font, textBrush, textRect, stringFormat)
    End Sub

    Private Sub tabControlMaintenance_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tabControlMaintenance.DrawItem
        Dim tabControl As TabControl = CType(sender, TabControl)

        ' Kiểm tra nếu tab hiện tại là tab được chọn
        Dim isSelectedTab As Boolean = (e.Index = tabControl.SelectedIndex)

        ' Vẽ màu nền
        If isSelectedTab Then
            ' Tab đang được chọn - tô màu khác biệt
            e.Graphics.FillRectangle(New SolidBrush(Color.LightBlue), e.Bounds)
        Else
            ' Tab không được chọn - giữ nguyên màu nền mặc định
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.Control), e.Bounds)
        End If

        ' Lấy icon tương ứng
        Dim icon As Image = Nothing
        Select Case e.Index
            Case 0
                icon = My.Resources.imgreport ' Tab daily report
            Case 1
                icon = My.Resources.iconpm ' Tab pm plan
            Case 2
                icon = My.Resources.iconsparepart ' Tab spart part
            Case 3
                icon = My.Resources.iconimprovement ' Tab improvement
        End Select

        ' Vẽ icon (nếu có)
        If icon IsNot Nothing Then
            Dim iconRect As New Rectangle(e.Bounds.X + 5, e.Bounds.Y + (e.Bounds.Height - 20) \ 2, 20, 20)
            e.Graphics.DrawImage(icon, iconRect)
        End If

        ' Vẽ text của tab

        Dim tabText As String = tabControl.TabPages(e.Index).Text
        Dim textBrush As Brush = If(e.Index = tabControl.SelectedIndex, Brushes.Black, Brushes.Black)
        Dim stringFormat As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center
        }
        ' Tính toán vùng vẽ text để tránh trùng icon
        Dim textRect As Rectangle = e.Bounds
        textRect.X += 25 ' Dời text qua phải để không đè lên icon
        e.Graphics.DrawString(tabText, tabControl.Font, textBrush, textRect, stringFormat)
    End Sub

    Private Sub dgvListBomFilter_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListBomFilter.CellContentDoubleClick
        If e.ColumnIndex = 5 Then 'Kiểm tra có bấm vào cột button không
            Dim fileName As String = ""
            Dim filePath As String = ""
            With dgvListBomFilter.Rows(e.RowIndex)
                fileName = String.Join(" ", .Cells(0).Value.ToString(), .Cells(1).Value.ToString(), .Cells(2).Value.ToString(), .Cells(3).Value.ToString())
                filePath = Path.Combine(filePathFilterSave & "\" & .Cells(3).Value.ToString(), fileName.ToString() & ".xlsx")
            End With
            If File.Exists(filePath) Then
                ' Mở file nếu tồn tại
                Process.Start(filePath)
            Else
                ' Thông báo nếu file không tồn tại
                MessageBox.Show("Không tìm thấy file: " & filePath)
            End If
        End If
    End Sub

    Private Sub btnBomDelete_Click(sender As Object, e As EventArgs) Handles btnBomDelete.Click
        Dim confirm As DialogResult
        If tvBomList.SelectedNode.Text = "" Then
            Return
        End If

        confirm = MessageBox.Show($"Bạn có muốn xóa Bom {tvBomList.SelectedNode.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.Yes Then
            DeleteBomData(tvBomList.SelectedNode.Text)
        End If
    End Sub

    Private Sub btnCadDelete_Click(sender As Object, e As EventArgs) Handles btnCadDelete.Click
        Dim confirm As DialogResult
        If lbCadList.SelectedItem = "" Then
            Return
        End If

        confirm = MessageBox.Show($"Bạn có muốn xóa Cad {lbCadList.SelectedItem} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.Yes Then
            DeleteCadData(lbCadList.SelectedItem)
        End If
    End Sub

    Private Sub btnLineCountUpdate_Click(sender As Object, e As EventArgs) Handles btnLineCountUpdate.Click
        Dim lineCount As Integer
        If Integer.TryParse(txtLineCount.Text, lineCount) Then
            UpdateLineCount(lineCount)
            CreateProgramCheckLineColumn(lineCount, "checkaoi")
            CreateProgramCheckLineColumn(lineCount, "checkmounter")
            CreateProgramCheckLineColumn(lineCount, "checkprinter")
            LoadProgramCheck("checkaoi")
            LoadProgramCheck("checkmounter")
            LoadPrinterPcbCheck("checkprinter")
        Else
            MessageBox.Show("Giá trị nhập không phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
    End Sub

    'Update db program check if cell value change
    Private Sub dgvCheckAoi_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckAoi.RowValidated
        If resutlsCheckAoi IsNot Nothing Then
            UpdateProgramCheckDb(resutlsCheckAoi, "checkaoi") ' Gọi hàm cập nhật cơ sở dữ liệu
        End If
    End Sub

    Private Sub dgvCheckAoi_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCheckAoi.KeyDown
        ' Kiểm tra nếu phím Delete được nhấn
        If e.KeyCode = Keys.Delete Then
            ' Kiểm tra nếu có ô được chọn
            If dgvCheckAoi.SelectedCells.Count > 0 Then
                ' Xóa giá trị trong từng ô được chọn
                For Each cell As DataGridViewCell In dgvCheckAoi.SelectedCells
                    If Not cell.ReadOnly Then
                        cell.Value = DBNull.Value ' Hoặc cell.Value = "" để xóa
                    End If
                Next
            End If
            e.Handled = True ' Ngăn chặn hành động mặc định
        End If
        UpdateProgramCheckDb(resutlsCheckAoi, "checkaoi")
    End Sub

    Private Sub dgvCheckMounter_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckMounter.RowValidated
        If resutlsCheckMounter IsNot Nothing Then
            UpdateProgramCheckDb(resutlsCheckMounter, "checkmounter") ' Gọi hàm cập nhật cơ sở dữ liệu
        End If
    End Sub

    Private Sub dgvCheckMounter_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCheckMounter.KeyDown
        ' Kiểm tra nếu phím Delete được nhấn
        If e.KeyCode = Keys.Delete Then
            ' Kiểm tra nếu có ô được chọn
            If dgvCheckMounter.SelectedCells.Count > 0 Then
                ' Xóa giá trị trong từng ô được chọn
                For Each cell As DataGridViewCell In dgvCheckMounter.SelectedCells
                    If Not cell.ReadOnly Then
                        cell.Value = DBNull.Value ' Hoặc cell.Value = "" để xóa
                    End If
                Next
            End If
            e.Handled = True ' Ngăn chặn hành động mặc định
        End If
        UpdateProgramCheckDb(resutlsCheckMounter, "checkmounter")
    End Sub

    Private Sub dgvCheckPrinter_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckPrinter.RowValidated
        If resutlsCheckPrinter IsNot Nothing Then
            UpdateProgramCheckDb(resutlsCheckPrinter, "checkprinter") ' Gọi hàm cập nhật cơ sở dữ liệu
        End If
    End Sub

    Private Sub dgvCheckPrinter_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCheckPrinter.KeyDown
        ' Kiểm tra nếu phím Delete được nhấn
        If e.KeyCode = Keys.Delete Then
            ' Kiểm tra nếu có ô được chọn
            If dgvCheckPrinter.SelectedCells.Count > 0 Then
                ' Xóa giá trị trong từng ô được chọn
                For Each cell As DataGridViewCell In dgvCheckPrinter.SelectedCells
                    If Not cell.ReadOnly Then
                        cell.Value = DBNull.Value ' Hoặc cell.Value = "" để xóa
                    End If
                Next
            End If
            e.Handled = True ' Ngăn chặn hành động mặc định
        End If
        UpdateProgramCheckDb(resutlsCheckPrinter, "checkprinter")
    End Sub



    Private Sub btnRefreshProgramCheckTable_Click(sender As Object, e As EventArgs) Handles btnRefreshProgramCheckTable.Click
        txtSearchCheckAoi.Text = ""
        txtSearchCheckMounter.Text = ""
        txtSearchCheckPrinter.Text = ""
        LoadProgramCheck("checkaoi")
        LoadProgramCheck("checkmounter")
        LoadPrinterPcbCheck("checkprinter")
    End Sub



    'Update db config to database mysqlite
    Private Sub dgvDbConfig_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDbConfig.CellContentClick
        If e.ColumnIndex = 5 Then 'Kiểm tra có bấm vào cột button không
            With dgvDbConfig.Rows(e.RowIndex)
                UpdateConfigDb(.Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value, .Cells(4).Value)
            End With
            GetConnectString()
        End If
    End Sub


    'Show password ***
    Private Sub dgvDbConfig_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDbConfig.CellFormatting
        ' Kiểm tra nếu cột hiện tại là cột "Password"
        If dgvDbConfig.Columns(e.ColumnIndex).Name = "PassDb" AndAlso e.Value IsNot Nothing Then
            ' Thay thế nội dung bằng dấu "*"
            e.Value = New String("*"c, e.Value.ToString().Length)
        End If
    End Sub

    Private Sub btnRefreshConfigTable_Click(sender As Object, e As EventArgs) Handles btnRefreshConfigTable.Click
        With dgvDbConfig
            .Rows.Clear()
            For Each db In LoadConfigDb()
                .Rows.Add(db.key, db.ip, db.dataTable, db.username, db.pass)
            Next
        End With
        GetConnectString()
        CheckConnectDb()
    End Sub

    Private Sub btnExpandAllBomTree_Click(sender As Object, e As EventArgs) Handles btnExpandAllBomTree.Click
        tvBomList.ExpandAll()
    End Sub

    Private Sub btnCollapseAllBomTree_Click(sender As Object, e As EventArgs) Handles btnCollapseAllBomTree.Click
        tvBomList.CollapseAll()
    End Sub

    Private Sub btnImportPlan_Click(sender As Object, e As EventArgs) Handles btnImportPlan.Click
        Dim filePath As String
        Dim planDate As String

        filePath = OpenFileSelect()

        If filePath = "" Or filePath = Nothing Then
            Exit Sub
        End If

        Dim planImport As New List(Of (line As String, shift As String, tt As String, capa As String,
                                     startTime As String, finishTime As String,
                                     workTime As String, modelChange As String,
                                     smtCode As String, assyCode As String, pcbCode As String,
                                     boardArray As String, lotQty As String, boardSide As String))
        Dim planData As New List(Of (line As String, shift As String, tt As String, capa As String,
                                     startTime As String, finishTime As String,
                                     workTime As String, modelChange As String,
                                     smtCode As String, assyCode As String, pcbCode As String,
                                     boardArray As String, lotQty As String, boardSide As String, notePlan As String))

        planDate = dtpPlanDate.Value.ToString("dd-MM-yy")
        planImport = GetPlanData(filePath, planDate)
        If planImport IsNot Nothing And planImport.Count > 0 Then
            ImportPlanToDataBase(planDate, planImport)
            planData = GetPlanDateData(planDate)
            SetPlanDataGridView(planData)
            ApplyFilterPlanView()
        End If
    End Sub

    Private Sub dtpPlanDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpPlanDate.ValueChanged
        Dim planData As New List(Of (line As String, shift As String, tt As String, capa As String,
                                    startTime As String, finishTime As String,
                                    workTime As String, modelChange As String,
                                    smtCode As String, assyCode As String, pcbCode As String,
                                    boardArray As String, lotQty As String, boardSide As String, notePlan As String))

        Dim planDate As String
        LoadProgramCheck("checkaoi")
        LoadProgramCheck("checkmounter")
        LoadPrinterPcbCheck("checkprinter")
        planDate = dtpPlanDate.Value.ToString("dd-MM-yy")
        planData = GetPlanDateData(planDate)
        SetPlanDataGridView(planData)
        ApplyFilterPlanView()
    End Sub

    Private Sub btnExportPlan_Click(sender As Object, e As EventArgs) Handles btnExportPlan.Click
        Dim planDate As String

        If resutlsPlanTable Is Nothing OrElse resutlsPlanTable.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        planDate = dtpPlanDate.Value.ToString("dd-MM-yy")
        ExportPlanToExcel(planDate, dgvPlan)
    End Sub

    Private Sub btnPlanRefresh_Click(sender As Object, e As EventArgs) Handles btnPlanRefresh.Click
        Dim planData As New List(Of (line As String, shift As String, tt As String, capa As String,
                                    startTime As String, finishTime As String,
                                    workTime As String, modelChange As String,
                                    smtCode As String, assyCode As String, pcbCode As String,
                                    boardArray As String, lotQty As String, boardSide As String, notePlan As String))
        Dim planDate As String
        LoadProgramCheck("checkaoi")
        LoadProgramCheck("checkmounter")
        LoadPrinterPcbCheck("checkprinter")
        planDate = dtpPlanDate.Value.ToString("dd-MM-yy")
        planData = GetPlanDateData(planDate)
        SetPlanDataGridView(planData)
        txtPlanCodeFilter.Text = ""
        cbPlanLineFilter.Text = "All"
        cbPlanShiftFilter.Text = "All"
        ApplyFilterPlanView()
    End Sub

    Private Sub dgvPlan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlan.CellEndEdit
        If e.ColumnIndex = dgvPlan.Columns("note").Index Then ' Chỉ xử lý cột "note"
            Dim planDate = dtpPlanDate.Value.ToString("dd-MM-yy")
            Dim line As String = dgvPlan.Rows(e.RowIndex).Cells("Line").Value.ToString()
            Dim assy As String = dgvPlan.Rows(e.RowIndex).Cells("Assy").Value.ToString()
            Dim side As String = dgvPlan.Rows(e.RowIndex).Cells("Side").Value.ToString()
            Dim lotQty As String = dgvPlan.Rows(e.RowIndex).Cells("Qty").Value.ToString()
            Dim note As String = dgvPlan.Rows(e.RowIndex).Cells("Note").Value.ToString()

            UpdatePlanNote(planDate, note, line, assy, side, lotQty)
        End If
    End Sub

    Private Sub dgvPlan_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPlan.KeyDown
        ' Kiểm tra nếu phím Delete được nhấn
        If e.KeyCode = Keys.Delete Then
            Dim planDate = dtpPlanDate.Value.ToString("dd-MM-yy")
            If dgvPlan.SelectedCells.Count > 0 Then
                ' Xóa giá trị trong từng ô được chọn
                For Each cell As DataGridViewCell In dgvPlan.SelectedCells
                    If Not cell.ReadOnly Then
                        cell.Value = DBNull.Value ' Hoặc cell.Value = "" để xóa
                        If cell.OwningColumn.Name = "Note" Then
                            Dim line As String = dgvPlan.Rows(cell.RowIndex).Cells("Line").Value.ToString()
                            Dim assy As String = dgvPlan.Rows(cell.RowIndex).Cells("Assy").Value.ToString()
                            Dim side As String = dgvPlan.Rows(cell.RowIndex).Cells("Side").Value.ToString()
                            Dim lotQty As String = dgvPlan.Rows(cell.RowIndex).Cells("Qty").Value.ToString()
                            Dim note As String = dgvPlan.Rows(cell.RowIndex).Cells("Note").Value.ToString()
                            UpdatePlanNote(planDate, note, line, assy, side, lotQty)
                        End If
                    End If
                Next
            End If
            e.Handled = True ' Ngăn chặn hành động mặc định
        End If
    End Sub

    Private Sub btnViewLocation_Click(sender As Object, e As EventArgs) Handles btnViewLocation.Click
        If tvBomList.SelectedNode IsNot Nothing AndAlso tvBomList.SelectedNode.Parent IsNot Nothing Then
            frmPcbLocation.Show()
        End If
    End Sub

    Private Sub cbBomVersion1_CheckedChanged(sender As Object, e As EventArgs) Handles cbBomVersion1.CheckedChanged
        If cbBomVersion1.Checked Then
            cbBomVersion1.Text = "Old Bom"
            cbBomVersion1.BackColor = Color.OrangeRed
        Else
            cbBomVersion1.Text = "Current Bom"
            cbBomVersion1.BackColor = Color.Transparent
        End If
        txtBom1.Text = ""
    End Sub

    Private Sub cbBomVersion2_CheckedChanged(sender As Object, e As EventArgs) Handles cbBomVersion2.CheckedChanged
        If cbBomVersion2.Checked Then
            cbBomVersion2.Text = "Old Bom"
            cbBomVersion2.BackColor = Color.OrangeRed
        Else
            cbBomVersion2.Text = "Current Bom"
            cbBomVersion2.BackColor = Color.Transparent
        End If
        txtBom2.Text = ""
    End Sub

    Private Sub btnMaterialDataRefresh_Click(sender As Object, e As EventArgs) Handles btnMaterialDataRefresh.Click
        LoadMaterialData()
    End Sub

    Private Sub dgvMaterialData_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaterialData.CellEndEdit
        Dim columnsToCheckDbNull = {"description", "sizedefault"}
        For Each colName As String In columnsToCheckDbNull
            If IsDBNull(dgvMaterialData.Rows(e.RowIndex).Cells(colName).Value) Then
                dgvMaterialData.Rows(e.RowIndex).Cells(colName).Value = ""
            End If
        Next

        If e.ColumnIndex <> dgvMaterialData.Columns("code").Index And e.ColumnIndex <> dgvMaterialData.Columns("id").Index Then ' Chỉ xử lý cột "note"
            Dim code As String = dgvMaterialData.Rows(e.RowIndex).Cells("code").Value.ToString()
            Dim description As String = dgvMaterialData.Rows(e.RowIndex).Cells("description").Value.ToString()
            Dim sizex As String = dgvMaterialData.Rows(e.RowIndex).Cells("sizex").Value
            Dim sizey As String = dgvMaterialData.Rows(e.RowIndex).Cells("sizey").Value
            Dim thickness As String = dgvMaterialData.Rows(e.RowIndex).Cells("thickness").Value
            Dim sizedefault As String = dgvMaterialData.Rows(e.RowIndex).Cells("sizedefault").Value.ToString()
            UpdateMaterialData(code, description, sizex, sizey, thickness, sizedefault)
        End If
    End Sub

    Private Sub dgvMaterialData_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMaterialData.CellValidating
        Dim columnsToCheckNumeric = {"sizex", "sizey", "thickness"}
        If columnsToCheckNumeric.Contains(dgvMaterialData.Columns(e.ColumnIndex).Name) Then
            ' Kiểm tra giá trị nhập vào có phải là số không
            If Not IsNumeric(e.FormattedValue) Then
                MessageBox.Show("Nhấp giá trị số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Hủy bỏ thay đổi và giữ lại giá trị cũ
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnRefreshDataTotal_Click(sender As Object, e As EventArgs) Handles btnRefreshDataTotal.Click
        Dim totalData As New List(Of (assy As String, top As String, bot As String, pcb As String,
                                 topcount As String, botcount As String, lastupdate As String, ecn As String))
        totalData = GetAllBomData()

        For Each row In totalData
            With row
                resutlsDataTotal.Rows.Add(.assy, .top, .bot, .pcb, .topcount, .botcount, .lastupdate, .ecn)
            End With
        Next
        dgvDataTotal.DataSource = resutlsDataTotalView
    End Sub

    Private Sub btnImportEcn_Click(sender As Object, e As EventArgs) Handles btnImportEcn.Click
        frmImportEcn.loadEcnCode = ""
        frmImportEcn.ShowDialog()
    End Sub

    Private Sub btnRefreshEcnData_Click(sender As Object, e As EventArgs) Handles btnRefreshEcnData.Click
        LoadEcnData()
    End Sub

    Private Sub dgvEcnData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEcnData.CellContentClick
        If e.ColumnIndex = 4 Then 'Kiểm tra có bấm vào cột button không
            Dim ecnCode As String = ""
            ecnCode = dgvEcnData.Rows(e.RowIndex).Cells(0).Value.ToString()
            frmImportEcn.loadEcnCode = ecnCode
            frmImportEcn.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then 'Kiểm tra có bấm vào cột button không
            Dim ecnCode As String = ""
            ecnCode = dgvEcnData.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim deleteConfirm As DialogResult
            deleteConfirm = MessageBox.Show($"Bạn có muốn xóa dữ liệu Ecn {ecnCode}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If deleteConfirm = DialogResult.Yes Then
                DeleteEcnData(ecnCode)
                LoadEcnData()
            End If
        End If
    End Sub

    Private Sub txtSearchEcn_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEcn.TextChanged
        ApplyFilterEcnData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmDailyReport.Show()
    End Sub
    Private Sub dgvPlan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlan.CellContentClick
        If dgvPlan.Columns(e.ColumnIndex).Name = "ReportButton" Then
            If dgvPlan.Rows(e.RowIndex).Cells("line").Value <> "" Then
                With frmDailyReport
                    .lotLine = dgvPlan.Rows(e.RowIndex).Cells("line").Value
                    .lotAssy = dgvPlan.Rows(e.RowIndex).Cells("assy").Value
                    .lotSmt = dgvPlan.Rows(e.RowIndex).Cells("smt").Value
                    .lotQty = dgvPlan.Rows(e.RowIndex).Cells("qty").Value
                    .lotSide = dgvPlan.Rows(e.RowIndex).Cells("side").Value
                    .lotShift = dgvPlan.Rows(e.RowIndex).Cells("shift").Value
                    .lotDate = dtpPlanDate.Value.Date
                    .idReport = 0
                    .Show()
                End With
            End If
        End If
    End Sub

    Private Sub dgvPlan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlan.CellContentDoubleClick
        If dgvPlan.Columns(e.ColumnIndex).Name = "ECN" Then 'Kiểm tra có bấm vào cột button không
            Dim ecnCode As String = ""
            ecnCode = dgvPlan.Rows(e.RowIndex).Cells("ECN").Value.ToString()
            If InStr(1, ecnCode.ToLower, "bnv") > 0 Then
                frmImportEcn.loadEcnCode = ecnCode
                frmImportEcn.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnRefreshDailyReport_Click(sender As Object, e As EventArgs) Handles btnRefreshDailyReport.Click
        LoadAllReportData()
        dtpReportEndDay.Value = Today.Date
        dtpReportStartDay.Value = Today.Date.AddDays(-14)
        txtSearchReport.Text = ""
        cbReportLine.Text = "All"
        cbReportMachine.Text = "All"
        ApplyFilterDailyReport()
    End Sub

    Private Sub dgvDailyReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDailyReport.CellContentClick
        If dgvDailyReport.Columns(e.ColumnIndex).Name = "ViewButton" Then 'Kiểm tra có bấm vào cột button không
            Dim reportNum As String = ""
            reportNum = dgvDailyReport.Rows(e.RowIndex).Cells(0).Value
            frmDailyReport.idReport = reportNum
            frmDailyReport.Show()
        End If

        If dgvDailyReport.Columns(e.ColumnIndex).Name = "DelButton" Then 'Kiểm tra có bấm vào cột button không
            Dim ecnCode As String = ""
            Dim reportNum = dgvDailyReport.Rows(e.RowIndex).Cells(0).Value
            Dim deleteConfirm As DialogResult
            deleteConfirm = MessageBox.Show($"Bạn có muốn xóa báo cáo số {reportNum}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If deleteConfirm = DialogResult.Yes Then
                DeleteDailyReportData(reportNum)
                LoadAllReportData()
            End If
        End If
    End Sub

    Private Sub btnCreateReport_Click(sender As Object, e As EventArgs) Handles btnCreateReport.Click
        With frmDailyReport
            .lotLine = ""
            .lotAssy = ""
            .lotSmt = ""
            .lotQty = ""
            .lotSide = ""
            .lotShift = ""
            .lotDate = Today.Date
            .idReport = 0
            .Show()
        End With
    End Sub

    Private Sub btnAddPmPlan_Click(sender As Object, e As EventArgs) Handles btnAddPmPlan.Click
        frmPmReport.dtpPmDateSelect.Value = Today.Date
        LoadPmPlanData(frmPmReport.dtpPmDateSelect.Value.Date)
        frmPmReport.Show()
    End Sub

    Private Sub btnRefreshPmList_Click(sender As Object, e As EventArgs) Handles btnRefreshPmList.Click
        LoadPmPlanList()
    End Sub

    Private Sub dgvPmPlan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPmPlan.CellContentClick
        If dgvPmPlan.Columns(e.ColumnIndex).Name = "ViewButton" Then 'Kiểm tra có bấm vào cột button không
            frmPmReport.dtpPmDateSelect.Value = dgvPmPlan.Rows(e.RowIndex).Cells(0).Value
            LoadPmPlanData(frmPmReport.dtpPmDateSelect.Value.Date)
            frmPmReport.Show()
        End If

        If dgvPmPlan.Columns(e.ColumnIndex).Name = "DelButton" Then 'Kiểm tra có bấm vào cột button không
            Dim pmDay As Date = dgvPmPlan.Rows(e.RowIndex).Cells(0).Value
            Dim deleteConfirm As DialogResult
            deleteConfirm = MessageBox.Show($"Bạn có muốn xóa báo cáo số {pmDay}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If deleteConfirm = DialogResult.Yes Then
                DeletePmPlanData(pmDay)
                LoadPmPlanList()
            End If
        End If
    End Sub

    Private Sub btnExportDailyReport_Click(sender As Object, e As EventArgs) Handles btnExportDailyReport.Click
        ExportDailyReportToExcel()
    End Sub
End Class
