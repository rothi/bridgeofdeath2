Public Class Form1

    Private Sub btnApproach_Click(sender As Object, e As EventArgs) Handles btnApproach.Click
        Dim strName As String = InputBox("What is your name?", "Name")
        Dim strQuest As String = InputBox("What is your quest?", "Name")
        Dim intRandomQuestionNumber As Integer
        Dim strRandomQAnswer As String

        Dim strRandomQ1 As String = "What is the flight velocity of an unlaiden swallow?"
        Dim strRandomQ2 As String = "What is your favorite color?"
        Dim strRandomQ3 As String = "How is your day?"
        Dim strRandomQ4 As String = "What is the meaining of life?"

        Randomize()
        intRandomQuestionNumber = Int((4 - 1 + 1) * Rnd() + 1)

        If intRandomQuestionNumber = 1 Then
            strRandomQAnswer = InputBox(strRandomQ1, "random")
        ElseIf intRandomQuestionNumber = 2 Then
            strRandomQAnswer = InputBox(strRandomQ2, "random")
        ElseIf intRandomQuestionNumber = 3 Then
            strRandomQAnswer = InputBox(strRandomQ3, "random")
        ElseIf intRandomQuestionNumber = 4 Then
            strRandomQAnswer = InputBox(strRandomQ4, "random")
        End If

        If strName = "Ian" Then
            Me.lblAnswer1.Text = "Good"
        ElseIf strName <> "Ian" Then
            Me.lblAnswer1.Text = "You die."
        End If

        If strQuest = "To seek the Holy Grail" Then
            Me.lblAnswer2.Text = "Good"
        ElseIf strQuest <> "To seek the Holy Grail" Then
            Me.lblAnswer2.Text = "You die."
        End If

        If intRandomQuestionNumber = 1 And strRandomQAnswer = "52.5mph" Then
            Me.lblAnswer3.Text = "Good"
        ElseIf intRandomQuestionNumber = 1 And strRandomQAnswer <> "52.5mph" Then
            Me.lblAnswer3.Text = "You die."
        End If
        If intRandomQuestionNumber = 2 And strRandomQAnswer = "Blue" Then
            Me.lblAnswer3.Text = "Good"
        ElseIf intRandomQuestionNumber = 2 And strRandomQAnswer <> "Blue" Then
            Me.lblAnswer3.Text = "You die."
        End If
        If intRandomQuestionNumber = 3 And strRandomQAnswer = "Good, thanks!" Then
            Me.lblAnswer3.Text = "Good"
        ElseIf intRandomQuestionNumber = 3 And strRandomQAnswer <> "Good, thanks!" Then
            Me.lblAnswer3.Text = "You die."
        End If
        If intRandomQuestionNumber = 4 And strRandomQAnswer = "To live every day to it's fullest" Then
            Me.lblAnswer3.Text = "Good"
        ElseIf intRandomQuestionNumber = 4 And strRandomQAnswer <> "To live every day to it's fullest" Then
            Me.lblAnswer3.Text = "You die."
        End If

        If Me.lblAnswer1.Text = "Good" And Me.lblAnswer2.Text = "Good" And Me.lblAnswer3.Text = "Good" Then
            Me.lblFinal.Text = "All 3 are correct. YOU MAY PASS!"
        Else : Me.lblFinal.Text = "Some answers are incorrect. YOU DIE!"
        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.lblAnswer1.Text = ""
        Me.lblAnswer2.Text = ""
        Me.lblAnswer3.Text = ""
        Me.lblFinal.Text = ""
    End Sub
End Class
