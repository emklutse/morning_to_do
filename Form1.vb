Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkLunch_Click(sender As Object, e As EventArgs) Handles chkLunch.Click
        If Me.chkLunch.Checked Then
            MessageBox.Show("Don't forget bottled water!")
        End If
    End Sub

    Private Sub btnAllDone_Click(sender As Object, e As EventArgs) Handles btnAllDone.Click
        If Not (Me.chkBed.Checked And Me.chkLunch.Checked _
                And Me.chkHomework.Checked And Me.chkTeeth.Checked) Then
            MessageBox.Show("Did you forget something?")
        Else
            Application.Exit()
        End If
    End Sub
End Class
