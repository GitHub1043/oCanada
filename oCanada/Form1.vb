Public Class Form1
    Dim intLine As Integer
    'Scope of intLine the WHOLE program
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Randomize()

        intLine = Int(Rnd() * 10) + 1

        Select Case intLine
            Case 1
                lblLine.Text = "O Canada!"
            Case 2
                lblLine.Text = "Our home and native land!"
            Case 3
                lblLine.Text = "True patriot love in all of us command."
            Case 4
                lblLine.Text = "With glowing hearts we see thee rise,"
            Case 5
                lblLine.Text = "The True North strong and free!"
            Case 6
                lblLine.Text = "From far and wide,"
            Case 7, 9, 10
                lblLine.Text = "O Canada, we stand on guard for thee."
            Case 8
                lblLine.Text = "God keep our land glorious and free!"
        End Select

    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim intGuess As Integer

        intGuess = Val(txtGuess.Text)
        If (intGuess = intLine) Then
            MessageBox.Show("Correct")
        ElseIf (intLine = 7) And (intGuess = 9) Then
            MessageBox.Show("Correct")
        ElseIf (intLine = 7) And (intGuess = 10) Then
            MessageBox.Show("Correct")
        ElseIf (intLine = 9) Then
            If (intGuess = 7) Then
                MessageBox.Show("Correct")
            ElseIf (intGuess = 10) Then
                MessageBox.Show("Correct")
            End If

        ElseIf ((intLine = 10) And (intGuess = 7)) Or ((intLine = 10) And (intGuess = 9)) Then
            MessageBox.Show("Correct")
        End If

    End Sub
End Class
