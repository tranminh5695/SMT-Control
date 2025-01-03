Imports System.Net.WebRequestMethods

Public Class frmPmReport
    Private Sub frmPmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPmPlan.EditMode = DataGridViewEditMode.EditOnEnter
        pbPmImageAfter.Image = Nothing
        pbPmImageBefore.Image = Nothing
    End Sub

    Private Sub dgvPmPlan_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvPmPlan.RowsAdded
        dgvPmPlan.Rows(e.RowIndex).Height = 120
        If e.RowIndex >= 0 And dgvPmPlan.Rows(e.RowIndex).IsNewRow Then
            For i = 0 To dgvPmPlan.ColumnCount - 1
                If dgvPmPlan.Columns(i).Name.Contains("Img") Then
                    dgvPmPlan.Rows(e.RowIndex).Cells(i).Value = Nothing
                End If
            Next
        End If
    End Sub

    Private Sub dgvPmPlan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPmPlan.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso dgvPmPlan.Columns(e.ColumnIndex).Name = "PmLine" Then
            Dim rect = dgvPmPlan.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            cbPmLine.Location = New Point(dgvPmPlan.Location.X + rect.X, dgvPmPlan.Location.Y + rect.Y)
            cbPmLine.Size = rect.Size
            cbPmLine.Height = dgvPmPlan.Rows(e.RowIndex).Height
            cbPmLine.Visible = True
            Dim lineSelect As String()
            If dgvPmPlan.CurrentCell.Value IsNot Nothing Then
                lineSelect = dgvPmPlan.CurrentCell.Value.ToString.Split(vbLf)
                For i As Integer = 0 To cbPmLine.Items.Count - 1
                    For Each line In lineSelect
                        If cbPmLine.Items(i) = line Then
                            cbPmLine.SetItemChecked(i, True)
                            Exit For
                        Else
                            cbPmLine.SetItemChecked(i, False)
                        End If
                    Next
                Next
            Else
                For i As Integer = 0 To cbPmLine.Items.Count - 1
                    cbPmLine.SetItemChecked(i, False)
                Next
            End If
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso dgvPmPlan.Columns(e.ColumnIndex).Name = "PmMachine" Then
            Dim rect = dgvPmPlan.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            cbPmMachine.Location = New Point(dgvPmPlan.Location.X + rect.X, dgvPmPlan.Location.Y + rect.Y)
            cbPmMachine.Size = rect.Size
            cbPmMachine.Height = dgvPmPlan.Rows(e.RowIndex).Height
            cbPmMachine.Visible = True
            Dim machineSelect As String()
            If dgvPmPlan.CurrentCell.Value IsNot Nothing Then
                machineSelect = dgvPmPlan.CurrentCell.Value.ToString.Split(vbLf)
                For i As Integer = 0 To cbPmMachine.Items.Count - 1
                    For Each line In machineSelect
                        If cbPmMachine.Items(i) = line Then
                            cbPmMachine.SetItemChecked(i, True)
                            Exit For
                        Else
                            cbPmMachine.SetItemChecked(i, False)
                        End If
                    Next
                Next
            Else
                For i As Integer = 0 To cbPmMachine.Items.Count - 1
                    cbPmMachine.SetItemChecked(i, False)
                Next
            End If
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso dgvPmPlan.Columns(e.ColumnIndex).Name.Contains("ImgBefore") Then
            Dim currentCell = dgvPmPlan.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf currentCell.Value Is Image Then
                ' Lấy hình ảnh từ ô
                Dim image As Image = DirectCast(currentCell.Value, Image)
                If image.Size.Height > 96 Then
                    ' Hiển thị hình ảnh trong PictureBox
                    pbPmImageBefore.Image = image
                Else
                    pbPmImageBefore.Image = Nothing
                End If
            Else
                ' Nếu không phải hình ảnh, xóa hình ảnh trong PictureBox
                pbPmImageBefore.Image = Nothing
            End If
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso dgvPmPlan.Columns(e.ColumnIndex).Name.Contains("ImgAfter") Then
            Dim currentCell = dgvPmPlan.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If TypeOf currentCell.Value Is Image Then
                ' Lấy hình ảnh từ ô
                Dim image As Image = DirectCast(currentCell.Value, Image)
                If image.Size.Height > 96 Then
                    ' Hiển thị hình ảnh trong PictureBox
                    pbPmImageAfter.Image = image
                Else
                    pbPmImageAfter.Image = Nothing
                End If
            Else
                ' Nếu không phải hình ảnh, xóa hình ảnh trong PictureBox
                pbPmImageAfter.Image = Nothing
            End If
        End If
    End Sub

    Private Sub dgvPmPlan_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvPmPlan.CurrentCellChanged
        cbPmLine.Visible = False
        cbPmMachine.Visible = False
    End Sub

    Private Sub cbPmLine_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles cbPmLine.ItemCheck
        If e.Index = 0 Then
            ' Khi "All" được check, bỏ check các mục khác
            If e.NewValue = CheckState.Checked Then
                For i As Integer = 1 To cbPmLine.Items.Count - 1
                    cbPmLine.SetItemChecked(i, False)
                Next
            End If
        Else
            ' Nếu bất kỳ mục nào khác được chọn, bỏ check "All"
            If e.NewValue = CheckState.Checked Then
                cbPmLine.SetItemChecked(0, False)
            End If
        End If
    End Sub
    Private Sub cbPmLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPmLine.SelectedIndexChanged
        Dim lineList As String = ""
        If cbPmLine.CheckedItems.Count > 0 Then
            For Each item As String In cbPmLine.CheckedItems
                lineList &= $"{item.ToString}{vbLf}"
            Next
        End If
        dgvPmPlan.CurrentCell.Value = lineList.TrimEnd().TrimEnd(vbLf)
    End Sub


    Private Sub cbPmMachine_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles cbPmMachine.ItemCheck
        If e.Index = 0 Then
            ' Khi "All" được check, bỏ check các mục khác
            If e.NewValue = CheckState.Checked Then
                For i As Integer = 1 To cbPmMachine.Items.Count - 1
                    cbPmMachine.SetItemChecked(i, False)
                Next
            End If
        Else
            ' Nếu bất kỳ mục nào khác được chọn, bỏ check "All"
            If e.NewValue = CheckState.Checked Then
                cbPmMachine.SetItemChecked(0, False)
            End If
        End If
    End Sub
    Private Sub cbPmMachine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPmMachine.SelectedIndexChanged
        Dim machineList As String = ""
        If cbPmMachine.CheckedItems.Count > 0 Then
            For Each item As String In cbPmMachine.CheckedItems
                machineList &= $"{item.ToString}{vbLf}"
            Next
        End If
        dgvPmPlan.CurrentCell.Value = machineList.TrimEnd().TrimEnd(vbLf)
    End Sub

    Private Sub dgvPmPlan_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPmPlan.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Kiểm tra ô hiện tại (CurrentCell) có hợp lệ không
            Dim currentCell = dgvPmPlan.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 6 AndAlso currentCell.ColumnIndex <= dgvPmPlan.ColumnCount Then
                ' Kiểm tra xem clipboard có hình ảnh không
                If Clipboard.ContainsImage() Then
                    ' Lấy hình ảnh từ clipboard
                    Dim image As Image = Clipboard.GetImage()

                    ' Gán hình ảnh vào ô hiện tại
                    dgvPmPlan.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = image
                    If currentCell.OwningColumn.Name.Contains("ImgBefore") Then
                        pbPmImageBefore.Image = image
                    ElseIf currentCell.OwningColumn.Name.Contains("ImgAfter") Then
                        pbPmImageAfter.Image = image
                    End If
                Else
                    MessageBox.Show("Clipboard không chứa hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

        If e.KeyCode = Keys.Delete Then
            Dim currentCell = dgvPmPlan.CurrentCell
            If currentCell IsNot Nothing AndAlso currentCell.ColumnIndex >= 0 AndAlso currentCell.ColumnIndex <= dgvPmPlan.ColumnCount Then
                ' Gán hình ảnh vào ô hiện tại
                dgvPmPlan.Rows(currentCell.RowIndex).Cells(currentCell.ColumnIndex).Value = Nothing
            End If
        End If
    End Sub

    Private Sub dgvPmPlan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPmPlan.CellContentClick
        If e.RowIndex >= 0 AndAlso dgvPmPlan.Columns(e.ColumnIndex).Name = "PmDelete" AndAlso Not dgvPmPlan.Rows(e.RowIndex).IsNewRow Then 'Kiểm tra có bấm vào cột Delete không
            Dim deleteConfirm As DialogResult
            deleteConfirm = MessageBox.Show($"Bạn có muốn xóa dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If deleteConfirm = DialogResult.Yes Then
                dgvPmPlan.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub btnEcnSaveData_Click(sender As Object, e As EventArgs) Handles btnEcnSaveData.Click
        ImportPmPlanToDataBase(dtpPmDateSelect.Value.Date)
    End Sub

    Private Sub dtpPmDateSelect_ValueChanged(sender As Object, e As EventArgs) Handles dtpPmDateSelect.ValueChanged
        LoadPmPlanData(dtpPmDateSelect.Value.Date)
        pbPmImageAfter.Image = Nothing
        pbPmImageBefore.Image = Nothing
    End Sub

    Private Sub btnReportInfoRefresh_Click(sender As Object, e As EventArgs) Handles btnReportInfoRefresh.Click
        LoadPmPlanData(dtpPmDateSelect.Value.Date)
        pbPmImageAfter.Image = Nothing
        pbPmImageBefore.Image = Nothing
    End Sub
End Class