Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strName As String = "Josh"
        Dim strQuest As String = "Seek the Grail"
        Dim strFavoriteColor As String = "Blue"

        Dim strNameGuess As String = Me.txtNameGuess.Text
        Dim strQuestGuess As String = Me.txtQuestGuess.Text
        Dim strColorGuess As String = Me.txtColorGuess.Text

        If strName = strNameGuess And strQuest = strQuestGuess And strFavoriteColor = strColorGuess Then

            Me.lblQ1Answer.Text = "You may pass!!"
        Else
            Me.lblQ1Answer.Text = "You will die!!"
        End If

    End Sub
End Class
