Public Class TestClass


    Public mAge As Integer



    Public Enum AgeGroup


        Infant
        Child
        Teeenager
        Adult
        Senior
        OverAged


    End Enum



    Public Function GetAgeGroup() As AgeGroup

        Select Case mAge

            Case Is < 3
                Return (AgeGroup.Infant)
            Case Is < 10
                Return (AgeGroup.Child)
            Case Is < 20
                Return (AgeGroup.Teeenager)
            Case Is < 30
                Return (AgeGroup.Senior)

            Case Is < 50
                Return (AgeGroup.OverAged)


        End Select



    End Function

End Class
