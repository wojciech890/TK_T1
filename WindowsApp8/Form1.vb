Public Class LibraryFrom1
    Dim genres As New List(Of String) From
        {"Fantastyka", "Biografie"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each genre As String In genres
            GenreListBox1.Items.Add(genre)
        Next
    End Sub

    Private Sub GenreListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenreListBox1.SelectedIndexChanged

    End Sub

End Class
