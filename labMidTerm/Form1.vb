Public Class Form1
    Private hold1 As Double = 0

    Private sum As Double = 0
    Private seniorD As Double = 0
    Private seniorT As Double = 0
    Private promo As Double = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnCalc.Click
        sum = (Val(txtChick.Text) * 350) + (Val(txtDuck.Text) * 400) + (Val(txtTurk.Text) * 500)

        seniorD = 0
        seniorT = 0
        promo = 0
        txtSD.Clear()
        txtPD.Clear()

        txtBP.Text = sum

        If Val(txtAge2.Text) >= 60 Then
            seniorD = sum * 0.12
            seniorT = sum * 0.88

            txtSD.Text = sum - seniorT
            txtTP.Text = seniorT

        ElseIf Val(txtBP.Text) > 1000 Then
            promo = sum - 200

            If seniorD < 200 Then
                txtPD.Text = 200
                txtTP.Text = Val(txtBP.Text) - Val(txtPD.Text)

            End If

        Else
            txtTP.Text = sum

        End If

    End Sub

    Private Sub bttnCon_Click(sender As Object, e As EventArgs) Handles bttnCon.Click
        txtAge2.Text = txtAge1.Text
        txtName2.Text = txtName1.Text
        txtCS2.Text = txtCS1.Text

        Panel1.Enabled = True
    End Sub

    Private Sub bttnPay_Click(sender As Object, e As EventArgs) Handles bttnPay.Click
        If txtPay.Text >= txtTP.Text Then
            MsgBox("Thank you for your purchase!", vbOKOnly, "Thank you!")

        Else
            MsgBox("Insufficient funds!", vbOKOnly, "Gimme monneh")

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
