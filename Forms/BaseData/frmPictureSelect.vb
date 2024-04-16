Imports System.IO
Imports AssetsManager.Misc

Public Class frmPictureSelect
    Dim _pictures As List(Of Picture) = New List(Of Picture)
    Dim currentPicture As Picture = Nothing
    Public Property selectedImage As Picture
    Private Sub frmPictureSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Sub loadData()
        _pictures = New List(Of Picture)
        For Each picData As DataRow In SQLDriver.sqlExeQuery("SELECT id,pic_name FROM INV_pictures WHERE pic_name not like '%_mini_%'").Rows
            Dim imageData = DirectCast(SQLDriver.sqlExeQueryScalar("SELECT picture FROM INV_pictures WHERE id =" & picData.ItemArray(0)), Byte())
            Dim img As Image = Nothing

            If imageData IsNot Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    img = Image.FromStream(ms, True)
                End Using
            End If

            _pictures.Add(New Picture(picData.ItemArray(1), img, picData.ItemArray(0)))
            cbImageSelect.Items.Add(New DictionaryEntry(picData.ItemArray(1), picData.ItemArray(0)))
        Next

    End Sub

    Private Sub cbImageSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbImageSelect.SelectedValueChanged
        If cbImageSelect.SelectedItem IsNot Nothing Then
            pbImage.Image = _pictures.Find(Function(c) c.id = CInt(cbImageSelect.SelectedItem.value)).image
            currentPicture = _pictures.Find(Function(c) c.id = CInt(cbImageSelect.SelectedItem.value))
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim img = Image.FromFile(OpenFileDialog1.FileName)
            If img.PhysicalDimension.Width > 600 Or img.PhysicalDimension.Height > 600 Then
                MsgBox("Obrazek za duży! Max 600x600 px.")
                Exit Sub
            End If
            pbImage.Image = img
            Dim pic = New Picture(System.IO.Path.GetFileName(OpenFileDialog1.FileName), img)
            'Dim picMini = New Picture(System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName) & "_mini_" & System.IO.Path.GetExtension(OpenFileDialog1.FileName), img)

            SQLDriver.sqlAddImage(pic)
            'SQLDriver.sqlAddImage(picMini)


            loadData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cbImageSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbImageSelect.SelectedIndexChanged
        pbImage.Image = SQLDriver.sqlRetreiveImage(cbImageSelect.SelectedItem.value)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        selectedImage = currentPicture
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cbImageSelect.SelectedItem IsNot Nothing Then
            If Not SQLDriver.sqlDeleteImage(cbImageSelect.SelectedItem.value) Then
                MsgBox("Ten obraz jest w użyciu!")
            End If
        End If
    End Sub
End Class