Imports System.Data.SqlClient
Imports System.Data





Public Class FrmStatus

    Dim CNLTS As New SqlConnection("Data Source=(local);Initial Catalog=LangTransSkills;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=1000")



    Private Sub ButnAssignAttendance_Click(sender As Object, e As EventArgs) Handles ButnAssignAttendance.Click



        'Select all from hte table. 


        Dim rsCNTSUpdate As SqlCommand
        Dim rsCNTSSelect As SqlCommand

        Dim rsPending As SqlCommand


        Dim rsAtt As New SqlCommand("Select * from  Attendance order by sno ", CNLTS)

        Dim intCnt As Integer = 0


        CNLTS.Open()



        Dim rdrAtt As SqlDataReader = rsAtt.ExecuteReader

        While rdrAtt.Read

            If rdrAtt("sno") >= 0 Then



                Me.Text = rdrAtt("sno").ToString

                'Check for Selection

                rsCNTSSelect = New SqlCommand("select count(*) from pendinglist where emailid = '" & rdrAtt("emailID") & "'", CNLTS)
                intCnt = rsCNTSSelect.ExecuteScalar()



                If intCnt > 0 Then
                    rsCNTSUpdate = New SqlCommand("Update pendinglist set noofclasses = noofclasses + 1 where emailid = '" & rdrAtt("emailID") & "'", CNLTS)
                    rsCNTSUpdate.ExecuteNonQuery()
                Else

                    rsPending = New SqlCommand("insert into Pending values (" & rdrAtt("sno") & ",'" & rdrAtt("emailid") & "','" & rdrAtt("name") & "')", CNLTS)
                    rsPending.ExecuteNonQuery()


                End If



            End If

        End While



        CNLTS.Close()


        MsgBox("Done Successfully..!!!")



    End Sub

    Private Sub butnAccessment_Click(sender As Object, e As EventArgs) Handles butnAccessment.Click

        ' Assign Assignment. 
        'Traverse Assignment data Table. 

        Dim cmdAssess As New SqlCommand("Select * from EXAM_PHASE_B ", CNLTS)
        Dim rdrAccess As SqlDataReader


        Dim rsRegistration As SqlCommand

        Dim rsRegSelect As SqlCommand

        Dim intCntr As Integer = 0



        CNLTS.Open()

        rdrAccess = cmdAssess.ExecuteReader

        While rdrAccess.Read

            'Check for record in registration table..

            rsRegSelect = New SqlCommand("Select count(*) from pendinglist  where emailid  = '" & rdrAccess("EMAILID") & "'", CNLTS)
            intCntr = rsRegSelect.ExecuteScalar()



            If intCntr > 0 Then

                rsRegistration = New SqlCommand("update pendinglist set ex_status = 'A' where emailid = '" & rdrAccess("EmailID") & "'", CNLTS)
                rsRegistration.ExecuteNonQuery()

            End If

        End While




        CNLTS.Close()


        MsgBox("Done Successfully..!!!")



    End Sub

    Private Sub butnInit_Click(sender As Object, e As EventArgs) Handles butnInit.Click

        'Table Intitialation Code.. 2 tables... 
        'Delete Classes

        Dim rsUpdateClass As New SqlCommand("update pendinglist set noofclasses = 0, ex_status = 'N'", CNLTS)
        'Delete Status 


        Dim cmdDeletePending As New SqlCommand("Delete from Pending", CNLTS)



        CNLTS.Open()

        cmdDeletePending.ExecuteNonQuery()
        rsUpdateClass.ExecuteNonQuery()

        CNLTS.Close()


        MsgBox("Initialization is Complete..!!!!")

    End Sub

    Private Sub ButnCheckRemaining_Click(sender As Object, e As EventArgs) Handles ButnCheckRemaining.Click


        'Traverse Through Attendance..


        Dim cmdAttendance As New SqlCommand("Select * from  Attendance order by sno ", CNLTS)

        Dim cmdPendingSelect


        Dim intCnt As Integer = 0


        CNLTS.Open()



        Dim rdrAtt As SqlDataReader = cmdAttendance.ExecuteReader

        While rdrAtt.Read

            If rdrAtt("sno") >= 0 Then



                Me.Text = rdrAtt("sno").ToString

                'Check for Selection

                cmdCNTSSelect = New SqlCommand("select count(*) from pendinglist where emailid = '" & rdrAtt("emailID") & "'", CNLTS)
                intCnt = rsCNTSSelect.ExecuteScalar()



                If intCnt > 0 Then
                    rsCNTSUpdate = New SqlCommand("Update pendinglist set noofclasses = noofclasses + 1 where emailid = '" & rdrAtt("emailID") & "'", CNLTS)
                    rsCNTSUpdate.ExecuteNonQuery()
                Else

                    rsPending = New SqlCommand("insert into Pending values (" & rdrAtt("sno") & ",'" & rdrAtt("emailid") & "','" & rdrAtt("name") & "')", CNLTS)
                    rsPending.ExecuteNonQuery()


                End If



            End If

        End While



        CNLTS.Close()


        MsgBox("Done Successfully..!!!")





        'Ignore if Printed 

        'Store rest in Pending but only one Occurance.. 

        'send some Seperate Mails for confirmation 



    End Sub
End Class
