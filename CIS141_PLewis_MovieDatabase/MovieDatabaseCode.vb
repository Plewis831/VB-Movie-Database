Public Class movieDatabase

    Dim movieID As String
    Dim title As String
    Dim director As String
    Dim yearReleased As String
    Dim genre As String

    Private Sub VideosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VideosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VideosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MovieDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MovieDataSet.Videos' table. You can move, or remove it, as needed.
        Me.VideosTableAdapter.Fill(Me.MovieDataSet.Videos)

    End Sub

    'Add a new movie
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Try
            Me.Validate()
            Me.VideosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MovieDataSet)
            VideosBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("I am sorry, there is an error. Please restart the program.")
        End Try

        Me.VideosTableAdapter.Fill(Me.MovieDataSet.Videos)

    End Sub

    'Delete Selection from table
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Try
            Me.VideosBindingSource.RemoveCurrent()
        Catch ex As Exception
            MessageBox.Show("I am sorry, there is an error. Please restart the program.")
        End Try
    End Sub

    'Update fields that are changed but leave ones the same that are not changed in the textbox
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click

        Dim str As String

        Try

            For Each x As Control In Me.Controls
            If x.GetType Is GetType(TextBox) Then

                If Not x.Text = String.Empty Then
                    str = str & x.Name & " = @" & x.Name & ","
                End If
            End If
        Next

        If str.EndsWith(",") Then
            str = str.Remove(str.Length - 1, 1)
        End If

        Catch ex As Exception
            MessageBox.Show("I am sorry, there is an error. Please restart the program.")
        End Try
    End Sub

    Private Sub ShowMoviesSince1995ToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowMoviesSince1995ToolStripButton.Click
        Try
            Me.VideosTableAdapter.ShowMoviesSince1995(Me.MovieDataSet.Videos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowMoviesBySpielbergToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowMoviesBySpielbergToolStripButton.Click
        Try
            Me.VideosTableAdapter.ShowMoviesBySpielberg(Me.MovieDataSet.Videos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowThreeStarsAndUpToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowThreeStarsAndUpToolStripButton.Click
        Try
            Me.VideosTableAdapter.ShowThreeStarsAndUp(Me.MovieDataSet.Videos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowFiveStarMoviesToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowFiveStarMoviesToolStripButton.Click
        Try
            Me.VideosTableAdapter.ShowFiveStarMovies(Me.MovieDataSet.Videos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowAllMoviesToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowAllMoviesToolStripButton.Click
        Try
            Me.VideosTableAdapter.showAllMovies(Me.MovieDataSet.Videos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        MessageBox.Show("Author: Preston Lewis" & Environment.NewLine & "Date: 11/20/19" & Environment.NewLine &
            "CIS 141" & Environment.NewLine & "Movie Database version 1.0")
    End Sub
End Class
