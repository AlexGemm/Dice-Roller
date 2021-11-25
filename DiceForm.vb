Public Class DiceForm

    Dim result As Integer

    Private Sub btnRollDFour_Click(sender As Object, e As EventArgs) Handles btnRollDFour.Click

        result = Int((4 * Rnd()) + 1)
        CalcLabel.Text = result

    End Sub
    Private Sub btnRollDSix_Click(sender As Object, e As EventArgs) Handles btnRollDSix.Click

        result = Int((6 * Rnd()) + 1)
        CalcLabel.Text = result

    End Sub
    Private Sub btnRollDEight_Click(sender As Object, e As EventArgs) Handles btnRollDEight.Click

        result = Int((8 * Rnd()) + 1)
        CalcLabel.Text = result

    End Sub
    Private Sub btnRollDTen_Click(sender As Object, e As EventArgs) Handles btnRollDTen.Click

        result = Int((10 * Rnd()) + 1)
        CalcLabel.Text = result

    End Sub
    Private Sub btnRollDTwelve_Click(sender As Object, e As EventArgs) Handles btnRollDTwelve.Click

        result = Int((12 * Rnd()) + 1)
        CalcLabel.Text = result

    End Sub
    Private Sub btnRollDTwenty_Click(sender As Object, e As EventArgs) Handles btnRollDTwenty.Click

        result = Int((20 * Rnd()) + 1)
        CalcLabel.Text = result

    End Sub
    Private Sub btnRollDHundred_Click(sender As Object, e As EventArgs) Handles btnRollDHundred.Click

        result = Int((100 * Rnd()) + 1)
        CalcLabel.Text = result

    End Sub


    Private Sub DiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClacLabel_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
