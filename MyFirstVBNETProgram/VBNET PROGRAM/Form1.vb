Public Class Form1

    Private Sub butEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEvaluate.Click

        '  Dim strMessage As String



        Dim strMessage = "Hurray !!!!"

        strMessage.ToUpper()

        If txtEvaluate.Text = "Visual Basic" Then

            MsgBox(strMessage & Chr(9) & "You are Winner of the main torunament", MsgBoxStyle.Information, "Information Regarding Your Choice")
        Else

            MsgBox(strMessage & Chr(9) & "You are Looser  of the main tornament ", MsgBoxStyle.Information, "Information Regarding Your Choice")


        End If


        MsgBox(strMessage.GetType.ToString())



    End Sub

    Private Sub butEvaluate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles butEvaluate.GotFocus

    End Sub

    Private Sub butEvaluate_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles butEvaluate.HandleDestroyed

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboSelection.SelectedIndex = 2




    End Sub

    Private Sub cboSelection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSelection.Click
       

    End Sub

    Private Sub cboSelection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelection.SelectedIndexChanged


        '  Dim strMessage As String



        Dim strMessage = "Hurray !!!!"

        strMessage = strMessage.ToUpper()

        If cboSelection.Text = "Visual Basic" Then

            MsgBox(strMessage & Chr(9) & "You are Winner of the main torunament", MsgBoxStyle.Information, "Information Regarding Your Choice")
        Else

            MsgBox(strMessage & Chr(9) & "You are Looser  of the main tornament ", MsgBoxStyle.Information, "Information Regarding Your Choice")
        End If



    End Sub

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click

        Me.Close()

    End Sub

    Private Sub bttnTxtAllign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnTxtAllign.Click

        txtEvaluate.TextAlign = HorizontalAlignment.Center


    End Sub

    Private Sub bttnOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOutput.Click

        Debug.Print("HELLO")

        tstSub()

        MsgBox(checkSum(3, 4))

    End Sub

    Private Sub bttnCodeSnipets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCodeSnipets.Click


        ' Backing storage -- a generic dictionary
        Dim sortedStudents As New SortedDictionary(Of Integer, String)

        ' Add items to the dictionary
        sortedStudents.Add(1, "Mary Chase")
        sortedStudents.Add(2, "Barnaby Williams")


    End Sub



    Sub tstSub()

        MsgBox("you are using a subroutine" & Now().ToShortDateString)



    End Sub


    Function checkSum(ByVal a As Integer, ByVal b As Integer) As Integer


        checkSum = a + b



    End Function
End Class
