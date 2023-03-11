Public Class MainDashboard
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutSkyWalkerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSkyWalkerToolStripMenuItem.Click
        AboutSkyWalker.Show()
    End Sub

    Private Sub AboutDevelopersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDevelopersToolStripMenuItem.Click
        AboutDevelopers.Show()
    End Sub
End Class
