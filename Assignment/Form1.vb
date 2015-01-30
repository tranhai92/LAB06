Imports System.IO

Public Class Form1
    Dim fileName As String = "Data\BangHH.txt"
    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If (KiemTraThongTin() = True) Then
            GhiDuLieu()
            AddToListView()
            ClearBox()
        End If
    End Sub

    Private Sub GhiDuLieu()
        Dim writer As New IO.StreamWriter(fileName, True)
        writer.Write(txtmahang.Text & "\")
        writer.Write(txttenhang.Text & "\")
        writer.Write(cbdonvitinh.Text & "\")
        writer.WriteLine(cbmaloaihang.Text & "\")
        writer.Close()
    End Sub

    Private Sub AddToListView()
        Dim item As New ListViewItem((lstnv.Items.Count + 1).ToString, 0)
        item.SubItems.Add(txtmahang.Text)
        item.SubItems.Add(txttenhang.Text)
        item.SubItems.Add(cbdonvitinh.Text)
        item.SubItems.Add(cbmaloaihang.Text)
        lstnv.Items.Add(item)

    End Sub

    Private Sub LayDuLieu()
        lstnv.Items.Clear()
        Dim reader As New StreamReader(fileName)
        Do Until reader.EndOfStream
            Dim motDongDuLieu(6) As String
            motDongDuLieu = reader.ReadLine().Split("\")
            If (motDongDuLieu.Length >= 6) Then
                Dim item As New ListViewItem((lstnv.Items.Count + 1).ToString, 0)
                item.SubItems.Add(motDongDuLieu(0)) 'Ma KH
                item.SubItems.Add(motDongDuLieu(1)) 'Ten KH
                item.SubItems.Add(motDongDuLieu(2)) 'Dia Chi
                item.SubItems.Add(motDongDuLieu(3)) 'Nguoi lien he
                item.SubItems.Add(motDongDuLieu(4)) 'So dien thoai
                item.SubItems.Add(motDongDuLieu(5)) 'Email
                lstnv.Items.Add(item)
            End If
        Loop
        reader.Close()
    End Sub


    Private Sub frmkh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LayDuLieu()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (dialogResult = Windows.Forms.DialogResult.Yes) Then
            Close()
        End If
    End Sub


    Private Sub ClearBox()
        txtmahang.Text = ""
        txttenhang.Text = ""
        cbdonvitinh.Text = ""
        cbmaloaihang.Text = ""

    End Sub

    Function DocFileTraVeArrayList() As ArrayList
        Dim reader As New StreamReader(fileName)
        Dim arr As New ArrayList
        Do Until reader.EndOfStream
            arr.Add(reader.ReadLine())
        Loop
        reader.Close()
        Return arr
    End Function

    Private Sub lstViewBook_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstnv.SelectedIndexChanged
        If (lstnv.SelectedIndices.Count = 1) Then
            btnDelete.Enabled = True
            btnEdit.Enabled = True
            Dim reader As New StreamReader(fileName)
            Dim index As Integer = 0
            Do Until reader.EndOfStream
                If (index = lstnv.SelectedIndices(0)) Then '2
                    Dim line(3) As String
                    line = reader.ReadLine().Split("\")
                    If (line.Length >= 3) Then
                        txtmahang.Text = line(0)
                        txttenhang.Text = line(1)
                        cbdonvitinh.Text = line(2)
                        cbmaloaihang.Text = line(3)
                        index += 1
                    End If
                Else
                    reader.ReadLine()
                    index += 1
                End If
            Loop
            reader.Close()
        ElseIf (lstnv.SelectedIndices.Count > 1) Then
            btnDelete.Enabled = True
            btnEdit.Enabled = False
            ClearBox()
        Else
            btnDelete.Enabled = False
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim arr As New ArrayList
        arr = DocFileTraVeArrayList()
        'Duyệt mảng các vị trí đc chọn
        'Duyệt từ dưới lên
        For i = lstnv.SelectedIndices.Count() - 1 To 0 Step -1
            arr.RemoveAt(lstnv.SelectedIndices(i))
            lstnv.Items.RemoveAt(lstnv.SelectedIndices(i))
        Next

        WriteArrayListToFile(arr)
        LayDuLieu()
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If (KiemTraThongTin() = False) Then
            Return 'Nếu thông tin không đầy đủ thì thoát sự kiện. Không thực hiện các lệnh bên dưới
        End If

        Dim arr As New ArrayList
        arr = DocFileTraVeArrayList()

        If (lstnv.SelectedIndices.Count() = 1) Then
            arr.RemoveAt(lstnv.SelectedIndices(0))
            arr.Insert(lstnv.SelectedIndices(0), _
              txtmahang.Text & "\" _
              & txttenhang.Text & "\" _
              & cbdonvitinh.Text & "\" _
              & cbmaloaihang.Text & "\")
            WriteArrayListToFile(arr)
            LayDuLieu()
            ClearBox()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    'Hàm ghi nội dung vào File
    Private Sub WriteArrayListToFile(ByVal arr As ArrayList)
        Dim writer As New StreamWriter(fileName)

        For i = 0 To arr.Count() - 1
            'GhiDuLieu từng dòng xuống file
            writer.WriteLine(arr.Item(i))
            'MessageBox.Show(arr.Item(i))

        Next
        writer.Close()

    End Sub

    'Hàm kiểm tra thông tin. Nếu thông tin đầy đủ thì trả về là True, ngược lại False 
    Private Function KiemTraThongTin() As Boolean

        If (txtmahang.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã hàng", "Thông báo")
            Return False
        ElseIf (txttenhang.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tên hàng", "Thông báo")
            Return False
        ElseIf (cbdonvitinh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập đơn vị tính", "Thông báo")
            Return False
        ElseIf (cbmaloaihang.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập mã loại hàng", "Thông báo")
            Return False

        End If

        Return True
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If (txtmahang.Text.Trim = "") Then
            MessageBox.Show("Vui lòng nhập mã khách hàng cần tìm")
            Return 'Thoát khỏi sự kiện nếu chưa nhập tên sách muốn tìm kiếm
        End If

        Dim index As Integer
        index = TimKiemTrenFile(txtmahang.Text)
        If (index >= 0) Then 'Tìm thấy
            MessageBox.Show("Tên hàng hóa bạn đang tìm kiếm ở dòng thứ " & (index + 1))
        Else 'index = -1 hay ko thấy
            MessageBox.Show("Không tìm thấy tên hàng hóa trong kho dữ liệu")
        End If
    End Sub

    'Hàm tìm kiếm tên sách trên file Text, hàm trả về dòng tìm thấy là 0 hay 1, 2, 3.... Nếu ko tìm thấy trả về -1
    'Hàm tìm kiếm gần đúng
    Private Function TimKiemTrenFile(ByVal keyword As String) As Integer
        Dim reader As New StreamReader(fileName)
        Dim index As Integer = 0 'Chỉ số của dòng. Kết quả sẽ trả về sau khi tìm kiếm xong
        Dim line(6) As String

        Do Until reader.EndOfStream
            line = reader.ReadLine().Split("\")
            If (line.Length >= 6) Then
                If (line(0).Trim.ToLower.Contains(keyword.Trim.ToLower)) Then 'Bỏ ký tự khoảng trắng phía sau và chuyển tất cả về chữ thường để so sánh
                    Return index 'Trả về chỉ số dòng tìm thấy
                End If
            End If
            index += 1 'Tăng chỉ số dòng lên 1
        Loop
        reader.Close()

        Return -1
    End Function

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmahang.TextChanged, txtmahang.TextChanged
        If (txtmahang.Text.Trim = "") Then
            btnAddNew.Enabled = False
        Else
            btnAddNew.Enabled = True
        End If
    End Sub
End Class
