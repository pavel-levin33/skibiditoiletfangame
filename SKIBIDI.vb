Public Class SKIBIDI
    Private Sub SKIBIDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Ost, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub SKIBIDI_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = (My.Resources.Skibidi_Head_Canon)
        Form1.Label3.Text = ("yes")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Form1.Label3.Text = ("yes") Then
            PictureBox1.Image = (My.Resources.No_Head_Skibidu)
            My.Settings.Glob_Count = Val(My.Settings.Glob_Count) + Val("1")
        End If
        Form1.Label3.Text = ("no")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Count_Update_Tick(sender As Object, e As EventArgs) Handles Count_Update.Tick
        count.Text = (My.Settings.Glob_Count)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        My.Settings.Glob_Count = ("0")
    End Sub
End Class