Imports DocumentFormat.OpenXml.Wordprocessing

Public Class frmDailyReport
    Public idReport As Integer
    Public lotLine As String
    Public lotAssy As String
    Public lotSmt As String
    Public lotQty As String
    Public lotSide As String
    Public lotShift As String
    Public lotLosstime As Integer
    Public lotDate As DateTime
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add item to line select
        cbLineSelect.Items.Clear()
        For i = 1 To 20
            cbLineSelect.Items.Add(i)
        Next

        'Add item to machine select
        With cbMachineSelect
            .Items.Clear()
            Dim listMachine As String() = {"Printer", "Reflow", "PAOI", "MAOI", "SAOI",
                                   "Mounter#1", "Mounter#2", "Mounter#3", "Mounter#4",
                                   "Mounter#5", "Mounter#6", "Mounter#7", "WorkTable",
                                   "InLoader", "Unloader", "VaccumLoader", "Feeder"}
            .Items.AddRange(listMachine)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim autoCompleteMachine As New AutoCompleteStringCollection()
            autoCompleteMachine.AddRange(listMachine)
            .AutoCompleteCustomSource = autoCompleteMachine
        End With
        'Add item to machine select
        With cbTypeReport
            .Items.Clear()
            Dim listType As String() = {"Stop line", "Improve"}
            .Items.AddRange(listType)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim autoCompleteType As New AutoCompleteStringCollection()
            autoCompleteType.AddRange(listType)
            .AutoCompleteCustomSource = autoCompleteType
            .Text = "Stop line"
        End With

        'Add item to machine select
        With cbReportStatus
            .Items.Clear()
            Dim listStatus As String() = {"Pending", "Done"}
            .Items.AddRange(listStatus)
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim autoCompleteStatus As New AutoCompleteStringCollection()
            autoCompleteStatus.AddRange(listStatus)
            .AutoCompleteCustomSource = autoCompleteStatus
            .Text = "Pending"
        End With

        'Add row image for dgv
        dgvTroubleImage.Rows.Clear()
        dgvActionImage.Rows.Clear()
        For i = 1 To 6
            dgvTroubleImage.Rows.Add()
            dgvActionImage.Rows.Add()
        Next
        For i = 0 To 5
            dgvTroubleImage.Rows(i).Height = 75
            dgvActionImage.Rows(i).Height = 75
        Next

        pbTroubleImageShow.Image = Nothing
        pbActionImageShow.Image = Nothing

        'Load lot info
        If idReport = 0 Then
            cbLineSelect.Text = lotLine
            cbMachineSelect.Text = ""
            txtPlanLot.Text = $"#{lotLine}_{lotAssy}_{lotSmt}_{lotSide.ToUpper}_{lotQty}(EA)_{lotDate.Date.ToString("yyMMdd")}_{lotShift}"
            dtpEndDay.Value = lotDate
            dtpStartDay.Value = lotDate
            dtpStartTime.Value = Now
            dtpEndTime.Value = Now
            txtTroubleNote.Text = ""
            txtActionNote.Text = ""
        ElseIf idReport > 0 Then
            LoadDailyReportId(idReport)
        End If
    End Sub

    Private Sub btnReportInfoRefresh_Click(sender As Object, e As EventArgs) Handles btnReportInfoRefresh.Click
        'Refresh data
        cbLineSelect.Text = ""
        txtPlanLot.Text = ""
        dtpEndDay.Value = Today.Date
        dtpStartDay.Value = Today.Date
        dtpStartTime.Value = Now
        dtpEndTime.Value = Now
        txtActionNote.Text = ""
        txtTroubleNote.Text = ""
        cbLineSelect.SelectedItem = 1
        cbMachineSelect.Text = ""
        cbTypeReport.Text = "Stop line"
        'Add row image for dgv
        dgvTroubleImage.Rows.Clear()
        dgvActionImage.Rows.Clear()
        For i = 1 To 6
            dgvTroubleImage.Rows.Add()
            dgvActionImage.Rows.Add()
        Next
        For i = 0 To 5
            dgvTroubleImage.Rows(i).Height = 75
            dgvActionImage.Rows(i).Height = 75
        Next
        'Set reportId = 0
        idReport = 0
        lbReportNumber.Text = $"Report No. {idReport}"
    End Sub

    'Calculate losstime
    Private Sub dtpStartDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDay.ValueChanged
        LosstimeCalculate()
    End Sub
    Private Sub dtpStartTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartTime.ValueChanged
        LosstimeCalculate()
    End Sub
    Private Sub dtpEndTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndTime.ValueChanged
        LosstimeCalculate()
    End Sub

    Private Sub dtpEndDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDay.ValueChanged
        LosstimeCalculate()
    End Sub

    Function LosstimeCalculate()
        Dim startDateTime As DateTime = dtpStartDay.Value.Date.Add(dtpStartTime.Value.TimeOfDay)
        Dim endDateTime As DateTime = dtpEndDay.Value.Date.Add(dtpEndTime.Value.TimeOfDay)
        Dim isCalculateOk As Boolean = True
        ' Tính khoảng thời gian
        Dim timeDifference As TimeSpan = endDateTime - startDateTime
        Dim lossTime As Integer = timeDifference.Days * 24 * 60 + timeDifference.Hours * 60 + timeDifference.Minutes
        lotLosstime = 1


        txtLosstime.Text = $"{lossTime}"
        lotLosstime = lossTime

        If lossTime < 0 Then
            isCalculateOk = False
        End If
        Return isCalculateOk
    End Function

    Private Sub dgvTroubleImage_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTroubleImage.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Kiểm tra ô hiện tại (CurrentCell) có hợp lệ không
            Dim currentCell = dgvTroubleImage.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 0 AndAlso currentCell.ColumnIndex <= dgvTroubleImage.ColumnCount Then
                ' Kiểm tra xem clipboard có hình ảnh không
                If Clipboard.ContainsImage() Then
                    ' Lấy hình ảnh từ clipboard
                    Dim image As Image = Clipboard.GetImage()

                    ' Gán hình ảnh vào ô hiện tại
                    dgvTroubleImage.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = image
                    pbTroubleImageShow.Image = image
                Else
                    MessageBox.Show("Clipboard không chứa hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

        If e.KeyCode = Keys.Delete Then
            Dim currentCell = dgvTroubleImage.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 0 AndAlso currentCell.ColumnIndex <= dgvTroubleImage.ColumnCount Then
                ' Gán hình ảnh vào ô hiện tại
                dgvTroubleImage.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = Nothing
            End If
        End If
    End Sub

    Private Sub dgvTroubleImage_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTroubleImage.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim currentCell = dgvTroubleImage.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf currentCell.Value Is Image Then
                ' Lấy hình ảnh từ ô
                Dim image As Image = DirectCast(currentCell.Value, Image)

                ' Hiển thị hình ảnh trong PictureBox
                pbTroubleImageShow.Image = image
            Else
                ' Nếu không phải hình ảnh, xóa hình ảnh trong PictureBox
                pbTroubleImageShow.Image = Nothing
            End If
        End If
    End Sub

    Private Sub pbTroubleImageShow_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pbTroubleImageShow.MouseDoubleClick
        ' Kiểm tra nếu PictureBox có hình ảnh
        If pbTroubleImageShow.Image IsNot Nothing Then
            ' Sao chép hình ảnh vào clipboard
            Clipboard.SetImage(pbTroubleImageShow.Image)
            MessageBox.Show("Hình ảnh đã được sao chép vào Clipboard.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Không có hình ảnh trong PictureBox để sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvActionImage_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvActionImage.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Kiểm tra ô hiện tại (CurrentCell) có hợp lệ không
            Dim currentCell = dgvActionImage.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 0 AndAlso currentCell.ColumnIndex <= dgvActionImage.ColumnCount Then
                ' Kiểm tra xem clipboard có hình ảnh không
                If Clipboard.ContainsImage() Then
                    ' Lấy hình ảnh từ clipboard
                    Dim image As Image = Clipboard.GetImage()

                    ' Gán hình ảnh vào ô hiện tại
                    dgvActionImage.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = image
                    pbActionImageShow.Image = image
                Else
                    MessageBox.Show("Clipboard không chứa hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

        If e.KeyCode = Keys.Delete Then
            Dim currentCell = dgvActionImage.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 0 AndAlso currentCell.ColumnIndex <= dgvActionImage.ColumnCount Then
                ' Gán hình ảnh vào ô hiện tại
                dgvActionImage.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = Nothing
            End If
        End If
    End Sub

    Private Sub dgvActionImage_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActionImage.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim currentCell = dgvActionImage.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf currentCell.Value Is Image Then
                ' Lấy hình ảnh từ ô
                Dim image As Image = DirectCast(currentCell.Value, Image)

                ' Hiển thị hình ảnh trong PictureBox
                pbActionImageShow.Image = image
            Else
                ' Nếu không phải hình ảnh, xóa hình ảnh trong PictureBox
                pbActionImageShow.Image = Nothing
            End If
        End If
    End Sub

    Private Sub pbActionImageShow_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pbActionImageShow.MouseDoubleClick
        ' Kiểm tra nếu PictureBox có hình ảnh
        If pbActionImageShow.Image IsNot Nothing Then
            ' Sao chép hình ảnh vào clipboard
            Clipboard.SetImage(pbActionImageShow.Image)
            MessageBox.Show("Hình ảnh đã được sao chép vào Clipboard.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Không có hình ảnh trong PictureBox để sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnReportSaveData_Click(sender As Object, e As EventArgs) Handles btnReportSaveData.Click
        Dim isContentFill As Boolean = True

        If String.IsNullOrWhiteSpace(cbMachineSelect.Text) Then
            ' Cấu hình ToolTip
            ttMachineSelect.Show("Chọn máy!", cbMachineSelect, cbMachineSelect.Width / 2, cbMachineSelect.Height, 1000)
            isContentFill = False
        End If

        If String.IsNullOrWhiteSpace(txtPlanLot.Text) Then
            ' Cấu hình ToolTip
            ttLot.Show("Nhập thông tin lot!", txtPlanLot, txtPlanLot.Width / 2, txtPlanLot.Height, 1000)
            isContentFill = False
        End If

        If String.IsNullOrWhiteSpace(txtTroubleNote.Text) Then
            ' Cấu hình ToolTip
            ttNoteTrouble.Show("Nhập thông tin!", txtTroubleNote, txtTroubleNote.Width, 0, 1000)
            isContentFill = False
        End If

        If String.IsNullOrWhiteSpace(txtActionNote.Text) Then
            ' Cấu hình ToolTip
            ttNoteAction.Show("Nhập thông tin!", txtActionNote, txtActionNote.Width, 0, 1000)
            isContentFill = False
        End If

        If LosstimeCalculate() = False Then
            ttLosstime.Show("Kiểm tra lại thời gian Bắt đầu/Kết thúc!", txtLosstime, txtLosstime.Width, 0, 1000)
            isContentFill = False
        End If

        If isContentFill = True Then
            If idReport = 0 Then
                ImportReportData()
            ElseIf idReport > 0 Then
                UpdateReportData()
            End If
            LoadAllReportData()
            ApplyFilterDailyReport()
            lbReportNumber.Text = $"Report No. {idReport}"
        End If
    End Sub

End Class