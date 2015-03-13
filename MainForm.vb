'Project name: Penny Math
'Verison: 0.01
'Created by: Trump 3/13/15

Public Class Form1

    'Exit the program.
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    'Reset all fields in form.
    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        pennyInputBox.Text = String.Empty
        dollarBox.Text = String.Empty
        quarterBox.Text = String.Empty
        dimeBox.Text = String.Empty
        nickelBox.Text = String.Empty
        pennyBox.Text = String.Empty

    End Sub

    'Event procedures for figuring crap out.
    Private Sub doDaMathButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles doDaMathButton.Click
        'Declaring variables.
        Dim pennyInput = Val(pennyInputBox.Text)
        Dim dollarOutput As Integer
        Dim quarterOutput As Integer
        Dim dimeOutput As Integer
        Dim nickelOutput As Integer
        Dim pennyOutput As Integer
        Dim thundaspluke, thundaspluke2, thundaspluke3 As Integer

        'Working the magic math.
        dollarOutput = pennyInput \ 100
        dollarBox.Text = dollarOutput
        thundaspluke = pennyInput Mod 100

        quarterOutput = thundaspluke \ 25
        quarterBox.Text = quarterOutput
        thundaspluke2 = thundaspluke Mod 25

        dimeOutput = thundaspluke2 \ 10
        dimeBox.Text = dimeOutput
        thundaspluke3 = thundaspluke2 Mod 10

        nickelOutput = thundaspluke3 \ 5
        nickelBox.Text = nickelOutput

        pennyOutput = thundaspluke3 Mod 5
        pennyBox.Text = pennyOutput

    End Sub
End Class