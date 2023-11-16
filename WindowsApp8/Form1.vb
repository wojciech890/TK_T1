
Imports System.IO
Public Class LibraryFrom1
    Dim books As New List(Of Book) From
        {
            New Book With {.Id = "683f28c5-62ac-4ed4-b72a-f883260b86d1", .Title = "Hobbit", .Genre = "Fantastyka", .Author = "J.R.R Tolkien", .Isbn = "832071608X", .State = "Dostępna"},
            New Book With {.Id = "683f28c5-62ac-4ed4-b72a-f883260b86d2", .Title = "Hobbit", .Genre = "Fantastyka", .Author = "J.R.R Tolkien", .Isbn = "8373117113", .State = "Dostępna"},
            New Book With {.Id = "683f28c5-62ac-4ed4-b72a-f883260b86d3", .Title = "Hobbit", .Genre = "Fantastyka", .Author = "J.R.R Tolkien", .Isbn = "8373117116", .State = "Dostępna"},
            New Book With {.Id = "217b1a67-de54-4606-8dfa-2e58d6107737", .Title = "Wiersze wszystkie", .Genre = "Poezja", .Author = "W. Szymborska", .Isbn = "9788324066391", .State = "Dostępna"},
            New Book With {.Id = "8ecd031a-bce5-47a2-ab1a-1ae5db38ed30", .Title = "Fajdros", .Genre = "Filozofia", .Author = "Platon", .Isbn = "8388524569", .State = "Dostępna"},
            New Book With {.Id = "09a0630f-dc89-47d5-86f5-c8c184e78220", .Title = "Silmarillion", .Genre = "Fantastyka", .Author = "J.R.R Tolkien", .Isbn = "8371698801", .State = "Dostępna"},
            New Book With {.Id = "043bf7b4-2af2-4a1c-ae50-e7c93b873e78", .Title = "Silmarillion", .Genre = "Fantastyka", .Author = "J.R.R Tolkien", .Isbn = "8372458820", .State = "Dostępna"}
        }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim subset = From book In books
                     Select book.Genre
                     Order By Genre

        For Each genre As String In subset.Distinct
            GenreListBox1.Items.Add(genre)
        Next

    End Sub

    Private Sub GenreListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenreListBox1.SelectedIndexChanged
        Dim genre = GenreListBox1.SelectedItem
        If IsNothing(genre) Then
            Return
        End If
        Dim authors = From book In books
                      Where book.Genre = genre
                      Select book.Author
                      Order By Author

        AuthorListBox1.Items.Clear()
        TitleListBox.Items.Clear()
        IsbnListBox.Items.Clear()

        For Each author As String In authors.Distinct
            AuthorListBox1.Items.Add(author)
        Next
    End Sub

    Private Sub AuthorListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuthorListBox1.SelectedIndexChanged
        Dim author = AuthorListBox1.SelectedItem
        If IsNothing(author) Then
            Return
        End If
        Dim titles = From book In books
                     Where book.Author = author
                     Select book.Title
                     Order By Title

        TitleListBox.Items.Clear()
        IsbnListBox.Items.Clear()

        For Each title As String In titles.Distinct
            TitleListBox.Items.Add(title)
        Next
    End Sub

    Private Sub TitleListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TitleListBox.SelectedIndexChanged
        Dim title = TitleListBox.SelectedItem
        If IsNothing(title) Then
            Return
        End If
        Dim isbns = From book In books
                    Where book.Title = title
                    Select book.Isbn
                    Order By Isbn

        IsbnListBox.Items.Clear()

        For Each isbn As String In isbns
            IsbnListBox.Items.Add(isbn)
        Next
    End Sub

    Private Sub IsbnListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IsbnListBox.SelectedIndexChanged
        Dim isbn = IsbnListBox.SelectedItem
        If IsNothing(isbn) Then
            Return
        End If

        CoverPictureBox1.Image = My.Resources.ResourceManager.GetObject(isbn)

    End Sub

    Private Sub CoverPictureBox1_Click(sender As Object, e As EventArgs) Handles CoverPictureBox1.Click

    End Sub
End Class

Public Class Book
    Public Property Id As String
    Public Property Title As String
    Public Property Genre As String
    Public Property Author As String
    Public Property Isbn As String
    Public Property State As String
End Class