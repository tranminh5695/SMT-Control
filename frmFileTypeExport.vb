Public Class frmFileTypeExport
    Public fileExportType As String
    Public fileExportSide As String

    Private Sub frmFileTypeExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileExportType = ""
        fileExportSide = ""
        btnExcelType.Show()
        btnTextType.Show()
        btnTopSide.Hide()
        btnBotSide.Hide()

        Label1.Text = "Chọn file muốn xuất"
        Me.Location = New Point(frmCompareBom.Location.X + frmCompareBom.Width / 2 - Me.Width / 2, frmCompareBom.Location.Y + frmCompareBom.Height / 2 - Me.Height / 2)
    End Sub
    Private Sub btnExcelType_Click(sender As Object, e As EventArgs) Handles btnExcelType.Click
        fileExportType = "Excel"
        Me.Close()
    End Sub
    Private Sub btnTextType_Click(sender As Object, e As EventArgs) Handles btnTextType.Click
        fileExportType = "Text"
        Label1.Text = "Chọn Top/Bot"
        btnBotSide.Show()
        btnTopSide.Show()
    End Sub

    Private Sub btnTopSide_Click(sender As Object, e As EventArgs) Handles btnTopSide.Click
        fileExportSide = "top"
        Me.Close()
    End Sub

    Private Sub btnBotSide_Click(sender As Object, e As EventArgs) Handles btnBotSide.Click
        fileExportSide = "bot"
        Me.Close()
    End Sub
End Class