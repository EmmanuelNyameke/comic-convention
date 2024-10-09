' Program Name: Comic Convention
' Date: October 1, 2024
' Author: K Bola
' Purpose: This Application computes the registration cost of attending a comic convention
Public Class frmComic
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const _cdecSuperheroCost As Decimal = 380
        Const _cdecAutographCost As Decimal = 275
        Const _cdecConventionCost As Decimal = 209
        Dim intGroupSize As Integer
        Dim decTotalCost As Decimal
        If (IsNumeric(txtSize.Text)) Then
            intGroupSize = Convert.ToInt32(txtSize.Text)
            If ((intGroupSize > 0) And (intGroupSize < 20) And (radSuperhero.Checked)) Then
                decTotalCost = intGroupSize * _cdecSuperheroCost
                lblCost.Text = decTotalCost.ToString("C")
            ElseIf ((intGroupSize > 0) And (intGroupSize < 20) And (radAutograph.Checked)) Then
                decTotalCost = intGroupSize * _cdecAutographCost
                lblCost.Text = decTotalCost.ToString("C")
            ElseIf ((intGroupSize > 0) And (intGroupSize < 20) And (radConvention.Checked)) Then
                decTotalCost = intGroupSize * _cdecConventionCost
                lblCost.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Please Enter a between 0 - 20", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
                txtSize.Clear()
                txtSize.Focus()
                lblCost.Text = ""
            End If
        Else
            MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
            txtSize.Clear()
            txtSize.Focus()
            lblCost.Text = ""
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSize.Clear()
        txtSize.Focus()
        lblCost.Text = ""
        radConvention.Checked = True
    End Sub
    Private Sub frmComic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
    End Sub
End Class
