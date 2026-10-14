Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblDependants.Click

    End Sub

    Private Sub btnCalculateFees_Click(sender As Object, e As EventArgs) Handles btnCalculateFees.Click



    End Sub

    Private Sub btnCalculateFees_Click_1(sender As Object, e As EventArgs) Handles btnCalculateFees.Click
        Dim salary As Decimal = Val(txtSalary.Text)
        Dim dependants As Integer = Val(txtDependants.Text)
        Dim fees As Decimal = Val(txtSchoolFees)


        Dim expenses As Decimal = dependants * fees
        Dim balance As Decimal = salary - expenses
        txtResults.Text = "Total School Fees:UGX " & expenses &
            vbNewLine &
        "Take Home Balance: UGX " & balance


    End Sub

    Private Sub btnCalculateDeductions_Click(sender As Object, e As EventArgs) Handles btnCalculateDeductions.Click
        Dim salary As Decimal = Val(txtSalary.Text)

        Dim nssf As Decimal = salary * 10 / 100
        Dim paye As Decimal = salary * 9 / 100
        Dim sacco As Decimal = salary * 5 / 100
        Dim total As Decimal = nssf + paye + sacco
        Dim balance As Decimal = salary - total

        txtResults.Text = "NSSF: UGX " & nssf &
            vbNewLine & "PAYE: UGX " & paye &
            vbNewLine & "SACCO: UGX " & sacco &
            vbNewLine & "Total Deductions: UGX " & total &
            vbNewLine & "Balance After Deductions: UGX " & balance
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSalary.Clear()
        txtDependants.Clear()
        txtSchoolFees.Clear()
        txtResults.Clear()
    End Sub
End Class
