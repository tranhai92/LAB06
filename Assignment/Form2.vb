Imports System.IO
Public Class Form2
    Dim fileName As String = "Data\BangKH.txt"
    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If (KiemTraThongTin() = True) Then
            GhiDuLieu()
            AddToListView()
            ClearBox()
        End If
    End Sub

    Private Sub GhiDuLieu()
        Dim writer As New StreamWriter(fileName, True)
        writer.Write(txtmakh.Text & "\")
        writer.Write(txttenkh.Text & "\")
        writer.Write(txtdiachi.Text & "\")
        writer.Write(cbnguoilh.Text & "\")
        writer.Write(txtsdt.Text & "\")
        writer.WriteLine(txtemail.Text & "\")
        writer.Close()
    End Sub

    Private Sub AddToListView()
        Dim item As New ListViewItem((lstkh.Items.Count + 1).ToString, 0)
        item.SubItems.Add(txtmakh.Text)
        item.SubItems.Add(txttenkh.Text)
        item.SubItems.Add(txtdiachi.Text)
        item.SubItems.Add(cbnguoilh.Text)
        item.SubItems.Add(txtsdt.Text)
        item.SubItems.Add(txtemail.Text)
        lstkh.Items.Add(item)

    End Sub

    Private Sub LayDuLieu()
        lstkh.Items.Clear()
        Dim reader As New StreamReader(fileName)
        Do Until reader.EndOfStream
            Dim motDongDuLieu(6) As String
            motDongDuLieu = reader.ReadLine().Split("\")
            If (motDongDuLieu.Length >= 6) Then
                Dim item As New ListViewItem((lstkh.Items.Count + 1).ToString, 0)
                item.SubItems.Add(motDongDuLieu(0)) 'Ma KH
                item.SubItems.Add(motDongDuLieu(1)) 'Ten KH
                item.SubItems.Add(motDongDuLieu(2)) 'Dia Chi
                item.SubItems.Add(motDongDuLieu(3)) 'Nguoi lien he
                item.SubItems.Add(motDongDuLieu(4)) 'So dien thoai
                item.SubItems.Add(motDongDuLieu(5)) 'Email
                lstkh.Items.Add(item)
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
        txtmakh.Text = ""
        txttenkh.Text = ""
        txtdiachi.Text = ""
        cbnguoilh.Text = ""
        txtsdt.Text = ""
        txtemail.Text = ""
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

    Private Sub lstViewBook_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstkh.SelectedIndexChanged
        If (lstkh.SelectedIndices.Count = 1) Then
            btnDelete.Enabled = True
            btnEdit.Enabled = True
            Dim reader As New StreamReader(fileName)
            Dim index As Integer = 0
            Do Until reader.EndOfStream
                If (index = lstkh.SelectedIndices(0)) Then '2
                    Dim line(6) As String
                    line = reader.ReadLine().Split("\")
                    If (line.Length >= 6) Then
                        txtmakh.Text = line(0)
                        txttenkh.Text = line(1)
                        txtdiachi.Text = line(2)
                        cbnguoilh.Text = line(3)
                        txtsdt.Text = line(4)
                        txtemail.Text = line(5)
                        index += 1
                    End If
                Else
                    reader.ReadLine()
                    index += 1
                End If
            Loop
            reader.Close()
        ElseIf (lstkh.SelectedIndices.Count > 1) Then
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
        For i = lstkh.SelectedIndices.Count() - 1 To 0 Step -1
            arr.RemoveAt(lstkh.SelectedIndices(i))
            lstkh.Items.RemoveAt(lstkh.SelectedIndices(i))
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

        If (lstkh.SelectedIndices.Count() = 1) Then
            arr.RemoveAt(lstkh.SelectedIndices(0))
            arr.Insert(lstkh.SelectedIndices(0), _
              txtmakh.Text & "\" _
              & txttenkh.Text & "\" _
              & txtdiachi.Text & "\" _
              & cbnguoilh.Text & "\" _
              & txtsdt.Text & "\" _
              & txtemail.Text & "\")
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

        If (txtmakh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã khách hàng", "Thông báo")
            Return False
        ElseIf (txttenkh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tên khách hàng", "Thông báo")
            Return False
        ElseIf (txtdiachi.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập địa chỉ khách hàng", "Thông báo")
            Return False
        ElseIf (cbnguoilh.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập người liên hệ", "Thông báo")
            Return False
        ElseIf (txtsdt.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập số điện thoại ", "Thông báo")
        ElseIf (txtemail.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập Email ", "Thông báo")
            Return False

        End If

        Return True
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If (txtmakh.Text.Trim = "") Then
            MessageBox.Show("Vui lòng nhập mã khách hàng cần tìm")
            Return 'Thoát khỏi sự kiện nếu chưa nhập tên sách muốn tìm kiếm
        End If

        Dim index As Integer
        index = TimKiemTrenFile(txtmakh.Text)
        If (index >= 0) Then 'Tìm thấy
            MessageBox.Show("Tên sách bạn đang ở dòng thứ " & (index + 1))
        Else 'index = -1 hay ko thấy
            MessageBox.Show("Không tìm thấy tên sách trong kho dữ liệu")
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

    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmakh.TextChanged
        If (txtmakh.Text.Trim = "") Then
            btnAddNew.Enabled = False
        Else
            btnAddNew.Enabled = True
        End If
    End Sub
End Class