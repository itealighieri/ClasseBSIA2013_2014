Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRicerca.Click
        Try
            valore = CSng(TextBox1.Text)
            For i = 1 To n
                If importotavoli(i) > valore Then
                    contatoretavoli = contatoretavoli + 1
                End If
            Next
            MessageBox.Show("Il numero di tavoli con importo superiore a " & CStr(valore) & " è " & CStr(contatoretavoli), "RISULTATO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As InvalidCastException
            MessageBox.Show("Inserire dati!!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class