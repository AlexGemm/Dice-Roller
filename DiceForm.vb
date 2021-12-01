Public Class DiceForm

    Dim result As Integer
    Dim modifier As Integer
    Dim rollingMultiple As Boolean

    Private Sub btnRollDFour_Click(sender As Object, e As EventArgs) Handles btnRollDFour.Click

        If rollingMultiple = False Then
            result = Int((4 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        Else
            result += Int((4 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        End If

    End Sub
    Private Sub btnRollDSix_Click(sender As Object, e As EventArgs) Handles btnRollDSix.Click

        If rollingMultiple = False Then
            result = Int((6 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        Else
            result += Int((6 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        End If

    End Sub
    Private Sub btnRollDEight_Click(sender As Object, e As EventArgs) Handles btnRollDEight.Click

        If rollingMultiple = False Then
            result = Int((8 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        Else
            result += Int((8 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        End If

    End Sub
    Private Sub btnRollDTen_Click(sender As Object, e As EventArgs) Handles btnRollDTen.Click

        If rollingMultiple = False Then
            result = Int((10 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        Else
            result += Int((10 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        End If

    End Sub
    Private Sub btnRollDTwelve_Click(sender As Object, e As EventArgs) Handles btnRollDTwelve.Click

        If rollingMultiple = False Then
            result = Int((12 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        Else
            result += Int((12 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        End If

    End Sub
    Private Sub btnRollDTwenty_Click(sender As Object, e As EventArgs) Handles btnRollDTwenty.Click

        If rollingMultiple = False Then
            result = Int((20 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        Else
            result += Int((20 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        End If

    End Sub
    Private Sub btnRollDHundred_Click(sender As Object, e As EventArgs) Handles btnRollDHundred.Click

        If rollingMultiple = False Then
            result = Int((100 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        Else
            result += Int((100 * Rnd()) + 1)
            CalcLabel.Text = (result + modifier)
        End If

    End Sub

    Private Sub dicePool_Click(sender As Object, e As EventArgs) Handles dicePool.Click
        If rollingMultiple = False Then
            result = 0
            CalcLabel.Text = result
            dicePool.Text = "Roll Single"
            rollingMultiple = True
        Else
            result = 0
            CalcLabel.Text = result
            dicePool.Text = "Roll Multiple"
            rollingMultiple = False
        End If

    End Sub


    Private Sub DiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClacLabel_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        modifier += 1
        CalcLabel.Text = (result + modifier)
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        modifier -= 1
        CalcLabel.Text = (result + modifier)
    End Sub

End Class
