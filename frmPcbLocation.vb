
Public Class frmPcbLocation
    Private coordinates As New List(Of (loc As String, corX As Double, corY As Double, corAng As Double, part As String))
    Private cadData As New List(Of (side As String, loc As String, x As String, y As String, angle As String))
    Private bomData As New List(Of (assy As String, smt As String, loc As String, com As String, des As String))
    Private materialData As New List(Of (code As String, description As String, sizex As Double, sizey As Double, thickness As Double))
    Private zoom = 4
    Private pcbXSize As Double
    Private pcbYSize As Double
    Private selectSide As String

    Private bomSearchLocationDetail As New DataTable()
    Private selectLoc As String = ""
    Private selectLocBefore As String = ""
    Private codeDetail As Array


    Public resultsLocation As New DataTable()
    Public resultsLocationView As New DataView(resultsLocation)

    Private selectCadColor As Color = Color.Blue
    Private selectBomColor As Color = Color.Lime
    Private selectPointColor As Color = Color.Red
    Private selectBackGroundColor As Color = Color.Black
    Private selectTextColor As Color = Color.OrangeRed

    Private drawScale = 3

    Private Sub frmPcbLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmCompareBom.Location.X, frmCompareBom.Location.Y)
        zoom = 4
        drawScale = 3

        selectLocBefore = ""
        selectLoc = ""
        txtSelectLocation.Text = ""
        txtSelectPart.Text = ""
        txtSearchLocation.Text = ""
        lbZoom.Text = $"Zoom (x{zoom})"

        btnSelectCadColor.BackColor = selectCadColor
        btnSelectBomColor.BackColor = selectBomColor
        btnSelectPointColor.BackColor = selectPointColor
        btnSelectBackgroundColor.BackColor = selectBackGroundColor
        btnTextColor.BackColor = selectTextColor
        framePanel.BackColor = selectBackGroundColor

        resultsLocation.Rows.Clear()
        resultsLocation.Columns.Clear()
        resultsLocation.Columns.Add("loc", GetType(String))
        resultsLocation.Columns.Add("part", GetType(String))

        With bomSearchLocationDetail
            .Rows.Clear()
            .Columns.Clear()
            .Columns.Add("Type")
            .Columns.Add("Code")
        End With

        cbSideSelect.Text = "Top"
        GetLocationToView()

        Dim prop As System.Reflection.PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
        prop.SetValue(locationPanel, True, Nothing)
    End Sub

    Sub GetLocationToView()
        selectSide = cbSideSelect.Text
        'Lấy thông tin Cad và BOM
        codeDetail = frmCompareBom.tvBomList.SelectedNode.Text.ToString().Split(" "c)


        With bomSearchLocationDetail
            .Rows.Add("Assy", codeDetail(0))
            .Rows.Add("SMT Top", codeDetail(1))
            .Rows.Add("SMT Bot", codeDetail(2))
            .Rows.Add("Pcb", codeDetail(3))
        End With
        dgvBomLocationDetail.DataSource = bomSearchLocationDetail

        cadData = GetPcbCadData(codeDetail(3))
        bomData = GetBomData(frmCompareBom.tvBomList.SelectedNode.Text)
        materialData = GetMaterialData()

        Dim pcbSize = GetPcbSize(codeDetail(3))
        ' Khởi tạo danh sách tọa độ
        pcbXSize = Convert.ToDouble(pcbSize(0))
        pcbYSize = Convert.ToDouble(pcbSize(1))

        GetBomLocation()

        locationPanel.Width = pcbXSize * zoom
        locationPanel.Height = pcbYSize * zoom

        ' Đăng ký sự kiện Paint của panel
        AddHandler locationPanel.Paint, AddressOf locationPanel_Paint
        txtResultCount.Text = $"{dgvLocationList.RowCount.ToString} Points"
    End Sub

    Sub GetBomLocation()
        Dim locIndex As Integer
        coordinates = New List(Of (loc As String, corX As Double, corY As Double, corAng As Double, part As String))
        coordinates.Clear()
        resultsLocation.Rows.Clear()

        For Each point In bomData
            locIndex = cadData.FindIndex(Function(data) data.loc = point.loc.ToString)
            If Not String.IsNullOrEmpty(point.loc) And locIndex >= 0 Then
                Dim newX = pcbXSize - Convert.ToDouble(cadData(locIndex).x)
                Dim newY = pcbYSize - Convert.ToDouble(cadData(locIndex).y)
                If cadData(locIndex).side.ToLower = selectSide.ToLower Then
                    coordinates.Add((cadData(locIndex).loc, newX, newY, Convert.ToDouble(cadData(locIndex).angle), point.com))
                    resultsLocation.Rows.Add(cadData(locIndex).loc, point.com)
                End If
            End If
        Next
        dgvLocationList.DataSource = resultsLocationView
    End Sub

    ' Sự kiện vẽ điểm lên Panel
    Private Sub locationPanel_Paint(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        ' Điều chỉnh tỉ lệ để khung vẽ vừa với panel
        Dim scaleX = (locationPanel.Width - 2) / pcbXSize
        Dim scaleY = (locationPanel.Height - 2) / pcbYSize
        Dim scale = Math.Min(scaleX, scaleY) - 0.1 ' Lấy tỉ lệ nhỏ hơn để không bị cắt

        ' Vẽ hình chữ nhật bao quanh
        Dim rectX = CInt(1)
        Dim rectY = CInt(2)
        Dim rectWidth = CInt(pcbXSize * scale)
        Dim rectHeight = CInt(pcbYSize * scale)

        g.DrawRectangle(Pens.Yellow, rectX, rectY, rectWidth, rectHeight)

        ' Vẽ các điểm bên trong hình chữ nhật
        For Each coordinate In cadData
            Dim bomLocFind = bomData.FirstOrDefault(Function(c) c.loc = coordinate.loc)
            If coordinate.side.ToLower = selectSide.ToLower Then
                ' Chuyển tọa độ từ thực sang tọa độ vẽ
                Dim x = CInt((pcbXSize - coordinate.x) * scale)
                Dim y = CInt((pcbYSize - coordinate.y) * scale)
                Dim angle = CInt((coordinate.angle)) 'Angle = 0, 90, 180, 270
                ' Vẽ điểm
                Dim originalPoint As New PointF(x, y)
                g.TranslateTransform(originalPoint.X, originalPoint.Y)
                g.RotateTransform(angle)

                Dim bomMaterialFind = materialData.FirstOrDefault(Function(c) c.code = bomLocFind.com)

                'Cập nhật thêm material nếu chưa có
                If bomMaterialFind.sizex = 0 And bomMaterialFind.sizey = 0 And bomLocFind.com IsNot Nothing Then
                    AddMaterialData(New List(Of (String, String)) From {
                                    (bomLocFind.com, bomLocFind.des)})
                    materialData = GetMaterialData()
                    bomMaterialFind = materialData.FirstOrDefault(Function(c) c.code = bomLocFind.com)
                End If

                If bomLocFind.loc <> Nothing Then
                    Using selectedBrush As New SolidBrush(selectBomColor)
                        g.FillRectangle(selectedBrush, CInt(-bomMaterialFind.sizex * (drawScale / 2)), CInt(-bomMaterialFind.sizey * (drawScale / 2)),
                                                        CInt(bomMaterialFind.sizex * drawScale), CInt(bomMaterialFind.sizey * drawScale))
                        If Not cbTextShow.Checked Then
                            'Thêm text cho vị trí bom
                            Using textBrush As New SolidBrush(selectTextColor)
                                Dim textSize As Double
                                textSize = Math.Min(bomMaterialFind.sizey, bomMaterialFind.sizex)
                                If textSize <= 0.5 Then
                                    textSize = 0.8
                                ElseIf textSize > 0.5 And textSize <= 3 Then
                                    textSize = 1.2
                                ElseIf textSize > 3 Then
                                    textSize = 2
                                End If
                                Dim textFont As New Font("Arial", textSize / 2 * zoom) ' Tùy chỉnh font và kích thước
                                Dim textPosition As New PointF(CInt(-bomMaterialFind.sizex * (drawScale / 2)), CInt(-bomMaterialFind.sizey * (drawScale / 2)))
                                g.DrawString(bomLocFind.loc, textFont, textBrush, textPosition)
                            End Using
                        End If
                    End Using
                Else
                    Using selectedBrush As New SolidBrush(selectCadColor)
                        g.FillRectangle(selectedBrush, -1, -1, 2, 2)
                    End Using
                End If
                g.ResetTransform()
            End If
        Next
    End Sub

    Private Sub HighlightPoint(g As Graphics, location As String, locationBefore As String)
        ' Tìm tọa độ của điểm
        Dim seclectLocCor = coordinates.FirstOrDefault(Function(c) c.loc = location)
        Dim bomMaterialFind = materialData.FirstOrDefault(Function(c) c.code = seclectLocCor.part)

        Dim seclectLocCorBefore = coordinates.FirstOrDefault(Function(c) c.loc = locationBefore)
        Dim bomMaterialBeforeFind = materialData.FirstOrDefault(Function(c) c.code = seclectLocCorBefore.part)

        ' Chuyển tọa độ từ thực sang tọa độ trên Panel
        Dim scaleX = (locationPanel.Width - 2) / pcbXSize
        Dim scaleY = (locationPanel.Height - 2) / pcbYSize
        Dim scale = Math.Min(scaleX, scaleY) - 0.1
        Dim drawScaleHighlight = drawScale * 2

        'Chuyển lại màu điểm chọn trước đó
        If seclectLocCorBefore.loc <> Nothing Then
            Dim x = CInt((seclectLocCorBefore.corX) * scale)
            Dim y = CInt((seclectLocCorBefore.corY) * scale)
            ' Tô màu điểm
            Dim angle = CInt((seclectLocCorBefore.corAng)) 'Angle = 0, 90, 180, 270
            ' Vẽ điểm
            Dim originalPoint As New PointF(x, y)
            g.TranslateTransform(originalPoint.X, originalPoint.Y)
            g.RotateTransform(angle)

            Using backgroundBrush As New SolidBrush(framePanel.BackColor)
                g.FillRectangle(backgroundBrush, CInt(-bomMaterialBeforeFind.sizex * (drawScaleHighlight / 2)), CInt(-bomMaterialBeforeFind.sizey * (drawScaleHighlight / 2)),
                                                CInt(bomMaterialBeforeFind.sizex * drawScaleHighlight), CInt(bomMaterialBeforeFind.sizey * drawScaleHighlight))
            End Using

            Using selectedBrush As New SolidBrush(selectBomColor)
                g.FillRectangle(selectedBrush, CInt(-bomMaterialBeforeFind.sizex * (drawScale / 2)), CInt(-bomMaterialBeforeFind.sizey * (drawScale / 2)),
                                            CInt(bomMaterialBeforeFind.sizex * drawScale), CInt(bomMaterialBeforeFind.sizey * drawScale))
            End Using
            g.ResetTransform()
        End If

        'Tô màu cho điểm mới
        If seclectLocCor.loc <> Nothing Then
            Dim x = CInt((seclectLocCor.corX) * scale)
            Dim y = CInt((seclectLocCor.corY) * scale)

            ' Tô màu điểm
            Dim angle = CInt((seclectLocCor.corAng)) 'Angle = 0, 90, 180, 270
            ' Vẽ điểm
            Dim originalPoint As New PointF(x, y)
            g.TranslateTransform(originalPoint.X, originalPoint.Y)
            g.RotateTransform(angle)
            Using selectedBrush As New SolidBrush(selectPointColor)
                g.FillRectangle(selectedBrush, CInt(-bomMaterialFind.sizex * (drawScaleHighlight / 2)), CInt(-bomMaterialFind.sizey * (drawScaleHighlight / 2)),
                                            CInt(bomMaterialFind.sizex * drawScaleHighlight), CInt(bomMaterialFind.sizey * drawScaleHighlight))
            End Using
            If Not cbTextShow.Checked Then
                'Thêm text cho vị trí bom
                Using textBrush As New SolidBrush(Color.White)
                    Dim textSize As Double
                    textSize = Math.Min(bomMaterialFind.sizey, bomMaterialFind.sizex)
                    If textSize <= 0.5 Then
                        textSize = 0.8
                    ElseIf textSize > 0.5 And textSize <= 3 Then
                        textSize = 1.2
                    ElseIf textSize > 3 Then
                        textSize = 2
                    End If
                    Dim textFont As New Font("Arial", textSize / 2 * zoom) ' Tùy chỉnh font và kích thước
                    Dim textPosition As New PointF(CInt(-bomMaterialFind.sizex * (drawScaleHighlight / 2)), CInt(-bomMaterialFind.sizey * (drawScaleHighlight / 2)))
                    g.DrawString(seclectLocCor.loc, textFont, textBrush, textPosition)
                End Using
            End If
            g.ResetTransform()
        End If
    End Sub

    Private Sub dgvLocationList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocationList.CellClick
        If e.RowIndex >= 0 Then
            ' Lưu tọa độ được chọn
            Dim newLoc = dgvLocationList.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim newPart = dgvLocationList.Rows(e.RowIndex).Cells(1).Value.ToString()
            ' Chỉ vẽ lại nếu chọn vị trí mới
            If newLoc <> selectLoc Then
                Dim g As Graphics = locationPanel.CreateGraphics()
                ' Cập nhật vị trí được chọn và tô màu xanh cho điểm mới
                txtSelectLocation.Text = newLoc
                txtSelectPart.Text = newPart

                selectLoc = newLoc
                HighlightPoint(g, selectLoc, selectLocBefore)
                selectLocBefore = selectLoc
                framePanel.Invalidate()

                MovePanelFrame(newLoc)
            End If
        End If
    End Sub

    Private Sub txtSearchLocation_TextChanged(sender As Object, e As EventArgs) Handles txtSearchLocation.TextChanged
        ApplyFilterLocationSearch()
        txtResultCount.Text = $"{dgvLocationList.RowCount.ToString} Points"
    End Sub

    Private Sub cbSideSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSideSelect.SelectedIndexChanged
        If resultsLocation.Rows.Count >= 0 Then
            selectSide = cbSideSelect.Text
            txtSearchLocation.Text = ""
            selectLocBefore = ""
            selectLoc = ""
            txtSelectLocation.Text = ""
            txtSelectPart.Text = ""
            zoom = 4
            drawScale = zoom - 1
            locationPanel.Invalidate()
            GetBomLocation()
            txtResultCount.Text = $"{dgvLocationList.RowCount.ToString} Points"
        End If
    End Sub



    Sub MovePanelFrame(moveLoc As String)
        Dim scaleX = (locationPanel.Width - 2) / pcbXSize
        Dim scaleY = (locationPanel.Height - 2) / pcbYSize
        Dim scale = Math.Min(scaleX, scaleY) - 0.1

        Dim seclectLocCor = coordinates.FirstOrDefault(Function(c) c.loc = moveLoc)
        Dim x = CInt((seclectLocCor.corX) * scale)
        Dim y = CInt((seclectLocCor.corY) * scale)

        'Chia tỉ lệ lúc zoom để di chuyển tới vị trí được chọn
        If zoom <= 35 Then
            framePanel.AutoScrollPosition = New Point(x - x / (zoom / 3.5), y - y / (zoom / 3.5))
        End If
    End Sub


    Private Sub framePanel_Scroll(sender As Object, e As ScrollEventArgs) Handles framePanel.Scroll
        Dim g As Graphics = locationPanel.CreateGraphics()
        HighlightPoint(g, selectLoc, selectLocBefore)
    End Sub

    Private Sub framePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles framePanel.MouseMove
        Dim g As Graphics = locationPanel.CreateGraphics()
        HighlightPoint(g, selectLoc, selectLocBefore)
    End Sub

    Private Sub locationPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles locationPanel.MouseMove
        Dim g As Graphics = locationPanel.CreateGraphics()
        HighlightPoint(g, selectLoc, selectLocBefore)

        If isDragging Then
            ' Tính toán khoảng cách di chuyển
            Dim dx As Integer = startPoint.X - e.Location.X
            Dim dy As Integer = startPoint.Y - e.Location.Y

            ' Di chuyển thanh cuộn của Panel
            framePanel.AutoScrollPosition = New Point(framePanel.HorizontalScroll.Value + dx, framePanel.VerticalScroll.Value + dy)
        End If
    End Sub

    Private Sub btnSelectCadColor_Click(sender As Object, e As EventArgs) Handles btnSelectCadColor.Click
        Dim colorDialog As New ColorDialog()
        colorDialog.AllowFullOpen = True
        colorDialog.Color = selectCadColor ' Hiển thị màu hiện tại trong hộp thoại

        If colorDialog.ShowDialog() = DialogResult.OK Then
            selectCadColor = colorDialog.Color ' Lưu màu được chọn
            btnSelectCadColor.BackColor = selectCadColor ' Đổi màu nền của nút để hiển thị màu đã chọn
            locationPanel.Invalidate()

            Dim g As Graphics = locationPanel.CreateGraphics()
            HighlightPoint(g, selectLoc, selectLocBefore)
        End If
    End Sub

    Private Sub btnSelectBomColor_Click(sender As Object, e As EventArgs) Handles btnSelectBomColor.Click
        Dim colorDialog As New ColorDialog()
        colorDialog.AllowFullOpen = True
        colorDialog.Color = selectBomColor ' Hiển thị màu hiện tại trong hộp thoại

        If colorDialog.ShowDialog() = DialogResult.OK Then
            selectBomColor = colorDialog.Color ' Lưu màu được chọn
            btnSelectBomColor.BackColor = selectBomColor ' Đổi màu nền của nút để hiển thị màu đã chọn
            locationPanel.Invalidate()

            Dim g As Graphics = locationPanel.CreateGraphics()
            HighlightPoint(g, selectLoc, selectLocBefore)
        End If
    End Sub

    Private Sub btnSelectPointColor_Click(sender As Object, e As EventArgs) Handles btnSelectPointColor.Click
        Dim colorDialog As New ColorDialog()
        colorDialog.AllowFullOpen = True
        colorDialog.Color = selectPointColor ' Hiển thị màu hiện tại trong hộp thoại

        If colorDialog.ShowDialog() = DialogResult.OK Then
            selectPointColor = colorDialog.Color ' Lưu màu được chọn
            btnSelectPointColor.BackColor = selectPointColor ' Đổi màu nền của nút để hiển thị màu đã chọn
            locationPanel.Invalidate()

            Dim g As Graphics = locationPanel.CreateGraphics()
            HighlightPoint(g, selectLoc, selectLocBefore)
        End If
    End Sub

    Private Sub btnSelectBackgroundColor_Click(sender As Object, e As EventArgs) Handles btnSelectBackgroundColor.Click
        Dim colorDialog As New ColorDialog()
        colorDialog.AllowFullOpen = True
        colorDialog.Color = selectBackGroundColor ' Hiển thị màu hiện tại trong hộp thoại

        If colorDialog.ShowDialog() = DialogResult.OK Then
            selectBackGroundColor = colorDialog.Color ' Lưu màu được chọn
            btnSelectBackgroundColor.BackColor = selectBackGroundColor ' Đổi màu nền của nút để hiển thị màu đã chọn
            locationPanel.Invalidate()
            framePanel.BackColor = selectBackGroundColor
            Dim g As Graphics = locationPanel.CreateGraphics()
            HighlightPoint(g, selectLoc, selectLocBefore)
        End If
    End Sub


    Private Sub frmPcbLocation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        framePanel.AutoScrollPosition = New Point(0, 0)
        resultsLocationView.RowFilter = Nothing
    End Sub

    Private Sub btnTextColor_Click(sender As Object, e As EventArgs) Handles btnTextColor.Click
        Dim colorDialog As New ColorDialog()
        colorDialog.AllowFullOpen = True
        colorDialog.Color = selectBackGroundColor ' Hiển thị màu hiện tại trong hộp thoại

        If colorDialog.ShowDialog() = DialogResult.OK Then
            selectTextColor = colorDialog.Color ' Lưu màu được chọn
            btnTextColor.BackColor = selectTextColor ' Đổi màu nền của nút để hiển thị màu đã chọn
            locationPanel.Invalidate()
            Dim g As Graphics = locationPanel.CreateGraphics()
            HighlightPoint(g, selectLoc, selectLocBefore)
        End If
    End Sub

    Private Sub cbTextShow_CheckedChanged(sender As Object, e As EventArgs) Handles cbTextShow.CheckedChanged
        If cbTextShow.Checked Then
            cbTextShow.Text = "Hide"
        Else
            cbTextShow.Text = "Show"
        End If


        locationPanel.Invalidate()
        Dim g As Graphics = locationPanel.CreateGraphics()
        HighlightPoint(g, selectLoc, selectLocBefore)
    End Sub

    Private isDragging As Boolean = False
    Private startPoint As Point

    Private Sub locationPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles locationPanel.MouseDown
        If e.Button = MouseButtons.Right Then
            ' Bắt đầu kéo
            isDragging = True
            startPoint = e.Location
            Cursor = Cursors.SizeAll ' Thay đổi con trỏ chuột để hiển thị trạng thái kéo
        End If
    End Sub

    Private Sub locationPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles locationPanel.MouseUp
        If e.Button = MouseButtons.Right Then
            ' Kết thúc kéo
            isDragging = False
            Cursor = Cursors.Default ' Đặt lại con trỏ chuột về mặc định
        End If
    End Sub

    'Zoom In Out 
    Private Sub framePanel_MouseWheel(sender As Object, e As MouseEventArgs) Handles framePanel.MouseWheel
        If e.Delta > 0 Then
            If zoom > 1 And zoom <= 35 Then
                zoom -= 0.5
                lbZoom.Text = $"Zoom (x{zoom})"
                ChangeDrawScale()
                locationPanel.Width = pcbXSize * zoom
                locationPanel.Height = pcbYSize * zoom
                locationPanel.Invalidate()

                Dim g As Graphics = locationPanel.CreateGraphics()
                HighlightPoint(g, selectLoc, selectLocBefore)
                If selectLoc <> "" Then
                    MovePanelFrame(selectLoc)
                End If
            End If
        End If

        If e.Delta < 0 Then
            If zoom >= 1 And zoom < 35 Then
                zoom += 0.5
                lbZoom.Text = $"Zoom (x{zoom})"
                ChangeDrawScale()
                locationPanel.Width = pcbXSize * zoom
                locationPanel.Height = pcbYSize * zoom
                locationPanel.Invalidate()

                Dim g As Graphics = locationPanel.CreateGraphics()
                HighlightPoint(g, selectLoc, selectLocBefore)
                If selectLoc <> "" Then
                    MovePanelFrame(selectLoc)
                End If
            End If
        End If
    End Sub
    Sub ChangeDrawScale()
        Select Case zoom
            Case 1
                drawScale = 0.5
            Case 2
                drawScale = 1
            Case >= 3
                drawScale = zoom - 1
        End Select
    End Sub
    Private Sub btnPanelRefresh_Click(sender As Object, e As EventArgs) Handles btnPanelRefresh.Click
        selectLoc = ""
        selectLocBefore = ""
        framePanel.Invalidate()
        locationPanel.Invalidate()
    End Sub
End Class