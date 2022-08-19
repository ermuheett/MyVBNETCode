Public Class FrmHome
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        MsgBox("Thank You Very Much for Using Event Manger 1.0", vbInformation + vbOKOnly, "Exiting")

        End



    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FrmEventMaster.Show()


    End Sub
End Class
