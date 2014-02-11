Public Class Form1
    Const MAX = 35 ' Dimensione massima del vettore
    Dim i As Integer = 0
    Dim n As Integer = 0
    Dim vet(MAX) As Integer
    Dim inserito As Boolean = False


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Acquisisce la quantità di valori
        n = CInt(TextBox1.Text)
        ' Verifica rispetto della dimensione massima
        If n <= MAX Then
            i = 0
            inserito = True ' segnale di presenza dei voti
            Do While i < n
                i = i + 1
                vet(i) = CInt(InputBox("Inserisci voto", "Inserimento"))
            Loop
        Else
            MessageBox.Show("Dimensione massima accettabile=35 ", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If inserito = True Then
            i = 0
            Do While i < n
                i = i + 1
                MessageBox.Show(CStr(i) & "° Voto " & CStr(vet(i)), "Visualizza", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loop
        Else
            MessageBox.Show("Prima di visualizzare, inserire i dati", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class
