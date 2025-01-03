Imports System.Globalization

Public Class frmImportEcn
    Public loadEcnCode As String

    Private Sub frmImportEcn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If loadEcnCode = "" Then
            txtEcnCode.Text = ""
            txtEcnApplyWeek.Text = "W"
            txtEcnNote.Text = ""
            txtEcnPcb.Text = ""
            pbEcnShow.Image = Nothing
            dgvEcnImport.Rows.Clear()
            dgvEcnImport.Rows.Add()
            dgvEcnImport.Rows(0).Height = 80
        Else
            dgvEcnImport.Rows.Clear()
            dgvEcnImport.Rows.Add()
            dgvEcnImport.Rows(0).Height = 80
            LoadEcnCodeData(loadEcnCode)
            pbEcnShow.Image = dgvEcnImport.Rows(0).Cells("Image1").Value
        End If

        Me.Location = New Point(frmCompareBom.Location.X, frmCompareBom.Location.Y)
    End Sub

    Private Sub dgvEcnImport_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEcnImport.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Kiểm tra ô hiện tại (CurrentCell) có hợp lệ không
            Dim currentCell = dgvEcnImport.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 0 AndAlso currentCell.ColumnIndex <= dgvEcnImport.ColumnCount Then
                ' Kiểm tra xem clipboard có hình ảnh không
                If Clipboard.ContainsImage() Then
                    ' Lấy hình ảnh từ clipboard
                    Dim image As Image = Clipboard.GetImage()

                    ' Gán hình ảnh vào ô hiện tại
                    dgvEcnImport.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = image
                    pbEcnShow.Image = image
                Else
                    MessageBox.Show("Clipboard không chứa hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

        If e.KeyCode = Keys.Delete Then
            Dim currentCell = dgvEcnImport.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 0 AndAlso currentCell.ColumnIndex <= dgvEcnImport.ColumnCount Then
                ' Gán hình ảnh vào ô hiện tại
                dgvEcnImport.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = Nothing
            End If
        End If
    End Sub

    Private Sub dgvEcnImport_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvEcnImport.RowsAdded
        If dgvEcnImport.RowCount > 1 Then
            dgvEcnImport.AllowUserToAddRows = False
        End If
    End Sub

    Private Sub dgvEcnImport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEcnImport.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim currentCell = dgvEcnImport.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf currentCell.Value Is Image Then
                ' Lấy hình ảnh từ ô
                Dim image As Image = DirectCast(currentCell.Value, Image)

                ' Hiển thị hình ảnh trong PictureBox
                pbEcnShow.Image = image
            Else
                ' Nếu không phải hình ảnh, xóa hình ảnh trong PictureBox
                pbEcnShow.Image = Nothing
            End If
        End If
    End Sub

    Private Sub pbEcnShow_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pbEcnShow.MouseDoubleClick
        ' Kiểm tra nếu PictureBox có hình ảnh
        If pbEcnShow.Image IsNot Nothing Then
            ' Sao chép hình ảnh vào clipboard
            Clipboard.SetImage(pbEcnShow.Image)
            MessageBox.Show("Hình ảnh đã được sao chép vào Clipboard.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Không có hình ảnh trong PictureBox để sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub btnEcnSaveData_Click(sender As Object, e As EventArgs) Handles btnEcnSaveData.Click
        ImportEcnData()
        LoadEcnData()
    End Sub

    Private Sub btnEcnInfoRefresh_Click(sender As Object, e As EventArgs) Handles btnEcnInfoRefresh.Click
        txtEcnCode.Text = ""
        txtEcnApplyWeek.Text = "W"
        txtEcnNote.Text = ""
        txtEcnPcb.Text = ""
        dtpEcnApplyDay.Value = Today()
        pbEcnShow.Image = Nothing
        dgvEcnImport.Rows.Clear()
        dgvEcnImport.Rows.Add()
        dgvEcnImport.Rows(0).Height = 80
    End Sub

    Private Sub dtpEcnApplyDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpEcnApplyDay.ValueChanged
        ' Lấy ngày được chọn từ DateTimePicker
        Dim selectedDate As DateTime = dtpEcnApplyDay.Value

        ' Tính toán tuần trong năm
        Dim weekNumber As Integer = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(selectedDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday)

        ' Lấy năm (2 chữ số cuối)
        Dim year As String = selectedDate.ToString("yy")

        ' Tạo chuỗi "Wxx-Yxx" với tuần và năm
        Dim weekYear As String = $"W{weekNumber:D2} Y{year}"

        ' Hiển thị kết quả lên một Label hoặc TextBox (Ví dụ: lblWeekYear)
        txtEcnApplyWeek.Text = weekYear
    End Sub
End Class