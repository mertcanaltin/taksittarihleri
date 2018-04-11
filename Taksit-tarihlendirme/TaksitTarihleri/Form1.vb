Public Class Form1


    Private Sub TaksitlendirButton_Click(sender As Object, e As EventArgs) Handles TaksitlendirButton.Click
        Dim Fiyat, TaksitTutari As Decimal
        Dim TaksitSayisi As Byte
        Dim Tarih, TaksitTarihi As Date
        Fiyat = CDec(FiyatTextBox.Text)
        TaksitSayisi = CByte(TSayiTextBox.Text)
        Tarih = CDate(TTarihTextBox.Text)
        TaksitTutari = Math.Round(Fiyat / TaksitSayisi, 2)
        TaksitlerListBox.Items.Clear()
        For i = 0 To TaksitSayisi - 1
            TaksitTarihi = Tarih.AddMonths(i)
            If TaksitTarihi.DayOfWeek = DayOfWeek.Sunday Then
                TaksitTarihi = DateAdd(DateInterval.Day, -1, TaksitTarihi)
                'TaksitTarihi = TaksitTarihi.AddDays(-1)
            End If
            TaksitlerListBox.Items.Add(TaksitTarihi & ";" & TaksitTutari)
        Next
    End Sub
End Class
