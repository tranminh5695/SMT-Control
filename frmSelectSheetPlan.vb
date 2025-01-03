Imports System.Management

Public Class frmSelectSheetPlan
    Public sheetSelect As String

    Private Sub SelectSheetPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbSheetPlan.Items.Clear()
        For Each sheet In PlanDetailData.listSheetPlan
            lbSheetPlan.Items.Add(sheet)
        Next
        Me.Location = New Point(frmCompareBom.Location.X + frmCompareBom.Width / 2 - Me.Width / 2, frmCompareBom.Location.Y + frmCompareBom.Height / 2 - Me.Height / 2)
    End Sub

    Private Sub btnSelectSheetPlan_Click(sender As Object, e As EventArgs) Handles btnSelectSheetPlan.Click
        sheetSelect = ""
        If lbSheetPlan.SelectedItem IsNot Nothing Then
            sheetSelect = lbSheetPlan.SelectedItem.ToString
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        sheetSelect = ""
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class