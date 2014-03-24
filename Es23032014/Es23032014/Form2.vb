Public Class Form2

    Private Sub ordina()
        Dim j As Integer
        Dim temp As String
        For i = 1 To n - 1
            For j = (i + 1) To n
                If Cognome(i) > Cognome(j) Then
                    temp = Cognome(i)
                    Cognome(i) = Cognome(j)
                    Cognome(j) = temp
                End If
            Next
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ordina()
        For i = 1 To n
            ListBox1.Items.Add(Cognome(i))
        Next
    End Sub
End Class