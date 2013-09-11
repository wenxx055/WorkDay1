Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim height_str As String
        Dim weight_str As String
        Dim BMI As Double

        height_str = txtHeight.Text
        weight_str = txtWeight.Text

        Dim height_num As Double
        Dim weight_num As Double

        height_num = CDbl(height_str)
        weight_num = CDbl(weight_str)

        BMI = (weight_num * 703) / (height_num ^ 2)

        TextBox1.Text = CStr(BMI)
    End Sub
End Class
