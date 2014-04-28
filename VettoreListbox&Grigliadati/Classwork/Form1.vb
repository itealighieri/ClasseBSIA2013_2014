Public Class Form1
    '
    ' Esempio di programma che gestisce l'output dei dati
    ' in una Listbox e in un componente DataGridview (Visualizzazione Griglia Dati)
    '
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ' Acquisizione del numero di tavoli a cui corrisponderanno 
            ' n righe nella griglia dati
            n = CInt(TextBox1.Text)
            If n < MAX Then
                ' Le successive istruzioni provvedono a creare due colonne nella griglia dati
                ' specificandone il nome e titolo 
                DataGridView1.Columns.Add("Colonna1", "Tavolo")
                DataGridView1.Columns.Add("Colonna2", "Importo")
                ' Creazione del numero di righe nella griglia dati
                ' considerando che la numerazione parte da zero
                ' si sottrae 1 a n per non avere una riga di troppo
                DataGridView1.Rows.Add(n - 1)
                For i = 1 To n
                    importotavoli(i) = CSng(InputBox("Inserisci importo dato dal tavolo numero " & CStr(i), "INSERIMENTO"))

                    ' Elenca nella listbox il valore dell'importo appena acquisito
                    ' il valore sarà visualizzato preparandolo mediante la funzione
                    ' FORMAT che tratta il dato numerico in modo da consentire  
                    ' la visualizzazione di tutte le cifre decimale presenti
                    ListBox1.Items.Add(Format(importotavoli(i), "F"))
                    ' Riporta il valore dell'importo appena acquisito nella griglia dati
                    DataGridView1.Item(0, i - 1).Value = i
                    DataGridView1.Item(1, i - 1).Value = Format(importotavoli(i), "F")
                    esito = True
                Next
            Else
                MessageBox.Show("Numero massimo prestabilito superato", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Inserire i dati!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If esito = True Then
            Form2.Show()
        Else
            MessageBox.Show("Inserire i dati!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
