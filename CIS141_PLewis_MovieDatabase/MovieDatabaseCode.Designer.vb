<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class movieDatabase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MOVIE_IDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DirectorLabel As System.Windows.Forms.Label
        Dim Year_ReleasedLabel As System.Windows.Forms.Label
        Dim MaleActorLabel As System.Windows.Forms.Label
        Dim FemaleActorLabel As System.Windows.Forms.Label
        Dim Star_RatingLabel As System.Windows.Forms.Label
        Dim AcademyRatingLabel As System.Windows.Forms.Label
        Dim GenreLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(movieDatabase))
        Me.VideosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.VideosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovieDataSet = New CIS141_PLewis_MovieDatabase.movieDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VideosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VideosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.MOVIE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DirectorTextBox = New System.Windows.Forms.TextBox()
        Me.Year_ReleasedTextBox = New System.Windows.Forms.TextBox()
        Me.MaleActorTextBox = New System.Windows.Forms.TextBox()
        Me.FemaleActorTextBox = New System.Windows.Forms.TextBox()
        Me.Star_RatingTextBox = New System.Windows.Forms.TextBox()
        Me.AcademyRatingTextBox = New System.Windows.Forms.TextBox()
        Me.GenreTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.ShowMoviesSince1995ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ShowMoviesSince1995ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowMoviesBySpielbergToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ShowMoviesBySpielbergToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowThreeStarsAndUpToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ShowThreeStarsAndUpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowFiveStarMoviesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ShowFiveStarMoviesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowAllMoviesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ShowAllMoviesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VideosTableAdapter = New CIS141_PLewis_MovieDatabase.movieDataSetTableAdapters.VideosTableAdapter()
        Me.TableAdapterManager = New CIS141_PLewis_MovieDatabase.movieDataSetTableAdapters.TableAdapterManager()
        Me.aboutButton = New System.Windows.Forms.ToolStripButton()
        Me.updateInstruct = New System.Windows.Forms.Label()
        Me.addInstruct = New System.Windows.Forms.Label()
        MOVIE_IDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        DirectorLabel = New System.Windows.Forms.Label()
        Year_ReleasedLabel = New System.Windows.Forms.Label()
        MaleActorLabel = New System.Windows.Forms.Label()
        FemaleActorLabel = New System.Windows.Forms.Label()
        Star_RatingLabel = New System.Windows.Forms.Label()
        AcademyRatingLabel = New System.Windows.Forms.Label()
        GenreLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        CType(Me.VideosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VideosBindingNavigator.SuspendLayout()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShowMoviesSince1995ToolStrip.SuspendLayout()
        Me.ShowMoviesBySpielbergToolStrip.SuspendLayout()
        Me.ShowThreeStarsAndUpToolStrip.SuspendLayout()
        Me.ShowFiveStarMoviesToolStrip.SuspendLayout()
        Me.ShowAllMoviesToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MOVIE_IDLabel
        '
        MOVIE_IDLabel.AutoSize = True
        MOVIE_IDLabel.Location = New System.Drawing.Point(12, 442)
        MOVIE_IDLabel.Name = "MOVIE_IDLabel"
        MOVIE_IDLabel.Size = New System.Drawing.Size(72, 17)
        MOVIE_IDLabel.TabIndex = 14
        MOVIE_IDLabel.Text = "MOVIE ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(12, 470)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(39, 17)
        TitleLabel.TabIndex = 16
        TitleLabel.Text = "Title:"
        '
        'DirectorLabel
        '
        DirectorLabel.AutoSize = True
        DirectorLabel.Location = New System.Drawing.Point(12, 498)
        DirectorLabel.Name = "DirectorLabel"
        DirectorLabel.Size = New System.Drawing.Size(62, 17)
        DirectorLabel.TabIndex = 18
        DirectorLabel.Text = "Director:"
        '
        'Year_ReleasedLabel
        '
        Year_ReleasedLabel.AutoSize = True
        Year_ReleasedLabel.Location = New System.Drawing.Point(12, 526)
        Year_ReleasedLabel.Name = "Year_ReleasedLabel"
        Year_ReleasedLabel.Size = New System.Drawing.Size(106, 17)
        Year_ReleasedLabel.TabIndex = 20
        Year_ReleasedLabel.Text = "Year Released:"
        '
        'MaleActorLabel
        '
        MaleActorLabel.AutoSize = True
        MaleActorLabel.Location = New System.Drawing.Point(362, 444)
        MaleActorLabel.Name = "MaleActorLabel"
        MaleActorLabel.Size = New System.Drawing.Size(79, 17)
        MaleActorLabel.TabIndex = 22
        MaleActorLabel.Text = "Male Actor:"
        '
        'FemaleActorLabel
        '
        FemaleActorLabel.AutoSize = True
        FemaleActorLabel.Location = New System.Drawing.Point(362, 472)
        FemaleActorLabel.Name = "FemaleActorLabel"
        FemaleActorLabel.Size = New System.Drawing.Size(95, 17)
        FemaleActorLabel.TabIndex = 24
        FemaleActorLabel.Text = "Female Actor:"
        '
        'Star_RatingLabel
        '
        Star_RatingLabel.AutoSize = True
        Star_RatingLabel.Location = New System.Drawing.Point(362, 500)
        Star_RatingLabel.Name = "Star_RatingLabel"
        Star_RatingLabel.Size = New System.Drawing.Size(83, 17)
        Star_RatingLabel.TabIndex = 26
        Star_RatingLabel.Text = "Star Rating:"
        '
        'AcademyRatingLabel
        '
        AcademyRatingLabel.AutoSize = True
        AcademyRatingLabel.Location = New System.Drawing.Point(362, 528)
        AcademyRatingLabel.Name = "AcademyRatingLabel"
        AcademyRatingLabel.Size = New System.Drawing.Size(115, 17)
        AcademyRatingLabel.TabIndex = 28
        AcademyRatingLabel.Text = "Academy Rating:"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Location = New System.Drawing.Point(362, 556)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(49, 17)
        GenreLabel.TabIndex = 30
        GenreLabel.Text = "genre:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(362, 584)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(81, 17)
        SupplierIDLabel.TabIndex = 32
        SupplierIDLabel.Text = "Supplier ID:"
        '
        'VideosBindingNavigator
        '
        Me.VideosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VideosBindingNavigator.BindingSource = Me.VideosBindingSource
        Me.VideosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VideosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VideosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VideosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VideosBindingNavigatorSaveItem, Me.aboutButton})
        Me.VideosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VideosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VideosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VideosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VideosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VideosBindingNavigator.Name = "VideosBindingNavigator"
        Me.VideosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VideosBindingNavigator.Size = New System.Drawing.Size(1354, 27)
        Me.VideosBindingNavigator.TabIndex = 0
        Me.VideosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'VideosBindingSource
        '
        Me.VideosBindingSource.DataMember = "Videos"
        Me.VideosBindingSource.DataSource = Me.MovieDataSet
        '
        'MovieDataSet
        '
        Me.MovieDataSet.DataSetName = "movieDataSet"
        Me.MovieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'VideosBindingNavigatorSaveItem
        '
        Me.VideosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VideosBindingNavigatorSaveItem.Image = CType(resources.GetObject("VideosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VideosBindingNavigatorSaveItem.Name = "VideosBindingNavigatorSaveItem"
        Me.VideosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.VideosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VideosDataGridView
        '
        Me.VideosDataGridView.AutoGenerateColumns = False
        Me.VideosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VideosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.VideosDataGridView.DataSource = Me.VideosBindingSource
        Me.VideosDataGridView.Location = New System.Drawing.Point(12, 199)
        Me.VideosDataGridView.Name = "VideosDataGridView"
        Me.VideosDataGridView.RowHeadersWidth = 51
        Me.VideosDataGridView.RowTemplate.Height = 24
        Me.VideosDataGridView.Size = New System.Drawing.Size(1317, 227)
        Me.VideosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MOVIE ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MOVIE ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Director"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Director"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Year_Released"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Year_Released"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MaleActor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MaleActor"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FemaleActor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FemaleActor"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Star Rating"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Star Rating"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "AcademyRating"
        Me.DataGridViewTextBoxColumn8.HeaderText = "AcademyRating"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "genre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "genre"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(1175, 584)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(100, 23)
        Me.AddButton.TabIndex = 13
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(765, 584)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(100, 23)
        Me.deleteButton.TabIndex = 14
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'MOVIE_IDTextBox
        '
        Me.MOVIE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "MOVIE ID", True))
        Me.MOVIE_IDTextBox.Location = New System.Drawing.Point(133, 439)
        Me.MOVIE_IDTextBox.Name = "MOVIE_IDTextBox"
        Me.MOVIE_IDTextBox.Size = New System.Drawing.Size(223, 22)
        Me.MOVIE_IDTextBox.TabIndex = 15
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(133, 467)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(223, 22)
        Me.TitleTextBox.TabIndex = 17
        '
        'DirectorTextBox
        '
        Me.DirectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Director", True))
        Me.DirectorTextBox.Location = New System.Drawing.Point(133, 495)
        Me.DirectorTextBox.Name = "DirectorTextBox"
        Me.DirectorTextBox.Size = New System.Drawing.Size(223, 22)
        Me.DirectorTextBox.TabIndex = 19
        '
        'Year_ReleasedTextBox
        '
        Me.Year_ReleasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Year_Released", True))
        Me.Year_ReleasedTextBox.Location = New System.Drawing.Point(133, 523)
        Me.Year_ReleasedTextBox.Name = "Year_ReleasedTextBox"
        Me.Year_ReleasedTextBox.Size = New System.Drawing.Size(223, 22)
        Me.Year_ReleasedTextBox.TabIndex = 21
        '
        'MaleActorTextBox
        '
        Me.MaleActorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "MaleActor", True))
        Me.MaleActorTextBox.Location = New System.Drawing.Point(483, 441)
        Me.MaleActorTextBox.Name = "MaleActorTextBox"
        Me.MaleActorTextBox.Size = New System.Drawing.Size(247, 22)
        Me.MaleActorTextBox.TabIndex = 23
        '
        'FemaleActorTextBox
        '
        Me.FemaleActorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "FemaleActor", True))
        Me.FemaleActorTextBox.Location = New System.Drawing.Point(483, 469)
        Me.FemaleActorTextBox.Name = "FemaleActorTextBox"
        Me.FemaleActorTextBox.Size = New System.Drawing.Size(247, 22)
        Me.FemaleActorTextBox.TabIndex = 25
        '
        'Star_RatingTextBox
        '
        Me.Star_RatingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Star Rating", True))
        Me.Star_RatingTextBox.Location = New System.Drawing.Point(483, 497)
        Me.Star_RatingTextBox.Name = "Star_RatingTextBox"
        Me.Star_RatingTextBox.Size = New System.Drawing.Size(247, 22)
        Me.Star_RatingTextBox.TabIndex = 27
        '
        'AcademyRatingTextBox
        '
        Me.AcademyRatingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "AcademyRating", True))
        Me.AcademyRatingTextBox.Location = New System.Drawing.Point(483, 525)
        Me.AcademyRatingTextBox.Name = "AcademyRatingTextBox"
        Me.AcademyRatingTextBox.Size = New System.Drawing.Size(247, 22)
        Me.AcademyRatingTextBox.TabIndex = 29
        '
        'GenreTextBox
        '
        Me.GenreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "genre", True))
        Me.GenreTextBox.Location = New System.Drawing.Point(483, 553)
        Me.GenreTextBox.Name = "GenreTextBox"
        Me.GenreTextBox.Size = New System.Drawing.Size(247, 22)
        Me.GenreTextBox.TabIndex = 31
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(483, 581)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(247, 22)
        Me.SupplierIDTextBox.TabIndex = 33
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(765, 546)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(93, 24)
        Me.updateButton.TabIndex = 34
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'ShowMoviesSince1995ToolStrip
        '
        Me.ShowMoviesSince1995ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ShowMoviesSince1995ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMoviesSince1995ToolStripButton})
        Me.ShowMoviesSince1995ToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.ShowMoviesSince1995ToolStrip.Name = "ShowMoviesSince1995ToolStrip"
        Me.ShowMoviesSince1995ToolStrip.Size = New System.Drawing.Size(1354, 27)
        Me.ShowMoviesSince1995ToolStrip.TabIndex = 35
        Me.ShowMoviesSince1995ToolStrip.Text = "ShowMoviesSince1995ToolStrip"
        '
        'ShowMoviesSince1995ToolStripButton
        '
        Me.ShowMoviesSince1995ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowMoviesSince1995ToolStripButton.Name = "ShowMoviesSince1995ToolStripButton"
        Me.ShowMoviesSince1995ToolStripButton.Size = New System.Drawing.Size(133, 24)
        Me.ShowMoviesSince1995ToolStripButton.Text = "Movies since 1995"
        '
        'ShowMoviesBySpielbergToolStrip
        '
        Me.ShowMoviesBySpielbergToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ShowMoviesBySpielbergToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMoviesBySpielbergToolStripButton})
        Me.ShowMoviesBySpielbergToolStrip.Location = New System.Drawing.Point(0, 54)
        Me.ShowMoviesBySpielbergToolStrip.Name = "ShowMoviesBySpielbergToolStrip"
        Me.ShowMoviesBySpielbergToolStrip.Size = New System.Drawing.Size(1354, 27)
        Me.ShowMoviesBySpielbergToolStrip.TabIndex = 36
        Me.ShowMoviesBySpielbergToolStrip.Text = "ShowMoviesBySpielbergToolStrip"
        '
        'ShowMoviesBySpielbergToolStripButton
        '
        Me.ShowMoviesBySpielbergToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowMoviesBySpielbergToolStripButton.Name = "ShowMoviesBySpielbergToolStripButton"
        Me.ShowMoviesBySpielbergToolStripButton.Size = New System.Drawing.Size(206, 24)
        Me.ShowMoviesBySpielbergToolStripButton.Text = "Directed by Steven Spielberg"
        '
        'ShowThreeStarsAndUpToolStrip
        '
        Me.ShowThreeStarsAndUpToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ShowThreeStarsAndUpToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowThreeStarsAndUpToolStripButton})
        Me.ShowThreeStarsAndUpToolStrip.Location = New System.Drawing.Point(0, 81)
        Me.ShowThreeStarsAndUpToolStrip.Name = "ShowThreeStarsAndUpToolStrip"
        Me.ShowThreeStarsAndUpToolStrip.Size = New System.Drawing.Size(1354, 27)
        Me.ShowThreeStarsAndUpToolStrip.TabIndex = 37
        Me.ShowThreeStarsAndUpToolStrip.Text = "ShowThreeStarsAndUpToolStrip"
        '
        'ShowThreeStarsAndUpToolStripButton
        '
        Me.ShowThreeStarsAndUpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowThreeStarsAndUpToolStripButton.Name = "ShowThreeStarsAndUpToolStripButton"
        Me.ShowThreeStarsAndUpToolStripButton.Size = New System.Drawing.Size(138, 24)
        Me.ShowThreeStarsAndUpToolStripButton.Text = "Three Stars and Up"
        '
        'ShowFiveStarMoviesToolStrip
        '
        Me.ShowFiveStarMoviesToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ShowFiveStarMoviesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowFiveStarMoviesToolStripButton})
        Me.ShowFiveStarMoviesToolStrip.Location = New System.Drawing.Point(0, 108)
        Me.ShowFiveStarMoviesToolStrip.Name = "ShowFiveStarMoviesToolStrip"
        Me.ShowFiveStarMoviesToolStrip.Size = New System.Drawing.Size(1354, 27)
        Me.ShowFiveStarMoviesToolStrip.TabIndex = 38
        Me.ShowFiveStarMoviesToolStrip.Text = "Five Star Movies"
        '
        'ShowFiveStarMoviesToolStripButton
        '
        Me.ShowFiveStarMoviesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowFiveStarMoviesToolStripButton.Name = "ShowFiveStarMoviesToolStripButton"
        Me.ShowFiveStarMoviesToolStripButton.Size = New System.Drawing.Size(120, 24)
        Me.ShowFiveStarMoviesToolStripButton.Text = "Five Star Movies"
        '
        'ShowAllMoviesToolStrip
        '
        Me.ShowAllMoviesToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ShowAllMoviesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAllMoviesToolStripButton})
        Me.ShowAllMoviesToolStrip.Location = New System.Drawing.Point(0, 135)
        Me.ShowAllMoviesToolStrip.Name = "ShowAllMoviesToolStrip"
        Me.ShowAllMoviesToolStrip.Size = New System.Drawing.Size(1354, 27)
        Me.ShowAllMoviesToolStrip.TabIndex = 39
        Me.ShowAllMoviesToolStrip.Text = "ShowAllMoviesToolStrip"
        '
        'ShowAllMoviesToolStripButton
        '
        Me.ShowAllMoviesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowAllMoviesToolStripButton.Name = "ShowAllMoviesToolStripButton"
        Me.ShowAllMoviesToolStripButton.Size = New System.Drawing.Size(122, 24)
        Me.ShowAllMoviesToolStripButton.Text = "Show All Movies"
        '
        'VideosTableAdapter
        '
        Me.VideosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = CIS141_PLewis_MovieDatabase.movieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VideosTableAdapter = Me.VideosTableAdapter
        '
        'aboutButton
        '
        Me.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.aboutButton.Image = CType(resources.GetObject("aboutButton.Image"), System.Drawing.Image)
        Me.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(54, 24)
        Me.aboutButton.Text = "About"
        '
        'updateInstruct
        '
        Me.updateInstruct.AutoSize = True
        Me.updateInstruct.Location = New System.Drawing.Point(765, 465)
        Me.updateInstruct.Name = "updateInstruct"
        Me.updateInstruct.Size = New System.Drawing.Size(544, 17)
        Me.updateInstruct.TabIndex = 40
        Me.updateInstruct.Text = "To update or delete, edit information on the left and click the apprioriate butto" &
    "n below"
        '
        'addInstruct
        '
        Me.addInstruct.AutoSize = True
        Me.addInstruct.Location = New System.Drawing.Point(755, 495)
        Me.addInstruct.Name = "addInstruct"
        Me.addInstruct.Size = New System.Drawing.Size(574, 17)
        Me.addInstruct.TabIndex = 41
        Me.addInstruct.Text = "To add a movie, enter the information on the last (empty) line above and click ""A" &
    "dd"" below"
        Me.addInstruct.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'movieDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 619)
        Me.Controls.Add(Me.addInstruct)
        Me.Controls.Add(Me.updateInstruct)
        Me.Controls.Add(Me.ShowAllMoviesToolStrip)
        Me.Controls.Add(Me.ShowFiveStarMoviesToolStrip)
        Me.Controls.Add(Me.ShowThreeStarsAndUpToolStrip)
        Me.Controls.Add(Me.ShowMoviesBySpielbergToolStrip)
        Me.Controls.Add(Me.ShowMoviesSince1995ToolStrip)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(MOVIE_IDLabel)
        Me.Controls.Add(Me.MOVIE_IDTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(DirectorLabel)
        Me.Controls.Add(Me.DirectorTextBox)
        Me.Controls.Add(Year_ReleasedLabel)
        Me.Controls.Add(Me.Year_ReleasedTextBox)
        Me.Controls.Add(MaleActorLabel)
        Me.Controls.Add(Me.MaleActorTextBox)
        Me.Controls.Add(FemaleActorLabel)
        Me.Controls.Add(Me.FemaleActorTextBox)
        Me.Controls.Add(Star_RatingLabel)
        Me.Controls.Add(Me.Star_RatingTextBox)
        Me.Controls.Add(AcademyRatingLabel)
        Me.Controls.Add(Me.AcademyRatingTextBox)
        Me.Controls.Add(GenreLabel)
        Me.Controls.Add(Me.GenreTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDTextBox)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.VideosDataGridView)
        Me.Controls.Add(Me.VideosBindingNavigator)
        Me.Name = "movieDatabase"
        Me.Text = "Movie Database"
        CType(Me.VideosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VideosBindingNavigator.ResumeLayout(False)
        Me.VideosBindingNavigator.PerformLayout()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShowMoviesSince1995ToolStrip.ResumeLayout(False)
        Me.ShowMoviesSince1995ToolStrip.PerformLayout()
        Me.ShowMoviesBySpielbergToolStrip.ResumeLayout(False)
        Me.ShowMoviesBySpielbergToolStrip.PerformLayout()
        Me.ShowThreeStarsAndUpToolStrip.ResumeLayout(False)
        Me.ShowThreeStarsAndUpToolStrip.PerformLayout()
        Me.ShowFiveStarMoviesToolStrip.ResumeLayout(False)
        Me.ShowFiveStarMoviesToolStrip.PerformLayout()
        Me.ShowAllMoviesToolStrip.ResumeLayout(False)
        Me.ShowAllMoviesToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MovieDataSet As movieDataSet
    Friend WithEvents VideosBindingSource As BindingSource
    Friend WithEvents VideosTableAdapter As movieDataSetTableAdapters.VideosTableAdapter
    Friend WithEvents TableAdapterManager As movieDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VideosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VideosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VideosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents AddButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents MOVIE_IDTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents DirectorTextBox As TextBox
    Friend WithEvents Year_ReleasedTextBox As TextBox
    Friend WithEvents MaleActorTextBox As TextBox
    Friend WithEvents FemaleActorTextBox As TextBox
    Friend WithEvents Star_RatingTextBox As TextBox
    Friend WithEvents AcademyRatingTextBox As TextBox
    Friend WithEvents GenreTextBox As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents updateButton As Button
    Friend WithEvents ShowMoviesSince1995ToolStrip As ToolStrip
    Friend WithEvents ShowMoviesSince1995ToolStripButton As ToolStripButton
    Friend WithEvents ShowMoviesBySpielbergToolStrip As ToolStrip
    Friend WithEvents ShowMoviesBySpielbergToolStripButton As ToolStripButton
    Friend WithEvents ShowThreeStarsAndUpToolStrip As ToolStrip
    Friend WithEvents ShowThreeStarsAndUpToolStripButton As ToolStripButton
    Friend WithEvents ShowFiveStarMoviesToolStrip As ToolStrip
    Friend WithEvents ShowFiveStarMoviesToolStripButton As ToolStripButton
    Friend WithEvents ShowAllMoviesToolStrip As ToolStrip
    Friend WithEvents ShowAllMoviesToolStripButton As ToolStripButton
    Friend WithEvents aboutButton As ToolStripButton
    Friend WithEvents updateInstruct As Label
    Friend WithEvents addInstruct As Label
End Class
