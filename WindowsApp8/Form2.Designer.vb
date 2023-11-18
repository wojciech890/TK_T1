<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBooksForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AddButton1 = New System.Windows.Forms.Button()
        Me.CloseButton1 = New System.Windows.Forms.Button()
        Me.IsbnLabel1 = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AuthorLabel1 = New System.Windows.Forms.Label()
        Me.Genre = New System.Windows.Forms.Label()
        Me.GenreTextBox1 = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox1 = New System.Windows.Forms.TextBox()
        Me.TitleTextBox1 = New System.Windows.Forms.TextBox()
        Me.IsbnTextBox1 = New System.Windows.Forms.TextBox()
        Me.GenreWarningLabel1 = New System.Windows.Forms.Label()
        Me.AuthorWarningLabel1 = New System.Windows.Forms.Label()
        Me.TitleWarningLabel1 = New System.Windows.Forms.Label()
        Me.IsbnWarningLabel1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddButton1
        '
        Me.AddButton1.Location = New System.Drawing.Point(693, 74)
        Me.AddButton1.Name = "AddButton1"
        Me.AddButton1.Size = New System.Drawing.Size(75, 23)
        Me.AddButton1.TabIndex = 0
        Me.AddButton1.Text = "Dodaj"
        Me.AddButton1.UseVisualStyleBackColor = True
        '
        'CloseButton1
        '
        Me.CloseButton1.Location = New System.Drawing.Point(693, 121)
        Me.CloseButton1.Name = "CloseButton1"
        Me.CloseButton1.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton1.TabIndex = 1
        Me.CloseButton1.Text = "Zamknij"
        Me.CloseButton1.UseVisualStyleBackColor = True
        '
        'IsbnLabel1
        '
        Me.IsbnLabel1.AutoSize = True
        Me.IsbnLabel1.Location = New System.Drawing.Point(551, 43)
        Me.IsbnLabel1.Name = "IsbnLabel1"
        Me.IsbnLabel1.Size = New System.Drawing.Size(83, 13)
        Me.IsbnLabel1.TabIndex = 10
        Me.IsbnLabel1.Text = "Numer wydania:"
        Me.IsbnLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(381, 43)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(35, 13)
        Me.TitleLabel.TabIndex = 9
        Me.TitleLabel.Text = "Tytuł:"
        '
        'AuthorLabel1
        '
        Me.AuthorLabel1.AutoSize = True
        Me.AuthorLabel1.Location = New System.Drawing.Point(227, 43)
        Me.AuthorLabel1.Name = "AuthorLabel1"
        Me.AuthorLabel1.Size = New System.Drawing.Size(35, 13)
        Me.AuthorLabel1.TabIndex = 8
        Me.AuthorLabel1.Text = "Autor:"
        Me.AuthorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Genre
        '
        Me.Genre.AutoSize = True
        Me.Genre.Location = New System.Drawing.Point(57, 43)
        Me.Genre.Name = "Genre"
        Me.Genre.Size = New System.Drawing.Size(51, 13)
        Me.Genre.TabIndex = 7
        Me.Genre.Text = "Gatunek:"
        '
        'GenreTextBox1
        '
        Me.GenreTextBox1.Location = New System.Drawing.Point(60, 77)
        Me.GenreTextBox1.Name = "GenreTextBox1"
        Me.GenreTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.GenreTextBox1.TabIndex = 11
        '
        'AuthorTextBox1
        '
        Me.AuthorTextBox1.Location = New System.Drawing.Point(230, 77)
        Me.AuthorTextBox1.Name = "AuthorTextBox1"
        Me.AuthorTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AuthorTextBox1.TabIndex = 12
        '
        'TitleTextBox1
        '
        Me.TitleTextBox1.Location = New System.Drawing.Point(384, 77)
        Me.TitleTextBox1.Name = "TitleTextBox1"
        Me.TitleTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox1.TabIndex = 13
        '
        'IsbnTextBox1
        '
        Me.IsbnTextBox1.Location = New System.Drawing.Point(554, 77)
        Me.IsbnTextBox1.Name = "IsbnTextBox1"
        Me.IsbnTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IsbnTextBox1.TabIndex = 14
        '
        'GenreWarningLabel1
        '
        Me.GenreWarningLabel1.AutoSize = True
        Me.GenreWarningLabel1.ForeColor = System.Drawing.Color.Red
        Me.GenreWarningLabel1.Location = New System.Drawing.Point(60, 104)
        Me.GenreWarningLabel1.Name = "GenreWarningLabel1"
        Me.GenreWarningLabel1.Size = New System.Drawing.Size(82, 13)
        Me.GenreWarningLabel1.TabIndex = 15
        Me.GenreWarningLabel1.Text = "Pole wymagane"
        Me.GenreWarningLabel1.Visible = False
        '
        'AuthorWarningLabel1
        '
        Me.AuthorWarningLabel1.AutoSize = True
        Me.AuthorWarningLabel1.ForeColor = System.Drawing.Color.Red
        Me.AuthorWarningLabel1.Location = New System.Drawing.Point(227, 104)
        Me.AuthorWarningLabel1.Name = "AuthorWarningLabel1"
        Me.AuthorWarningLabel1.Size = New System.Drawing.Size(82, 13)
        Me.AuthorWarningLabel1.TabIndex = 16
        Me.AuthorWarningLabel1.Text = "Pole wymagane"
        Me.AuthorWarningLabel1.Visible = False
        '
        'TitleWarningLabel1
        '
        Me.TitleWarningLabel1.AutoSize = True
        Me.TitleWarningLabel1.ForeColor = System.Drawing.Color.Red
        Me.TitleWarningLabel1.Location = New System.Drawing.Point(381, 104)
        Me.TitleWarningLabel1.Name = "TitleWarningLabel1"
        Me.TitleWarningLabel1.Size = New System.Drawing.Size(82, 13)
        Me.TitleWarningLabel1.TabIndex = 17
        Me.TitleWarningLabel1.Text = "Pole wymagane"
        Me.TitleWarningLabel1.Visible = False
        '
        'IsbnWarningLabel1
        '
        Me.IsbnWarningLabel1.AutoSize = True
        Me.IsbnWarningLabel1.ForeColor = System.Drawing.Color.Red
        Me.IsbnWarningLabel1.Location = New System.Drawing.Point(551, 104)
        Me.IsbnWarningLabel1.Name = "IsbnWarningLabel1"
        Me.IsbnWarningLabel1.Size = New System.Drawing.Size(82, 13)
        Me.IsbnWarningLabel1.TabIndex = 18
        Me.IsbnWarningLabel1.Text = "Pole wymagane"
        Me.IsbnWarningLabel1.Visible = False
        '
        'AddBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 388)
        Me.Controls.Add(Me.IsbnWarningLabel1)
        Me.Controls.Add(Me.TitleWarningLabel1)
        Me.Controls.Add(Me.AuthorWarningLabel1)
        Me.Controls.Add(Me.GenreWarningLabel1)
        Me.Controls.Add(Me.IsbnTextBox1)
        Me.Controls.Add(Me.TitleTextBox1)
        Me.Controls.Add(Me.AuthorTextBox1)
        Me.Controls.Add(Me.GenreTextBox1)
        Me.Controls.Add(Me.IsbnLabel1)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.AuthorLabel1)
        Me.Controls.Add(Me.Genre)
        Me.Controls.Add(Me.CloseButton1)
        Me.Controls.Add(Me.AddButton1)
        Me.Name = "AddBooksForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton1 As Button
    Friend WithEvents CloseButton1 As Button
    Friend WithEvents IsbnLabel1 As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents AuthorLabel1 As Label
    Friend WithEvents Genre As Label
    Friend WithEvents GenreTextBox1 As TextBox
    Friend WithEvents AuthorTextBox1 As TextBox
    Friend WithEvents TitleTextBox1 As TextBox
    Friend WithEvents IsbnTextBox1 As TextBox
    Friend WithEvents GenreWarningLabel1 As Label
    Friend WithEvents AuthorWarningLabel1 As Label
    Friend WithEvents TitleWarningLabel1 As Label
    Friend WithEvents IsbnWarningLabel1 As Label
End Class
